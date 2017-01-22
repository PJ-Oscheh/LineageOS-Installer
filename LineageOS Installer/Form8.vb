Imports System.Text
Public Class Form8



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click() Handles Label3.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click() Handles Label4.Click
        Dim unlockbl As Process
        unlockbl = New Process
        unlockbl.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\unlock_bl.bat"
        unlockbl.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        unlockbl.StartInfo.UseShellExecute = True
        unlockbl.StartInfo.WorkingDirectory = "C:\Tools\LineageOSInstaller\scripts"
        unlockbl.Start()
        unlockbl.WaitForExit()
        Form11.Show()
    End Sub

    Private Sub Label5_Click() Handles Label5.Click
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

    Private Sub Label6_Click() Handles Label6.Click
        Form10.Show()
    End Sub
End Class
