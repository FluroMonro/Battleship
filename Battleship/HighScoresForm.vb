Public Class HighScoresForm

    Public currentScoreArrow
    Public currentTimeArrow
    Public Sub onLoadHighScores()
        currentScoreArrow = 1
        currentTimeArrow = 2

        updateArrowButtonImages(False, True, "descending")

        initialiseControlsPlacement()
        showscore()
    End Sub

    Private Sub initialiseControlsPlacement()
        'To place the controls in the same position relative to the custom display size of the user

        'To initialise the screen size as the fullscreen display size of the user
        Me.WindowState = FormWindowState.Maximized
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        'Setting the placement and size relative to the screen


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
        BattleShipsGame.readHighScores()
        printHighScores()
    End Sub



    Private Sub printHighScores()
        Dim targetObj As New Label
        For i = 1 To 10
            targetObj = Me.Controls.Item("p" + i.ToString + "namelbl")
            targetObj.Text = BattleShipsGame.arrHighScores(i).name

            targetObj = Me.Controls.Item("p" + i.ToString + "scorelbl")
            targetObj.Text = BattleShipsGame.arrHighScores(i).score

            targetObj = Me.Controls.Item("p" + i.ToString + "timelbl")
            targetObj.Text = BattleShipsGame.arrHighScores(i).time
        Next
    End Sub


    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        Me.Hide()
        MainMenuForm.Show()
    End Sub

    Private Sub scorebtn_Click(sender As Object, e As EventArgs) Handles scorebtn.Click
        currentScoreArrow = BattleShipsGame.AlternateNum(currentScoreArrow)
        Dim sortbytime = False
        Dim sortbyscores = True
        Dim order As String

        If currentScoreArrow = 1 Then
            order = "descending"
        Else
            order = "ascending"
        End If
        updateArrowButtonImages(sortbytime, sortbyscores, order)
        BattleShipsGame.BubbleSort(sortbyscores, sortbytime, order)
        BattleShipsGame.WriteHighScores()
        printHighScores()
        updateRankings(order, "score")
    End Sub

    Private Sub timebtn_Click(sender As Object, e As EventArgs) Handles timebtn.Click
        currentTimeArrow = BattleShipsGame.AlternateNum(currentTimeArrow)
        Dim sortbytime = True
        Dim sortbyscores = False
        Dim order As String

        If currentTimeArrow = 1 Then
            order = "descending"
        Else
            order = "ascending"
        End If
        updateArrowButtonImages(sortbytime, sortbyscores, order)
        BattleShipsGame.BubbleSort(sortbyscores, sortbytime, order)
        BattleShipsGame.WriteHighScores()
        printHighScores()
        updateRankings(order, "time")
    End Sub
    Private Sub updateArrowButtonImages(sortBytime As Boolean, sortbyscores As Boolean, order As String)
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
        Select Case order
            Case "descending"
                If type = "time" Then
                    ranklbl1.Text = 10
                    ranklbl2.Text = 9
                    ranklbl3.Text = 8
                    ranklbl4.Text = 7
                    ranklbl5.Text = 6
                    ranklbl6.Text = 5
                    ranklbl7.Text = 4
                    ranklbl8.Text = 3
                    ranklbl9.Text = 2
                    ranklbl10.Text = 1
                Else
                    ranklbl1.Text = 1
                    ranklbl2.Text = 2
                    ranklbl3.Text = 3
                    ranklbl4.Text = 4
                    ranklbl5.Text = 5
                    ranklbl6.Text = 6
                    ranklbl7.Text = 7
                    ranklbl8.Text = 8
                    ranklbl9.Text = 9
                    ranklbl10.Text = 10
                End If
            Case "ascending"
                If type = "time" Then
                    ranklbl1.Text = 1
                    ranklbl2.Text = 2
                    ranklbl3.Text = 3
                    ranklbl4.Text = 4
                    ranklbl5.Text = 5
                    ranklbl6.Text = 6
                    ranklbl7.Text = 7
                    ranklbl8.Text = 8
                    ranklbl9.Text = 9
                    ranklbl10.Text = 10
                Else
                    ranklbl1.Text = 10
                    ranklbl2.Text = 9
                    ranklbl3.Text = 8
                    ranklbl4.Text = 7
                    ranklbl5.Text = 6
                    ranklbl6.Text = 5
                    ranklbl7.Text = 4
                    ranklbl8.Text = 3
                    ranklbl9.Text = 2
                    ranklbl10.Text = 1
                End If
        End Select
    End Sub

    Private Sub scorepanel_Paint(sender As Object, e As PaintEventArgs) Handles scorepanel.Paint

    End Sub
End Class