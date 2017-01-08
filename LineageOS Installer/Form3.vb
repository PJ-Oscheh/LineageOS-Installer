Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Form13.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MsgBox("If you already downloaded LineageOS, just ensure your file is in 'C:\Tools\LineageOSInstaller\LinOS-Files\' and is named 'lineageos'")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form13.Show()
        Me.Close()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class