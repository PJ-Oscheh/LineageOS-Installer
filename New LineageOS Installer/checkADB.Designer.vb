<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkADB
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checkADB))
        Me.mainLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.fileLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.warningImg = New System.Windows.Forms.PictureBox()
        Me.issueText = New MaterialSkin.Controls.MaterialLabel()
        Me.errorLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.NextButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        CType(Me.warningImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainLabel
        '
        Me.mainLabel.BackColor = System.Drawing.Color.White
        Me.mainLabel.Depth = 0
        Me.mainLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.mainLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mainLabel.Location = New System.Drawing.Point(12, 92)
        Me.mainLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.mainLabel.Name = "mainLabel"
        Me.mainLabel.Size = New System.Drawing.Size(366, 35)
        Me.mainLabel.TabIndex = 0
        Me.mainLabel.Text = "Just making sure everything is in the right place..."
        '
        'fileLabel
        '
        Me.fileLabel.AutoSize = True
        Me.fileLabel.Depth = 0
        Me.fileLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.fileLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fileLabel.Location = New System.Drawing.Point(12, 443)
        Me.fileLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.fileLabel.Name = "fileLabel"
        Me.fileLabel.Size = New System.Drawing.Size(33, 19)
        Me.fileLabel.TabIndex = 1
        Me.fileLabel.Text = "File"
        '
        'warningImg
        '
        Me.warningImg.BackColor = System.Drawing.Color.White
        Me.warningImg.Image = CType(resources.GetObject("warningImg.Image"), System.Drawing.Image)
        Me.warningImg.Location = New System.Drawing.Point(8, 77)
        Me.warningImg.Name = "warningImg"
        Me.warningImg.Size = New System.Drawing.Size(50, 50)
        Me.warningImg.TabIndex = 2
        Me.warningImg.TabStop = False
        '
        'issueText
        '
        Me.issueText.AutoSize = True
        Me.issueText.BackColor = System.Drawing.Color.White
        Me.issueText.Depth = 0
        Me.issueText.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.issueText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.issueText.Location = New System.Drawing.Point(59, 83)
        Me.issueText.MouseState = MaterialSkin.MouseState.HOVER
        Me.issueText.Name = "issueText"
        Me.issueText.Size = New System.Drawing.Size(207, 19)
        Me.issueText.TabIndex = 3
        Me.issueText.Text = "The installation cannot begin."
        '
        'errorLabel
        '
        Me.errorLabel.BackColor = System.Drawing.Color.White
        Me.errorLabel.Depth = 0
        Me.errorLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.errorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.errorLabel.Location = New System.Drawing.Point(16, 201)
        Me.errorLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(452, 182)
        Me.errorLabel.TabIndex = 4
        Me.errorLabel.Text = "Error"
        '
        'NextButton
        '
        Me.NextButton.Depth = 0
        Me.NextButton.Location = New System.Drawing.Point(389, 435)
        Me.NextButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Primary = True
        Me.NextButton.Size = New System.Drawing.Size(79, 33)
        Me.NextButton.TabIndex = 5
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(8, 426)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(461, 1)
        Me.MaterialDivider1.TabIndex = 6
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'checkADB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 480)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.issueText)
        Me.Controls.Add(Me.warningImg)
        Me.Controls.Add(Me.fileLabel)
        Me.Controls.Add(Me.mainLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "checkADB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Making sure you have your files..."
        CType(Me.warningImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents fileLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents warningImg As PictureBox
    Friend WithEvents issueText As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents errorLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents NextButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
End Class
