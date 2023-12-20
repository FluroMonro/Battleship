Public Class HighScoresForm
    Private Sub HighScoresForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialiseControlsPlacement()
        showScore()
    End Sub
    Private Sub initialiseControlsPlacement()
        'To place the controls in the same position relative to the custom display size of the user

        'To initialise the screen size as the fullscreen display size of the user
        'Me.WindowState = FormWindowState.Maximized
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
End Class