<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScoresForm
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
        WaterBoarder = New PictureBox()
        backtomainbtn = New Button()
        p1namelbl = New Label()
        p3namelbl = New Label()
        p2namelbl = New Label()
        ranklbl1 = New Label()
        ranklbl2 = New Label()
        ranklbl3 = New Label()
        ranklbl4 = New Label()
        ranklbl5 = New Label()
        ranklbl6 = New Label()
        ranklbl7 = New Label()
        ranklbl8 = New Label()
        ranklbl9 = New Label()
        ranklbl10 = New Label()
        p4namelbl = New Label()
        p5namelbl = New Label()
        p6namelbl = New Label()
        p7namelbl = New Label()
        p8namelbl = New Label()
        p9namelbl = New Label()
        p10namelbl = New Label()
        rankingpanel = New Panel()
        rankslbl = New Label()
        namepanel = New Panel()
        namelbl = New Label()
        p1scorelbl = New Label()
        p2scorelbl = New Label()
        p3scorelbl = New Label()
        p4scorelbl = New Label()
        p5scorelbl = New Label()
        p6scorelbl = New Label()
        p7scorelbl = New Label()
        p8scorelbl = New Label()
        p9scorelbl = New Label()
        p10scorelbl = New Label()
        scorepanel = New Panel()
        Label1 = New Label()
        scorebtn = New PictureBox()
        p1timelbl = New Label()
        p2timelbl = New Label()
        p3timelbl = New Label()
        p6timelbl = New Label()
        p5timelbl = New Label()
        p4timelbl = New Label()
        p9timelbl = New Label()
        p8timelbl = New Label()
        p7timelbl = New Label()
        p10timelbl = New Label()
        timepanel = New Panel()
        timelbl = New Label()
        timebtn = New PictureBox()
        Titlelbl = New Label()
        subtitlelbl = New Label()
        backgroundMapImg = New PictureBox()
        CType(WaterBoarder, ComponentModel.ISupportInitialize).BeginInit()
        rankingpanel.SuspendLayout()
        namepanel.SuspendLayout()
        scorepanel.SuspendLayout()
        CType(scorebtn, ComponentModel.ISupportInitialize).BeginInit()
        timepanel.SuspendLayout()
        CType(timebtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(backgroundMapImg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WaterBoarder
        ' 
        WaterBoarder.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\5rql1nrc.he4\\Pictures\WaterBoard.png"
        WaterBoarder.Location = New Point(12, 12)
        WaterBoarder.Name = "WaterBoarder"
        WaterBoarder.Size = New Size(300, 300)
        WaterBoarder.SizeMode = PictureBoxSizeMode.StretchImage
        WaterBoarder.TabIndex = 0
        WaterBoarder.TabStop = False
        ' 
        ' backtomainbtn
        ' 
        backtomainbtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        backtomainbtn.BackgroundImage = My.Resources.Resources.smallButtonBlue
        backtomainbtn.BackgroundImageLayout = ImageLayout.Stretch
        backtomainbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        backtomainbtn.FlatAppearance.BorderSize = 0
        backtomainbtn.FlatStyle = FlatStyle.Flat
        backtomainbtn.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        backtomainbtn.ForeColor = SystemColors.ButtonHighlight
        backtomainbtn.Location = New Point(1386, 791)
        backtomainbtn.Margin = New Padding(0)
        backtomainbtn.Name = "backtomainbtn"
        backtomainbtn.Size = New Size(80, 26)
        backtomainbtn.TabIndex = 7
        backtomainbtn.Text = "EXIT"
        backtomainbtn.UseVisualStyleBackColor = False
        ' 
        ' p1namelbl
        ' 
        p1namelbl.AutoSize = True
        p1namelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p1namelbl.Location = New Point(63, 55)
        p1namelbl.Name = "p1namelbl"
        p1namelbl.Size = New Size(62, 21)
        p1namelbl.TabIndex = 9
        p1namelbl.Text = "player1"
        ' 
        ' p3namelbl
        ' 
        p3namelbl.AutoSize = True
        p3namelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p3namelbl.Location = New Point(63, 135)
        p3namelbl.Name = "p3namelbl"
        p3namelbl.Size = New Size(62, 21)
        p3namelbl.TabIndex = 10
        p3namelbl.Text = "player3"
        ' 
        ' p2namelbl
        ' 
        p2namelbl.AutoSize = True
        p2namelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p2namelbl.Location = New Point(63, 95)
        p2namelbl.Name = "p2namelbl"
        p2namelbl.Size = New Size(62, 21)
        p2namelbl.TabIndex = 11
        p2namelbl.Text = "player2"
        ' 
        ' ranklbl1
        ' 
        ranklbl1.AutoSize = True
        ranklbl1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ranklbl1.Location = New Point(63, 60)
        ranklbl1.Name = "ranklbl1"
        ranklbl1.Size = New Size(19, 21)
        ranklbl1.TabIndex = 12
        ranklbl1.Text = "1"
        ' 
        ' ranklbl2
        ' 
        ranklbl2.AutoSize = True
        ranklbl2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ranklbl2.Location = New Point(63, 100)
        ranklbl2.Name = "ranklbl2"
        ranklbl2.Size = New Size(19, 21)
        ranklbl2.TabIndex = 13
        ranklbl2.Text = "2"
        ' 
        ' ranklbl3
        ' 
        ranklbl3.AutoSize = True
        ranklbl3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ranklbl3.Location = New Point(63, 140)
        ranklbl3.Name = "ranklbl3"
        ranklbl3.Size = New Size(19, 21)
        ranklbl3.TabIndex = 14
        ranklbl3.Text = "3"
        ' 
        ' ranklbl4
        ' 
        ranklbl4.AutoSize = True
        ranklbl4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ranklbl4.Location = New Point(63, 180)
        ranklbl4.Name = "ranklbl4"
        ranklbl4.Size = New Size(19, 21)
        ranklbl4.TabIndex = 15
        ranklbl4.Text = "4"
        ' 
        ' ranklbl5
        ' 
        ranklbl5.AutoSize = True
        ranklbl5.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ranklbl5.Location = New Point(63, 220)
        ranklbl5.Name = "ranklbl5"
        ranklbl5.Size = New Size(19, 21)
        ranklbl5.TabIndex = 16
        ranklbl5.Text = "5"
        ' 
        ' ranklbl6
        ' 
        ranklbl6.AutoSize = True
        ranklbl6.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ranklbl6.Location = New Point(63, 260)
        ranklbl6.Name = "ranklbl6"
        ranklbl6.Size = New Size(19, 21)
        ranklbl6.TabIndex = 17
        ranklbl6.Text = "6"
        ' 
        ' ranklbl7
        ' 
        ranklbl7.AutoSize = True
        ranklbl7.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ranklbl7.Location = New Point(63, 300)
        ranklbl7.Name = "ranklbl7"
        ranklbl7.Size = New Size(19, 21)
        ranklbl7.TabIndex = 18
        ranklbl7.Text = "7"
        ' 
        ' ranklbl8
        ' 
        ranklbl8.AutoSize = True
        ranklbl8.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ranklbl8.Location = New Point(63, 340)
        ranklbl8.Name = "ranklbl8"
        ranklbl8.Size = New Size(19, 21)
        ranklbl8.TabIndex = 19
        ranklbl8.Text = "8"
        ' 
        ' ranklbl9
        ' 
        ranklbl9.AutoSize = True
        ranklbl9.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ranklbl9.Location = New Point(63, 380)
        ranklbl9.Name = "ranklbl9"
        ranklbl9.Size = New Size(19, 21)
        ranklbl9.TabIndex = 20
        ranklbl9.Text = "9"
        ' 
        ' ranklbl10
        ' 
        ranklbl10.AutoSize = True
        ranklbl10.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ranklbl10.Location = New Point(54, 420)
        ranklbl10.Name = "ranklbl10"
        ranklbl10.Size = New Size(28, 21)
        ranklbl10.TabIndex = 21
        ranklbl10.Text = "10"
        ' 
        ' p4namelbl
        ' 
        p4namelbl.AutoSize = True
        p4namelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p4namelbl.Location = New Point(63, 175)
        p4namelbl.Name = "p4namelbl"
        p4namelbl.Size = New Size(62, 21)
        p4namelbl.TabIndex = 22
        p4namelbl.Text = "player4"
        ' 
        ' p5namelbl
        ' 
        p5namelbl.AutoSize = True
        p5namelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p5namelbl.Location = New Point(63, 215)
        p5namelbl.Name = "p5namelbl"
        p5namelbl.Size = New Size(62, 21)
        p5namelbl.TabIndex = 23
        p5namelbl.Text = "player5"
        ' 
        ' p6namelbl
        ' 
        p6namelbl.AutoSize = True
        p6namelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p6namelbl.Location = New Point(63, 257)
        p6namelbl.Name = "p6namelbl"
        p6namelbl.Size = New Size(62, 21)
        p6namelbl.TabIndex = 24
        p6namelbl.Text = "player6"
        ' 
        ' p7namelbl
        ' 
        p7namelbl.AutoSize = True
        p7namelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p7namelbl.Location = New Point(63, 300)
        p7namelbl.Name = "p7namelbl"
        p7namelbl.Size = New Size(62, 21)
        p7namelbl.TabIndex = 25
        p7namelbl.Text = "player7"
        ' 
        ' p8namelbl
        ' 
        p8namelbl.AutoSize = True
        p8namelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p8namelbl.Location = New Point(63, 340)
        p8namelbl.Name = "p8namelbl"
        p8namelbl.Size = New Size(62, 21)
        p8namelbl.TabIndex = 26
        p8namelbl.Text = "player8"
        ' 
        ' p9namelbl
        ' 
        p9namelbl.AutoSize = True
        p9namelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p9namelbl.Location = New Point(63, 380)
        p9namelbl.Name = "p9namelbl"
        p9namelbl.Size = New Size(62, 21)
        p9namelbl.TabIndex = 27
        p9namelbl.Text = "player9"
        ' 
        ' p10namelbl
        ' 
        p10namelbl.AutoSize = True
        p10namelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p10namelbl.Location = New Point(63, 420)
        p10namelbl.Name = "p10namelbl"
        p10namelbl.Size = New Size(71, 21)
        p10namelbl.TabIndex = 28
        p10namelbl.Text = "player10"
        ' 
        ' rankingpanel
        ' 
        rankingpanel.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        rankingpanel.Controls.Add(rankslbl)
        rankingpanel.Controls.Add(ranklbl10)
        rankingpanel.Controls.Add(ranklbl9)
        rankingpanel.Controls.Add(ranklbl8)
        rankingpanel.Controls.Add(ranklbl7)
        rankingpanel.Controls.Add(ranklbl6)
        rankingpanel.Controls.Add(ranklbl5)
        rankingpanel.Controls.Add(ranklbl4)
        rankingpanel.Controls.Add(ranklbl3)
        rankingpanel.Controls.Add(ranklbl2)
        rankingpanel.Controls.Add(ranklbl1)
        rankingpanel.Location = New Point(417, 303)
        rankingpanel.Name = "rankingpanel"
        rankingpanel.Size = New Size(165, 453)
        rankingpanel.TabIndex = 29
        ' 
        ' rankslbl
        ' 
        rankslbl.AutoSize = True
        rankslbl.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point)
        rankslbl.Location = New Point(42, 9)
        rankslbl.Name = "rankslbl"
        rankslbl.Size = New Size(68, 28)
        rankslbl.TabIndex = 22
        rankslbl.Text = "Ranks"
        ' 
        ' namepanel
        ' 
        namepanel.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        namepanel.Controls.Add(namelbl)
        namepanel.Controls.Add(p10namelbl)
        namepanel.Controls.Add(p9namelbl)
        namepanel.Controls.Add(p8namelbl)
        namepanel.Controls.Add(p7namelbl)
        namepanel.Controls.Add(p6namelbl)
        namepanel.Controls.Add(p5namelbl)
        namepanel.Controls.Add(p4namelbl)
        namepanel.Controls.Add(p2namelbl)
        namepanel.Controls.Add(p3namelbl)
        namepanel.Controls.Add(p1namelbl)
        namepanel.Location = New Point(588, 303)
        namepanel.Name = "namepanel"
        namepanel.Size = New Size(165, 453)
        namepanel.TabIndex = 30
        ' 
        ' namelbl
        ' 
        namelbl.AutoSize = True
        namelbl.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point)
        namelbl.Location = New Point(48, 9)
        namelbl.Name = "namelbl"
        namelbl.Size = New Size(77, 28)
        namelbl.TabIndex = 23
        namelbl.Text = "Names"
        ' 
        ' p1scorelbl
        ' 
        p1scorelbl.AutoSize = True
        p1scorelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p1scorelbl.Location = New Point(75, 55)
        p1scorelbl.Name = "p1scorelbl"
        p1scorelbl.Size = New Size(19, 21)
        p1scorelbl.TabIndex = 29
        p1scorelbl.Text = "0"
        ' 
        ' p2scorelbl
        ' 
        p2scorelbl.AutoSize = True
        p2scorelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p2scorelbl.Location = New Point(75, 95)
        p2scorelbl.Name = "p2scorelbl"
        p2scorelbl.Size = New Size(19, 21)
        p2scorelbl.TabIndex = 31
        p2scorelbl.Text = "0"
        ' 
        ' p3scorelbl
        ' 
        p3scorelbl.AutoSize = True
        p3scorelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p3scorelbl.Location = New Point(75, 135)
        p3scorelbl.Name = "p3scorelbl"
        p3scorelbl.Size = New Size(19, 21)
        p3scorelbl.TabIndex = 32
        p3scorelbl.Text = "0"
        ' 
        ' p4scorelbl
        ' 
        p4scorelbl.AutoSize = True
        p4scorelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p4scorelbl.Location = New Point(75, 175)
        p4scorelbl.Name = "p4scorelbl"
        p4scorelbl.Size = New Size(19, 21)
        p4scorelbl.TabIndex = 33
        p4scorelbl.Text = "0"
        ' 
        ' p5scorelbl
        ' 
        p5scorelbl.AutoSize = True
        p5scorelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p5scorelbl.Location = New Point(75, 220)
        p5scorelbl.Name = "p5scorelbl"
        p5scorelbl.Size = New Size(19, 21)
        p5scorelbl.TabIndex = 34
        p5scorelbl.Text = "0"
        ' 
        ' p6scorelbl
        ' 
        p6scorelbl.AutoSize = True
        p6scorelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p6scorelbl.Location = New Point(75, 260)
        p6scorelbl.Name = "p6scorelbl"
        p6scorelbl.Size = New Size(19, 21)
        p6scorelbl.TabIndex = 35
        p6scorelbl.Text = "0"
        ' 
        ' p7scorelbl
        ' 
        p7scorelbl.AutoSize = True
        p7scorelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p7scorelbl.Location = New Point(75, 300)
        p7scorelbl.Name = "p7scorelbl"
        p7scorelbl.Size = New Size(19, 21)
        p7scorelbl.TabIndex = 36
        p7scorelbl.Text = "0"
        ' 
        ' p8scorelbl
        ' 
        p8scorelbl.AutoSize = True
        p8scorelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p8scorelbl.Location = New Point(75, 340)
        p8scorelbl.Name = "p8scorelbl"
        p8scorelbl.Size = New Size(19, 21)
        p8scorelbl.TabIndex = 37
        p8scorelbl.Text = "0"
        ' 
        ' p9scorelbl
        ' 
        p9scorelbl.AutoSize = True
        p9scorelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p9scorelbl.Location = New Point(75, 380)
        p9scorelbl.Name = "p9scorelbl"
        p9scorelbl.Size = New Size(19, 21)
        p9scorelbl.TabIndex = 38
        p9scorelbl.Text = "0"
        ' 
        ' p10scorelbl
        ' 
        p10scorelbl.AutoSize = True
        p10scorelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p10scorelbl.Location = New Point(75, 420)
        p10scorelbl.Name = "p10scorelbl"
        p10scorelbl.Size = New Size(19, 21)
        p10scorelbl.TabIndex = 39
        p10scorelbl.Text = "0"
        ' 
        ' scorepanel
        ' 
        scorepanel.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        scorepanel.Controls.Add(Label1)
        scorepanel.Controls.Add(scorebtn)
        scorepanel.Controls.Add(p10scorelbl)
        scorepanel.Controls.Add(p9scorelbl)
        scorepanel.Controls.Add(p8scorelbl)
        scorepanel.Controls.Add(p7scorelbl)
        scorepanel.Controls.Add(p6scorelbl)
        scorepanel.Controls.Add(p5scorelbl)
        scorepanel.Controls.Add(p4scorelbl)
        scorepanel.Controls.Add(p3scorelbl)
        scorepanel.Controls.Add(p2scorelbl)
        scorepanel.Controls.Add(p1scorelbl)
        scorepanel.Location = New Point(759, 303)
        scorepanel.Name = "scorepanel"
        scorepanel.Size = New Size(165, 453)
        scorepanel.TabIndex = 40
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(45, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 28)
        Label1.TabIndex = 29
        Label1.Text = "Scores"
        ' 
        ' scorebtn
        ' 
        scorebtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        scorebtn.Image = My.Resources.Resources.BlackDownArrow
        scorebtn.Location = New Point(115, 9)
        scorebtn.Name = "scorebtn"
        scorebtn.Size = New Size(21, 32)
        scorebtn.SizeMode = PictureBoxSizeMode.StretchImage
        scorebtn.TabIndex = 55
        scorebtn.TabStop = False
        ' 
        ' p1timelbl
        ' 
        p1timelbl.AutoSize = True
        p1timelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p1timelbl.Location = New Point(62, 55)
        p1timelbl.Name = "p1timelbl"
        p1timelbl.Size = New Size(49, 21)
        p1timelbl.TabIndex = 40
        p1timelbl.Text = "00:00"
        ' 
        ' p2timelbl
        ' 
        p2timelbl.AutoSize = True
        p2timelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p2timelbl.Location = New Point(62, 95)
        p2timelbl.Name = "p2timelbl"
        p2timelbl.Size = New Size(49, 21)
        p2timelbl.TabIndex = 41
        p2timelbl.Text = "00:00"
        ' 
        ' p3timelbl
        ' 
        p3timelbl.AutoSize = True
        p3timelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p3timelbl.Location = New Point(62, 135)
        p3timelbl.Name = "p3timelbl"
        p3timelbl.Size = New Size(49, 21)
        p3timelbl.TabIndex = 42
        p3timelbl.Text = "00:00"
        ' 
        ' p6timelbl
        ' 
        p6timelbl.AutoSize = True
        p6timelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p6timelbl.Location = New Point(62, 260)
        p6timelbl.Name = "p6timelbl"
        p6timelbl.Size = New Size(49, 21)
        p6timelbl.TabIndex = 45
        p6timelbl.Text = "00:00"
        ' 
        ' p5timelbl
        ' 
        p5timelbl.AutoSize = True
        p5timelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p5timelbl.Location = New Point(62, 220)
        p5timelbl.Name = "p5timelbl"
        p5timelbl.Size = New Size(49, 21)
        p5timelbl.TabIndex = 44
        p5timelbl.Text = "00:00"
        ' 
        ' p4timelbl
        ' 
        p4timelbl.AutoSize = True
        p4timelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p4timelbl.Location = New Point(62, 180)
        p4timelbl.Name = "p4timelbl"
        p4timelbl.Size = New Size(49, 21)
        p4timelbl.TabIndex = 43
        p4timelbl.Text = "00:00"
        ' 
        ' p9timelbl
        ' 
        p9timelbl.AutoSize = True
        p9timelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p9timelbl.Location = New Point(62, 380)
        p9timelbl.Name = "p9timelbl"
        p9timelbl.Size = New Size(49, 21)
        p9timelbl.TabIndex = 48
        p9timelbl.Text = "00:00"
        ' 
        ' p8timelbl
        ' 
        p8timelbl.AutoSize = True
        p8timelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p8timelbl.Location = New Point(62, 340)
        p8timelbl.Name = "p8timelbl"
        p8timelbl.Size = New Size(49, 21)
        p8timelbl.TabIndex = 47
        p8timelbl.Text = "00:00"
        ' 
        ' p7timelbl
        ' 
        p7timelbl.AutoSize = True
        p7timelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p7timelbl.Location = New Point(62, 300)
        p7timelbl.Name = "p7timelbl"
        p7timelbl.Size = New Size(49, 21)
        p7timelbl.TabIndex = 46
        p7timelbl.Text = "00:00"
        ' 
        ' p10timelbl
        ' 
        p10timelbl.AutoSize = True
        p10timelbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        p10timelbl.Location = New Point(62, 420)
        p10timelbl.Name = "p10timelbl"
        p10timelbl.Size = New Size(49, 21)
        p10timelbl.TabIndex = 49
        p10timelbl.Text = "00:00"
        ' 
        ' timepanel
        ' 
        timepanel.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timepanel.Controls.Add(timelbl)
        timepanel.Controls.Add(timebtn)
        timepanel.Controls.Add(p10timelbl)
        timepanel.Controls.Add(p9timelbl)
        timepanel.Controls.Add(p8timelbl)
        timepanel.Controls.Add(p7timelbl)
        timepanel.Controls.Add(p6timelbl)
        timepanel.Controls.Add(p5timelbl)
        timepanel.Controls.Add(p4timelbl)
        timepanel.Controls.Add(p3timelbl)
        timepanel.Controls.Add(p2timelbl)
        timepanel.Controls.Add(p1timelbl)
        timepanel.Location = New Point(930, 303)
        timepanel.Name = "timepanel"
        timepanel.Size = New Size(165, 453)
        timepanel.TabIndex = 50
        ' 
        ' timelbl
        ' 
        timelbl.AutoSize = True
        timelbl.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point)
        timelbl.Location = New Point(52, 9)
        timelbl.Name = "timelbl"
        timelbl.Size = New Size(68, 28)
        timelbl.TabIndex = 40
        timelbl.Text = "Times"
        timelbl.UseWaitCursor = True
        ' 
        ' timebtn
        ' 
        timebtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        timebtn.Image = My.Resources.Resources.BlackDownArrow
        timebtn.Location = New Point(116, 9)
        timebtn.Name = "timebtn"
        timebtn.Size = New Size(21, 32)
        timebtn.SizeMode = PictureBoxSizeMode.StretchImage
        timebtn.TabIndex = 56
        timebtn.TabStop = False
        ' 
        ' Titlelbl
        ' 
        Titlelbl.AutoSize = True
        Titlelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        Titlelbl.Font = New Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point)
        Titlelbl.Location = New Point(588, 125)
        Titlelbl.Name = "Titlelbl"
        Titlelbl.Size = New Size(336, 71)
        Titlelbl.TabIndex = 51
        Titlelbl.Text = "BATTLESHIP"
        ' 
        ' subtitlelbl
        ' 
        subtitlelbl.AutoSize = True
        subtitlelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        subtitlelbl.Font = New Font("Segoe UI", 30.0F, FontStyle.Italic, GraphicsUnit.Point)
        subtitlelbl.Location = New Point(671, 200)
        subtitlelbl.Name = "subtitlelbl"
        subtitlelbl.Size = New Size(208, 54)
        subtitlelbl.TabIndex = 52
        subtitlelbl.Text = "Highscores"
        ' 
        ' backgroundMapImg
        ' 
        backgroundMapImg.Location = New Point(372, 155)
        backgroundMapImg.Name = "backgroundMapImg"
        backgroundMapImg.Size = New Size(100, 50)
        backgroundMapImg.SizeMode = PictureBoxSizeMode.StretchImage
        backgroundMapImg.TabIndex = 57
        backgroundMapImg.TabStop = False
        ' 
        ' HighScoresForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 876)
        Controls.Add(subtitlelbl)
        Controls.Add(Titlelbl)
        Controls.Add(timepanel)
        Controls.Add(scorepanel)
        Controls.Add(namepanel)
        Controls.Add(rankingpanel)
        Controls.Add(backtomainbtn)
        Controls.Add(WaterBoarder)
        Controls.Add(backgroundMapImg)
        HelpButton = True
        MinimizeBox = False
        Name = "HighScoresForm"
        Text = "High Scores"
        TopMost = True
        CType(WaterBoarder, ComponentModel.ISupportInitialize).EndInit()
        rankingpanel.ResumeLayout(False)
        rankingpanel.PerformLayout()
        namepanel.ResumeLayout(False)
        namepanel.PerformLayout()
        scorepanel.ResumeLayout(False)
        scorepanel.PerformLayout()
        CType(scorebtn, ComponentModel.ISupportInitialize).EndInit()
        timepanel.ResumeLayout(False)
        timepanel.PerformLayout()
        CType(timebtn, ComponentModel.ISupportInitialize).EndInit()
        CType(backgroundMapImg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents WaterBoarder As PictureBox
    Friend WithEvents backtomainbtn As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents p1namelbl As Label
    Friend WithEvents p3namelbl As Label
    Friend WithEvents p2namelbl As Label
    Friend WithEvents ranklbl1 As Label
    Friend WithEvents ranklbl2 As Label
    Friend WithEvents ranklbl3 As Label
    Friend WithEvents ranklbl4 As Label
    Friend WithEvents ranklbl5 As Label
    Friend WithEvents ranklbl6 As Label
    Friend WithEvents ranklbl7 As Label
    Friend WithEvents ranklbl8 As Label
    Friend WithEvents ranklbl9 As Label
    Friend WithEvents ranklbl10 As Label
    Friend WithEvents p4namelbl As Label
    Friend WithEvents p5namelbl As Label
    Friend WithEvents p6namelbl As Label
    Friend WithEvents p7namelbl As Label
    Friend WithEvents p8namelbl As Label
    Friend WithEvents p9namelbl As Label
    Friend WithEvents p10namelbl As Label
    Friend WithEvents rankingpanel As Panel
    Friend WithEvents namepanel As Panel
    Friend WithEvents p1scorelbl As Label
    Friend WithEvents p2scorelbl As Label
    Friend WithEvents p3scorelbl As Label
    Friend WithEvents p4scorelbl As Label
    Friend WithEvents p5scorelbl As Label
    Friend WithEvents p6scorelbl As Label
    Friend WithEvents p7scorelbl As Label
    Friend WithEvents p8scorelbl As Label
    Friend WithEvents p9scorelbl As Label
    Friend WithEvents p10scorelbl As Label
    Friend WithEvents scorepanel As Panel
    Friend WithEvents p1timelbl As Label
    Friend WithEvents p2timelbl As Label
    Friend WithEvents p3timelbl As Label
    Friend WithEvents p6timelbl As Label
    Friend WithEvents p5timelbl As Label
    Friend WithEvents p4timelbl As Label
    Friend WithEvents p9timelbl As Label
    Friend WithEvents p8timelbl As Label
    Friend WithEvents p7timelbl As Label
    Friend WithEvents p10timelbl As Label
    Friend WithEvents timepanel As Panel
    Friend WithEvents rankslbl As Label
    Friend WithEvents namelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents timelbl As Label
    Friend WithEvents Titlelbl As Label
    Friend WithEvents subtitlelbl As Label
    Friend WithEvents scorebtn As PictureBox
    Friend WithEvents timebtn As PictureBox
    Friend WithEvents backgroundMapImg As PictureBox
End Class
