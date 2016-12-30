Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form6.Show()
        Me.Close()
    End Sub
End Class