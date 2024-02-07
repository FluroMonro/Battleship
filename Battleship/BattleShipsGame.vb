Imports System.Diagnostics.PerformanceData
Imports System.Drawing.Text
Imports System.Runtime.Intrinsics.Arm
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Permissions
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class BattleShipsGame
    Dim currentPlayer As Integer
    Dim gameOver As Boolean
    Dim boardEmpty As Boolean
    Dim playerMoveX As Integer
    Dim PlayerMoveY As Integer
    Dim opponentMoveX As Integer
    Dim opponentMoveY As Integer
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

    Public Structure recHighScore
        Public name As String
        Public score As Integer
        Public time As String
    End Structure

    Public Structure shipGridLocations
        Public X As Integer
        Public Y As Integer
        Public isHit As Boolean
    End Structure

    Public Structure singleGridLocation
        Public X As Integer
        Public Y As Integer
    End Structure

    Public arrHighScores(10) As recHighScore
    Public hasAhitLocation As singleGridLocation

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

    Public Sub updateGlobalVars(name As String, size As Integer, userDifficulty As String, shipPlacementOption As Boolean)
        playerName = name
        gridSize = size
        difficulty = userDifficulty
        isShipPlacementRandom = shipPlacementOption
    End Sub
    Public Sub onFormLoad()
        initialiseControlsPlacement()

        'reset the boards before generating a new
        resetGameArray(opponentgameArray)
        resetGameArray(playergameArray)

        currentPlayer = 1
        opponentMoveX = 0
        opponentMoveY = 1
        hasAHit = False

        hasAhitLocation.X = 0
        hasAhitLocation.Y = 0
        previousHit = False
        computerStage = 0
        oppositePath = False
        NextShip = False

        For i = 1 To 2
            opponentShip2(i).X = 0
            opponentShip2(i).Y = 0
            playerShip2(i).X = 0
            playerShip2(i).Y = 0
        Next
        For i = 1 To 3
            opponentShip3a(i).X = 0
            opponentShip3a(i).Y = 0
            playerShip3a(i).X = 0
            playerShip3a(i).Y = 0
            opponentShip3b(i).X = 0
            opponentShip3b(i).Y = 0
            playerShip3b(i).X = 0
            playerShip3b(i).Y = 0
        Next
        For i = 1 To 4
            opponentShip4(i).X = 0
            opponentShip4(i).Y = 0
            playerShip4(i).X = 0
            playerShip4(i).Y = 0
        Next
        For i = 1 To 5
            opponentShip5(i).X = 0
            opponentShip5(i).Y = 0
            playerShip5(i).X = 0
            playerShip5(i).Y = 0
        Next

        playernametxt.Text = playerName


        'generate gameArray randomly (both computer and Player)
        generateGameArr(opponentgameArray, 2)
        generateGameArr(playergameArray, 1)

        generatePicture(opponentpictureBoxArray, OpponentBoardBGImg, 2)
        generatePicture(playerpictureBoxArray, PlayerBoardBGImg, 1)

        assignGridImages(opponentgameArray, opponentpictureBoxArray, 2)
        assignGridImages(playergameArray, playerpictureBoxArray, 1)

        'scoring()

    End Sub
    Private Sub initialiseControlsPlacement()
        'To place the controls in the same position relative to the custom display size of the user

        'To initialise the screen size as the fullscreen display size of the user
        Me.WindowState = FormWindowState.Minimized
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        'To force the game to a 1528x960 window unless already that resolution in fullscreen
        'If Me.Width <> 1528 And Me.Height <> 960 Then
        '    Me.WindowState = FormWindowState.Normal
        '    Me.Width = 1528
        '    Me.Height = 960
        'End If

        Dim turnsbannerWidth As Short
        Dim turnsbannerXloc As Short
        Dim turnsbannerYLoc As Short

        turnsbannerWidth = 330
        turnsbannerHeight = 45
        turnsbannerXloc = Me.Width / 2 - (turnsbannerWidth / 2)
        turnsbannerYLoc = (Me.Height / 2 - (turnsbannerHeight / 2)) - 40
        boardSizes = turnsbannerYLoc - ((turnsbannerHeight / 2) - 9)

        'Setting the placement and size relative to the screen
        backtomainbtn.Location = New Point(Me.Width - (100 + 42), Me.Height - (60 + 64))
        resetbtn.Location = New Point(Me.Width - (200 + 42), Me.Height - (60 + 64))


        OpponentBoardBGImg.Location = New Point((Me.Width / 2) - (boardSizes / 2), 20)
        PlayerBoardBGImg.Location = New Point(Me.Width / 2 - (boardSizes / 2), turnsbannerYLoc + 40)

        timelbl.Font = New Font("Segoe UI", CShort(Me.Height / 48.5333328F), FontStyle.Bold, GraphicsUnit.Point)
        timelbl.Location = New Point((Me.Width / 2) - 40, Me.Height - 95)
        timelbl.Size = New Size(80, 30)

        Dim playernameoffSet = 5 * (playerName.Length)
        playernamelbl.Location = New Point((Me.Width / 2) - (boardSizes / 2) - playernameoffSet - 200, Me.Bottom - 230)
        playernametxt.Location = New Point((Me.Width / 2) - (boardSizes / 2) - playernameoffSet - 120, Me.Bottom - 230)
        playerscorelbl.Location = New Point(Me.Width / 2 - (boardSizes / 2) - playernameoffSet - 168, Me.Bottom - 200)
        playerscoretxt.Location = New Point(Me.Width / 2 - (boardSizes / 2) - playernameoffSet - 94, Me.Bottom - 200)

        opponentnamelbl.Location = New Point((Me.Width / 2) + (boardSizes / 2) + 40, Me.Top + 150)
        opponentscorelbl.Location = New Point((Me.Width / 2) + (boardSizes / 2) + 68, Me.Top + 180)
        opponentscoretxt.Location = New Point((Me.Width / 2) + (boardSizes / 2) + 142, Me.Top + 180)

        gridCircleSizeNum = (boardSizes - 30) / gridSize

        PlayerBoardBGImg.ImageLocation = Application.StartupPath & "\Pictures\board.png"
        OpponentBoardBGImg.ImageLocation = Application.StartupPath & "\Pictures\board.png"
        'Declarations of variables in relation to custom screensize (eg. Me.Width)

        OpponentBoardBGImg.Size = New Size(boardSizes, boardSizes)
        PlayerBoardBGImg.Size = New Size(boardSizes, boardSizes)
        TurnsBannerPic.Location = New Point(turnsbannerXloc, turnsbannerYLoc)
        TurnsBannerPic.Size = New Size(turnsbannerWidth, turnsbannerHeight)
        TurnsBannerPic.ImageLocation = Application.StartupPath & "\Pictures\PlayerTurnBanner.png"

        playernamelbl.Size = New Size(88, 26)
        playernametxt.Size = New Size(118, 24)
        playerscorelbl.Size = New Size(79, 26)
        playerscoretxt.Size = New Size(22, 24)
        opponentnamelbl.Size = New Size(113, 26)
        opponentscorelbl.Size = New Size(79, 26)
        opponentscoretxt.Size = New Size(22, 24)

        opponentshipPicbox2.Location = New Point(100, 100)
        opponentshipPicbox3a.Location = New Point(100, 100)
        opponentshipPicbox3b.Location = New Point(100, 100)
        opponentshipPicbox4.Location = New Point(100, 100)
        opponentshipPicbox5.Location = New Point(100, 100)
        playershipPicbox2.Location = New Point(100, 100)
        playershipPicbox3a.Location = New Point(100, 100)
        playershipPicbox3b.Location = New Point(100, 100)
        playershipPicbox4.Location = New Point(100, 100)
        playershipPicbox5.Location = New Point(100, 100)

        KeyPanel.Location = New Point(Me.Width / 20, Me.Height / 18)

        opponentshipPicbox2.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"
        opponentshipPicbox3a.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"
        opponentshipPicbox3b.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"
        opponentshipPicbox4.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"
        opponentshipPicbox5.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"
        playershipPicbox2.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"
        playershipPicbox3a.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"
        playershipPicbox3b.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"
        playershipPicbox4.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"
        playershipPicbox5.ImageLocation = Application.StartupPath & "\Pictures\BoardBlue.png"

        backgroundImg.ImageLocation = Application.StartupPath & "\Pictures\gameBackground.png"
        backgroundImg.Location = New Point(0, 0)
        backgroundImg.Size = New Size(Me.Width - 15, Me.Height - 38)
        'will hide the opponents ships if gameOver = false and the players ship until they have been positioned
        gameOver = False
        revealships()
    End Sub
    Private Sub resetGameArray(gameArray As Array)
        'resets the entire array to all 0s
        Dim row, col As Integer
        For col = 1 To gridSize
            For row = 1 To gridSize
                gameArray(col, row) = 0
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
                picbox.Name = col & row
                picbox.Parent = picBoard
                pictureBoxArray(col, row) = picbox
                picbox.BringToFront()
                picbox.BackColor = Color.FromArgb(CByte(0), CByte(237), CByte(28), CByte(36))

                'presentation
                picbox.Width = gridCircleSizeNum
                picbox.Height = gridCircleSizeNum
                If currentPlayer = 1 Then
                    Select Case gridSize
                        Case 8
                            picbox.Left = col * gridCircleSizeNum - 33
                            picbox.Top = (Me.Height / 2) - (row * gridCircleSizeNum) - 91
                        Case 10
                            picbox.Left = col * gridCircleSizeNum - gridOffSet
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
                        AddHandler picbox.Click, AddressOf getPlayerMove
                    End If
                End If
                picbox.ImageLocation = Application.StartupPath & "\pictures\transparentCircle.png"
                picbox.SizeMode = PictureBoxSizeMode.StretchImage
            Next col
        Next row
    End Sub
    Private Sub generateGameArr(gameArr As Array, player As Integer)
        If isShipPlacementRandom = True Then
            generateShips(gameArr, 2, player)
            generateShips(gameArr, 3, player)
            duplicateShip = True
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
    Private Function generateShips(gameArr As Array, length As Integer, currentplayer As Integer) As Array
        Dim valid As Boolean
        valid = False
        Dim col As Integer
        Dim row As Integer
        Dim direction As Integer
        Dim temporarySpace As Integer
        temporarySpace = 1

        While valid = False
            col = Int(Rnd() * gridSize) + 1
            row = Int(Rnd() * gridSize) + 1
            If gameArr(col, row) = 0 Then
                direction = Int(Rnd() * 4) + 1
                If direction = 1 And currentplayer = 2 Then
                    direction = 2
                Else
                    If direction = 2 And currentplayer = 2 Then
                        direction = 1
                    End If
                End If
                Select Case direction
                    Case 1
                        If isValidPlace(col, row, length, direction) = True Then
                            Select Case length
                                Case 2
                                    If gameArr(col, row - 1) = 0 Then
                                        For i = row To (row - (length - 1)) Step -1
                                            gameArr(col, i) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)
                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 3
                                    If gameArr(col, row - 1) = 0 AndAlso gameArr(col, row - 2) = 0 Then
                                        For i = row To (row - (length - 1)) Step -1
                                            gameArr(col, i) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 4
                                    If gameArr(col, row - 1) = 0 AndAlso gameArr(col, row - 2) = 0 AndAlso gameArr(col, row - 3) = 0 Then
                                        For i = row To (row - (length - 1)) Step -1
                                            gameArr(col, i) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 5
                                    If gameArr(col, row - 1) = 0 AndAlso gameArr(col, row - 2) = 0 AndAlso gameArr(col, row - 3) = 0 AndAlso gameArr(col, row - 4) = 0 Then
                                        For i = row To row - (length - 1) Step -1
                                            gameArr(col, i) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                            End Select
                        End If
                    Case 2
                        If isValidPlace(col, row, length, direction) = True Then
                            Select Case length
                                Case 2
                                    If gameArr(col, row + 1) = 0 Then
                                        For i = row To (row + (length - 1))
                                            gameArr(col, i) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 3
                                    If gameArr(col, row + 1) = 0 AndAlso gameArr(col, row + 2) = 0 Then
                                        For i = row To (row + (length - 1))
                                            gameArr(col, i) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 4
                                    If gameArr(col, row + 1) = 0 AndAlso gameArr(col, row + 2) = 0 AndAlso gameArr(col, row + 3) = 0 Then
                                        For i = row To (row + (length - 1))
                                            gameArr(col, i) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 5
                                    If gameArr(col, row + 1) = 0 AndAlso gameArr(col, row + 2) = 0 AndAlso gameArr(col, row + 3) = 0 AndAlso gameArr(col, row + 4) = 0 Then
                                        For i = row To (row + (length - 1))
                                            gameArr(col, i) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                            End Select
                        End If
                    Case 3
                        If isValidPlace(col, row, length, direction) = True Then
                            Select Case length
                                Case 2
                                    If gameArr(col - 1, row) = 0 Then
                                        For i = col To (col - (length - 1)) Step -1
                                            gameArr(i, row) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 3
                                    If gameArr(col - 1, row) = 0 AndAlso gameArr(col - 2, row) = 0 Then
                                        For i = col To (col - (length - 1)) Step -1
                                            gameArr(i, row) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 4
                                    If gameArr(col - 1, row) = 0 AndAlso gameArr(col - 2, row) = 0 AndAlso gameArr(col - 3, row) = 0 Then
                                        For i = col To (col - (length - 1)) Step -1
                                            gameArr(i, row) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 5
                                    If gameArr(col - 1, row) = 0 AndAlso gameArr(col - 2, row) = 0 AndAlso gameArr(col - 3, row) = 0 AndAlso gameArr(col - 4, row) = 0 Then
                                        For i = col To (col - (length - 1)) Step -1
                                            gameArr(i, row) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                            End Select
                        End If
                    Case 4
                        If isValidPlace(col, row, length, direction) = True Then
                            Select Case length
                                Case 2
                                    If gameArr(col + 1, row) = 0 Then
                                        For i = col To (col + (length - 1))
                                            gameArr(i, row) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 3
                                    If gameArr(col + 1, row) = 0 AndAlso gameArr(col + 2, row) = 0 Then
                                        For i = col To (col + (length - 1))
                                            gameArr(i, row) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 4
                                    If gameArr(col + 1, row) = 0 AndAlso gameArr(col + 2, row) = 0 AndAlso gameArr(col + 3, row) = 0 Then
                                        For i = col To (col + (length - 1))
                                            gameArr(i, row) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                                Case 5
                                    If gameArr(col + 1, row) = 0 AndAlso gameArr(col + 2, row) = 0 AndAlso gameArr(col + 3, row) = 0 AndAlso gameArr(col + 4, row) = 0 Then
                                        For i = col To (col + (length - 1))
                                            gameArr(i, row) = 1

                                            setIndividualShipLocations(col, row, length, temporarySpace, currentplayer)

                                            temporarySpace = temporarySpace + 1
                                        Next i
                                        valid = True
                                    Else
                                        valid = False
                                    End If
                            End Select
                        End If
                End Select
            End If
        End While

        'useful for debuging purposes, to determine where the head of the ship is.
        gameArr(col, row) = 4

        If currentplayer = 1 Then
            assignShips(gameArr, 1, length, direction, col, row)
        Else
            assignShips(gameArr, 2, length, direction, col, row)
        End If
        Return gameArr
    End Function

    Private Sub setIndividualShipLocations(col As Integer, row As Integer, length As Integer, i As Integer, currentplayer As Integer)

        'to set storage of the individual ships
        If currentplayer = 1 Then
            Select Case length
                Case 2
                    playerShip2(i).X = col
                    playerShip2(i).Y = row
                Case 3
                    If playerShip3a(i).X = 0 Then
                        playerShip3a(i).X = col
                        playerShip3a(i).Y = row
                    Else
                        playerShip3b(i).X = col
                        playerShip3b(i).Y = row
                    End If
                Case 4
                    playerShip4(i).X = col
                    playerShip4(i).Y = row
                Case 5
                    playerShip5(i).X = col
                    playerShip5(i).Y = row
            End Select
        Else
            Select Case length
                Case 2
                    opponentShip2(i).X = col
                    opponentShip2(i).Y = row
                Case 3
                    If opponentShip3a(i).X = 0 Then
                        opponentShip3a(i).X = col
                        opponentShip3a(i).Y = row
                    Else
                        opponentShip3b(i).X = col
                        opponentShip3b(i).Y = row
                    End If
                Case 4
                    opponentShip4(i).X = col
                    opponentShip4(i).Y = row
                Case 5
                    opponentShip5(i).X = col
                    opponentShip5(i).Y = row
            End Select
        End If
    End Sub
    Private Function isValidPlace(col, row, length, direction) As Boolean
        Dim valid As Boolean
        Select Case direction
            Case 1
                If row - length < 0 Then
                    valid = False
                Else
                    valid = True
                End If
            Case 2
                If row + length > gridSize Then
                    valid = False
                Else
                    valid = True
                End If
            Case 3
                If col - length < 0 Then
                    valid = False
                Else
                    valid = True
                End If
            Case 4
                If col + length > gridSize Then
                    valid = False
                Else
                    valid = True
                End If
        End Select
        Return valid
    End Function
    Private Sub assignShips(gameArr As Array, currentplayer As Integer, length As Integer, direction As Integer, column As Integer, row As Integer)
        Dim shipPictureBox As PictureBox
        Select Case length
            Case 2
                If currentplayer = 2 Then
                    shipPictureBox = opponentshipPicbox2
                Else
                    shipPictureBox = playershipPicbox2
                End If
            Case 3
                If currentplayer = 2 Then
                    If has3alreadydone = True Then
                        shipPictureBox = opponentshipPicbox3b
                        has3alreadydone = False
                    Else
                        shipPictureBox = opponentshipPicbox3a
                        has3alreadydone = True
                    End If
                Else
                    If has3alreadydone = True Then
                        shipPictureBox = playershipPicbox3b
                        has3alreadydone = False
                    Else
                        shipPictureBox = playershipPicbox3a
                        has3alreadydone = True
                    End If
                End If
            Case 4
                If currentplayer = 2 Then
                    shipPictureBox = opponentshipPicbox4
                Else
                    shipPictureBox = playershipPicbox4
                End If
            Case 5
                If currentplayer = 2 Then
                    shipPictureBox = opponentshipPicbox5
                Else
                    shipPictureBox = playershipPicbox5
                End If
            Case Else
                'Shouldn't run unless there's an error as length is always 2, 3, 4, 5.
                If currentplayer = 1 Then
                    shipPictureBox = playershipPicbox5
                    MsgBox("Length error")
                Else
                    shipPictureBox = opponentshipPicbox5
                    MsgBox("Length error")
                End If
        End Select

        'generate each assigned picture in it's correct location
        shipImageGenerate(shipPictureBox, currentplayer, length, direction, column, row)
    End Sub
    Private Sub assignShipImages(currentplayer As Integer, picboard As PictureBox)
        Select Case picboard.Name
            Case opponentshipPicbox2.Name : opponentshipPicbox2.ImageLocation = Application.StartupPath & "\pictures\BattleShip2.png"
            Case playershipPicbox2.Name : playershipPicbox2.ImageLocation = Application.StartupPath & "\pictures\BattleShip2.png"
            Case opponentshipPicbox3a.Name : opponentshipPicbox3a.ImageLocation = Application.StartupPath & "\pictures\BattleShip3.png"
            Case playershipPicbox3a.Name : playershipPicbox3a.ImageLocation = Application.StartupPath & "\pictures\BattleShip3.png"
            Case opponentshipPicbox3b.Name : opponentshipPicbox3b.ImageLocation = Application.StartupPath & "\pictures\BattleShip3.png"
            Case playershipPicbox3b.Name : playershipPicbox3b.ImageLocation = Application.StartupPath & "\pictures\BattleShip3.png"
            Case opponentshipPicbox4.Name : opponentshipPicbox4.ImageLocation = Application.StartupPath & "\pictures\BattleShip4.png"
            Case playershipPicbox4.Name : playershipPicbox4.ImageLocation = Application.StartupPath & "\pictures\BattleShip4.png"
            Case opponentshipPicbox5.Name : opponentshipPicbox5.ImageLocation = Application.StartupPath & "\pictures\BattleShip5.png"
            Case playershipPicbox5.Name : playershipPicbox5.ImageLocation = Application.StartupPath & "\pictures\BattleShip5.png"
            Case Else
                'Shouldn't run unless there's an error as length is always 2, 3, 4, 5.
                MsgBox("Length error")
        End Select
    End Sub
    Private Sub shipImageGenerate(picbox As PictureBox, currentplayer As Integer, length As Integer, direction As Integer, column As Integer, row As Integer)
        gridOffSet = 20
        startOfBoardPosX = (Me.Width / 2) - (boardSizes / 2) + gridOffSet - gridCircleSizeNum
        startOfOpponentBoardPosY = (Me.Height / 2) - turnsbannerHeight - gridOffSet
        startOfPlayerBoardPosY = Me.Bottom - turnsbannerHeight - gridOffSet - gridCircleSizeNum

        Select Case direction
            Case 1
                'Ship faces upwards

                Dim dimension1 As Short
                dimension1 = gridCircleSizeNum * 0.6
                Dim dimension2 As Short
                dimension2 = length * gridCircleSizeNum * 0.9

                If currentplayer = 2 Then
                    picbox.Visible = True
                End If

                picbox.Location = New Point(100, 500)

                assignShipImages(currentplayer, picbox)
                rotateImage90(picbox, dimension1, dimension2)
                rotateImage90(picbox, dimension1, dimension2)
                rotateImage90(picbox, dimension1, dimension2)

                If currentplayer = 2 Then
                    picbox.Visible = False
                End If

                'Offset for correct presentation
                Dim playerShipOffsetX As Integer
                Dim playerShipOffsetY As Integer
                Dim opponentShipOffsetX As Integer
                Dim opponentShipOffsetY As Integer
                Select Case length
                    Case 2
                        playerShipOffsetX = 4
                        playerShipOffsetY = -2
                        opponentShipOffsetX = 4
                        opponentShipOffsetY = -5
                    Case 3
                        playerShipOffsetX = 4
                        playerShipOffsetY = 0
                        opponentShipOffsetX = 4
                        opponentShipOffsetY = -3
                    Case 4
                        playerShipOffsetX = 4
                        playerShipOffsetY = 0
                        opponentShipOffsetX = 4
                        opponentShipOffsetY = -2
                    Case 5
                        playerShipOffsetX = 4
                        playerShipOffsetY = 0
                        opponentShipOffsetX = 4
                        opponentShipOffsetY = 0
                End Select

                If currentplayer = 1 Then
                    picbox.Location = New Point(startOfBoardPosX + playerShipOffsetX + (column * gridCircleSizeNum), startOfPlayerBoardPosY + playerShipOffsetY - (row * gridCircleSizeNum))
                Else
                    picbox.Location = New Point(startOfBoardPosX + opponentShipOffsetX + (column * gridCircleSizeNum), startOfOpponentBoardPosY + opponentShipOffsetY - (row * gridCircleSizeNum))
                End If
            Case 2
                'Ship faces Downwards

                Dim dimension1 As Short
                dimension1 = gridCircleSizeNum * 0.6
                Dim dimension2 As Short
                dimension2 = length * gridCircleSizeNum * 0.9

                If currentplayer = 2 Then
                    picbox.Visible = True
                End If

                picbox.Location = New Point(100, 500)

                assignShipImages(currentplayer, picbox)
                rotateImage90(picbox, dimension1, dimension2)

                If currentplayer = 2 Then
                    picbox.Visible = False
                End If
                'Offset for correct presentation
                Dim playerShipOffsetX As Integer
                Dim playerShipOffsetY As Integer
                Dim opponentShipOffsetX As Integer
                Dim opponentShipOffsetY As Integer
                Select Case length
                    Case 2
                        playerShipOffsetX = 4
                        playerShipOffsetY = -2
                        opponentShipOffsetX = 4
                        opponentShipOffsetY = 6
                    Case 3
                        playerShipOffsetX = 4
                        playerShipOffsetY = 0
                        opponentShipOffsetX = 4
                        opponentShipOffsetY = 4
                    Case 4
                        playerShipOffsetX = 4
                        playerShipOffsetY = 4
                        opponentShipOffsetX = 4
                        opponentShipOffsetY = 1
                    Case 5
                        playerShipOffsetX = 4
                        playerShipOffsetY = 0
                        opponentShipOffsetX = 4
                        opponentShipOffsetY = 0
                End Select

                If currentplayer = 1 Then
                    picbox.Location = New Point(startOfBoardPosX + playerShipOffsetX + (column * gridCircleSizeNum), startOfPlayerBoardPosY + playerShipOffsetY - ((row + (length - 1)) * gridCircleSizeNum))
                Else
                    picbox.Location = New Point(startOfBoardPosX + opponentShipOffsetX + (column * gridCircleSizeNum), startOfOpponentBoardPosY - opponentShipOffsetY - ((row + (length - 1)) * gridCircleSizeNum))
                End If

            Case 3
                'Ship faces right (Default image rotation so no need To rotate)

                'Offset for correct presentation
                Dim playerShipOffsetX As Integer
                Dim playerShipOffsetY As Integer
                Dim opponentShipOffsetX As Integer
                Dim opponentShipOffsetY As Integer
                Select Case length
                    Case 2
                        playerShipOffsetX = 0
                        playerShipOffsetY = 2
                        opponentShipOffsetX = 0
                        opponentShipOffsetY = -1
                    Case 3
                        playerShipOffsetX = 2
                        playerShipOffsetY = 1
                        opponentShipOffsetX = 2
                        opponentShipOffsetY = -1
                    Case 4
                        playerShipOffsetX = 3
                        playerShipOffsetY = 1
                        opponentShipOffsetX = 4
                        opponentShipOffsetY = -1
                    Case 5
                        playerShipOffsetX = 6
                        playerShipOffsetY = 2
                        opponentShipOffsetX = 7
                        opponentShipOffsetY = -2
                End Select

                picbox.Size = New Size((length * gridCircleSizeNum) * 0.9, (gridCircleSizeNum * 0.6))

                If currentplayer = 1 Then
                    picbox.Location = New Point(startOfBoardPosX + playerShipOffsetX + ((column - (length - 1)) * gridCircleSizeNum), startOfPlayerBoardPosY + playerShipOffsetY - (row * gridCircleSizeNum))
                Else
                    picbox.Location = New Point(startOfBoardPosX + opponentShipOffsetX + ((column - (length - 1)) * gridCircleSizeNum), startOfOpponentBoardPosY + opponentShipOffsetY - (row * gridCircleSizeNum))
                End If

                assignShipImages(currentplayer, picbox)
            Case 4
                'Ship faces Left
                Dim dimension1 As Short
                dimension1 = length * gridCircleSizeNum * 0.9
                Dim dimension2 As Short
                dimension2 = gridCircleSizeNum * 0.6

                If currentplayer = 2 Then
                    picbox.Visible = True
                End If

                picbox.Location = New Point(100, 500)

                assignShipImages(currentplayer, picbox)
                rotateImage90(picbox, dimension1, dimension2)
                rotateImage90(picbox, dimension1, dimension2)

                If currentplayer = 2 Then
                    picbox.Visible = False
                End If

                'Offset for correct presentation
                Dim playerShipOffsetX As Integer
                Dim playerShipOffsetY As Integer
                Dim opponentShipOffsetX As Integer
                Dim opponentShipOffsetY As Integer
                Select Case length
                    Case 2
                        playerShipOffsetX = 0
                        playerShipOffsetY = 2
                        opponentShipOffsetX = 0
                        opponentShipOffsetY = -2
                    Case 3
                        playerShipOffsetX = 2
                        playerShipOffsetY = 1
                        opponentShipOffsetX = 2
                        opponentShipOffsetY = -2
                    Case 4
                        playerShipOffsetX = 6
                        playerShipOffsetY = 2
                        opponentShipOffsetX = 4
                        opponentShipOffsetY = -1
                    Case 5
                        playerShipOffsetX = 6
                        playerShipOffsetY = 2
                        opponentShipOffsetX = 6
                        opponentShipOffsetY = -2
                End Select

                If currentplayer = 1 Then
                    picbox.Location = New Point(startOfBoardPosX + playerShipOffsetX + (column * gridCircleSizeNum), startOfPlayerBoardPosY + playerShipOffsetY - (row * gridCircleSizeNum))
                Else
                    picbox.Location = New Point(startOfBoardPosX + opponentShipOffsetX + (column * gridCircleSizeNum), startOfOpponentBoardPosY + opponentShipOffsetY - (row * gridCircleSizeNum))
                End If
        End Select

    End Sub
    Private Sub rotateImage90(picbox As PictureBox, dimension1 As Short, dimension2 As Short)
        wait(0.01)
        Dim bmp As Bitmap = New Bitmap(picbox.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        picbox.Image = bmp
        picbox.Size = New Size(dimension1, dimension2)
    End Sub
    Private Sub revealships()
        If gameOver = True Then
            'show opponentsShips
            opponentshipPicbox2.Visible = True
            opponentshipPicbox3a.Visible = True
            opponentshipPicbox3b.Visible = True
            opponentshipPicbox4.Visible = True
            opponentshipPicbox5.Visible = True
        Else
            'hide opponents ships
            opponentshipPicbox2.Visible = False
            opponentshipPicbox3a.Visible = False
            opponentshipPicbox3b.Visible = False
            opponentshipPicbox4.Visible = False
            opponentshipPicbox5.Visible = False
        End If
    End Sub
    Private Sub assignGridImages(gameArray As Array, pictureBoxArray As Object, currentPlayer As Integer)
        'Updates and changes the picture depending on the value of the palyer
        Dim col As Integer
        Dim row As Integer

        For col = 1 To gridSize
            For row = 1 To gridSize
                Select Case gameArray(col, row)
                    Case 0 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\TransparentCircle.png"
                    'Case 1 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\placeholderCircle.png"
                    Case 2 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\BlueCircle.png"
                    Case 3 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\RedCircle.png"
                        'Case 4 : pictureBoxArray(col, row).ImageLocation = Application.StartupPath & "\pictures\GreenCircle.png"
                End Select
            Next row
        Next col
    End Sub
    Private Sub getPlayerMove(ByVal sender As Object, ByVal e As EventArgs)
        Dim picLocation As String

        If currentPlayer = 1 Then
            picLocation = sender.Name
            If picLocation.Length = 3 Then
                If picLocation(1) = "0" Then
                    'row 10
                    playerMoveX = CInt(Strings.Left(sender.Name, 2))
                    PlayerMoveY = CInt(Strings.Right(sender.Name, 1))
                Else
                    'col 10
                    If picLocation(2) = "0" Then
                        playerMoveX = CInt(Strings.Left(sender.Name, 1))
                        PlayerMoveY = CInt(Strings.Right(sender.Name, 2))
                    End If
                End If
            Else
                If picLocation.Length = 4 Then
                    'row 10 col 10
                    playerMoveX = CInt(Strings.Left(sender.Name, 2))
                    PlayerMoveY = CInt(Strings.Right(sender.Name, 2))
                Else
                    'single digit row and col
                    playerMoveX = CInt(Strings.Left(sender.Name, 1))
                    PlayerMoveY = CInt(Strings.Right(sender.Name, 1))
                End If
            End If
            game()
        End If
    End Sub
    Private Sub game()
        'check
        check(playerMoveX, PlayerMoveY, opponentgameArray)

        'update score
        updateInGameScore(1)

        'display grid
        assignGridImages(opponentgameArray, opponentpictureBoxArray, currentPlayer)

        If gameOver = True Then
            revealships()
            determineScore()
            'scoring()
        Else

            If playerextraTurn = False Then
                swapPlayer()

                wait(1)
                computerMove()

                'check, returns whether it is game over or not
                check(opponentMoveX, opponentMoveY, playergameArray)

                'update score
                updateInGameScore(2)

                'display grid
                assignGridImages(playergameArray, playerpictureBoxArray, currentPlayer)


                If gameOver = True Then
                    revealships()
                    determineScore()
                    'scoring()
                Else
                    If computerextraTurn = False Then
                        swapPlayer()
                    Else
                        While computerextraTurn = True
                            MsgBox("computer extra turn...")

                            wait(1)
                            computerMove()

                            'check, returns whether it is game over or not
                            check(opponentMoveX, opponentMoveY, playergameArray)

                            'update score
                            updateInGameScore(2)

                            'display grid
                            assignGridImages(playergameArray, playerpictureBoxArray, currentPlayer)

                            If gameOver = True Then
                                computerextraTurn = False
                            End If

                        End While
                        If gameOver = True Then
                            revealships()
                            determineScore()
                            'scoring()
                        Else
                            swapPlayer()
                        End If
                    End If
                End If
            Else
                MsgBox("player extra turn...")
            End If
        End If
    End Sub
    Private Function check(MoveX As Integer, MoveY As Integer, gameArr As Array) As Array

        If gameArr(MoveX, MoveY) = 0 Then
            'Miss
            gameArr(MoveX, MoveY) = 2
            playerextraTurn = False
            computerextraTurn = False

            If currentPlayer = 2 Then
                previousHit = False
                If oppositePath = True Then
                    NextShip = True
                End If
            End If
        Else
            If gameArr(MoveX, MoveY) = 1 OrElse gameArr(MoveX, MoveY) = 4 Then
                'Hit
                gameArr(MoveX, MoveY) = 3

                'To control the computer move
                If currentPlayer = 2 Then
                    If hasAHit = False Then
                        hasAHit = True
                        hasAhitLocation.X = MoveX
                        hasAhitLocation.Y = MoveY
                        previousHit = False
                        computerStage = 1
                    Else
                        previousHit = True
                        computerStage = 2
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
    Private Function determineScore() As Integer
        Dim winner = currentPlayer
        'game ended by time, boardEmpty = False
        If boardEmpty = True Then
            If winner = 1 Then
                MsgBox("YOU WIN!")

            Else
                MsgBox("YOU LOSE!")
            End If
            score = CInt(playerscoretxt.Text) - CInt(opponentscoretxt.Text)
        Else
            MsgBox("Ended by timer")
            For row = 1 To gridSize
                For column = 1 To gridSize
                    If playergameArray(column, row) = 1 OrElse playergameArray(column, row) = 4 Then
                        score = score + 1
                    End If
                Next column
            Next row

            For row = 1 To gridSize
                For column = 1 To gridSize
                    If opponentgameArray(column, row) = 1 Then
                        score = score - 1
                    End If
                Next column
            Next row

            If score > 0 Then
                MsgBox("YOU WIN!")
            Else
                MsgBox("YOU LOSE!")
            End If
        End If
        MsgBox(score)
        Return score
    End Function
    Private Sub updateInGameScore(currentPlayer As Integer)
        Dim playerScore As Integer
        Dim opponentScore As Integer

        If currentPlayer = 1 Then
            For row = 1 To gridSize
                For column = 1 To gridSize
                    If opponentgameArray(column, row) = 3 Then
                        playerScore = playerScore + 1
                    End If
                Next column
            Next row
            playerscoretxt.Text = playerScore
        Else
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
    Private Sub wait(ByVal seconds As Short)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Sub displayCurrentPlayer()
        If currentPlayer = 1 Then
            TurnsBannerPic.ImageLocation = Application.StartupPath & "\Pictures\PlayerTurnBanner.png"
        ElseIf currentPlayer = 2 Then
            TurnsBannerPic.ImageLocation = Application.StartupPath & "\Pictures\OpponentTurnBanner.png"
        End If
    End Sub
    Private Sub computerMove()
        Dim tempdifficulty As String
        tempdifficulty = difficulty
        If tempdifficulty = "Unfair" Then
            tempdifficulty = "Hard"
        End If

        Select Case tempdifficulty
            Case "beginner"
                randomSquare()

            Case "Normal"
                If hasAHit = False Then
                    randomSquare()
                Else
                    randomAdjacent()
                End If

            Case "Hard"
                If hasAHit = False Then
                    randomSquare()
                Else
                    If computerStage = 1 Then
                        randomAdjacent()
                    Else
                        If previousHit = True Then
                            continueOnPath()
                        Else
                            If NextShip = True Then
                                hasAHit = False
                                randomSquare()
                            Else
                                swapPathDirection()
                                continueOnPath()
                            End If
                        End If
                    End If
                End If

            Case "Impossible"
                For row = 1 To gridSize
                    For column = 1 To gridSize
                        If playergameArray(column, row) = 1 OrElse playergameArray(column, row) = 4 Then
                            opponentMoveX = column
                            opponentMoveY = row
                        End If
                    Next column
                Next row
            Case Else
                'temporary Go thru array
                If opponentMoveX = gridSize Then
                    opponentMoveY = opponentMoveY + 1
                    opponentMoveX = 1
                Else
                    opponentMoveX = opponentMoveX + 1
                End If
        End Select
    End Sub

    Private Sub randomSquare()
        opponentMoveX = Int(Rnd() * gridSize) + 1
        opponentMoveY = Int(Rnd() * gridSize) + 1
    End Sub

    Private Sub randomAdjacent()
        MsgBox("Random Adjacent")
    End Sub
    Private Sub continueOnPath()
        MsgBox("Continue On Path")
    End Sub
    Private Sub swapPathDirection()
        MsgBox("Swap Path Direction")
    End Sub

    Private Sub swapPlayer()
        'switches between the value of 1 and 2 each time to swap players after each turn
        currentPlayer = AlternateNum(currentPlayer)
        displayCurrentPlayer()
    End Sub
    Public Function AlternateNum(num As Integer)
        num = 2 / num
        Return num
    End Function
    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        Me.Hide()
        MainMenuForm.Show()
    End Sub
    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        onFormLoad()
    End Sub
    Private Sub scoring()
        readHighScores()
        Dim sortbytime = False
        Dim sortbyscores = True
        Dim order = "descending"
        BubbleSort(sortbyscores, sortbytime, order)
        WriteHighScores()
    End Sub
    Public Sub WriteHighScores()
        Dim i As Integer
        FileSystem.FileOpen(1, "hs.txt", OpenMode.Output)
        For i = 1 To 10
            FileSystem.Write(1, arrHighScores(i).score)
            FileSystem.Write(1, arrHighScores(i).name)
            FileSystem.Write(1, convertTimeToInteger(arrHighScores(i).time))
        Next
        FileSystem.FileClose(1)
    End Sub
    Public Sub readHighScores()
        Dim i As Integer
        FileSystem.FileOpen(1, "hs.txt", OpenMode.Input)
        For i = 1 To 10
            Dim fileContents
            FileSystem.Input(1, fileContents)
            arrHighScores(i).score = fileContents

            FileSystem.Input(1, fileContents)
            arrHighScores(i).name = fileContents

            FileSystem.Input(1, fileContents)

            fileContents = convertTimeToDisplay(CInt(fileContents))
            arrHighScores(i).time = fileContents
        Next
        FileSystem.FileClose(1)
    End Sub
    Private Function convertTimeToDisplay(time) As String
        If time < 10 Then
            'under than 10 sec
            time = "00:0" & CStr(time)
        Else
            'between 10s and 1min
            If time < 60 Then
                time = "00:" & CStr(time)
            Else
                'between 1 and 10min
                If time < 600 Then
                    time = "0" & Math.Floor(time / 60) & ":" & (time - (Math.Floor(time / 60) * 60))
                Else
                    'anything above 10min
                    time = Math.Floor(time / 60) & ":" & (time - (Math.Floor(time / 60) * 60))
                End If
            End If
        End If
        Return time
    End Function
    Private Function convertTimeToInteger(time As String) As String
        Dim subtime As String
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
        Else
            MsgBox("Going wrong")
        End If

        Return time
    End Function
    Public Sub BubbleSort(sortByScores As Boolean, sortByTime As Boolean, order As String)
        Dim Swapped As Boolean
        Swapped = True
        Dim Last As Integer
        Last = arrHighScores.Length - 1
        While Swapped = True
            Swapped = False
            Dim i = 1
            While i < Last

                If sortByScores = True Then
                    If order = "descending" Then
                        If arrHighScores(i).score < arrHighScores(i + 1).score Then
                            Swap(arrHighScores(i), arrHighScores(i + 1))
                            Swapped = True
                        End If
                    Else
                        If arrHighScores(i).score > arrHighScores(i + 1).score Then
                            Swap(arrHighScores(i), arrHighScores(i + 1))
                            Swapped = True
                        End If
                    End If

                End If
                If sortByTime = True Then
                    If order = "descending" Then
                        If CInt(convertTimeToInteger(arrHighScores(i).time)) < CInt(convertTimeToInteger(arrHighScores(i + 1).time)) Then
                            Swap(arrHighScores(i), arrHighScores(i + 1))
                            Swapped = True
                        End If
                    Else
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
    Private Sub Swap(ByRef A As recHighScore, ByRef B As recHighScore)
        Dim Temp As recHighScore
        Temp = A
        A = B
        B = Temp
    End Sub
End Class