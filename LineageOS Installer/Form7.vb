Public Class Form7
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("C:\Tools\LineageOSInstaller\scripts\adb_check")
    End Sub
End Class