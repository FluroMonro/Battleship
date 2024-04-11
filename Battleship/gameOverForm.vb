Public Class gameOverForm

    Private Sub gameOverForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        onLoadsettings()
    End Sub
    Public Sub onLoadsettings()
        formID = "gameOverForm"
        Dim playerscore As Integer
        Dim playerTime As String
        Dim outcomeOfGame As String
        outcomeOfGame = gameOutcome
        playerscore = endScore
        playerTime = endTime
        scoretxt.Text = endScore
        timetxt.Text = endTime
        initialiseControlsPlacement(outcomeOfGame)
    End Sub
    Public Sub initialiseControlsPlacement(outcomeOfGame As String)
        Me.WindowState = FormWindowState.Maximized
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        'Setting the placement and size of controls on the form

        backgroundImg.ImageLocation = Application.StartupPath & "\Pictures\battleShipsBackground.png"
        backgroundImg.Size = New Size(Me.Width - 15, Me.Height - 38)
        backgroundImg.Location = New Point(0, 0)
        backtomainbtn.Location = New Point(Me.Width - 265, Me.Height - 195)

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

    Private Sub backtomainbtn_Enter(sender As Object, e As EventArgs) Handles backtomainbtn.MouseEnter
        HighScoresForm.EnterOverSmallButton("backtomainbtn", Me)
    End Sub
    Private Sub backtomainbtn_Leave(sender As Object, e As EventArgs) Handles backtomainbtn.MouseLeave
        HighScoresForm.ExitOverSmallButton("backtomainbtn", Me)
    End Sub

    Private Sub backtomainbtn_Click(sender As Object, e As EventArgs) Handles backtomainbtn.Click
        'When Exit button is clicked
        Me.Hide()
        MainMenuForm.Show()
    End Sub
End Class