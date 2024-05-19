Imports System.Data.Common
Imports System.Diagnostics.PerformanceData
Imports System.Drawing.Text
Imports System.Reflection.Emit
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Runtime.Intrinsics.Arm
Imports System.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Permissions
Imports System.Threading
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class BattleShipsGame
    Dim currentPlayer As Integer
    Dim gameOver As Boolean
    Dim boardEmpty As Boolean
    Dim gridCircleSizeNum As Integer
    Public playergameArray(14, 14) As Integer
    Public playerpictureBoxArray(14, 14) As PictureBox
    Public opponentgameArray(14, 14) As Integer
    Public opponentpictureBoxArray(14, 14) As PictureBox
    Public score As Integer
    Dim boardSizes As Short
    Dim startOfBoardPosX As Integer
    Dim startOfOpponentBoardPosY As Integer
    Dim startOfPlayerBoardPosY As Integer
    Dim gridOffSet As Integer
    Dim turnsbannerHeight As Short
    Dim has3alreadydone As Boolean
    Dim playerextraTurn As Boolean
    Dim computerextraTurn As Boolean
    Dim hasAHit As Boolean
    Dim previousHit As Boolean
    Dim computerStage As Integer
    Dim oppositePath As Boolean
    Dim NextShip As Boolean
    Dim duplicateShip As Boolean
    Dim time As Integer
    Dim displayTime As String
    Dim playerMissCount As Integer
    Dim playerHitCount As Integer
    Dim opponentMissCount As Integer
    Dim opponentHitCount As Integer
    Dim playershipSunkCount As Integer
    Dim playershipHitListCount As Integer
    Public Structure recHighScore
        Public name As String
        Public score As Integer
        Public time As String
        Public difficulty As String
    End Structure
    Public Structure shipGridLocations
        Public X As Integer
        Public Y As Integer
        Public isHit As Boolean
    End Structure
    Public Structure gridLocation
        Public X As Integer
        Public Y As Integer
    End Structure

    Public arrHighScores(11) As recHighScore
    Public hasAhitLocation As gridLocation
    Public opponentShip2(2) As shipGridLocations
    Public opponentShip3a(3) As shipGridLocations
    Public opponentShip3b(3) As shipGridLocations
    Public opponentShip4(4) As shipGridLocations
    Public opponentShip5(5) As shipGridLocations
    Public playerShip2(2) As shipGridLocations
    Public playerShip3a(3) As shipGridLocations
    Public playerShip3b(3) As shipGridLocations
    Public playerShip4(4) As shipGridLocations
    Public playerShip5(5) As shipGridLocations
    Public opponentShipSunkArr(5) As Boolean
    Public playerShipSunkArr(5) As Boolean
    Public alreadyLeft As Boolean
    Public alreadyRight As Boolean
    Public alreadyUp As Boolean
    Public alreadyDown As Boolean
    Public opponentMoveDirection As Integer
    Public opponentContinueOnCount As Integer

    ''' <summary>
    ''' Subroutine updates the form's global variables from the module of global variables 
    ''' Is called by the gameSettings Form
    ''' Example of use: updateGlobalVars("John",10,"Normal",True,0)
    ''' </summary>
    ''' <param name="name">A string representing the player's name. Eg. "John"</param>
    ''' <param name="size">An integer representing the number of grid circles in the game. Eg. 10: the board would be 10x10 grid circles in size.</param>
    ''' <param name="userDifficulty">A string representing the difficulty the user has chosen. Eg. "Normal"</param>
    ''' <param name="timeOption">A boolean representing whether the user has chosen to have a timer or a stopwatch. For True: a stopwatch (counting up), and for False a timer (counting down)</param>
    ''' <param name="timeSet">The time the user has set, if they have chosen the 'timer'. Otherwise (for above timeOption as True): is 0</param>
    Public Sub updateGlobalVars(name As String, size As Integer, userDifficulty As String, timeOption As Boolean, timeSet As Integer)
        'Updating the global variables from across forms
        playerName = name
        gridSize = size
        difficulty = userDifficulty
        timeOptionAsCountUp = timeOption
        timeLeft = timeSet
        formID = "Game"
    End Sub

    ''' <summary>
    ''' Subroutine is the mainline for the intialisation of the form and to get the game ready to play.
    ''' </summary>
    Public Sub onFormLoad()
        gameTimer.Stop()
        timeInitialise()

        initialiseFormControls()
        initialiseVariables()

        'reset the boards before generating a new board
        opponentgameArray = resetGameArray(opponentgameArray)
        playergameArray = resetGameArray(playergameArray)

        'Generate the array of picture boxes that represents the game array 
        generatePicture(opponentpictureBoxArray, OpponentBoardBGImg, 2)
        generatePicture(playerpictureBoxArray, PlayerBoardBGImg, 1)

        'generate the 2D array: gameArray randomly (both computer and Player)
        generateGameArr(opponentgameArray, 2)
        generateGameArr(playergameArray, 1)

        'Assign the correct grid images for the picture box array to be represent the game array
        assignGridImages(opponentgameArray, opponentpictureBoxArray, "opponent")
        assignGridImages(playergameArray, playerpictureBoxArray, "player")

        currentPlayer = 1
    End Sub

    ''' <summary>
    ''' Subroutine initialises all the public variables
    ''' </summary>
    Private Sub initialiseVariables()
        Dim playerMissCount As Integer
        Dim playerHitCount As Integer
        Dim opponentMissCount As Integer
        Dim opponentHitCount As Integer
        Dim playershipSunkCount As Integer
        Dim i As Integer

        playerMissCount = 0
        playerHitCount = 0
        opponentMissCount = 0
        opponentHitCount = 0
        playershipSunkCount = 0
        i = 0

        updateGameStats(playerHitCount, playerMissCount, 1)
        updateGameStats(opponentHitCount, opponentMissCount, 2)

        'Initialise all the global variable
        For i = 1 To 5
            opponentShipSunkArr(i) = False
            playerShipSunkArr(i) = False
        Next i
        hasAHit = False
        hasAhitLocation.X = 0
        hasAhitLocation.Y = 0
        previousHit = False
        computerStage = 0
        oppositePath = False
        NextShip = False
        opponentContinueOnCount = 1
        alreadyLeft = False
        alreadyRight = False
        alreadyUp = False
        alreadyDown = False
        opponentMoveDirection = 0

        'Go through every element all the individual ship records and set the X and Y field to 0 and the isHit to False
        For i = 1 To 2
            opponentShip2(i).X = 0
            opponentShip2(i).Y = 0
            opponentShip2(i).isHit = False
            playerShip2(i).X = 0
            playerShip2(i).Y = 0
            playerShip2(i).isHit = False
        Next i
        For i = 1 To 3
            opponentShip3a(i).X = 0
            opponentShip3a(i).Y = 0
            opponentShip3a(i).isHit = False
            playerShip3a(i).X = 0
            playerShip3a(i).Y = 0
            playerShip3a(i).isHit = False
            opponentShip3b(i).X = 0
            opponentShip3b(i).Y = 0
            opponentShip3b(i).isHit = False
            playerShip3b(i).X = 0
            playerShip3b(i).Y = 0
            playerShip3b(i).isHit = False
        Next i
        For i = 1 To 4
            opponentShip4(i).X = 0
            opponentShip4(i).Y = 0
            opponentShip4(i).isHit = False
            playerShip4(i).X = 0
            playerShip4(i).Y = 0
            playerShip4(i).isHit = False
        Next i
        For i = 1 To 5
            opponentShip5(i).X = 0
            opponentShip5(i).Y = 0
            opponentShip5(i).isHit = False
            playerShip5(i).X = 0
            playerShip5(i).Y = 0
            playerShip5(i).isHit = False
        Next i
        playershipHitListCount = 5
    End Sub

    ''' <summary>
    ''' Subroutine Initialises all the controls on the form in the correct locations and sizes and images
    ''' </summary>
    Private Sub initialiseFormControls()
        'To initialise the screen size as the fullscreen display size of the user
        Me.WindowState = FormWindowState.Maximized
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)

        'To force the game to a 1528x960 window unless already that resolution in fullscreen
        If Me.Width <> 1528 And Me.Height <> 960 Then
            Me.WindowState = FormWindowState.Normal
            Me.Size = New Size(1528, 960)
        End If

        'Variables to be used for the placement of controls
        Dim turnsbannerWidth As Short
        Dim turnsbannerXloc As Short
        Dim turnsbannerYLoc As Short
        turnsbannerWidth = 330
        turnsbannerHeight = 45
        turnsbannerXloc = Me.Width / 2 - (turnsbannerWidth / 2)
        turnsbannerYLoc = (Me.Height / 2 - (turnsbannerHeight / 2)) - 40
        boardSizes = turnsbannerYLoc - ((turnsbannerHeight / 2) - 9)

        backgroundImg.ImageLocation = Application.StartupPath & "\Pictures\gameBackground.png"
        backgroundImg.Location = New Point(0, 0)
        backgroundImg.Size = New Size(Me.Width - 15, Me.Height - 38)
        backgroundImg.Load(backgroundImg.ImageLocation)

        'Setting the placement and size of controls on the form
        backtomainbtn.Location = New Point(Me.Width - (100 + 42), Me.Height - (60 + 64))
        resetbtn.Location = New Point(Me.Width - (200 + 42), Me.Height - (60 + 64))

        OpponentBoardBGImg.Location = New Point((Me.Width / 2) - (boardSizes / 2), 20)
        PlayerBoardBGImg.Location = New Point(Me.Width / 2 - (boardSizes / 2), turnsbannerYLoc + 40)


        timelbl.Font = New Font("Segoe UI", CShort(Me.Height / 48.5333328F), FontStyle.Bold, GraphicsUnit.Point)
        timelbl.Location = New Point((Me.Width / 2) - 40, Me.Height - 95)
        timelbl.Size = New Size(80, 30)

        'Using an offset dependent on the length of playername so that the text won't overlap on the game boards
        Dim playernameoffSet = 5 * (playerName.Length)
        playernametxt.Text = playerName
        playernamelbl.Location = New Point((Me.Width / 2) - (boardSizes / 2) - playernameoffSet - 200, Me.Bottom - 230)
        playernametxt.Location = New Point((Me.Width / 2) - (boardSizes / 2) - playernameoffSet - 120, Me.Bottom - 230)
        playerscorelbl.Location = New Point(Me.Width / 2 - (boardSizes / 2) - playernameoffSet - 168, Me.Bottom - 200)
        playerscoretxt.Location = New Point(Me.Width / 2 - (boardSizes / 2) - playernameoffSet - 94, Me.Bottom - 200)

        opponentnamelbl.Location = New Point((Me.Width / 2) + (boardSizes / 2) + 40, Me.Top + 150)
        opponentscorelbl.Location = New Point((Me.Width / 2) + (boardSizes / 2) + 68, Me.Top + 180)
        opponentscoretxt.Location = New Point((Me.Width / 2) + (boardSizes / 2) + 142, Me.Top + 180)

        TurnsBannerPic.Location = New Point(turnsbannerXloc, turnsbannerYLoc)
        TurnsBannerPic.Size = New Size(turnsbannerWidth, turnsbannerHeight)
        TurnsBannerPic.ImageLocation = Application.StartupPath & "\Pictures\PlayerTurnBanner.png"

        KeyPanel.Location = New Point(Me.Width / 20, Me.Height / 18)
        playerStatspnl.Location = New Point(Me.Width / 5, Me.Height / 18)

        'Setting the size of the grid circle to be dependent on the boardSize (minus it's border) and divided by how many elements the grid is
        'Ability to adjust the sizes of the grid and to have corresponding changes to the size of each circle
        gridCircleSizeNum = (boardSizes - 30) / gridSize
        'Variables used for setting target object to be able to automate and loop controls 
        Dim duplicateShip As Boolean
        Dim targetObject As PictureBox
        Dim shippicstr As String
        Dim currentplayerstr As String
        Dim player As Integer
        player = 0
        'For both player and opponent

        For player = 1 To 2
            If player = 1 Then
                currentplayerstr = "player"
            Else
                currentplayerstr = "opponent"
            End If

            'Game boards
            targetObject = Me.Controls.Item(currentplayerstr + "BoardBGImg")
            targetObject.ImageLocation = Application.StartupPath & "\Pictures\board.png"
            targetObject.Size = New Size(boardSizes, boardSizes)

            'Ships picture boxes
            For length = 2 To 5
                shippicstr = length.ToString
                If length = 3 Then
                    If duplicateShip = False Then
                        shippicstr = "3a"
                        duplicateShip = True
                    End If
                End If
                If length = 4 Then
                    If duplicateShip = True Then
                        shippicstr = "3b"
                        duplicateShip = False
                        length = length - 1
                    End If
                End If

                Dim shipstr As String

                shipstr = currentplayerstr & "Ship" & shippicstr
                'Me.WindowState = FormWindowState.Minimized
                targetObject = Me.Controls.Item(currentplayerstr & "ShipPicbox" & shippicstr)
                If targetObject Is Nothing Then
                    targetObject = referenceShipFromParents(targetObject, length, shipstr, currentplayerstr)
                End If
                targetObject.Location = New Point(100, 100)
                targetObject.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
                targetObject.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"
                targetObject.Parent = Me
            Next length
        Next player
    End Sub

    ''' <summary>
    ''' Determines the pictrebox associated with the correct ship after it has been parented with the grid circles it is on top of.
    ''' Example of use: referenceShipFromParents("4_2", 3, "playerShip3a", "player") = playershipPicbox3a
    ''' </summary>
    ''' <param name="targetobject">A picturebox: Will be either 'Nothing' or a grid picture box: eg. "4_2"</param>
    ''' <param name="length">An integer representing the length of the ship: eg. 3</param>
    ''' <param name="shipstr">A string representing the chosen ship: eg. "playerShip3a"</param>
    ''' <param name="currentplayerstr">A string representing the target player: eg. "player" or "opponent"</param>
    ''' <returns>The picturebox of the ship</returns>
    Private Function referenceShipFromParents(targetobject As PictureBox, length As Integer, shipstr As String, currentplayerstr As String) As PictureBox
        Dim targetship() As shipGridLocations
        Dim targetpicboxArr(,) As PictureBox

        'Gets the picturebox array of the target and the targetship array of records that holds the locations of the ship.
        targetship = CallByName(Me, shipstr, vbGet)
        targetpicboxArr = CallByName(Me, currentplayerstr & "pictureBoxArray", vbGet)

        'Passes the child of the picturebox at the location in the picturebox array into GetShipFromParent()
        targetobject = GetShipFromParent(targetpicboxArr(targetship(length).X, targetship(length).Y).GetChildAtPoint(New Point(0, 0), 0))

        Return targetobject
    End Function

    ''' <summary>
    ''' Function gets the picturebox of the ship (which is at the top layer of parenting) from one of the parents in a lower layer
    ''' Example of use: GetShipFromParent("4_2") = playerShipPicbox3a
    ''' </summary>
    ''' <param name="parentPicbox">A picturebox that is a parent of a ship picture box</param>
    ''' <returns>The picturebox of the ship on the top layer of the grid box layers. </returns>
    Public Function GetShipFromParent(parentPicbox As PictureBox) As PictureBox
        Dim targetobject As PictureBox
        Dim i As Integer
        Dim count As Integer

        targetobject = parentPicbox
        i = 0
        count = 0

        'Move up the layers until there are no more children (top layer)
        Do
            targetobject = targetobject.GetChildAtPoint(New Point(0, 0), 0)
            count = count + 1
        Loop Until targetobject Is Nothing

        targetobject = parentPicbox

        'Move up the layers to the top layer (1 before there are no children) which will be the ship.
        For i = 1 To (count - 1)
            targetobject = targetobject.GetChildAtPoint(New Point(0, 0), 0)
        Next i
        Return targetobject
    End Function

    ''' <summary>
    ''' Function sets all the elements in the array to be 0 (empty)
    ''' Example of use: playerGameArr = resetGameArray(playerGameArr)
    ''' </summary>
    ''' <param name="array">A 2D array</param>
    ''' <returns>The array after being reset to 0</returns>
    Private Function resetGameArray(array As Array) As Array
        Dim row As Integer
        Dim col As Integer

        row = 0
        col = 0

        For col = 1 To gridSize
            For row = 1 To gridSize
                array(col, row) = 0
            Next row
        Next col
        Return array
    End Function

    ''' <summary>
    ''' Subroutine generates the grid of pictureboxes with correct Data, presentation and placement
    ''' Example of use: generatePicture(opponentpictureBoxArray, OpponentBoardBGImg, 2)
    ''' </summary>
    ''' <param name="pictureBoxArray">The array that holds each pictrebox created</param>
    ''' <param name="picBoard">The picturebox of the board that sits behind the grid of pictureboxes</param>
    ''' <param name="currentPlayer">An integer representation of the player to be created</param>
    Public Sub generatePicture(pictureBoxArray As Array, picBoard As PictureBox, currentPlayer As Integer)
        Dim col As Integer
        Dim row As Integer

        col = 0
        row = 0

        For row = 1 To gridSize
            For col = 1 To gridSize
                Dim picbox = New PictureBox
                'Data
                picbox.Name = col & "_" & row
                picbox.Parent = picBoard
                pictureBoxArray(col, row) = picbox
                picbox.BringToFront()
                picbox.BackColor = Color.FromArgb(CByte(0), CByte(237), CByte(28), CByte(36))

                'presentation
                picbox.Width = gridCircleSizeNum
                picbox.Height = gridCircleSizeNum

                'placement of each picture box dependent on row and col
                Select Case gridSize
                    Case 8
                        picbox.Left = col * gridCircleSizeNum - 33
                        picbox.Top = (Me.Height / 2) - (row * gridCircleSizeNum) - 91
                    Case 10
                        picbox.Left = col * gridCircleSizeNum - 20
                        picbox.Top = (Me.Height / 2) - (row * gridCircleSizeNum) - 94
                    Case 12
                        picbox.Left = col * gridCircleSizeNum - 15
                        picbox.Top = (Me.Height / 2) - (row * gridCircleSizeNum) - 92
                    Case 14
                        picbox.Left = col * gridCircleSizeNum - 14
                        picbox.Top = (Me.Height / 2) - (row * gridCircleSizeNum) - 89
                End Select

                'Adding the option to click and hover which calls each respective subroutine
                If currentPlayer = 2 Then
                    AddHandler picbox.Click, AddressOf getPlayerMove
                    AddHandler picbox.MouseEnter, AddressOf mouseEnterGridCircle
                    AddHandler picbox.MouseLeave, AddressOf mouseExitGridCircle
                End If

                'Image presentation
                picbox.ImageLocation = Application.StartupPath & "\pictures\transparentCircle.png"
                picbox.SizeMode = PictureBoxSizeMode.StretchImage
            Next col
        Next row
    End Sub

    ''' <summary>
    ''' Subroutine calls generateShips for each ship
    ''' Example of use: generateGameArr(playerGameArr, 1)
    ''' </summary>
    ''' <param name="gameArr">The empty 2D array that will be populated with the locations of the ships.</param>
    ''' <param name="player">An integer representation of the player. Eg. 1: the player, 2: the opponent</param>
    Private Sub generateGameArr(gameArr As Array, player As Integer)
        'To generate the game array, whether randomly or by choice
        gameArr = generateShips(gameArr, 2, player)
        gameArr = generateShips(gameArr, 3, player)
        gameArr = generateShips(gameArr, 3, player)
        gameArr = generateShips(gameArr, 4, player)
        gameArr = generateShips(gameArr, 5, player)
    End Sub

    ''' <summary>
    ''' Populates the game array with a ship at a valid random location in a random direction 
    ''' Example of use: gameArr = generateShips(playerGameArr, 3, 1)
    ''' </summary>
    ''' <param name="gameArr">The game array to be populated: eg. playerGameArr </param>
    ''' <param name="length">The length of the ship: eg. 3</param>
    ''' <param name="currentplayernum">The integer representation of the owner of the game array: eg. 1 for the player</param>
    ''' <returns>An updated version of the game array</returns>
    Private Function generateShips(gameArr As Array, length As Integer, currentplayernum As Integer) As Array
        'Declare local variables
        Dim valid As Boolean
        valid = False
        Dim col As Integer
        Dim row As Integer
        Dim direction As Integer
        Dim signedIndicatorX As Integer
        Dim signedIndicatorY As Integer
        Dim directionShipFacing As String

        'While loop to continue until there is a valid location chosen
        While valid = False
            valid = False
            'Generate a random column and row
            col = Int(Rnd() * gridSize) + 1
            row = Int(Rnd() * gridSize) + 1

            'To check if the randomly generated location is empty
            If gameArr(col, row) = 0 Then
                'Generate a random diretion between 1 and 4 (left, right, up, down)
                direction = Int(Rnd() * 4) + 1

                'To generate the ship of chosen length in a randomly chosen diection
                Select Case direction
                    Case 1
                        directionShipFacing = "up"
                        signedIndicatorX = 0
                        signedIndicatorY = -1
                    Case 2 : directionShipFacing = "down"
                        signedIndicatorX = 0
                        signedIndicatorY = 1
                    Case 3 : directionShipFacing = "right"
                        signedIndicatorX = -1
                        signedIndicatorY = 0
                    Case 4 : directionShipFacing = "left"
                        signedIndicatorX = 1
                        signedIndicatorY = 0
                End Select
                If isValidPlace(col, row, length, directionShipFacing) = True Then
                    Select Case length
                        Case 2
                            If gameArr(col + signedIndicatorX, row + signedIndicatorY) = 0 Then
                                'If the element to the left is empty: Set the initially chosen location and the one to the left as a ship
                                valid = populateGameArr(signedIndicatorX, signedIndicatorY, length, directionShipFacing, col, row, gameArr, currentplayernum)
                                'Set the respective ship record to the same starting location
                            End If
                        Case 3
                            'If the element to the left is empty and the one to the left of that is also empty: Set all 3 to be a ship
                            If gameArr(col + signedIndicatorX, row + signedIndicatorY) = 0 AndAlso gameArr(col + (2 * signedIndicatorX), row + (2 * signedIndicatorY)) = 0 Then
                                valid = populateGameArr(signedIndicatorX, signedIndicatorY, length, directionShipFacing, col, row, gameArr, currentplayernum)

                            End If
                        Case 4
                            'If all the other 3 squares are empty: set all 4 to be ships
                            If gameArr(col + signedIndicatorX, row + signedIndicatorY) = 0 AndAlso gameArr(col + (2 * signedIndicatorX), row + (2 * signedIndicatorY)) = 0 AndAlso gameArr(col + (3 * signedIndicatorX), row + (3 * signedIndicatorY)) = 0 Then
                                valid = populateGameArr(signedIndicatorX, signedIndicatorY, length, directionShipFacing, col, row, gameArr, currentplayernum)
                            End If
                        Case 5
                            'If all the other 4 squares are empty: set all 5 to be ships
                            If gameArr(col + signedIndicatorX, row + signedIndicatorY) = 0 AndAlso gameArr(col + (2 * signedIndicatorX), row + (2 * signedIndicatorY)) = 0 AndAlso gameArr(col + (3 * signedIndicatorX), row + (3 * signedIndicatorY)) = 0 AndAlso gameArr(col + (4 * signedIndicatorX), row + (4 * signedIndicatorY)) = 0 Then
                                valid = populateGameArr(signedIndicatorX, signedIndicatorY, length, directionShipFacing, col, row, gameArr, currentplayernum)
                            End If
                    End Select
                End If
            End If
        End While

        'useful for debuging purposes, to determine where the head of the ship is. Can be used to turn the square in the front of the ship to a different colour circle
        gameArr(col, row) = 4

        'Generate each ship pictrebox in it's correct location
        If currentplayernum = 1 Then
            displayShipsAsParentingStack(col, row, length, directionShipFacing)
        End If
        revealships()
        Return gameArr
    End Function

    ''' <summary>
    ''' Function assigns the location for the ship, populating the game array
    ''' Once stored and run, return a true to allow generateShips() to continue
    ''' Example of use: populateGameArr(1,0,3,"left",5,2,playerGameArr,1) = true
    ''' </summary>
    ''' <param name="signedIndicatorX">An integer which is used to multiply by 1 or -1 in the X direction</param>
    ''' <param name="signedIndicatorY">An integer which is used to multiply by 1 or -1 in the Y direction</param>
    ''' <param name="length">The length of the ship: eg. 3</param>
    ''' <param name="directionShipFacing">A string representing the direction the ship is facing: eg. "left"</param>
    ''' <param name="col">An integer representing the column the ship has been placed in</param>
    ''' <param name="row">An integer representing the row the ship has been placed in</param>
    ''' <param name="gameArr">The game array to be populated: eg. playerGameArr</param>
    ''' <param name="currentplayernum">The integer representation of the owner of the game array: eg. 1 for the player</param>
    ''' <returns>A boolean of True (valid = true)</returns>
    Private Function populateGameArr(signedIndicatorX As Integer, signedIndicatorY As Integer, length As Integer, directionShipFacing As String, col As Integer, row As Integer, gameArr As Array, currentplayernum As Integer) As Boolean
        Dim i As Integer
        i = 0

        'Assign every location of the ship in the game Array
        Select Case directionShipFacing
            Case "right"
                'Goes backwards in X from start
                For i = col To (col + (signedIndicatorX * (length - 1))) Step -1
                    gameArr(i, row) = 1
                Next i

            Case "left"
                'Goes fowards in X from start
                For i = col To (col + (signedIndicatorX * (length - 1)))
                    gameArr(i, row) = 1
                Next i

            Case "up"
                'Goes backwards in Y from start
                For i = row To (row + (signedIndicatorY * (length - 1))) Step -1
                    gameArr(col, i) = 1
                Next i

            Case "down"
                'Goes forwards in Y from start
                For i = row To (row + (signedIndicatorY * (length - 1)))
                    gameArr(col, i) = 1
                Next i
        End Select
        'Store those positions within each individual ship record
        setIndividualShipLocations(col, row, length, directionShipFacing, currentplayernum)
        Return True
    End Function

    ''' <summary>
    ''' Subroutine stores the locations of each individual ship into their respective records
    ''' Example of use: setIndividualShipLocations(5, 2, 3, "left", 1)
    ''' </summary>
    ''' <param name="col">An integer representing the column the ship has been placed in</param>
    ''' <param name="row">An integer representing the row the ship has been placed in</param>
    ''' <param name="length">The length of the ship: eg. 3</param>
    ''' <param name="direction">A string representing the direction the ship is facing: eg. "left"</param>
    ''' <param name="currentplayernum">The integer representation of the owner of the game array: eg. 1 for the player</param>
    Private Sub setIndividualShipLocations(col As Integer, row As Integer, length As Integer, direction As String, currentplayernum As Integer)
        Dim Xoffset As Integer
        Dim Yoffset As Integer
        Dim playerDuplicateship As Boolean
        Dim opponentDuplicateship As Boolean
        Dim elementCount As Integer

        Xoffset = 0
        Yoffset = 0
        playerDuplicateship = False
        opponentDuplicateship = False
        elementCount = 0

        'If the first element of the player's first 3 length ship is 0, then neither of the 3 length ships has been set
        If playerShip3a(1).X = 0 AndAlso playerShip3a(1).Y = 0 Then
            'First 3 length ship
            playerDuplicateship = False
        Else
            'Second 3 length ship
            playerDuplicateship = True
        End If

        'If the first element of the opponents's first 3 length ship is 0, then neither of the 3 length ships has been set
        If opponentShip3a(1).X = 0 AndAlso opponentShip3a(1).Y = 0 Then
            opponentDuplicateship = False
        Else
            opponentDuplicateship = True
        End If

        'For every element until the length of the ship, set the location of the ships to the separate and individual records
        For elementCount = 1 To length
            If currentplayernum = 1 Then
                'For the player
                Select Case length
                    Case 2
                        'First time Xoffset and Yoffset will be 0, to allow the X and Y locations to match up with the randomly chosen rows and columns
                        'Will increment for the rest
                        playerShip2(elementCount).X = col + Xoffset
                        playerShip2(elementCount).Y = row + Yoffset
                    Case 3
                        If playerDuplicateship = False Then
                            'Set the location for the first of the 3 length ship
                            playerShip3a(elementCount).X = col + Xoffset
                            playerShip3a(elementCount).Y = row + Yoffset
                        Else
                            'Set the location for the second of the 3 length ship
                            playerShip3b(elementCount).X = col + Xoffset
                            playerShip3b(elementCount).Y = row + Yoffset
                        End If
                    Case 4
                        playerShip4(elementCount).X = col + Xoffset
                        playerShip4(elementCount).Y = row + Yoffset
                    Case 5
                        playerShip5(elementCount).X = col + Xoffset
                        playerShip5(elementCount).Y = row + Yoffset
                End Select
            Else
                'for the opponent
                Select Case length
                    Case 2
                        opponentShip2(elementCount).X = col + Xoffset
                        opponentShip2(elementCount).Y = row + Yoffset
                    Case 3
                        If opponentDuplicateship = False Then
                            opponentShip3a(elementCount).X = col + Xoffset
                            opponentShip3a(elementCount).Y = row + Yoffset
                        Else
                            opponentShip3b(elementCount).X = col + Xoffset
                            opponentShip3b(elementCount).Y = row + Yoffset
                        End If
                    Case 4
                        opponentShip4(elementCount).X = col + Xoffset
                        opponentShip4(elementCount).Y = row + Yoffset
                    Case 5
                        opponentShip5(elementCount).X = col + Xoffset
                        opponentShip5(elementCount).Y = row + Yoffset
                End Select
            End If

            Select Case direction
                'Increment the offsets appropiately for the direction of the ship
                Case "up" : Yoffset = Yoffset - 1
                Case "down" : Yoffset = Yoffset + 1
                Case "right" : Xoffset = Xoffset - 1
                Case "left" : Xoffset = Xoffset + 1
            End Select
        Next elementCount
    End Sub

    ''' <summary>
    ''' Function determines whether the a ship can be placed in the position that has been randomly generated
    ''' To check if the ship will not be generated over the edge of the board: that will cause an error
    ''' Example of use: isValidPlace(3,4,5,"left")
    ''' </summary>
    ''' <param name="col">An integer representing the X value (column) of the ships beginning</param>
    ''' <param name="row">An integer representing the Y value (row) of the ships beginning</param>
    ''' <param name="length">An integer representing the length of the ship</param>
    ''' <param name="direction">An string representing the direction the ship is facing. The ship is facing in the opposite direction to the direction it is going in after the random position is chosen.</param>
    ''' <returns>A boolean for if the placement of the ship is valid</returns>
    Private Function isValidPlace(col As Integer, row As Integer, length As Integer, direction As String) As Boolean
        'Assume to be true unless an edge case below
        Dim valid As Boolean
        valid = True

        Select Case direction
            Case "up" 'Ship faces up: Down from random start position
                If row - length < 0 Then
                    'If too close to the edge on the top side
                    valid = False
                End If
            Case "down" 'Ship faces down: Up from random start position
                If row + length > gridSize Then
                    'If too close to the edge on the bottom side
                    valid = False
                End If
            Case "right" 'Ship faces right: Left from random start position
                If col - length < 0 Then
                    'If too close to the edge on the left side
                    valid = False
                End If
            Case "left" 'Ship faces left: Right from random start position
                If col + length > gridSize Then
                    'If too close to the edge on the right side
                    valid = False
                End If
        End Select
        Return valid
    End Function

    ''' <summary>
    ''' Subroutine which displays the ships pictureboxes in the correct way.
    ''' Creates a parenting stack with the randomly generated guess forming the lowest layer, with each picturebox above it forming another layer until the ships picturebox is placed on top.
    ''' Needs to expand the layers to the size of the entire ship, and needs to preserve image while doing so.
    ''' Example of use: displayShipsAsParentingStack(5,2,3,"left")
    ''' </summary>
    ''' <param name="col">An integer representing the X value (column) of the ships beginning: eg. 5</param>
    ''' <param name="row">An integer representing the Y value (row) of the ships beginning: eg. 2</param>
    ''' <param name="shipLength">An integer representing the length of the ship: eg. 3</param>
    ''' <param name="direction">An string representing the direction the ship is facing. The ship is facing in the opposite direction to the direction it is going in after the random position is chosen.</param>
    Private Sub displayShipsAsParentingStack(col As Integer, row As Integer, shipLength As Integer, direction As String)
        'overall parent must be highest count (aka back to front)
        Dim X As Integer
        Dim Y As Integer
        Dim Xscale As Integer
        Dim Yscale As Integer
        Dim XOffset As Integer
        Dim YOffset As Integer
        Dim count As Integer
        Dim parentgridbox As PictureBox
        Dim targetship As PictureBox
        Dim originalParent As PictureBox

        'Set the original parent to be the randomly generated location
        originalParent = playerpictureBoxArray(col, row)

        'Change the sizemode back to normal from streched (if stretched- image is stretched to fit the entire picturebox which would hide the other pictureboxes underneath) 
        originalParent.SizeMode = PictureBoxSizeMode.Normal

        count = shipLength

        'X,Y,Xscale,Yscle,XOffset,YOffset are all dependent on the direction the ship is facing
        Select Case direction
            Case "right"
                X = gridCircleSizeNum * (shipLength - 1)
                Xscale = gridCircleSizeNum * shipLength
                Yscale = gridCircleSizeNum
                XOffset = -1
                YOffset = 0
                'Expanding picturebox to the left so needs to be moved back
                resizeAndMoveImageWithinPicbox(originalParent, count, gridCircleSizeNum, direction)
                'To move back to the far end of where was chosen (so expanding does not go over the limit onto the others)
                originalParent.Location = originalParent.Location - New Point(X, Y)
            Case "left"
                Xscale = gridCircleSizeNum * shipLength
                Yscale = gridCircleSizeNum
                XOffset = 1
                YOffset = 0
                'Expanding picturebox to the left so it does not need to be moved
                resizeAndMoveImageWithinPicbox(originalParent, count, gridCircleSizeNum, "noMovement")
            Case "down"
                Y = gridCircleSizeNum * (shipLength - 1)
                Xscale = gridCircleSizeNum
                Yscale = gridCircleSizeNum * shipLength
                XOffset = 0
                YOffset = 1
                'Expanding picturebox upwards so needs to be moved back down
                resizeAndMoveImageWithinPicbox(originalParent, count, gridCircleSizeNum, direction)
                'To move back to the far end of where was chosen (so expanding does not go over the limit onto the others)
                originalParent.Location = originalParent.Location - New Point(X, Y)
            Case "up"
                Xscale = gridCircleSizeNum
                Yscale = gridCircleSizeNum * shipLength
                XOffset = 0
                YOffset = -1
                'Expanding picturebox upwards so it does not need to be moved
                resizeAndMoveImageWithinPicbox(originalParent, count, gridCircleSizeNum, "noMovement")
        End Select

        'Expands the picturebox to the correct size and sets it transparent
        originalParent.Size = New Size(Xscale, Yscale)
        originalParent.BackColor = Color.Transparent
        parentgridbox = originalParent

        'Parent stacking each picturebox until the top layer
        If direction = "right" OrElse direction = "down" Then
            rightAndDown(shipLength, col, row, XOffset, YOffset, Xscale, Yscale, parentgridbox, direction)
        Else
            leftAndUp(shipLength, col, row, XOffset, YOffset, Xscale, Yscale, parentgridbox, direction)
        End If

        'Get the picturebox of the ship
        If shipLength = 3 Then
            If duplicateShip = False Then
                targetship = Me.Controls.Item("playerShipPicbox3a")
                duplicateShip = True
            Else
                targetship = Me.Controls.Item("playerShipPicbox3b")
                duplicateShip = False
            End If
        Else
            targetship = Me.Controls.Item("playerShipPicbox" & shipLength)
        End If

        'Assigns and loads the image inside the ships picturebox
        assignShipImages(targetship)
        targetship.Load(targetship.ImageLocation)

        'Rotate the image the appropriate number of times for correct orientation
        Select Case direction
            Case "left"
                targetship = rotateImage90(targetship)
                targetship = rotateImage90(targetship)
            Case "down"
                targetship = rotateImage90(targetship)
            Case "up"
                targetship = rotateImage90(targetship)
                targetship = rotateImage90(targetship)
                targetship = rotateImage90(targetship)
        End Select

        'Set the correct parametres for the ships picturebox to display correctly
        targetship.Parent = parentgridbox
        targetship.Size = parentgridbox.Size
        targetship.BackColor = Color.Transparent
        targetship.BringToFront()
        targetship.Location = New Point(0, 0)
    End Sub

    ''' <summary>
    ''' Handles parenting stack for directions "right" and "down" 
    ''' Example of use: rightAndDown(3,5,2,-1,0, 3*gridCircleSizeNum, gridCircleSizeNum,5_2,"right")
    ''' </summary>
    ''' <param name="shipLength">An integer representing the length of the ship: eg. 3</param>
    ''' <param name="col">An integer representing the X value (column) of the ships beginning: eg. 5</param>
    ''' <param name="row">An integer representing the Y value (row) of the ships beginning: eg. 2</param>
    ''' <param name="XOffset">An integer that either is -1, 0 or 1 and is used to offset through the array in the X component</param>
    ''' <param name="Yoffset">An integer that either is -1, 0 or 1 and is used to offset through the array in the Y component</param>
    ''' <param name="Xscale">An integer representing the new width of the picturebox</param>
    ''' <param name="Yscale">An integer representing the new height of the picturebox</param>
    ''' <param name="parentgridbox">The original (lowest layer) picturebox to be changed each loop creating a parenting stack</param>
    ''' <param name="direction">An string representing the direction the ship is facing. The ship is facing in the opposite direction to the direction it is going in after the random position is chosen.</param>
    Private Sub rightAndDown(shipLength As Integer, col As Integer, row As Integer, XOffset As Integer, Yoffset As Integer, Xscale As Integer, Yscale As Integer, ByRef parentgridbox As PictureBox, direction As String)
        Dim newCount As Integer
        Dim targetgridbox As PictureBox
        Dim count As Integer
        count = 0

        'From left to right or up to down
        For count = 1 To (shipLength - 1)
            'Get the correct picturebox
            targetgridbox = playerpictureBoxArray(col + (XOffset * count), row + (Yoffset * count))

            'Change the sizemode back to normal from streched (if stretched- image is stretched to fit the entire picturebox which would hide the other pictureboxes underneath
            targetgridbox.SizeMode = PictureBoxSizeMode.Normal

            'Correctly display the image inside the picturebox as to not obsecure any below it.
            resizeAndMoveImageWithinPicbox(targetgridbox, shipLength - count, gridCircleSizeNum, direction)

            'Set the correct parametres for the picturebox to display correctly
            targetgridbox.Size = New Size(Xscale, Yscale)
            targetgridbox.Parent = parentgridbox
            targetgridbox.BringToFront()
            targetgridbox.Location = New Point(0, 0)
            targetgridbox.BackColor = Color.Transparent

            'Chain the parenting stack
            parentgridbox = targetgridbox
        Next count
    End Sub

    ''' <summary>
    ''' Handles parenting stack for directions "left" and "up" 
    ''' Example of use: leftAndUp(3,5,2,1,0, 3*gridCircleSizeNum, gridCircleSizeNum,5_2,"left")
    ''' </summary>
    ''' <param name="shipLength">An integer representing the length of the ship: eg. 3</param>
    ''' <param name="col">An integer representing the X value (column) of the ships beginning: eg. 5</param>
    ''' <param name="row">An integer representing the Y value (row) of the ships beginning: eg. 2</param>
    ''' <param name="XOffset">An integer that either is -1, 0 or 1 and is used to offset through the array in the X component</param>
    ''' <param name="Yoffset">An integer that either is -1, 0 or 1 and is used to offset through the array in the Y component</param>
    ''' <param name="Xscale">An integer representing the new width of the picturebox</param>
    ''' <param name="Yscale">An integer representing the new height of the picturebox</param>
    ''' <param name="parentgridbox">The original (lowest layer) picturebox to be changed each loop creating a parenting stack</param>
    ''' <param name="direction">An string representing the direction the ship is facing. The ship is facing in the opposite direction to the direction it is going in after the random position is chosen.</param>
    Private Sub leftAndUp(shipLength As Integer, col As Integer, row As Integer, XOffset As Integer, Yoffset As Integer, Xscale As Integer, Yscale As Integer, ByRef parentgridbox As PictureBox, direction As String)
        Dim targetgridbox As PictureBox
        Dim count As Integer
        count = 0

        'From right to left or down to up
        For count = (shipLength - 1) To 1 Step -1
            'Get the correct picturebox
            targetgridbox = playerpictureBoxArray(col + (XOffset * count), row + (Yoffset * count))

            'Change the sizemode back to normal from streched (if stretched- image is stretched to fit the entire picturebox which would hide the other pictureboxes 
            targetgridbox.SizeMode = PictureBoxSizeMode.Normal

            'Correctly display the image inside the picturebox as to not obsecure any below it.
            resizeAndMoveImageWithinPicbox(targetgridbox, count, gridCircleSizeNum, direction)

            'Set the correct parametres for the picturebox to display correctly
            targetgridbox.Size = New Size(Xscale, Yscale)
            targetgridbox.Parent = parentgridbox
            targetgridbox.BringToFront()
            targetgridbox.Location = New Point(0, 0)
            targetgridbox.BackColor = Color.Transparent

            'Chain the parenting stack
            parentgridbox = targetgridbox
        Next count
    End Sub

    ''' <summary>
    ''' Subroutine resizes and moves the image of a picturebox within itself.
    ''' To be used for correct visuals in parenting for the ships
    ''' To allow the image to be seen without obsecuring the image of it's aprent
    ''' Example of use: resizeAndMoveImageWithinPicbox(picbox, 1, gridCircleSizeNum, "noDirection")
    ''' </summary>
    ''' <param name="picbox">The picturebox whose picture needs to be resized and moved</param>
    ''' <param name="count">An integer representing how far along to move the image (the stage of parenting)</param>
    ''' <param name="radius">An integer that represents the size (radius) of the image</param>
    ''' <param name="direction">A string representing the direction in which to move the image</param>
    Private Sub resizeAndMoveImageWithinPicbox(picbox As PictureBox, count As Integer, radius As Integer, direction As String)
        picbox.Load(picbox.ImageLocation)
        Dim Xloc As Integer
        Dim Yloc As Integer

        'Transformation magnitidue and direction of picture 
        Select Case direction
            Case "right"
                Xloc = radius * (count - 1)
                Yloc = 0
            Case "left"
                Xloc = radius * count
                Yloc = 0
            Case "up"
                Xloc = 0
                Yloc = radius * count
            Case "down"
                Xloc = 0
                Yloc = radius * count - radius
            Case "noMovement"
                Xloc = 0
                Yloc = 0
        End Select

        'Apply transformation to a new bitmap
        Dim b As Bitmap = DirectCast(picbox.Image, Bitmap)
        Dim new_b As New Bitmap(radius + Xloc, radius + Yloc)
        Dim g As Graphics = Graphics.FromImage(new_b)

        'Draw with the new transformations: moves and scales the picture
        g.DrawImage(b, Xloc, Yloc, radius, radius)
        g.Save()

        picbox.Image = new_b
    End Sub

    ''' <summary>
    ''' Subroutine preserves the image size and transformation within the picturebox whilst also updating the image.
    ''' Example of use: updateImageKeepCorrectSize(4_2,3,10)
    ''' </summary>
    ''' <param name="picbox">>The picturebox whose picture needs to be updated</param>
    ''' <param name="arrayValue">An integer representing the value of the position inside the gameArray (empty, a ship, a hit, a miss)</param>
    ''' <param name="radius">An integer that represents the size (radius) of the image</param>
    Private Sub updateImageKeepCorrectSize(picbox As PictureBox, arrayValue As Integer, radius As Integer)
        Dim Xloc As Integer
        Dim Yloc As Integer

        'Store the transformations of the image
        If picbox.Image.Width - radius = 0 AndAlso picbox.Image.Height - radius = 0 Then
            'No movement
        Else
            If picbox.Image.Width - radius = 0 Then
                'If y has been stretched
                Yloc = picbox.Image.Height - radius
            Else
                If picbox.Image.Height - radius = 0 Then
                    'If x has been stretched
                    Xloc = picbox.Image.Width - radius
                End If
            End If
        End If

        'Update the images
        Select Case arrayValue
            Case 1 : picbox.ImageLocation = Application.StartupPath & "\pictures\transparentCircleHidden.png" 'hidden
            Case 2 : picbox.ImageLocation = Application.StartupPath & "\pictures\BlueCircle.png" 'miss
            Case 3 : picbox.ImageLocation = Application.StartupPath & "\pictures\RedCircle.png" 'hit
            Case 4 : picbox.ImageLocation = Application.StartupPath & "\pictures\transparentCircleHidden.png" 'hidden front of ship
        End Select
        picbox.Load(picbox.ImageLocation)

        'Apply stored transformation to a new bitmap
        Dim b As Bitmap = DirectCast(picbox.Image, Bitmap)
        Dim new_b As New Bitmap(radius + Xloc, radius + Yloc)
        Dim g As Graphics = Graphics.FromImage(new_b)

        'Draw with the stored transformations: moves and scales the picture
        g.DrawImage(b, Xloc, Yloc, radius, radius)
        g.Save()

        picbox.Image = new_b
    End Sub

    ''' <summary>
    ''' Subroutine assigns the picturebox with the correct image from the pictures folder.
    ''' </summary>
    ''' <param name="picboard">The picturebox of the ship</param>
    Private Sub assignShipImages(picboard As PictureBox)
        'Assign each ship picturebox with the correct picture
        Select Case picboard.Name
            Case opponentShipPicbox2.Name : opponentShipPicbox2.ImageLocation = Application.StartupPath & "\pictures\BattleShip2.png"
            Case playerShipPicbox2.Name : playerShipPicbox2.ImageLocation = Application.StartupPath & "\pictures\BattleShip2.png"
            Case opponentShipPicbox3a.Name : opponentShipPicbox3a.ImageLocation = Application.StartupPath & "\pictures\BattleShip3.png"
            Case playerShipPicbox3a.Name : playerShipPicbox3a.ImageLocation = Application.StartupPath & "\pictures\BattleShip3.png"
            Case opponentShipPicbox3b.Name : opponentShipPicbox3b.ImageLocation = Application.StartupPath & "\pictures\BattleShip3.png"
            Case playerShipPicbox3b.Name : playerShipPicbox3b.ImageLocation = Application.StartupPath & "\pictures\BattleShip3.png"
            Case opponentShipPicbox4.Name : opponentShipPicbox4.ImageLocation = Application.StartupPath & "\pictures\BattleShip4.png"
            Case playerShipPicbox4.Name : playerShipPicbox4.ImageLocation = Application.StartupPath & "\pictures\BattleShip4.png"
            Case opponentShipPicbox5.Name : opponentShipPicbox5.ImageLocation = Application.StartupPath & "\pictures\BattleShip5.png"
            Case playerShipPicbox5.Name : playerShipPicbox5.ImageLocation = Application.StartupPath & "\pictures\BattleShip5.png"
        End Select
    End Sub

    ''' <summary>
    ''' Function rotates the image 90 degrees clockwise within it's picturebox
    ''' Example of use: targetship = rotateImage90(targetship)
    ''' </summary>
    ''' <param name="picbox">The picturebox thats image is to be rotated inside it</param>
    ''' <returns>The same picturebox with it's image rotated 90 degrees</returns>
    Private Function rotateImage90(picbox As PictureBox) As PictureBox
        'To rotate the image 90 degrees and scale it correctly
        Dim bmp As Bitmap
        bmp = New Bitmap(picbox.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        picbox.Image = bmp
        Return picbox
    End Function

    ''' <summary>
    ''' Subroutine reveals the opponents ships at the end of the game.
    ''' </summary>
    Private Sub revealships()
        If gameOver = True Then
            'Sets all the ships to be 'hit' to allow them to appear with the correct images
            For i = 1 To 2
                opponentShip2(i).isHit = True
            Next i
            For i = 1 To 3
                opponentShip3a(i).isHit = True
                opponentShip3b(i).isHit = True
            Next i
            For i = 1 To 4
                opponentShip4(i).isHit = True
            Next i
            For i = 1 To 5
                opponentShip5(i).isHit = True
            Next i

            checkIfSunk(2)

            'Allows the user to view the opponents ships for 1 second before being taken to the game over form
            wait(1)
        End If
    End Sub

    ''' <summary>
    ''' Subroutine updates and changes the picture depending on the value of the 2D array at the same grid position
    ''' </summary>
    ''' <param name="gameArray">The 2D game array holding the information about the ships, the misses, the hits and the empty positions</param>
    ''' <param name="pictureBoxArray">The 2D array of pictureboxes for the grid locations</param>
    ''' <param name="playerStr">The string representation of the current player</param>
    Private Sub assignGridImages(gameArray As Array, pictureBoxArray As Array, playerStr As String)
        Dim col As Integer
        Dim row As Integer
        col = 0
        row = 0

        'For every picturebox in the array
        For col = 1 To gridSize
            For row = 1 To gridSize

                If playerStr = "opponent" Then
                    'The opponent's board has not got ship parenting, and so the images do not need to be preserved and can be updated directly
                    Select Case gameArray(col, row)
                        Case 0 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\TransparentCircleHidden.png"
                        Case 1 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\TransparentCircleHidden.png" 'hidden
                        Case 2 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\BlueCircle.png" 'miss
                        Case 3 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\RedCircle.png" 'hit
                        Case 4 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\TransparentCircleHidden.png" 'hidden front of ship
                    End Select

                Else
                    'The players board has been parented, and so the images that are parents of the ship need to be preserved
                    'The images have been modified (moved within their stretched picturebox) and this transformation needs to be preserved
                    Select Case gameArray(col, row)
                        Case 0 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\TransparentCircle.png"
                        Case Else : updateImageKeepCorrectSize(pictureBoxArray(col, row), gameArray(col, row), gridCircleSizeNum)
                    End Select
                End If
            Next row
        Next col
    End Sub

    ''' <summary>
    ''' Subroutine passes the player's move to the game() subroutine if it has't been previously guessed
    ''' Is called upon a click of a picturebox, handled within generatePicture()
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param
    Private Sub getPlayerMove(ByVal sender As PictureBox, ByVal e As EventArgs)
        Dim playerMove As gridLocation
        Dim correctGridSquare As Boolean
        Dim picLocation As String
        picLocation = sender.Name

        playerMove = getPlayerMoveFromPicboxName(sender, picLocation)

        If currentPlayer = 1 Then
            'The players move starts each round of the game
            If opponentgameArray(playerMove.X, playerMove.Y) = 1 Or opponentgameArray(playerMove.X, playerMove.Y) = 4 Or opponentgameArray(playerMove.X, playerMove.Y) = 0 Then
                timeStart()
                game(playerMove)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Function determines the location of the player move from the name of the picturebox that has been clicked.
    ''' Example of use: getPlayerMoveFromPicboxName(4_2,"4_2").X = 4
    ''' </summary>
    ''' <param name="sender">The picturebox that has been clicked</param>
    ''' <param name="piclocation">A string representing the name of the picturebox that has been clicked</param>
    ''' <returns>A record with X and Y fields representing the grid location</returns>
    Public Function getPlayerMoveFromPicboxName(sender As PictureBox, piclocation As String) As gridLocation
        Dim playerMove As gridLocation
        If piclocation.Length = 4 Then
            'c_rr' or 'cc_r'
            If piclocation(1) = "_" Then
                'One digit column, two digit row ('c_rr')
                playerMove.X = CInt(Strings.Left(sender.Name, 1))
                playerMove.Y = CInt(Strings.Right(sender.Name, 2))
            Else
                'Two digit column, one digit row ('cc_r')
                playerMove.X = CInt(Strings.Left(sender.Name, 2))
                playerMove.Y = CInt(Strings.Right(sender.Name, 1))
            End If

        Else
            If piclocation.Length = 5 Then
                'cc_rr'
                playerMove.X = CInt(Strings.Left(sender.Name, 2))
                playerMove.Y = CInt(Strings.Right(sender.Name, 2))
            Else
                'c_r'
                playerMove.X = CInt(Strings.Left(sender.Name, 1))
                playerMove.Y = CInt(Strings.Right(sender.Name, 1))
            End If
        End If
        Return playerMove
    End Function

    ''' <summary>
    ''' Subroutine is mainline of the game, started by it's call from playerMove
    ''' If the player does not have an extra turn, it responds with the computers turn. 
    ''' Example of use: game(playerMove)
    ''' </summary>
    ''' <param name="playerMove">A record with field X and field Y representing the location of the move on the grid.</param>
    Private Sub game(playerMove As gridLocation)
        'check the move of the player (hit, miss, game over)
        opponentgameArray = check(playerMove, opponentgameArray) ' function needs a better name

        'Update displayed score and stats for the player
        updateInGameScore(1)
        updateGameStats(playerHitCount, playerMissCount, 1)

        'Update the grid to show a hit or miss
        assignGridImages(opponentgameArray, opponentpictureBoxArray, "opponent")

        If gameOver = True Then
            gameIsOverWithResult()
        Else
            If playerextraTurn = False Then
                'Opponents turn

                Dim opponentmove As gridLocation
                swapPlayer()

                'Give some time for the user to notice that the computer has moved
                wait(0.3)

                'Fetch opponents move
                opponentmove = computerMove()
                'check whether a hit or a miss or if game is over
                playergameArray = check(opponentmove, playergameArray)

                'Update diaplyed score and stats for the opponent
                updateInGameScore(2)
                updateGameStats(opponentHitCount, opponentMissCount, 2)

                'Display updated grid
                assignGridImages(playergameArray, playerpictureBoxArray, "player")

                If gameOver = True Then
                    gameIsOverWithResult()
                Else
                    If computerextraTurn = False Then
                        swapPlayer()
                    Else
                        While computerextraTurn = True

                            wait(0.3)
                            opponentmove = computerMove()

                            'check, returns whether it is game over or not
                            playergameArray = check(opponentmove, playergameArray)

                            'update score and stats
                            updateInGameScore(2)
                            updateGameStats(opponentHitCount, opponentMissCount, 2)

                            'Display updated grid
                            assignGridImages(playergameArray, playerpictureBoxArray, "player")

                            'To break out of the while loop if the game has been ended
                            If gameOver = True Then
                                computerextraTurn = False
                            End If
                        End While
                        If gameOver = True Then
                            gameIsOverWithResult()
                        Else
                            'To wait for the players next move
                            swapPlayer()
                        End If
                    End If
                End If
            Else
                'To wait for the players next move
                MsgBox("You get an extra turn!")
            End If
        End If
    End Sub

    ''' <summary>
    ''' Subroutine ends the game without determining the score or taking the user to the game over form.
    ''' </summary>
    Private Sub gameIsOverNoResult()
        timeEnd()
        'Re-setting the variables that will cause incorrect statistics if left
        playerMissCount = 0
        playerHitCount = 0
        opponentMissCount = 0
        opponentHitCount = 0
        time = 0
        score = 0
        If timeOptionAsCountUp = True Then
            displayTime = ""
            timelbl.Text = displayTime
        End If

        gameTimer.Stop()
        timeInitialise()
    End Sub

    ''' <summary>
    ''' Subroutine ends the game and runs scoring before taking the user to the game over form.
    ''' </summary>
    Private Sub gameIsOverWithResult()
        timeEnd()
        score = determineScore()
        scoring()

        'If the timer has run out: set the time to be the chosen time
        If time = 0 Then
            time = timeLeft
        End If

        'Re-setting the variables that will cause incorrect statistics if left
        playerMissCount = 0
        playerHitCount = 0
        opponentMissCount = 0
        opponentHitCount = 0
        showgameOverForm()
    End Sub

    ''' <summary>
    ''' Subroutine takes the user to the gameOver form and updates the global variables
    ''' </summary>
    Private Sub showgameOverForm()
        Me.Hide()
        endTime = convertStringIntegerTimeToDisplayTime(time)
        endScore = score
        gameOverForm.onLoadsettings()
        gameOverForm.Show()
        time = 0
    End Sub

    ''' <summary>
    ''' Function determines whether the move is a hit or a miss and what to do in either case.
    ''' Checks if ships have been hit or sunk and check if the game can continue (there are still battleships left to hit)
    ''' Example: check(playerMove, opponentGameArr)
    ''' </summary>
    ''' <param name="Move">A record of gridLocation with fields X,Y and isHit: eg. playerMove</param>
    ''' <param name="gameArr">The game array in question: eg. opponentGameArr</param>
    ''' <returns>The updated game array</returns>
    Private Function check(ByRef Move As gridLocation, gameArr As Array) As Array
        If gameArr(Move.X, Move.Y) = 0 Then
            'Miss
            If currentPlayer = 1 Then
                playerMissCount = playerMissCount + 1
            Else
                opponentMissCount = opponentMissCount + 1
            End If
            'Update the array with a miss
            gameArr(Move.X, Move.Y) = 2

            'Reset extra turns
            playerextraTurn = False
            computerextraTurn = False

            'Opponent move logic for Normal, Hard and Unfair modes
            If currentPlayer = 2 Then
                previousHit = False
                opponentContinueOnCount = 1
                If oppositePath = True Then
                    NextShip = True
                    oppositePath = False
                End If
            End If
        Else
            If gameArr(Move.X, Move.Y) = 1 OrElse gameArr(Move.X, Move.Y) = 4 Then
                'Hit: 1 as general hit, 4 as the starting point (front) of each ship
                If currentPlayer = 1 Then
                    playerHitCount = playerHitCount + 1
                Else
                    opponentHitCount = opponentHitCount + 1
                End If

                'Update the array with a hit
                gameArr(Move.X, Move.Y) = 3

                'Check if any of the individual ship records are hit, and if they are sunk
                updateShipRecOnHit(Move.X, Move.Y, AlternateNum(currentPlayer))
                checkIfSunk(AlternateNum(currentPlayer))

                'Variables used in opponents randomAdjacent function
                alreadyLeft = False
                alreadyRight = False
                alreadyUp = False
                alreadyDown = False

                'The logic To control the computer move
                If currentPlayer = 2 Then
                    If hasAHit = False Then
                        hasAHit = True
                        hasAhitLocation.X = Move.X
                        hasAhitLocation.Y = Move.Y

                        'For Hard and Unfair
                        previousHit = False
                        computerStage = 1
                    Else
                        If difficulty = "Normal" Then
                            'Move the new location of hasAhit to the current move
                            hasAhitLocation.X = Move.X
                            hasAhitLocation.Y = Move.Y
                        Else
                            If difficulty = "Hard" Or difficulty = "Unfair" Then
                                'As distance away from hasAhitLocation increases, this counter needs to increase too
                                opponentContinueOnCount = opponentContinueOnCount + 1
                                previousHit = True
                                computerStage = 2
                            End If
                        End If
                    End If
                End If

                'To add extra turns if necessary, depending on the difficulty set 
                If currentPlayer = 1 Then
                    Select Case difficulty
                        Case "Beginner" : playerextraTurn = True
                        Case "Normal" : playerextraTurn = False
                        Case "Hard" : playerextraTurn = False
                        Case "Unfair" : playerextraTurn = False
                        Case "Impossible" : playerextraTurn = True
                    End Select
                Else
                    If currentPlayer = 2 Then
                        Select Case difficulty
                            Case "Beginner" : computerextraTurn = False
                            Case "Normal" : computerextraTurn = False
                            Case "Hard" : computerextraTurn = False
                            Case "Unfair" : computerextraTurn = True
                            Case "Impossible" : computerextraTurn = False
                        End Select
                    End If
                End If
            End If
        End If

        'Determine if there are still battleships left to hit
        gameOver = True
        boardEmpty = True

        Dim row As Integer
        Dim column As Integer
        row = 0
        column = 0

        For row = 1 To gridSize
            For column = 1 To gridSize
                If gameArr(column, row) = 1 OrElse gameArr(column, row) = 4 Then
                    gameOver = False
                    boardEmpty = False
                End If
            Next column
        Next row
        Return gameArr
    End Function

    ''' <summary>
    ''' Subroutine updates the array of records of the individual ship which has been hit.
    ''' Example of use: updateShipsIfHit(5,4,1)
    ''' </summary>
    ''' <param name="MoveX">An integer representing the X coordinate of the move: eg. 5</param>
    ''' <param name="MoveY">An integer representing the Y coordinate of the move: eg. 4</param>
    ''' <param name="playerNum">The player who has just been shot at: eg 1 (the user if the opponent has just shot)</param>
    Private Sub updateShipRecOnHit(MoveX As Integer, MoveY As Integer, playerNum As Integer) 'Check if move has hit a ship
        Dim targetpicboxArr(,) As PictureBox
        Dim shipPicboxStr As String
        Dim shipStr As String
        Dim targetShip() As shipGridLocations
        Dim length As Integer
        Dim i As Integer
        i = 0

        'Find the string of the ship
        If playerNum = 1 Then
            targetpicboxArr = playerpictureBoxArray
            shipStr = "playerShip"

            'Gets the name of the picturebox associated with the ship (from the top layer of the picturebox array at the location of the moves)
            shipPicboxStr = GetShipFromParent(targetpicboxArr(MoveX, MoveY)).Name

            'Set the length and extract the string of the array of records associated with the ship
            If Strings.Right(shipPicboxStr, 1) = "a" Or Strings.Right(shipPicboxStr, 1) = "b" Then
                shipStr = shipStr + Strings.Right(shipPicboxStr, 2)
                length = 3
            Else
                shipStr = shipStr + Strings.Right(shipPicboxStr, 1)
                length = CInt(Strings.Right(shipPicboxStr, 1))
            End If
        Else
            'Gets the string of the array of records associated with the location
            shipStr = getShipFromMoves(MoveX, MoveY)

            'Extract the length
            If Strings.Right(shipStr, 1) = "a" Or Strings.Right(shipStr, 1) = "b" Then
                length = 3
            Else
                length = CInt(Strings.Right(shipStr, 1))
            End If
        End If

        'Get the array of records associated with this name in the string
        targetShip = CallByName(Me, shipStr, vbGet)

        'Update the hit if the position matches
        For i = 1 To length
            If targetShip(i).X = MoveX AndAlso targetShip(i).Y = MoveY Then
                targetShip(i).isHit = True
            End If
        Next i
    End Sub

    ''' <summary>
    ''' Function finds the array of records that is associated with the hit location and returns the string
    ''' Example of use: getShipFromMoves(5,3) = "opponentShip3a"
    ''' </summary>
    ''' <param name="MoveX">An integer representing the X coordinate of the move: eg. 5</param>
    ''' <param name="MoveY">An integer representing the Y coordinate of the move: eg. 4</param>
    ''' <returns>The string representing the name of the ship's array of records</returns>
    Private Function getShipFromMoves(MoveX As Integer, MoveY As Integer) As String
        Dim lengthstr As String
        Dim shipstr As String
        Dim correctShip As String
        Dim hasBeenHit As Boolean
        Dim targetship() As shipGridLocations
        Dim isDuplicateShip As Boolean
        Dim length As Integer
        Dim i As Integer
        length = 0
        i = 0
        correctShip = ""

        'Loop through each ship until the correct one is found
        Do
            For length = 2 To 5
                'The string of each ship
                lengthstr = length.ToString
                shipstr = "opponentShip" & length

                'The strings for the two 3 length ships (run the first and then the second by resetting back to length 3)
                If length = 4 AndAlso isDuplicateShip = True Then
                    length = 3
                End If
                Select Case length
                    Case 3
                        If isDuplicateShip = False Then
                            shipstr = "opponentShip3a"
                            isDuplicateShip = True
                        Else
                            shipstr = "opponentShip3b"
                            isDuplicateShip = False
                        End If
                End Select

                'Get the array of records associated with this name in the string
                targetship = CallByName(Me, shipstr, vbGet)

                'If the array of records is associated with the hit location: it is the correct ship
                For i = 1 To length
                    If targetship(i).X = MoveX AndAlso targetship(i).Y = MoveY Then
                        hasBeenHit = True
                        correctShip = shipstr
                    End If
                Next i
            Next length
        Loop Until hasBeenHit = True
        Return correctShip
    End Function


    Private Sub checkIfSunk(playerNum As Integer)
        'If a ship has been sunk
        Dim playerstr As String
        Dim shipstr As String
        Dim targetShip() As shipGridLocations
        Dim targetShipPicbox As PictureBox
        Dim targetShipPicboxStr As String
        Dim duplicateShip As Boolean
        Dim sunkArrStr As String
        Dim targetShipSunkArr() As Boolean
        Dim targetPicboxArr(,) As PictureBox
        Dim countOfShip As Integer
        Dim parentBoard As PictureBox
        Dim shipDirection As String
        Dim Xscale As Integer
        Dim Yscale As Integer
        Dim newLength As Integer
        Dim length As Integer
        Dim count As Integer
        length = 0
        count = 0

        For length = 2 To 5
            If playerNum = 1 Then
                playerstr = "player"
                sunkArrStr = "playerShipSunkArr"
                targetPicboxArr = playerpictureBoxArray
                parentBoard = Controls.Item("PlayerBoardBGImg")
            Else
                playerstr = "opponent"
                targetShipPicboxStr = playerstr & "ShipPicbox" & length
                sunkArrStr = "opponentShipSunkArr"
                targetPicboxArr = opponentpictureBoxArray
                parentBoard = Controls.Item("OpponentBoardBGImg")
            End If

            shipstr = playerstr & "Ship" & length
            If length = 4 AndAlso duplicateShip = True Then
                length = 3
            End If
            Select Case length
                Case 3
                    If duplicateShip = False Then
                        shipstr = shipstr & "a"
                        targetShipPicboxStr = playerstr & "ShipPicbox" & length & "a"
                        newLength = 3
                        duplicateShip = True
                    Else
                        shipstr = playerstr & "Ship3b"
                        targetShipPicboxStr = playerstr & "ShipPicbox" & length & "b"
                        newLength = 1
                        duplicateShip = False
                    End If
                Case Else : newLength = length
            End Select

            targetShipSunkArr = CallByName(Me, sunkArrStr, vbGet)
            If targetShipSunkArr(newLength) = False Then
                targetShip = CallByName(Me, shipstr, vbGet)

                If playerstr = "player" Then
                    targetShipPicbox = referenceShipFromParents(targetShipPicbox, length, shipstr, playerstr)
                Else
                    targetShipPicbox = Me.Controls.Item(targetShipPicboxStr)
                End If

                Dim shipSunk As Boolean
                shipSunk = True
                For count = 1 To length
                    If targetShip(count).isHit = False Then
                        shipSunk = False
                    Else
                        countOfShip = count
                    End If
                Next count

                If shipSunk = True Then
                    targetShipSunkArr(newLength) = True
                    If currentPlayer = 2 Then
                        NextShip = True
                        oppositePath = False
                    End If

                    If playerstr = "player" Then
                        MsgBox("Your " & length & " length ship has been sunk")
                    Else
                        If gameOver = False Then
                            MsgBox("You sunk the opponents " & length & " length ship")
                            playershipSunkCount = playershipSunkCount + 1
                        End If
                        targetShipPicbox.Visible = True
                        targetShipPicbox.Parent = parentBoard
                        targetShipPicbox.BringToFront()
                        If gameOver = False Then
                            targetShipPicbox.ImageLocation = Application.StartupPath & "\Pictures\BattleShip" & length & "Sunk.png"
                        Else
                            targetShipPicbox.ImageLocation = Application.StartupPath & "\Pictures\BattleShip" & length & "Unsunk.png"
                        End If
                        targetShipPicbox.Location = targetPicboxArr(targetShip(countOfShip).X, targetShip(countOfShip).Y).Location
                        targetShipPicbox.Load(targetShipPicbox.ImageLocation)

                        shipDirection = findDirectionFromShipGridLocs(targetShip, length)
                        Select Case shipDirection
                            Case "right"
                                Xscale = gridCircleSizeNum * length
                                Yscale = gridCircleSizeNum
                                targetShipPicbox.Location = targetShipPicbox.Location - New Point(((length - 1) * gridCircleSizeNum), 0)
                            Case "left"
                                Xscale = gridCircleSizeNum * length
                                Yscale = gridCircleSizeNum
                                targetShipPicbox = rotateImage90(targetShipPicbox)
                                targetShipPicbox = rotateImage90(targetShipPicbox)
                            Case "up"
                                Xscale = gridCircleSizeNum
                                Yscale = gridCircleSizeNum * length
                                targetShipPicbox = rotateImage90(targetShipPicbox)
                                targetShipPicbox = rotateImage90(targetShipPicbox)
                                targetShipPicbox = rotateImage90(targetShipPicbox)
                                targetShipPicbox.Location = targetShipPicbox.Location - New Point(0, ((length - 1) * gridCircleSizeNum))
                            Case "down"
                                Xscale = gridCircleSizeNum
                                Yscale = gridCircleSizeNum * length
                                targetShipPicbox = rotateImage90(targetShipPicbox)
                        End Select

                        targetShipPicbox.Size = New Size(Xscale, Yscale)
                    End If
                End If
            End If
        Next length
    End Sub

    ''' <summary>
    ''' Function determines the direction of the ship from the grid locations of the ship
    ''' Example of use: shipDirection = findDirectionFromShipGridLocs(targetShip, length)
    ''' </summary>
    ''' <param name="targetShip">The array of records associated with the specific ship and it's location</param>
    ''' <param name="length">An integer representing the length of the ship</param>
    ''' <returns>A string representing the direction of the ship. Eg. "right"</returns>
    Public Function findDirectionFromShipGridLocs(targetShip() As shipGridLocations, length As Integer) As String
        Dim direction As String
        'Checks whether the location one away from the end in a specific direction is the same location as the second last location of the shpi
        If (targetShip(length).X) - 1 = targetShip(length - 1).X Then
            direction = "right"
        Else
            If (targetShip(length).X) + 1 = targetShip(length - 1).X Then
                direction = "left"
            Else
                If (targetShip(length).Y) - 1 = targetShip(length - 1).Y Then
                    direction = "down"
                Else
                    direction = "up"
                End If
            End If
        End If
        Return direction
    End Function

    ''' <summary>
    ''' Function determines the end score of the user at the end of the game.
    ''' Also determines the outcome of the game (Win,Loss,Draw)
    ''' </summary>
    ''' <returns>The score of the user as an integer</returns>
    Private Function determineScore() As Integer
        'As swap player is after determine score in game(), the current player will always be the one who had the last move, and is hence, the winner
        Dim winner = currentPlayer
        Dim tempScore As Integer

        'To check whether the game has been ended by time or by sinking all the ships
        If boardEmpty = True Then
            If winner = 1 Then
                'Player wins
                gameOutcome = "Win"
            Else
                'Opponent Wins
                gameOutcome = "Lose"
            End If

            'Final score is playerscore - opponentscore
            tempScore = CInt(playerscoretxt.Text) - CInt(opponentscoretxt.Text)
        Else
            'If ended by the timer

            'Go through players array and calculate how many ships the player has left and add that to the score
            Dim row As Integer
            Dim column As Integer
            row = 0
            column = 0

            For row = 1 To gridSize
                For column = 1 To gridSize
                    If playergameArray(column, row) = 1 OrElse playergameArray(column, row) = 4 Then
                        tempScore = tempScore + 1
                    End If
                Next column
            Next row

            'Go through the opponents array and calculate how many the opponent has left and take that away from the score
            For row = 1 To gridSize
                For column = 1 To gridSize
                    If opponentgameArray(column, row) = 1 OrElse opponentgameArray(column, row) = 4 Then
                        tempScore = tempScore - 1
                    End If
                Next column
            Next row

            If tempScore > 0 Then
                'If score Is positive, Then the player has more ships left than the opponent and player wins
                gameOutcome = "Win"
            Else
                If tempScore = 0 Then
                    gameOutcome = "Draw"
                Else
                    gameOutcome = "Lose"
                End If
                'If score Is negative, Then the opponent has more ships left than the player and player loses
            End If
        End If
        If gameOutcome = "lose" OrElse gameOutcome = "Draw" Then
            revealships()
        End If
        Return tempScore
    End Function

    ''' <summary>
    ''' Subroutine counts the number of hits and updates the in-game score.
    ''' Example of use: updateInGameScore(1)
    ''' </summary>
    ''' <param name="currentPlayer">An integer representation of the player being updated</param>
    Private Sub updateInGameScore(currentPlayer As Integer)
        Dim playerScore As Integer
        Dim opponentScore As Integer
        Dim row As Integer
        Dim column As Integer
        row = 0
        column = 0

        'Count the number of hits and display the number
        If currentPlayer = 1 Then
            'For the player
            For row = 1 To gridSize
                For column = 1 To gridSize
                    If opponentgameArray(column, row) = 3 Then
                        playerScore = playerScore + 1
                    End If
                Next column
            Next row
            playerscoretxt.Text = playerScore
        Else
            'For the opponenet
            For row = 1 To gridSize
                For column = 1 To gridSize
                    If playergameArray(column, row) = 3 Then
                        opponentScore = opponentScore + 1
                    End If
                Next column
            Next row
            opponentscoretxt.Text = opponentScore
        End If
    End Sub

    ''' <summary>
    ''' Subroutine freezes the processing the computer for 10 milliseconds at a time until it reaches the given time
    ''' Example of use: wait(0.5)
    ''' </summary>
    ''' <param name="seconds">A single precision floating point of the number of seconds to wait for: eg. 0.5</param>
    Private Sub wait(ByVal seconds As Single)
        Dim i As Integer
        i = 0

        For i = 0 To seconds * 100
            'To allow the program to catch up instead of freezing the processing the entire time
            System.Threading.Thread.Sleep(10)
            'Catch up with events
            Application.DoEvents()
        Next i
    End Sub

    ''' <summary>
    ''' Subroutine displays the player or the opponents banner depending on the current player
    ''' </summary>
    Private Sub displayCurrentPlayer()
        If currentPlayer = 1 Then 'Player
            TurnsBannerPic.ImageLocation = Application.StartupPath & "\Pictures\PlayerTurnBanner.png"
        ElseIf currentPlayer = 2 Then 'Opponent
            TurnsBannerPic.ImageLocation = Application.StartupPath & "\Pictures\OpponentTurnBanner.png"
        End If
    End Sub

    ''' <summary>
    ''' Function is the mainline in determining the computers next move.
    ''' Process is determined by the difficulty chosen by the player.
    ''' </summary>
    ''' <returns>A record with X and Y fields representing the grid location</returns>
    Private Function computerMove() As gridLocation
        'Get the move for the computer
        Dim row As Integer
        Dim column As Integer
        row = 0
        column = 0

        Dim opponentMove As gridLocation
        Dim tempdifficulty As String

        'As only difference between Unfair and Hard difficulties is Extra turns, they have the same processes
        tempdifficulty = difficulty
        If tempdifficulty = "Unfair" Then
            tempdifficulty = "Hard"
        End If

        'What to do for each difficulty
        Select Case tempdifficulty
            Case "Beginner"
                opponentMove = randomSquare()

            Case "Normal"
                If hasAHit = False Then
                    'If there hasn't been a hit, randomly choose an avaliable square on the board
                    opponentMove = randomSquare()
                Else
                    'If there has been a hit, randomly choose an adjacent square to move to (hasAHit location changes every time there is a new hit)
                    opponentMove = randomAdjacent()
                End If

            Case "Hard"
                If hasAHit = False OrElse NextShip = True Then
                    'If there hasn't been a hit, randomly choose an avaliable square on the board
                    hasAHit = False
                    NextShip = False
                    opponentMove = randomSquare()
                Else
                    'If there has been a hit, computerStage will either be 1 or 2.
                    'Computer stage is 1 (from check()) if hasAhit was false when the opponents move hit a ship of the player
                    'Computer stage is 2 (from check()) if hasAhit was true when the opponents move hit a ship of the player

                    If computerStage = 1 Then
                        opponentMove = randomAdjacent()
                    Else 'Computer stage 2
                        If previousHit = True Then 'Set in check(), when hasAhit = True and there is another hit
                            opponentMove = continueOnPath() 'Follow the direction until previousHit = False
                        Else 'previousHit = false when the computer misses
                            If NextShip = True Then 'Set in check() if there is a miss after swapping path direction
                                hasAHit = False
                                opponentMove = randomSquare()
                            Else 'Has followed direction to a miss, will now swap direction and continue on the other side of the initial hasAhit
                                opponentMove = swapPathDirection()
                            End If
                        End If
                    End If
                End If

            Case "Impossible"
                'Go through the players array until there are no 1s or 4s left (all sunk).
                'Will go from the end of the array to the start as will continuously set the opponents move to the last 1 or 4 (which will turn into a 3 when in check())

                For row = 1 To gridSize
                    For column = 1 To gridSize
                        If playergameArray(column, row) = 1 OrElse playergameArray(column, row) = 4 Then
                            opponentMove.X = column
                            opponentMove.Y = row
                        End If
                    Next column
                Next row
        End Select
        Return opponentMove
    End Function

    ''' <summary>
    ''' Function randomly generates a grid location on the board that hasn't been already guessed.
    ''' </summary>
    ''' <returns>A record with X and Y fields representing the grid location</returns>
    Private Function randomSquare() As gridLocation
        Dim count As Integer
        count = 1
        Dim foundMovePos As Boolean
        Dim opponentMove As gridLocation

        'To make sure each location has not been taken already
        While foundMovePos = False And count < 20
            'Random locations for both X and Y
            opponentMove.X = Int(Rnd() * gridSize) + 1
            opponentMove.Y = Int(Rnd() * gridSize) + 1

            'If there is a hit or a miss then it can't put it's move there, and so it will need to loop around and get another random location
            'Ensures no second guess of a taken spot
            If playergameArray(opponentMove.X, opponentMove.Y) <> 2 AndAlso playergameArray(opponentMove.X, opponentMove.Y) <> 3 Then
                foundMovePos = True
            End If
            count = count + 1
        End While
        Return opponentMove
    End Function

    ''' <summary>
    ''' Function choses a random adjacent location (that hasn't already been guessed) to the previously hit location 
    ''' </summary>
    ''' <returns>A record with X and Y fields representing the grid location</returns>
    Private Function randomAdjacent() As gridLocation
        Dim foundMovePos As Boolean
        Dim count As Integer
        Dim opponentMove As gridLocation
        count = 1

        'To ensure a valid move is chosen, bailing out at 20 (a reasonable number for random generation of 4 possible numbers)
        While foundMovePos = False And count < 20
            'Generate a random direction (left, right, up, down)
            opponentMoveDirection = Int(Rnd() * 4) + 1

            Select Case opponentMoveDirection
                Case 1  'left
                    If hasAhitLocation.X > 1 AndAlso alreadyLeft = False AndAlso playergameArray(hasAhitLocation.X - 1, hasAhitLocation.Y) <> 2 AndAlso playergameArray(hasAhitLocation.X - 1, hasAhitLocation.Y) <> 3 Then
                        'if in a valid location (not to close to the edge of the board)
                        'if it hasn't been chosen already
                        'if it doesn't already had a hit or a miss

                        'One to the left of hasAhit
                        opponentMove.X = hasAhitLocation.X - 1
                        opponentMove.Y = hasAhitLocation.Y
                        alreadyLeft = True
                        foundMovePos = True
                    End If

                Case 2 'right
                    If hasAhitLocation.X < gridSize AndAlso alreadyRight = False AndAlso playergameArray(hasAhitLocation.X + 1, hasAhitLocation.Y) <> 2 AndAlso playergameArray(hasAhitLocation.X + 1, hasAhitLocation.Y) <> 3 Then
                        'One to the right of hasAhit
                        opponentMove.X = hasAhitLocation.X + 1
                        opponentMove.Y = hasAhitLocation.Y
                        alreadyRight = True
                        foundMovePos = True
                    End If

                Case 3 'up
                    If hasAhitLocation.Y < gridSize AndAlso alreadyUp = False AndAlso playergameArray(hasAhitLocation.X, hasAhitLocation.Y + 1) <> 2 AndAlso playergameArray(hasAhitLocation.X, hasAhitLocation.Y + 1) <> 3 Then
                        'One above of hasAhit
                        opponentMove.Y = hasAhitLocation.Y + 1
                        opponentMove.X = hasAhitLocation.X
                        alreadyUp = True
                        foundMovePos = True
                    End If

                Case 4 'down
                    If hasAhitLocation.Y > 1 AndAlso alreadyDown = False AndAlso playergameArray(hasAhitLocation.X, hasAhitLocation.Y - 1) <> 2 AndAlso playergameArray(hasAhitLocation.X, hasAhitLocation.Y - 1) <> 3 Then
                        'One below hasAhit
                        opponentMove.Y = hasAhitLocation.Y - 1
                        opponentMove.X = hasAhitLocation.X
                        alreadyDown = True
                        foundMovePos = True
                    End If
            End Select
            count = count + 1
        End While

        'If there are no valid places
        If count = 20 Then
            'Go back to randomly guessing
            hasAHit = False
            opponentMove = randomSquare()
        End If
        Return opponentMove
    End Function

    ''' <summary>
    ''' Function continues guessing along the path of the previous hit.
    ''' If it's path is blocked by a previous guess, then it has either sunk (if it has already swapped directions) the ship or it has reached the end of one and needs to swap its direction (Original guess in the middle of the ship)
    ''' </summary>
    ''' <returns>A record with X and Y fields representing the grid location</returns>
    Private Function continueOnPath() As gridLocation
        Dim validMove As Boolean
        Dim opponentMove As gridLocation

        'Uses direction randomly generated by randomAdjacent
        Select Case opponentMoveDirection
            Case 1 'left
                If hasAhitLocation.X > 1 AndAlso playergameArray(hasAhitLocation.X - opponentContinueOnCount, hasAhitLocation.Y) <> 2 AndAlso playergameArray(hasAhitLocation.X - opponentContinueOnCount, hasAhitLocation.Y) <> 3 Then
                    'if in a valid location (not to close to the edge of the board)
                    'if it hasn't been chosen already
                    'if it doesn't already had a hit or a miss

                    'To the left of hasAhit by how many opponentContinueOnCount is (incremented in check())
                    opponentMove.X = hasAhitLocation.X - opponentContinueOnCount
                    opponentMove.Y = hasAhitLocation.Y
                    validMove = True
                End If
            Case 2 'right
                If hasAhitLocation.X < gridSize AndAlso playergameArray(hasAhitLocation.X + opponentContinueOnCount, hasAhitLocation.Y) <> 2 AndAlso playergameArray(hasAhitLocation.X + opponentContinueOnCount, hasAhitLocation.Y) <> 3 Then
                    'To the right of hasAhit by opponentContinueOnCount
                    opponentMove.X = hasAhitLocation.X + opponentContinueOnCount
                    opponentMove.Y = hasAhitLocation.Y
                    validMove = True
                End If

            Case 3 'up
                If hasAhitLocation.Y < gridSize AndAlso playergameArray(hasAhitLocation.X, hasAhitLocation.Y + opponentContinueOnCount) <> 2 AndAlso playergameArray(hasAhitLocation.X, hasAhitLocation.Y + opponentContinueOnCount) <> 3 Then
                    'Above hasAhit by opponentContinueOnCount
                    opponentMove.X = hasAhitLocation.X
                    opponentMove.Y = hasAhitLocation.Y + opponentContinueOnCount
                    validMove = True
                End If

            Case 4 'down
                If hasAhitLocation.Y > 1 AndAlso playergameArray(hasAhitLocation.X, hasAhitLocation.Y - opponentContinueOnCount) <> 2 AndAlso playergameArray(hasAhitLocation.X, hasAhitLocation.Y - opponentContinueOnCount) <> 3 Then
                    'Below hasAhit by opponentContinueOnCount
                    opponentMove.X = hasAhitLocation.X
                    opponentMove.Y = hasAhitLocation.Y - opponentContinueOnCount
                    validMove = True
                End If
        End Select

        If validMove = False Then
            'If it cannot continue down a path because it is blocked
            If oppositePath = True Then
                'If it is already swapped direction then the ship should be sunk, so random square is called and variables are reset
                opponentMove = randomSquare()
                oppositePath = False
                NextShip = False
                hasAHit = False
            Else
                'Swap directions if it hasn't already
                opponentMove = swapPathDirection()
            End If
        End If
        Return opponentMove
    End Function

    ''' <summary>
    ''' Function swaps the direction path for the computer move and continues it's guess.
    ''' </summary>
    ''' <returns>>A record with X and Y fields representing the grid location</returns>
    Private Function swapPathDirection() As gridLocation
        Dim opponentMove As gridLocation
        'Swap the direction of the path
        oppositePath = True
        Select Case opponentMoveDirection
            Case 1 : opponentMoveDirection = 2 'left -> right
            Case 2 : opponentMoveDirection = 1 'right -> left
            Case 3 : opponentMoveDirection = 4 'up -> down
            Case 4 : opponentMoveDirection = 3 'down -> up
        End Select
        opponentContinueOnCount = 1
        opponentMove = continueOnPath()
        Return opponentMove
    End Function

    ''' <summary>
    ''' Subroutine switches between the value of 1 and 2 each time to swap players after each turn
    ''' Alternates and displays
    ''' </summary>
    Private Sub swapPlayer()
        currentPlayer = AlternateNum(currentPlayer)
        displayCurrentPlayer()
    End Sub

    ''' <summary>
    ''' Function returns an integer that alternates between a 1 and a 2 each time it is called
    ''' Example: AlternateNum(2) = 1
    ''' </summary>
    ''' <param name="num">An integer, either 1 or 2</param>
    ''' <returns>An integer of either 1 or 2: opposite to the passed in value</returns>
    Public Function AlternateNum(num As Integer)
        num = 2 / num
        Return num
    End Function

    ''' <summary>
    ''' Subroutine takes the user back to the main menu form when clicked.
    ''' Runs the gameIsOverNoResult() to make sure score is not recorded, but game is left in a state that a new one can be created by the user. 
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        'Exit back to the main menu
        gameIsOverNoResult()
        Me.Hide()
        MainMenuForm.Show()
    End Sub

    ''' <summary>
    ''' Subroutine which calls the EnterOverSmallButton() from the highscores form upon moving mouse over the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Enter(sender As Object, e As EventArgs) Handles backtomainbtn.MouseEnter

        HighScoresForm.EnterOverSmallButton("backtomainbtn", Me)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the ExitOverSmallButton() from the highscores form upon moving mouse off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Leave(sender As Object, e As EventArgs) Handles backtomainbtn.MouseLeave
        HighScoresForm.ExitOverSmallButton("backtomainbtn", Me)
    End Sub

    ''' <summary>
    ''' Subroutine reloads the page when clicked.
    ''' Disables itself from being clicked for 2 seconds after the form has been re-loaded to stop the user from being able to spam click it.
    ''' Runs the gameIsOverNoResult() to make sure score is not recorded, but game is left in a state that a new one can be run.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        'Reload the page
        resetbtn.Enabled = False
        gameIsOverNoResult()
        onFormLoad()
        wait(2)
        resetbtn.Enabled = True
    End Sub

    ''' <summary>
    ''' Subroutine which calls the EnterOverSmallButton() from the highscores form upon moving mouse over the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub resetbtn_Enter(sender As Object, e As EventArgs) Handles resetbtn.MouseEnter
        HighScoresForm.EnterOverSmallButton("resetbtn", Me)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the ExitOverSmallButton() from the highscores form upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub resetbtn_Leave(sender As Object, e As EventArgs) Handles resetbtn.MouseLeave
        HighScoresForm.ExitOverSmallButton("resetbtn", Me)
    End Sub

    ''' <summary>
    ''' Subroutine changes the grid circle from a transparent circle to a green circle (hover)
    ''' Each picbox created in generatePicture() has been set to handle this subroutine
    ''' Example of use: AddHandler picbox.MouseEnter, AddressOf mouseEnterGridCircle
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub mouseEnterGridCircle(ByVal sender As PictureBox, ByVal e As EventArgs)
        Dim picbox As PictureBox
        picbox = sender
        If picbox.ImageLocation = (Application.StartupPath & "\pictures\TransparentCircle.png") Then
            'To change a transparent circle to a green circle
            picbox.ImageLocation = Application.StartupPath & "\pictures\GreenCircle.png"
            resizeAndMoveImageWithinPicbox(picbox, 1, gridCircleSizeNum, "noDirection")
        Else
            'To change a 'hidden' ship location with a transparent circle to a green circle
            If picbox.ImageLocation = Application.StartupPath & "\pictures\TransparentCircleHidden.png" Then
                picbox.ImageLocation = Application.StartupPath & "\pictures\GreenCircleHidden.png"
                resizeAndMoveImageWithinPicbox(picbox, 1, gridCircleSizeNum, "noDirection")
            End If
        End If
    End Sub

    ''' <summary>
    ''' Subroutine changes the grid circle back to a transparent circle from a green circle.
    ''' Each picbox created in generatePicture() has been set to handle this subroutine
    '''  Example of use: AddHandler() picbox.MouseLeave, AddressOf mouseExitGridCircle
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub mouseExitGridCircle(ByVal sender As PictureBox, ByVal e As EventArgs)
        Dim picbox As PictureBox
        picbox = sender
        If picbox.ImageLocation = Application.StartupPath & "\pictures\GreenCircle.png" Then
            'To change back a green circle to a transparent circle
            picbox.ImageLocation = Application.StartupPath & "\pictures\TransparentCircle.png"
            resizeAndMoveImageWithinPicbox(picbox, 1, gridCircleSizeNum, "noDirection")
        Else
            'To change a 'hidden' ship location with a green circle back to a transparent circle
            If picbox.ImageLocation = Application.StartupPath & "\pictures\GreenCircleHidden.png" Then
                picbox.ImageLocation = Application.StartupPath & "\pictures\TransparentCircleHidden.png"
                resizeAndMoveImageWithinPicbox(picbox, 1, gridCircleSizeNum, "noDirection")
            End If
        End If
    End Sub

    ''' <summary>
    ''' Subroutine in charge of the highscores
    ''' The mainline of scoring
    ''' </summary>
    Private Sub scoring()
        'Read the high-scores from the hs.txt file
        readHighScores()

        'Add in players score
        addPlayerScoreToHighscores()

        'Sort the scores
        BubbleSort(True, True)

        'Write the scores to the file
        WriteHighScores()
    End Sub

    ''' <summary>
    ''' Subroutine that adds the players score, name, difficulty and time into the 11th element of the array of records
    ''' </summary>
    Private Sub addPlayerScoreToHighscores()
        'To overwrite the temporary 11th element created in the highscores form with the user's info
        arrHighScores(11).score = score
        arrHighScores(11).name = playerName
        arrHighScores(11).difficulty = difficulty
        arrHighScores(11).time = convertStringIntegerTimeToDisplayTime(time)
    End Sub

    ''' <summary>
    ''' Subroutine reads the highscores from a text file
    ''' Inputs the contents into the first 10 elements of the highscores records
    ''' </summary>
    Public Sub readHighScores()
        Dim i As Integer
        i = 0

        'Open the hs.txt file for Input (read)
        FileSystem.FileOpen(1, "hs.txt", OpenMode.Input)

        'For the top 10 in 'default' sorting
        For i = 1 To 10
            'score
            Dim fileContents
            FileSystem.Input(1, fileContents)
            arrHighScores(i).score = fileContents

            'name
            FileSystem.Input(1, fileContents)
            arrHighScores(i).name = fileContents

            'time
            FileSystem.Input(1, fileContents)
            fileContents = convertStringIntegerTimeToDisplayTime(CInt(fileContents))
            arrHighScores(i).time = fileContents

            'difficulty
            FileSystem.Input(1, fileContents)
            arrHighScores(i).difficulty = fileContents
        Next i
        FileSystem.FileClose(1)
    End Sub

    ''' <summary>
    ''' Subroutine writes each element a field a time into a text file
    ''' </summary>
    Public Sub WriteHighScores()
        Dim i As Integer
        i = 0

        'Open the hs.txt file for Outpue (write)
        FileSystem.FileOpen(1, "hs.txt", OpenMode.Output)
        For i = 1 To 10
            FileSystem.Write(1, arrHighScores(i).score)
            FileSystem.Write(1, arrHighScores(i).name)
            FileSystem.Write(1, convertDisplayTimeToIntegerStringTime(arrHighScores(i).time))
            FileSystem.Write(1, arrHighScores(i).difficulty)
        Next i
        FileSystem.FileClose(1)
    End Sub

    ''' <summary>
    ''' Function which converts a string representing integer time (dddd) into a display time (dd:dd) 
    ''' Example of use: convertDisplayTimeToIntegerStringTime("610") = "10:10"
    ''' </summary>
    ''' <param name="time">A string representing integer time in dddd format. Eg. "610"</param>
    ''' <returns>A string representing the display time. Eg. "10:10"</returns>
    Public Function convertStringIntegerTimeToDisplayTime(time As Integer) As String
        Dim newTime As String
        Select Case time
            Case >= 3599 : newTime = "59:59" 'Greater than an hour
            Case < 10 : newTime = "00:0" & CStr(time) 'Less than 10s
            Case < 60 : newTime = "00:" & CStr(time) 'Less than a minute
            Case < 600 'less than 10min
                Select Case True
                    'Subtract the minutes from the time and deal with the left over seconds
                    Case time - (Math.Floor(time / 60) * 60) = 0 : newTime = "0" & Math.Floor(time / 60) & ":" & "00"
                    Case time - (Math.Floor(time / 60) * 60) < 10 : newTime = "0" & Math.Floor(time / 60) & ":0" & (time - (Math.Floor(time / 60) * 60))
                    Case Else : newTime = "0" & Math.Floor(time / 60) & ":" & (time - (Math.Floor(time / 60) * 60))
                End Select

            Case Else 'anything above 10min
                Select Case True
                     'Subtract the minutes from the time and deal with the left over seconds
                    Case time - (Math.Floor(time / 60) * 60) = 0 : newTime = Math.Floor(time / 60) & ":" & "00" 'Only minutes no seconds
                    Case time - (Math.Floor(time / 60) * 60) < 10 : newTime = Math.Floor(time / 60) & ":0" & (time - (Math.Floor(time / 60) * 60)) 'Leftovers less than 10s
                    Case Else : newTime = Math.Floor(time / 60) & ":" & (time - (Math.Floor(time / 60) * 60)) 'Minutes : seconds
                End Select
        End Select
        Return newTime
    End Function

    ''' <summary>
    ''' Function which converts display time (dd:dd) into a string representing integer time (dddd)
    ''' Example of use: convertDisplayTimeToIntegerStringTime("10:10") = "610"
    ''' </summary>
    ''' <param name="time">A string representing time in dd:dd format. Eg. "10:10"</param>
    ''' <returns>A string representing the integer conversion. Eg. "610"</returns>
    Private Function convertDisplayTimeToIntegerStringTime(time As String) As String
        'subtime as integer to be added after leading 0s
        Dim subtime As String
        Dim newtime As String
        Select Case time
            Case "00:00" : newtime = timeLeft 'To make sure that 00:00 does not run (impossible time)
                Select Case newtime.Length 'To pad the time to be characters digits long
                    Case 1 : newtime = "000" & newtime
                    Case 2 : newtime = "00" & newtime
                    Case 3 : newtime = "0" & newtime
                End Select
            Case "59:59" : newtime = "3599"
            Case Else ' 
                Select Case True
                        'under 10 sec
                    Case time(0) = "0" AndAlso time(1) = "0" AndAlso time(3) = "0" : subtime = Mid(time, 5, 1)
                        newtime = "000" & subtime

                        'between 10s and 1min
                    Case time(0) = "0" AndAlso time(1) = "0" : subtime = Mid(time, 4, 2)
                        newtime = "00" & subtime

                        'between 1min and 10min
                    Case time(0) = "0" : subtime = CStr(CInt(Mid(time, 4, 2)) + Math.Floor(CInt(Mid(time, 2, 1) * 60)))
                        newtime = "0" & subtime

                        'anything above 10min
                    Case Else : newtime = CStr(CInt(Mid(time, 4, 2)) + Math.Floor(CInt(Mid(time, 1, 2) * 60)))
                End Select
        End Select
        Return newtime
    End Function

    ''' <summary>
    ''' Subroutine sorts the array of records 'highscores' into an order determined by the user.
    ''' Example of use: BubbleSort(True, True)
    ''' </summary>
    ''' <param name="isTypeScore">A boolean representing whether to sort by the score field or by the time field of the record</param>
    ''' <param name="orderAsDescending">A boolean determining whether to sort in ascending or descending order</param>
    Public Sub BubbleSort(isTypeScore As Boolean, orderAsDescending As Boolean)
        Dim Swapped As Boolean
        Swapped = True
        Dim Last As Integer
        Last = arrHighScores.Length - 1

        'Swapped as a bailout if in order (no swaps) instead of having to keep checking
        While Swapped = True
            Swapped = False
            Dim i = 1
            'i < last means that it once i = last, it will be in order
            While i < Last
                If isTypeScore = True Then
                    If orderAsDescending = True Then

                        'Temporary fake score as lower than possible so it can't show up as top 10 in descending
                        If arrHighScores(11).name = "ZZZZZZ" Then
                            arrHighScores(11).score = -50
                        End If

                        'Swap if the current one is smaller than the one on it's right
                        If arrHighScores(i).score < arrHighScores(i + 1).score Then
                            Swap(arrHighScores(i), arrHighScores(i + 1))
                            Swapped = True
                        End If
                    Else
                        'Temporary fake score as higher than possible so it can't show up as top 10 in ascending
                        If arrHighScores(11).name = "ZZZZZZ" Then
                            arrHighScores(11).score = 50
                        End If

                        'Swap if the current one is bigger than the one on it's right
                        If arrHighScores(i).score > arrHighScores(i + 1).score Then
                            Swap(arrHighScores(i), arrHighScores(i + 1))
                            Swapped = True
                        End If
                    End If

                Else
                    If orderAsDescending = True Then
                        'Temporary fake time as lower than possible so it can't show up as top 10
                        If arrHighScores(11).name = "ZZZZZZ" Then
                            arrHighScores(11).time = "00:00"
                        End If

                        'Swap if the current one is smaller than the one on it's right
                        If CInt(convertDisplayTimeToIntegerStringTime(arrHighScores(i).time)) < CInt(convertDisplayTimeToIntegerStringTime(arrHighScores(i + 1).time)) Then
                            Swap(arrHighScores(i), arrHighScores(i + 1))
                            Swapped = True
                        End If
                    Else
                        'Temporary fake score as highest possible so it can't show up as top 10 in ascending
                        If arrHighScores(11).name = "ZZZZZZ" Then
                            arrHighScores(11).time = "59:59"
                        End If

                        'Swap if the current one is bigger than the one on it's right
                        If CInt(convertDisplayTimeToIntegerStringTime(arrHighScores(i).time)) > CInt(convertDisplayTimeToIntegerStringTime(arrHighScores(i + 1).time)) Then
                            Swap(arrHighScores(i), arrHighScores(i + 1))
                            Swapped = True
                        End If
                    End If
                End If
                i = i + 1
            End While
            Last = Last - 1
        End While
    End Sub

    ''' <summary>
    ''' Subroutine updates the game stats on the form controls
    ''' Example of use: updateGameStats(4,2,2)
    ''' </summary>
    ''' <param name="hitcount">Integer number of accurate shots (a hit)</param>
    ''' <param name="misscount">Integer number of inaccurate shots (a miss)</param>
    ''' <param name="playernum">Integer representation of the current player: either 1 for player or 2 for opponent</param>
    Private Sub updateGameStats(hitcount As Integer, misscount As Integer, playernum As Integer)
        Dim accuracy As String
        If misscount = 0 AndAlso hitcount = 0 Then 'Undefined accuracy (0/0 not defined)
            accuracy = "-"
        Else
            'Calculating the percentage average of hit:shot ratio and converting it to a string
            accuracy = CStr(CInt((hitcount / (misscount + hitcount)) * 100)) & "%"
        End If

        'Updating the statistics onto the form labels
        If playernum = 1 Then
            playerAccuracyCounttxt.Text = accuracy
            playerHitCounttxt.Text = hitcount
            playerMissCounttxt.Text = misscount
            playerShipsHitCounttxt.Text = playershipSunkCount
            playerShipsLeftCounttxt.Text = playershipHitListCount - playershipSunkCount
        Else
            opponentAccuracyCounttxt.Text = accuracy
            opponentShipsHitCounttxt.Text = hitcount
            opponentShipsMissCounttxt.Text = misscount
        End If
    End Sub

    ''' <summary>
    ''' Subroutine swaps two arbitary records of recHighScore
    ''' To be used in bubblesorting
    ''' Example of use:  swap(arrHighScores(1), arrHighScores(2))
    ''' </summary>
    ''' <param name="A">An arbitary record to be swapped</param>
    ''' <param name="B">A different arbitary record to be swapped</param>
    Private Sub swap(ByRef A As recHighScore, ByRef B As recHighScore)
        'swap records by using a temporary value
        Dim Temp As recHighScore
        Temp = A
        A = B
        B = Temp
    End Sub

    ''' <summary>
    ''' Subroutine which intialises the timer and the interval of its tick
    ''' </summary>
    Private Sub timeInitialise()
        gameTimer.Interval = 1000 '1000milliseconds = 1 second
        If timeOptionAsCountUp = False Then
            'Time left is the time on the timer the user chose in the game Settings form
            time = timeLeft
            displayTime = convertStringIntegerTimeToDisplayTime(time)
        End If
        timelbl.Text = displayTime
    End Sub

    ''' <summary>
    ''' Subroutine starts the timer if the game is NOT over
    ''' </summary>
    Private Sub timeStart()
        If gameOver = False Then
            gameTimer.Start()
        End If
    End Sub

    ''' <summary>
    ''' Subroutine ends the timer if the game is over and resets the displayTime to be ""
    ''' </summary>
    Private Sub timeEnd()
        If gameOver = True Then
            gameTimer.Stop()
            displayTime = ""
        End If
    End Sub

    ''' <summary>
    ''' Subroutine is called every second (tick)
    ''' Displays the time on the control label
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub gametimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If timeOptionAsCountUp = True Then
            'Count up
            time = time + 1
            If time = 3599 Then 'If the hour limit is reached: gameOver
                If formID = "Game" Then
                    gameIsOverWithResult()
                End If
            End If
        Else
            If time = 0 Then 'If the timer has run out
                If formID = "Game" Then
                    gameIsOverWithResult()
                End If
            Else 'Count down
                time = time - 1
            End If
        End If

        'display time on form
        displayTime = convertStringIntegerTimeToDisplayTime(time)
        timelbl.Text = displayTime
    End Sub
End Class