<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class install
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(install))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.NextButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.messageLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.BackColor = System.Drawing.Color.White
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 74)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(447, 85)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Please connect your device, but don't disconnect it unless instructed! A backup w" &
    "ill be made in case anything goes wrong, so you can return your device to a work" &
    "ing state."
        '
        'NextButton
        '
        Me.NextButton.Depth = 0
        Me.NextButton.Location = New System.Drawing.Point(306, 435)
        Me.NextButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Primary = True
        Me.NextButton.Size = New System.Drawing.Size(162, 33)
        Me.NextButton.TabIndex = 6
        Me.NextButton.Text = "Install LineageOS"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 399)
        Me.ProgressBar1.Maximum = 4
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(443, 10)
        Me.ProgressBar1.TabIndex = 7
        '
        'messageLabel
        '
        Me.messageLabel.BackColor = System.Drawing.Color.White
        Me.messageLabel.Depth = 0
        Me.messageLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.messageLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.messageLabel.Location = New System.Drawing.Point(12, 247)
        Me.messageLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(447, 99)
        Me.messageLabel.TabIndex = 9
        Me.messageLabel.Text = resources.GetString("messageLabel.Text")
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(165, 327)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(294, 36)
        Me.MaterialFlatButton1.TabIndex = 10
        Me.MaterialFlatButton1.Text = "I've re-enabled USB Debugging; proceed "
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'install
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 480)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "install"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Install LineageOS!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents NextButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents messageLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
