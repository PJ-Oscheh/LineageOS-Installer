Imports System.Text
Public Class Form8
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click() Handles Label3.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click() Handles Label4.Click
        Dim unlockbl As Process
        unlockbl = New Process
        unlockbl.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\unlock_bl.bat"
        unlockbl.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        unlockbl.StartInfo.UseShellExecute = True
        unlockbl.StartInfo.WorkingDirectory = "C:\Tools\LineageOSInstaller\scripts"


        unlockbl.Start()
        unlockbl.WaitForExit()
        Form11.Show()
    End Sub

    Private Sub Label5_Click() Handles Label5.Click
        Dim flashrecovery As Process
        flashrecovery = New Process
        flashrecovery.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\flash_recovery.bat"
        flashrecovery.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        flashrecovery.StartInfo.UseShellExecute = True
        flashrecovery.StartInfo.WorkingDirectory = "C:\Tools\LineageOSInstaller\scripts"
        flashrecovery.Start()
        flashrecovery.WaitForExit()
        Form15.Show()
    End Sub

    Private Sub Label6_Click() Handles Label6.Click
        Form10.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim unlockbl As Process
        unlockbl = New Process
        unlockbl.StartInfo.FileName = "C:\Tools\LineageOSInstaller\scripts\unlock_bl.bat"
        unlockbl.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        unlockbl.StartInfo.UseShellExecute = True
        unlockbl.StartInfo.WorkingDirectory = "C:\Tools\LineageOSInstaller\scripts"

        unlockbl.Start()
        unlockbl.WaitForExit()
        Form11.Show()



    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)
        MsgBox("Name this .ZIP file `SU`")
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)
        MsgBox("Name this .ZIP file `Magisk`")
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)
        MsgBox("Name this .ZIP file `Xposed`")
    End Sub
    'Window Movement'
    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown


        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top

    End Sub
    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Panel2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseUp
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
    'End Window Movement'
End Class
