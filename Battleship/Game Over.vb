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
        backToMainbtn.Location = New Point(Me.Width - 265, Me.Height - 195)
        toHsbtn.Location = New Point(Me.Width - 405, Me.Height - 195)
        scoreTextlbl.Text = endScore
        timeTextlbl.Text = endTime
        shotsTextlbl.Text = shotsNum.ToString
        shipsSunkTextlbl.Text = sunkNum.ToString
        accuracyTextlbl.Text = accuracyStr
        boardSizeTextlbl.Text = gridSize & "x" & gridSize
        difTextlbl.Text = difficulty
        gameOverlbl.Location = New Point((Me.Width / 2) - (gameOverlbl.Width / 2), 200)

        'Display the appropriate form controls 
        If outcomeOfGame = "Win" Then
            youWinlbl.Visible = True
            scorelbl.Visible = True
            scoreTextlbl.Visible = True
            computerWinslbl.Visible = False
            drawlbl.Visible = False
        Else
            youWinlbl.Visible = False
            scorelbl.Visible = False
            scoreTextlbl.Visible = False

            If outcomeOfGame = "Lose" Then
                computerWinslbl.Visible = True
                drawlbl.Visible = False
            Else
                computerWinslbl.Visible = False
                drawlbl.Visible = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Subroutine which calls the EnterOverSmallButton() from the highscores form upon moving on the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Enter(sender As Object, e As EventArgs) Handles backToMainbtn.MouseEnter
        highScoresfrm.EnterOverSmallButton(sender, Me)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the ExitOverSmallButton() from the highscores form upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Leave(sender As Object, e As EventArgs) Handles backToMainbtn.MouseLeave
        highScoresfrm.ExitOverSmallButton(sender, Me)
    End Sub
    ''' <summary>
    ''' Subroutine which calls the EnterOverSmallButton() from the highscores form upon moving on the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub tohsbtn_Enter(sender As Object, e As EventArgs) Handles toHsbtn.MouseEnter
        highScoresfrm.EnterOverSmallButton(sender, Me)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the ExitOverSmallButton() from the highscores form upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub tohsbtn_Leave(sender As Object, e As EventArgs) Handles toHsbtn.MouseLeave
        highScoresfrm.ExitOverSmallButton(sender, Me)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the openMainMenu() subroutine when button is clicked
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backToMainbtn.Click
        openMainMenu(sender)
    End Sub

    ''' <summary>
    ''' Subroutine closes the current function and 
    ''' </summary>
    ''' <param name="sender">The form passed in to close</param>
    Public Sub openMainMenu(sender As Object)
        'When Exit button is clicked
        Me.Hide()
        mainMenufrm.Show()
    End Sub

    ''' <summary>
    ''' Subroutine which takes the user to the High Scores Form.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub tohsbtn_Click(sender As Object, e As EventArgs) Handles toHsbtn.Click
        mainMenufrm.openHsForm(sender)
    End Sub
End Class