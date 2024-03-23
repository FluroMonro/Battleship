﻿Imports System.Reflection.Emit

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
        components = New ComponentModel.Container()
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
        gameTimer = New Timer(components)
        Timer1 = New Timer(components)
        Label1 = New Windows.Forms.Label()
        playerStatspnl = New Panel()
        playerShipsLeftCounttxt = New Windows.Forms.Label()
        playerShipsHitCounttxt = New Windows.Forms.Label()
        shipsLeftlbl = New Windows.Forms.Label()
        shipHitlbl = New Windows.Forms.Label()
        playerAccuracyCounttxt = New Windows.Forms.Label()
        playerHitCounttxt = New Windows.Forms.Label()
        playerMissCounttxt = New Windows.Forms.Label()
        playerAccuracylbl = New Windows.Forms.Label()
        playerHitCountlbl = New Windows.Forms.Label()
        playerMissCountLbl = New Windows.Forms.Label()
        PlayerStatslbl = New Windows.Forms.Label()
        opponentStatspnl = New Panel()
        opponentAccuracyCounttxt = New Windows.Forms.Label()
        opponentShipsHitCounttxt = New Windows.Forms.Label()
        opponentShipsMissCounttxt = New Windows.Forms.Label()
        opponentAccuracylbl = New Windows.Forms.Label()
        opponentHitCountlbl = New Windows.Forms.Label()
        opponentMissCountlbl = New Windows.Forms.Label()
        opponentStatslbl = New Windows.Forms.Label()
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
        playerStatspnl.SuspendLayout()
        opponentStatspnl.SuspendLayout()
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
        ' gameTimer
        ' 
        gameTimer.Enabled = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(280, 237)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 36
        ' 
        ' playerStatspnl
        ' 
        playerStatspnl.BackColor = Color.FromArgb(CByte(175), CByte(215), CByte(240))
        playerStatspnl.BackgroundImageLayout = ImageLayout.None
        playerStatspnl.Controls.Add(playerShipsLeftCounttxt)
        playerStatspnl.Controls.Add(playerShipsHitCounttxt)
        playerStatspnl.Controls.Add(shipsLeftlbl)
        playerStatspnl.Controls.Add(shipHitlbl)
        playerStatspnl.Controls.Add(playerAccuracyCounttxt)
        playerStatspnl.Controls.Add(playerHitCounttxt)
        playerStatspnl.Controls.Add(playerMissCounttxt)
        playerStatspnl.Controls.Add(playerAccuracylbl)
        playerStatspnl.Controls.Add(playerHitCountlbl)
        playerStatspnl.Controls.Add(playerMissCountLbl)
        playerStatspnl.Controls.Add(PlayerStatslbl)
        playerStatspnl.Location = New Point(220, 45)
        playerStatspnl.Name = "playerStatspnl"
        playerStatspnl.Size = New Size(214, 306)
        playerStatspnl.TabIndex = 36
        ' 
        ' playerShipsLeftCounttxt
        ' 
        playerShipsLeftCounttxt.AutoSize = True
        playerShipsLeftCounttxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerShipsLeftCounttxt.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerShipsLeftCounttxt.Location = New Point(119, 210)
        playerShipsLeftCounttxt.Name = "playerShipsLeftCounttxt"
        playerShipsLeftCounttxt.Size = New Size(19, 21)
        playerShipsLeftCounttxt.TabIndex = 42
        playerShipsLeftCounttxt.Text = "0"
        ' 
        ' playerShipsHitCounttxt
        ' 
        playerShipsHitCounttxt.AutoSize = True
        playerShipsHitCounttxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerShipsHitCounttxt.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerShipsHitCounttxt.Location = New Point(119, 170)
        playerShipsHitCounttxt.Name = "playerShipsHitCounttxt"
        playerShipsHitCounttxt.Size = New Size(19, 21)
        playerShipsHitCounttxt.TabIndex = 41
        playerShipsHitCounttxt.Text = "0"
        ' 
        ' shipsLeftlbl
        ' 
        shipsLeftlbl.AutoSize = True
        shipsLeftlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shipsLeftlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        shipsLeftlbl.Location = New Point(25, 210)
        shipsLeftlbl.Name = "shipsLeftlbl"
        shipsLeftlbl.Size = New Size(81, 21)
        shipsLeftlbl.TabIndex = 40
        shipsLeftlbl.Text = "Ships Left:"
        ' 
        ' shipHitlbl
        ' 
        shipHitlbl.AutoSize = True
        shipHitlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        shipHitlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        shipHitlbl.Location = New Point(25, 170)
        shipHitlbl.Name = "shipHitlbl"
        shipHitlbl.Size = New Size(75, 21)
        shipHitlbl.TabIndex = 39
        shipHitlbl.Text = "Ships Hit:"
        ' 
        ' playerAccuracyCounttxt
        ' 
        playerAccuracyCounttxt.AutoSize = True
        playerAccuracyCounttxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerAccuracyCounttxt.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerAccuracyCounttxt.Location = New Point(119, 130)
        playerAccuracyCounttxt.Name = "playerAccuracyCounttxt"
        playerAccuracyCounttxt.Size = New Size(16, 21)
        playerAccuracyCounttxt.TabIndex = 38
        playerAccuracyCounttxt.Text = "-"
        ' 
        ' playerHitCounttxt
        ' 
        playerHitCounttxt.AutoSize = True
        playerHitCounttxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerHitCounttxt.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerHitCounttxt.Location = New Point(119, 90)
        playerHitCounttxt.Name = "playerHitCounttxt"
        playerHitCounttxt.Size = New Size(19, 21)
        playerHitCounttxt.TabIndex = 37
        playerHitCounttxt.Text = "0"
        ' 
        ' playerMissCounttxt
        ' 
        playerMissCounttxt.AutoSize = True
        playerMissCounttxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerMissCounttxt.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerMissCounttxt.Location = New Point(119, 50)
        playerMissCounttxt.Name = "playerMissCounttxt"
        playerMissCounttxt.Size = New Size(19, 21)
        playerMissCounttxt.TabIndex = 36
        playerMissCounttxt.Text = "0"
        ' 
        ' playerAccuracylbl
        ' 
        playerAccuracylbl.AutoSize = True
        playerAccuracylbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerAccuracylbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerAccuracylbl.Location = New Point(24, 130)
        playerAccuracylbl.Name = "playerAccuracylbl"
        playerAccuracylbl.Size = New Size(75, 21)
        playerAccuracylbl.TabIndex = 35
        playerAccuracylbl.Text = "Accuracy:"
        ' 
        ' playerHitCountlbl
        ' 
        playerHitCountlbl.AutoSize = True
        playerHitCountlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerHitCountlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerHitCountlbl.Location = New Point(24, 90)
        playerHitCountlbl.Name = "playerHitCountlbl"
        playerHitCountlbl.Size = New Size(40, 21)
        playerHitCountlbl.TabIndex = 34
        playerHitCountlbl.Text = "Hits:"
        ' 
        ' playerMissCountLbl
        ' 
        playerMissCountLbl.AutoSize = True
        playerMissCountLbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerMissCountLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerMissCountLbl.Location = New Point(25, 50)
        playerMissCountLbl.Name = "playerMissCountLbl"
        playerMissCountLbl.Size = New Size(60, 21)
        playerMissCountLbl.TabIndex = 32
        playerMissCountLbl.Text = "Misses:"
        ' 
        ' PlayerStatslbl
        ' 
        PlayerStatslbl.AutoSize = True
        PlayerStatslbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        PlayerStatslbl.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        PlayerStatslbl.Location = New Point(15, 12)
        PlayerStatslbl.Name = "PlayerStatslbl"
        PlayerStatslbl.Size = New Size(124, 28)
        PlayerStatslbl.TabIndex = 31
        PlayerStatslbl.Text = "Player Stats"
        ' 
        ' opponentStatspnl
        ' 
        opponentStatspnl.BackColor = Color.FromArgb(CByte(175), CByte(215), CByte(240))
        opponentStatspnl.BackgroundImageLayout = ImageLayout.None
        opponentStatspnl.Controls.Add(opponentAccuracyCounttxt)
        opponentStatspnl.Controls.Add(opponentShipsHitCounttxt)
        opponentStatspnl.Controls.Add(opponentShipsMissCounttxt)
        opponentStatspnl.Controls.Add(opponentAccuracylbl)
        opponentStatspnl.Controls.Add(opponentHitCountlbl)
        opponentStatspnl.Controls.Add(opponentMissCountlbl)
        opponentStatspnl.Controls.Add(opponentStatslbl)
        opponentStatspnl.Location = New Point(1022, 561)
        opponentStatspnl.Name = "opponentStatspnl"
        opponentStatspnl.Size = New Size(188, 179)
        opponentStatspnl.TabIndex = 43
        ' 
        ' opponentAccuracyCounttxt
        ' 
        opponentAccuracyCounttxt.AutoSize = True
        opponentAccuracyCounttxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentAccuracyCounttxt.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        opponentAccuracyCounttxt.Location = New Point(119, 130)
        opponentAccuracyCounttxt.Name = "opponentAccuracyCounttxt"
        opponentAccuracyCounttxt.Size = New Size(16, 21)
        opponentAccuracyCounttxt.TabIndex = 38
        opponentAccuracyCounttxt.Text = "-"
        ' 
        ' opponentShipsHitCounttxt
        ' 
        opponentShipsHitCounttxt.AutoSize = True
        opponentShipsHitCounttxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentShipsHitCounttxt.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        opponentShipsHitCounttxt.Location = New Point(119, 90)
        opponentShipsHitCounttxt.Name = "opponentShipsHitCounttxt"
        opponentShipsHitCounttxt.Size = New Size(19, 21)
        opponentShipsHitCounttxt.TabIndex = 37
        opponentShipsHitCounttxt.Text = "0"
        ' 
        ' opponentShipsMissCounttxt
        ' 
        opponentShipsMissCounttxt.AutoSize = True
        opponentShipsMissCounttxt.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentShipsMissCounttxt.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        opponentShipsMissCounttxt.Location = New Point(119, 50)
        opponentShipsMissCounttxt.Name = "opponentShipsMissCounttxt"
        opponentShipsMissCounttxt.Size = New Size(19, 21)
        opponentShipsMissCounttxt.TabIndex = 36
        opponentShipsMissCounttxt.Text = "0"
        ' 
        ' opponentAccuracylbl
        ' 
        opponentAccuracylbl.AutoSize = True
        opponentAccuracylbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentAccuracylbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        opponentAccuracylbl.Location = New Point(25, 130)
        opponentAccuracylbl.Name = "opponentAccuracylbl"
        opponentAccuracylbl.Size = New Size(75, 21)
        opponentAccuracylbl.TabIndex = 35
        opponentAccuracylbl.Text = "Accuracy:"
        ' 
        ' opponentHitCountlbl
        ' 
        opponentHitCountlbl.AutoSize = True
        opponentHitCountlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentHitCountlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        opponentHitCountlbl.Location = New Point(25, 90)
        opponentHitCountlbl.Name = "opponentHitCountlbl"
        opponentHitCountlbl.Size = New Size(40, 21)
        opponentHitCountlbl.TabIndex = 34
        opponentHitCountlbl.Text = "Hits:"
        ' 
        ' opponentMissCountlbl
        ' 
        opponentMissCountlbl.AutoSize = True
        opponentMissCountlbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentMissCountlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        opponentMissCountlbl.Location = New Point(25, 50)
        opponentMissCountlbl.Name = "opponentMissCountlbl"
        opponentMissCountlbl.Size = New Size(60, 21)
        opponentMissCountlbl.TabIndex = 32
        opponentMissCountlbl.Text = "Misses:"
        ' 
        ' opponentStatslbl
        ' 
        opponentStatslbl.AutoSize = True
        opponentStatslbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentStatslbl.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        opponentStatslbl.Location = New Point(15, 12)
        opponentStatslbl.Name = "opponentStatslbl"
        opponentStatslbl.Size = New Size(159, 28)
        opponentStatslbl.TabIndex = 31
        opponentStatslbl.Text = "Opponent Stats"
        ' 
        ' BattleShipsGame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 876)
        Controls.Add(opponentStatspnl)
        Controls.Add(playerStatspnl)
        Controls.Add(Label1)
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
        playerStatspnl.ResumeLayout(False)
        playerStatspnl.PerformLayout()
        opponentStatspnl.ResumeLayout(False)
        opponentStatspnl.PerformLayout()
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
    Friend WithEvents gameTimer As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents playerStatspnl As Panel
    Friend WithEvents playerMissCounttxt As Windows.Forms.Label
    Friend WithEvents playerAccuracylbl As Windows.Forms.Label
    Friend WithEvents playerHitCountlbl As Windows.Forms.Label
    Friend WithEvents playerMissCountLbl As Windows.Forms.Label
    Friend WithEvents PlayerStatslbl As Windows.Forms.Label
    Friend WithEvents playerAccuracyCounttxt As Windows.Forms.Label
    Friend WithEvents playerHitCounttxt As Windows.Forms.Label
    Friend WithEvents shipHitlbl As Windows.Forms.Label
    Friend WithEvents shipsLeftlbl As Windows.Forms.Label
    Friend WithEvents playerShipsLeftCounttxt As Windows.Forms.Label
    Friend WithEvents playerShipsHitCounttxt As Windows.Forms.Label
    Friend WithEvents opponentStatspnl As Panel
    Friend WithEvents opponentAccuracyCounttxt As Windows.Forms.Label
    Friend WithEvents opponentShipsHitCounttxt As Windows.Forms.Label
    Friend WithEvents opponentShipsMissCounttxt As Windows.Forms.Label
    Friend WithEvents opponentAccuracylbl As Windows.Forms.Label
    Friend WithEvents opponentHitCountlbl As Windows.Forms.Label
    Friend WithEvents opponentMissCountlbl As Windows.Forms.Label
    Friend WithEvents opponentStatslbl As Windows.Forms.Label
End Class
