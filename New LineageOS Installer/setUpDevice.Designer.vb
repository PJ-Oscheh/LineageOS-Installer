<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setUpDevice
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
        Me.components = New System.ComponentModel.Container()
        Me.NextButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.WebControl1 = New Awesomium.Windows.Forms.WebControl(Me.components)
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
        Me.NextButton.TabIndex = 6
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'WebControl1
        '
        Me.WebControl1.Location = New System.Drawing.Point(12, 89)
        Me.WebControl1.Size = New System.Drawing.Size(456, 340)
        Me.WebControl1.Source = New System.Uri("file:///C:/Tools/LineageOSInstaller/Application-Files/setUpYourDevice.html", System.UriKind.Absolute)
        Me.WebControl1.TabIndex = 7
        '
        'setUpDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 480)
        Me.Controls.Add(Me.WebControl1)
        Me.Controls.Add(Me.NextButton)
        Me.Name = "setUpDevice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Up Your Device"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NextButton As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents WebControl1 As Awesomium.Windows.Forms.WebControl
End Class
