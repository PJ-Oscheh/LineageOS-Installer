Imports MaterialSkin
Public Class LangSelect
    Private Sub LangSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        My.Settings.Language = "English"
        Language()
    End Sub
    Private Sub Language()
        If My.Settings.Language = "English" Then
            Form1.WelcomeLabel.Text = "Welcome to LineageOS! Click 'Next' to get started!"
            Form1.NextButton.Text = "Next"
            Form1.LanguageButton.Text = "Change Language"
            youNeed.MaterialLabel1.Text = "You will need the device you wish to install LineageOS on and a USB cable to connect it to your PC (preferably the cable that came included)"
        End If
    End Sub
End Class