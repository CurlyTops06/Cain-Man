Public Class SignInForm
    Private MyStoredProcedures As New UserAccountStoredProceduresDataContext
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Securitywords As String
        User_AccountBindingSource.DataSource = MyStoredProcedures.checkUser(txtName.Text, txtPass.Text)
        If User_AccountBindingSource.Count = 0 Then
            MsgBox("There is no existing user account yet!")
        ElseIf txtName.Text Like User_NameTextBox.Text = True AndAlso txtPass.Text Like User_PasswordTextBox.Text = True Then
            Try
                UsersSecurityBindingSource.DataSource = MyStoredProcedures.CheckSecurity(Full_NameTextBox.Text)
                Securitywords = InputBox("Input 3 words " + vbNewLine + "Ex: dog<space>cat<space>fish", "2nd Authenticator")
                If Securitywords Like ThreeWordsLabel1.Text Then
                    CIMMainForm.lblName.Text = Full_NameTextBox.Text
                    CIMMainForm.Show()
                    'MsgBox("Welcome to Calorie Intake Manager " & Full_NameTextBox.Text & "!")
                    txtName.Text = ""
                    txtPass.Text = ""
                    Me.Hide()
                Else
                    MsgBox("Security Words Did Not Match Any Existing Data.", MsgBoxStyle.OkOnly, "Invalid!")
                End If
            Catch ex As Exception
                MsgBox("Please Input Words Only!")
            End Try
        Else
            MsgBox("Username and Password Did Not Match Any Existing Data.", MsgBoxStyle.OkOnly, "Invalid!")
        End If
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        New_Account.Show()
    End Sub

    Private Sub User_AccountBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.User_AccountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserAccountDataSet)
    End Sub

    Private Sub User_AccountBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles User_AccountBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.User_AccountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserAccountDataSet)
    End Sub

    Private Sub SignInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserAccountDataSet.UsersSecurity' table. You can move, or remove it, as needed.
        Me.UsersSecurityTableAdapter.Fill(Me.UserAccountDataSet.UsersSecurity)
        'TODO: This line of code loads data into the 'UserAccountDataSet.User_Account' table. You can move, or remove it, as needed.
        'Me.User_AccountTableAdapter.Fill(Me.UserAccountDataSet.User_Account)
    End Sub

    Private Sub chShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chShowPass.CheckedChanged
        If chShowPass.Checked Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

End Class