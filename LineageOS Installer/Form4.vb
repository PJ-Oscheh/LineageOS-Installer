Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form5.Show()
        Me.Close()
    End Sub
End Class