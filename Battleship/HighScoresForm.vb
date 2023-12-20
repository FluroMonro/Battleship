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
        WaterBoarder.ImageLocation = Application.StartupPath & "\Pictures\WaterBoard.png"
        WaterBoarder.Size = New Size(Me.Width - 42, Me.Height - 64)
        backtomainbtn.Location = New Point(Me.Width - (100 + 42), Me.Height - (60 + 64))
        Titlelbl.Location = New Point(Me.Width / 2 - (336 / 2), 125)
        Titlelbl.Size = New Size(336, 71)
        subtitlelbl.Location = New Point(Me.Width / 2 - (208 / 2), 200)
        subtitlelbl.Size = New Size(208, 54)
    End Sub

    Private Sub showscore()
        BattleShipsGame.readHighScores()
        printHighScores()
    End Sub



    Private Sub printHighScores()
        p1namelbl.Text = BattleShipsGame.arrHighScores(1).name
        p2namelbl.Text = BattleShipsGame.arrHighScores(2).name
        p3namelbl.Text = BattleShipsGame.arrHighScores(3).name
        p4namelbl.Text = BattleShipsGame.arrHighScores(4).name
        p5namelbl.Text = BattleShipsGame.arrHighScores(5).name
        p6namelbl.Text = BattleShipsGame.arrHighScores(6).name
        p7namelbl.Text = BattleShipsGame.arrHighScores(7).name
        p8namelbl.Text = BattleShipsGame.arrHighScores(8).name
        p9namelbl.Text = BattleShipsGame.arrHighScores(9).name
        p10namelbl.Text = BattleShipsGame.arrHighScores(10).name

        p1scorelbl.Text = BattleShipsGame.arrHighScores(1).score
        p2scorelbl.Text = BattleShipsGame.arrHighScores(2).score
        p3scorelbl.Text = BattleShipsGame.arrHighScores(3).score
        p4scorelbl.Text = BattleShipsGame.arrHighScores(4).score
        p5scorelbl.Text = BattleShipsGame.arrHighScores(5).score
        p6scorelbl.Text = BattleShipsGame.arrHighScores(6).score
        p7scorelbl.Text = BattleShipsGame.arrHighScores(7).score
        p8scorelbl.Text = BattleShipsGame.arrHighScores(8).score
        p9scorelbl.Text = BattleShipsGame.arrHighScores(9).score
        p10scorelbl.Text = BattleShipsGame.arrHighScores(10).score

        p1timelbl.Text = BattleShipsGame.arrHighScores(1).time
        p2timelbl.Text = BattleShipsGame.arrHighScores(2).time
        p3timelbl.Text = BattleShipsGame.arrHighScores(3).time
        p4timelbl.Text = BattleShipsGame.arrHighScores(4).time
        p5timelbl.Text = BattleShipsGame.arrHighScores(5).time
        p6timelbl.Text = BattleShipsGame.arrHighScores(6).time
        p7timelbl.Text = BattleShipsGame.arrHighScores(7).time
        p8timelbl.Text = BattleShipsGame.arrHighScores(8).time
        p9timelbl.Text = BattleShipsGame.arrHighScores(9).time
        p10timelbl.Text = BattleShipsGame.arrHighScores(10).time


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
        updateRankings(order)
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
        updateRankings(order)
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
    Private Sub updateRankings(order As String)
        Select Case order
            Case "descending"
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
            Case "ascending"
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
        End Select
    End Sub
End Class