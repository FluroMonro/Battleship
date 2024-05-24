Imports System.Drawing.Text

Public Class mainMenufrm
    ''' <summary>
    ''' Subroutine called upon the form's load
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainMenuFormLoad()
    End Sub

    ''' <summary>
    ''' Subroutine calls the initialiseFormControls() subroutine
    ''' </summary>
    Public Sub mainMenuFormLoad()
        'When the game is opened
        formID = "MainMenu"
        initialiseFormControls()
    End Sub

    ''' <summary>
    ''' Subroutine Initialises all the controls on the form in the correct locations and sizes and images.
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

        'Setting the placement and size of controls on the screen
        backgroundpb.ImageLocation = Application.StartupPath & "\Pictures\battleShipsMainMenuBackground.png"
        backgroundpb.Size = New Size(Me.Width - 15, Me.Height - 38)
        backgroundpb.Location = New Point(0, 0)
        backgroundpb.Load(backgroundpb.ImageLocation)
        titlelbl.Size = New Size(336, 71)
        titlelbl.Location = New Point((Me.Width / 2) - (titlelbl.Width / 2), 200)
        playFromMainbtn.Location = New Point(Me.Width / 2 - (250 / 2), 375)
        playFromMainbtn.Size = New Size(250, 50)
        openHsbtn.Location = New Point(Me.Width / 2 - (250 / 2), 500)
        openHsbtn.Size = New Size(250, 50)
        quitProgrambtn.Location = New Point(Me.Width / 2 - (250 / 2), 625)
        quitProgrambtn.Size = New Size(250, 50)
    End Sub

    ''' <summary>
    ''' Subroutine calls openGameSettings() upon button click
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub playFromMainbtn_Click(sender As Object, e As EventArgs) Handles playFromMainbtn.Click
        openGameSettings()
    End Sub

    ''' <summary>
    ''' Subroutine opens the Game Settings form
    ''' </summary>
    Private Sub openGameSettings()
        battleshipGamefrm.Close()
        gameOverfrm.Close()
        Me.Hide()
        gameSettingsfrm.onLoadSettings()
        gameSettingsfrm.Show()
    End Sub

    ''' <summary>
    ''' Subroutine calls openHsForm() upon the button click
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub openhsbutton_Click(sender As Object, e As EventArgs) Handles openHsbtn.Click
        openHsForm(sender)
    End Sub

    ''' <summary>
    ''' Subroutine opens the High scores form
    ''' Example of use: openHsForm(battleshipGamefrm)
    ''' </summary>
    ''' <param name="sender"></param>
    Public Sub openHsForm(sender As Object)
        Me.Hide()
        highScoresfrm.Show()
        highScoresfrm.onLoadHighScores()
    End Sub

    ''' <summary>
    ''' Subroutine calls closeProgram() on the button click
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub quitProgrambtn_Click(sender As Object, e As EventArgs) Handles quitProgrambtn.Click
        closeProgram()
    End Sub

    ''' <summary>
    ''' Subroutine closes the entire program, including the hidden forms.
    ''' </summary>
    Private Sub closeProgram()
        Me.Close()
        battleshipGamefrm.Close()
        gameOverfrm.Close()
        gameSettingsfrm.Close()
        highScoresfrm.Close()
    End Sub

    ''' <summary>
    ''' Subroutine which calls the EnterOverBigButton() upon moving on the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub playfrommainbtn_Enter(sender As Object, e As EventArgs) Handles playFromMainbtn.MouseEnter
        EnterOverBigButton(sender)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the ExitOverBigButton() upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub playfrommainbtn_Leave(sender As Object, e As EventArgs) Handles playFromMainbtn.MouseLeave
        ExitOverBigButton(sender)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the EnterOverBigButton() upon moving on the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub openhsbutton_Enter(sender As Object, e As EventArgs) Handles openHsbtn.MouseEnter
        EnterOverBigButton(sender)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the ExitOverBigButton() upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub openhsbutton_Leave(sender As Object, e As EventArgs) Handles openHsbtn.MouseLeave
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
    ''' Example of use: EnterOverBigButton(exitbtn)
    ''' </summary>
    ''' <param name="targetButton">The button control the user has hovered over</param>
    Private Sub EnterOverBigButton(targetButton As Button)
        targetButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\ButtonPurple.png")
    End Sub

    ''' <summary>
    ''' Subroutine which switches the button's image out for the blue image (back to normal)
    ''' Example of use: ExitOverBigButton(exitbtn)
    ''' </summary>
    ''' <param name="targetButton">The button control the user has hovered over</param>
    Private Sub ExitOverBigButton(targetButton As Button)
        targetButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\ButtonBlue.png")
    End Sub
End Class