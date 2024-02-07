Imports System.Reflection.Emit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BattleShipsGame
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        backgroundImg = New PictureBox()
        PlayerBoardBGImg = New PictureBox()
        OpponentBoardBGImg = New PictureBox()
        TurnsBannerPic = New PictureBox()
        timelbl = New Windows.Forms.Label()
        playernamelbl = New Windows.Forms.Label()
        playerscorelbl = New Windows.Forms.Label()
        playerscoretxt = New Windows.Forms.Label()
        playernametxt = New Windows.Forms.Label()
        opponentnamelbl = New Windows.Forms.Label()
        opponentscorelbl = New Windows.Forms.Label()
        opponentscoretxt = New Windows.Forms.Label()
        backtomainbtn = New Button()
        resetbtn = New Button()
        opponentshipPicbox2 = New PictureBox()
        opponentshipPicbox3a = New PictureBox()
        opponentshipPicbox3b = New PictureBox()
        opponentshipPicbox4 = New PictureBox()
        opponentshipPicbox5 = New PictureBox()
        playershipPicbox5 = New PictureBox()
        playershipPicbox4 = New PictureBox()
        playershipPicbox3b = New PictureBox()
        playershipPicbox3a = New PictureBox()
        playershipPicbox2 = New PictureBox()
        keyBluepicbox = New PictureBox()
        keytitlelbl = New Windows.Forms.Label()
        Keymisslbl = New Windows.Forms.Label()
        KeyHitlbl = New Windows.Forms.Label()
        keyRedpicbox = New PictureBox()
        KeyPanel = New Panel()
        ListBox1 = New ListBox()
        CType(backgroundImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(PlayerBoardBGImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(OpponentBoardBGImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(TurnsBannerPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(opponentshipPicbox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(opponentshipPicbox3a, ComponentModel.ISupportInitialize).BeginInit()
        CType(opponentshipPicbox3b, ComponentModel.ISupportInitialize).BeginInit()
        CType(opponentshipPicbox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(opponentshipPicbox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(playershipPicbox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(playershipPicbox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(playershipPicbox3b, ComponentModel.ISupportInitialize).BeginInit()
        CType(playershipPicbox3a, ComponentModel.ISupportInitialize).BeginInit()
        CType(playershipPicbox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(keyBluepicbox, ComponentModel.ISupportInitialize).BeginInit()
        CType(keyRedpicbox, ComponentModel.ISupportInitialize).BeginInit()
        KeyPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' backgroundImg
        ' 
        backgroundImg.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\bdum3ufq.wjq\\Pictures\WaterBoard.png"
        backgroundImg.Location = New Point(12, 12)
        backgroundImg.Name = "backgroundImg"
        backgroundImg.Size = New Size(100, 50)
        backgroundImg.SizeMode = PictureBoxSizeMode.StretchImage
        backgroundImg.TabIndex = 0
        backgroundImg.TabStop = False
        ' 
        ' PlayerBoardBGImg
        ' 
        PlayerBoardBGImg.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        PlayerBoardBGImg.BackgroundImageLayout = ImageLayout.Stretch
        PlayerBoardBGImg.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\bdum3ufq.wjq\\Pictures\Board.png"
        PlayerBoardBGImg.Location = New Point(0, 50)
        PlayerBoardBGImg.Name = "PlayerBoardBGImg"
        PlayerBoardBGImg.Size = New Size(100, 50)
        PlayerBoardBGImg.SizeMode = PictureBoxSizeMode.StretchImage
        PlayerBoardBGImg.TabIndex = 8
        PlayerBoardBGImg.TabStop = False
        ' 
        ' OpponentBoardBGImg
        ' 
        OpponentBoardBGImg.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        OpponentBoardBGImg.BackgroundImageLayout = ImageLayout.Stretch
        OpponentBoardBGImg.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\bdum3ufq.wjq\\Pictures\Board.png"
        OpponentBoardBGImg.Location = New Point(207, 75)
        OpponentBoardBGImg.Name = "OpponentBoardBGImg"
        OpponentBoardBGImg.Size = New Size(100, 50)
        OpponentBoardBGImg.SizeMode = PictureBoxSizeMode.StretchImage
        OpponentBoardBGImg.TabIndex = 9
        OpponentBoardBGImg.TabStop = False
        ' 
        ' TurnsBannerPic
        ' 
        TurnsBannerPic.BackColor = Color.FromArgb(CByte(156), CByte(156), CByte(156))
        TurnsBannerPic.BackgroundImageLayout = ImageLayout.None
        TurnsBannerPic.Location = New Point(207, 85)
        TurnsBannerPic.Name = "TurnsBannerPic"
        TurnsBannerPic.Size = New Size(100, 50)
        TurnsBannerPic.SizeMode = PictureBoxSizeMode.StretchImage
        TurnsBannerPic.TabIndex = 10
        TurnsBannerPic.TabStop = False
        ' 
        ' timelbl
        ' 
        timelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timelbl.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point)
        timelbl.ForeColor = Color.Red
        timelbl.ImageAlign = ContentAlignment.BottomCenter
        timelbl.Location = New Point(0, 50)
        timelbl.Margin = New Padding(0)
        timelbl.Name = "timelbl"
        timelbl.Size = New Size(100, 23)
        timelbl.TabIndex = 11
        timelbl.Text = "00:00"
        ' 
        ' playernamelbl
        ' 
        playernamelbl.AutoSize = True
        playernamelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playernamelbl.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point)
        playernamelbl.ForeColor = Color.Black
        playernamelbl.Location = New Point(104, 35)
        playernamelbl.Name = "playernamelbl"
        playernamelbl.Size = New Size(88, 26)
        playernamelbl.TabIndex = 12
        playernamelbl.Text = "Player: "
        ' 
        ' playerscorelbl
        ' 
        playerscorelbl.AutoSize = True
        playerscorelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerscorelbl.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point)
        playerscorelbl.ForeColor = Color.Black
        playerscorelbl.Location = New Point(104, 9)
        playerscorelbl.Name = "playerscorelbl"
        playerscorelbl.Size = New Size(79, 26)
        playerscorelbl.TabIndex = 13
        playerscorelbl.Text = "Score:"
        ' 
        ' playerscoretxt
        ' 
        playerscoretxt.AutoSize = True
        playerscoretxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerscoretxt.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        playerscoretxt.ForeColor = Color.Black
        playerscoretxt.Location = New Point(104, 61)
        playerscoretxt.Name = "playerscoretxt"
        playerscoretxt.Size = New Size(22, 24)
        playerscoretxt.TabIndex = 14
        playerscoretxt.Text = "0"
        ' 
        ' playernametxt
        ' 
        playernametxt.AutoSize = True
        playernametxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playernametxt.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        playernametxt.ForeColor = Color.Black
        playernametxt.Location = New Point(-18, 26)
        playernametxt.Name = "playernametxt"
        playernametxt.Size = New Size(0, 24)
        playernametxt.TabIndex = 15
        ' 
        ' opponentnamelbl
        ' 
        opponentnamelbl.AutoSize = True
        opponentnamelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentnamelbl.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point)
        opponentnamelbl.ForeColor = Color.Black
        opponentnamelbl.Location = New Point(341, 10)
        opponentnamelbl.Name = "opponentnamelbl"
        opponentnamelbl.Size = New Size(113, 26)
        opponentnamelbl.TabIndex = 16
        opponentnamelbl.Text = "Opponent"
        ' 
        ' opponentscorelbl
        ' 
        opponentscorelbl.AutoSize = True
        opponentscorelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentscorelbl.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point)
        opponentscorelbl.ForeColor = Color.Black
        opponentscorelbl.Location = New Point(341, 36)
        opponentscorelbl.Name = "opponentscorelbl"
        opponentscorelbl.Size = New Size(79, 26)
        opponentscorelbl.TabIndex = 17
        opponentscorelbl.Text = "Score:"
        ' 
        ' opponentscoretxt
        ' 
        opponentscoretxt.AutoSize = True
        opponentscoretxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentscoretxt.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        opponentscoretxt.ForeColor = Color.Black
        opponentscoretxt.Location = New Point(341, 62)
        opponentscoretxt.Name = "opponentscoretxt"
        opponentscoretxt.Size = New Size(22, 24)
        opponentscoretxt.TabIndex = 18
        opponentscoretxt.Text = "0"
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
        backtomainbtn.Location = New Point(537, 131)
        backtomainbtn.Margin = New Padding(0)
        backtomainbtn.Name = "backtomainbtn"
        backtomainbtn.Size = New Size(80, 23)
        backtomainbtn.TabIndex = 7
        backtomainbtn.Text = "EXIT"
        backtomainbtn.UseVisualStyleBackColor = False
        ' 
        ' resetbtn
        ' 
        resetbtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        resetbtn.BackgroundImage = My.Resources.Resources.smallButtonBlue
        resetbtn.BackgroundImageLayout = ImageLayout.Stretch
        resetbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        resetbtn.FlatAppearance.BorderSize = 0
        resetbtn.FlatStyle = FlatStyle.Flat
        resetbtn.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        resetbtn.ForeColor = SystemColors.ButtonHighlight
        resetbtn.Location = New Point(308, 163)
        resetbtn.Margin = New Padding(0)
        resetbtn.Name = "resetbtn"
        resetbtn.Size = New Size(80, 23)
        resetbtn.TabIndex = 19
        resetbtn.Text = "RESET"
        resetbtn.UseVisualStyleBackColor = False
        ' 
        ' opponentshipPicbox2
        ' 
        opponentshipPicbox2.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentshipPicbox2.Image = My.Resources.Resources.BattleShip2
        opponentshipPicbox2.Location = New Point(83, 131)
        opponentshipPicbox2.Name = "opponentshipPicbox2"
        opponentshipPicbox2.Size = New Size(100, 50)
        opponentshipPicbox2.SizeMode = PictureBoxSizeMode.StretchImage
        opponentshipPicbox2.TabIndex = 20
        opponentshipPicbox2.TabStop = False
        ' 
        ' opponentshipPicbox3a
        ' 
        opponentshipPicbox3a.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentshipPicbox3a.Image = My.Resources.Resources.BattleShip3
        opponentshipPicbox3a.Location = New Point(23, 615)
        opponentshipPicbox3a.Name = "opponentshipPicbox3a"
        opponentshipPicbox3a.Size = New Size(100, 50)
        opponentshipPicbox3a.SizeMode = PictureBoxSizeMode.StretchImage
        opponentshipPicbox3a.TabIndex = 21
        opponentshipPicbox3a.TabStop = False
        ' 
        ' opponentshipPicbox3b
        ' 
        opponentshipPicbox3b.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentshipPicbox3b.Image = My.Resources.Resources.BattleShip3
        opponentshipPicbox3b.Location = New Point(23, 690)
        opponentshipPicbox3b.Name = "opponentshipPicbox3b"
        opponentshipPicbox3b.Size = New Size(100, 50)
        opponentshipPicbox3b.SizeMode = PictureBoxSizeMode.StretchImage
        opponentshipPicbox3b.TabIndex = 22
        opponentshipPicbox3b.TabStop = False
        ' 
        ' opponentshipPicbox4
        ' 
        opponentshipPicbox4.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentshipPicbox4.Image = My.Resources.Resources.BattleShip4
        opponentshipPicbox4.Location = New Point(124, 783)
        opponentshipPicbox4.Name = "opponentshipPicbox4"
        opponentshipPicbox4.Size = New Size(100, 50)
        opponentshipPicbox4.SizeMode = PictureBoxSizeMode.StretchImage
        opponentshipPicbox4.TabIndex = 23
        opponentshipPicbox4.TabStop = False
        ' 
        ' opponentshipPicbox5
        ' 
        opponentshipPicbox5.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentshipPicbox5.Image = My.Resources.Resources.BattleShip5
        opponentshipPicbox5.Location = New Point(155, 701)
        opponentshipPicbox5.Name = "opponentshipPicbox5"
        opponentshipPicbox5.Size = New Size(100, 50)
        opponentshipPicbox5.SizeMode = PictureBoxSizeMode.StretchImage
        opponentshipPicbox5.TabIndex = 24
        opponentshipPicbox5.TabStop = False
        ' 
        ' playershipPicbox5
        ' 
        playershipPicbox5.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playershipPicbox5.Image = My.Resources.Resources.BattleShip5
        playershipPicbox5.Location = New Point(83, 131)
        playershipPicbox5.Name = "playershipPicbox5"
        playershipPicbox5.Size = New Size(100, 50)
        playershipPicbox5.SizeMode = PictureBoxSizeMode.StretchImage
        playershipPicbox5.TabIndex = 29
        playershipPicbox5.TabStop = False
        ' 
        ' playershipPicbox4
        ' 
        playershipPicbox4.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playershipPicbox4.Image = My.Resources.Resources.BattleShip4
        playershipPicbox4.Location = New Point(83, 131)
        playershipPicbox4.Name = "playershipPicbox4"
        playershipPicbox4.Size = New Size(100, 50)
        playershipPicbox4.SizeMode = PictureBoxSizeMode.StretchImage
        playershipPicbox4.TabIndex = 28
        playershipPicbox4.TabStop = False
        ' 
        ' playershipPicbox3b
        ' 
        playershipPicbox3b.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playershipPicbox3b.Image = My.Resources.Resources.BattleShip3
        playershipPicbox3b.Location = New Point(83, 131)
        playershipPicbox3b.Name = "playershipPicbox3b"
        playershipPicbox3b.Size = New Size(100, 50)
        playershipPicbox3b.SizeMode = PictureBoxSizeMode.StretchImage
        playershipPicbox3b.TabIndex = 27
        playershipPicbox3b.TabStop = False
        ' 
        ' playershipPicbox3a
        ' 
        playershipPicbox3a.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playershipPicbox3a.Image = My.Resources.Resources.BattleShip3
        playershipPicbox3a.Location = New Point(83, 131)
        playershipPicbox3a.Name = "playershipPicbox3a"
        playershipPicbox3a.Size = New Size(100, 50)
        playershipPicbox3a.SizeMode = PictureBoxSizeMode.StretchImage
        playershipPicbox3a.TabIndex = 26
        playershipPicbox3a.TabStop = False
        ' 
        ' playershipPicbox2
        ' 
        playershipPicbox2.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playershipPicbox2.Image = My.Resources.Resources.BattleShip2
        playershipPicbox2.Location = New Point(83, 131)
        playershipPicbox2.Name = "playershipPicbox2"
        playershipPicbox2.Size = New Size(100, 50)
        playershipPicbox2.SizeMode = PictureBoxSizeMode.StretchImage
        playershipPicbox2.TabIndex = 25
        playershipPicbox2.TabStop = False
        ' 
        ' keyBluepicbox
        ' 
        keyBluepicbox.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        keyBluepicbox.Image = My.Resources.Resources.BlueCircle
        keyBluepicbox.Location = New Point(27, 46)
        keyBluepicbox.Name = "keyBluepicbox"
        keyBluepicbox.Size = New Size(40, 40)
        keyBluepicbox.SizeMode = PictureBoxSizeMode.StretchImage
        keyBluepicbox.TabIndex = 30
        keyBluepicbox.TabStop = False
        ' 
        ' keytitlelbl
        ' 
        keytitlelbl.AutoSize = True
        keytitlelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        keytitlelbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        keytitlelbl.Location = New Point(15, 12)
        keytitlelbl.Name = "keytitlelbl"
        keytitlelbl.Size = New Size(38, 21)
        keytitlelbl.TabIndex = 31
        keytitlelbl.Text = "Key"
        ' 
        ' Keymisslbl
        ' 
        Keymisslbl.AutoSize = True
        Keymisslbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        Keymisslbl.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Keymisslbl.Location = New Point(73, 56)
        Keymisslbl.Name = "Keymisslbl"
        Keymisslbl.Size = New Size(37, 19)
        Keymisslbl.TabIndex = 32
        Keymisslbl.Text = "Miss"
        ' 
        ' KeyHitlbl
        ' 
        KeyHitlbl.AutoSize = True
        KeyHitlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        KeyHitlbl.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        KeyHitlbl.Location = New Point(73, 102)
        KeyHitlbl.Name = "KeyHitlbl"
        KeyHitlbl.Size = New Size(27, 19)
        KeyHitlbl.TabIndex = 34
        KeyHitlbl.Text = "Hit"
        ' 
        ' keyRedpicbox
        ' 
        keyRedpicbox.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        keyRedpicbox.Image = My.Resources.Resources.RedCircle
        keyRedpicbox.Location = New Point(27, 92)
        keyRedpicbox.Name = "keyRedpicbox"
        keyRedpicbox.Size = New Size(40, 40)
        keyRedpicbox.SizeMode = PictureBoxSizeMode.StretchImage
        keyRedpicbox.TabIndex = 33
        keyRedpicbox.TabStop = False
        ' 
        ' KeyPanel
        ' 
        KeyPanel.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        KeyPanel.Controls.Add(KeyHitlbl)
        KeyPanel.Controls.Add(keyRedpicbox)
        KeyPanel.Controls.Add(Keymisslbl)
        KeyPanel.Controls.Add(keytitlelbl)
        KeyPanel.Controls.Add(keyBluepicbox)
        KeyPanel.Location = New Point(47, 219)
        KeyPanel.Name = "KeyPanel"
        KeyPanel.Size = New Size(136, 157)
        KeyPanel.TabIndex = 35
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(231, 436)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(189, 229)
        ListBox1.TabIndex = 36
        ' 
        ' BattleShipsGame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 876)
        Controls.Add(ListBox1)
        Controls.Add(KeyPanel)
        Controls.Add(playershipPicbox5)
        Controls.Add(playershipPicbox4)
        Controls.Add(playershipPicbox3b)
        Controls.Add(playershipPicbox3a)
        Controls.Add(playershipPicbox2)
        Controls.Add(opponentshipPicbox5)
        Controls.Add(opponentshipPicbox4)
        Controls.Add(opponentshipPicbox3b)
        Controls.Add(opponentshipPicbox3a)
        Controls.Add(opponentshipPicbox2)
        Controls.Add(resetbtn)
        Controls.Add(opponentscoretxt)
        Controls.Add(opponentscorelbl)
        Controls.Add(opponentnamelbl)
        Controls.Add(playernametxt)
        Controls.Add(playerscoretxt)
        Controls.Add(playerscorelbl)
        Controls.Add(playernamelbl)
        Controls.Add(timelbl)
        Controls.Add(TurnsBannerPic)
        Controls.Add(OpponentBoardBGImg)
        Controls.Add(PlayerBoardBGImg)
        Controls.Add(backtomainbtn)
        Controls.Add(backgroundImg)
        HelpButton = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "BattleShipsGame"
        Text = "Battleship"
        TopMost = True
        CType(backgroundImg, ComponentModel.ISupportInitialize).EndInit()
        CType(PlayerBoardBGImg, ComponentModel.ISupportInitialize).EndInit()
        CType(OpponentBoardBGImg, ComponentModel.ISupportInitialize).EndInit()
        CType(TurnsBannerPic, ComponentModel.ISupportInitialize).EndInit()
        CType(opponentshipPicbox2, ComponentModel.ISupportInitialize).EndInit()
        CType(opponentshipPicbox3a, ComponentModel.ISupportInitialize).EndInit()
        CType(opponentshipPicbox3b, ComponentModel.ISupportInitialize).EndInit()
        CType(opponentshipPicbox4, ComponentModel.ISupportInitialize).EndInit()
        CType(opponentshipPicbox5, ComponentModel.ISupportInitialize).EndInit()
        CType(playershipPicbox5, ComponentModel.ISupportInitialize).EndInit()
        CType(playershipPicbox4, ComponentModel.ISupportInitialize).EndInit()
        CType(playershipPicbox3b, ComponentModel.ISupportInitialize).EndInit()
        CType(playershipPicbox3a, ComponentModel.ISupportInitialize).EndInit()
        CType(playershipPicbox2, ComponentModel.ISupportInitialize).EndInit()
        CType(keyBluepicbox, ComponentModel.ISupportInitialize).EndInit()
        CType(keyRedpicbox, ComponentModel.ISupportInitialize).EndInit()
        KeyPanel.ResumeLayout(False)
        KeyPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backgroundImg As PictureBox
    Friend WithEvents PlayerBoardBGImg As PictureBox
    Friend WithEvents OpponentBoardBGImg As PictureBox
    Friend WithEvents TurnsBannerPic As PictureBox
    Friend WithEvents timelbl As Windows.Forms.Label
    Friend WithEvents playernamelbl As Windows.Forms.Label
    Friend WithEvents playerscorelbl As Windows.Forms.Label
    Friend WithEvents playerscoretxt As Windows.Forms.Label
    Friend WithEvents playernametxt As Windows.Forms.Label
    Friend WithEvents opponentnamelbl As Windows.Forms.Label
    Friend WithEvents opponentscorelbl As Windows.Forms.Label
    Friend WithEvents opponentscoretxt As Windows.Forms.Label
    Friend WithEvents backtomainbtn As Button
    Friend WithEvents resetbtn As Button
    Friend WithEvents opponentshipPicbox2 As PictureBox
    Friend WithEvents opponentshipPicbox3a As PictureBox
    Friend WithEvents opponentshipPicbox3b As PictureBox
    Friend WithEvents opponentshipPicbox4 As PictureBox
    Friend WithEvents opponentshipPicbox5 As PictureBox
    Friend WithEvents playershipPicbox5 As PictureBox
    Friend WithEvents playershipPicbox4 As PictureBox
    Friend WithEvents playershipPicbox3b As PictureBox
    Friend WithEvents playershipPicbox3a As PictureBox
    Friend WithEvents playershipPicbox2 As PictureBox
    Friend WithEvents keyBluepicbox As PictureBox
    Friend WithEvents keytitlelbl As Windows.Forms.Label
    Friend WithEvents Keymisslbl As Windows.Forms.Label
    Friend WithEvents KeyHitlbl As Windows.Forms.Label
    Friend WithEvents keyRedpicbox As PictureBox
    Friend WithEvents KeyPanel As Panel
    Friend WithEvents ListBox1 As ListBox
End Class
