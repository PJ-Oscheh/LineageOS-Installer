﻿Public Class youNeed
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        NextButton.Text = "Loading..."
        channel.Show()
        Me.Close()
    End Sub
End Class