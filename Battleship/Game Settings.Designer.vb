<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameSettingsfrm
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
        playtbn = New Button()
        backToMainbtn = New Button()
        playerNamelbl = New Label()
        titlelbl = New Label()
        playerNameInputtxt = New TextBox()
        playerNameWarninglbl = New Label()
        difficultylbl = New Label()
        unfairopt = New RadioButton()
        hardopt = New RadioButton()
        normopt = New RadioButton()
        beginopt = New RadioButton()
        boardSizebtn8 = New RadioButton()
        boardSizebtn10 = New RadioButton()
        boardSizebtn12 = New RadioButton()
        boardSizebtn14 = New RadioButton()
        boardSizelbl = New Label()
        boardSizepnl = New Panel()
        difficultypnl = New Panel()
        imposopt = New RadioButton()
        timerckbx = New CheckBox()
        timerValueBar = New TrackBar()
        timerValueTextlbl = New Label()
        CType(backgroundpb, ComponentModel.ISupportInitialize).BeginInit()
        boardSizepnl.SuspendLayout()
        difficultypnl.SuspendLayout()
        CType(timerValueBar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backgroundpb
        ' 
        backgroundpb.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\42okntgt.zbq\\Pictures\WaterBoard.png"
        backgroundpb.Location = New Point(12, 12)
        backgroundpb.Name = "backgroundpb"
        backgroundpb.Size = New Size(300, 300)
        backgroundpb.SizeMode = PictureBoxSizeMode.StretchImage
        backgroundpb.TabIndex = 0
        backgroundpb.TabStop = False
        ' 
        ' playtbn
        ' 
        playtbn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playtbn.BackgroundImage = My.Resources.Resources.smallButtonBlue
        playtbn.BackgroundImageLayout = ImageLayout.Stretch
        playtbn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        playtbn.FlatAppearance.BorderSize = 0
        playtbn.FlatStyle = FlatStyle.Flat
        playtbn.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        playtbn.ForeColor = SystemColors.ButtonHighlight
        playtbn.Location = New Point(300, 300)
        playtbn.Margin = New Padding(0)
        playtbn.Name = "playtbn"
        playtbn.Size = New Size(80, 26)
        playtbn.TabIndex = 5
        playtbn.Text = "PLAY"
        playtbn.UseVisualStyleBackColor = False
        ' 
        ' backToMainbtn
        ' 
        backToMainbtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        backToMainbtn.BackgroundImage = My.Resources.Resources.smallButtonBlue
        backToMainbtn.BackgroundImageLayout = ImageLayout.Stretch
        backToMainbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        backToMainbtn.FlatAppearance.BorderSize = 0
        backToMainbtn.FlatStyle = FlatStyle.Flat
        backToMainbtn.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        backToMainbtn.ForeColor = SystemColors.ButtonHighlight
        backToMainbtn.Location = New Point(300, 344)
        backToMainbtn.Margin = New Padding(0)
        backToMainbtn.Name = "backToMainbtn"
        backToMainbtn.Size = New Size(80, 26)
        backToMainbtn.TabIndex = 6
        backToMainbtn.Text = "EXIT"
        backToMainbtn.UseVisualStyleBackColor = False
        ' 
        ' playerNamelbl
        ' 
        playerNamelbl.AutoSize = True
        playerNamelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerNamelbl.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        playerNamelbl.Location = New Point(342, 260)
        playerNamelbl.Name = "playerNamelbl"
        playerNamelbl.Size = New Size(138, 28)
        playerNamelbl.TabIndex = 7
        playerNamelbl.Text = "Player Name:"
        ' 
        ' titlelbl
        ' 
        titlelbl.AutoSize = True
        titlelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        titlelbl.Font = New Font("Candara Light", 39.75F, FontStyle.Bold, GraphicsUnit.Point)
        titlelbl.Location = New Point(592, 44)
        titlelbl.Name = "titlelbl"
        titlelbl.Size = New Size(247, 64)
        titlelbl.TabIndex = 8
        titlelbl.Text = "SETTINGS"
        ' 
        ' playerNameInputtxt
        ' 
        playerNameInputtxt.Location = New Point(486, 265)
        playerNameInputtxt.Name = "playerNameInputtxt"
        playerNameInputtxt.PlaceholderText = "Enter your name"
        playerNameInputtxt.Size = New Size(195, 23)
        playerNameInputtxt.TabIndex = 9
        ' 
        ' playerNameWarninglbl
        ' 
        playerNameWarninglbl.AutoSize = True
        playerNameWarninglbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerNameWarninglbl.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        playerNameWarninglbl.ForeColor = Color.Red
        playerNameWarninglbl.Location = New Point(486, 291)
        playerNameWarninglbl.Name = "playerNameWarninglbl"
        playerNameWarninglbl.Size = New Size(195, 19)
        playerNameWarninglbl.TabIndex = 10
        playerNameWarninglbl.Text = "Must be 3-16 characters Long"
        ' 
        ' difficultylbl
        ' 
        difficultylbl.AutoSize = True
        difficultylbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        difficultylbl.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        difficultylbl.Location = New Point(57, 19)
        difficultylbl.Name = "difficultylbl"
        difficultylbl.Size = New Size(113, 28)
        difficultylbl.TabIndex = 20
        difficultylbl.Text = "Difficulty: "
        ' 
        ' unfairopt
        ' 
        unfairopt.AutoSize = True
        unfairopt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        unfairopt.FlatStyle = FlatStyle.Flat
        unfairopt.Location = New Point(181, 103)
        unfairopt.Name = "unfairopt"
        unfairopt.Size = New Size(56, 19)
        unfairopt.TabIndex = 19
        unfairopt.Text = "Unfair"
        unfairopt.UseVisualStyleBackColor = False
        ' 
        ' hardopt
        ' 
        hardopt.AutoSize = True
        hardopt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        hardopt.FlatStyle = FlatStyle.Flat
        hardopt.Location = New Point(181, 78)
        hardopt.Name = "hardopt"
        hardopt.Size = New Size(50, 19)
        hardopt.TabIndex = 18
        hardopt.Text = "Hard"
        hardopt.UseVisualStyleBackColor = False
        ' 
        ' normopt
        ' 
        normopt.AutoSize = True
        normopt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        normopt.Checked = True
        normopt.FlatStyle = FlatStyle.Flat
        normopt.Location = New Point(181, 53)
        normopt.Name = "normopt"
        normopt.Size = New Size(64, 19)
        normopt.TabIndex = 17
        normopt.TabStop = True
        normopt.Text = "Normal"
        normopt.UseVisualStyleBackColor = False
        ' 
        ' beginopt
        ' 
        beginopt.AutoSize = True
        beginopt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        beginopt.FlatStyle = FlatStyle.Flat
        beginopt.Location = New Point(181, 28)
        beginopt.Name = "beginopt"
        beginopt.Size = New Size(71, 19)
        beginopt.TabIndex = 16
        beginopt.Text = "Beginner"
        beginopt.UseVisualStyleBackColor = False
        ' 
        ' boardSizebtn8
        ' 
        boardSizebtn8.AutoSize = True
        boardSizebtn8.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        boardSizebtn8.FlatStyle = FlatStyle.Flat
        boardSizebtn8.Location = New Point(165, 27)
        boardSizebtn8.Name = "boardSizebtn8"
        boardSizebtn8.Size = New Size(42, 19)
        boardSizebtn8.TabIndex = 11
        boardSizebtn8.Text = "8x8"
        boardSizebtn8.UseVisualStyleBackColor = False
        ' 
        ' boardSizebtn10
        ' 
        boardSizebtn10.AutoSize = True
        boardSizebtn10.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        boardSizebtn10.Checked = True
        boardSizebtn10.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        boardSizebtn10.FlatAppearance.BorderSize = 3
        boardSizebtn10.FlatAppearance.CheckedBackColor = Color.Red
        boardSizebtn10.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        boardSizebtn10.FlatAppearance.MouseOverBackColor = Color.Black
        boardSizebtn10.FlatStyle = FlatStyle.Flat
        boardSizebtn10.Location = New Point(165, 52)
        boardSizebtn10.Name = "boardSizebtn10"
        boardSizebtn10.Size = New Size(54, 19)
        boardSizebtn10.TabIndex = 12
        boardSizebtn10.TabStop = True
        boardSizebtn10.Text = "10x10"
        boardSizebtn10.UseVisualStyleBackColor = False
        ' 
        ' boardSizebtn12
        ' 
        boardSizebtn12.AutoSize = True
        boardSizebtn12.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        boardSizebtn12.FlatStyle = FlatStyle.Flat
        boardSizebtn12.Location = New Point(165, 77)
        boardSizebtn12.Name = "boardSizebtn12"
        boardSizebtn12.Size = New Size(54, 19)
        boardSizebtn12.TabIndex = 13
        boardSizebtn12.Text = "12x12"
        boardSizebtn12.UseVisualStyleBackColor = False
        ' 
        ' boardSizebtn14
        ' 
        boardSizebtn14.AutoSize = True
        boardSizebtn14.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        boardSizebtn14.FlatStyle = FlatStyle.Flat
        boardSizebtn14.Location = New Point(165, 102)
        boardSizebtn14.Name = "boardSizebtn14"
        boardSizebtn14.Size = New Size(54, 19)
        boardSizebtn14.TabIndex = 14
        boardSizebtn14.Text = "14x14"
        boardSizebtn14.UseVisualStyleBackColor = False
        ' 
        ' boardSizelbl
        ' 
        boardSizelbl.AutoSize = True
        boardSizelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        boardSizelbl.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        boardSizelbl.Location = New Point(31, 18)
        boardSizelbl.Name = "boardSizelbl"
        boardSizelbl.Size = New Size(123, 28)
        boardSizelbl.TabIndex = 15
        boardSizelbl.Text = "Board Size: "
        ' 
        ' boardSizepnl
        ' 
        boardSizepnl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        boardSizepnl.Controls.Add(boardSizelbl)
        boardSizepnl.Controls.Add(boardSizebtn14)
        boardSizepnl.Controls.Add(boardSizebtn12)
        boardSizepnl.Controls.Add(boardSizebtn10)
        boardSizepnl.Controls.Add(boardSizebtn8)
        boardSizepnl.Location = New Point(936, 238)
        boardSizepnl.Name = "boardSizepnl"
        boardSizepnl.Size = New Size(265, 151)
        boardSizepnl.TabIndex = 23
        ' 
        ' difficultypnl
        ' 
        difficultypnl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        difficultypnl.Controls.Add(imposopt)
        difficultypnl.Controls.Add(difficultylbl)
        difficultypnl.Controls.Add(unfairopt)
        difficultypnl.Controls.Add(hardopt)
        difficultypnl.Controls.Add(normopt)
        difficultypnl.Controls.Add(beginopt)
        difficultypnl.Location = New Point(920, 542)
        difficultypnl.Name = "difficultypnl"
        difficultypnl.Size = New Size(321, 164)
        difficultypnl.TabIndex = 25
        ' 
        ' imposopt
        ' 
        imposopt.AutoSize = True
        imposopt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        imposopt.FlatStyle = FlatStyle.Flat
        imposopt.Location = New Point(181, 128)
        imposopt.Name = "imposopt"
        imposopt.Size = New Size(81, 19)
        imposopt.TabIndex = 21
        imposopt.Text = "Impossible"
        imposopt.UseVisualStyleBackColor = False
        ' 
        ' timerckbx
        ' 
        timerckbx.AutoSize = True
        timerckbx.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timerckbx.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        timerckbx.Location = New Point(388, 542)
        timerckbx.Name = "timerckbx"
        timerckbx.Size = New Size(92, 32)
        timerckbx.TabIndex = 26
        timerckbx.Text = "Timer:"
        timerckbx.UseVisualStyleBackColor = False
        ' 
        ' timerValueBar
        ' 
        timerValueBar.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timerValueBar.LargeChange = 4
        timerValueBar.Location = New Point(486, 542)
        timerValueBar.Name = "timerValueBar"
        timerValueBar.Size = New Size(205, 45)
        timerValueBar.TabIndex = 27
        timerValueBar.Value = 5
        timerValueBar.Visible = False
        ' 
        ' timerValueTextlbl
        ' 
        timerValueTextlbl.AutoSize = True
        timerValueTextlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timerValueTextlbl.FlatStyle = FlatStyle.Flat
        timerValueTextlbl.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        timerValueTextlbl.ForeColor = Color.Black
        timerValueTextlbl.Location = New Point(561, 595)
        timerValueTextlbl.Name = "timerValueTextlbl"
        timerValueTextlbl.Size = New Size(56, 25)
        timerValueTextlbl.TabIndex = 28
        timerValueTextlbl.Text = "03:00"
        timerValueTextlbl.Visible = False
        ' 
        ' gameSettingsfrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 876)
        Controls.Add(timerValueTextlbl)
        Controls.Add(timerValueBar)
        Controls.Add(timerckbx)
        Controls.Add(difficultypnl)
        Controls.Add(boardSizepnl)
        Controls.Add(playerNameWarninglbl)
        Controls.Add(playerNameInputtxt)
        Controls.Add(titlelbl)
        Controls.Add(playerNamelbl)
        Controls.Add(backToMainbtn)
        Controls.Add(playtbn)
        Controls.Add(backgroundpb)
        Name = "gameSettingsfrm"
        Text = "Game Settings"
        CType(backgroundpb, ComponentModel.ISupportInitialize).EndInit()
        boardSizepnl.ResumeLayout(False)
        boardSizepnl.PerformLayout()
        difficultypnl.ResumeLayout(False)
        difficultypnl.PerformLayout()
        CType(timerValueBar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents backgroundpb As PictureBox
    Friend WithEvents playtbn As Button
    Friend WithEvents backToMainbtn As Button
    Friend WithEvents playerNamelbl As Label
    Friend WithEvents titlelbl As Label
    Friend WithEvents playerNameInputtxt As TextBox
    Friend WithEvents playerNameWarninglbl As Label
    Friend WithEvents difficultylbl As Label
    Friend WithEvents unfairopt As RadioButton
    Friend WithEvents hardopt As RadioButton
    Friend WithEvents normopt As RadioButton
    Friend WithEvents beginopt As RadioButton
    Friend WithEvents boardSizebtn8 As RadioButton
    Friend WithEvents boardSizebtn10 As RadioButton
    Friend WithEvents boardSizebtn12 As RadioButton
    Friend WithEvents boardSizebtn14 As RadioButton
    Friend WithEvents boardSizelbl As Label
    Friend WithEvents boardSizepnl As Panel
    Friend WithEvents difficultypnl As Panel
    Friend WithEvents timerckbx As CheckBox
    Friend WithEvents timerValueBar As TrackBar
    Friend WithEvents imposopt As RadioButton
    Friend WithEvents timerValueTextlbl As Label
End Class
