Imports System.IO
Public Class checkADB
    'Sorry for the misnomer! This is the file check; the ADB Check occurs in `install.vb`.
    Dim proceedWithInstall As Integer
    '0 = don't proceed, 1 = proceed.'
    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles mainLabel.Click

    End Sub

    Private Sub checkADB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fileCheck()
    End Sub

    Private Sub fileCheck() Handles MyBase.Load
        NextButton.Text = "Retry"
        proceedWithInstall = 1
        warningImg.Hide()
        issueText.Hide()
        errorLabel.Hide()
        fileLabel.Text = "Checking for lineageos.zip"
        If File.Exists("C:\Tools\LineageOSInstaller\LinOS-Files\lineageos.zip") = True Then
            fileLabel.Text = "Found lineageos.zip"

        Else
            proceedWithInstall = 0
            warningImg.Show()
            issueText.Show()
            errorLabel.Show()
            mainLabel.Hide()
            fileLabel.Text = "Error: lineageos.zip wasn't found."
            errorLabel.Text = "'lineageos.zip' was not found. Make sure it is located at: 'C:\Tools\LineageOSInstaller\LinOS-Files\lineageos.zip' and is named correctly."
        End If
        If File.Exists("C:\Tools\LineageOSInstaller\LinOS-Files\recovery.img") = True Then
            fileLabel.Text = "Found recovery.img"
        Else
            proceedWithInstall = 0
            warningImg.Show()
            issueText.Show()
            errorLabel.Show()
            mainLabel.Hide()
            fileLabel.Text = "Error: recovery.img wasn't found."
            errorLabel.Text = "'recovery.img' was not found. Make sure it is located at: 'C:\Tools\LineageOSInstaller\LinOS-Files\recovery.img' and is named correctly."
        End If
        If File.Exists("C:\Tools\LineageOSInstaller\LinOS-Files\gapps.zip") = True Then
            fileLabel.Text = "Found gapps.zip"
        Else
            proceedWithInstall = 0
            warningImg.Show()
            issueText.Show()
            errorLabel.Show()
            mainLabel.Hide()
            fileLabel.Text = "Error: gapps.zip wasn't found."
            errorLabel.Text = "'gapps.zip' was not found. Make sure it is located at: 'C:\Tools\LineageOSInstaller\LinOS-Files\gapps.zip' and is named correctly."
        End If
        If File.Exists("C:\Tools\LineageOSInstaller\scripts\adb_check.bat") = True Then
            fileLabel.Text = "Found adb_check.bat"
        Else
            proceedWithInstall = 0
            warningImg.Show()
            issueText.Show()
            errorLabel.Show()
            mainLabel.Hide()
            fileLabel.Text = "Error: adb_check.bat wasn't found"
            errorLabel.Text = "'adb_check.bat' was not found. You may have a corrupt program directory; if so, please restart the program. If that doesn't fix the issue, redownload it."
        End If
        If File.Exists("C:\Tools\LineageOSInstaller\scripts\adb_reboot.bat") = True Then
            fileLabel.Text = "Found adb_reboot.bat"
        Else
            proceedWithInstall = 0
            warningImg.Show()
            issueText.Show()
            errorLabel.Show()
            mainLabel.Hide()
            fileLabel.Text = "Error: adb_reboot.bat wasn't found"
            errorLabel.Text = "'adb_reboot.bat' was not found. You may have a corrupt program directory; if so, please restart the program. If that doesn't fix the issue, redownload it."
        End If
        If File.Exists("C:\Tools\LineageOSInstaller\scripts\flash_recovery.bat") = True Then
            fileLabel.Text = "Found flash_recovery.bat"
        Else
            proceedWithInstall = 0
            warningImg.Show()
            issueText.Show()
            errorLabel.Show()
            mainLabel.Hide()
            fileLabel.Text = "Error: flash_recovery.bat wasn't found"
            errorLabel.Text = "'flash_recovery.bat' was not found. You may have a corrupt program directory; if so, please restart the program. If that doesn't fix the issue, redownload it."
        End If
        If File.Exists("C:\Tools\LineageOSInstaller\scripts\install_lineage.bat") = True Then
            fileLabel.Text = "Found install_lineage.bat"
        Else
            proceedWithInstall = 0
            warningImg.Show()
            issueText.Show()
            errorLabel.Show()
            mainLabel.Hide()
            fileLabel.Text = "Error: install_lineage.bat wasn't found"
            errorLabel.Text = "'install_lineage.bat' was not found. You may have a corrupt program directory; if so, please restart the program. If that doesn't fix the issue, redownload it."
        End If
        If File.Exists("C:\Tools\LineageOSInstaller\scripts\push_lineage.bat") = True Then
            fileLabel.Text = "Found push_lineage.bat"
        Else
            proceedWithInstall = 0
            warningImg.Show()
            issueText.Show()
            errorLabel.Show()
            mainLabel.Hide()
            fileLabel.Text = "Error: push_lineage.bat wasn't found"
            errorLabel.Text = "'push_lineage.bat' was not found. You may have a corrupt program directory; if so, please restart the program. If that doesn't fix the issue, redownload it."
        End If
        If File.Exists("C:\Tools\LineageOSInstaller\scripts\unlock_bl.bat") = True Then
            fileLabel.Text = "Found unlock_bl.bat"
        Else
            proceedWithInstall = 0
            warningImg.Show()
            issueText.Show()
            errorLabel.Show()
            mainLabel.Hide()
            fileLabel.Text = "Error: unlock_bl.bat wasn't found"
            errorLabel.Text = "'unlock_bl.bat' was not found. You may have a corrupt program directory; if so, please restart the program. If that doesn't fix the issue, redownload it."
        End If
        If proceedWithInstall = 1 Then
            NextButton.Text = "Next"
            NextButton.Show()
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If proceedWithInstall = 0 Then
            NextButton.Show()

            fileCheck()
        End If
        If proceedWithInstall = 1 Then
            install.Show()
        End If

    End Sub
End Class