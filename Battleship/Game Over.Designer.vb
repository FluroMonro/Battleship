<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameOverfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        backgroundpb = New PictureBox()
        gameOverlbl = New Label()
        youwinlbl = New Label()
        computerwinslbl = New Label()
        scorelbl = New Label()
        scoretxt = New Label()
        timetxt = New Label()
        timelbl = New Label()
        backtomainbtn = New Button()
        drawlbl = New Label()
        tohsbtn = New Button()
        accuracytxt = New Label()
        accuracylbl = New Label()
        shotstxt = New Label()
        shotslbl = New Label()
        shipsSunktxt = New Label()
        shipsSunklbl = New Label()
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
        ' youwinlbl
        ' 
        youwinlbl.AutoSize = True
        youwinlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        youwinlbl.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        youwinlbl.Location = New Point(719, 350)
        youwinlbl.Name = "youwinlbl"
        youwinlbl.Size = New Size(90, 28)
        youwinlbl.TabIndex = 10
        youwinlbl.Text = "You Win!"
        ' 
        ' computerwinslbl
        ' 
        computerwinslbl.AutoSize = True
        computerwinslbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        computerwinslbl.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        computerwinslbl.Location = New Point(687, 350)
        computerwinslbl.Name = "computerwinslbl"
        computerwinslbl.Size = New Size(154, 28)
        computerwinslbl.TabIndex = 11
        computerwinslbl.Text = "Computer Wins!"
        ' 
        ' scorelbl
        ' 
        scorelbl.AutoSize = True
        scorelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        scorelbl.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        scorelbl.Location = New Point(687, 583)
        scorelbl.Name = "scorelbl"
        scorelbl.Size = New Size(60, 25)
        scorelbl.TabIndex = 12
        scorelbl.Text = "Score:"
        ' 
        ' scoretxt
        ' 
        scoretxt.AutoSize = True
        scoretxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        scoretxt.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        scoretxt.Location = New Point(787, 583)
        scoretxt.Name = "scoretxt"
        scoretxt.Size = New Size(22, 25)
        scoretxt.TabIndex = 13
        scoretxt.Text = "0"
        ' 
        ' timetxt
        ' 
        timetxt.AutoSize = True
        timetxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timetxt.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        timetxt.Location = New Point(785, 521)
        timetxt.Name = "timetxt"
        timetxt.Size = New Size(56, 25)
        timetxt.TabIndex = 15
        timetxt.Text = "00:00"
        ' 
        ' timelbl
        ' 
        timelbl.AutoSize = True
        timelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timelbl.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        timelbl.Location = New Point(687, 521)
        timelbl.Name = "timelbl"
        timelbl.Size = New Size(54, 25)
        timelbl.TabIndex = 14
        timelbl.Text = "Time:"
        ' 
        ' backtomainbtn
        ' 
        backtomainbtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        backtomainbtn.BackgroundImage = My.Resources.Resources.smallButtonBlue
        backtomainbtn.BackgroundImageLayout = ImageLayout.Stretch
        backtomainbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        backtomainbtn.FlatAppearance.BorderSize = 0
        backtomainbtn.FlatStyle = FlatStyle.Flat
        backtomainbtn.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        backtomainbtn.ForeColor = SystemColors.ButtonHighlight
        backtomainbtn.Location = New Point(716, 447)
        backtomainbtn.Margin = New Padding(0)
        backtomainbtn.Name = "backtomainbtn"
        backtomainbtn.Size = New Size(80, 26)
        backtomainbtn.TabIndex = 17
        backtomainbtn.Text = "EXIT"
        backtomainbtn.UseVisualStyleBackColor = False
        ' 
        ' drawlbl
        ' 
        drawlbl.AutoSize = True
        drawlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        drawlbl.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        drawlbl.Location = New Point(680, 350)
        drawlbl.Name = "drawlbl"
        drawlbl.Size = New Size(167, 28)
        drawlbl.TabIndex = 18
        drawlbl.Text = "Draw: No Winner!"
        ' 
        ' tohsbtn
        ' 
        tohsbtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        tohsbtn.BackgroundImage = My.Resources.Resources.smallButtonBlue
        tohsbtn.BackgroundImageLayout = ImageLayout.Stretch
        tohsbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        tohsbtn.FlatAppearance.BorderSize = 0
        tohsbtn.FlatStyle = FlatStyle.Flat
        tohsbtn.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        tohsbtn.ForeColor = SystemColors.ButtonHighlight
        tohsbtn.Location = New Point(569, 447)
        tohsbtn.Margin = New Padding(0)
        tohsbtn.Name = "tohsbtn"
        tohsbtn.Size = New Size(133, 26)
        tohsbtn.TabIndex = 19
        tohsbtn.Text = "HIGH SCORES"
        tohsbtn.UseVisualStyleBackColor = False
        ' 
        ' accuracytxt
        ' 
        accuracytxt.AutoSize = True
        accuracytxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        accuracytxt.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        accuracytxt.Location = New Point(975, 635)
        accuracytxt.Name = "accuracytxt"
        accuracytxt.Size = New Size(19, 25)
        accuracytxt.TabIndex = 21
        accuracytxt.Text = "-"
        ' 
        ' accuracylbl
        ' 
        accuracylbl.AutoSize = True
        accuracylbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        accuracylbl.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        accuracylbl.Location = New Point(875, 635)
        accuracylbl.Name = "accuracylbl"
        accuracylbl.Size = New Size(86, 25)
        accuracylbl.TabIndex = 20
        accuracylbl.Text = "Accuracy:"
        ' 
        ' shotstxt
        ' 
        shotstxt.AutoSize = True
        shotstxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shotstxt.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        shotstxt.Location = New Point(787, 635)
        shotstxt.Name = "shotstxt"
        shotstxt.Size = New Size(22, 25)
        shotstxt.TabIndex = 23
        shotstxt.Text = "0"
        ' 
        ' shotslbl
        ' 
        shotslbl.AutoSize = True
        shotslbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shotslbl.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        shotslbl.Location = New Point(638, 635)
        shotslbl.Name = "shotslbl"
        shotslbl.Size = New Size(109, 25)
        shotslbl.TabIndex = 22
        shotslbl.Text = "Shots taken:"
        ' 
        ' shipsSunktxt
        ' 
        shipsSunktxt.AutoSize = True
        shipsSunktxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shipsSunktxt.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        shipsSunktxt.Location = New Point(564, 635)
        shipsSunktxt.Name = "shipsSunktxt"
        shipsSunktxt.Size = New Size(22, 25)
        shipsSunktxt.TabIndex = 25
        shipsSunktxt.Text = "0"
        ' 
        ' shipsSunklbl
        ' 
        shipsSunklbl.AutoSize = True
        shipsSunklbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shipsSunklbl.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        shipsSunklbl.Location = New Point(455, 635)
        shipsSunklbl.Name = "shipsSunklbl"
        shipsSunklbl.Size = New Size(103, 25)
        shipsSunklbl.TabIndex = 24
        shipsSunklbl.Text = "Ships Sunk:"
        ' 
        ' gameOverfrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 921)
        Controls.Add(shipsSunktxt)
        Controls.Add(shipsSunklbl)
        Controls.Add(shotstxt)
        Controls.Add(shotslbl)
        Controls.Add(accuracytxt)
        Controls.Add(accuracylbl)
        Controls.Add(tohsbtn)
        Controls.Add(drawlbl)
        Controls.Add(backtomainbtn)
        Controls.Add(timetxt)
        Controls.Add(timelbl)
        Controls.Add(scoretxt)
        Controls.Add(scorelbl)
        Controls.Add(computerwinslbl)
        Controls.Add(youwinlbl)
        Controls.Add(gameOverlbl)
        Controls.Add(backgroundpb)
        Name = "gameOverfrm"
        Text = "Game Over"
        CType(backgroundpb, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents backgroundpb As PictureBox
    Friend WithEvents gameOverlbl As Label
    Friend WithEvents youwinlbl As Label
    Friend WithEvents computerwinslbl As Label
    Friend WithEvents scorelbl As Label
    Friend WithEvents scoretxt As Label
    Friend WithEvents timetxt As Label
    Friend WithEvents timelbl As Label
    Friend WithEvents backtomainbtn As Button
    Friend WithEvents drawlbl As Label
    Friend WithEvents tohsbtn As Button
    Friend WithEvents accuracytxt As Label
    Friend WithEvents accuracylbl As Label
    Friend WithEvents shotstxt As Label
    Friend WithEvents shotslbl As Label
    Friend WithEvents shipsSunktxt As Label
    Friend WithEvents shipsSunklbl As Label
End Class
