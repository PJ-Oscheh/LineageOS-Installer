<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.NextButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.WelcomeLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.LanguageButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'NextButton
        '
        Me.NextButton.Depth = 0
        Me.NextButton.Location = New System.Drawing.Point(389, 435)
        Me.NextButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Primary = True
        Me.NextButton.Size = New System.Drawing.Size(79, 33)
        Me.NextButton.TabIndex = 0
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.BackColor = System.Drawing.Color.White
        Me.WelcomeLabel.Depth = 0
        Me.WelcomeLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WelcomeLabel.Location = New System.Drawing.Point(68, 99)
        Me.WelcomeLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(345, 19)
        Me.WelcomeLabel.TabIndex = 1
        Me.WelcomeLabel.Text = "Welcome to LineageOS! Click ""Next to get started!"
        '
        'LanguageButton
        '
        Me.LanguageButton.AutoSize = True
        Me.LanguageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LanguageButton.Depth = 0
        Me.LanguageButton.Location = New System.Drawing.Point(13, 435)
        Me.LanguageButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.LanguageButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.LanguageButton.Name = "LanguageButton"
        Me.LanguageButton.Primary = False
        Me.LanguageButton.Size = New System.Drawing.Size(141, 36)
        Me.LanguageButton.TabIndex = 2
        Me.LanguageButton.Text = "Change Language"
        Me.LanguageButton.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.Color.White
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 410)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(220, 19)
        Me.MaterialLabel1.TabIndex = 3
        Me.MaterialLabel1.Text = "Version 2.0-privatedevelopment"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 480)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.LanguageButton)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.NextButton)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to LineageOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NextButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents WelcomeLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LanguageButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
