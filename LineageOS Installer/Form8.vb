Imports System.Text
Public Class Form8



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click() Handles Label3.Click
        Dim sb = New StringBuilder()
        Dim psi = New ProcessStartInfo() With
    {
            .WorkingDirectory = "C:\Tools\LineageOSInstaller\scripts\",
            .FileName = "C:\Tools\LineageOSInstaller\scripts\install.bat",
            .CreateNoWindow = True,
            .RedirectStandardOutput = True,
            .RedirectStandardInput = True,
            .UseShellExecute = False
    }

        Dim installbatOut = New Process()
        installbatOut.StartInfo = psi
        AddHandler installbatOut.OutputDataReceived, Function(sender, args) sb.AppendLine(args.Data)
        installbatOut.Start()
        installbatOut.BeginOutputReadLine()
        installbatOut.WaitForExit(100)
        RichTextBox1.Text = sb.ToString()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
