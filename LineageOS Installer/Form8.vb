Imports System.Text
Public Class Form8

    Private Sub Button1_Click() Handles Button1.Click
        'Output for `C:\Tools\LineageOSInstaller\scripts\install.bat`. Thanks StackOverflow'
        'However, this will require a fully automated script. Perhaps we could create timeouts?'


        Dim sb = New StringBuilder()
        Dim psi = New ProcessStartInfo() With
    {
            .WorkingDirectory = "C:\Tools\LineageOSInstaller\scripts\",
            .FileName = "C:\Tools\LineageOSInstaller\scripts\install.bat",
            .CreateNoWindow = False,
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

End Class
