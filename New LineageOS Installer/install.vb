Imports System.IO
Public Class install
    Dim runningScript As Process
    Dim stepNumber As Integer

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
        'Hmm.... "Cross-thread operation not valid: Control 'messageLabel' accessed from a thread other than the thread it was created on" occurs when running from source but everything seems fine when built (published)

        Me.Invoke(Sub() ProgressBar1.Value = 2)
        messageLabel.Show()
        MaterialFlatButton1.Show()
    End Sub
    Private Sub install_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        messageLabel.Text = "On your device, use the options to select 'Recovery'."
        MaterialFlatButton1.Text = "Recovery has booted; proceed."
        MaterialFlatButton1.Show()
    End Sub
    Private Sub Install_Lineage()
        'Install LineageOS
        MaterialFlatButton1.Hide()
        messageLabel.Hide()
        runningScript = New Process
        runningScript.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\install_lineage.bat"
        runningScript.Start()
        runningScript.EnableRaisingEvents = True
        AddHandler runningScript.Exited, AddressOf Install_LineageProcessExited
    End Sub
    Private Sub Install_LineageProcessExited(sender As Object, e As EventArgs)
        Me.Invoke(Sub() ProgressBar1.Value = 4)
        messageLabel.Show()
        messageLabel.Text = "LineageOS should have installed, and your device should be booting now. Please allow up to 20 minutes for the device to boot."
    End Sub
End Class