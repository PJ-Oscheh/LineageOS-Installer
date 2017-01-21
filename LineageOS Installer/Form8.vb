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
        Process.Start("C:\Tools\LineageOSInstaller\scripts\flash_recovery.bat")
    End Sub

    Private Sub Label6_Click() Handles Label6.Click
        Dim pushlin As Process
        pushlin = New Process
        pushlin.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\push_lineage.bat"
        pushlin.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        pushlin.StartInfo.UseShellExecute = True
        pushlin.StartInfo.WorkingDirectory = "C:\Tools\LineageOSInstaller\scripts"
        pushlin.Start()
        pushlin.WaitForExit()
        Form10.Show()
    End Sub
End Class
