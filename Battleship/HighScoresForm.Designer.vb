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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(HighScoresForm))
        WaterBoarder = New PictureBox()
        backtomainbtn = New Button()
        CType(WaterBoarder, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WaterBoarder
        ' 
        WaterBoarder.ImageLocation = Application.StartupPath & "\Pictures\WaterBoard.png"
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
        backtomainbtn.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        backtomainbtn.ForeColor = SystemColors.ButtonHighlight
        backtomainbtn.Location = New Point(716, 425)
        backtomainbtn.Margin = New Padding(0)
        backtomainbtn.Name = "backtomainbtn"
        backtomainbtn.Size = New Size(80, 26)
        backtomainbtn.TabIndex = 7
        backtomainbtn.Text = "EXIT"
        backtomainbtn.UseVisualStyleBackColor = False
        ' 
        ' HighScoresForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(85), CByte(84))
        ClientSize = New Size(1512, 876)
        Controls.Add(backtomainbtn)
        Controls.Add(WaterBoarder)
        HelpButton = True
        MinimizeBox = False
        Name = "HighScoresForm"
        Text = "High Scores"
        TopMost = True
        CType(WaterBoarder, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents WaterBoarder As PictureBox
    Friend WithEvents backtomainbtn As Button
End Class
