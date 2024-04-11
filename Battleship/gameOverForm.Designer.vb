<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameOverForm
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
        backgroundImg = New PictureBox()
        gameOverlbl = New Label()
        youwinlbl = New Label()
        computerwinslbl = New Label()
        scorelbl = New Label()
        scoretxt = New Label()
        timetxt = New Label()
        timelbl = New Label()
        Label8 = New Label()
        backtomainbtn = New Button()
        CType(backgroundImg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backgroundImg
        ' 
        backgroundImg.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\42okntgt.zbq\\Pictures\WaterBoard.png"
        backgroundImg.Location = New Point(12, 12)
        backgroundImg.Name = "backgroundImg"
        backgroundImg.Size = New Size(300, 300)
        backgroundImg.SizeMode = PictureBoxSizeMode.StretchImage
        backgroundImg.TabIndex = 8
        backgroundImg.TabStop = False
        ' 
        ' gameOverlbl
        ' 
        gameOverlbl.AutoSize = True
        gameOverlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        gameOverlbl.Font = New Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point)
        gameOverlbl.Location = New Point(594, 152)
        gameOverlbl.Name = "gameOverlbl"
        gameOverlbl.Size = New Size(340, 72)
        gameOverlbl.TabIndex = 9
        gameOverlbl.Text = "GAME OVER!"
        ' 
        ' youwinlbl
        ' 
        youwinlbl.AutoSize = True
        youwinlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        youwinlbl.Location = New Point(745, 416)
        youwinlbl.Name = "youwinlbl"
        youwinlbl.Size = New Size(54, 15)
        youwinlbl.TabIndex = 10
        youwinlbl.Text = "You Win!"
        ' 
        ' computerwinslbl
        ' 
        computerwinslbl.AutoSize = True
        computerwinslbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        computerwinslbl.Location = New Point(716, 385)
        computerwinslbl.Name = "computerwinslbl"
        computerwinslbl.Size = New Size(93, 15)
        computerwinslbl.TabIndex = 11
        computerwinslbl.Text = "Computer Wins!"
        ' 
        ' scorelbl
        ' 
        scorelbl.AutoSize = True
        scorelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        scorelbl.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        scorelbl.Location = New Point(594, 606)
        scorelbl.Name = "scorelbl"
        scorelbl.Size = New Size(100, 25)
        scorelbl.TabIndex = 12
        scorelbl.Text = "Your Score:"
        ' 
        ' scoretxt
        ' 
        scoretxt.AutoSize = True
        scoretxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        scoretxt.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        scoretxt.Location = New Point(700, 606)
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
        timetxt.Location = New Point(878, 606)
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
        timelbl.Location = New Point(782, 606)
        timelbl.Name = "timelbl"
        timelbl.Size = New Size(90, 25)
        timelbl.TabIndex = 14
        timelbl.Text = "Your Time"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(279, 344)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 15)
        Label8.TabIndex = 16
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
        ' gameOverForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 921)
        Controls.Add(backtomainbtn)
        Controls.Add(Label8)
        Controls.Add(timetxt)
        Controls.Add(timelbl)
        Controls.Add(scoretxt)
        Controls.Add(scorelbl)
        Controls.Add(computerwinslbl)
        Controls.Add(youwinlbl)
        Controls.Add(gameOverlbl)
        Controls.Add(backgroundImg)
        Name = "gameOverForm"
        Text = "gameOverForm"
        CType(backgroundImg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents backgroundImg As PictureBox
    Friend WithEvents gameOverlbl As Label
    Friend WithEvents youwinlbl As Label
    Friend WithEvents computerwinslbl As Label
    Friend WithEvents scorelbl As Label
    Friend WithEvents scoretxt As Label
    Friend WithEvents timetxt As Label
    Friend WithEvents timelbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents backtomainbtn As Button
End Class
