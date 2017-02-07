Public Class Form11
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Dim flashrecovery As Process
        flashrecovery = New Process
        flashrecovery.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\flash_recovery.bat"
        flashrecovery.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        flashrecovery.StartInfo.UseShellExecute = True
        flashrecovery.StartInfo.WorkingDirectory = "C:\Tools\LineageOSInstaller\scripts"
        flashrecovery.Start()
        flashrecovery.WaitForExit()
        Form15.Show()
    End Sub
End Class