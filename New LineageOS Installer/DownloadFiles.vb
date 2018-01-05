Public Class DownloadFiles
    Dim clicks As Integer = 0


    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        clicks = clicks + 1
        If clicks = 1 Then
            lineageWeb.Hide()
            twrpWeb.Show()
        End If
        If clicks = 2 Then
            twrpWeb.Hide()
            gappsWeb.Show()
        End If
        If clicks = 3 Then
            checkADB.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DownloadFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        twrpWeb.Hide()
        gappsWeb.Hide()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        If clicks = 0 Then
            Process.Start("https://download.lineageos.org")
        End If
        If clicks = 1 Then
            Process.Start("https://twrp.me/Devices")
        End If
        If clicks = 2 Then
            Process.Start("http://opengapps.org")
        End If
    End Sub
End Class