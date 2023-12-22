Public Class GameSettingsForm
    Dim playerName As String
    Private Sub GameSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialiseControlsPlacement()
        onLoadSettings()
    End Sub

    Public Sub onLoadSettings()
        playerNameInputTxtbox.Text = ""
        playernamewarninglbl.Visible = False
        BoardSizebtn10.Checked = True
        shipPlacementRand.Checked = True
        difNorm.Checked = True

    End Sub

    Private Sub initialiseControlsPlacement()
        'To place the controls in the same position relative to the custom display size of the user

        'To initialise the screen size as the fullscreen display size of the user
        Me.WindowState = FormWindowState.Maximized
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        'Setting the placement and size relative to the screen
        'WaterBoarder.ImageLocation = Application.StartupPath & "\Pictures\WaterBoard.png"
        'WaterBoarder.Size = New Size(Me.Width - 42, Me.Height - 64)

        Titlelbl.Location = New Point(Me.Width / 2 - (336 / 2), 125)
        Titlelbl.Size = New Size(336, 71)
        playerNameInputTxtbox.Size = New Size(100, 40)
        backgroundMapImg.ImageLocation = Application.StartupPath & "\Pictures\mapBackground.png"
        backgroundMapImg.Size = New Size(Me.Width - (Me.Width / 90), Me.Height - (Me.Height / 24))
        backgroundMapImg.Location = New Point(0, 0)
        backgroundMapImg.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        Me.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        WaterBoarder.ImageLocation = Application.StartupPath & "\Pictures\WaterBoard.png"
        WaterBoarder.Size = New Size(Me.Width - 220, Me.Height - 250)
        WaterBoarder.Location = New Point(100, 100)
        WaterBoarder.BackColor = Color.FromArgb(CByte(193), CByte(144), CByte(88))
        backtomainbtn.Parent = WaterBoarder
        playbtnGameSettings.Parent = WaterBoarder
        backtomainbtn.Location = New Point(WaterBoarder.Width - 120, WaterBoarder.Height - 60)
        playbtnGameSettings.Location = New Point(WaterBoarder.Width - 220, WaterBoarder.Height - 60)
    End Sub



    Private Function validateName(name As String) As Boolean
        Dim length As Integer
        Dim valid As Boolean
        length = name.Length
        If length >= 3 And length <= 16 Then
            Valid = True
        Else
            playernamewarninglbl.Visible = True
        End If
        Return valid
    End Function




    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        Me.Hide()
        MainMenuForm.Show()
    End Sub

    Private Sub playbtnGameSettings_Click(sender As Object, e As EventArgs) Handles playbtnGameSettings.Click
        'validate name
        playerName = playerNameInputTxtbox.Text

        If BoardSizebtn8.Checked = True Then
            gridSize = 8
        Else
            If BoardSizebtn10.Checked = True Then
                gridSize = 10
            Else
                If BoardSizebtn12.Checked = True Then
                    gridSize = 12
                Else
                    If BoardSizebtn14.Checked = True Then
                        gridSize = 14
                    End If
                End If
            End If
        End If

        If shipPlacementRand.Checked = True Then
            isShipPlacementRandom = True
        Else
            isShipPlacementRandom = False
        End If


        If difBegin.Checked = True Then
            difficulty = 1
        Else
            If difNorm.Checked = True Then
                difficulty = 2
            Else
                If difHard.Checked = True Then
                    difficulty = 3
                Else
                    If difImpos.Checked = True Then
                        difficulty = 4
                    End If
                End If
            End If
        End If


        If validateName(playerName) = True Then
            playGame()
        End If
    End Sub

    Private Sub playGame()
        BattleShipsGame.updateGlobalVars(playerName, gridSize, difficulty, isShipPlacementRandom)
        Me.Hide()
        BattleShipsGame.Show()
        BattleShipsGame.onFormLoad()
        playerNameInputTxtbox.Text = ""
    End Sub

    Private Sub timerckbx_CheckedChanged(sender As Object, e As EventArgs) Handles timerckbx.CheckedChanged
        If timerckbx.Checked = True Then
            timerValueBar.Visible = True
        Else
            timerValueBar.Visible = False
        End If
    End Sub
End Class