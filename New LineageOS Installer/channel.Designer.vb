<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class channel
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
        Me.stable = New MaterialSkin.Controls.MaterialRadioButton()
        Me.devel = New MaterialSkin.Controls.MaterialRadioButton()
        Me.NextButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.stableDesc = New MaterialSkin.Controls.MaterialLabel()
        Me.develDesc = New MaterialSkin.Controls.MaterialLabel()
        Me.skipFiles = New MaterialSkin.Controls.MaterialCheckBox()
        Me.jumpToInstall = New MaterialSkin.Controls.MaterialCheckBox()
        Me.SuspendLayout()
        '
        'stable
        '
        Me.stable.AutoSize = True
        Me.stable.BackColor = System.Drawing.Color.White
        Me.stable.Depth = 0
        Me.stable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stable.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.stable.Location = New System.Drawing.Point(30, 114)
        Me.stable.Margin = New System.Windows.Forms.Padding(0)
        Me.stable.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.stable.MouseState = MaterialSkin.MouseState.HOVER
        Me.stable.Name = "stable"
        Me.stable.Ripple = True
        Me.stable.Size = New System.Drawing.Size(68, 30)
        Me.stable.TabIndex = 0
        Me.stable.TabStop = True
        Me.stable.Text = "Stable"
        Me.stable.UseVisualStyleBackColor = False
        '
        'devel
        '
        Me.devel.AutoSize = True
        Me.devel.BackColor = System.Drawing.Color.White
        Me.devel.Depth = 0
        Me.devel.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.devel.Location = New System.Drawing.Point(30, 221)
        Me.devel.Margin = New System.Windows.Forms.Padding(0)
        Me.devel.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.devel.MouseState = MaterialSkin.MouseState.HOVER
        Me.devel.Name = "devel"
        Me.devel.Ripple = True
        Me.devel.Size = New System.Drawing.Size(90, 30)
        Me.devel.TabIndex = 1
        Me.devel.TabStop = True
        Me.devel.Text = "Advanced"
        Me.devel.UseVisualStyleBackColor = False
        '
        'NextButton
        '
        Me.NextButton.Depth = 0
        Me.NextButton.Location = New System.Drawing.Point(389, 435)
        Me.NextButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Primary = True
        Me.NextButton.Size = New System.Drawing.Size(79, 33)
        Me.NextButton.TabIndex = 2
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'stableDesc
        '
        Me.stableDesc.BackColor = System.Drawing.Color.White
        Me.stableDesc.Depth = 0
        Me.stableDesc.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.stableDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.stableDesc.Location = New System.Drawing.Point(26, 154)
        Me.stableDesc.MouseState = MaterialSkin.MouseState.HOVER
        Me.stableDesc.Name = "stableDesc"
        Me.stableDesc.Size = New System.Drawing.Size(442, 48)
        Me.stableDesc.TabIndex = 3
        Me.stableDesc.Text = "Automatically downloads all files. This option is recommended for most users. (St" &
    "able builds have not been released yet.)"
        '
        'develDesc
        '
        Me.develDesc.BackColor = System.Drawing.Color.White
        Me.develDesc.Depth = 0
        Me.develDesc.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.develDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.develDesc.Location = New System.Drawing.Point(26, 269)
        Me.develDesc.MouseState = MaterialSkin.MouseState.HOVER
        Me.develDesc.Name = "develDesc"
        Me.develDesc.Size = New System.Drawing.Size(442, 48)
        Me.develDesc.TabIndex = 4
        Me.develDesc.Text = "Choose what build of LineageOS, TWRP and GApps you want to use. This is recommend" &
    "ed for advanced users."
        '
        'skipFiles
        '
        Me.skipFiles.AutoSize = True
        Me.skipFiles.BackColor = System.Drawing.Color.White
        Me.skipFiles.Depth = 0
        Me.skipFiles.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.skipFiles.Location = New System.Drawing.Point(30, 362)
        Me.skipFiles.Margin = New System.Windows.Forms.Padding(0)
        Me.skipFiles.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.skipFiles.MouseState = MaterialSkin.MouseState.HOVER
        Me.skipFiles.Name = "skipFiles"
        Me.skipFiles.Ripple = True
        Me.skipFiles.Size = New System.Drawing.Size(124, 30)
        Me.skipFiles.TabIndex = 5
        Me.skipFiles.Text = "Skip File Check"
        Me.skipFiles.UseVisualStyleBackColor = False
        '
        'jumpToInstall
        '
        Me.jumpToInstall.AutoSize = True
        Me.jumpToInstall.BackColor = System.Drawing.Color.White
        Me.jumpToInstall.Depth = 0
        Me.jumpToInstall.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.jumpToInstall.Location = New System.Drawing.Point(30, 317)
        Me.jumpToInstall.Margin = New System.Windows.Forms.Padding(0)
        Me.jumpToInstall.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.jumpToInstall.MouseState = MaterialSkin.MouseState.HOVER
        Me.jumpToInstall.Name = "jumpToInstall"
        Me.jumpToInstall.Ripple = True
        Me.jumpToInstall.Size = New System.Drawing.Size(153, 30)
        Me.jumpToInstall.TabIndex = 6
        Me.jumpToInstall.Text = "Jump to Installation"
        Me.jumpToInstall.UseVisualStyleBackColor = False
        '
        'channel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 480)
        Me.Controls.Add(Me.jumpToInstall)
        Me.Controls.Add(Me.skipFiles)
        Me.Controls.Add(Me.develDesc)
        Me.Controls.Add(Me.stableDesc)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.devel)
        Me.Controls.Add(Me.stable)
        Me.Name = "channel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Your Installation Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents stable As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents devel As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents NextButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents stableDesc As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents develDesc As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents skipFiles As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents jumpToInstall As MaterialSkin.Controls.MaterialCheckBox
End Class
