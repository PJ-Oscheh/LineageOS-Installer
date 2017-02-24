Public Class Form15
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim installlin As Process
        installlin = New Process
        installlin.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\install_lineage.bat"
        installlin.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        installlin.StartInfo.UseShellExecute = True
        installlin.StartInfo.WorkingDirectory = "C:\Tools\LineageOSInstaller\scripts"
        installlin.Start()
        installlin.WaitForExit()
        Me.Close()
        Form19.Show()
    End Sub
End Class