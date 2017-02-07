Public Class Form17
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        WebControl1.Hide()
        Label2.Show()
        Label5.Show()
        Label4.Hide()
    End Sub

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Hide()
        Label2.Hide()
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        WebControl1.Show()
        Label2.Hide()
        Label5.Hide()
        Label4.Show()
    End Sub
End Class