Public Class gameOverfrm
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
    ''' These controls are dependant on the outcome of the game (what is shown and what it hidden)
    ''' Example of use: initialiseFormControls("Win")
    ''' </summary>
    ''' <param name="outcomeOfGame">Who won the game. Determines what is shown on the form.</param>
    Private Sub initialiseFormControls(outcomeOfGame As String)
        'To initialise the screen size as the fullscreen display size of the user
        Me.WindowState = FormWindowState.Maximized
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)

        'To force the game to a 1528x960 window unless already that resolution in fullscreen
        If Me.Width <> 1528 And Me.Height <> 960 Then
            Me.WindowState = FormWindowState.Normal
            Me.Size = New Size(1528, 960)
        End If

        'Setting the placement and size of controls on the form
        backgroundpb.ImageLocation = Application.StartupPath & "\Pictures\battleShipsBackground.png"
        backgroundpb.Size = New Size(Me.Width - 15, Me.Height - 38)
        backgroundpb.Location = New Point(0, 0)
        backtomainbtn.Location = New Point(Me.Width - 265, Me.Height - 195)
        tohsbtn.Location = New Point(Me.Width - 405, Me.Height - 195)
        scoretxt.Text = endScore
        timetxt.Text = endTime
        shotstxt.Text = shotsNum.ToString
        shipsSunktxt.Text = sunkNum.ToString
        accuracytxt.Text = accuracyStr
        gameOverlbl.Location = New Point((Me.Width / 2) - (gameOverlbl.Width / 2), 200)

        'Display the appropriate form controls 
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
        highScoresfrm.EnterOverSmallButton("backtomainbtn", Me)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the ExitOverSmallButton() from the highscores form upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Leave(sender As Object, e As EventArgs) Handles backtomainbtn.MouseLeave
        highScoresfrm.ExitOverSmallButton("backtomainbtn", Me)
    End Sub
    ''' <summary>
    ''' Subroutine which calls the EnterOverSmallButton() from the highscores form upon moving on the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub tohsbtn_Enter(sender As Object, e As EventArgs) Handles tohsbtn.MouseEnter
        highScoresfrm.EnterOverSmallButton("tohsbtn", Me)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the ExitOverSmallButton() from the highscores form upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub tohsbtn_Leave(sender As Object, e As EventArgs) Handles tohsbtn.MouseLeave
        highScoresfrm.ExitOverSmallButton("tohsbtn", Me)
    End Sub


    ''' <summary>
    ''' Subroutine which takes the user to the main menu form.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        'When Exit button is clicked
        Me.Hide()
        mainMenufrm.Show()
    End Sub
    ''' <summary>
    ''' Subroutine which takes the user to the High Scores Form.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub tohsbtn_Click(sender As Object, e As EventArgs) Handles tohsbtn.Click
        'When the Highscore button is clicked
        Me.Hide()
        highScoresfrm.Show()
        highScoresfrm.onLoadHighScores()
    End Sub
End Class