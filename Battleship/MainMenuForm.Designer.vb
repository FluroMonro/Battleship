﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainMenuForm))
        WaterBoarder = New PictureBox()
        Titlelbl = New Label()
        playfrommainbtn = New Button()
        openhsbutton = New Button()
        quitProgrambtn = New Button()
        CType(WaterBoarder, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WaterBoarder
        ' 
        WaterBoarder.ImageLocation = "\\?\C:\Users\ben\AppData\Local\Microsoft\VisualStudio\17.0_935cd82f\WinFormsDesigner\42okntgt.zbq\\Pictures\WaterBoard.png"
        WaterBoarder.Location = New Point(12, 12)
        WaterBoarder.Name = "WaterBoarder"
        WaterBoarder.Size = New Size(1488, 852)
        WaterBoarder.SizeMode = PictureBoxSizeMode.StretchImage
        WaterBoarder.TabIndex = 0
        WaterBoarder.TabStop = False
        ' 
        ' Titlelbl
        ' 
        Titlelbl.AutoSize = True
        Titlelbl.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        Titlelbl.Font = New Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point)
        Titlelbl.Location = New Point(615, 28)
        Titlelbl.Name = "Titlelbl"
        Titlelbl.Size = New Size(336, 71)
        Titlelbl.TabIndex = 1
        Titlelbl.Text = "BATTLESHIP"
        ' 
        ' playfrommainbtn
        ' 
        playfrommainbtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        playfrommainbtn.BackgroundImage = CType(resources.GetObject("playfrommainbtn.BackgroundImage"), Image)
        playfrommainbtn.BackgroundImageLayout = ImageLayout.Stretch
        playfrommainbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        playfrommainbtn.FlatAppearance.BorderSize = 0
        playfrommainbtn.FlatStyle = FlatStyle.Flat
        playfrommainbtn.Font = New Font("Arial", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        playfrommainbtn.ForeColor = SystemColors.ButtonHighlight
        playfrommainbtn.Location = New Point(654, 155)
        playfrommainbtn.Margin = New Padding(0)
        playfrommainbtn.Name = "playfrommainbtn"
        playfrommainbtn.Size = New Size(250, 50)
        playfrommainbtn.TabIndex = 2
        playfrommainbtn.Text = "PLAY"
        playfrommainbtn.UseVisualStyleBackColor = False
        ' 
        ' openhsbutton
        ' 
        openhsbutton.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        openhsbutton.BackgroundImage = CType(resources.GetObject("openhsbutton.BackgroundImage"), Image)
        openhsbutton.BackgroundImageLayout = ImageLayout.Stretch
        openhsbutton.FlatAppearance.BorderSize = 0
        openhsbutton.FlatStyle = FlatStyle.Flat
        openhsbutton.Font = New Font("Arial", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        openhsbutton.ForeColor = SystemColors.ButtonHighlight
        openhsbutton.Location = New Point(654, 293)
        openhsbutton.Name = "openhsbutton"
        openhsbutton.Size = New Size(250, 50)
        openhsbutton.TabIndex = 3
        openhsbutton.Text = "HIGH SCORES"
        openhsbutton.TextImageRelation = TextImageRelation.ImageBeforeText
        openhsbutton.UseVisualStyleBackColor = False
        ' 
        ' quitProgrambtn
        ' 
        quitProgrambtn.BackColor = Color.FromArgb(CByte(173), CByte(215), CByte(240))
        quitProgrambtn.BackgroundImage = CType(resources.GetObject("quitProgrambtn.BackgroundImage"), Image)
        quitProgrambtn.BackgroundImageLayout = ImageLayout.Stretch
        quitProgrambtn.FlatAppearance.BorderColor = Color.Lime
        quitProgrambtn.FlatAppearance.BorderSize = 0
        quitProgrambtn.FlatStyle = FlatStyle.Flat
        quitProgrambtn.Font = New Font("Arial", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        quitProgrambtn.ForeColor = SystemColors.ButtonHighlight
        quitProgrambtn.Location = New Point(654, 452)
        quitProgrambtn.Name = "quitProgrambtn"
        quitProgrambtn.Size = New Size(250, 50)
        quitProgrambtn.TabIndex = 4
        quitProgrambtn.Text = "QUIT"
        quitProgrambtn.UseVisualStyleBackColor = False
        ' 
        ' MainMenuForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 876)
        Controls.Add(quitProgrambtn)
        Controls.Add(openhsbutton)
        Controls.Add(playfrommainbtn)
        Controls.Add(Titlelbl)
        Controls.Add(WaterBoarder)
        HelpButton = True
        MinimizeBox = False
        Name = "MainMenuForm"
        Text = "Main Menu"
        TopMost = True
        CType(WaterBoarder, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents WaterBoarder As PictureBox
    Friend WithEvents Titlelbl As Label
    Friend WithEvents playfrommainbtn As Button
    Friend WithEvents openhsbutton As Button
    Friend WithEvents quitProgrambtn As Button
End Class