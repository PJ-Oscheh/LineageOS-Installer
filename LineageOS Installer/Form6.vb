Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form7.Show()
        Me.Close()
    End Sub
End Class