<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class youNeed
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.NextButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.BackColor = System.Drawing.Color.White
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 86)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(413, 131)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "You will need the device you wish to install LineageOS on and a USB cable to conn" &
    "ect it to your PC (preferably the cable that came included)"
        '
        'NextButton
        '
        Me.NextButton.Depth = 0
        Me.NextButton.Location = New System.Drawing.Point(389, 435)
        Me.NextButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Primary = True
        Me.NextButton.Size = New System.Drawing.Size(79, 33)
        Me.NextButton.TabIndex = 1
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'youNeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 480)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "youNeed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prerequisits"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents NextButton As MaterialSkin.Controls.MaterialRaisedButton
End Class
