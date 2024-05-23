<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainMenufrm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(mainMenufrm))
        backgroundpb = New PictureBox()
        titlelbl = New Label()
        playfrommainbtn = New Button()
        openhsbtn = New Button()
        quitProgrambtn = New Button()
        CType(backgroundpb, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backgroundpb
        ' 
        backgroundpb.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\42okntgt.zbq\\Pictures\WaterBoard.png"
        backgroundpb.Location = New Point(12, 12)
        backgroundpb.Name = "backgroundpb"
        backgroundpb.Size = New Size(1488, 852)
        backgroundpb.SizeMode = PictureBoxSizeMode.StretchImage
        backgroundpb.TabIndex = 0
        backgroundpb.TabStop = False
        ' 
        ' titlelbl
        ' 
        titlelbl.AutoSize = True
        titlelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        titlelbl.Font = New Font("Candara Light", 39.75F, FontStyle.Bold, GraphicsUnit.Point)
        titlelbl.Location = New Point(615, 28)
        titlelbl.Name = "titlelbl"
        titlelbl.Size = New Size(305, 64)
        titlelbl.TabIndex = 1
        titlelbl.Text = "BATTLESHIP"
        ' 
        ' playfrommainbtn
        ' 
        playfrommainbtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playfrommainbtn.BackgroundImage = CType(resources.GetObject("playfrommainbtn.BackgroundImage"), Image)
        playfrommainbtn.BackgroundImageLayout = ImageLayout.Stretch
        playfrommainbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        playfrommainbtn.FlatAppearance.BorderSize = 0
        playfrommainbtn.FlatStyle = FlatStyle.Flat
        playfrommainbtn.Font = New Font("Candara", 23.25F, FontStyle.Bold, GraphicsUnit.Point)
        playfrommainbtn.ForeColor = SystemColors.ButtonHighlight
        playfrommainbtn.Location = New Point(654, 155)
        playfrommainbtn.Margin = New Padding(0)
        playfrommainbtn.Name = "playfrommainbtn"
        playfrommainbtn.Size = New Size(250, 50)
        playfrommainbtn.TabIndex = 2
        playfrommainbtn.Text = "PLAY"
        playfrommainbtn.UseVisualStyleBackColor = False
        ' 
        ' openhsbtn
        ' 
        openhsbtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        openhsbtn.BackgroundImage = CType(resources.GetObject("openhsbtn.BackgroundImage"), Image)
        openhsbtn.BackgroundImageLayout = ImageLayout.Stretch
        openhsbtn.FlatAppearance.BorderSize = 0
        openhsbtn.FlatStyle = FlatStyle.Flat
        openhsbtn.Font = New Font("Candara", 23.25F, FontStyle.Bold, GraphicsUnit.Point)
        openhsbtn.ForeColor = SystemColors.ButtonHighlight
        openhsbtn.Location = New Point(654, 293)
        openhsbtn.Name = "openhsbtn"
        openhsbtn.Size = New Size(250, 50)
        openhsbtn.TabIndex = 3
        openhsbtn.Text = "HIGH SCORES"
        openhsbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        openhsbtn.UseVisualStyleBackColor = False
        ' 
        ' quitProgrambtn
        ' 
        quitProgrambtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        quitProgrambtn.BackgroundImage = CType(resources.GetObject("quitProgrambtn.BackgroundImage"), Image)
        quitProgrambtn.BackgroundImageLayout = ImageLayout.Stretch
        quitProgrambtn.FlatAppearance.BorderColor = Color.Lime
        quitProgrambtn.FlatAppearance.BorderSize = 0
        quitProgrambtn.FlatStyle = FlatStyle.Flat
        quitProgrambtn.Font = New Font("Candara", 23.25F, FontStyle.Bold, GraphicsUnit.Point)
        quitProgrambtn.ForeColor = SystemColors.ButtonHighlight
        quitProgrambtn.Location = New Point(654, 452)
        quitProgrambtn.Name = "quitProgrambtn"
        quitProgrambtn.Size = New Size(250, 50)
        quitProgrambtn.TabIndex = 4
        quitProgrambtn.Text = "QUIT"
        quitProgrambtn.UseVisualStyleBackColor = False
        ' 
        ' mainMenufrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 876)
        Controls.Add(quitProgrambtn)
        Controls.Add(openhsbtn)
        Controls.Add(playfrommainbtn)
        Controls.Add(titlelbl)
        Controls.Add(backgroundpb)
        HelpButton = True
        MinimizeBox = False
        Name = "mainMenufrm"
        Text = "Main Menu"
        TopMost = True
        CType(backgroundpb, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backgroundpb As PictureBox
    Friend WithEvents titlelbl As Label
    Friend WithEvents playfrommainbtn As Button
    Friend WithEvents openhsbtn As Button
    Friend WithEvents quitProgrambtn As Button
End Class
