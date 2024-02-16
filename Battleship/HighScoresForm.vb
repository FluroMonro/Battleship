Imports System.Runtime
Public Class HighScoresForm
    Public currentScoreArrow
    Public currentTimeArrow
    Public Sub onLoadHighScores()
        formID = "HighScores"

        'Call the subroutines to intialise the form

        currentScoreArrow = 1
        currentTimeArrow = 2

        updateArrowButtonImages(True, False, "descending")
        updateRankings("ascending", "score")

        initialiseLastHighscore()
        initialiseControlsPlacement()
        showscore()
    End Sub
    Private Sub initialiseControlsPlacement()
        'To intialise the controls in the correct way

        'To initialise the screen size as the fullscreen display size of the user
        Me.WindowState = FormWindowState.Maximized
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        'Setting the placement and size of controls onto the screen
        Titlelbl.Location = New Point(Me.Width / 2 - (336 / 2), 125)
        Titlelbl.Size = New Size(336, 71)
        subtitlelbl.Location = New Point(Me.Width / 2 - (208 / 2), 200)
        subtitlelbl.Size = New Size(208, 54)
        backgroundImg.ImageLocation = Application.StartupPath & "\Pictures\battleShipsBackground.png"
        backgroundImg.Size = New Size(Me.Width - 15, Me.Height - 38)
        backgroundImg.Location = New Point(0, 0)
        backtomainbtn.Location = New Point(Me.Width - 265, Me.Height - 195)
    End Sub
    Private Sub showscore()
        'Read and print the highscore into the form
        BattleShipsGame.readHighScores()
        printHighScores()
    End Sub
    Public Sub initialiseLastHighscore()
        'Initialise the temporary high-score for the player until they finish a game
        BattleShipsGame.arrHighScores(11).name = "ZZZZZZ"
        BattleShipsGame.arrHighScores(11).score = -17
        BattleShipsGame.arrHighScores(11).time = "59:59"
        BattleShipsGame.arrHighScores(11).difficulty = "None"
    End Sub
    Private Sub printHighScores()
        'Match each label on the high-score form with the element and field of the array of elements
        Dim targetObject As Label
        For i = 1 To 10
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
    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        'Leave the hs.txt in the same order every time
        BattleShipsGame.BubbleSort(True, False, "descending")
        BattleShipsGame.WriteHighScores()

        Me.Hide()
        MainMenuForm.Show()
    End Sub
    Private Sub scorebtn_Click(sender As Object, e As EventArgs) Handles scorebtn.Click
        'When the player clicks on the score arrow

        'Alternate the current arrow (flip)
        currentScoreArrow = BattleShipsGame.AlternateNum(currentScoreArrow)
        Dim sortbyscores = True
        Dim sortbytime = False
        Dim order As String

        If currentScoreArrow = 1 Then
            order = "descending"
        Else
            order = "ascending"
        End If
        'Update the visuals to reflect the current array
        updateArrowButtonImages(sortbyscores, sortbytime, order)

        'Sort by scores and write to the file
        BattleShipsGame.BubbleSort(sortbyscores, sortbytime, order)
        BattleShipsGame.WriteHighScores()
        'print and update the rankings to reflect the order
        printHighScores()
        updateRankings(order, "score")
    End Sub
    Private Sub timebtn_Click(sender As Object, e As EventArgs) Handles timebtn.Click
        'When the player clicks on the time arrow

        'Alternate the current arrow (flip)
        currentTimeArrow = BattleShipsGame.AlternateNum(currentTimeArrow)
        Dim sortbytime = True
        Dim sortbyscores = False
        Dim order As String

        If currentTimeArrow = 1 Then
            order = "descending"
        Else
            order = "ascending"
        End If
        'Update the visuals to reflect the current array
        updateArrowButtonImages(sortbyscores, sortbytime, order)
        BattleShipsGame.BubbleSort(sortbyscores, sortbytime, order)
        BattleShipsGame.WriteHighScores()
        'print and update the rankings to reflect the order
        printHighScores()
        updateRankings(order, "time")
    End Sub
    Private Sub updateArrowButtonImages(sortbyscores As Boolean, sortBytime As Boolean, order As String)
        'To set and update the image of the arrow to the correct image
        'Black is for the currently sorted by item, grey for the other
        Select Case order
            Case "descending"
                'descending
                Select Case sortBytime
                    Case True : timebtn.ImageLocation = Application.StartupPath & "\Pictures\blackdownArrow.png"
                        Select Case currentScoreArrow
                            Case 1 : scorebtn.ImageLocation = Application.StartupPath & "\Pictures\greydownArrow.png"
                            Case 2 : scorebtn.ImageLocation = Application.StartupPath & "\Pictures\greyupArrow.png"
                        End Select

                    Case False : scorebtn.ImageLocation = Application.StartupPath & "\Pictures\blackdownArrow.png"
                        Select Case currentTimeArrow
                            Case 1 : timebtn.ImageLocation = Application.StartupPath & "\Pictures\greydownArrow.png"
                            Case 2 : timebtn.ImageLocation = Application.StartupPath & "\Pictures\greyupArrow.png"
                        End Select
                End Select
            Case "ascending"
                Select Case sortBytime
                    Case True : timebtn.ImageLocation = Application.StartupPath & "\Pictures\blackupArrow.png"
                        Select Case currentScoreArrow
                            Case 1 : scorebtn.ImageLocation = Application.StartupPath & "\Pictures\greydownArrow.png"
                            Case 2 : scorebtn.ImageLocation = Application.StartupPath & "\Pictures\greyupArrow.png"
                        End Select

                    Case False : scorebtn.ImageLocation = Application.StartupPath & "\Pictures\blackupArrow.png"
                        Select Case currentTimeArrow
                            Case 1 : timebtn.ImageLocation = Application.StartupPath & "\Pictures\greydownArrow.png"
                            Case 2 : timebtn.ImageLocation = Application.StartupPath & "\Pictures\greyupArrow.png"
                        End Select
                End Select
        End Select
    End Sub
    Private Sub updateRankings(order As String, type As String)
        'To update the text of the rankings to reflect the correct order
        Dim rankingOrderStr As String
        Dim targetObject As Label

        Select Case order
            Case "descending"
                If type = "time" Then
                    rankingOrderStr = "descending"
                Else
                    rankingOrderStr = "ascending"
                End If
            Case "ascending"
                If type = "time" Then
                    rankingOrderStr = "ascending"
                Else
                    rankingOrderStr = "descending"
                End If
        End Select

        For i = 10 To 1 Step -1
            targetObject = Me.rankingpanel.Controls.Item("ranklbl" + i.ToString())
            If rankingOrderStr = "ascending" Then
                targetObject.Text = i
            Else '11 - i as needs to be on the opposite side of 10 from i
                targetObject.Text = 11 - i
            End If
        Next
    End Sub
End Class