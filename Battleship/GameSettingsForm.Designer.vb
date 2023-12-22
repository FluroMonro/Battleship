<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameSettingsForm
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
        playbtnGameSettings = New Button()
        backtomainbtn = New Button()
        playerNamelbl = New Label()
        Titlelbl = New Label()
        playerNameInputTxtbox = New TextBox()
        playernamewarninglbl = New Label()
        shipPlacementlbl = New Label()
        shipPlacementOwn = New RadioButton()
        shipPlacementRand = New RadioButton()
        difficultylbl = New Label()
        difImpos = New RadioButton()
        difHard = New RadioButton()
        difNorm = New RadioButton()
        difBegin = New RadioButton()
        BoardSizebtn8 = New RadioButton()
        BoardSizebtn10 = New RadioButton()
        BoardSizebtn12 = New RadioButton()
        BoardSizebtn14 = New RadioButton()
        boardSizelbl = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        timerckbx = New CheckBox()
        timerValueBar = New TrackBar()
        CType(backgroundImg, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(timerValueBar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backgroundImg
        ' 
        backgroundImg.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\42okntgt.zbq\\Pictures\WaterBoard.png"
        backgroundImg.Location = New Point(12, 12)
        backgroundImg.Name = "backgroundImg"
        backgroundImg.Size = New Size(300, 300)
        backgroundImg.SizeMode = PictureBoxSizeMode.StretchImage
        backgroundImg.TabIndex = 0
        backgroundImg.TabStop = False
        ' 
        ' playbtnGameSettings
        ' 
        playbtnGameSettings.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playbtnGameSettings.BackgroundImage = My.Resources.Resources.smallButtonBlue
        playbtnGameSettings.BackgroundImageLayout = ImageLayout.Stretch
        playbtnGameSettings.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        playbtnGameSettings.FlatAppearance.BorderSize = 0
        playbtnGameSettings.FlatStyle = FlatStyle.Flat
        playbtnGameSettings.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        playbtnGameSettings.ForeColor = SystemColors.ButtonHighlight
        playbtnGameSettings.Location = New Point(300, 300)
        playbtnGameSettings.Margin = New Padding(0)
        playbtnGameSettings.Name = "playbtnGameSettings"
        playbtnGameSettings.Size = New Size(80, 26)
        playbtnGameSettings.TabIndex = 5
        playbtnGameSettings.Text = "PLAY"
        playbtnGameSettings.UseVisualStyleBackColor = False
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
        backtomainbtn.Location = New Point(300, 344)
        backtomainbtn.Margin = New Padding(0)
        backtomainbtn.Name = "backtomainbtn"
        backtomainbtn.Size = New Size(80, 26)
        backtomainbtn.TabIndex = 6
        backtomainbtn.Text = "EXIT"
        backtomainbtn.UseVisualStyleBackColor = False
        ' 
        ' playerNamelbl
        ' 
        playerNamelbl.AutoSize = True
        playerNamelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerNamelbl.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        playerNamelbl.Location = New Point(211, 260)
        playerNamelbl.Name = "playerNamelbl"
        playerNamelbl.Size = New Size(138, 28)
        playerNamelbl.TabIndex = 7
        playerNamelbl.Text = "Player Name:"
        ' 
        ' Titlelbl
        ' 
        Titlelbl.AutoSize = True
        Titlelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        Titlelbl.Font = New Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point)
        Titlelbl.Location = New Point(579, 44)
        Titlelbl.Name = "Titlelbl"
        Titlelbl.Size = New Size(336, 71)
        Titlelbl.TabIndex = 8
        Titlelbl.Text = "BATTLESHIP"
        ' 
        ' playerNameInputTxtbox
        ' 
        playerNameInputTxtbox.Location = New Point(355, 265)
        playerNameInputTxtbox.Name = "playerNameInputTxtbox"
        playerNameInputTxtbox.PlaceholderText = "Enter your name"
        playerNameInputTxtbox.Size = New Size(195, 23)
        playerNameInputTxtbox.TabIndex = 9
        ' 
        ' playernamewarninglbl
        ' 
        playernamewarninglbl.AutoSize = True
        playernamewarninglbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playernamewarninglbl.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        playernamewarninglbl.ForeColor = Color.Red
        playernamewarninglbl.Location = New Point(355, 291)
        playernamewarninglbl.Name = "playernamewarninglbl"
        playernamewarninglbl.Size = New Size(195, 19)
        playernamewarninglbl.TabIndex = 10
        playernamewarninglbl.Text = "Must be 3-16 characters Long"
        ' 
        ' shipPlacementlbl
        ' 
        shipPlacementlbl.AutoSize = True
        shipPlacementlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shipPlacementlbl.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        shipPlacementlbl.Location = New Point(24, 15)
        shipPlacementlbl.Name = "shipPlacementlbl"
        shipPlacementlbl.Size = New Size(169, 28)
        shipPlacementlbl.TabIndex = 18
        shipPlacementlbl.Text = "Ship Placement: "
        ' 
        ' shipPlacementOwn
        ' 
        shipPlacementOwn.AutoSize = True
        shipPlacementOwn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shipPlacementOwn.Location = New Point(204, 49)
        shipPlacementOwn.Name = "shipPlacementOwn"
        shipPlacementOwn.Size = New Size(90, 19)
        shipPlacementOwn.TabIndex = 17
        shipPlacementOwn.Text = "Own Choice"
        shipPlacementOwn.UseVisualStyleBackColor = False
        ' 
        ' shipPlacementRand
        ' 
        shipPlacementRand.AutoSize = True
        shipPlacementRand.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shipPlacementRand.Checked = True
        shipPlacementRand.Location = New Point(204, 24)
        shipPlacementRand.Name = "shipPlacementRand"
        shipPlacementRand.Size = New Size(70, 19)
        shipPlacementRand.TabIndex = 16
        shipPlacementRand.TabStop = True
        shipPlacementRand.Text = "Random"
        shipPlacementRand.UseVisualStyleBackColor = False
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
        ' difImpos
        ' 
        difImpos.AutoSize = True
        difImpos.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        difImpos.Location = New Point(181, 103)
        difImpos.Name = "difImpos"
        difImpos.Size = New Size(82, 19)
        difImpos.TabIndex = 19
        difImpos.Text = "Impossible"
        difImpos.UseVisualStyleBackColor = False
        ' 
        ' difHard
        ' 
        difHard.AutoSize = True
        difHard.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        difHard.Location = New Point(181, 78)
        difHard.Name = "difHard"
        difHard.Size = New Size(51, 19)
        difHard.TabIndex = 18
        difHard.Text = "Hard"
        difHard.UseVisualStyleBackColor = False
        ' 
        ' difNorm
        ' 
        difNorm.AutoSize = True
        difNorm.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        difNorm.Checked = True
        difNorm.Location = New Point(181, 53)
        difNorm.Name = "difNorm"
        difNorm.Size = New Size(65, 19)
        difNorm.TabIndex = 17
        difNorm.TabStop = True
        difNorm.Text = "Normal"
        difNorm.UseVisualStyleBackColor = False
        ' 
        ' difBegin
        ' 
        difBegin.AutoSize = True
        difBegin.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        difBegin.Location = New Point(181, 28)
        difBegin.Name = "difBegin"
        difBegin.Size = New Size(72, 19)
        difBegin.TabIndex = 16
        difBegin.Text = "Beginner"
        difBegin.UseVisualStyleBackColor = False
        ' 
        ' BoardSizebtn8
        ' 
        BoardSizebtn8.AutoSize = True
        BoardSizebtn8.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        BoardSizebtn8.Location = New Point(165, 27)
        BoardSizebtn8.Name = "BoardSizebtn8"
        BoardSizebtn8.Size = New Size(43, 19)
        BoardSizebtn8.TabIndex = 11
        BoardSizebtn8.Text = "8x8"
        BoardSizebtn8.UseVisualStyleBackColor = False
        ' 
        ' BoardSizebtn10
        ' 
        BoardSizebtn10.AutoSize = True
        BoardSizebtn10.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        BoardSizebtn10.Checked = True
        BoardSizebtn10.Location = New Point(165, 52)
        BoardSizebtn10.Name = "BoardSizebtn10"
        BoardSizebtn10.Size = New Size(55, 19)
        BoardSizebtn10.TabIndex = 12
        BoardSizebtn10.TabStop = True
        BoardSizebtn10.Text = "10x10"
        BoardSizebtn10.UseVisualStyleBackColor = False
        ' 
        ' BoardSizebtn12
        ' 
        BoardSizebtn12.AutoSize = True
        BoardSizebtn12.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        BoardSizebtn12.Location = New Point(165, 77)
        BoardSizebtn12.Name = "BoardSizebtn12"
        BoardSizebtn12.Size = New Size(55, 19)
        BoardSizebtn12.TabIndex = 13
        BoardSizebtn12.Text = "12x12"
        BoardSizebtn12.UseVisualStyleBackColor = False
        ' 
        ' BoardSizebtn14
        ' 
        BoardSizebtn14.AutoSize = True
        BoardSizebtn14.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        BoardSizebtn14.Location = New Point(165, 102)
        BoardSizebtn14.Name = "BoardSizebtn14"
        BoardSizebtn14.Size = New Size(55, 19)
        BoardSizebtn14.TabIndex = 14
        BoardSizebtn14.Text = "14x14"
        BoardSizebtn14.UseVisualStyleBackColor = False
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        Panel1.Controls.Add(boardSizelbl)
        Panel1.Controls.Add(BoardSizebtn14)
        Panel1.Controls.Add(BoardSizebtn12)
        Panel1.Controls.Add(BoardSizebtn10)
        Panel1.Controls.Add(BoardSizebtn8)
        Panel1.Location = New Point(836, 238)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(265, 151)
        Panel1.TabIndex = 23
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        Panel2.Controls.Add(shipPlacementlbl)
        Panel2.Controls.Add(shipPlacementOwn)
        Panel2.Controls.Add(shipPlacementRand)
        Panel2.Location = New Point(797, 412)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(320, 107)
        Panel2.TabIndex = 24
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        Panel3.Controls.Add(difficultylbl)
        Panel3.Controls.Add(difImpos)
        Panel3.Controls.Add(difHard)
        Panel3.Controls.Add(difNorm)
        Panel3.Controls.Add(difBegin)
        Panel3.Location = New Point(820, 542)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(321, 157)
        Panel3.TabIndex = 25
        ' 
        ' timerckbx
        ' 
        timerckbx.AutoSize = True
        timerckbx.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timerckbx.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        timerckbx.Location = New Point(257, 542)
        timerckbx.Name = "timerckbx"
        timerckbx.Size = New Size(92, 32)
        timerckbx.TabIndex = 26
        timerckbx.Text = "Timer:"
        timerckbx.UseVisualStyleBackColor = False
        ' 
        ' timerValueBar
        ' 
        timerValueBar.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timerValueBar.Location = New Point(355, 542)
        timerValueBar.Name = "timerValueBar"
        timerValueBar.Size = New Size(205, 45)
        timerValueBar.TabIndex = 27
        timerValueBar.Value = 5
        timerValueBar.Visible = False
        ' 
        ' GameSettingsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 876)
        Controls.Add(timerValueBar)
        Controls.Add(timerckbx)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(playernamewarninglbl)
        Controls.Add(playerNameInputTxtbox)
        Controls.Add(Titlelbl)
        Controls.Add(playerNamelbl)
        Controls.Add(backtomainbtn)
        Controls.Add(playbtnGameSettings)
        Controls.Add(backgroundImg)
        Name = "GameSettingsForm"
        Text = "Game Settings"
        CType(backgroundImg, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(timerValueBar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents backgroundImg As PictureBox
    Friend WithEvents playbtnGameSettings As Button
    Friend WithEvents backtomainbtn As Button
    Friend WithEvents playerNamelbl As Label
    Friend WithEvents Titlelbl As Label
    Friend WithEvents playerNameInputTxtbox As TextBox
    Friend WithEvents playernamewarninglbl As Label
    Friend WithEvents shipPlacementlbl As Label
    Friend WithEvents shipPlacementOwn As RadioButton
    Friend WithEvents shipPlacementRand As RadioButton
    Friend WithEvents difficultylbl As Label
    Friend WithEvents difImpos As RadioButton
    Friend WithEvents difHard As RadioButton
    Friend WithEvents difNorm As RadioButton
    Friend WithEvents difBegin As RadioButton
    Friend WithEvents BoardSizebtn8 As RadioButton
    Friend WithEvents BoardSizebtn10 As RadioButton
    Friend WithEvents BoardSizebtn12 As RadioButton
    Friend WithEvents BoardSizebtn14 As RadioButton
    Friend WithEvents boardSizelbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents timerckbx As CheckBox
    Friend WithEvents timerValueBar As TrackBar
End Class
