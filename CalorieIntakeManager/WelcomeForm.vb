Public Class WelcomeForm
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        SignInForm.Show()
        MsgBox("Welcome to Calorie Intake Manager!" & vbNewLine & vbNewLine & "Kindly Sign in Your Account or Sign up to Create a New One.", MsgBoxStyle.OkOnly, "[Calorie Intake Manager]")
        Me.Hide()
    End Sub
End Class
