<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class New_Account
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
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Account))
        Me.User_AccountBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.User_AccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserAccountDataSet = New CalorieIntakeManager.UserAccountDataSet()
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
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.User_NameTextBox = New System.Windows.Forms.TextBox()
        Me.User_PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.rdoFeet = New System.Windows.Forms.RadioButton()
        Me.rdoMeters = New System.Windows.Forms.RadioButton()
        Me.rdoKilograms = New System.Windows.Forms.RadioButton()
        Me.rdoPound = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.User_AccountTableAdapter = New CalorieIntakeManager.UserAccountDataSetTableAdapters.User_AccountTableAdapter()
        Me.TableAdapterManager = New CalorieIntakeManager.UserAccountDataSetTableAdapters.TableAdapterManager()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lblSH = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lblSW = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.chShowPass = New System.Windows.Forms.CheckBox()
        Me.UsersSecurityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersSecurityTableAdapter = New CalorieIntakeManager.UserAccountDataSetTableAdapters.UsersSecurityTableAdapter()
        Full_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        HeightLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        User_NameLabel = New System.Windows.Forms.Label()
        User_PasswordLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.User_AccountBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.User_AccountBindingNavigator.SuspendLayout()
        CType(Me.User_AccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAccountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.UsersSecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.BackColor = System.Drawing.Color.Transparent
        Full_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.ForeColor = System.Drawing.Color.Green
        Full_NameLabel.Location = New System.Drawing.Point(250, 177)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(102, 24)
        Full_NameLabel.TabIndex = 3
        Full_NameLabel.Text = "Full Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.Transparent
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.ForeColor = System.Drawing.Color.Green
        GenderLabel.Location = New System.Drawing.Point(250, 211)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(79, 24)
        GenderLabel.TabIndex = 5
        GenderLabel.Text = "Gender:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.BackColor = System.Drawing.Color.Transparent
        AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.ForeColor = System.Drawing.Color.Green
        AgeLabel.Location = New System.Drawing.Point(250, 247)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(50, 24)
        AgeLabel.TabIndex = 7
        AgeLabel.Text = "Age:"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.BackColor = System.Drawing.Color.Transparent
        HeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeightLabel.ForeColor = System.Drawing.Color.Green
        HeightLabel.Location = New System.Drawing.Point(250, 287)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(70, 24)
        HeightLabel.TabIndex = 9
        HeightLabel.Text = "Height:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.BackColor = System.Drawing.Color.Transparent
        WeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WeightLabel.ForeColor = System.Drawing.Color.Green
        WeightLabel.Location = New System.Drawing.Point(250, 349)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(74, 24)
        WeightLabel.TabIndex = 11
        WeightLabel.Text = "Weight:"
        '
        'User_NameLabel
        '
        User_NameLabel.AutoSize = True
        User_NameLabel.BackColor = System.Drawing.Color.Transparent
        User_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_NameLabel.ForeColor = System.Drawing.Color.Green
        User_NameLabel.Location = New System.Drawing.Point(250, 413)
        User_NameLabel.Name = "User_NameLabel"
        User_NameLabel.Size = New System.Drawing.Size(110, 24)
        User_NameLabel.TabIndex = 13
        User_NameLabel.Text = "User Name:"
        '
        'User_PasswordLabel
        '
        User_PasswordLabel.AutoSize = True
        User_PasswordLabel.BackColor = System.Drawing.Color.Transparent
        User_PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_PasswordLabel.ForeColor = System.Drawing.Color.Green
        User_PasswordLabel.Location = New System.Drawing.Point(250, 447)
        User_PasswordLabel.Name = "User_PasswordLabel"
        User_PasswordLabel.Size = New System.Drawing.Size(141, 24)
        User_PasswordLabel.TabIndex = 15
        User_PasswordLabel.Text = "User Password:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Green
        Label2.Location = New System.Drawing.Point(250, 481)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(167, 24)
        Label2.TabIndex = 32
        Label2.Text = "Confirm Password:"
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
        Me.User_AccountBindingNavigator.TabIndex = 0
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
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Full_NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Full_Name", True))
        Me.Full_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(436, 174)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(356, 28)
        Me.Full_NameTextBox.TabIndex = 4
        '
        'GenderComboBox
        '
        Me.GenderComboBox.BackColor = System.Drawing.SystemColors.Control
        Me.GenderComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Gender", True))
        Me.GenderComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.GenderComboBox.Location = New System.Drawing.Point(436, 208)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(356, 30)
        Me.GenderComboBox.TabIndex = 6
        Me.GenderComboBox.Text = "MALE"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Age", True))
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(436, 244)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(102, 28)
        Me.AgeTextBox.TabIndex = 8
        '
        'HeightTextBox
        '
        Me.HeightTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.HeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Height", True))
        Me.HeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightTextBox.Location = New System.Drawing.Point(0, 8)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(103, 28)
        Me.HeightTextBox.TabIndex = 10
        '
        'WeightTextBox
        '
        Me.WeightTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "Weight", True))
        Me.WeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTextBox.Location = New System.Drawing.Point(0, 9)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(102, 28)
        Me.WeightTextBox.TabIndex = 12
        '
        'User_NameTextBox
        '
        Me.User_NameTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.User_NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.User_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_Name", True))
        Me.User_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_NameTextBox.Location = New System.Drawing.Point(436, 410)
        Me.User_NameTextBox.Name = "User_NameTextBox"
        Me.User_NameTextBox.Size = New System.Drawing.Size(356, 28)
        Me.User_NameTextBox.TabIndex = 14
        '
        'User_PasswordTextBox
        '
        Me.User_PasswordTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.User_PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_Password", True))
        Me.User_PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_PasswordTextBox.Location = New System.Drawing.Point(436, 444)
        Me.User_PasswordTextBox.Name = "User_PasswordTextBox"
        Me.User_PasswordTextBox.Size = New System.Drawing.Size(356, 28)
        Me.User_PasswordTextBox.TabIndex = 16
        Me.User_PasswordTextBox.UseSystemPasswordChar = True
        '
        'rdoFeet
        '
        Me.rdoFeet.AutoSize = True
        Me.rdoFeet.Checked = True
        Me.rdoFeet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdoFeet.ForeColor = System.Drawing.Color.Green
        Me.rdoFeet.Location = New System.Drawing.Point(0, 43)
        Me.rdoFeet.Name = "rdoFeet"
        Me.rdoFeet.Size = New System.Drawing.Size(57, 21)
        Me.rdoFeet.TabIndex = 17
        Me.rdoFeet.TabStop = True
        Me.rdoFeet.Text = "Feet"
        Me.rdoFeet.UseVisualStyleBackColor = True
        '
        'rdoMeters
        '
        Me.rdoMeters.AutoSize = True
        Me.rdoMeters.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdoMeters.ForeColor = System.Drawing.Color.Green
        Me.rdoMeters.Location = New System.Drawing.Point(97, 43)
        Me.rdoMeters.Name = "rdoMeters"
        Me.rdoMeters.Size = New System.Drawing.Size(72, 21)
        Me.rdoMeters.TabIndex = 18
        Me.rdoMeters.Text = "Meters"
        Me.rdoMeters.UseVisualStyleBackColor = True
        '
        'rdoKilograms
        '
        Me.rdoKilograms.AutoSize = True
        Me.rdoKilograms.Checked = True
        Me.rdoKilograms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdoKilograms.ForeColor = System.Drawing.Color.Green
        Me.rdoKilograms.Location = New System.Drawing.Point(0, 43)
        Me.rdoKilograms.Name = "rdoKilograms"
        Me.rdoKilograms.Size = New System.Drawing.Size(91, 21)
        Me.rdoKilograms.TabIndex = 22
        Me.rdoKilograms.TabStop = True
        Me.rdoKilograms.Text = "Kilograms"
        Me.rdoKilograms.UseVisualStyleBackColor = True
        '
        'rdoPound
        '
        Me.rdoPound.AutoSize = True
        Me.rdoPound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdoPound.ForeColor = System.Drawing.Color.Green
        Me.rdoPound.Location = New System.Drawing.Point(97, 43)
        Me.rdoPound.Name = "rdoPound"
        Me.rdoPound.Size = New System.Drawing.Size(70, 21)
        Me.rdoPound.TabIndex = 21
        Me.rdoPound.Text = "Pound"
        Me.rdoPound.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(464, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 38)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Sign Up"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(79, -13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 741)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(160, 18)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(537, 134)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox7.Location = New System.Drawing.Point(166, 25)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(531, 134)
        Me.GroupBox7.TabIndex = 29
        Me.GroupBox7.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(855, -13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 700)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(975, -13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 732)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(-11, -13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(116, 751)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(148, 591)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(735, 104)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox8.Location = New System.Drawing.Point(168, -28)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(702, 116)
        Me.GroupBox8.TabIndex = 29
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "GroupBox8"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Green
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(532, 539)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(185, 46)
        Me.btnConfirm.TabIndex = 30
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Green
        Me.btnCancel.Location = New System.Drawing.Point(723, 539)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(69, 46)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
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
        'txtConfirmPass
        '
        Me.txtConfirmPass.BackColor = System.Drawing.SystemColors.Control
        Me.txtConfirmPass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_AccountBindingSource, "User_Password", True))
        Me.txtConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(436, 478)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(356, 28)
        Me.txtConfirmPass.TabIndex = 33
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'GroupBox9
        '
        Me.GroupBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox9.Controls.Add(Me.lblSH)
        Me.GroupBox9.Controls.Add(Me.lblHeight)
        Me.GroupBox9.Controls.Add(Me.HeightTextBox)
        Me.GroupBox9.Controls.Add(Me.rdoMeters)
        Me.GroupBox9.Controls.Add(Me.rdoFeet)
        Me.GroupBox9.Location = New System.Drawing.Point(436, 275)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(281, 68)
        Me.GroupBox9.TabIndex = 34
        Me.GroupBox9.TabStop = False
        '
        'lblSH
        '
        Me.lblSH.AutoSize = True
        Me.lblSH.ForeColor = System.Drawing.Color.DimGray
        Me.lblSH.Location = New System.Drawing.Point(144, 16)
        Me.lblSH.Name = "lblSH"
        Me.lblSH.Size = New System.Drawing.Size(128, 17)
        Me.lblSH.TabIndex = 20
        Me.lblSH.Text = "(Sample Input: 5.7)"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.ForeColor = System.Drawing.Color.Green
        Me.lblHeight.Location = New System.Drawing.Point(109, 11)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(18, 24)
        Me.lblHeight.TabIndex = 19
        Me.lblHeight.Text = "ft"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.lblSW)
        Me.GroupBox10.Controls.Add(Me.lblWeight)
        Me.GroupBox10.Controls.Add(Me.rdoKilograms)
        Me.GroupBox10.Controls.Add(Me.rdoPound)
        Me.GroupBox10.Controls.Add(Me.WeightTextBox)
        Me.GroupBox10.Location = New System.Drawing.Point(436, 336)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(281, 68)
        Me.GroupBox10.TabIndex = 35
        Me.GroupBox10.TabStop = False
        '
        'lblSW
        '
        Me.lblSW.AutoSize = True
        Me.lblSW.ForeColor = System.Drawing.Color.DimGray
        Me.lblSW.Location = New System.Drawing.Point(144, 17)
        Me.lblSW.Name = "lblSW"
        Me.lblSW.Size = New System.Drawing.Size(124, 17)
        Me.lblSW.TabIndex = 21
        Me.lblSW.Text = "(Sample Input: 50)"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.Green
        Me.lblWeight.Location = New System.Drawing.Point(108, 12)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(30, 24)
        Me.lblWeight.TabIndex = 20
        Me.lblWeight.Text = "kg"
        '
        'chShowPass
        '
        Me.chShowPass.AutoSize = True
        Me.chShowPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chShowPass.ForeColor = System.Drawing.Color.Green
        Me.chShowPass.Location = New System.Drawing.Point(663, 512)
        Me.chShowPass.Name = "chShowPass"
        Me.chShowPass.Size = New System.Drawing.Size(129, 21)
        Me.chShowPass.TabIndex = 36
        Me.chShowPass.Text = "Show Password"
        Me.chShowPass.UseVisualStyleBackColor = True
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
        'New_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1095, 682)
        Me.Controls.Add(Me.chShowPass)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Full_NameLabel)
        Me.Controls.Add(Me.Full_NameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(HeightLabel)
        Me.Controls.Add(WeightLabel)
        Me.Controls.Add(User_NameLabel)
        Me.Controls.Add(Me.User_NameTextBox)
        Me.Controls.Add(User_PasswordLabel)
        Me.Controls.Add(Me.User_PasswordTextBox)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.User_AccountBindingNavigator)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "New_Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calorie Intake Manager"
        CType(Me.User_AccountBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.User_AccountBindingNavigator.ResumeLayout(False)
        Me.User_AccountBindingNavigator.PerformLayout()
        CType(Me.User_AccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAccountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.UsersSecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Full_NameTextBox As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents User_NameTextBox As TextBox
    Friend WithEvents User_PasswordTextBox As TextBox
    Friend WithEvents rdoKilograms As RadioButton
    Friend WithEvents rdoPound As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents rdoFeet As RadioButton
    Friend WithEvents rdoMeters As RadioButton
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents chShowPass As CheckBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblSH As Label
    Friend WithEvents lblSW As Label
    Friend WithEvents UsersSecurityBindingSource As BindingSource
    Friend WithEvents UsersSecurityTableAdapter As UserAccountDataSetTableAdapters.UsersSecurityTableAdapter
End Class
