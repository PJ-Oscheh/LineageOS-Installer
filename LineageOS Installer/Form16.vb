Public Class Form16
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If TextBox1.Text = "yes" Then
            Form2.Show()
            Me.Close()
        Else
            MsgBox("If you refuse to read everything, do not use this program.")
        End If
    End Sub
End Class