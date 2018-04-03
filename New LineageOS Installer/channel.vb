Public Class channel
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If devel.Checked = True And jumpToInstall.Checked = True Then
            install.Show()
        Else
            setUpDevice.Show()
        End If
        Me.Close()
    End Sub

    Private Sub channel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        stable.Enabled = False
        devel.Checked = True

    End Sub

    Private Sub devel_CheckedChanged(sender As Object, e As EventArgs) Handles devel.CheckedChanged
        If devel.Checked = True Then
            skipFiles.Show()

        End If
        If devel.Checked = False Then
            skipFiles.Enabled = False

        End If
    End Sub

    Private Sub stable_CheckedChanged(sender As Object, e As EventArgs) Handles stable.CheckedChanged

    End Sub

End Class