<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DownloadFiles
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownloadFiles))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lineageWebControl = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.NextButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.twrpWebControl = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.gappWebControl = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.lineageWeb = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.twrpWeb = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.gappsWeb = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.BackColor = System.Drawing.Color.White
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 87)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(667, 42)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Use the embedded browser below to download your files. You will download: the Lin" &
    "eageOS ROM, TWRP, and GApps. (If the page doesn't display correctly, click ""Open" &
    " in Browser."")"
        '
        'lineageWebControl
        '
        Me.lineageWebControl.Location = New System.Drawing.Point(16, 162)
        Me.lineageWebControl.Size = New System.Drawing.Size(1028, 236)
        Me.lineageWebControl.Source = New System.Uri("http://download.lineageos.org/", System.UriKind.Absolute)
        Me.lineageWebControl.TabIndex = 1
        '
        'NextButton
        '
        Me.NextButton.Depth = 0
        Me.NextButton.Location = New System.Drawing.Point(965, 650)
        Me.NextButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Primary = True
        Me.NextButton.Size = New System.Drawing.Size(79, 33)
        Me.NextButton.TabIndex = 2
        Me.NextButton.Text = "Next File"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'twrpWebControl
        '
        Me.twrpWebControl.Location = New System.Drawing.Point(12, 162)
        Me.twrpWebControl.Size = New System.Drawing.Size(1032, 236)
        Me.twrpWebControl.Source = New System.Uri("https://twrp.me/Devices/", System.UriKind.Absolute)
        Me.twrpWebControl.TabIndex = 3
        '
        'gappWebControl
        '
        Me.gappWebControl.Location = New System.Drawing.Point(16, 162)
        Me.gappWebControl.Size = New System.Drawing.Size(1028, 236)
        Me.gappWebControl.Source = New System.Uri("http://opengapps.org/", System.UriKind.Absolute)
        Me.gappWebControl.TabIndex = 4
        '
        'lineageWeb
        '
        Me.lineageWeb.Location = New System.Drawing.Point(16, 132)
        Me.lineageWeb.Size = New System.Drawing.Size(1028, 512)
        Me.lineageWeb.Source = New System.Uri("http://download.lineageos.org/", System.UriKind.Absolute)
        Me.lineageWeb.TabIndex = 3
        '
        'twrpWeb
        '
        Me.twrpWeb.Location = New System.Drawing.Point(16, 132)
        Me.twrpWeb.Size = New System.Drawing.Size(1028, 512)
        Me.twrpWeb.Source = New System.Uri("https://twrp.me/Devices/", System.UriKind.Absolute)
        Me.twrpWeb.TabIndex = 4
        '
        'gappsWeb
        '
        Me.gappsWeb.Location = New System.Drawing.Point(16, 132)
        Me.gappsWeb.Size = New System.Drawing.Size(1028, 512)
        Me.gappsWeb.Source = New System.Uri("http://opengapps.org/", System.UriKind.Absolute)
        Me.gappsWeb.TabIndex = 5
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 648)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(947, 57)
        Me.MaterialLabel2.TabIndex = 6
        Me.MaterialLabel2.Text = "NOTE: You MUST name: The LineageOS ZIP ""lineageos"", TWRP ""recovery"" and GApps ""ga" &
    "pps"" and put it all in C:\Tools\LineageOSInstaller\LinOS-Files"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(911, 79)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(132, 36)
        Me.MaterialFlatButton1.TabIndex = 7
        Me.MaterialFlatButton1.Text = "Open in Browser"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = False
        '
        'DownloadFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1056, 695)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.gappsWeb)
        Me.Controls.Add(Me.twrpWeb)
        Me.Controls.Add(Me.lineageWeb)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DownloadFiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Let's Download Your Files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents lineageWebControl As Awesomium.Windows.Forms.WebControl
    Friend WithEvents NextButton As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents twrpWebControl As Awesomium.Windows.Forms.WebControl
    Private WithEvents gappWebControl As Awesomium.Windows.Forms.WebControl
    Private WithEvents lineageWeb As Awesomium.Windows.Forms.WebControl
    Private WithEvents twrpWeb As Awesomium.Windows.Forms.WebControl
    Private WithEvents gappsWeb As Awesomium.Windows.Forms.WebControl
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
End Class
