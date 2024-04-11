Public Class gameOverForm
    Private Sub gameOverForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialiseControlsPlacement()
        onLoadSettings()
    End Sub
    Private Sub onLoadsettings()
        formID = "gameOverForm"
        Dim playerscore As Integer
        Dim playerTime As String


        playerscore = endScore
        playerTime = endTime
        scoretxt.Text = endScore
        timetxt.Text = endTime
    End Sub
    Public Sub initialiseControlsPlacement()
        Me.WindowState = FormWindowState.Maximized
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        'Setting the placement and size of controls on the form

        backgroundImg.ImageLocation = Application.StartupPath & "\Pictures\battleShipsBackground.png"
        backgroundImg.Size = New Size(Me.Width - 15, Me.Height - 38)
        backgroundImg.Location = New Point(0, 0)
        backtomainbtn.Location = New Point(Me.Width - 265, Me.Height - 195)

        If isWin = True Then
            youwinlbl.Visible = True
            computerwinslbl.Visible = False
        Else
            computerwinslbl.Visible = True
            youwinlbl.Visible = False
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