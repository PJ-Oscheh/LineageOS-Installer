Imports System.Text
Public Class Form8



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click() Handles Label3.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click() Handles Label4.Click
        Process.Start("C:\Tools\LineageOSInstaller\scripts\unlock_bl.bat")
    End Sub

    Private Sub Label5_Click() Handles Label5.Click
        Process.Start("C:\Tools\LineageOSInstaller\scripts\flash_recovery.bat")
    End Sub

    Private Sub Label6_Click() Handles Label6.Click
        Process.Start("C:\Tools\LineageOSInstaller\scripts\push_lineage.bat")
    End Sub
End Class
