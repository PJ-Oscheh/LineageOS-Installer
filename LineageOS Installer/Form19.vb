Public Class Form19
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form1.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        Dim adbReb As Process
        adbReb = New Process
        adbReb.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\adb_reboot.bat"
        adbReb.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        adbReb.StartInfo.UseShellExecute = True
        adbReb.StartInfo.WorkingDirectory = "C:\Tools\LineageOSInstaller\scripts"
        adbReb.Start()
        adbReb.WaitForExit()
    End Sub
End Class