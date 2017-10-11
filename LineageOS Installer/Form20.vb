Imports System.Net

Public Class Form20
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim thisWebClient As New WebClient()
        thisWebClient.DownloadFile("https://mirrorbits.lineageos.org/full/flo/20171003/lineage-14.1-20171003-nightly-flo-signed.zip", "C:\Tools\LineageOSInstaller\LinOS-Files\lineageos.zip")

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class