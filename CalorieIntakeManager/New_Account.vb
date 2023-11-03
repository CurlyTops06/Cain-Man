Public Class New_Account
    Private Sub User_AccountBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles User_AccountBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.User_AccountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserAccountDataSet)

    End Sub

    Private Sub New_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserAccountDataSet.UsersSecurity' table. You can move, or remove it, as needed.
        Me.UsersSecurityTableAdapter.Fill(Me.UserAccountDataSet.UsersSecurity)
        'TODO: This line of code loads data into the 'UserAccountDataSet.User_Account' table. You can move, or remove it, as needed.
        'Me.User_AccountTableAdapter.Fill(Me.UserAccountDataSet.User_Account)
        User_AccountBindingSource.AddNew()
        UsersSecurityBindingSource.AddNew()
    End Sub

    Private MyStoredProcedures As New UserAccountStoredProceduresDataContext
    Dim account As New AccountClass

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim Securitywords As String
        account.getName = Full_NameTextBox.Text
        account.getGender = GenderComboBox.Text
        account.getAge = Val(AgeTextBox.Text)
        account.getHeight = Val(HeightTextBox.Text)
        account.getWeight = Val(WeightTextBox.Text)
        If (Full_NameTextBox.Text = "" AndAlso AgeTextBox.Text = "" AndAlso HeightTextBox.Text = "" AndAlso User_NameTextBox.Text = "" AndAlso txtConfirmPass.Text AndAlso User_PasswordTextBox.Text = "") = True Then
            MsgBox("Please Complete All Missing Boxes.", MsgBoxStyle.OkOnly, "Unsuccessful!")
        ElseIf account.getAge = -1 Then
            MsgBox("You're Too Young to Use This Application!", MsgBoxStyle.OkOnly, "Invalid!")
        ElseIf account.getAge = 0 Then
            MsgBox("You're Too Old to Use This Application!", MsgBoxStyle.OkOnly, "Invalid!")
        ElseIf account.getHeight = 0 Then
            MsgBox("Height Input is Either Too Low or Too High." & vbNewLine & "Please Check Again!", MsgBoxStyle.OkOnly, "Invalid!")
        ElseIf account.getWeight = 0 Then
            MsgBox("Weight is too low.", MsgBoxStyle.OkOnly, "Invalid!")
        Else
            If User_PasswordTextBox.Text Like txtConfirmPass.Text = True Then
                Try
                    Securitywords = InputBox("Input 3 words that descirbe about you" + vbNewLine + "Ex: dog<space>cat<space>fish", "2nd Authenticator")
                    MyStoredProcedures.InputThreeWordsUser(account.getName, Securitywords)
                    MyStoredProcedures.CreateNewAccount(account.getName, account.getGender, account.getAge, account.getHeight, account.getWeight, User_NameTextBox.Text, User_PasswordTextBox.Text)
                    MsgBox("New Account Has Been Created Successfully." & vbNewLine & "NOTE:Please remeber and do not share the 3 words that you input" & vbNewLine & "You Can Now Sign in Your Account.", MsgBoxStyle.OkOnly, "Success!")
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Please Input Words Only!")
                End Try
            Else
                MsgBox("User Password and Confirm Password are not the same." & vbNewLine & "Please Try Again.", MsgBoxStyle.OkOnly, "Unsuccessful!")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        User_AccountBindingSource.RemoveCurrent()
        Me.Close()
    End Sub

    Private Sub chShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chShowPass.CheckedChanged
        If chShowPass.Checked Then
            User_PasswordTextBox.UseSystemPasswordChar = False
            txtConfirmPass.UseSystemPasswordChar = False
        Else
            User_PasswordTextBox.UseSystemPasswordChar = True
            txtConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub rdoMeters_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMeters.CheckedChanged
        If rdoMeters.Checked Then
            lblHeight.Text = "m"
            lblSH.Text = "(Sample Input: 1.74)"
            account.getHeight = Val(HeightTextBox.Text)
            HeightTextBox.Text = account.Divide(account.getHeight, 3.281)
        Else
            lblHeight.Text = "ft"
            lblSH.Text = "(Sample Input: 5.7)"
            account.getHeight = Val(HeightTextBox.Text)
            HeightTextBox.Text = account.Multiply(account.getHeight, 3.281)
        End If
    End Sub

    Private Sub rdoPound_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPound.CheckedChanged
        If rdoPound.Checked Then
            lblWeight.Text = "lb"
            lblSW.Text = "(Sample Input: 110)"
            account.getWeight = Val(WeightTextBox.Text)
            WeightTextBox.Text = account.Multiply(account.getWeight, 2.205)
        Else
            lblWeight.Text = "kg"
            lblSW.Text = "(Sample Input: 50)"
            account.getWeight = Val(WeightTextBox.Text)
            WeightTextBox.Text = account.Divide(account.getWeight, 2.205)
        End If
    End Sub
End Class