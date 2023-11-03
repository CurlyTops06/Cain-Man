<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignInForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignInForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chShowPass = New System.Windows.Forms.CheckBox()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.User_AccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserAccountDataSet = New CalorieIntakeManager.UserAccountDataSet()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.User_PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.User_NameTextBox = New System.Windows.Forms.TextBox()
        Me.User_AccountTableAdapter = New CalorieIntakeManager.UserAccountDataSetTableAdapters.User_AccountTableAdapter()
        Me.TableAdapterManager = New CalorieIntakeManager.UserAccountDataSetTableAdapters.TableAdapterManager()
        Me.User_AccountBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.User_AccountBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.User_IDTextBox = New System.Windows.Forms.TextBox()
        Me.UsersSecurityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersSecurityTableAdapter = New CalorieIntakeManager.UserAccountDataSetTableAdapters.UsersSecurityTableAdapter()
        Me.FullNameLabel1 = New System.Windows.Forms.Label()
        Me.ThreeWordsLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.User_AccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAccountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_AccountBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.User_AccountBindingNavigator.SuspendLayout()
        CType(Me.UsersSecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ThreeWordsLabel1)
        Me.GroupBox1.Controls.Add(Me.FullNameLabel1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(78, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 734)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox3.Controls.Add(Me.chShowPass)
        Me.GroupBox3.Controls.Add(Me.btnSignup)
        Me.GroupBox3.Controls.Add(Me.btnLogin)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtPass)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(68, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(418, 426)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'chShowPass
        '
        Me.chShowPass.AutoSize = True
        Me.chShowPass.BackColor = System.Drawing.Color.Transparent
        Me.chShowPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chShowPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chShowPass.ForeColor = System.Drawing.Color.Green
        Me.chShowPass.Location = New System.Drawing.Point(229, 149)
        Me.chShowPass.Name = "chShowPass"
        Me.chShowPass.Size = New System.Drawing.Size(129, 21)
        Me.chShowPass.TabIndex = 8
        Me.chShowPass.Text = "Show Password"
        Me.chShowPass.UseVisualStyleBackColor = False
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.SystemColors.Control
        Me.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.ForeColor = System.Drawing.Color.Green
        Me.btnSignup.Location = New System.Drawing.Point(276, 253)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(82, 42)
        Me.btnSignup.TabIndex = 7
        Me.btnSignup.Text = "Sign up"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Green
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(67, 253)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(203, 42)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(64, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(64, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(151, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sign in"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.Control
        Me.txtPass.Location = New System.Drawing.Point(67, 170)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(291, 28)
        Me.txtPass.TabIndex = 1
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtName.Location = New System.Drawing.Point(67, 119)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(291, 28)
        Me.txtName.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GenderComboBox)
        Me.GroupBox2.Controls.Add(Me.AgeTextBox)
        Me.GroupBox2.Controls.Add(Me.WeightTextBox)
        Me.GroupBox2.Controls.Add(Me.Full_NameTextBox)
        Me.GroupBox2.Controls.Add(Me.HeightTextBox)
        Me.GroupBox2.Controls.Add(Me.User_PasswordTextBox)
        Me.GroupBox2.Controls.Add(Me.User_NameTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(168, -16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(709, 740)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(335, 230)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 24)
        Me.GenderComboBox.TabIndex = 7
        '
        'User_AccountBindingSource
        '
        Me.User_AccountBindingSource.DataMember = "User_Account"
        Me.User_AccountBindingSource.DataSource = Me.UserAccountDataSet
        '
        'UserAccountDataSet
        '
        Me.UserAccountDataSet.DataSetName = "UserAccountDataSet"
        Me.UserAccountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(335, 261)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(121, 22)
        Me.AgeTextBox.TabIndex = 9
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(335, 317)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(121, 22)
        Me.WeightTextBox.TabIndex = 13
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Full_Name", True))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(335, 202)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Full_NameTextBox.TabIndex = 5
        '
        'HeightTextBox
        '
        Me.HeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Height", True))
        Me.HeightTextBox.Location = New System.Drawing.Point(335, 289)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(121, 22)
        Me.HeightTextBox.TabIndex = 11
        '
        'User_PasswordTextBox
        '
        Me.User_PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_Password", True))
        Me.User_PasswordTextBox.Location = New System.Drawing.Point(335, 373)
        Me.User_PasswordTextBox.Name = "User_PasswordTextBox"
        Me.User_PasswordTextBox.Size = New System.Drawing.Size(121, 22)
        Me.User_PasswordTextBox.TabIndex = 17
        '
        'User_NameTextBox
        '
        Me.User_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_Name", True))
        Me.User_NameTextBox.Location = New System.Drawing.Point(335, 345)
        Me.User_NameTextBox.Name = "User_NameTextBox"
        Me.User_NameTextBox.Size = New System.Drawing.Size(121, 22)
        Me.User_NameTextBox.TabIndex = 15
        '
        'User_AccountTableAdapter
        '
        Me.User_AccountTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_AddedFoodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_FoodTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CalorieIntakeManager.UserAccountDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.User_AccountTableAdapter = Me.User_AccountTableAdapter
        Me.TableAdapterManager.UsersSecurityTableAdapter = Nothing
        '
        'User_AccountBindingNavigator
        '
        Me.User_AccountBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.User_AccountBindingNavigator.BindingSource = Me.User_AccountBindingSource
        Me.User_AccountBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.User_AccountBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.User_AccountBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.User_AccountBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.User_AccountBindingNavigatorSaveItem})
        Me.User_AccountBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.User_AccountBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.User_AccountBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.User_AccountBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.User_AccountBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.User_AccountBindingNavigator.Name = "User_AccountBindingNavigator"
        Me.User_AccountBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.User_AccountBindingNavigator.Size = New System.Drawing.Size(1062, 27)
        Me.User_AccountBindingNavigator.TabIndex = 2
        Me.User_AccountBindingNavigator.Text = "BindingNavigator1"
        Me.User_AccountBindingNavigator.Visible = False
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
        'User_AccountBindingNavigatorSaveItem
        '
        Me.User_AccountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.User_AccountBindingNavigatorSaveItem.Image = CType(resources.GetObject("User_AccountBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.User_AccountBindingNavigatorSaveItem.Name = "User_AccountBindingNavigatorSaveItem"
        Me.User_AccountBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.User_AccountBindingNavigatorSaveItem.Text = "Save Data"
        '
        'User_IDTextBox
        '
        Me.User_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_ID", True))
        Me.User_IDTextBox.Location = New System.Drawing.Point(883, 143)
        Me.User_IDTextBox.Name = "User_IDTextBox"
        Me.User_IDTextBox.Size = New System.Drawing.Size(121, 22)
        Me.User_IDTextBox.TabIndex = 3
        Me.User_IDTextBox.Visible = False
        '
        'UsersSecurityBindingSource
        '
        Me.UsersSecurityBindingSource.DataMember = "UsersSecurity"
        Me.UsersSecurityBindingSource.DataSource = Me.UserAccountDataSet
        '
        'UsersSecurityTableAdapter
        '
        Me.UsersSecurityTableAdapter.ClearBeforeFill = True
        '
        'FullNameLabel1
        '
        Me.FullNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersSecurityBindingSource, "FullName", True))
        Me.FullNameLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FullNameLabel1.Location = New System.Drawing.Point(156, 117)
        Me.FullNameLabel1.Name = "FullNameLabel1"
        Me.FullNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.FullNameLabel1.TabIndex = 2
        Me.FullNameLabel1.Text = "Label4"
        '
        'ThreeWordsLabel1
        '
        Me.ThreeWordsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersSecurityBindingSource, "ThreeWords", True))
        Me.ThreeWordsLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ThreeWordsLabel1.Location = New System.Drawing.Point(256, 77)
        Me.ThreeWordsLabel1.Name = "ThreeWordsLabel1"
        Me.ThreeWordsLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ThreeWordsLabel1.TabIndex = 4
        Me.ThreeWordsLabel1.Text = "Label4"
        '
        'SignInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1062, 724)
        Me.Controls.Add(Me.User_IDTextBox)
        Me.Controls.Add(Me.User_AccountBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SignInForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calorie Intake Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.User_AccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAccountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_AccountBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.User_AccountBindingNavigator.ResumeLayout(False)
        Me.User_AccountBindingNavigator.PerformLayout()
        CType(Me.UsersSecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSignup As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents UserAccountDataSet As UserAccountDataSet
    Friend WithEvents User_AccountBindingSource As BindingSource
    Friend WithEvents User_AccountTableAdapter As UserAccountDataSetTableAdapters.User_AccountTableAdapter
    Friend WithEvents TableAdapterManager As UserAccountDataSetTableAdapters.TableAdapterManager
    Friend WithEvents User_AccountBindingNavigator As BindingNavigator
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
    Friend WithEvents User_AccountBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents User_IDTextBox As TextBox
    Friend WithEvents Full_NameTextBox As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents User_NameTextBox As TextBox
    Friend WithEvents User_PasswordTextBox As TextBox
    Friend WithEvents chShowPass As CheckBox
    Friend WithEvents UsersSecurityBindingSource As BindingSource
    Friend WithEvents UsersSecurityTableAdapter As UserAccountDataSetTableAdapters.UsersSecurityTableAdapter
    Friend WithEvents ThreeWordsLabel1 As Label
    Friend WithEvents FullNameLabel1 As Label
End Class
