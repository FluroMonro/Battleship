﻿Imports System.Reflection.Emit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class battleshipGamefrm
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
        backgroundpb = New PictureBox()
        playerBoardpb = New PictureBox()
        opponentBoardpb = New PictureBox()
        turnsBannerpb = New PictureBox()
        timelbl = New Windows.Forms.Label()
        playernamelbl = New Windows.Forms.Label()
        playerscorelbl = New Windows.Forms.Label()
        playerScoreTextlbl = New Windows.Forms.Label()
        opponentnamelbl = New Windows.Forms.Label()
        opponentscorelbl = New Windows.Forms.Label()
        opponentScoreTextlbl = New Windows.Forms.Label()
        backToMainbtn = New Button()
        resetbtn = New Button()
        opponentShip2pb = New PictureBox()
        opponentShip3apb = New PictureBox()
        opponentShip3bpb = New PictureBox()
        opponentShip4pb = New PictureBox()
        opponentShip5pb = New PictureBox()
        playerShip5pb = New PictureBox()
        playerShip4pb = New PictureBox()
        playerShip3bpb = New PictureBox()
        playerShip3apb = New PictureBox()
        playerShip2pb = New PictureBox()
        keyBluepb = New PictureBox()
        keyTitlelbl = New Windows.Forms.Label()
        keyMisslbl = New Windows.Forms.Label()
        keyHitlbl = New Windows.Forms.Label()
        keyRedpb = New PictureBox()
        keypnl = New Panel()
        gameTimer = New Timer(components)
        playerStatspnl = New Panel()
        playerShipsLeftCountTextlbl = New Windows.Forms.Label()
        playerShipsHitCountTextlbl = New Windows.Forms.Label()
        shipsLeftlbl = New Windows.Forms.Label()
        shipHitlbl = New Windows.Forms.Label()
        playerAccuracyCountTextlbl = New Windows.Forms.Label()
        playerHitCountTextlbl = New Windows.Forms.Label()
        playerMissCountTextlbl = New Windows.Forms.Label()
        playerAccuracylbl = New Windows.Forms.Label()
        playerHitCountlbl = New Windows.Forms.Label()
        playerMissCountlbl = New Windows.Forms.Label()
        playerStatslbl = New Windows.Forms.Label()
        opponentStatspnl = New Panel()
        opponentAccuracyCountTextlbl = New Windows.Forms.Label()
        opponentShipsHitCountTextlbl = New Windows.Forms.Label()
        opponentShipsMissCountTextlbl = New Windows.Forms.Label()
        opponentAccuracylbl = New Windows.Forms.Label()
        opponentHitCountlbl = New Windows.Forms.Label()
        opponentMissCountlbl = New Windows.Forms.Label()
        opponentStatslbl = New Windows.Forms.Label()
        CType(backgroundpb, ComponentModel.ISupportInitialize).BeginInit()
        CType(playerBoardpb, ComponentModel.ISupportInitialize).BeginInit()
        CType(opponentBoardpb, ComponentModel.ISupportInitialize).BeginInit()
        CType(turnsBannerpb, ComponentModel.ISupportInitialize).BeginInit()
        CType(opponentShip2pb, ComponentModel.ISupportInitialize).BeginInit()
        CType(opponentShip3apb, ComponentModel.ISupportInitialize).BeginInit()
        CType(opponentShip3bpb, ComponentModel.ISupportInitialize).BeginInit()
        CType(opponentShip4pb, ComponentModel.ISupportInitialize).BeginInit()
        CType(opponentShip5pb, ComponentModel.ISupportInitialize).BeginInit()
        CType(playerShip5pb, ComponentModel.ISupportInitialize).BeginInit()
        CType(playerShip4pb, ComponentModel.ISupportInitialize).BeginInit()
        CType(playerShip3bpb, ComponentModel.ISupportInitialize).BeginInit()
        CType(playerShip3apb, ComponentModel.ISupportInitialize).BeginInit()
        CType(playerShip2pb, ComponentModel.ISupportInitialize).BeginInit()
        CType(keyBluepb, ComponentModel.ISupportInitialize).BeginInit()
        CType(keyRedpb, ComponentModel.ISupportInitialize).BeginInit()
        keypnl.SuspendLayout()
        playerStatspnl.SuspendLayout()
        opponentStatspnl.SuspendLayout()
        SuspendLayout()
        ' 
        ' backgroundpb
        ' 
        backgroundpb.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\bdum3ufq.wjq\\Pictures\WaterBoard.png"
        backgroundpb.Location = New Point(12, 12)
        backgroundpb.Name = "backgroundpb"
        backgroundpb.Size = New Size(100, 50)
        backgroundpb.SizeMode = PictureBoxSizeMode.StretchImage
        backgroundpb.TabIndex = 0
        backgroundpb.TabStop = False
        ' 
        ' playerBoardpb
        ' 
        playerBoardpb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerBoardpb.BackgroundImageLayout = ImageLayout.Stretch
        playerBoardpb.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\bdum3ufq.wjq\\Pictures\Board.png"
        playerBoardpb.Location = New Point(688, 610)
        playerBoardpb.Name = "playerBoardpb"
        playerBoardpb.Size = New Size(100, 50)
        playerBoardpb.SizeMode = PictureBoxSizeMode.StretchImage
        playerBoardpb.TabIndex = 8
        playerBoardpb.TabStop = False
        ' 
        ' opponentBoardpb
        ' 
        opponentBoardpb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentBoardpb.BackgroundImageLayout = ImageLayout.Stretch
        opponentBoardpb.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\bdum3ufq.wjq\\Pictures\Board.png"
        opponentBoardpb.Location = New Point(688, 175)
        opponentBoardpb.Name = "opponentBoardpb"
        opponentBoardpb.Size = New Size(100, 50)
        opponentBoardpb.SizeMode = PictureBoxSizeMode.StretchImage
        opponentBoardpb.TabIndex = 9
        opponentBoardpb.TabStop = False
        ' 
        ' turnsBannerpb
        ' 
        turnsBannerpb.BackColor = Color.FromArgb(CByte(156), CByte(156), CByte(156))
        turnsBannerpb.BackgroundImageLayout = ImageLayout.None
        turnsBannerpb.Location = New Point(688, 395)
        turnsBannerpb.Name = "turnsBannerpb"
        turnsBannerpb.Size = New Size(100, 50)
        turnsBannerpb.SizeMode = PictureBoxSizeMode.StretchImage
        turnsBannerpb.TabIndex = 10
        turnsBannerpb.TabStop = False
        ' 
        ' timelbl
        ' 
        timelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timelbl.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point)
        timelbl.ForeColor = Color.Red
        timelbl.ImageAlign = ContentAlignment.BottomCenter
        timelbl.Location = New Point(716, 821)
        timelbl.Margin = New Padding(0)
        timelbl.Name = "timelbl"
        timelbl.Size = New Size(100, 23)
        timelbl.TabIndex = 11
        timelbl.Text = "00:00"
        ' 
        ' playernamelbl
        ' 
        playernamelbl.AutoSize = True
        playernamelbl.BackColor = Color.Transparent
        playernamelbl.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point)
        playernamelbl.ForeColor = Color.Black
        playernamelbl.Location = New Point(307, 634)
        playernamelbl.Name = "playernamelbl"
        playernamelbl.Size = New Size(160, 26)
        playernamelbl.TabIndex = 12
        playernamelbl.Text = "Player's Board"
        ' 
        ' playerscorelbl
        ' 
        playerscorelbl.AutoSize = True
        playerscorelbl.BackColor = Color.Transparent
        playerscorelbl.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point)
        playerscorelbl.ForeColor = Color.Black
        playerscorelbl.Location = New Point(365, 660)
        playerscorelbl.Name = "playerscorelbl"
        playerscorelbl.Size = New Size(79, 26)
        playerscorelbl.TabIndex = 13
        playerscorelbl.Text = "Score:"
        ' 
        ' playerScoreTextlbl
        ' 
        playerScoreTextlbl.AutoSize = True
        playerScoreTextlbl.BackColor = Color.Transparent
        playerScoreTextlbl.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        playerScoreTextlbl.ForeColor = Color.Black
        playerScoreTextlbl.Location = New Point(450, 662)
        playerScoreTextlbl.Name = "playerScoreTextlbl"
        playerScoreTextlbl.Size = New Size(22, 24)
        playerScoreTextlbl.TabIndex = 14
        playerScoreTextlbl.Text = "0"
        ' 
        ' opponentnamelbl
        ' 
        opponentnamelbl.AutoSize = True
        opponentnamelbl.BackColor = Color.Transparent
        opponentnamelbl.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point)
        opponentnamelbl.ForeColor = Color.Black
        opponentnamelbl.Location = New Point(307, 175)
        opponentnamelbl.Name = "opponentnamelbl"
        opponentnamelbl.Size = New Size(198, 26)
        opponentnamelbl.TabIndex = 16
        opponentnamelbl.Text = "Opponent's Board"
        ' 
        ' opponentscorelbl
        ' 
        opponentscorelbl.AutoSize = True
        opponentscorelbl.BackColor = Color.Transparent
        opponentscorelbl.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point)
        opponentscorelbl.ForeColor = Color.Black
        opponentscorelbl.Location = New Point(365, 210)
        opponentscorelbl.Name = "opponentscorelbl"
        opponentscorelbl.Size = New Size(79, 26)
        opponentscorelbl.TabIndex = 17
        opponentscorelbl.Text = "Score:"
        ' 
        ' opponentScoreTextlbl
        ' 
        opponentScoreTextlbl.AutoSize = True
        opponentScoreTextlbl.BackColor = Color.Transparent
        opponentScoreTextlbl.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        opponentScoreTextlbl.ForeColor = Color.Black
        opponentScoreTextlbl.Location = New Point(446, 212)
        opponentScoreTextlbl.Name = "opponentScoreTextlbl"
        opponentScoreTextlbl.Size = New Size(22, 24)
        opponentScoreTextlbl.TabIndex = 18
        opponentScoreTextlbl.Text = "0"
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
        backToMainbtn.Location = New Point(1398, 821)
        backToMainbtn.Margin = New Padding(0)
        backToMainbtn.Name = "backToMainbtn"
        backToMainbtn.Size = New Size(80, 23)
        backToMainbtn.TabIndex = 7
        backToMainbtn.Text = "EXIT"
        backToMainbtn.UseVisualStyleBackColor = False
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
        resetbtn.Location = New Point(1297, 821)
        resetbtn.Margin = New Padding(0)
        resetbtn.Name = "resetbtn"
        resetbtn.Size = New Size(80, 23)
        resetbtn.TabIndex = 19
        resetbtn.Text = "RESET"
        resetbtn.UseVisualStyleBackColor = False
        ' 
        ' opponentShip2pb
        ' 
        opponentShip2pb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentShip2pb.Image = My.Resources.Resources.BattleShip2
        opponentShip2pb.Location = New Point(60, 395)
        opponentShip2pb.Name = "opponentShip2pb"
        opponentShip2pb.Size = New Size(100, 50)
        opponentShip2pb.SizeMode = PictureBoxSizeMode.StretchImage
        opponentShip2pb.TabIndex = 20
        opponentShip2pb.TabStop = False
        ' 
        ' opponentShip3apb
        ' 
        opponentShip3apb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentShip3apb.Image = My.Resources.Resources.BattleShip3
        opponentShip3apb.Location = New Point(60, 395)
        opponentShip3apb.Name = "opponentShip3apb"
        opponentShip3apb.Size = New Size(100, 50)
        opponentShip3apb.SizeMode = PictureBoxSizeMode.StretchImage
        opponentShip3apb.TabIndex = 21
        opponentShip3apb.TabStop = False
        ' 
        ' opponentShip3bpb
        ' 
        opponentShip3bpb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentShip3bpb.Image = My.Resources.Resources.BattleShip3
        opponentShip3bpb.Location = New Point(60, 395)
        opponentShip3bpb.Name = "opponentShip3bpb"
        opponentShip3bpb.Size = New Size(100, 50)
        opponentShip3bpb.SizeMode = PictureBoxSizeMode.StretchImage
        opponentShip3bpb.TabIndex = 22
        opponentShip3bpb.TabStop = False
        ' 
        ' opponentShip4pb
        ' 
        opponentShip4pb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentShip4pb.Image = My.Resources.Resources.BattleShip4
        opponentShip4pb.Location = New Point(60, 395)
        opponentShip4pb.Name = "opponentShip4pb"
        opponentShip4pb.Size = New Size(100, 50)
        opponentShip4pb.SizeMode = PictureBoxSizeMode.StretchImage
        opponentShip4pb.TabIndex = 23
        opponentShip4pb.TabStop = False
        ' 
        ' opponentShip5pb
        ' 
        opponentShip5pb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        opponentShip5pb.Image = My.Resources.Resources.BattleShip5
        opponentShip5pb.Location = New Point(60, 395)
        opponentShip5pb.Name = "opponentShip5pb"
        opponentShip5pb.Size = New Size(100, 50)
        opponentShip5pb.SizeMode = PictureBoxSizeMode.StretchImage
        opponentShip5pb.TabIndex = 24
        opponentShip5pb.TabStop = False
        ' 
        ' playerShip5pb
        ' 
        playerShip5pb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerShip5pb.Image = My.Resources.Resources.BattleShip5
        playerShip5pb.Location = New Point(60, 395)
        playerShip5pb.Name = "playerShip5pb"
        playerShip5pb.Size = New Size(100, 50)
        playerShip5pb.SizeMode = PictureBoxSizeMode.StretchImage
        playerShip5pb.TabIndex = 29
        playerShip5pb.TabStop = False
        ' 
        ' playerShip4pb
        ' 
        playerShip4pb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerShip4pb.Image = My.Resources.Resources.BattleShip4
        playerShip4pb.Location = New Point(60, 395)
        playerShip4pb.Name = "playerShip4pb"
        playerShip4pb.Size = New Size(100, 50)
        playerShip4pb.SizeMode = PictureBoxSizeMode.StretchImage
        playerShip4pb.TabIndex = 28
        playerShip4pb.TabStop = False
        ' 
        ' playerShip3bpb
        ' 
        playerShip3bpb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerShip3bpb.Image = My.Resources.Resources.BattleShip3
        playerShip3bpb.Location = New Point(60, 395)
        playerShip3bpb.Name = "playerShip3bpb"
        playerShip3bpb.Size = New Size(100, 50)
        playerShip3bpb.SizeMode = PictureBoxSizeMode.StretchImage
        playerShip3bpb.TabIndex = 27
        playerShip3bpb.TabStop = False
        ' 
        ' playerShip3apb
        ' 
        playerShip3apb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerShip3apb.Image = My.Resources.Resources.BattleShip3
        playerShip3apb.Location = New Point(60, 395)
        playerShip3apb.Name = "playerShip3apb"
        playerShip3apb.Size = New Size(100, 50)
        playerShip3apb.SizeMode = PictureBoxSizeMode.StretchImage
        playerShip3apb.TabIndex = 26
        playerShip3apb.TabStop = False
        ' 
        ' playerShip2pb
        ' 
        playerShip2pb.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playerShip2pb.Image = My.Resources.Resources.BattleShip2
        playerShip2pb.Location = New Point(60, 395)
        playerShip2pb.Name = "playerShip2pb"
        playerShip2pb.Size = New Size(100, 50)
        playerShip2pb.SizeMode = PictureBoxSizeMode.StretchImage
        playerShip2pb.TabIndex = 25
        playerShip2pb.TabStop = False
        ' 
        ' keyBluepb
        ' 
        keyBluepb.BackColor = Color.Transparent
        keyBluepb.Image = My.Resources.Resources.BlueCircle
        keyBluepb.Location = New Point(34, 60)
        keyBluepb.Name = "keyBluepb"
        keyBluepb.Size = New Size(40, 40)
        keyBluepb.SizeMode = PictureBoxSizeMode.StretchImage
        keyBluepb.TabIndex = 30
        keyBluepb.TabStop = False
        ' 
        ' keyTitlelbl
        ' 
        keyTitlelbl.AutoSize = True
        keyTitlelbl.BackColor = Color.Transparent
        keyTitlelbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        keyTitlelbl.Location = New Point(22, 26)
        keyTitlelbl.Name = "keyTitlelbl"
        keyTitlelbl.Size = New Size(38, 21)
        keyTitlelbl.TabIndex = 31
        keyTitlelbl.Text = "Key"
        ' 
        ' keyMisslbl
        ' 
        keyMisslbl.AutoSize = True
        keyMisslbl.BackColor = Color.Transparent
        keyMisslbl.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        keyMisslbl.Location = New Point(80, 70)
        keyMisslbl.Name = "keyMisslbl"
        keyMisslbl.Size = New Size(37, 19)
        keyMisslbl.TabIndex = 32
        keyMisslbl.Text = "Miss"
        ' 
        ' keyHitlbl
        ' 
        keyHitlbl.AutoSize = True
        keyHitlbl.BackColor = Color.Transparent
        keyHitlbl.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        keyHitlbl.Location = New Point(80, 116)
        keyHitlbl.Name = "keyHitlbl"
        keyHitlbl.Size = New Size(27, 19)
        keyHitlbl.TabIndex = 34
        keyHitlbl.Text = "Hit"
        ' 
        ' keyRedpb
        ' 
        keyRedpb.BackColor = Color.Transparent
        keyRedpb.Image = My.Resources.Resources.RedCircle
        keyRedpb.Location = New Point(34, 106)
        keyRedpb.Name = "keyRedpb"
        keyRedpb.Size = New Size(40, 40)
        keyRedpb.SizeMode = PictureBoxSizeMode.StretchImage
        keyRedpb.TabIndex = 33
        keyRedpb.TabStop = False
        ' 
        ' keypnl
        ' 
        keypnl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        keypnl.Controls.Add(keyHitlbl)
        keypnl.Controls.Add(keyRedpb)
        keypnl.Controls.Add(keyMisslbl)
        keypnl.Controls.Add(keyTitlelbl)
        keypnl.Controls.Add(keyBluepb)
        keypnl.Location = New Point(38, 215)
        keypnl.Name = "keypnl"
        keypnl.Size = New Size(145, 161)
        keypnl.TabIndex = 35
        ' 
        ' gameTimer
        ' 
        gameTimer.Enabled = True
        ' 
        ' playerStatspnl
        ' 
        playerStatspnl.BackColor = Color.FromArgb(CByte(175), CByte(215), CByte(240))
        playerStatspnl.BackgroundImageLayout = ImageLayout.None
        playerStatspnl.Controls.Add(playerShipsLeftCountTextlbl)
        playerStatspnl.Controls.Add(playerShipsHitCountTextlbl)
        playerStatspnl.Controls.Add(shipsLeftlbl)
        playerStatspnl.Controls.Add(shipHitlbl)
        playerStatspnl.Controls.Add(playerAccuracyCountTextlbl)
        playerStatspnl.Controls.Add(playerHitCountTextlbl)
        playerStatspnl.Controls.Add(playerMissCountTextlbl)
        playerStatspnl.Controls.Add(playerAccuracylbl)
        playerStatspnl.Controls.Add(playerHitCountlbl)
        playerStatspnl.Controls.Add(playerMissCountlbl)
        playerStatspnl.Controls.Add(playerStatslbl)
        playerStatspnl.Location = New Point(1020, 45)
        playerStatspnl.Name = "playerStatspnl"
        playerStatspnl.Size = New Size(279, 306)
        playerStatspnl.TabIndex = 36
        ' 
        ' playerShipsLeftCountTextlbl
        ' 
        playerShipsLeftCountTextlbl.AutoSize = True
        playerShipsLeftCountTextlbl.BackColor = Color.Transparent
        playerShipsLeftCountTextlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerShipsLeftCountTextlbl.Location = New Point(119, 210)
        playerShipsLeftCountTextlbl.Name = "playerShipsLeftCountTextlbl"
        playerShipsLeftCountTextlbl.Size = New Size(19, 21)
        playerShipsLeftCountTextlbl.TabIndex = 42
        playerShipsLeftCountTextlbl.Text = "0"
        ' 
        ' playerShipsHitCountTextlbl
        ' 
        playerShipsHitCountTextlbl.AutoSize = True
        playerShipsHitCountTextlbl.BackColor = Color.Transparent
        playerShipsHitCountTextlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerShipsHitCountTextlbl.Location = New Point(119, 170)
        playerShipsHitCountTextlbl.Name = "playerShipsHitCountTextlbl"
        playerShipsHitCountTextlbl.Size = New Size(19, 21)
        playerShipsHitCountTextlbl.TabIndex = 41
        playerShipsHitCountTextlbl.Text = "0"
        ' 
        ' shipsLeftlbl
        ' 
        shipsLeftlbl.AutoSize = True
        shipsLeftlbl.BackColor = Color.Transparent
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
        shipHitlbl.BackColor = Color.Transparent
        shipHitlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        shipHitlbl.Location = New Point(25, 170)
        shipHitlbl.Name = "shipHitlbl"
        shipHitlbl.Size = New Size(90, 21)
        shipHitlbl.TabIndex = 39
        shipHitlbl.Text = "Ships Sunk:"
        ' 
        ' playerAccuracyCountTextlbl
        ' 
        playerAccuracyCountTextlbl.AutoSize = True
        playerAccuracyCountTextlbl.BackColor = Color.Transparent
        playerAccuracyCountTextlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerAccuracyCountTextlbl.Location = New Point(119, 130)
        playerAccuracyCountTextlbl.Name = "playerAccuracyCountTextlbl"
        playerAccuracyCountTextlbl.Size = New Size(16, 21)
        playerAccuracyCountTextlbl.TabIndex = 38
        playerAccuracyCountTextlbl.Text = "-"
        ' 
        ' playerHitCountTextlbl
        ' 
        playerHitCountTextlbl.AutoSize = True
        playerHitCountTextlbl.BackColor = Color.Transparent
        playerHitCountTextlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerHitCountTextlbl.Location = New Point(119, 90)
        playerHitCountTextlbl.Name = "playerHitCountTextlbl"
        playerHitCountTextlbl.Size = New Size(19, 21)
        playerHitCountTextlbl.TabIndex = 37
        playerHitCountTextlbl.Text = "0"
        ' 
        ' playerMissCountTextlbl
        ' 
        playerMissCountTextlbl.AutoSize = True
        playerMissCountTextlbl.BackColor = Color.Transparent
        playerMissCountTextlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerMissCountTextlbl.Location = New Point(119, 50)
        playerMissCountTextlbl.Name = "playerMissCountTextlbl"
        playerMissCountTextlbl.Size = New Size(19, 21)
        playerMissCountTextlbl.TabIndex = 36
        playerMissCountTextlbl.Text = "0"
        ' 
        ' playerAccuracylbl
        ' 
        playerAccuracylbl.AutoSize = True
        playerAccuracylbl.BackColor = Color.Transparent
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
        playerHitCountlbl.BackColor = Color.Transparent
        playerHitCountlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerHitCountlbl.Location = New Point(24, 90)
        playerHitCountlbl.Name = "playerHitCountlbl"
        playerHitCountlbl.Size = New Size(40, 21)
        playerHitCountlbl.TabIndex = 34
        playerHitCountlbl.Text = "Hits:"
        ' 
        ' playerMissCountlbl
        ' 
        playerMissCountlbl.AutoSize = True
        playerMissCountlbl.BackColor = Color.Transparent
        playerMissCountlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        playerMissCountlbl.Location = New Point(25, 50)
        playerMissCountlbl.Name = "playerMissCountlbl"
        playerMissCountlbl.Size = New Size(60, 21)
        playerMissCountlbl.TabIndex = 32
        playerMissCountlbl.Text = "Misses:"
        ' 
        ' playerStatslbl
        ' 
        playerStatslbl.AutoSize = True
        playerStatslbl.BackColor = Color.Transparent
        playerStatslbl.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        playerStatslbl.Location = New Point(15, 12)
        playerStatslbl.Name = "playerStatslbl"
        playerStatslbl.Size = New Size(124, 28)
        playerStatslbl.TabIndex = 31
        playerStatslbl.Text = "Player Stats"
        ' 
        ' opponentStatspnl
        ' 
        opponentStatspnl.BackColor = Color.FromArgb(CByte(175), CByte(215), CByte(240))
        opponentStatspnl.BackgroundImageLayout = ImageLayout.None
        opponentStatspnl.Controls.Add(opponentAccuracyCountTextlbl)
        opponentStatspnl.Controls.Add(opponentShipsHitCountTextlbl)
        opponentStatspnl.Controls.Add(opponentShipsMissCountTextlbl)
        opponentStatspnl.Controls.Add(opponentAccuracylbl)
        opponentStatspnl.Controls.Add(opponentHitCountlbl)
        opponentStatspnl.Controls.Add(opponentMissCountlbl)
        opponentStatspnl.Controls.Add(opponentStatslbl)
        opponentStatspnl.Location = New Point(1020, 560)
        opponentStatspnl.Name = "opponentStatspnl"
        opponentStatspnl.Size = New Size(188, 179)
        opponentStatspnl.TabIndex = 43
        ' 
        ' opponentAccuracyCountTextlbl
        ' 
        opponentAccuracyCountTextlbl.AutoSize = True
        opponentAccuracyCountTextlbl.BackColor = Color.Transparent
        opponentAccuracyCountTextlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        opponentAccuracyCountTextlbl.Location = New Point(119, 130)
        opponentAccuracyCountTextlbl.Name = "opponentAccuracyCountTextlbl"
        opponentAccuracyCountTextlbl.Size = New Size(16, 21)
        opponentAccuracyCountTextlbl.TabIndex = 38
        opponentAccuracyCountTextlbl.Text = "-"
        ' 
        ' opponentShipsHitCountTextlbl
        ' 
        opponentShipsHitCountTextlbl.AutoSize = True
        opponentShipsHitCountTextlbl.BackColor = Color.Transparent
        opponentShipsHitCountTextlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        opponentShipsHitCountTextlbl.Location = New Point(119, 90)
        opponentShipsHitCountTextlbl.Name = "opponentShipsHitCountTextlbl"
        opponentShipsHitCountTextlbl.Size = New Size(19, 21)
        opponentShipsHitCountTextlbl.TabIndex = 37
        opponentShipsHitCountTextlbl.Text = "0"
        ' 
        ' opponentShipsMissCountTextlbl
        ' 
        opponentShipsMissCountTextlbl.AutoSize = True
        opponentShipsMissCountTextlbl.BackColor = Color.Transparent
        opponentShipsMissCountTextlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        opponentShipsMissCountTextlbl.Location = New Point(119, 50)
        opponentShipsMissCountTextlbl.Name = "opponentShipsMissCountTextlbl"
        opponentShipsMissCountTextlbl.Size = New Size(19, 21)
        opponentShipsMissCountTextlbl.TabIndex = 36
        opponentShipsMissCountTextlbl.Text = "0"
        ' 
        ' opponentAccuracylbl
        ' 
        opponentAccuracylbl.AutoSize = True
        opponentAccuracylbl.BackColor = Color.Transparent
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
        opponentHitCountlbl.BackColor = Color.Transparent
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
        opponentMissCountlbl.BackColor = Color.Transparent
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
        opponentStatslbl.BackColor = Color.Transparent
        opponentStatslbl.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        opponentStatslbl.Location = New Point(15, 12)
        opponentStatslbl.Name = "opponentStatslbl"
        opponentStatslbl.Size = New Size(159, 28)
        opponentStatslbl.TabIndex = 31
        opponentStatslbl.Text = "Opponent Stats"
        ' 
        ' battleshipGamefrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 876)
        Controls.Add(opponentStatspnl)
        Controls.Add(playerStatspnl)
        Controls.Add(keypnl)
        Controls.Add(playerShip5pb)
        Controls.Add(playerShip4pb)
        Controls.Add(playerShip3bpb)
        Controls.Add(playerShip3apb)
        Controls.Add(playerShip2pb)
        Controls.Add(opponentShip5pb)
        Controls.Add(opponentShip4pb)
        Controls.Add(opponentShip3bpb)
        Controls.Add(opponentShip3apb)
        Controls.Add(opponentShip2pb)
        Controls.Add(resetbtn)
        Controls.Add(opponentScoreTextlbl)
        Controls.Add(opponentscorelbl)
        Controls.Add(opponentnamelbl)
        Controls.Add(playerScoreTextlbl)
        Controls.Add(playerscorelbl)
        Controls.Add(playernamelbl)
        Controls.Add(timelbl)
        Controls.Add(turnsBannerpb)
        Controls.Add(opponentBoardpb)
        Controls.Add(playerBoardpb)
        Controls.Add(backToMainbtn)
        Controls.Add(backgroundpb)
        HelpButton = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "battleshipGamefrm"
        Text = "Battleship"
        TopMost = True
        CType(backgroundpb, ComponentModel.ISupportInitialize).EndInit()
        CType(playerBoardpb, ComponentModel.ISupportInitialize).EndInit()
        CType(opponentBoardpb, ComponentModel.ISupportInitialize).EndInit()
        CType(turnsBannerpb, ComponentModel.ISupportInitialize).EndInit()
        CType(opponentShip2pb, ComponentModel.ISupportInitialize).EndInit()
        CType(opponentShip3apb, ComponentModel.ISupportInitialize).EndInit()
        CType(opponentShip3bpb, ComponentModel.ISupportInitialize).EndInit()
        CType(opponentShip4pb, ComponentModel.ISupportInitialize).EndInit()
        CType(opponentShip5pb, ComponentModel.ISupportInitialize).EndInit()
        CType(playerShip5pb, ComponentModel.ISupportInitialize).EndInit()
        CType(playerShip4pb, ComponentModel.ISupportInitialize).EndInit()
        CType(playerShip3bpb, ComponentModel.ISupportInitialize).EndInit()
        CType(playerShip3apb, ComponentModel.ISupportInitialize).EndInit()
        CType(playerShip2pb, ComponentModel.ISupportInitialize).EndInit()
        CType(keyBluepb, ComponentModel.ISupportInitialize).EndInit()
        CType(keyRedpb, ComponentModel.ISupportInitialize).EndInit()
        keypnl.ResumeLayout(False)
        keypnl.PerformLayout()
        playerStatspnl.ResumeLayout(False)
        playerStatspnl.PerformLayout()
        opponentStatspnl.ResumeLayout(False)
        opponentStatspnl.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backgroundpb As PictureBox
    Friend WithEvents playerBoardpb As PictureBox
    Friend WithEvents opponentBoardpb As PictureBox
    Friend WithEvents turnsBannerpb As PictureBox
    Friend WithEvents timelbl As Windows.Forms.Label
    Friend WithEvents playernamelbl As Windows.Forms.Label
    Friend WithEvents playerscorelbl As Windows.Forms.Label
    Friend WithEvents playerScoreTextlbl As Windows.Forms.Label
    Friend WithEvents opponentnamelbl As Windows.Forms.Label
    Friend WithEvents opponentscorelbl As Windows.Forms.Label
    Friend WithEvents opponentScoreTextlbl As Windows.Forms.Label
    Friend WithEvents backToMainbtn As Button
    Friend WithEvents resetbtn As Button
    Friend WithEvents opponentShip2pb As PictureBox
    Friend WithEvents opponentShip3apb As PictureBox
    Friend WithEvents opponentShip3bpb As PictureBox
    Friend WithEvents opponentShip4pb As PictureBox
    Friend WithEvents opponentShip5pb As PictureBox
    Friend WithEvents playerShip5pb As PictureBox
    Friend WithEvents playerShip4pb As PictureBox
    Friend WithEvents playerShip3bpb As PictureBox
    Friend WithEvents playerShip3apb As PictureBox
    Friend WithEvents playerShip2pb As PictureBox
    Friend WithEvents keyBluepb As PictureBox
    Friend WithEvents keyTitlelbl As Windows.Forms.Label
    Friend WithEvents keyMisslbl As Windows.Forms.Label
    Friend WithEvents keyHitlbl As Windows.Forms.Label
    Friend WithEvents keyRedpb As PictureBox
    Friend WithEvents keypnl As Panel
    Friend WithEvents gameTimer As Timer
    Friend WithEvents playerStatspnl As Panel
    Friend WithEvents playerMissCountTextlbl As Windows.Forms.Label
    Friend WithEvents playerAccuracylbl As Windows.Forms.Label
    Friend WithEvents playerHitCountlbl As Windows.Forms.Label
    Friend WithEvents playerMissCountlbl As Windows.Forms.Label
    Friend WithEvents playerStatslbl As Windows.Forms.Label
    Friend WithEvents playerAccuracyCountTextlbl As Windows.Forms.Label
    Friend WithEvents playerHitCountTextlbl As Windows.Forms.Label
    Friend WithEvents shipHitlbl As Windows.Forms.Label
    Friend WithEvents shipsLeftlbl As Windows.Forms.Label
    Friend WithEvents playerShipsLeftCountTextlbl As Windows.Forms.Label
    Friend WithEvents playerShipsHitCountTextlbl As Windows.Forms.Label
    Friend WithEvents opponentStatspnl As Panel
    Friend WithEvents opponentAccuracyCountTextlbl As Windows.Forms.Label
    Friend WithEvents opponentShipsHitCountTextlbl As Windows.Forms.Label
    Friend WithEvents opponentShipsMissCountTextlbl As Windows.Forms.Label
    Friend WithEvents opponentAccuracylbl As Windows.Forms.Label
    Friend WithEvents opponentHitCountlbl As Windows.Forms.Label
    Friend WithEvents opponentMissCountlbl As Windows.Forms.Label
    Friend WithEvents opponentStatslbl As Windows.Forms.Label
End Class
