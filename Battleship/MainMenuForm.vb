﻿Public Class MainMenuForm
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
        Titlelbl.Location = New Point(Me.Width / 2 - (336 / 2), 200)
        Titlelbl.Size = New Size(336, 71)
        playfrommainbtn.Location = New Point(Me.Width / 2 - (250 / 2), 375)
        playfrommainbtn.Size = New Size(250, 50)
        openhsbutton.Location = New Point(Me.Width / 2 - (250 / 2), 500)
        openhsbutton.Size = New Size(250, 50)
        quitProgrambtn.Location = New Point(Me.Width / 2 - (250 / 2), 625)
        quitProgrambtn.Size = New Size(250, 50)
        backgroundImg.ImageLocation = Application.StartupPath & "\Pictures\battleShipsBackground.png"
        backgroundImg.Size = New Size(Me.Width - 15, Me.Height - 38)
        backgroundImg.Location = New Point(0, 0)
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
