Public Class MainMenuForm
    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialiseControlsPlacement()
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
        playfrommainbtn.Location = New Point(Me.Width / 2 - (250 / 2), 300)
        playfrommainbtn.Size = New Size(250, 50)
        openhsbutton.Location = New Point(Me.Width / 2 - (250 / 2), 425)
        openhsbutton.Size = New Size(250, 50)
        quitProgrambtn.Location = New Point(Me.Width / 2 - (250 / 2), 550)
        quitProgrambtn.Size = New Size(250, 50)
        backgroundMapImg.ImageLocation = Application.StartupPath & "\Pictures\mapBackground.png"
        backgroundMapImg.Size = New Size(Me.Width - (Me.Width / 90), Me.Height - (Me.Height / 24))
        backgroundMapImg.Location = New Point(0, 0)
        backgroundMapImg.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        Me.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        WaterBoarder.ImageLocation = Application.StartupPath & "\Pictures\WaterBoard.png"
        WaterBoarder.Size = New Size(Me.Width - 220, Me.Height - 250)
        WaterBoarder.Location = New Point(100, 100)
        WaterBoarder.BackColor = Color.FromArgb(CByte(193), CByte(144), CByte(88))
    End Sub








    Private Sub playfrommainbtn_Click(sender As Object, e As EventArgs) Handles playfrommainbtn.Click
        Me.Hide()
        GameSettingsForm.Show()
        GameSettingsForm.onLoadSettings()
    End Sub

    Private Sub openhsbutton_Click(sender As Object, e As EventArgs) Handles openhsbutton.Click
        Me.Hide()
        HighScoresForm.Show()
        HighScoresForm.onLoadHighScores()
    End Sub

    Private Sub quitProgrambtn_Click(sender As Object, e As EventArgs) Handles quitProgrambtn.Click
        Me.Close()
    End Sub
End Class
