Imports System.Runtime
Public Class HighScoresForm
    Public currentScoreArrowActive As Boolean
    Public currentTimeArrowActive As Boolean
    ''' <summary>
    ''' Subroutine which initialises variables and calls the other subroutines to initialise the form correctly.
    ''' </summary>
    Public Sub onLoadHighScores()
        formID = "HighScores"

        currentScoreArrowActive = True
        currentTimeArrowActive = False

        'Call the subroutines to intialise the form
        initialiseFormControls()
        initialiseLastHighscore()

        'Make sure the form is displaying correctly for descending and sorting by scores.
        updateArrowButtonImages(True, True)
        updateRankings(True, True)

        'Read and print the highscore into the form
        BattleShipsGame.readHighScores()
        printHighScores()
    End Sub

    ''' <summary>
    ''' Subroutine initialises all the controls on the form in the correct locations and sizes.
    ''' </summary>
    Private Sub initialiseFormControls()
        'To initialise the screen size as the fullscreen display size of the user
        Me.WindowState = FormWindowState.Maximized
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        'Setting the placement and size of controls onto the screen
        backgroundImg.ImageLocation = Application.StartupPath & "\Pictures\battleShipsBackground.png"
        backgroundImg.Size = New Size(Me.Width - 15, Me.Height - 38)
        backgroundImg.Location = New Point(0, 0)
        backgroundImg.Load(backgroundImg.ImageLocation)
        Titlelbl.Location = New Point(Me.Width / 2 - (336 / 2), 125)
        Titlelbl.Size = New Size(336, 71)
        subtitlelbl.Location = New Point(Me.Width / 2 - (208 / 2), 200)
        subtitlelbl.Size = New Size(208, 54)
        backtomainbtn.Location = New Point(Me.Width - 265, Me.Height - 195)
    End Sub

    ''' <summary>
    ''' Subroutine initialises the player's high-score temporarily as the lowest possible (to not show on the form).
    ''' </summary>
    Public Sub initialiseLastHighscore()
        BattleShipsGame.arrHighScores(11).name = "ZZZZZZ" 'A player is not likely to use this as their name.
        BattleShipsGame.arrHighScores(11).score = -17 '-17 is when the player loses to the computer 0:17
        BattleShipsGame.arrHighScores(11).time = "59:59" 'The highest possible time
        BattleShipsGame.arrHighScores(11).difficulty = "None"
    End Sub

    ''' <summary>
    ''' This subroutine matches each label on the high-score form with the element and field of the array of elements
    ''' </summary>
    Private Sub printHighScores()
        Dim targetObject As Label
        For i = 1 To 10 'i = the ranking
            targetObject = Me.namepanel.Controls.Item("namelbl" + i.ToString())
            targetObject.Text = BattleShipsGame.arrHighScores(i).name

            targetObject = Me.scorepanel.Controls.Item("scorelbl" + i.ToString())
            targetObject.Text = BattleShipsGame.arrHighScores(i).score

            targetObject = Me.timepanel.Controls.Item("timelbl" + i.ToString())
            targetObject.Text = BattleShipsGame.arrHighScores(i).time

            targetObject = Me.difficultyPanel.Controls.Item("diflbl" + i.ToString())
            targetObject.Text = BattleShipsGame.arrHighScores(i).difficulty
        Next
    End Sub

    ''' <summary>
    ''' Subroutine for when the user clicks on the score arrow
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub scorebtn_Click(sender As Object, e As EventArgs) Handles scorebtn.Click
        'Alternate the current arrow (flip)
        currentScoreArrowActive = flipBoolean(currentScoreArrowActive)
        changeOrdering(True)
    End Sub

    ''' <summary>
    ''' Subroutine for when the user clicks on the time arrow
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub timebtn_Click(sender As Object, e As EventArgs) Handles timebtn.Click
        'Alternate the current arrow (flip)
        currentTimeArrowActive = flipBoolean(currentTimeArrowActive)
        changeOrdering(False)
    End Sub

    ''' <summary>
    ''' Subroutine changes the ordering of the scores depending on which arrow has been clicked.
    ''' Writing the high scores is done each time to ensure the rankings are preserved each time.
    ''' Example of use: changeOrdering(True)
    ''' </summary>
    ''' <param name="isTypeScore">A boolean which will either be True if sorting by score or False if sorting by time</param>
    Private Sub changeOrdering(isTypeScore As Boolean)
        Dim isOrderDescending As Boolean

        'Set the order from the arrow that has been clicked and update the rankings
        If isTypeScore = True Then
            If currentScoreArrowActive = True Then
                isOrderDescending = True
            Else
                isOrderDescending = False
            End If
            updateRankings(isOrderDescending, True)
        Else
            If currentTimeArrowActive = True Then
                isOrderDescending = True
            Else
                isOrderDescending = False
            End If
            updateRankings(isOrderDescending, False)
        End If

        'Update the visuals to reflect the current array
        updateArrowButtonImages(isTypeScore, isOrderDescending)
        BattleShipsGame.BubbleSort(isTypeScore, isOrderDescending)
        BattleShipsGame.WriteHighScores()
        'print and update the rankings to reflect the order
        printHighScores()
    End Sub

    ''' <summary>
    ''' Subroutine sets and updates the image of the arrow to the correctly coloured and oriented image
    ''' Black image for the currently sorted by item, grey is for the other (unselected)
    ''' Example of use: updateArrowButtonImages(True, True)
    ''' </summary>
    ''' <param name="isTypeScore">A boolean which will either be True if sorting by score or False if sorting by time</param>
    ''' <param name="isOrderDescending">A Boolean which will either be True for a descending order or False for an ascending order</param>
    Private Sub updateArrowButtonImages(isTypeScore As Boolean, isOrderDescending As Boolean)
        If isOrderDescending = True Then
            If isTypeScore = False Then
                'descending and sorting by time
                timebtn.ImageLocation = Application.StartupPath & "\Pictures\blackdownArrow.png"

                If currentScoreArrowActive = True Then
                    scorebtn.ImageLocation = Application.StartupPath & "\Pictures\greydownArrow.png"
                Else
                    scorebtn.ImageLocation = Application.StartupPath & "\Pictures\greyupArrow.png"
                End If
            Else
                'descending and sorting by score
                scorebtn.ImageLocation = Application.StartupPath & "\Pictures\blackdownArrow.png"

                If currentTimeArrowActive = True Then
                    timebtn.ImageLocation = Application.StartupPath & "\Pictures\greydownArrow.png"
                Else
                    timebtn.ImageLocation = Application.StartupPath & "\Pictures\greyupArrow.png"
                End If
            End If
        Else
            If isTypeScore = False Then
                'ascending and sorting by time
                timebtn.ImageLocation = Application.StartupPath & "\Pictures\blackupArrow.png"

                If currentScoreArrowActive = True Then
                    scorebtn.ImageLocation = Application.StartupPath & "\Pictures\greydownArrow.png"
                Else
                    scorebtn.ImageLocation = Application.StartupPath & "\Pictures\greyupArrow.png"
                End If
            Else
                'ascending and sorting by score
                scorebtn.ImageLocation = Application.StartupPath & "\Pictures\blackupArrow.png"

                If currentTimeArrowActive = True Then
                    timebtn.ImageLocation = Application.StartupPath & "\Pictures\greydownArrow.png"
                Else
                    timebtn.ImageLocation = Application.StartupPath & "\Pictures\greyupArrow.png"
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Subroutine updates the text of the rankings to reflect the correct order
    ''' Example of use: updateRankings(True, True)
    ''' </summary>
    ''' <param name="isTypeScore">A boolean which will either be True if sorting by score or False if sorting by time</param>
    ''' <param name="isOrderDescending">A Boolean which will either be True for a descending order or False for an ascending order</param>
    Private Sub updateRankings(isTypeScore As Boolean, isOrderDescending As Boolean)
        Dim rankingOrderStr As String
        Dim targetObject As Label

        If isOrderDescending = True Then
            If isTypeScore = False Then
                rankingOrderStr = "descending"
            Else
                rankingOrderStr = "ascending"
            End If
        Else
            If isTypeScore = False Then
                rankingOrderStr = "ascending"
            Else
                rankingOrderStr = "descending"
            End If
        End If

        'To go through all the labels and change the text to be the correct number
        For i = 10 To 1 Step -1
            targetObject = Me.rankingpanel.Controls.Item("ranklbl" + i.ToString())
            If rankingOrderStr = "ascending" Then
                targetObject.Text = i
            Else '11 - i as each ranking needs to be on the opposite side of 10 from i
                targetObject.Text = 11 - i
            End If
        Next
    End Sub

    ''' <summary>
    ''' Subroutine which preserves the highscores in descending and sorting by scores to be read the same way each time.
    ''' Takes the user to the main menu form.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        'Leaves the hs.txt in the same order every time
        BattleShipsGame.BubbleSort(True, True)
        BattleShipsGame.WriteHighScores()

        Me.Hide()
        MainMenuForm.Show()
    End Sub

    ''' <summary>
    ''' Subroutine which calls the EnterOverSmallButton() upon moving on the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Enter(sender As Object, e As EventArgs) Handles backtomainbtn.MouseEnter
        EnterOverSmallButton("backtomainbtn", Me)
    End Sub

    ''' <summary>
    ''' Subroutine which calls the ExitOverSmallButton() upon moving off the button
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub backtomainbtn_Leave(sender As Object, e As EventArgs) Handles backtomainbtn.MouseLeave
        ExitOverSmallButton("backtomainbtn", Me)
    End Sub

    ''' <summary>
    ''' Subroutine which switches the button's image out for the purple image (for hover)
    ''' Example of use: EnterOverSmallButton("exitbtn", Me)
    ''' </summary>
    ''' <param name="buttonName">The name of the button that has called this subroutine </param>
    ''' <param name="formID">The Identity of the form which has called this subroutine</param>
    Public Sub EnterOverSmallButton(buttonName As String, formID As Form)
        Dim targetObject As Button
        targetObject = formID.Controls.Item(buttonName) 'Gets the control on the form with the name
        targetObject.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\smallButtonPurple.png")
    End Sub

    ''' <summary>
    ''' Subroutine which switches the button's image out for the blue image (back to normal)
    ''' Example of use: ExitOverSmallButton("exitbtn", Me)
    ''' </summary>
    ''' <param name="buttonName">The name of the button that has called this subroutine </param>
    ''' <param name="formID">The Identity of the form which has called this subroutine</param>
    Public Sub ExitOverSmallButton(buttonName As String, formID As Form)
        Dim targetObject As Button
        targetObject = formID.Controls.Item(buttonName) 'Gets the control on the form with the name
        targetObject.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\smallButtonBlue.png")
    End Sub

    ''' <summary>
    ''' Function flips a boolean value
    ''' Example of use: flipBoolean(True) = False
    ''' </summary>
    ''' <param name="bool">An arbitary Boolean</param>
    ''' <returns>A boolean of the opposite value than the value passed in</returns>
    Private Function flipBoolean(bool As Boolean) As Boolean
        If bool = True Then
            bool = False
        Else
            bool = True
        End If
        Return bool
    End Function
End Class