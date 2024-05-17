Public Class MainMenuForm
    ''' <summary>
    '''  subroutine called upon the form's load to call the subroutine to initialise controls
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the game is played
        initialiseFormControls()
        formID = "MainMenu"
    End Sub
    ''' <summary>
    ''' Initialises all the controls on the form in the correct locations and sizes.
    ''' </summary>
    Private Sub initialiseFormControls()
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
        backgroundImg.ImageLocation = Application.StartupPath & "\Pictures\battleShipsMainMenuBackground.png"
        backgroundImg.Size = New Size(Me.Width - 15, Me.Height - 38)
        backgroundImg.Location = New Point(0, 0)
        backgroundImg.Load(backgroundImg.ImageLocation)
    End Sub
    ''' <summary>
    ''' Subroutine which takes the user to the GameSettings form.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub playfrommainbtn_Click(sender As Object, e As EventArgs) Handles playfrommainbtn.Click
        'When the Play button is pressed
        Me.Hide()
        GameSettingsForm.onLoadSettings()
        GameSettingsForm.Show()
    End Sub
    ''' <summary>
    ''' Subroutine which takes the user to the Highscores form.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub openhsbutton_Click(sender As Object, e As EventArgs) Handles openhsbutton.Click
        'When the High-score button is pressed
        Me.Hide()
        HighScoresForm.Show()
        HighScoresForm.onLoadHighScores()
    End Sub
    ''' <summary>
    ''' Subroutine which takes the user to the Highscores form.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub quitProgrambtn_Click(sender As Object, e As EventArgs) Handles quitProgrambtn.Click
        'When the Quit button is pressed
        Me.Close()
    End Sub
    ''' <summary>
    ''' Subroutine which calls the EnterOverBigButton() upon moving on the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub playfrommainbtn_Enter(sender As Object, e As EventArgs) Handles playfrommainbtn.MouseEnter
        EnterOverBigButton(sender)
    End Sub
    ''' <summary>
    ''' Subroutine which calls the ExitOverBigButton() upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub playfrommainbtn_Leave(sender As Object, e As EventArgs) Handles playfrommainbtn.MouseLeave
        ExitOverBigButton(sender)
    End Sub
    ''' <summary>
    ''' Subroutine which calls the EnterOverBigButton() upon moving on the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub openhsbutton_Enter(sender As Object, e As EventArgs) Handles openhsbutton.MouseEnter
        EnterOverBigButton(sender)
    End Sub
    ''' <summary>
    ''' Subroutine which calls the ExitOverBigButton() upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub openhsbutton_Leave(sender As Object, e As EventArgs) Handles openhsbutton.MouseLeave
        ExitOverBigButton(sender)
    End Sub
    ''' <summary>
    ''' Subroutine which calls the EnterOverBigButton() upon moving on the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub quitProgrambtn_Enter(sender As Object, e As EventArgs) Handles quitProgrambtn.MouseEnter
        EnterOverBigButton(sender)
    End Sub
    ''' <summary>
    ''' Subroutine which calls the ExitOverBigButton() upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub quitProgrambtn_Leave(sender As Object, e As EventArgs) Handles quitProgrambtn.MouseLeave
        ExitOverBigButton(sender)
    End Sub
    ''' <summary>
    ''' Subroutine which switches the button's image out for the purple image (for hover)
    ''' </summary>
    ''' <param name="targetButton">The button the user has hovered over</param>
    Private Sub EnterOverBigButton(targetButton As Button)
        targetButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\ButtonPurple.png")
    End Sub
    ''' <summary>
    ''' Subroutine which switches the button's image out for the blue image (back to normal)
    ''' </summary>
    ''' <param name="targetButton">The button the user has hovered over</param>
    Private Sub ExitOverBigButton(targetButton As Button)
        targetButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\ButtonBlue.png")
    End Sub
End Class