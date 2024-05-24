<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gameOverfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        backgroundpb = New PictureBox()
        gameOverlbl = New Label()
        youWinlbl = New Label()
        computerWinslbl = New Label()
        scorelbl = New Label()
        scoreTextlbl = New Label()
        timeTextlbl = New Label()
        timelbl = New Label()
        backToMainbtn = New Button()
        drawlbl = New Label()
        toHsbtn = New Button()
        accuracyTextlbl = New Label()
        accuracylbl = New Label()
        shotsTextlbl = New Label()
        shotslbl = New Label()
        shipsSunkTextlbl = New Label()
        shipsSunklbl = New Label()
        difTextlbl = New Label()
        diflbl = New Label()
        boardSizeTextlbl = New Label()
        boardSizelbl = New Label()
        CType(backgroundpb, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backgroundpb
        ' 
        backgroundpb.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\42okntgt.zbq\\Pictures\WaterBoard.png"
        backgroundpb.Location = New Point(12, 12)
        backgroundpb.Name = "backgroundpb"
        backgroundpb.Size = New Size(300, 300)
        backgroundpb.SizeMode = PictureBoxSizeMode.StretchImage
        backgroundpb.TabIndex = 8
        backgroundpb.TabStop = False
        ' 
        ' gameOverlbl
        ' 
        gameOverlbl.AutoSize = True
        gameOverlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        gameOverlbl.Font = New Font("Candara Light", 39.75F, FontStyle.Bold, GraphicsUnit.Point)
        gameOverlbl.Location = New Point(594, 152)
        gameOverlbl.Name = "gameOverlbl"
        gameOverlbl.Size = New Size(318, 64)
        gameOverlbl.TabIndex = 9
        gameOverlbl.Text = "GAME OVER!"
        ' 
        ' youWinlbl
        ' 
        youWinlbl.AutoSize = True
        youWinlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        youWinlbl.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        youWinlbl.Location = New Point(719, 350)
        youWinlbl.Name = "youWinlbl"
        youWinlbl.Size = New Size(90, 28)
        youWinlbl.TabIndex = 10
        youWinlbl.Text = "You Win!"
        ' 
        ' computerWinslbl
        ' 
        computerWinslbl.AutoSize = True
        computerWinslbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        computerWinslbl.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        computerWinslbl.Location = New Point(687, 350)
        computerWinslbl.Name = "computerWinslbl"
        computerWinslbl.Size = New Size(154, 28)
        computerWinslbl.TabIndex = 11
        computerWinslbl.Text = "Computer Wins!"
        ' 
        ' scorelbl
        ' 
        scorelbl.AutoSize = True
        scorelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        scorelbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        scorelbl.Location = New Point(719, 520)
        scorelbl.Name = "scorelbl"
        scorelbl.Size = New Size(60, 25)
        scorelbl.TabIndex = 12
        scorelbl.Text = "Score:"
        ' 
        ' scoreTextlbl
        ' 
        scoreTextlbl.AutoSize = True
        scoreTextlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        scoreTextlbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        scoreTextlbl.Location = New Point(785, 520)
        scoreTextlbl.Name = "scoreTextlbl"
        scoreTextlbl.Size = New Size(22, 25)
        scoreTextlbl.TabIndex = 13
        scoreTextlbl.Text = "0"
        ' 
        ' timeTextlbl
        ' 
        timeTextlbl.AutoSize = True
        timeTextlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timeTextlbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        timeTextlbl.Location = New Point(650, 570)
        timeTextlbl.Name = "timeTextlbl"
        timeTextlbl.Size = New Size(56, 25)
        timeTextlbl.TabIndex = 15
        timeTextlbl.Text = "00:00"
        ' 
        ' timelbl
        ' 
        timelbl.AutoSize = True
        timelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timelbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        timelbl.Location = New Point(594, 570)
        timelbl.Name = "timelbl"
        timelbl.Size = New Size(54, 25)
        timelbl.TabIndex = 14
        timelbl.Text = "Time:"
        ' 
        ' backToMainbtn
        ' 
        backToMainbtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        backToMainbtn.BackgroundImage = My.Resources.Resources.smallButtonBlue
        backToMainbtn.BackgroundImageLayout = ImageLayout.Stretch
        backToMainbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        backToMainbtn.FlatAppearance.BorderSize = 0
        backToMainbtn.FlatStyle = FlatStyle.Flat
        backToMainbtn.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        backToMainbtn.ForeColor = SystemColors.ButtonHighlight
        backToMainbtn.Location = New Point(716, 447)
        backToMainbtn.Margin = New Padding(0)
        backToMainbtn.Name = "backToMainbtn"
        backToMainbtn.Size = New Size(80, 26)
        backToMainbtn.TabIndex = 17
        backToMainbtn.Text = "EXIT"
        backToMainbtn.UseVisualStyleBackColor = False
        ' 
        ' drawlbl
        ' 
        drawlbl.AutoSize = True
        drawlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        drawlbl.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        drawlbl.Location = New Point(680, 350)
        drawlbl.Name = "drawlbl"
        drawlbl.Size = New Size(167, 28)
        drawlbl.TabIndex = 18
        drawlbl.Text = "Draw: No Winner!"
        ' 
        ' toHsbtn
        ' 
        toHsbtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        toHsbtn.BackgroundImage = My.Resources.Resources.smallButtonBlue
        toHsbtn.BackgroundImageLayout = ImageLayout.Stretch
        toHsbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        toHsbtn.FlatAppearance.BorderSize = 0
        toHsbtn.FlatStyle = FlatStyle.Flat
        toHsbtn.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        toHsbtn.ForeColor = SystemColors.ButtonHighlight
        toHsbtn.Location = New Point(569, 447)
        toHsbtn.Margin = New Padding(0)
        toHsbtn.Name = "toHsbtn"
        toHsbtn.Size = New Size(133, 26)
        toHsbtn.TabIndex = 19
        toHsbtn.Text = "HIGH SCORES"
        toHsbtn.UseVisualStyleBackColor = False
        ' 
        ' accuracyTextlbl
        ' 
        accuracyTextlbl.AutoSize = True
        accuracyTextlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        accuracyTextlbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        accuracyTextlbl.Location = New Point(900, 670)
        accuracyTextlbl.Name = "accuracyTextlbl"
        accuracyTextlbl.Size = New Size(19, 25)
        accuracyTextlbl.TabIndex = 21
        accuracyTextlbl.Text = "-"
        ' 
        ' accuracylbl
        ' 
        accuracylbl.AutoSize = True
        accuracylbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        accuracylbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        accuracylbl.Location = New Point(808, 670)
        accuracylbl.Name = "accuracylbl"
        accuracylbl.Size = New Size(86, 25)
        accuracylbl.TabIndex = 20
        accuracylbl.Text = "Accuracy:"
        ' 
        ' shotsTextlbl
        ' 
        shotsTextlbl.AutoSize = True
        shotsTextlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shotsTextlbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        shotsTextlbl.Location = New Point(900, 620)
        shotsTextlbl.Name = "shotsTextlbl"
        shotsTextlbl.Size = New Size(22, 25)
        shotsTextlbl.TabIndex = 23
        shotsTextlbl.Text = "0"
        ' 
        ' shotslbl
        ' 
        shotslbl.AutoSize = True
        shotslbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shotslbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        shotslbl.Location = New Point(785, 620)
        shotslbl.Name = "shotslbl"
        shotslbl.Size = New Size(109, 25)
        shotslbl.TabIndex = 22
        shotslbl.Text = "Shots taken:"
        ' 
        ' shipsSunkTextlbl
        ' 
        shipsSunkTextlbl.AutoSize = True
        shipsSunkTextlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shipsSunkTextlbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        shipsSunkTextlbl.Location = New Point(650, 670)
        shipsSunkTextlbl.Name = "shipsSunkTextlbl"
        shipsSunkTextlbl.Size = New Size(22, 25)
        shipsSunkTextlbl.TabIndex = 25
        shipsSunkTextlbl.Text = "0"
        ' 
        ' shipsSunklbl
        ' 
        shipsSunklbl.AutoSize = True
        shipsSunklbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shipsSunklbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        shipsSunklbl.Location = New Point(545, 670)
        shipsSunklbl.Name = "shipsSunklbl"
        shipsSunklbl.Size = New Size(103, 25)
        shipsSunklbl.TabIndex = 24
        shipsSunklbl.Text = "Ships Sunk:"
        ' 
        ' difTextlbl
        ' 
        difTextlbl.AutoSize = True
        difTextlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        difTextlbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        difTextlbl.Location = New Point(900, 570)
        difTextlbl.Name = "difTextlbl"
        difTextlbl.Size = New Size(19, 25)
        difTextlbl.TabIndex = 27
        difTextlbl.Text = "-"
        ' 
        ' diflbl
        ' 
        diflbl.AutoSize = True
        diflbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        diflbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        diflbl.Location = New Point(808, 570)
        diflbl.Name = "diflbl"
        diflbl.Size = New Size(86, 25)
        diflbl.TabIndex = 26
        diflbl.Text = "Difficulty:"
        ' 
        ' boardSizeTextlbl
        ' 
        boardSizeTextlbl.AutoSize = True
        boardSizeTextlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        boardSizeTextlbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        boardSizeTextlbl.Location = New Point(650, 620)
        boardSizeTextlbl.Name = "boardSizeTextlbl"
        boardSizeTextlbl.Size = New Size(19, 25)
        boardSizeTextlbl.TabIndex = 29
        boardSizeTextlbl.Text = "-"
        ' 
        ' boardSizelbl
        ' 
        boardSizelbl.AutoSize = True
        boardSizelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        boardSizelbl.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        boardSizelbl.Location = New Point(549, 620)
        boardSizelbl.Name = "boardSizelbl"
        boardSizelbl.Size = New Size(99, 25)
        boardSizelbl.TabIndex = 28
        boardSizelbl.Text = "Board Size:"
        ' 
        ' s
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 921)
        Controls.Add(boardSizeTextlbl)
        Controls.Add(boardSizelbl)
        Controls.Add(difTextlbl)
        Controls.Add(diflbl)
        Controls.Add(shipsSunkTextlbl)
        Controls.Add(shipsSunklbl)
        Controls.Add(shotsTextlbl)
        Controls.Add(shotslbl)
        Controls.Add(accuracyTextlbl)
        Controls.Add(accuracylbl)
        Controls.Add(toHsbtn)
        Controls.Add(drawlbl)
        Controls.Add(backToMainbtn)
        Controls.Add(timeTextlbl)
        Controls.Add(timelbl)
        Controls.Add(scoreTextlbl)
        Controls.Add(scorelbl)
        Controls.Add(computerWinslbl)
        Controls.Add(youWinlbl)
        Controls.Add(gameOverlbl)
        Controls.Add(backgroundpb)
        Name = "s"
        Text = "Game Over"
        CType(backgroundpb, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents backgroundpb As PictureBox
    Friend WithEvents gameOverlbl As Label
    Friend WithEvents youWinlbl As Label
    Friend WithEvents computerWinslbl As Label
    Friend WithEvents scorelbl As Label
    Friend WithEvents scoreTextlbl As Label
    Friend WithEvents timeTextlbl As Label
    Friend WithEvents timelbl As Label
    Friend WithEvents backToMainbtn As Button
    Friend WithEvents drawlbl As Label
    Friend WithEvents toHsbtn As Button
    Friend WithEvents accuracyTextlbl As Label
    Friend WithEvents accuracylbl As Label
    Friend WithEvents shotsTextlbl As Label
    Friend WithEvents shotslbl As Label
    Friend WithEvents shipsSunkTextlbl As Label
    Friend WithEvents shipsSunklbl As Label
    Friend WithEvents difTextlbl As Label
    Friend WithEvents diflbl As Label
    Friend WithEvents boardSizeTextlbl As Label
    Friend WithEvents boardSizelbl As Label
End Class
