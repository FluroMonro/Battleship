Public Class gameOverForm
    ''' <summary>
    '''  subroutine called upon the form's load to call the subroutine to initialise controls
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub gameOverForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        onLoadsettings()
    End Sub
    ''' <summary>
    ''' Subroutine which sets initialises the variable holding the outcome of the game and passes it into initialiseFormControls()
    ''' </summary>
    Public Sub onLoadsettings()
        formID = "gameOverForm"
        Dim outcomeOfGame As String
        outcomeOfGame = gameOutcome

        initialiseFormControls(outcomeOfGame)
    End Sub
    ''' <summary>
    ''' Subroutine which initialises the placement, sizes, images, text etc. of the controls on the form
    ''' </summary>
    ''' <param name="outcomeOfGame">Who won the game. Determines what is shown on the form.</param>
    Public Sub initialiseFormControls(outcomeOfGame As String)
        Me.WindowState = FormWindowState.Maximized
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        'Setting the placement and size of controls on the form

        backgroundImg.ImageLocation = Application.StartupPath & "\Pictures\battleShipsBackground.png"
        backgroundImg.Size = New Size(Me.Width - 15, Me.Height - 38)
        backgroundImg.Location = New Point(0, 0)
        backtomainbtn.Location = New Point(Me.Width - 265, Me.Height - 195)
        scoretxt.Text = endScore
        timetxt.Text = endTime

        If outcomeOfGame = "Win" Then
            youwinlbl.Visible = True
            scorelbl.Visible = True
            scoretxt.Visible = True
            computerwinslbl.Visible = False
            drawlbl.Visible = False
        Else
            youwinlbl.Visible = False
            scorelbl.Visible = False
            scoretxt.Visible = False

            If outcomeOfGame = "Lose" Then
                computerwinslbl.Visible = True
                drawlbl.Visible = False
            Else
                computerwinslbl.Visible = False
                drawlbl.Visible = True
            End If

        End If
    End Sub
    ''' <summary>
    ''' Subroutine which calls the EnterOverSmallButton() from the highscores form upon moving on the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Enter(sender As Object, e As EventArgs) Handles backtomainbtn.MouseEnter
        HighScoresForm.EnterOverSmallButton("backtomainbtn", Me)
    End Sub
    ''' <summary>
    ''' Subroutine which calls the ExitOverSmallButton() from the highscores form upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Leave(sender As Object, e As EventArgs) Handles backtomainbtn.MouseLeave
        HighScoresForm.ExitOverSmallButton("backtomainbtn", Me)
    End Sub
    ''' <summary>
    ''' Subroutine which takes the user to the main menu form.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        'When Exit button is clicked
        Me.Hide()
        MainMenuForm.Show()
    End Sub
End Class