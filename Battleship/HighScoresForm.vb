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
            Dim fileContents
            FileSystem.Input(1, fileContents)
            BattleShipsGame.arrHighScores(i).score = fileContents

            FileSystem.Input(1, fileContents)
            BattleShipsGame.arrHighScores(i).name = fileContents

            FileSystem.Input(1, fileContents)

            If fileContents < 10 Then
                'under than 10 sec
                fileContents = "00:0" & CStr(fileContents)
            Else
                'between 10s and 1min
                If fileContents < 60 Then
                    fileContents = "00:" & CStr(fileContents)
                Else
                    'between 1 and 10min
                    If fileContents < 600 Then
                        fileContents = "0 " & Math.Floor(fileContents / 60) & ":" & (((fileContents / 60) - Math.Floor(fileContents / 60)) * 60)
                    Else
                        'anything above 10min
                        fileContents = Math.Floor(fileContents / 60) & ":" & (((fileContents / 60) - Math.Floor(fileContents / 60)) * 60)
                    End If

                End If

            End If

            BattleShipsGame.arrHighScores(i).time = fileContents

        Next
        FileSystem.FileClose(1)
    End Sub

    Private Sub printHighScores()
        For i = 1 To 10
            ListBox1.Items.Add(BattleShipsGame.arrHighScores(i).name & " " & BattleShipsGame.arrHighScores(i).score & " " & BattleShipsGame.arrHighScores(i).time)
        Next i
    End Sub


    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        Me.Hide()
        MainMenuForm.Show()
    End Sub
End Class