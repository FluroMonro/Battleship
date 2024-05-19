Public Class GameSettingsForm
    Dim playerName As String
    Dim timerNumValue As Integer

    ''' <summary>
    '''  subroutine called upon the form's load to call the subroutine which calls the subroutine to initialise controls.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub GameSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        onLoadSettings()
    End Sub

    ''' <summary>
    ''' Subroutine calls the subroutine to initialse the form controls and sets the formID to reflect the form
    ''' </summary>
    Public Sub onLoadSettings()
        formID = "GameSettings"
        initialiseFormControls()
    End Sub

    ''' <summary>
    ''' Subroutine initialises all the controls on the form in the correct locations and sizes and with the correct images.
    ''' </summary
    Private Sub initialiseFormControls()
        'To initialise the screen size as the fullscreen display size of the user
        Me.WindowState = FormWindowState.Maximized
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        'Setting the placement and size of controls on the form
        Titlelbl.Location = New Point(Me.Width / 2 - (336 / 2), 125)
        Titlelbl.Size = New Size(336, 71)
        playerNameInputTxtbox.Size = New Size(100, 40)
        backgroundImg.ImageLocation = Application.StartupPath & "\Pictures\battleShipsBackground.png"
        backgroundImg.Size = New Size(Me.Width - 15, Me.Height - 38)
        backgroundImg.Location = New Point(0, 0)
        backgroundImg.Load(backgroundImg.ImageLocation)
        backtomainbtn.Location = New Point(Me.Width - 265, Me.Height - 195)
        playbtnGameSettings.Location = New Point(Me.Width - 365, Me.Height - 195)

        'Initialise the control parameters
        playerNameInputTxtbox.Text = ""
        playernamewarninglbl.Visible = False
        BoardSizebtn10.Checked = True
        difNorm.Checked = True
        timerValueBar.Visible = False
        timervalue.Visible = False
        timerValueBar.Value = 5
        timervalue.Text = "02:30"
        timerckbx.Checked = False
    End Sub

    ''' <summary>
    ''' Function determines if the name the user has provided is valid: if the name is between 3 and 16 characters long.
    ''' Example of use: validateName("John") = True
    ''' </summary>
    ''' <param name="name">A string representing the players name: Eg. "John"</param>
    ''' <returns>Returns whether the name is valid</returns>
    Private Function validateName(name As String) As Boolean
        Dim length As Integer
        Dim valid As Boolean
        length = name.Length

        'Name is valid between 3 and 16 characters
        If length >= 3 And length <= 16 Then
            valid = True
        Else 'show a warning label that tells them the information
            playernamewarninglbl.Visible = True
        End If
        Return valid
    End Function

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

    ''' <summary>
    ''' Subroutine which calls the EnterOverSmallButton() from the highscores form upon moving on the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub playbtnGameSettings_Enter(sender As Object, e As EventArgs) Handles playbtnGameSettings.MouseEnter
        HighScoresForm.EnterOverSmallButton("playbtnGameSettings", Me)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the ExitOverSmallButton() from the highscores form upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub playbtnGameSettings_Leave(sender As Object, e As EventArgs) Handles playbtnGameSettings.MouseLeave
        HighScoresForm.ExitOverSmallButton("playbtnGameSettings", Me)
    End Sub

    ''' <summary>
    ''' Subroutine takes the information the user has given on the game settings form and sets the global variables to reflect this.
    ''' Does not allow the player to play the game until they have a valid name.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub playbtnGameSettings_Click(sender As Object, e As EventArgs) Handles playbtnGameSettings.Click
        'When the Play button is clicked

        'Get player's name from input field
        playerName = playerNameInputTxtbox.Text

        'Get the chosen boardsize
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

        'Get the chosen difficulty
        If difBegin.Checked = True Then
            difficulty = "Beginner"
        Else
            If difNorm.Checked = True Then
                difficulty = "Normal"
            Else
                If difHard.Checked = True Then
                    difficulty = "Hard"
                Else
                    If difUnfair.Checked = True Then
                        difficulty = "Unfair"
                    Else
                        If difImpos.Checked = True Then
                            difficulty = "Impossible"
                        End If
                    End If
                End If
            End If
        End If

        'Get the chosen time option
        If timerckbx.Checked = True Then
            timeOptionAsCountUp = False
            timeLeft = timerNumValue
        Else
            timeOptionAsCountUp = True
        End If

        'Only allow the game to be played when the name is valid
        If validateName(playerName) = True Then
            initialiseFormControls()
            onLoadSettings()
            playGame()
        End If
    End Sub

    ''' <summary>
    ''' Subroutine takes the user to the Game form.
    ''' </summary>
    Private Sub playGame()
        'Clear the input field for the name (for next reload)
        playerNameInputTxtbox.Text = ""

        'Update the global variables across forms
        BattleShipsGame.updateGlobalVars(playerName, gridSize, difficulty, timeOptionAsCountUp, timeLeft)
        Me.Hide()
        BattleShipsGame.Show()
        BattleShipsGame.onFormLoad()
    End Sub

    ''' <summary>
    ''' Subroutine shows or hides the timer value bar depending on whether the timer check box is ticked.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub timerckbx_CheckedChanged(sender As Object, e As EventArgs) Handles timerckbx.CheckedChanged
        'When the check box for the timer is checked show the value bar
        If timerckbx.Checked = True Then
            timerValueBar.Visible = True
            timervalue.Visible = True
        Else
            timerValueBar.Visible = False
            timervalue.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Subroutine changes the text of the timer value label to reflect the time chosen on the timer value bar.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub timervaluebar_ValueChanged(sender As Object, e As EventArgs) Handles timerValueBar.Scroll
        'Increments of 30s
        timerNumValue = timerValueBar.Value * 30
        timervalue.Text = BattleShipsGame.convertStringIntegerTimeToDisplayTime(timerNumValue)
    End Sub
End Class