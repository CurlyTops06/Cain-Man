Public Class CIMMainForm
    Private MyStoredProcedures As New UserAccountStoredProceduresDataContext
    Dim Food As New FoodClass
    Dim Account As New AccountClass
    Dim totalCal As Integer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If DataGridView1.Rows.Count = 5 Then
            MsgBox("Added Items Exceed to the Normal Food intake of 5 Meals per day.", MsgBoxStyle.OkOnly, "Caution!")
        Else
            DataGridView1.Rows.Add(txtID.Text, txtName.Text, txtDescription.Text, txtAmount.Text, txtCalories.Text)
            totalCal += Val(txtCalories.Text)
            lblTotalCal.Text = totalCal
        End If
        btnRemove.Enabled = True
    End Sub

    Private Sub Tbl_FoodBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_FoodBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_FoodBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserAccountDataSet)
    End Sub

    Private Sub CIMMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.User_AccountTableAdapter.Fill(Me.User_AccountBindingSource.DataSource = MyStoredProcedures.DisplayInfo(lblName.Text))
        'Me.User_AccountTableAdapter.Fill(Me.User_AccountBindingSource.DataSource)
        'TODO: This line of code loads data into the 'UserAccountDataSet.User_Account' table. You can move, or remove it, as needed.
        'Me.User_AccountBindingSource.DataSource = MyStoredProcedures.checkUser(User_NameTextBox.Text, User_PasswordTextBox.Text)
        MsgBox("Welcome to Calorie Intake Manager " & Full_NameTextBox.Text & "!")
        User_AccountBindingSource.DataSource = MyStoredProcedures.DisplayInfo(lblName.Text)
        Try
            'Me.User_AccountTableAdapter.Fill(Me.UserAccountDataSet.User_Account)
        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'UserAccountDataSet.tbl_AddedFood' table. You can move, or remove it, as needed.
        Me.Tbl_AddedFoodTableAdapter.Fill(Me.UserAccountDataSet.tbl_AddedFood)
        'TODO: This line of code loads data into the 'UserAccountDataSet.tbl_Food' table. You can move, or remove it, as needed.
        Me.Tbl_FoodTableAdapter.Fill(Me.UserAccountDataSet.tbl_Food)
        Food.getHeight = Val(HeightTextBox1.Text)
        If Food.getHeight = -1 Then
            rdoMeters.Checked = True
            rdoM.Checked = True
        ElseIf Food.getHeight = 0 Then
            rdoFeet.Checked = True
            rdoFT.Checked = True
        End If
        Food.getWeight = Val(WeightTextBox1.Text)
        If Food.getWeight = 0 Then
            rdoKilograms.Checked = True
            rdoKG.Checked = True
        ElseIf Food.getWeight = -1 Then
            rdoPound.Checked = True
            rdoLB.Checked = True
        End If
        If Calorie_GoalLabel1.Text = "" Then
            MsgBox("Please Add a Calorie Goal!", MsgBoxStyle.OkOnly, "CAUTION!")
            cmbSearchBy.Enabled = False
            txtSearch.Enabled = False
            Tbl_FoodDataGridView.Enabled = False
            btnAdd.Enabled = False
            btnRemove.Enabled = False
            btnConfirm.Enabled = False
        End If
        btnRemove.Enabled = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If cmbSearchBy.Text = "Food_Name" Then
            Tbl_FoodBindingSource.DataSource = MyStoredProcedures.SelectByFoodName(txtSearch.Text)
        ElseIf cmbSearchBy.Text = "Food_ID" Then
            Food.foodSearchID = Val(txtSearch.Text)
            Tbl_FoodBindingSource.DataSource = MyStoredProcedures.SelectByFoodID(Food.foodSearchID)
        ElseIf cmbSearchBy.Text = "Description" Then
            Tbl_FoodBindingSource.DataSource = MyStoredProcedures.SelectByDescription(txtSearch.Text)
        ElseIf cmbSearchBy.Text = "Amount_Per" Then
            Tbl_FoodBindingSource.DataSource = MyStoredProcedures.SelectByAmountPer(txtSearch.Text)
        End If

    End Sub

    Private Sub cmbSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchBy.SelectedIndexChanged
        Dim starts, ends As Integer
        Dim ask As MessageBoxOptions
        If cmbSearchBy.Text = "Calories" Then
            Do Until ask = vbCancel Or ends > 0
                Try
                    starts = InputBox("Input Calories Starting From:")
                    ends = InputBox("To:")
                    Tbl_FoodBindingSource.DataSource = MyStoredProcedures.SelectByCalories(starts, ends)
                Catch ex As Exception
                    ask = MsgBox("Invalid Input!" & vbNewLine & "Do You Want to Try Again?", MsgBoxStyle.OkCancel, "Error!")
                End Try
            Loop
        End If
    End Sub

    Private Sub Tbl_FoodDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_FoodDataGridView.CellClick
        Dim selectedRowIndex As Integer
        Dim FoodDirectory As String
        selectedRowIndex = e.RowIndex
        Dim row As New DataGridViewRow
        If selectedRowIndex >= 0 Then
            row = Tbl_FoodDataGridView.Rows(selectedRowIndex)
            txtID.Text = row.Cells(0).Value.ToString()
            txtName.Text = row.Cells(1).Value.ToString()
            FoodDirectory = "C:\Users\Paul William Quiliop\Downloads\CalorieIntakeManager\Food Icon\"
            '"E:\School Files\3rd Year 1st Sem\Software Engineering\CalorieIntakeManager\Food Icon\"
            If txtName.Text = "Banana" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "1Banana.png"
            ElseIf txtName.Text = "Apple" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "2Apple.png"
            ElseIf txtName.Text = "Grapes" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "3Grapes.png"
            ElseIf txtName.Text = "Orange" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "4Orange.png"
            ElseIf txtName.Text = "Pear" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "5Pear.png"
            ElseIf txtName.Text = "Peach" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "6Peach.png"
            ElseIf txtName.Text = "Pineapple" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "7Pineapple.png"
            ElseIf txtName.Text = "Strawberry" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "8Strawberry.png"
            ElseIf txtName.Text = "Watermelon" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "9Watermelon.png"
            ElseIf txtName.Text = "Asparagus" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "10Asparagus.png"
            ElseIf txtName.Text = "Broccoli" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "11Broccoli.png"
            ElseIf txtName.Text = "Carrot" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "12Carrot.png"
            ElseIf txtName.Text = "Eggplant" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "13Eggplant.png"
            ElseIf txtName.Text = "Lettuce" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "14Lettuce.png"
            ElseIf txtName.Text = "Tomato" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "15Tomato.png"
            ElseIf txtName.Text = "Beef" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "16Beef.png"
            ElseIf txtName.Text = "Chicken" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "17Chicken.png"
            ElseIf txtName.Text = "Tofu" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "18Tofu.png"
            ElseIf txtName.Text = "Egg" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "19Egg.png"
            ElseIf txtName.Text = "Fish" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "20Fish.png"
            ElseIf txtName.Text = "Pork" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "21Pork.png"
            ElseIf txtName.Text = "Bread" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "22Bread.png"
            ElseIf txtName.Text = "Butter" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "23Butter.png"
            ElseIf txtName.Text = "Caesar Salad" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "24CaesarSalad.png"
            ElseIf txtName.Text = "Cheese Burger" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "25CheeseBurger.png"
            ElseIf txtName.Text = "Pizza" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "26Pizza.png"
            ElseIf txtName.Text = "Potato" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "27Potato.png"
            ElseIf txtName.Text = "Rice" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "28Rice.png"
            ElseIf txtName.Text = "Beer" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "29Beer.png"
            ElseIf txtName.Text = "Soft Drink" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "30Softdrink.png"
            ElseIf txtName.Text = "Milk" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "31Milk.png"
            ElseIf txtName.Text = "Yogurt" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "32Yogurt.png"
            ElseIf txtName.Text = "Almonds" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "almonds.png"
            ElseIf txtName.Text = "Avocado" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "avocado.png"
            ElseIf txtName.Text = "Bell Pepper" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "bell-pepper.png"
            ElseIf txtName.Text = "Cabbage" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "cabbage.png"
            ElseIf txtName.Text = "Cauliflower" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "cauliflower.png"
            ElseIf txtName.Text = "Cherry" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "cherry.png"
            ElseIf txtName.Text = "Chocolate" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "chocolate-bar.png"
            ElseIf txtName.Text = "Coconut Juice" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "coconut-water.png"
            ElseIf txtName.Text = "Corn" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "corn.png"
            ElseIf txtName.Text = "Donut" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "donut.png"
            ElseIf txtName.Text = "Dragon Fuit" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "dragon-fruit.png"
            ElseIf txtName.Text = "Durian" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "durian.png"
            ElseIf txtName.Text = "French Fries" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "french-fries.png"
            ElseIf txtName.Text = "Garlic Clove" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "garlic.png"
            ElseIf txtName.Text = "Green Tea" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "green-tea.png"
            ElseIf txtName.Text = "Ice Cream" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "ice-cream.png"
            ElseIf txtName.Text = "Lemon" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "lemon.png"
            ElseIf txtName.Text = "Mango" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "mango.png"
            ElseIf txtName.Text = "Mangosteen" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "mangosteen.png"
            ElseIf txtName.Text = "Onion" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "onion.png"
            ElseIf txtName.Text = "Papaya" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "papaya.png"
            ElseIf txtName.Text = "Peanut Butter" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "peanut-butter.png"
            ElseIf txtName.Text = "Rambutan" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "rambutan.png"
            ElseIf txtName.Text = "Fried Chicken" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "roast-chicken.png"
            ElseIf txtName.Text = "Spinach" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "spinach.png"
            ElseIf txtName.Text = "Sunflower Seed" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "sunflower.png"
            ElseIf txtName.Text = "Sweet Potato" Then
                FoodPic_PictureBox1.ImageLocation = FoodDirectory + "sweet-potato.png"
            End If
            txtDescription.Text = row.Cells(2).Value.ToString()
            txtAmount.Text = row.Cells(3).Value.ToString()
            txtCalories.Text = row.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim foodNames As String
        Dim calories As Integer
        For Each row As DataGridViewRow In DataGridView1.Rows
            foodNames = foodNames & row.Cells(1).Value & " | "
            calories += row.Cells(4).Value
        Next
        If foodNames = "" Then
            MsgBox("Please Add Items First!", MsgBoxStyle.OkOnly, "Invalid!")
        Else
            If Calorie_GoalLabel1.Text = "" Then
                Dim ask2 = MsgBox("You can add a Calorie Goal" & vbNewLine & "Do you want To add one first?", MsgBoxStyle.YesNo)
                If ask2 = MsgBoxResult.No Then
                    MyStoredProcedures.AddFood(foodNames, calories, DateTime.Now)
                    MsgBox("Saved Items Successfully", MsgBoxStyle.OkOnly, "[CalorieIntakeManager] Thank you!")
                    lblTotalCal.Text = ""
                    totalCal = 0
                    DataGridView1.Rows.Clear()
                    Me.Tbl_AddedFoodTableAdapter.Fill(Me.UserAccountDataSet.tbl_AddedFood)
                End If
            Else
                Dim ask = MsgBox("Save Items?", MsgBoxStyle.YesNo)
                If ask = MsgBoxResult.Yes Then
                    MyStoredProcedures.AddFood(foodNames, calories, DateTime.Now)
                    MsgBox("Saved Items Successfully", MsgBoxStyle.OkOnly, "[CalorieIntakeManager] Thank you!")
                    Calorie_GoalLabel1.Text -= calories
                    If Calorie_GoalLabel1.Text < 1 Then
                        MsgBox("You've Completed Your Calorie Goal For Today!")
                        Calorie_GoalTextBox.Text = "Complete"
                    End If
                    lblTotalCal.Text = ""
                    totalCal = 0
                    DataGridView1.Rows.Clear()
                    MyStoredProcedures.AddCalorieGoal(Val(User_IDTextBox.Text), Full_NameTextBox.Text, GenderComboBox.Text, Val(AgeTextBox.Text), Val(HeightTextBox.Text), Val(WeightTextBox.Text), User_NameTextBox.Text, User_PasswordTextBox.Text, Val(Calorie_GoalLabel1.Text))
                    Me.Tbl_AddedFoodTableAdapter.Fill(Me.UserAccountDataSet.tbl_AddedFood)
                End If
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim ask = MsgBox("Remove Item?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                totalCal -= txtSubtCal.Text
                lblTotalCal.Text = totalCal
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            End If
        Else
            MsgBox("Please Select Before You Hit Delete!")
        End If

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedRowIndex As Integer
        selectedRowIndex = e.RowIndex
        Dim row As New DataGridViewRow
        If selectedRowIndex > 0 Then
            row = DataGridView1.Rows(selectedRowIndex)
            txtSubtCal.Text = row.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub btnGoal_Click(sender As Object, e As EventArgs) Handles btnGoal.Click
        Dim goal As Integer
        Try
            goal = InputBox("Input Your Calorie Goal")
            MyStoredProcedures.AddCalorieGoal(Val(User_IDTextBox.Text), Full_NameTextBox.Text, GenderComboBox.Text, Val(AgeTextBox.Text), Val(HeightTextBox.Text), Val(WeightTextBox.Text), User_NameTextBox.Text, User_PasswordTextBox.Text, goal)
            Calorie_GoalLabel1.Text = goal
            cmbSearchBy.Enabled = True
            txtSearch.Enabled = True
            Tbl_FoodDataGridView.Enabled = True
            btnAdd.Enabled = True
            btnRemove.Enabled = True
            btnConfirm.Enabled = True
        Catch ex As Exception
            MsgBox("Please Input Numbers Only!")
        End Try
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim ask = MsgBox("Are You Sure You Want to Log Out?", MsgBoxStyle.YesNo, "[CalorieIntakemanager] Log Out?")
        If ask = MsgBoxResult.Yes Then
            Me.Close()
            SignInForm.Show()
            MsgBox("Thank you!" & vbNewLine & "Come Again.")
        End If
    End Sub

    Private Sub rdoMeters_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMeters.CheckedChanged
        If rdoMeters.Checked Then
            lblHeight.Text = "m"
            Account.getHeight = Val(HeightTextBox1.Text)
            HeightTextBox1.Text = Account.Divide(Account.getHeight, 3.281)
        Else
            lblHeight.Text = "ft"
            Account.getHeight = Val(HeightTextBox1.Text)
            HeightTextBox1.Text = Account.Multiply(Account.getHeight, 3.281)
        End If
    End Sub

    Private Sub rdoPound_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPound.CheckedChanged
        If rdoPound.Checked Then
            lblWeight.Text = "lb"
            Account.getWeight = Val(WeightTextBox1.Text)
            WeightTextBox1.Text = Account.Multiply(Account.getWeight, 2.205)
        Else
            lblWeight.Text = "kg"
            Account.getWeight = Val(WeightTextBox1.Text)
            WeightTextBox1.Text = Account.Divide(Account.getWeight, 2.205)
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim weight, height, weightBMI, heightBMI, BMI As Double
        Dim activityLevel As Double = 0
        If rdoFeet.Checked = True Then
            height = Val(HeightTextBox1.Text) * 30.48
            heightBMI = Val(HeightTextBox1.Text) * 0.3048
        ElseIf rdoMeters.Checked = True Then
            height = Val(HeightTextBox1.Text) * 100
            heightBMI = Val(HeightTextBox1.Text)
        End If
        If rdoKilograms.Checked = True Then
            weight = Val(WeightTextBox1.Text)
            weightBMI = Val(WeightTextBox1.Text)
        ElseIf rdoPound.Checked = True Then
            weight = Val(WeightTextBox1.Text) / 2.205
            weightBMI = Val(WeightTextBox1.Text) * 0.453592
        End If
        If cmbActivityLevel.Text = "Lightly (Little or No Exercise)" Then
            activityLevel = 1.3735
        ElseIf cmbActivityLevel.Text = "Moderately (2-5 times/week)" Then
            activityLevel = 1.5488
        ElseIf cmbActivityLevel.Text = "Very Active (6-7 times/week)" Then
            activityLevel = 1.7234
        ElseIf cmbActivityLevel.Text = "Extra Active (Intense Exercise Daily)" Then
            activityLevel = 1.898
        End If
        lblMaintain.Text = Food.CalorieFormula(Val(AgeTextBox1.Text), GenderComboBox1.Text, height, weight, activityLevel)
        lblLose1.Text = Val(lblMaintain.Text) - 500
        lblLose2.Text = Val(lblMaintain.Text) - 1000
        lblGain1.Text = Val(lblMaintain.Text) + 500
        lblGain2.Text = Val(lblMaintain.Text) + 1000
        BMI = Food.BMIFormula(weightBMI, heightBMI)
        lblBMI.Text = Format(BMI, "0.00")
        Food.BMICategory = BMI
        lblBMICategory.Text = Food.BMICategory
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtAddedFood_ID.Text = "" Then
            MsgBox("Please Select an Item First!")
        Else
            Dim ask = MsgBox("Are you sure you want to Delete this Item?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then
                DataGridView2.Rows.Remove(DataGridView2.SelectedRows(0))
                MyStoredProcedures.DeleteHistory(txtAddedFood_ID.Text)
                MsgBox("Deleted Successfully!")
                Me.Tbl_AddedFoodTableAdapter.Fill(Me.UserAccountDataSet.tbl_AddedFood)
            End If
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim selectedRowIndex As Integer
        selectedRowIndex = e.RowIndex
        Dim row As New DataGridViewRow
        If selectedRowIndex > 0 Then
            row = DataGridView2.Rows(selectedRowIndex)
            txtAddedFood_ID.Text = row.Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        Dim ask = MsgBox("Are you Sure you Want to Delete All History?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            MyStoredProcedures.DeleteAllHistory()
            Me.Tbl_AddedFoodTableAdapter.Fill(Me.UserAccountDataSet.tbl_AddedFood)
            MsgBox("Deleted All History")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Account.getName = Full_NameTextBox.Text
        Account.getGender = GenderComboBox.Text
        Account.getAge = Val(AgeTextBox.Text)
        Account.getHeight = Val(HeightTextBox.Text)
        Account.getWeight = Val(WeightTextBox.Text)
        If (Full_NameTextBox.Text = "" AndAlso AgeTextBox.Text = "" AndAlso HeightTextBox.Text = "" AndAlso User_NameTextBox.Text = "" AndAlso txtConfirmPass.Text AndAlso User_PasswordTextBox.Text = "") = True Then
            MsgBox("Please Complete All Missing Boxes.", MsgBoxStyle.OkOnly, "Unsuccessful!")
        ElseIf Account.getAge = -1 Then
            MsgBox("You're Too Young to Use This Application!", MsgBoxStyle.OkOnly, "Invalid!")
        ElseIf Account.getAge = 0 Then
            MsgBox("You're Too Old to Use This Application!", MsgBoxStyle.OkOnly, "Invalid!")
        ElseIf Account.getHeight = 0 Then
            MsgBox("Height Input is Either Too Low or Too High." & vbNewLine & "Please Check Again!", MsgBoxStyle.OkOnly, "Invalid!")
        ElseIf Account.getWeight = 0 Then
            MsgBox("Weight is too low.", MsgBoxStyle.OkOnly, "Invalid!")
        Else
            If User_PasswordTextBox.Text Like txtConfirmPass.Text = True Then
                Dim ask = MsgBox("Are You Sure You Want to Update Account Details?", MsgBoxStyle.YesNo, "[CalorieIntakeManager]")
                If ask = MsgBoxResult.Yes Then
                    MyStoredProcedures.UpdateAccount(Val(User_IDTextBox.Text), Account.getName, Account.getGender, Account.getAge, Account.getHeight, Account.getWeight, User_NameTextBox.Text, User_PasswordTextBox.Text)
                    MsgBox("Your Account Has Been Updated Successfully.", MsgBoxStyle.OkOnly, "Success!")
                End If
            Else
                MsgBox("User Password and Confirm Password are not the same." & vbNewLine & "Please Try Again.", MsgBoxStyle.OkOnly, "Unsuccessful!")
            End If
        End If
    End Sub

    Private Sub rdoM_CheckedChanged(sender As Object, e As EventArgs) Handles rdoM.CheckedChanged
        If rdoM.Checked Then
            Label21.Text = "m"
            Account.getHeight = Val(HeightTextBox.Text)
            HeightTextBox.Text = Account.Divide(Account.getHeight, 3.281)
        ElseIf rdoFT.Checked = True Then
            Label21.Text = "ft"
            Account.getHeight = Val(HeightTextBox.Text)
            HeightTextBox.Text = Account.Multiply(Account.getHeight, 3.281)
        End If
    End Sub

    Private Sub rdoLB_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLB.CheckedChanged
        If rdoLB.Checked Then
            Label22.Text = "lb"
            Account.getWeight = Val(WeightTextBox.Text)
            WeightTextBox.Text = Account.Multiply(Account.getWeight, 2.205)
        ElseIf rdoKG.Checked = True Then
            Label22.Text = "kg"
            Account.getWeight = Val(WeightTextBox.Text)
            WeightTextBox.Text = Account.Divide(Account.getWeight, 2.205)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chShowPass.CheckedChanged
        If chShowPass.Checked Then
            User_PasswordTextBox.UseSystemPasswordChar = False
            txtConfirmPass.UseSystemPasswordChar = False
        Else
            User_PasswordTextBox.UseSystemPasswordChar = True
            txtConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub
End Class