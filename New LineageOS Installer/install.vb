Imports System.IO
Imports System.Threading

Public Class install
    Dim runningScript As Process
    Dim stepNumber As Integer
    Dim interval As New TimeSpan(0, 0, 1)



    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        NextButton.Hide()
        ADBCheck()

    End Sub
    Private Sub ADBCheck()
        runningScript = New Process
        runningScript.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\adb_check.bat"
        runningScript.Start()
        runningScript.EnableRaisingEvents = True
        AddHandler runningScript.Exited, AddressOf ADBCheckProcessExited
    End Sub

    Private Sub ADBCheckProcessExited(ByVal sender As Object, ByVal e As System.EventArgs)
        'Check if device is connected
        'Note: running the application from Visual Studio may fail at this point. If so, please build the application and run it.
        Dim lines() As String = IO.File.ReadAllLines("C:\Tools\LineageOSInstaller\scripts\adb_check_result.txt")

        If lines(1) = Nothing Then
            MsgBox("Please Connect your device.")
            ' Me.Invoke(Sub() ProgressBar1.Value = 0)
            ADBCheck()
        Else
            MsgBox("Your device was detected")
            '  Me.Invoke(Sub() ProgressBar1.Value = 1)
            Unlock_BL()
        End If


    End Sub
    Private Sub Unlock_BL()
        'Unlock Bootloader
        runningScript = New Process
        runningScript.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\unlock_bl.bat"
        runningScript.Start()
        runningScript.EnableRaisingEvents = True
        AddHandler runningScript.Exited, AddressOf Unlock_BLProcessExited
    End Sub
    Private Sub Unlock_BLProcessExited(sender As Object, e As EventArgs)
        notifUsbDebug.Visible = True
        notifUsbDebug.ShowBalloonTip(5000)

        Me.Invoke(Sub() ProgressBar1.Value = 2)

        Me.Invoke(Sub() messageLabel.Show())
        Me.Invoke(Sub() MaterialFlatButton1.Show())
    End Sub
    Private Sub install_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        notifUsbDebug.Icon = SystemIcons.Information
        notifUsbDebug.BalloonTipText = "Please enable USB Debugging when your device boots."
        notifUsbDebug.BalloonTipTitle = "Enable USB Debugging"
        notifUsbDebug.BalloonTipIcon = ToolTipIcon.Info

        PictureBox1.Hide()
        messageLabel.Hide()
        MaterialFlatButton1.Hide()
        stepNumber = 0
    End Sub



    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click

        If stepNumber = 0 Then
            'Flash recovery
            MaterialFlatButton1.Hide()
            messageLabel.Text = ""
            runningScript = New Process
            runningScript.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\flash_recovery.bat"
            runningScript.Start()
            runningScript.EnableRaisingEvents = True
            AddHandler runningScript.Exited, AddressOf Flash_RecoveryProcessExited
        End If
        If stepNumber = 1 Then

            Install_Lineage()
        End If
    End Sub
    Private Sub Flash_RecoveryProcessExited(sender As Object, e As EventArgs)
        Me.Invoke(Sub() ProgressBar1.Value = 3)
        stepNumber = 1
        Me.Invoke(Sub() PictureBox1.Show())
        Me.Invoke(Sub() messageLabel.Text = "Your device is about to boot into TWRP Recovery. Swipe to allow modifications. Please click the button below when the main screen (reference the image to the left) loads.")
        Me.Invoke(Sub() MaterialFlatButton1.Text = "Recovery has booted; proceed.")
        Me.Invoke(Sub() MaterialFlatButton1.Show())
    End Sub
    Private Sub Test_Twrp_Boot()
        'Sub isn't used; the twrp check occurs too early.
        runningScript = New Process
        runningScript.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\test_twrp_boot.bat"
        runningScript.Start()
        runningScript.EnableRaisingEvents = True
        AddHandler runningScript.Exited, AddressOf Test_Twrp_BootProcessExited
    End Sub
    Private Sub Test_Twrp_BootProcessExited(sender As Object, e As System.EventArgs)
        'Sub isn't used

        Dim infotxt As String = "C:\Tools\LineageOSInstaller\scripts\test_twrp_boot.txt"
        Dim tlines() As String = IO.File.ReadAllLines(infotxt)
        If File.ReadAllText(infotxt).Length = 0 Then

            Test_Twrp_Boot()
            Return

        End If
        If tlines(0) = "1" Then

            Install_Lineage()
            Return
        Else

            Test_Twrp_Boot()
            Return
        End If


    End Sub
    Private Sub Install_Lineage()
        'Install LineageOS
        Me.Invoke(Sub() PictureBox1.Hide())
        Me.Invoke(Sub() MaterialFlatButton1.Hide())
        Me.Invoke(Sub() messageLabel.Hide())
        runningScript = New Process
        runningScript.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\install_lineage.bat"
        runningScript.Start()
        runningScript.EnableRaisingEvents = True
        AddHandler runningScript.Exited, AddressOf Install_LineageProcessExited
    End Sub
    Private Sub Install_LineageProcessExited(sender As Object, e As EventArgs)
        Me.Invoke(Sub() ProgressBar1.Value = 4)
        Me.Invoke(Sub() messageLabel.Show())
        Me.Invoke(Sub() messageLabel.Text = "LineageOS should have installed, and your device should be booting now. Please allow up to 20 minutes for the device to boot.")
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class