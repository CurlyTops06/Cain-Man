<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CIMMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim HeightLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim User_NameLabel As System.Windows.Forms.Label
        Dim User_PasswordLabel As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIMMainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FoodPic_PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblTotalCal = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Food_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Food_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_FoodDataGridView = New System.Windows.Forms.DataGridView()
        Me.FoodIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Food_Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount_Per = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calories = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_FoodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserAccountDataSet = New CalorieIntakeManager.UserAccountDataSet()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblBMICategory = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblGain2 = New System.Windows.Forms.Label()
        Me.lblGain1 = New System.Windows.Forms.Label()
        Me.lblMaintain = New System.Windows.Forms.Label()
        Me.lblLose2 = New System.Windows.Forms.Label()
        Me.lblLose1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.WeightTextBox1 = New System.Windows.Forms.TextBox()
        Me.User_AccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rdoKilograms = New System.Windows.Forms.RadioButton()
        Me.rdoPound = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.rdoMeters = New System.Windows.Forms.RadioButton()
        Me.rdoFeet = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HeightTextBox1 = New System.Windows.Forms.TextBox()
        Me.User_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Full_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.GenderComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AgeTextBox1 = New System.Windows.Forms.TextBox()
        Me.User_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.User_PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.cmbActivityLevel = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.txtAddedFood_ID = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.AddedFoodIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddedDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaloriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_AddedFoodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.rdoLB = New System.Windows.Forms.RadioButton()
        Me.rdoKG = New System.Windows.Forms.RadioButton()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.rdoM = New System.Windows.Forms.RadioButton()
        Me.rdoFT = New System.Windows.Forms.RadioButton()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.chShowPass = New System.Windows.Forms.CheckBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.User_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.User_NameTextBox = New System.Windows.Forms.TextBox()
        Me.User_PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Calorie_GoalTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbl_FoodBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_FoodBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.txtSubtCal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnGoal = New System.Windows.Forms.Button()
        Me.Tbl_FoodTableAdapter = New CalorieIntakeManager.UserAccountDataSetTableAdapters.tbl_FoodTableAdapter()
        Me.TableAdapterManager = New CalorieIntakeManager.UserAccountDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_AddedFoodTableAdapter = New CalorieIntakeManager.UserAccountDataSetTableAdapters.tbl_AddedFoodTableAdapter()
        Me.User_AccountTableAdapter = New CalorieIntakeManager.UserAccountDataSetTableAdapters.User_AccountTableAdapter()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Calorie_GoalLabel1 = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        HeightLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        User_NameLabel = New System.Windows.Forms.Label()
        User_PasswordLabel = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.FoodPic_PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_FoodDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_FoodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAccountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.User_AccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_AddedFoodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_FoodBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_FoodBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.ForeColor = System.Drawing.Color.Green
        Full_NameLabel.Location = New System.Drawing.Point(267, 120)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(102, 24)
        Full_NameLabel.TabIndex = 2
        Full_NameLabel.Text = "Full Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.ForeColor = System.Drawing.Color.Green
        GenderLabel.Location = New System.Drawing.Point(267, 154)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(79, 24)
        GenderLabel.TabIndex = 4
        GenderLabel.Text = "Gender:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.ForeColor = System.Drawing.Color.Green
        AgeLabel.Location = New System.Drawing.Point(267, 190)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(50, 24)
        AgeLabel.TabIndex = 6
        AgeLabel.Text = "Age:"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeightLabel.ForeColor = System.Drawing.Color.Green
        HeightLabel.Location = New System.Drawing.Point(266, 230)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(70, 24)
        HeightLabel.TabIndex = 8
        HeightLabel.Text = "Height:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WeightLabel.ForeColor = System.Drawing.Color.Green
        WeightLabel.Location = New System.Drawing.Point(266, 287)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(74, 24)
        WeightLabel.TabIndex = 10
        WeightLabel.Text = "Weight:"
        '
        'User_NameLabel
        '
        User_NameLabel.AutoSize = True
        User_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_NameLabel.ForeColor = System.Drawing.Color.Green
        User_NameLabel.Location = New System.Drawing.Point(266, 344)
        User_NameLabel.Name = "User_NameLabel"
        User_NameLabel.Size = New System.Drawing.Size(110, 24)
        User_NameLabel.TabIndex = 12
        User_NameLabel.Text = "User Name:"
        '
        'User_PasswordLabel
        '
        User_PasswordLabel.AutoSize = True
        User_PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_PasswordLabel.ForeColor = System.Drawing.Color.Green
        User_PasswordLabel.Location = New System.Drawing.Point(266, 378)
        User_PasswordLabel.Name = "User_PasswordLabel"
        User_PasswordLabel.Size = New System.Drawing.Size(141, 24)
        User_PasswordLabel.TabIndex = 14
        User_PasswordLabel.Text = "User Password:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label23.ForeColor = System.Drawing.Color.Green
        Label23.Location = New System.Drawing.Point(266, 412)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(167, 24)
        Label23.TabIndex = 25
        Label23.Text = "Confirm Password:"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImage = CType(resources.GetObject("GroupBox6.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox6.Location = New System.Drawing.Point(16, 1)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(90, 88)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 90)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1038, 571)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.FoodPic_PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.lblTotalCal)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.cmbSearchBy)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Tbl_FoodDataGridView)
        Me.TabPage1.Controls.Add(Me.btnConfirm)
        Me.TabPage1.Controls.Add(Me.btnRemove)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1030, 540)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Manager"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FoodPic_PictureBox1
        '
        Me.FoodPic_PictureBox1.Location = New System.Drawing.Point(696, 56)
        Me.FoodPic_PictureBox1.Name = "FoodPic_PictureBox1"
        Me.FoodPic_PictureBox1.Size = New System.Drawing.Size(328, 328)
        Me.FoodPic_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FoodPic_PictureBox1.TabIndex = 21
        Me.FoodPic_PictureBox1.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Green
        Me.Label18.Location = New System.Drawing.Point(450, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(157, 18)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "on the Column Header"
        '
        'lblTotalCal
        '
        Me.lblTotalCal.AutoSize = True
        Me.lblTotalCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCal.ForeColor = System.Drawing.Color.Green
        Me.lblTotalCal.Location = New System.Drawing.Point(822, 393)
        Me.lblTotalCal.Name = "lblTotalCal"
        Me.lblTotalCal.Size = New System.Drawing.Size(111, 29)
        Me.lblTotalCal.TabIndex = 19
        Me.lblTotalCal.Text = "Calories"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Green
        Me.Label17.Location = New System.Drawing.Point(776, 400)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 17)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Total"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Food_ID, Me.Food_Name, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(6, 390)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(684, 142)
        Me.DataGridView1.TabIndex = 17
        '
        'Food_ID
        '
        Me.Food_ID.DataPropertyName = "Food_ID"
        Me.Food_ID.HeaderText = "Food_ID"
        Me.Food_ID.MinimumWidth = 6
        Me.Food_ID.Name = "Food_ID"
        Me.Food_ID.Width = 94
        '
        'Food_Name
        '
        Me.Food_Name.DataPropertyName = "Food_Name"
        Me.Food_Name.HeaderText = "Food_Name"
        Me.Food_Name.MinimumWidth = 6
        Me.Food_Name.Name = "Food_Name"
        Me.Food_Name.Width = 120
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Food_Description"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Food_Description"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 155
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Amount_Per"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amount_Per"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 119
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Calories"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Calories"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 92
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Green
        Me.Label16.Location = New System.Drawing.Point(263, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 17)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Search"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.BackColor = System.Drawing.SystemColors.Control
        Me.cmbSearchBy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.Items.AddRange(New Object() {"Food_Name", "Food_ID", "Description", "Amount_Per", "Calories"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(6, 26)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(184, 24)
        Me.cmbSearchBy.TabIndex = 15
        Me.cmbSearchBy.Text = "Food_Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(438, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 18)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "You Sort Items by Clicking"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(62, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Search By"
        '
        'Tbl_FoodDataGridView
        '
        Me.Tbl_FoodDataGridView.AllowUserToAddRows = False
        Me.Tbl_FoodDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_FoodDataGridView.AllowUserToOrderColumns = True
        Me.Tbl_FoodDataGridView.AllowUserToResizeColumns = False
        Me.Tbl_FoodDataGridView.AllowUserToResizeRows = False
        Me.Tbl_FoodDataGridView.AutoGenerateColumns = False
        Me.Tbl_FoodDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Tbl_FoodDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_FoodDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Tbl_FoodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_FoodDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodIDDataGridViewTextBoxColumn, Me.FoodNameDataGridViewTextBoxColumn, Me.Food_Description, Me.Amount_Per, Me.Calories})
        Me.Tbl_FoodDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tbl_FoodDataGridView.DataSource = Me.Tbl_FoodBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tbl_FoodDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.Tbl_FoodDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Tbl_FoodDataGridView.Location = New System.Drawing.Point(6, 56)
        Me.Tbl_FoodDataGridView.MultiSelect = False
        Me.Tbl_FoodDataGridView.Name = "Tbl_FoodDataGridView"
        Me.Tbl_FoodDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_FoodDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Tbl_FoodDataGridView.RowHeadersVisible = False
        Me.Tbl_FoodDataGridView.RowHeadersWidth = 51
        Me.Tbl_FoodDataGridView.RowTemplate.Height = 24
        Me.Tbl_FoodDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tbl_FoodDataGridView.Size = New System.Drawing.Size(684, 328)
        Me.Tbl_FoodDataGridView.TabIndex = 10
        '
        'FoodIDDataGridViewTextBoxColumn
        '
        Me.FoodIDDataGridViewTextBoxColumn.DataPropertyName = "Food_ID"
        Me.FoodIDDataGridViewTextBoxColumn.HeaderText = "Food_ID"
        Me.FoodIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FoodIDDataGridViewTextBoxColumn.Name = "FoodIDDataGridViewTextBoxColumn"
        Me.FoodIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.FoodIDDataGridViewTextBoxColumn.Width = 94
        '
        'FoodNameDataGridViewTextBoxColumn
        '
        Me.FoodNameDataGridViewTextBoxColumn.DataPropertyName = "Food_Name"
        Me.FoodNameDataGridViewTextBoxColumn.HeaderText = "Food_Name"
        Me.FoodNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FoodNameDataGridViewTextBoxColumn.Name = "FoodNameDataGridViewTextBoxColumn"
        Me.FoodNameDataGridViewTextBoxColumn.Width = 120
        '
        'Food_Description
        '
        Me.Food_Description.DataPropertyName = "Food_Description"
        Me.Food_Description.HeaderText = "Food_Description"
        Me.Food_Description.MinimumWidth = 6
        Me.Food_Description.Name = "Food_Description"
        Me.Food_Description.Width = 155
        '
        'Amount_Per
        '
        Me.Amount_Per.DataPropertyName = "Amount_Per"
        Me.Amount_Per.HeaderText = "Amount_Per"
        Me.Amount_Per.MinimumWidth = 6
        Me.Amount_Per.Name = "Amount_Per"
        Me.Amount_Per.Width = 119
        '
        'Calories
        '
        Me.Calories.DataPropertyName = "Calories"
        Me.Calories.HeaderText = "Calories"
        Me.Calories.MinimumWidth = 6
        Me.Calories.Name = "Calories"
        Me.Calories.Width = 92
        '
        'Tbl_FoodBindingSource
        '
        Me.Tbl_FoodBindingSource.DataMember = "tbl_Food"
        Me.Tbl_FoodBindingSource.DataSource = Me.UserAccountDataSet
        '
        'UserAccountDataSet
        '
        Me.UserAccountDataSet.DataSetName = "UserAccountDataSet"
        Me.UserAccountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Green
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(696, 485)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(328, 49)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm Items"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Red
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(865, 430)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(159, 49)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Green
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(696, 430)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(159, 49)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Control
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(196, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(190, 22)
        Me.txtSearch.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.lblBMICategory)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.lblBMI)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.lblGain2)
        Me.TabPage2.Controls.Add(Me.lblGain1)
        Me.TabPage2.Controls.Add(Me.lblMaintain)
        Me.TabPage2.Controls.Add(Me.lblLose2)
        Me.TabPage2.Controls.Add(Me.lblLose1)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.User_IDTextBox1)
        Me.TabPage2.Controls.Add(Me.Full_NameTextBox1)
        Me.TabPage2.Controls.Add(Me.GenderComboBox1)
        Me.TabPage2.Controls.Add(Me.AgeTextBox1)
        Me.TabPage2.Controls.Add(Me.User_NameTextBox1)
        Me.TabPage2.Controls.Add(Me.User_PasswordTextBox1)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.btnCalculate)
        Me.TabPage2.Controls.Add(Me.cmbActivityLevel)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1030, 540)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Calculator"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblBMICategory
        '
        Me.lblBMICategory.AutoSize = True
        Me.lblBMICategory.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblBMICategory.Location = New System.Drawing.Point(792, 262)
        Me.lblBMICategory.Name = "lblBMICategory"
        Me.lblBMICategory.Size = New System.Drawing.Size(122, 24)
        Me.lblBMICategory.TabIndex = 51
        Me.lblBMICategory.Text = "BMI Category"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Green
        Me.Label26.Location = New System.Drawing.Point(790, 203)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(133, 32)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "You Are:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Green
        Me.Label25.Location = New System.Drawing.Point(790, 98)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(179, 32)
        Me.Label25.TabIndex = 49
        Me.Label25.Text = "Your BMI is:"
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblBMI.Location = New System.Drawing.Point(792, 154)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(42, 24)
        Me.lblBMI.TabIndex = 48
        Me.lblBMI.Text = "BMI"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Green
        Me.Label19.Location = New System.Drawing.Point(378, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(294, 38)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Calorie Calculator"
        '
        'lblGain2
        '
        Me.lblGain2.AutoSize = True
        Me.lblGain2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGain2.ForeColor = System.Drawing.Color.Green
        Me.lblGain2.Location = New System.Drawing.Point(544, 461)
        Me.lblGain2.Name = "lblGain2"
        Me.lblGain2.Size = New System.Drawing.Size(128, 32)
        Me.lblGain2.TabIndex = 47
        Me.lblGain2.Text = "Calories"
        '
        'lblGain1
        '
        Me.lblGain1.AutoSize = True
        Me.lblGain1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGain1.ForeColor = System.Drawing.Color.Green
        Me.lblGain1.Location = New System.Drawing.Point(544, 385)
        Me.lblGain1.Name = "lblGain1"
        Me.lblGain1.Size = New System.Drawing.Size(128, 32)
        Me.lblGain1.TabIndex = 46
        Me.lblGain1.Text = "Calories"
        '
        'lblMaintain
        '
        Me.lblMaintain.AutoSize = True
        Me.lblMaintain.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaintain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMaintain.Location = New System.Drawing.Point(544, 146)
        Me.lblMaintain.Name = "lblMaintain"
        Me.lblMaintain.Size = New System.Drawing.Size(128, 32)
        Me.lblMaintain.TabIndex = 45
        Me.lblMaintain.Text = "Calories"
        '
        'lblLose2
        '
        Me.lblLose2.AutoSize = True
        Me.lblLose2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLose2.ForeColor = System.Drawing.Color.Red
        Me.lblLose2.Location = New System.Drawing.Point(544, 304)
        Me.lblLose2.Name = "lblLose2"
        Me.lblLose2.Size = New System.Drawing.Size(128, 32)
        Me.lblLose2.TabIndex = 44
        Me.lblLose2.Text = "Calories"
        '
        'lblLose1
        '
        Me.lblLose1.AutoSize = True
        Me.lblLose1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLose1.ForeColor = System.Drawing.Color.Red
        Me.lblLose1.Location = New System.Drawing.Point(544, 225)
        Me.lblLose1.Name = "lblLose1"
        Me.lblLose1.Size = New System.Drawing.Size(128, 32)
        Me.lblLose1.TabIndex = 17
        Me.lblLose1.Text = "Calories"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblWeight)
        Me.GroupBox2.Controls.Add(Me.WeightTextBox1)
        Me.GroupBox2.Controls.Add(Me.rdoKilograms)
        Me.GroupBox2.Controls.Add(Me.rdoPound)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(106, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 88)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.ForeColor = System.Drawing.Color.Green
        Me.lblWeight.Location = New System.Drawing.Point(176, 30)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(30, 24)
        Me.lblWeight.TabIndex = 49
        Me.lblWeight.Text = "kg"
        '
        'WeightTextBox1
        '
        Me.WeightTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Weight", True))
        Me.WeightTextBox1.Location = New System.Drawing.Point(47, 27)
        Me.WeightTextBox1.Name = "WeightTextBox1"
        Me.WeightTextBox1.Size = New System.Drawing.Size(123, 28)
        Me.WeightTextBox1.TabIndex = 37
        '
        'User_AccountBindingSource
        '
        Me.User_AccountBindingSource.DataMember = "User_Account"
        Me.User_AccountBindingSource.DataSource = Me.UserAccountDataSet
        '
        'rdoKilograms
        '
        Me.rdoKilograms.AutoSize = True
        Me.rdoKilograms.ForeColor = System.Drawing.Color.Green
        Me.rdoKilograms.Location = New System.Drawing.Point(98, 61)
        Me.rdoKilograms.Name = "rdoKilograms"
        Me.rdoKilograms.Size = New System.Drawing.Size(114, 28)
        Me.rdoKilograms.TabIndex = 17
        Me.rdoKilograms.TabStop = True
        Me.rdoKilograms.Text = "Kilograms"
        Me.rdoKilograms.UseVisualStyleBackColor = True
        '
        'rdoPound
        '
        Me.rdoPound.AutoSize = True
        Me.rdoPound.ForeColor = System.Drawing.Color.Green
        Me.rdoPound.Location = New System.Drawing.Point(5, 61)
        Me.rdoPound.Name = "rdoPound"
        Me.rdoPound.Size = New System.Drawing.Size(87, 28)
        Me.rdoPound.TabIndex = 16
        Me.rdoPound.TabStop = True
        Me.rdoPound.Text = "Pound"
        Me.rdoPound.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(72, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Weight"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHeight)
        Me.GroupBox1.Controls.Add(Me.rdoMeters)
        Me.GroupBox1.Controls.Add(Me.rdoFeet)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.HeightTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(106, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 88)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.ForeColor = System.Drawing.Color.Green
        Me.lblHeight.Location = New System.Drawing.Point(176, 28)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(18, 24)
        Me.lblHeight.TabIndex = 48
        Me.lblHeight.Text = "ft"
        '
        'rdoMeters
        '
        Me.rdoMeters.AutoSize = True
        Me.rdoMeters.ForeColor = System.Drawing.Color.Green
        Me.rdoMeters.Location = New System.Drawing.Point(109, 59)
        Me.rdoMeters.Name = "rdoMeters"
        Me.rdoMeters.Size = New System.Drawing.Size(88, 28)
        Me.rdoMeters.TabIndex = 15
        Me.rdoMeters.TabStop = True
        Me.rdoMeters.Text = "Meters"
        Me.rdoMeters.UseVisualStyleBackColor = True
        '
        'rdoFeet
        '
        Me.rdoFeet.AutoSize = True
        Me.rdoFeet.ForeColor = System.Drawing.Color.Green
        Me.rdoFeet.Location = New System.Drawing.Point(34, 59)
        Me.rdoFeet.Name = "rdoFeet"
        Me.rdoFeet.Size = New System.Drawing.Size(69, 28)
        Me.rdoFeet.TabIndex = 14
        Me.rdoFeet.TabStop = True
        Me.rdoFeet.Text = "Feet"
        Me.rdoFeet.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(72, -2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Height"
        '
        'HeightTextBox1
        '
        Me.HeightTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Height", True))
        Me.HeightTextBox1.Location = New System.Drawing.Point(47, 25)
        Me.HeightTextBox1.Name = "HeightTextBox1"
        Me.HeightTextBox1.Size = New System.Drawing.Size(123, 28)
        Me.HeightTextBox1.TabIndex = 35
        '
        'User_IDTextBox1
        '
        Me.User_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_ID", True))
        Me.User_IDTextBox1.Location = New System.Drawing.Point(966, 6)
        Me.User_IDTextBox1.Name = "User_IDTextBox1"
        Me.User_IDTextBox1.Size = New System.Drawing.Size(10, 28)
        Me.User_IDTextBox1.TabIndex = 27
        Me.User_IDTextBox1.Visible = False
        '
        'Full_NameTextBox1
        '
        Me.Full_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Full_Name", True))
        Me.Full_NameTextBox1.Location = New System.Drawing.Point(982, 6)
        Me.Full_NameTextBox1.Name = "Full_NameTextBox1"
        Me.Full_NameTextBox1.Size = New System.Drawing.Size(10, 28)
        Me.Full_NameTextBox1.TabIndex = 29
        Me.Full_NameTextBox1.Visible = False
        '
        'GenderComboBox1
        '
        Me.GenderComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Gender", True))
        Me.GenderComboBox1.FormattingEnabled = True
        Me.GenderComboBox1.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.GenderComboBox1.Location = New System.Drawing.Point(153, 161)
        Me.GenderComboBox1.Name = "GenderComboBox1"
        Me.GenderComboBox1.Size = New System.Drawing.Size(121, 30)
        Me.GenderComboBox1.TabIndex = 31
        '
        'AgeTextBox1
        '
        Me.AgeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Age", True))
        Me.AgeTextBox1.Location = New System.Drawing.Point(153, 103)
        Me.AgeTextBox1.Name = "AgeTextBox1"
        Me.AgeTextBox1.Size = New System.Drawing.Size(121, 28)
        Me.AgeTextBox1.TabIndex = 33
        '
        'User_NameTextBox1
        '
        Me.User_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_Name", True))
        Me.User_NameTextBox1.Location = New System.Drawing.Point(998, 6)
        Me.User_NameTextBox1.Name = "User_NameTextBox1"
        Me.User_NameTextBox1.Size = New System.Drawing.Size(10, 28)
        Me.User_NameTextBox1.TabIndex = 39
        Me.User_NameTextBox1.Visible = False
        '
        'User_PasswordTextBox1
        '
        Me.User_PasswordTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_Password", True))
        Me.User_PasswordTextBox1.Location = New System.Drawing.Point(1014, 6)
        Me.User_PasswordTextBox1.Name = "User_PasswordTextBox1"
        Me.User_PasswordTextBox1.Size = New System.Drawing.Size(10, 28)
        Me.User_PasswordTextBox1.TabIndex = 41
        Me.User_PasswordTextBox1.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(494, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(188, 24)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Calories you need to:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(483, 437)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(217, 24)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Gain 2 lb / 1 kg per week"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(475, 361)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 24)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Gain 1 lb / 0.5 kg per week"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(477, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(219, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Lose 2 lb / 1 kg per week"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(470, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(234, 24)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Lose 1 lb / 0.5 kg per week"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(494, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 24)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Maintain your weight"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(157, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Activity Level"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(176, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(190, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Age"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Green
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(34, 461)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(358, 46)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'cmbActivityLevel
        '
        Me.cmbActivityLevel.FormattingEnabled = True
        Me.cmbActivityLevel.Items.AddRange(New Object() {"Lightly (Little or No Exercise)", "Moderately (2-5 times/week)", "Very Active (6-7 times/week)", "Extra Active (Intense Exercise Daily)"})
        Me.cmbActivityLevel.Location = New System.Drawing.Point(66, 425)
        Me.cmbActivityLevel.Name = "cmbActivityLevel"
        Me.cmbActivityLevel.Size = New System.Drawing.Size(305, 30)
        Me.cmbActivityLevel.TabIndex = 6
        Me.cmbActivityLevel.Text = "Lightly (Little or No Exercise)"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.btnDeleteAll)
        Me.TabPage3.Controls.Add(Me.txtAddedFood_ID)
        Me.TabPage3.Controls.Add(Me.btnDelete)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1030, 540)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "History"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Green
        Me.Label20.Location = New System.Drawing.Point(464, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(127, 38)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "History"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.BackColor = System.Drawing.Color.Red
        Me.btnDeleteAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAll.ForeColor = System.Drawing.Color.White
        Me.btnDeleteAll.Location = New System.Drawing.Point(761, 492)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(227, 42)
        Me.btnDeleteAll.TabIndex = 23
        Me.btnDeleteAll.Text = "Delete All History"
        Me.btnDeleteAll.UseVisualStyleBackColor = False
        '
        'txtAddedFood_ID
        '
        Me.txtAddedFood_ID.Location = New System.Drawing.Point(1014, 6)
        Me.txtAddedFood_ID.Name = "txtAddedFood_ID"
        Me.txtAddedFood_ID.Size = New System.Drawing.Size(10, 24)
        Me.txtAddedFood_ID.TabIndex = 17
        Me.txtAddedFood_ID.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(613, 492)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(142, 42)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AddedFoodIDDataGridViewTextBoxColumn, Me.AddedDateTimeDataGridViewTextBoxColumn, Me.FoodNameDataGridViewTextBoxColumn1, Me.CaloriesDataGridViewTextBoxColumn})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView2.DataSource = Me.Tbl_AddedFoodBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(42, 65)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(946, 421)
        Me.DataGridView2.TabIndex = 21
        '
        'AddedFoodIDDataGridViewTextBoxColumn
        '
        Me.AddedFoodIDDataGridViewTextBoxColumn.DataPropertyName = "AddedFood_ID"
        Me.AddedFoodIDDataGridViewTextBoxColumn.HeaderText = "AddedFood_ID"
        Me.AddedFoodIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddedFoodIDDataGridViewTextBoxColumn.Name = "AddedFoodIDDataGridViewTextBoxColumn"
        Me.AddedFoodIDDataGridViewTextBoxColumn.Width = 135
        '
        'AddedDateTimeDataGridViewTextBoxColumn
        '
        Me.AddedDateTimeDataGridViewTextBoxColumn.DataPropertyName = "AddedDateTime"
        Me.AddedDateTimeDataGridViewTextBoxColumn.HeaderText = "AddedDateTime"
        Me.AddedDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddedDateTimeDataGridViewTextBoxColumn.Name = "AddedDateTimeDataGridViewTextBoxColumn"
        Me.AddedDateTimeDataGridViewTextBoxColumn.Width = 142
        '
        'FoodNameDataGridViewTextBoxColumn1
        '
        Me.FoodNameDataGridViewTextBoxColumn1.DataPropertyName = "Food_Name"
        Me.FoodNameDataGridViewTextBoxColumn1.HeaderText = "Food_Name"
        Me.FoodNameDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.FoodNameDataGridViewTextBoxColumn1.Name = "FoodNameDataGridViewTextBoxColumn1"
        Me.FoodNameDataGridViewTextBoxColumn1.Width = 120
        '
        'CaloriesDataGridViewTextBoxColumn
        '
        Me.CaloriesDataGridViewTextBoxColumn.DataPropertyName = "Calories"
        Me.CaloriesDataGridViewTextBoxColumn.HeaderText = "Calories"
        Me.CaloriesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CaloriesDataGridViewTextBoxColumn.Name = "CaloriesDataGridViewTextBoxColumn"
        Me.CaloriesDataGridViewTextBoxColumn.Width = 92
        '
        'Tbl_AddedFoodBindingSource
        '
        Me.Tbl_AddedFoodBindingSource.DataMember = "tbl_AddedFood"
        Me.Tbl_AddedFoodBindingSource.DataSource = Me.UserAccountDataSet
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.chShowPass)
        Me.TabPage4.Controls.Add(Label23)
        Me.TabPage4.Controls.Add(Me.txtConfirmPass)
        Me.TabPage4.Controls.Add(Me.User_IDTextBox)
        Me.TabPage4.Controls.Add(Full_NameLabel)
        Me.TabPage4.Controls.Add(Me.Full_NameTextBox)
        Me.TabPage4.Controls.Add(GenderLabel)
        Me.TabPage4.Controls.Add(Me.GenderComboBox)
        Me.TabPage4.Controls.Add(AgeLabel)
        Me.TabPage4.Controls.Add(Me.AgeTextBox)
        Me.TabPage4.Controls.Add(HeightLabel)
        Me.TabPage4.Controls.Add(WeightLabel)
        Me.TabPage4.Controls.Add(User_NameLabel)
        Me.TabPage4.Controls.Add(Me.User_NameTextBox)
        Me.TabPage4.Controls.Add(User_PasswordLabel)
        Me.TabPage4.Controls.Add(Me.User_PasswordTextBox)
        Me.TabPage4.Controls.Add(Me.Calorie_GoalTextBox)
        Me.TabPage4.ForeColor = System.Drawing.Color.Green
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1030, 540)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Account Settings"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Green
        Me.Label24.Location = New System.Drawing.Point(390, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(279, 38)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Account Settings"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(420, 477)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 42)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Update Account"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.rdoLB)
        Me.GroupBox4.Controls.Add(Me.rdoKG)
        Me.GroupBox4.Controls.Add(Me.WeightTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(467, 286)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(193, 52)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(112, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 18)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "kg"
        '
        'rdoLB
        '
        Me.rdoLB.AutoSize = True
        Me.rdoLB.ForeColor = System.Drawing.Color.Green
        Me.rdoLB.Location = New System.Drawing.Point(103, 30)
        Me.rdoLB.Name = "rdoLB"
        Me.rdoLB.Size = New System.Drawing.Size(80, 22)
        Me.rdoLB.TabIndex = 21
        Me.rdoLB.TabStop = True
        Me.rdoLB.Text = "Pounds"
        Me.rdoLB.UseVisualStyleBackColor = True
        '
        'rdoKG
        '
        Me.rdoKG.AutoSize = True
        Me.rdoKG.ForeColor = System.Drawing.Color.Green
        Me.rdoKG.Location = New System.Drawing.Point(1, 30)
        Me.rdoKG.Name = "rdoKG"
        Me.rdoKG.Size = New System.Drawing.Size(96, 22)
        Me.rdoKG.TabIndex = 20
        Me.rdoKG.TabStop = True
        Me.rdoKG.Text = "Kilograms"
        Me.rdoKG.UseVisualStyleBackColor = True
        '
        'WeightTextBox
        '
        Me.WeightTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Weight", True))
        Me.WeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTextBox.Location = New System.Drawing.Point(0, 1)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(106, 28)
        Me.WeightTextBox.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.rdoM)
        Me.GroupBox3.Controls.Add(Me.rdoFT)
        Me.GroupBox3.Controls.Add(Me.HeightTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(466, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 56)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(113, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(16, 18)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "ft"
        '
        'rdoM
        '
        Me.rdoM.AutoSize = True
        Me.rdoM.ForeColor = System.Drawing.Color.Green
        Me.rdoM.Location = New System.Drawing.Point(104, 33)
        Me.rdoM.Name = "rdoM"
        Me.rdoM.Size = New System.Drawing.Size(75, 22)
        Me.rdoM.TabIndex = 19
        Me.rdoM.TabStop = True
        Me.rdoM.Text = "Meters"
        Me.rdoM.UseVisualStyleBackColor = True
        '
        'rdoFT
        '
        Me.rdoFT.AutoSize = True
        Me.rdoFT.ForeColor = System.Drawing.Color.Green
        Me.rdoFT.Location = New System.Drawing.Point(1, 33)
        Me.rdoFT.Name = "rdoFT"
        Me.rdoFT.Size = New System.Drawing.Size(58, 22)
        Me.rdoFT.TabIndex = 18
        Me.rdoFT.TabStop = True
        Me.rdoFT.Text = "Feet"
        Me.rdoFT.UseVisualStyleBackColor = True
        '
        'HeightTextBox
        '
        Me.HeightTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.HeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Height", True))
        Me.HeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightTextBox.Location = New System.Drawing.Point(0, 4)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(106, 28)
        Me.HeightTextBox.TabIndex = 9
        '
        'chShowPass
        '
        Me.chShowPass.AutoSize = True
        Me.chShowPass.Location = New System.Drawing.Point(706, 446)
        Me.chShowPass.Name = "chShowPass"
        Me.chShowPass.Size = New System.Drawing.Size(139, 22)
        Me.chShowPass.TabIndex = 26
        Me.chShowPass.Text = "Show Password"
        Me.chShowPass.UseVisualStyleBackColor = True
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BackColor = System.Drawing.SystemColors.Control
        Me.txtConfirmPass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_Password", True))
        Me.txtConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(466, 412)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(378, 28)
        Me.txtConfirmPass.TabIndex = 24
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'User_IDTextBox
        '
        Me.User_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_ID", True))
        Me.User_IDTextBox.Location = New System.Drawing.Point(608, 495)
        Me.User_IDTextBox.Name = "User_IDTextBox"
        Me.User_IDTextBox.Size = New System.Drawing.Size(10, 24)
        Me.User_IDTextBox.TabIndex = 1
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Full_NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Full_Name", True))
        Me.Full_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(467, 120)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(378, 28)
        Me.Full_NameTextBox.TabIndex = 3
        '
        'GenderComboBox
        '
        Me.GenderComboBox.BackColor = System.Drawing.SystemColors.Control
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Gender", True))
        Me.GenderComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.GenderComboBox.Location = New System.Drawing.Point(467, 154)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(378, 30)
        Me.GenderComboBox.TabIndex = 5
        '
        'AgeTextBox
        '
        Me.AgeTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Age", True))
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(467, 190)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(106, 28)
        Me.AgeTextBox.TabIndex = 7
        '
        'User_NameTextBox
        '
        Me.User_NameTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.User_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_Name", True))
        Me.User_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_NameTextBox.Location = New System.Drawing.Point(466, 344)
        Me.User_NameTextBox.Name = "User_NameTextBox"
        Me.User_NameTextBox.Size = New System.Drawing.Size(378, 28)
        Me.User_NameTextBox.TabIndex = 13
        '
        'User_PasswordTextBox
        '
        Me.User_PasswordTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.User_PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_Password", True))
        Me.User_PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_PasswordTextBox.Location = New System.Drawing.Point(466, 378)
        Me.User_PasswordTextBox.Name = "User_PasswordTextBox"
        Me.User_PasswordTextBox.Size = New System.Drawing.Size(378, 28)
        Me.User_PasswordTextBox.TabIndex = 15
        Me.User_PasswordTextBox.UseSystemPasswordChar = True
        '
        'Calorie_GoalTextBox
        '
        Me.Calorie_GoalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Calorie_Goal", True))
        Me.Calorie_GoalTextBox.Location = New System.Drawing.Point(1014, 6)
        Me.Calorie_GoalTextBox.Name = "Calorie_GoalTextBox"
        Me.Calorie_GoalTextBox.Size = New System.Drawing.Size(10, 24)
        Me.Calorie_GoalTextBox.TabIndex = 17
        Me.Calorie_GoalTextBox.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(492, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Calorie Goal"
        '
        'Tbl_FoodBindingNavigator
        '
        Me.Tbl_FoodBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_FoodBindingNavigator.BindingSource = Me.Tbl_FoodBindingSource
        Me.Tbl_FoodBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_FoodBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_FoodBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tbl_FoodBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_FoodBindingNavigatorSaveItem})
        Me.Tbl_FoodBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_FoodBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_FoodBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_FoodBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_FoodBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_FoodBindingNavigator.Name = "Tbl_FoodBindingNavigator"
        Me.Tbl_FoodBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_FoodBindingNavigator.Size = New System.Drawing.Size(1062, 27)
        Me.Tbl_FoodBindingNavigator.TabIndex = 5
        Me.Tbl_FoodBindingNavigator.Text = "BindingNavigator1"
        Me.Tbl_FoodBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Tbl_FoodBindingNavigatorSaveItem
        '
        Me.Tbl_FoodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_FoodBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_FoodBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_FoodBindingNavigatorSaveItem.Name = "Tbl_FoodBindingNavigatorSaveItem"
        Me.Tbl_FoodBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Tbl_FoodBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(959, 81)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(10, 22)
        Me.txtID.TabIndex = 6
        Me.txtID.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(975, 81)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(10, 22)
        Me.txtName.TabIndex = 7
        Me.txtName.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(991, 81)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(10, 22)
        Me.txtDescription.TabIndex = 8
        Me.txtDescription.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(1007, 81)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(10, 22)
        Me.txtAmount.TabIndex = 9
        Me.txtAmount.Visible = False
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(1023, 81)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(10, 22)
        Me.txtCalories.TabIndex = 10
        Me.txtCalories.Visible = False
        '
        'txtSubtCal
        '
        Me.txtSubtCal.Location = New System.Drawing.Point(1039, 81)
        Me.txtSubtCal.Name = "txtSubtCal"
        Me.txtSubtCal.Size = New System.Drawing.Size(10, 22)
        Me.txtSubtCal.TabIndex = 11
        Me.txtSubtCal.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(112, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Calorie Intake Manager"
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.DimGray
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(920, 25)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(130, 50)
        Me.btnLogOut.TabIndex = 13
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnGoal
        '
        Me.btnGoal.BackColor = System.Drawing.Color.White
        Me.btnGoal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGoal.Location = New System.Drawing.Point(496, 74)
        Me.btnGoal.Name = "btnGoal"
        Me.btnGoal.Size = New System.Drawing.Size(98, 28)
        Me.btnGoal.TabIndex = 15
        Me.btnGoal.Text = "Set Goal"
        Me.btnGoal.UseVisualStyleBackColor = False
        '
        'Tbl_FoodTableAdapter
        '
        Me.Tbl_FoodTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_AddedFoodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_FoodTableAdapter = Me.Tbl_FoodTableAdapter
        Me.TableAdapterManager.UpdateOrder = CalorieIntakeManager.UserAccountDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.User_AccountTableAdapter = Nothing
        '
        'Tbl_AddedFoodTableAdapter
        '
        Me.Tbl_AddedFoodTableAdapter.ClearBeforeFill = True
        '
        'User_AccountTableAdapter
        '
        Me.User_AccountTableAdapter.ClearBeforeFill = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Green
        Me.lblName.Location = New System.Drawing.Point(112, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name"
        '
        'Calorie_GoalLabel1
        '
        Me.Calorie_GoalLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Calorie_Goal", True))
        Me.Calorie_GoalLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Calorie_GoalLabel1.ForeColor = System.Drawing.Color.Red
        Me.Calorie_GoalLabel1.Location = New System.Drawing.Point(489, 34)
        Me.Calorie_GoalLabel1.Name = "Calorie_GoalLabel1"
        Me.Calorie_GoalLabel1.Size = New System.Drawing.Size(178, 37)
        Me.Calorie_GoalLabel1.TabIndex = 17
        Me.Calorie_GoalLabel1.Text = "Goal"
        '
        'CIMMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 681)
        Me.Controls.Add(Me.Calorie_GoalLabel1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnGoal)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSubtCal)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tbl_FoodBindingNavigator)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CIMMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calorie Intake Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.FoodPic_PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_FoodDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_FoodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAccountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.User_AccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_AddedFoodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_FoodBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_FoodBindingNavigator.ResumeLayout(False)
        Me.Tbl_FoodBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rdoKilograms As RadioButton
    Friend WithEvents rdoPound As RadioButton
    Friend WithEvents rdoMeters As RadioButton
    Friend WithEvents rdoFeet As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents cmbActivityLevel As ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents UserAccountDataSet As UserAccountDataSet
    Friend WithEvents Tbl_FoodBindingSource As BindingSource
    Friend WithEvents Tbl_FoodTableAdapter As UserAccountDataSetTableAdapters.tbl_FoodTableAdapter
    Friend WithEvents TableAdapterManager As UserAccountDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_FoodBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_FoodBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_FoodDataGridView As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbSearchBy As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FoodIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Food_Description As DataGridViewTextBoxColumn
    Friend WithEvents Amount_Per As DataGridViewTextBoxColumn
    Friend WithEvents Calories As DataGridViewTextBoxColumn
    Friend WithEvents Tbl_AddedFoodBindingSource As BindingSource
    Friend WithEvents Tbl_AddedFoodTableAdapter As UserAccountDataSetTableAdapters.tbl_AddedFoodTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtCalories As TextBox
    Friend WithEvents lblTotalCal As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents User_AccountBindingSource As BindingSource
    Friend WithEvents User_AccountTableAdapter As UserAccountDataSetTableAdapters.User_AccountTableAdapter
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents User_IDTextBox1 As TextBox
    Friend WithEvents Full_NameTextBox1 As TextBox
    Friend WithEvents GenderComboBox1 As ComboBox
    Friend WithEvents AgeTextBox1 As TextBox
    Friend WithEvents HeightTextBox1 As TextBox
    Friend WithEvents WeightTextBox1 As TextBox
    Friend WithEvents User_NameTextBox1 As TextBox
    Friend WithEvents User_PasswordTextBox1 As TextBox
    Friend WithEvents Food_ID As DataGridViewTextBoxColumn
    Friend WithEvents Food_Name As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents txtSubtCal As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnGoal As Button
    Friend WithEvents User_IDTextBox As TextBox
    Friend WithEvents Full_NameTextBox As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents User_NameTextBox As TextBox
    Friend WithEvents User_PasswordTextBox As TextBox
    Friend WithEvents Calorie_GoalTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblGain2 As Label
    Friend WithEvents lblGain1 As Label
    Friend WithEvents lblMaintain As Label
    Friend WithEvents lblLose2 As Label
    Friend WithEvents lblLose1 As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents AddedFoodIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddedDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CaloriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtAddedFood_ID As TextBox
    Friend WithEvents btnDeleteAll As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents rdoM As RadioButton
    Friend WithEvents rdoFT As RadioButton
    Friend WithEvents rdoLB As RadioButton
    Friend WithEvents rdoKG As RadioButton
    Friend WithEvents chShowPass As CheckBox
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents FoodPic_PictureBox1 As PictureBox
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblBMICategory As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Calorie_GoalLabel1 As Label
End Class
