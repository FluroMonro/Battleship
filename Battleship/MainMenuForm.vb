Public Class MainMenuForm
    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the game is played
        initialiseControlsPlacement()
        formID = "MainMenu"
    End Sub
    Private Sub initialiseControlsPlacement()
        'To intialise the controls in the correct way

        'To initialise the screen size as the fullscreen display size of the user
        Me.WindowState = FormWindowState.Maximized
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        'Setting the placement and size of controls on the screen
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
        'When the Play button is pressed
        Me.Hide()
        GameSettingsForm.Show()
        GameSettingsForm.onLoadSettings()
    End Sub
    Private Sub openhsbutton_Click(sender As Object, e As EventArgs) Handles openhsbutton.Click
        'When the High-score button is pressed
        Me.Hide()
        HighScoresForm.Show()
        HighScoresForm.onLoadHighScores()
    End Sub
    Private Sub quitProgrambtn_Click(sender As Object, e As EventArgs) Handles quitProgrambtn.Click
        'When the Quit button is pressed
        Me.Close()
    End Sub
    Private Sub playfrommainbtn_Enter(sender As Object, e As EventArgs) Handles playfrommainbtn.MouseEnter
        EnterOverBigButton("playfrommainbtn")
    End Sub
    Private Sub playfrommainbtn_Leave(sender As Object, e As EventArgs) Handles playfrommainbtn.MouseLeave
        ExitOverBigButton("playfrommainbtn")
    End Sub
    Private Sub openhsbutton_Enter(sender As Object, e As EventArgs) Handles openhsbutton.MouseEnter
        EnterOverBigButton("openhsbutton")
    End Sub
    Private Sub openhsbutton_Leave(sender As Object, e As EventArgs) Handles openhsbutton.MouseLeave
        ExitOverBigButton("openhsbutton")
    End Sub
    Private Sub quitProgrambtn_Enter(sender As Object, e As EventArgs) Handles quitProgrambtn.MouseEnter
        EnterOverBigButton("quitProgrambtn")
    End Sub
    Private Sub quitProgrambtn_Leave(sender As Object, e As EventArgs) Handles quitProgrambtn.MouseLeave
        ExitOverBigButton("quitProgrambtn")
    End Sub
    Private Sub EnterOverBigButton(buttonName As String)
        Dim targetObject As Button
        targetObject = Me.Controls.Item(buttonName)
        targetObject.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\ButtonPurple.png")
    End Sub
    Private Sub ExitOverBigButton(buttonName As String)
        Dim targetObject As Button
        targetObject = Me.Controls.Item(buttonName)
        targetObject.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\ButtonBlue.png")
    End Sub
End Class
