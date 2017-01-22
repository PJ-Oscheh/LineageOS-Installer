Public Class Form10
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim pushlin As Process
        pushlin = New Process
        pushlin.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\push_lineage.bat"
        pushlin.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        pushlin.StartInfo.UseShellExecute = True
        pushlin.StartInfo.WorkingDirectory = "C:\Tools\LineageOSInstaller\scripts"
        pushlin.Start()
        pushlin.WaitForExit()
        Form14.Show()
        Me.Close()
    End Sub
End Class