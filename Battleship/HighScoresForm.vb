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
    End Sub



    Private Sub showscore()
        readhHighScores()
        printHighScores()
    End Sub

    Private Sub readhHighScores()
        Dim i As Integer
        FileSystem.FileOpen(1, "hs.txt", OpenMode.Input)
        For i = 1 To 10
            Dim temp
            FileSystem.Input(1, temp)
            If CInt(Asc(temp)) > 57 Or CInt(Asc(temp)) < 48 Then
                BattleShipsGame.arrHighScores(i).name = temp
                FileSystem.Input(1, temp)
            End If
            If CInt(Asc(temp)) >= 48 AndAlso CInt(Asc(temp)) <= 57 Then
                BattleShipsGame.arrHighScores(i).score = temp
            End If
        Next
        FileSystem.FileClose(1)
    End Sub

    Private Sub printHighScores()
        For i = 1 To 10
            ListBox1.Items.Add(BattleShipsGame.arrHighScores(i).name & " " & BattleShipsGame.arrHighScores(i).score)
        Next i
        MsgBox(BattleShipsGame.arrHighScores(1).score)
    End Sub


    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        Me.Hide()
        MainMenuForm.Show()
    End Sub
End Class