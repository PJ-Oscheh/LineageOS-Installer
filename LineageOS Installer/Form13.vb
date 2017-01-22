Public Class Form13
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MsgBox("If you already downloaded TWRP, just ensure your file is in C:\Tools\LineageOSInstaller\LinOS-Files\ and is named 'recovery'")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form17.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox("If you already downloaded TWRP, just ensure your file is in C:\Tools\LineageOSInstaller\LinOS-Files\ and is named 'recovery'")
    End Sub
End Class