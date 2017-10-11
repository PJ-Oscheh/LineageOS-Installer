Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://lineageos.org/legal/")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Hide()
        LinkLabel1.Hide()
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

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        MsgBox("This application is developed by the contributions of PJBeans, Evilarceus. Photo Credit (Unblurred) - Christoph Schulz - UnSplash (Free to use)")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Tools\LineageOSInstaller\scripts\startup.bat")
        Form2.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("C:\Tools\LineageOSInstaller\scripts\startup.bat")
        Form16.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        MsgBox("This application is developed by the contributions of PJBeans, Evilarceus. Photo Credit (Unblurred) - Christoph Schulz - UnSplash (Free to use)")
    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click
        Form8.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        Label2.Show()
        LinkLabel1.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim site As String = "https://github.com/PJBeans/LineageOS-Installer/graphs/contributors"
        Process.Start(site)
    End Sub
    'Window Movement'
    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown


        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top

    End Sub
    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Panel2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub
    Private Sub Panel2text_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown


        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top

    End Sub
    Private Sub Panel2text_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Panel2text_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        drag = False
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
    'End Window Movement'
End Class
