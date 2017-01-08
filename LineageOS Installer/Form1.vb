Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://lineageos.org/legal/")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Tools\LineageOSInstaller\scripts\startup.bat")
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Form8.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox("This application is developed by the contributions of PJBeans, Evilarceus. Photo Credit (Unblurred) - Christoph Schulz - UnSplash (Free to use)")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Tools\LineageOSInstaller\scripts\startup.bat")
        Form2.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("C:\Tools\LineageOSInstaller\scripts\startup.bat")
        Form2.Show()
    End Sub
End Class
