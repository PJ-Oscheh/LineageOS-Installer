Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form13.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("If you already downloaded LineageOS, just ensure your file is in 'C:\Tools\LineageOSInstaller\LinOS-Files\' and is named 'lineageos'")
    End Sub
End Class