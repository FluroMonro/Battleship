Imports System.Diagnostics.PerformanceData
Imports System.Drawing.Text
Imports System.Reflection.Emit
Imports System.Runtime.CompilerServices
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
    Public opponentShip2sunk As Boolean
    Public opponentShip3asunk As Boolean
    Public opponentShip3bsunk As Boolean
    Public opponentShip4sunk As Boolean
    Public opponentShip5sunk As Boolean
    Public playerShip2sunk As Boolean
    Public playerShip3asunk As Boolean
    Public playerShip3bsunk As Boolean
    Public playerShip4sunk As Boolean
    Public playerShip5sunk As Boolean

    Public alreadyLeft As Boolean
    Public alreadyRight As Boolean
    Public alreadyUp As Boolean
    Public alreadyDown As Boolean
    Public opponentMoveDirection As Integer
    Public opponentContinueOnCount As Integer
    Public Sub updateGlobalVars(name As String, size As Integer, userDifficulty As String, shipPlacementOption As Boolean, timeOption As Boolean, timeSet As Integer)
        'Updating the global variables from across forms
        playerName = name
        gridSize = size
        difficulty = userDifficulty
        isShipPlacementRandom = shipPlacementOption
        timeOptionAsCountUp = timeOption
        timeLeft = timeSet
        formID = "Game"
    End Sub
    Public Sub onFormLoad()
        gameTimer.Stop()
        timeInitialise()

        initialiseFormControls()
        initialiseVariables()

        'reset the boards before generating a new
        resetGameArray(opponentgameArray)
        resetGameArray(playergameArray)

        'Generate the array of picture boxes that represents the game array 
        generatePicture(opponentpictureBoxArray, OpponentBoardBGImg, 2)
        generatePicture(playerpictureBoxArray, PlayerBoardBGImg, 1)



        'generate the 2D array: gameArray randomly (both computer and Player)
        generateGameArr(opponentgameArray, 2)
        generateGameArr(playergameArray, 1)

        'Assign the correct grid images for the picture box array to be represent the game array
        assignGridImages(opponentgameArray, opponentpictureBoxArray)
        assignGridImages(playergameArray, playerpictureBoxArray)
    End Sub
    Private Sub initialiseVariables()
        Dim playerMissCount = 0
        Dim playerHitCount = 0
        Dim opponentMissCount = 0
        Dim opponentHitCount = 0
        Dim playershipSunkCount = 0
        updateGameStats(playerHitCount, playerMissCount, 1)
        updateGameStats(opponentHitCount, opponentMissCount, 2)

        'Initialise all the global variable
        currentPlayer = 1
        opponentShip2sunk = False
        opponentShip3asunk = False
        opponentShip3bsunk = False
        opponentShip4sunk = False
        opponentShip5sunk = False
        playerShip2sunk = False
        playerShip3asunk = False
        playerShip3bsunk = False
        playerShip4sunk = False
        playerShip5sunk = False
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
    Private Sub initialiseFormControls()
        'To intialise the controls in the correct way

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

        backgroundImg.ImageLocation = Application.StartupPath & "\Pictures\gameBackground.png"
        backgroundImg.Location = New Point(0, 0)
        backgroundImg.Size = New Size(Me.Width - 15, Me.Height - 38)

        'Setting the size of the grid circle to be dependent on the boardSize (minus it's border) and divided by how many elements the grid is
        'Ability to adjust the sizes of the grid and to have corresponding changes to the size of each circle
        gridCircleSizeNum = (boardSizes - 30) / gridSize
        'Variables used for setting target object to be able to automate and loop controls 
        Dim duplicateShip As Boolean
        Dim targetObject As PictureBox
        Dim shippicstr As String
        Dim currentplayerstr As String
        'For both player and opponent

        'MsgBox(opponentShipPicbox2.Parent.Name)

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
                Dim targetship
                Dim targetpicboxArr
                shipstr = currentplayerstr & "Ship" & shippicstr
                targetship = CallByName(Me, shipstr, vbGet)
                targetpicboxArr = CallByName(Me, currentplayerstr & "pictureBoxArray", vbGet)

                targetObject = Me.Controls.Item(currentplayerstr & "ShipPicbox" & shippicstr)
                If targetObject Is Nothing Then
                    targetObject = targetpicboxArr(targetship(length).X, targetship(length).Y).GetChildAtPoint(New Point(0, 0), 0)
                    Dim count = 0
                    Do
                        targetObject = targetObject.GetChildAtPoint(New Point(0, 0), 0)
                        count = count + 1
                    Loop Until targetObject Is Nothing

                    targetObject = targetpicboxArr(targetship(length).X, targetship(length).Y).GetChildAtPoint(New Point(0, 0), 0)
                    For i = 1 To (count - 1)
                        targetObject = targetObject.GetChildAtPoint(New Point(0, 0), 0)
                    Next i
                End If
                targetObject.Location = New Point(100, 100)
                targetObject.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
                targetObject.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"
                targetObject.Parent = Me
            Next length
        Next

        'opponentStatspnl.Location = New Point(boardSizes + Me.Width / 3, Me.Height / 3 + boardSizes)

        'will hide the opponents ships if gameOver = false and the players ship until they have been positioned

        'revealships()
    End Sub
    Private Sub resetGameArray(array As Array)
        'resets the entire array to all 0s
        Dim row, col As Integer
        For col = 1 To gridSize
            For row = 1 To gridSize
                array(col, row) = 0
            Next row
        Next col
    End Sub
    Public Sub generatePicture(pictureBoxArray As Array, picBoard As Object, currentPlayer As Integer)
        'generates grid of pictures

        Dim col As Integer
        Dim row As Integer

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
                If currentPlayer = 1 Then
                    'for player
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
                Else
                    If currentPlayer = 2 Then
                        'for opponent
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

                        'Adding the option to click and send to getPlayerMove function
                        AddHandler picbox.Click, AddressOf getPlayerMove
                        AddHandler picbox.MouseEnter, AddressOf mouseEnterGridCircle
                        AddHandler picbox.MouseLeave, AddressOf mouseExitGridCircle
                    End If
                End If
                'Image presentation
                picbox.ImageLocation = Application.StartupPath & "\pictures\transparentCircle.png"
                picbox.SizeMode = PictureBoxSizeMode.StretchImage
            Next col
        Next row
    End Sub
    Private Sub generateGameArr(gameArr As Array, player As Integer)
        'To generate the game array, whether randomly or by choice
        WindowState = FormWindowState.Minimized
        If isShipPlacementRandom = True Then
            generateShips(gameArr, 2, player)
            generateShips(gameArr, 3, player)
            generateShips(gameArr, 3, player)
            generateShips(gameArr, 4, player)
            generateShips(gameArr, 5, player)
            wait(0.2)
        Else
            If isShipPlacementRandom = False Then
                MsgBox("own choice shipPlacement")
            End If
        End If

    End Sub
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
                direction = Int(Rnd()) + 2
                'direction = Int(Rnd() * 4) + 1

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
                If isValidPlace(col, row, length, direction) = True Then
                    Select Case length
                        Case 2
                            If gameArr(col + signedIndicatorX, row + signedIndicatorY) = 0 Then
                                'If the element to the left is empty: Set the initially chosen location and the one to the left as a ship
                                valid = loopThroughForEachShipUntilValidAndChangeValue(signedIndicatorX, signedIndicatorY, length, directionShipFacing, col, row, gameArr, currentplayernum)
                                'Set the respective ship record to the same starting location
                            End If
                        Case 3
                            'If the element to the left is empty and the one to the left of that is also empty: Set all 3 to be a ship
                            If gameArr(col + signedIndicatorX, row + signedIndicatorY) = 0 AndAlso gameArr(col + (2 * signedIndicatorX), row + (2 * signedIndicatorY)) = 0 Then
                                valid = loopThroughForEachShipUntilValidAndChangeValue(signedIndicatorX, signedIndicatorY, length, directionShipFacing, col, row, gameArr, currentplayernum)

                            End If
                        Case 4
                            'If all the other 3 squares are empty: set all 4 to be ships
                            If gameArr(col + signedIndicatorX, row + signedIndicatorY) = 0 AndAlso gameArr(col + (2 * signedIndicatorX), row + (2 * signedIndicatorY)) = 0 AndAlso gameArr(col + (3 * signedIndicatorX), row + (3 * signedIndicatorY)) = 0 Then
                                valid = loopThroughForEachShipUntilValidAndChangeValue(signedIndicatorX, signedIndicatorY, length, directionShipFacing, col, row, gameArr, currentplayernum)
                            End If
                        Case 5
                            'If all the other 4 squares are empty: set all 5 to be ships
                            If gameArr(col + signedIndicatorX, row + signedIndicatorY) = 0 AndAlso gameArr(col + (2 * signedIndicatorX), row + (2 * signedIndicatorY)) = 0 AndAlso gameArr(col + (3 * signedIndicatorX), row + (3 * signedIndicatorY)) = 0 AndAlso gameArr(col + (4 * signedIndicatorX), row + (4 * signedIndicatorY)) = 0 Then
                                valid = loopThroughForEachShipUntilValidAndChangeValue(signedIndicatorX, signedIndicatorY, length, directionShipFacing, col, row, gameArr, currentplayernum)
                            End If
                    End Select
                End If
            End If
        End While

        'useful for debuging purposes, to determine where the head of the ship is. Can be used to turn the square in the front of the ship to a different colour circle
        gameArr(col, row) = 4
        'Assign the ships with each picture box
        assignShips(gameArr, currentplayernum, length, directionShipFacing, col, row)

        Return gameArr
    End Function
    Private Function loopThroughForEachShipUntilValidAndChangeValue(signedIndicatorX As Integer, signedIndicatorY As Integer, length As Integer, directionShipFacing As String, col As Integer, row As Integer, gameArr As Array, currentplayernum As Integer) As Boolean
        Dim X As Integer
        Dim Y As Integer
        Dim RowOrColumn As Integer
        Dim i As Integer

        Select Case directionShipFacing
            Case "right"
                RowOrColumn = col
                For i = RowOrColumn To (RowOrColumn + (signedIndicatorX * (length - 1))) Step -1
                    X = i
                    Y = row

                    gameArr(X, Y) = 1
                Next i


            Case "left"
                RowOrColumn = col
                For i = RowOrColumn To (RowOrColumn + (signedIndicatorX * (length - 1)))
                    X = i
                    Y = row

                    gameArr(X, Y) = 1
                Next i

            Case "up"
                RowOrColumn = row
                For i = RowOrColumn To (RowOrColumn + (signedIndicatorY * (length - 1))) Step -1
                    X = col
                    Y = i

                    gameArr(X, Y) = 1
                Next i

            Case "down"
                RowOrColumn = row
                For i = RowOrColumn To (RowOrColumn + (signedIndicatorY * (length - 1)))
                    X = col
                    Y = i

                    gameArr(X, Y) = 1
                Next i
        End Select
        setIndividualShipLocations(col, row, length, directionShipFacing, currentplayernum)
        Return True
    End Function

    Private Sub setIndividualShipLocations(col As Integer, row As Integer, length As Integer, direction As String, currentplayernum As Integer)
        'to set storage of the individual ships

        Dim Xoffset As Integer
        Dim Yoffset As Integer
        Dim playerDuplicateship As Boolean
        Dim opponentDuplicateship As Boolean

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

        Next
    End Sub
    Private Function isValidPlace(col, row, length, direction) As Boolean
        'To check if the ship is not on an edge of the board that will cause an error

        'Assume to be true unless an edge case below
        Dim valid As Boolean
        valid = True

        Select Case direction
            Case 1 'up and ship faces down
                If row - length < 0 Then
                    'If too close to the edge on the top side
                    valid = False
                End If
            Case 2 'down
                If row + length > gridSize Then
                    'If too close to the edge on the bottom side
                    valid = False
                End If
            Case 3 'left
                If col - length < 0 Then
                    'If too close to the edge on the left side
                    valid = False
                End If
            Case 4 'right
                If col + length > gridSize Then
                    'If too close to the edge on the right side
                    valid = False
                End If
        End Select
        Return valid
    End Function
    Private Sub assignShips(gameArr As Array, currentplayernum As Integer, length As Integer, direction As String, column As Integer, row As Integer)
        'Assign each picture box to the correct object on the form with regards to length and player

        Dim shipPictureBox As PictureBox
        Select Case length
            Case 2
                If currentplayernum = 2 Then
                    shipPictureBox = opponentShipPicbox2
                Else
                    shipPictureBox = playerShipPicbox2
                End If
            Case 3
                If currentplayernum = 2 Then
                    'To determine if there has already been a ship of 3
                    If has3alreadydone = True Then
                        shipPictureBox = opponentShipPicbox3b
                        has3alreadydone = False
                    Else
                        shipPictureBox = opponentShipPicbox3a
                        has3alreadydone = True
                    End If
                Else
                    If has3alreadydone = True Then
                        shipPictureBox = playerShipPicbox3b
                        has3alreadydone = False
                    Else
                        shipPictureBox = playerShipPicbox3a
                        has3alreadydone = True
                    End If
                End If
            Case 4
                If currentPlayer = 2 Then
                    shipPictureBox = opponentShipPicbox4
                Else
                    shipPictureBox = playerShipPicbox4
                End If
            Case 5
                If currentPlayer = 2 Then
                    shipPictureBox = opponentShipPicbox5
                Else
                    shipPictureBox = playerShipPicbox5
                End If
        End Select

        'Generate each assigned picture in it's correct location
        displayShipLocations(column, row, length, direction, currentplayernum)

    End Sub
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
    Private Sub rotateImage90(picbox As PictureBox)
        'To rotate the image 90 degrees and scale it correctly
        wait(0.01)
        Dim bmp As Bitmap = New Bitmap(picbox.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        picbox.Image = bmp
    End Sub
    Private Sub revealships()
        If gameOver = True Then
            'show opponents Ships
            opponentShipPicbox2.Visible = True
            opponentShipPicbox3a.Visible = True
            opponentShipPicbox3b.Visible = True
            opponentShipPicbox4.Visible = True
            opponentShipPicbox5.Visible = True
        Else
            'hide opponents ships
            opponentShipPicbox2.Visible = False
            opponentShipPicbox3a.Visible = False
            opponentShipPicbox3b.Visible = False
            opponentShipPicbox4.Visible = False
            opponentShipPicbox5.Visible = False
        End If
    End Sub
    Private Sub assignGridImages(gameArray As Array, pictureBoxArray As Object)
        'Updates and changes the picture depending on the value of the 
        Dim col As Integer
        Dim row As Integer
        For col = 1 To gridSize
            For row = 1 To gridSize
                Select Case gameArray(col, row)
                    Case 0 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\TransparentCircle.png"
                    Case Else : updateImageKeepCorrectSize(pictureBoxArray(col, row), gameArray(col, row), gridCircleSizeNum)
                End Select
            Next row
        Next col
    End Sub


    Private Function getPlayerMove(ByVal sender As Object, ByVal e As EventArgs)
        'When the picture box is clicked, the name of the picture box is used to determine the moves location on the grid
        Dim playerMove As gridLocation
        Dim picLocation As String
        If currentPlayer = 1 Then
            picLocation = sender.Name

            If picLocation.Length = 4 Then
                'c_rr' or 'cc_r'
                If picLocation(1) = "_" Then
                    'One digit column, two digit row ('c_rr')
                    playerMove.X = CInt(Strings.Left(sender.Name, 1))
                    playerMove.Y = CInt(Strings.Right(sender.Name, 2))
                Else
                    'Two digit column, one digit row ('cc_r')
                    playerMove.X = CInt(Strings.Left(sender.Name, 2))
                    playerMove.Y = CInt(Strings.Right(sender.Name, 1))
                End If

            Else
                If picLocation.Length = 5 Then
                    'cc_rr'
                    playerMove.X = CInt(Strings.Left(sender.Name, 2))
                    playerMove.Y = CInt(Strings.Right(sender.Name, 2))
                Else
                    'c_r'
                    playerMove.X = CInt(Strings.Left(sender.Name, 1))
                    playerMove.Y = CInt(Strings.Right(sender.Name, 1))
                End If
            End If
            timeStart()

            If opponentgameArray(playerMove.X, playerMove.Y) = 0 Or opponentgameArray(playerMove.X, playerMove.Y) = 1 Or opponentgameArray(playerMove.X, playerMove.Y) = 4 Then
                'The players move starts each round of the game
                game(playerMove)
            End If
        End If
        Return playerMove
    End Function
    Private Sub game(playerMove As gridLocation)
        'Mainline of the game, started by it's call from playerMove

        'check the move of the player (hit, miss, game over)
        check(playerMove, opponentgameArray)

        'Update displayed score and stats for the player
        updateInGameScore(1)
        updateGameStats(playerHitCount, playerMissCount, 1)

        'Update the grid to show a hit or miss
        assignGridImages(opponentgameArray, opponentpictureBoxArray)

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
                check(opponentmove, playergameArray)

                'Update diaplyed score and stats for the opponent
                updateInGameScore(2)
                updateGameStats(opponentHitCount, opponentMissCount, 2)

                'Display updated grid
                assignGridImages(playergameArray, playerpictureBoxArray)

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
                            check(opponentmove, playergameArray)

                            'update score and stats
                            updateInGameScore(2)
                            updateGameStats(opponentHitCount, opponentMissCount, 2)

                            'Display updated grid
                            assignGridImages(playergameArray, playerpictureBoxArray)

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
                MsgBox("player extra turn...")
            End If
        End If
    End Sub
    Private Sub gameIsOverNoResult()
        timeEnd()
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
    Private Sub gameIsOverWithResult()
        timeEnd()
        revealships()
        determineScore()
        scoring()

        If time = 0 OrElse time = 3599 Then
            time = timeLeft
        End If

        playerMissCount = 0
        playerHitCount = 0
        opponentMissCount = 0
        opponentHitCount = 0
        showgameOverForm()
    End Sub
    Private Sub showgameOverForm()
        Me.Hide()
        endTime = convertTimeToDisplay(time)
        endScore = score
        gameOverForm.onLoadsettings()
        gameOverForm.Show()
        time = 0
    End Sub
    Private Function check(ByRef Move As gridLocation, gameArr As Array) As Array
        'Determines whether the move is a hit or a miss and what to do in either case

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
                checkShipsIfHit(Move.X, Move.Y)
                checkIfSunk()

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
    Private Sub checkShipsIfHit(MoveX As Integer, MoveY As Integer) 'Check if move has hit a ship
        'Each FOR loop is for the length of the ships
        For i = 1 To 2 'Length 2
            If playerShip2(i).X = MoveX AndAlso playerShip2(i).Y = MoveY Then
                playerShip2(i).isHit = True
            End If
            If opponentShip2(i).X = MoveX AndAlso opponentShip2(i).Y = MoveY Then
                opponentShip2(i).isHit = True
            End If
        Next i

        For i = 1 To 3 'Length 3 
            If playerShip3a(i).X = MoveX AndAlso playerShip3a(i).Y = MoveY Then
                playerShip3a(i).isHit = True
            End If
            If opponentShip3a(i).X = MoveX AndAlso opponentShip3a(i).Y = MoveY Then
                opponentShip3a(i).isHit = True
            End If
            If playerShip3b(i).X = MoveX AndAlso playerShip3b(i).Y = MoveY Then
                playerShip3b(i).isHit = True
            End If
            If opponentShip3b(i).X = MoveX AndAlso opponentShip3b(i).Y = MoveY Then
                opponentShip3b(i).isHit = True
            End If
        Next i

        For i = 1 To 4 'Length 4
            If playerShip4(i).X = MoveX AndAlso playerShip4(i).Y = MoveY Then
                playerShip4(i).isHit = True
            End If
            If opponentShip4(i).X = MoveX AndAlso opponentShip4(i).Y = MoveY Then
                opponentShip4(i).isHit = True
            End If
        Next i

        For i = 1 To 5 'Length 5
            If playerShip5(i).X = MoveX AndAlso playerShip5(i).Y = MoveY Then
                playerShip5(i).isHit = True
            End If
            If opponentShip5(i).X = MoveX AndAlso opponentShip5(i).Y = MoveY Then
                opponentShip5(i).isHit = True
            End If
        Next i
    End Sub
    Private Sub checkIfSunk()
        'If a ship has been sunk

        'Length 2
        If opponentShip2sunk = False Then
            If opponentShip2(1).isHit = True AndAlso opponentShip2(2).isHit = True Then
                MsgBox("You sunk a ship")
                opponentShip2sunk = True
                opponentShipPicbox2.Visible = True
                playershipSunkCount = playershipSunkCount + 1
            End If
        End If

        If playerShip2sunk = False Then
            If playerShip2(1).isHit = True AndAlso playerShip2(2).isHit = True Then
                MsgBox("Your ship has been sunken")
                playerShip2sunk = True
            End If
        End If

        'Length 3
        If opponentShip3asunk = False Then
            If opponentShip3a(1).isHit = True AndAlso opponentShip3a(2).isHit = True AndAlso opponentShip3a(3).isHit = True Then
                MsgBox("You sunk a ship")
                opponentShip3asunk = True
                opponentShipPicbox3a.Visible = True
                playershipSunkCount = playershipSunkCount + 1
            End If
        End If

        If playerShip3asunk = False Then
            If playerShip3a(1).isHit = True AndAlso playerShip3a(2).isHit = True AndAlso playerShip3a(3).isHit = True Then
                playerShip3asunk = True
                MsgBox("Your ship has been sunken")
            End If
        End If

        If opponentShip3bsunk = False Then
            If opponentShip3b(1).isHit = True AndAlso opponentShip3b(2).isHit = True AndAlso opponentShip3b(3).isHit = True Then
                MsgBox("You sunk a ship")
                opponentShip3bsunk = True
                opponentShipPicbox3b.Visible = True
                playershipSunkCount = playershipSunkCount + 1
            End If
        End If

        If playerShip3bsunk = False Then
            If playerShip3b(1).isHit = True AndAlso playerShip3b(2).isHit = True AndAlso playerShip3b(3).isHit = True Then
                MsgBox("Your ship has been sunken")
                playerShip3bsunk = True
            End If
        End If


        'Length 4
        If opponentShip4sunk = False Then
            If opponentShip4(1).isHit = True AndAlso opponentShip4(2).isHit = True AndAlso opponentShip4(3).isHit = True AndAlso opponentShip4(4).isHit = True Then
                MsgBox("You sunk a ship")
                opponentShipPicbox4.Visible = True
                opponentShip4sunk = True
                playershipSunkCount = playershipSunkCount + 1
            End If
        End If

        If playerShip4sunk = False Then
            If playerShip4(1).isHit = True AndAlso playerShip4(2).isHit = True AndAlso playerShip4(3).isHit = True AndAlso playerShip4(4).isHit = True Then
                MsgBox("Your ship has been sunken")
                playerShip4sunk = True
            End If
        End If


        'Length 5
        If opponentShip5sunk = False Then
            If opponentShip5(1).isHit = True AndAlso opponentShip5(2).isHit = True AndAlso opponentShip5(3).isHit = True AndAlso opponentShip5(4).isHit = True AndAlso opponentShip5(5).isHit = True Then
                MsgBox("You sunk a ship")
                opponentShipPicbox5.Visible = True
                opponentShip5sunk = True
                playershipSunkCount = playershipSunkCount + 1
            End If
        End If

        If playerShip5sunk = False Then
            If playerShip5(1).isHit = True AndAlso playerShip5(2).isHit = True AndAlso playerShip5(3).isHit = True AndAlso playerShip5(4).isHit = True AndAlso playerShip5(5).isHit = True Then
                MsgBox("Your ship has been sunken")
                playerShip5sunk = True
            End If
        End If
    End Sub
    Private Function determineScore() As Integer
        'As swap player is after determine score in game(), the current player will always be the one who had the last move, and is hence, the winner
        Dim winner = currentPlayer

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
            score = CInt(playerscoretxt.Text) - CInt(opponentscoretxt.Text)
        Else
            'If ended by the timer

            'Go through players array and calculate how many ships the player has left and add that to the score
            For row = 1 To gridSize
                For column = 1 To gridSize
                    If playergameArray(column, row) = 1 OrElse playergameArray(column, row) = 4 Then
                        score = score + 1
                    End If
                Next column
            Next row

            'Go through the opponents array and calculate how many the opponent has left and take that away from the score
            For row = 1 To gridSize
                For column = 1 To gridSize
                    If opponentgameArray(column, row) = 1 OrElse opponentgameArray(column, row) = 4 Then
                        score = score - 1
                    End If
                Next column
            Next row

            If score > 0 Then
                'If score Is positive, Then the player has more ships left than the opponent and player wins
                gameOutcome = "Win"
            Else
                If score = 0 Then
                    gameOutcome = "Draw"
                Else
                    gameOutcome = "Lose"
                End If
                'If score Is negative, Then the opponent has more ships left than the player and player loses
            End If
        End If
        Return score
    End Function
    Private Sub updateInGameScore(currentPlayer As Integer)
        Dim playerScore As Integer
        Dim opponentScore As Integer

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
    Private Sub wait(ByVal seconds As Single)
        'Freeze the processing the computer for 10 milliseconds until it reaches the given time
        For i As Integer = 0 To seconds * 100
            'To allow the program to catch up instead of freezing the processing the entire time
            System.Threading.Thread.Sleep(10)
            'Catch up with events
            Application.DoEvents()
        Next
    End Sub
    Private Sub displayCurrentPlayer()  'Choose whether to display the player or the opponents banner
        If currentPlayer = 1 Then 'Player
            TurnsBannerPic.ImageLocation = Application.StartupPath & "\Pictures\PlayerTurnBanner.png"
        ElseIf currentPlayer = 2 Then 'Opponent
            TurnsBannerPic.ImageLocation = Application.StartupPath & "\Pictures\OpponentTurnBanner.png"
        End If
    End Sub
    Private Function computerMove()
        'Get the move for the computer

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
                randomSquare(opponentMove)

            Case "Normal"
                If hasAHit = False Then
                    'If there hasn't been a hit, randomly choose an avaliable square on the board
                    randomSquare(opponentMove)
                Else
                    'If there has been a hit, randomly choose an adjacent square to move to (hasAHit location changes every time there is a new hit)
                    randomAdjacent(opponentMove)
                End If

            Case "Hard"
                If hasAHit = False Then
                    'If there hasn't been a hit, randomly choose an avaliable square on the board
                    randomSquare(opponentMove)
                Else
                    'If there has been a hit, computerStage will either be 1 or 2.
                    'Computer stage is 1 (from check()) if hasAhit was false when the opponents move hit a ship of the player
                    'Computer stage is 2 (from check()) if hasAhit was true when the opponents move hit a ship of the player

                    If computerStage = 1 Then
                        randomAdjacent(opponentMove)
                    Else 'Computer stage 2
                        If previousHit = True Then 'Set in check(), when hasAhit = True and there is another hit
                            continueOnPath(opponentMove) 'Follow the direction until previousHit = False
                        Else 'previousHit = false when the computer misses
                            If NextShip = True Then 'Set in check() if there is a miss after swapping path direction
                                hasAHit = False
                                randomSquare(opponentMove)
                            Else 'Has followed direction to a miss, will now swap direction and continue on the other side of the initial hasAhit
                                swapPathDirection(opponentMove)
                                continueOnPath(opponentMove)
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
    Private Function randomSquare(ByRef opponentMove As gridLocation)
        Dim count As Integer
        count = 1
        Dim foundMovePos As Boolean

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
    Private Function randomAdjacent(ByRef opponentMove As gridLocation)
        Dim foundMovePos As Boolean
        Dim count As Integer
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
            randomSquare(opponentMove)
        End If
        Return opponentMove
    End Function
    Private Function continueOnPath(ByRef opponentMove As gridLocation)
        Dim validMove As Boolean

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
                randomSquare(opponentMove)
                oppositePath = False
                NextShip = False
                hasAHit = False
            Else
                'if it hasn't swapped directions yet, do so and continue on path
                swapPathDirection(opponentMove)
                continueOnPath(opponentMove)
            End If
        End If
        Return opponentMove
    End Function
    Private Function swapPathDirection(ByRef opponentMove As gridLocation)
        'Swap the direction of the path
        oppositePath = True
        Select Case opponentMoveDirection
            Case 1 : opponentMoveDirection = 2 'left -> right
            Case 2 : opponentMoveDirection = 1 'right -> left
            Case 3 : opponentMoveDirection = 4 'up -> down
            Case 4 : opponentMoveDirection = 3 'down -> up
        End Select
        opponentContinueOnCount = 1
        Return opponentMove
    End Function
    Private Sub swapPlayer()
        'switches between the value of 1 and 2 each time to swap players after each turn
        currentPlayer = AlternateNum(currentPlayer)
        displayCurrentPlayer()
    End Sub
    Public Function AlternateNum(num As Integer)
        'Alternates between 1 and 2 every time it is called
        num = 2 / num
        Return num
    End Function
    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        'Exit back to the main menu
        gameIsOverNoResult()
        Me.Hide()
        MainMenuForm.Show()

    End Sub
    Private Sub backtomainbtn_Enter(sender As Object, e As EventArgs) Handles backtomainbtn.MouseEnter

        HighScoresForm.EnterOverSmallButton("backtomainbtn", Me)
    End Sub
    Private Sub backtomainbtn_Leave(sender As Object, e As EventArgs) Handles backtomainbtn.MouseLeave
        HighScoresForm.ExitOverSmallButton("backtomainbtn", Me)
    End Sub
    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        'Reload the page
        resetbtn.Enabled = False
        gameIsOverNoResult()
        onFormLoad()
        wait(2)
        resetbtn.Enabled = True
    End Sub
    Private Sub resetbtn_Enter(sender As Object, e As EventArgs) Handles resetbtn.MouseEnter
        HighScoresForm.EnterOverSmallButton("resetbtn", Me)
    End Sub
    Private Sub resetbtn_Leave(sender As Object, e As EventArgs) Handles resetbtn.MouseLeave
        HighScoresForm.ExitOverSmallButton("resetbtn", Me)
    End Sub
    Private Sub mouseEnterGridCircle(ByVal sender As PictureBox, ByVal e As EventArgs)
        Dim picbox As PictureBox
        picbox = sender
        If picbox.ImageLocation = (Application.StartupPath & "\pictures\TransparentCircle.png") Then
            picbox.ImageLocation = Application.StartupPath & "\pictures\GreenCircle.png"
            resizeAndMoveImageWithinPicbox(picbox, 1, gridCircleSizeNum, "noDirection")
        Else
            If picbox.ImageLocation = Application.StartupPath & "\pictures\TransparentCircleHidden.png" Then
                picbox.ImageLocation = Application.StartupPath & "\pictures\GreenCircleHidden.png"
                resizeAndMoveImageWithinPicbox(picbox, 1, gridCircleSizeNum, "noDirection")
            End If
        End If
    End Sub
    Private Sub mouseExitGridCircle(ByVal sender As PictureBox, ByVal e As EventArgs)
        Dim picbox As PictureBox
        picbox = sender
        If picbox.ImageLocation = Application.StartupPath & "\pictures\GreenCircle.png" Then
            picbox.ImageLocation = Application.StartupPath & "\pictures\TransparentCircle.png"
            resizeAndMoveImageWithinPicbox(picbox, 1, gridCircleSizeNum, "noDirection")
        Else
            If picbox.ImageLocation = Application.StartupPath & "\pictures\GreenCircleHidden.png" Then
                picbox.ImageLocation = Application.StartupPath & "\pictures\TransparentCircleHidden.png"
                resizeAndMoveImageWithinPicbox(picbox, 1, gridCircleSizeNum, "noDirection")
            End If
        End If
    End Sub
    Private Sub scoring()
        'Subroutine in charge of the highscores

        'Read the high-scores from the hs.txt file
        readHighScores()

        'Add in players score
        addPlayerScoreToHighscores()

        'Sort the scores
        Dim sortbytime = False
        Dim sortbyscores = True
        Dim order = "descending"
        BubbleSort(sortbyscores, sortbytime, order)

        'Write the scores to the file
        WriteHighScores()
    End Sub
    Private Sub addPlayerScoreToHighscores()
        'Add the players score, name, difficulty and time into the 11th element of the array of records
        arrHighScores(11).score = score
        arrHighScores(11).name = playerName
        arrHighScores(11).difficulty = difficulty
        arrHighScores(11).time = convertTimeToDisplay(time)
    End Sub
    Public Sub readHighScores()
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
            fileContents = convertTimeToDisplay(CInt(fileContents))
            arrHighScores(i).time = fileContents

            'difficulty
            FileSystem.Input(1, fileContents)
            arrHighScores(i).difficulty = fileContents
        Next
        FileSystem.FileClose(1)
    End Sub
    Public Sub WriteHighScores()
        'Open the hs.txt file for Outpue (write)
        FileSystem.FileOpen(1, "hs.txt", OpenMode.Output)
        For i = 1 To 10
            FileSystem.Write(1, arrHighScores(i).score)
            FileSystem.Write(1, arrHighScores(i).name)
            FileSystem.Write(1, convertTimeToInteger(arrHighScores(i).time))
            FileSystem.Write(1, arrHighScores(i).difficulty)
        Next
        FileSystem.FileClose(1)
    End Sub
    Public Function convertTimeToDisplay(time As Integer) As String
        'Convert integer time into display time (dd:dd)

        Dim newTime As String
        If time >= 3599 Then
            newTime = "59:59"
        Else
            If time < 10 Then
                'under than 10 sec
                newTime = "00:0" & CStr(time)
            Else
                'between 10s and 1min
                If time < 60 Then
                    newTime = "00:" & CStr(time)
                Else
                    'between 1 and 10min
                    If time < 600 Then
                        If time - (Math.Floor(time / 60) * 60) = 0 Then
                            newTime = "0" & Math.Floor(time / 60) & ":" & "00"
                        Else
                            If time - (Math.Floor(time / 60) * 60) < 10 Then
                                newTime = "0" & Math.Floor(time / 60) & ":0" & (time - (Math.Floor(time / 60) * 60))
                            Else
                                newTime = "0" & Math.Floor(time / 60) & ":" & (time - (Math.Floor(time / 60) * 60))
                            End If
                        End If
                    Else
                        'anything above 10min
                        If time - (Math.Floor(time / 60) * 60) = 0 Then
                            newTime = Math.Floor(time / 60) & ":" & "00"
                        Else
                            If time - (Math.Floor(time / 60) * 60) < 10 Then
                                newTime = Math.Floor(time / 60) & ":0" & (time - (Math.Floor(time / 60) * 60))
                            Else
                                newTime = Math.Floor(time / 60) & ":" & (time - (Math.Floor(time / 60) * 60))
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Return newTime
    End Function
    Private Function convertTimeToInteger(time As String) As String
        'Convert display time (dd:dd) into integer time

        'subtime as integer to be added after leading 0s
        Dim subtime As String

        'To make sure that 00:00 does not run (impossible time)
        If time = "0" Then
            time = timeLeft
        Else
            If time = "3599" Then
                time = 3599
            Else
                If Asc(time(0)) <> 48 Or Asc(time(1)) <> 48 Or Asc(time(2)) <> 48 Or Asc(time(3)) <> 48 Or Asc(time(4)) <> 48 Then
                    If time(0) = "0" AndAlso time(1) = "0" AndAlso time(3) = "0" Then
                        'under than 10 sec
                        subtime = Mid(time, 5, 1)
                        time = "000" & subtime
                    Else
                        'between 10s and 1min

                        If time(0) = "0" AndAlso time(1) = "0" Then
                            subtime = Mid(time, 4, 2)
                            time = "00" & subtime
                        Else
                            If time(0) = "0" Then
                                'between 1min and 10min
                                subtime = CStr(CInt(Mid(time, 4, 2)) + Math.Floor(CInt(Mid(time, 2, 1) * 60)))
                                time = "0" & subtime
                            Else
                                'anything above 10min
                                time = CStr(CInt(Mid(time, 4, 2)) + Math.Floor(CInt(Mid(time, 1, 2) * 60)))
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Return time
    End Function
    Public Sub BubbleSort(sortByScores As Boolean, sortByTime As Boolean, order As String)
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
                If sortByScores = True Then
                    If order = "descending" Then

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
                End If

                If sortByTime = True Then
                    If order = "descending" Then
                        'Temporary fake time as lower than possible so it can't show up as top 10
                        If arrHighScores(11).name = "ZZZZZZ" Then
                            arrHighScores(11).time = "00:00"
                        End If

                        'Swap if the current one is smaller than the one on it's right
                        If CInt(convertTimeToInteger(arrHighScores(i).time)) < CInt(convertTimeToInteger(arrHighScores(i + 1).time)) Then
                            Swap(arrHighScores(i), arrHighScores(i + 1))
                            Swapped = True
                        End If
                    Else
                        'Temporary fake score as highest possible so it can't show up as top 10 in ascending
                        If arrHighScores(11).name = "ZZZZZZ" Then
                            arrHighScores(11).time = "59:59"
                        End If

                        'Swap if the current one is bigger than the one on it's right
                        If CInt(convertTimeToInteger(arrHighScores(i).time)) > CInt(convertTimeToInteger(arrHighScores(i + 1).time)) Then
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
    Private Sub updateGameStats(hitcount As Integer, misscount As Integer, playernum As Integer)
        Dim accuracy As String
        If misscount = 0 AndAlso hitcount = 0 Then
            accuracy = "-"
        Else
            accuracy = CStr(CInt((hitcount / (misscount + hitcount)) * 100)) & "%"
        End If

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
    Private Sub Swap(ByRef A As recHighScore, ByRef B As recHighScore)
        'swap records by using a temporary value
        Dim Temp As recHighScore
        Temp = A
        A = B
        B = Temp
    End Sub
    Private Sub timeInitialise()
        gameTimer.Interval = 1000
        If timeOptionAsCountUp = False Then
            time = timeLeft
            displayTime = convertTimeToDisplay(time)
        End If
        timelbl.Text = displayTime
    End Sub
    Private Sub timeStart()
        If gameOver = False Then
            gameTimer.Start()
        End If
    End Sub
    Private Sub timeEnd()
        If gameOver = True Then
            gameTimer.Stop()
            displayTime = ""
        End If
    End Sub
    Private Sub gametimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If timeOptionAsCountUp = True Then
            time = time + 1
            If time = 3599 Then
                If formID = "Game" Then
                    gameIsOverWithResult()
                End If
            End If
        Else
            If time = 0 Then
                If formID = "Game" Then
                    gameIsOverWithResult()
                End If
            Else
                time = time - 1
            End If
        End If

        displayTime = convertTimeToDisplay(time)
        timelbl.Text = displayTime
    End Sub
    Private Sub displayShipLocations(col As Integer, row As Integer, shipLength As Integer, direction As String, currentplayernum As Integer)
        'overall parent must be highest count
        'aka back to front
        Dim X As Integer
        Dim Y As Integer
        Dim Xscale As Integer
        Dim Yscale As Integer
        Dim gridcirclesize
        Dim XOffset As Integer
        Dim YOffset As Integer
        Dim playerstring As String
        Dim parentgridbox As PictureBox
        Dim targetgridbox As PictureBox
        Dim targetship As PictureBox
        Dim highestLayerParent As PictureBox
        Dim originalParent As PictureBox

        WindowState = FormWindowState.Minimized

        gridcirclesize = gridCircleSizeNum

        If currentplayernum = 1 Then
            playerstring = "player"
            originalParent = playerpictureBoxArray(col, row)
        Else
            playerstring = "opponent"
            originalParent = opponentpictureBoxArray(col, row)
        End If

        Select Case direction
            Case "right"
                X = gridcirclesize * (shipLength - 1)
                Y = 0
                Xscale = gridcirclesize * shipLength
                Yscale = gridcirclesize
                XOffset = -1
                YOffset = 0
            Case "left"
                'X = -gridcirclesize * (shipLength - 1)
                Y = 0
                Xscale = gridcirclesize * shipLength
                Yscale = gridcirclesize
                XOffset = 1
                YOffset = 0
            Case "down"
                X = 0
                Y = gridcirclesize * (shipLength - 1)
                Xscale = gridcirclesize
                Yscale = gridcirclesize * shipLength
                XOffset = 0
                YOffset = 1
            Case "up"
                X = 0
                'Y = -gridcirclesize * (shipLength - 1)
                Xscale = gridcirclesize
                Yscale = gridcirclesize * shipLength
                XOffset = 0
                YOffset = -1
        End Select
        Dim count As Integer
        count = shipLength
        originalParent.SizeMode = PictureBoxSizeMode.Normal


        Select Case direction
            Case "right"
                resizeAndMoveImageWithinPicbox(originalParent, count, gridCircleSizeNum, direction)
                originalParent.Size = New Size(Xscale, Yscale)
                originalParent.BackColor = Color.Transparent
                originalParent.Location = originalParent.Location - New Point(X, Y)
                parentgridbox = originalParent

                For count = 1 To (shipLength - 1)
                    If currentplayernum = 1 Then
                        targetgridbox = playerpictureBoxArray(col + (XOffset * count), row + (YOffset * count))
                    Else
                        targetgridbox = opponentpictureBoxArray(col + (XOffset * count), row + (YOffset * count))
                    End If
                    targetgridbox.SizeMode = PictureBoxSizeMode.Normal
                    resizeAndMoveImageWithinPicbox(targetgridbox, count, gridCircleSizeNum, direction)
                    targetgridbox.Size = New Size(Xscale, Yscale)
                    targetgridbox.Parent = parentgridbox
                    targetgridbox.BringToFront()
                    targetgridbox.Location = New Point(0, 0)
                    targetgridbox.BackColor = Color.Transparent
                    parentgridbox = targetgridbox
                Next count
            Case "left"
                resizeAndMoveImageWithinPicbox(originalParent, count, gridCircleSizeNum, "noMovement")
                originalParent.Size = New Size(Xscale, Yscale)
                originalParent.BackColor = Color.Transparent
                parentgridbox = originalParent
                For count = (shipLength - 1) To 1 Step -1
                    If currentplayernum = 1 Then
                        targetgridbox = playerpictureBoxArray(col + (XOffset * count), row + (YOffset * count))
                    Else
                        targetgridbox = opponentpictureBoxArray(col + (XOffset * count), row + (YOffset * count))
                    End If
                    targetgridbox.SizeMode = PictureBoxSizeMode.Normal
                    resizeAndMoveImageWithinPicbox(targetgridbox, count, gridCircleSizeNum, direction)
                    targetgridbox.Size = New Size(Xscale, Yscale)
                    targetgridbox.Parent = parentgridbox
                    targetgridbox.BringToFront()
                    targetgridbox.Location = New Point(0, 0)
                    targetgridbox.BackColor = Color.Transparent
                    parentgridbox = targetgridbox
                Next count
            Case "up"
                resizeAndMoveImageWithinPicbox(originalParent, count, gridCircleSizeNum, "noMovement")
                originalParent.Size = New Size(Xscale, Yscale)
                originalParent.BackColor = Color.Transparent
                parentgridbox = originalParent
                For count = (shipLength - 1) To 1 Step -1
                    If currentplayernum = 1 Then
                        targetgridbox = playerpictureBoxArray(col + (XOffset * count), row + (YOffset * count))
                    Else
                        targetgridbox = opponentpictureBoxArray(col + (XOffset * count), row + (YOffset * count))
                    End If
                    targetgridbox.SizeMode = PictureBoxSizeMode.Normal
                    resizeAndMoveImageWithinPicbox(targetgridbox, count, gridCircleSizeNum, direction)
                    targetgridbox.Size = New Size(Xscale, Yscale)
                    targetgridbox.Parent = parentgridbox
                    targetgridbox.BringToFront()
                    targetgridbox.Location = New Point(0, 0)
                    targetgridbox.BackColor = Color.Transparent
                    parentgridbox = targetgridbox
                Next count
            Case "down"
                resizeAndMoveImageWithinPicbox(originalParent, count, gridCircleSizeNum, direction)
                originalParent.Size = New Size(Xscale, Yscale)
                originalParent.BackColor = Color.Transparent
                originalParent.Location = originalParent.Location - New Point(X, Y)
                parentgridbox = originalParent
                For count = 1 To (shipLength - 1)
                    If currentplayernum = 1 Then
                        targetgridbox = playerpictureBoxArray(col + (XOffset * count), row + (YOffset * count))
                    Else
                        targetgridbox = opponentpictureBoxArray(col + (XOffset * count), row + (YOffset * count))
                    End If
                    targetgridbox.SizeMode = PictureBoxSizeMode.Normal
                    resizeAndMoveImageWithinPicbox(targetgridbox, shipLength - count, gridCircleSizeNum, direction)
                    targetgridbox.Size = New Size(Xscale, Yscale)
                    targetgridbox.Parent = parentgridbox
                    targetgridbox.BringToFront()
                    targetgridbox.Location = New Point(0, 0)
                    targetgridbox.BackColor = Color.Transparent
                    parentgridbox = targetgridbox
                Next count
        End Select

        'Ships
        If shipLength = 3 Then
            If duplicateShip = False Then
                targetship = Me.Controls.Item(playerstring & "ShipPicbox3a")
                duplicateShip = True
            Else
                targetship = Me.Controls.Item(playerstring & "ShipPicbox3b")
                duplicateShip = False
            End If
        Else
            targetship = Me.Controls.Item(playerstring & "ShipPicbox" & shipLength)
        End If

        assignShipImages(targetship)
        targetship.Load(targetship.ImageLocation)

        Select Case direction
            Case "left"
                rotateImage90(targetship)
                rotateImage90(targetship)
            Case "down"
                rotateImage90(targetship)
            Case "up"
                rotateImage90(targetship)
                rotateImage90(targetship)
                rotateImage90(targetship)
        End Select

        targetship.Parent = parentgridbox
        targetship.Size = parentgridbox.Size
        targetship.BackColor = Color.Transparent
        targetship.BringToFront()
        targetship.Location = New Point(0, 0)
        'WindowState = FormWindowState.Maximized
    End Sub
    Private Sub resizeAndMoveImageWithinPicbox(picbox As PictureBox, count As Integer, radius As Integer, direction As String)
        'WindowState = FormWindowState.Minimized
        picbox.Load(picbox.ImageLocation)
        Dim Xloc As Integer
        Dim Yloc As Integer

        Select Case direction
            Case "right"
                Xloc = radius * (count - 1)
                Yloc = 0
            Case "left"
                Xloc = radius * count
                Yloc = 0
            Case "up"
                Xloc = 0
                Yloc = radius * (count - 1)
            Case "down"
                Xloc = 0
                Yloc = radius * count - radius
            Case "noMovement"
                Xloc = 0
                Yloc = 0
        End Select
        
        Dim b As Bitmap = DirectCast(picbox.Image, Bitmap)
        Dim new_b As New Bitmap(radius + Xloc, radius + Yloc)
        Dim g As Graphics = Graphics.FromImage(new_b)

        g.DrawImage(b, Xloc, Yloc, radius, radius) 'Moves and scales the picture
        g.Save()

        picbox.Image = new_b
        'WindowState = FormWindowState.Maximized
    End Sub
    Private Sub updateImageKeepCorrectSize(picbox As PictureBox, arrayValue As Integer, radius As Integer)
        Dim Xloc As Integer
        Dim Yloc As Integer

        If picbox.Image.Width - radius = 0 AndAlso picbox.Image.Height - radius = 0 Then
            'No movement
        Else
            If picbox.Image.Width - radius = 0 Then
                'If only y stretch
                Yloc = picbox.Image.Height - radius
            Else
                If picbox.Image.Height - radius = 0 Then
                    'If only x stretch
                    Xloc = picbox.Image.Width - radius
                End If
            End If
        End If

        Select Case arrayValue
            Case 1 : picbox.ImageLocation = Application.StartupPath & "\pictures\GreenCircle.png" 'hidden
            Case 2 : picbox.ImageLocation = Application.StartupPath & "\pictures\BlueCircle.png" 'miss
            Case 3 : picbox.ImageLocation = Application.StartupPath & "\pictures\RedCircle.png" 'hit
            Case 4 : picbox.ImageLocation = Application.StartupPath & "\pictures\placeHolderCircle.png" 'hidden front of ship
        End Select
        picbox.Load(picbox.ImageLocation)


        Dim b As Bitmap = DirectCast(picbox.Image, Bitmap)
        Dim new_b As New Bitmap(radius + Xloc, radius + Yloc)
        Dim g As Graphics = Graphics.FromImage(new_b)

        g.DrawImage(b, Xloc, Yloc, radius, radius) 'Moves and scales the picture
        g.Save()

        picbox.Image = new_b
    End Sub
End Class