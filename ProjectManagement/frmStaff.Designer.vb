<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Staff_codeLabel As System.Windows.Forms.Label
        Dim Staff_nameLabel As System.Windows.Forms.Label
        Dim Staff_kanaLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Ext_phoneLabel As System.Windows.Forms.Label
        Dim MemoLabel As System.Windows.Forms.Label
        Dim Input_dateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Dim Staff_sectionLabel1 As System.Windows.Forms.Label
        Me.Tbl_staffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_staffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Staff_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_kanaTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Ext_phoneTextBox = New System.Windows.Forms.TextBox()
        Me.Resign_flagCheckBox = New System.Windows.Forms.CheckBox()
        Me.MemoTextBox = New System.Windows.Forms.TextBox()
        Me.Input_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.Staff_sectionComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.Tbl_staffTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_staffTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_sectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_sectionTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_sectionTableAdapter()
        Staff_codeLabel = New System.Windows.Forms.Label()
        Staff_nameLabel = New System.Windows.Forms.Label()
        Staff_kanaLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Ext_phoneLabel = New System.Windows.Forms.Label()
        MemoLabel = New System.Windows.Forms.Label()
        Input_dateLabel = New System.Windows.Forms.Label()
        Staff_sectionLabel1 = New System.Windows.Forms.Label()
        CType(Me.Tbl_staffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_staffBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_sectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Staff_codeLabel
        '
        Staff_codeLabel.AutoSize = True
        Staff_codeLabel.Location = New System.Drawing.Point(27, 49)
        Staff_codeLabel.Name = "Staff_codeLabel"
        Staff_codeLabel.Size = New System.Drawing.Size(70, 12)
        Staff_codeLabel.TabIndex = 1
        Staff_codeLabel.Text = "スタッフコード："
        AddHandler Staff_codeLabel.Click, AddressOf Me.Staff_codeLabel_Click
        '
        'Staff_nameLabel
        '
        Staff_nameLabel.AutoSize = True
        Staff_nameLabel.Location = New System.Drawing.Point(27, 74)
        Staff_nameLabel.Name = "Staff_nameLabel"
        Staff_nameLabel.Size = New System.Drawing.Size(55, 12)
        Staff_nameLabel.TabIndex = 3
        Staff_nameLabel.Text = "スタッフ名："
        '
        'Staff_kanaLabel
        '
        Staff_kanaLabel.AutoSize = True
        Staff_kanaLabel.Location = New System.Drawing.Point(27, 99)
        Staff_kanaLabel.Name = "Staff_kanaLabel"
        Staff_kanaLabel.Size = New System.Drawing.Size(74, 12)
        Staff_kanaLabel.TabIndex = 5
        Staff_kanaLabel.Text = "スタッフ名カナ："
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(27, 174)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(99, 12)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "電子メールアドレス："
        '
        'Ext_phoneLabel
        '
        Ext_phoneLabel.AutoSize = True
        Ext_phoneLabel.Location = New System.Drawing.Point(27, 199)
        Ext_phoneLabel.Name = "Ext_phoneLabel"
        Ext_phoneLabel.Size = New System.Drawing.Size(59, 12)
        Ext_phoneLabel.TabIndex = 13
        Ext_phoneLabel.Text = "内線番号："
        '
        'MemoLabel
        '
        MemoLabel.AutoSize = True
        MemoLabel.Location = New System.Drawing.Point(27, 224)
        MemoLabel.Name = "MemoLabel"
        MemoLabel.Size = New System.Drawing.Size(35, 12)
        MemoLabel.TabIndex = 21
        MemoLabel.Text = "備考："
        '
        'Input_dateLabel
        '
        Input_dateLabel.AutoSize = True
        Input_dateLabel.Location = New System.Drawing.Point(27, 360)
        Input_dateLabel.Name = "Input_dateLabel"
        Input_dateLabel.Size = New System.Drawing.Size(47, 12)
        Input_dateLabel.TabIndex = 25
        Input_dateLabel.Text = "入力日："
        '
        'Tbl_staffBindingNavigator
        '
        Me.Tbl_staffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_staffBindingNavigator.BindingSource = Me.Tbl_staffBindingSource
        Me.Tbl_staffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_staffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_staffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_staffBindingNavigatorSaveItem})
        Me.Tbl_staffBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_staffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_staffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_staffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_staffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_staffBindingNavigator.Name = "Tbl_staffBindingNavigator"
        Me.Tbl_staffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_staffBindingNavigator.Size = New System.Drawing.Size(363, 25)
        Me.Tbl_staffBindingNavigator.TabIndex = 0
        Me.Tbl_staffBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tbl_staffBindingNavigatorSaveItem
        '
        Me.Tbl_staffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_staffBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_staffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_staffBindingNavigatorSaveItem.Name = "Tbl_staffBindingNavigatorSaveItem"
        Me.Tbl_staffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_staffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Staff_codeTextBox
        '
        Me.Staff_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_code", True))
        Me.Staff_codeTextBox.Location = New System.Drawing.Point(131, 46)
        Me.Staff_codeTextBox.Name = "Staff_codeTextBox"
        Me.Staff_codeTextBox.Size = New System.Drawing.Size(56, 19)
        Me.Staff_codeTextBox.TabIndex = 2
        '
        'Staff_nameTextBox
        '
        Me.Staff_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_name", True))
        Me.Staff_nameTextBox.Location = New System.Drawing.Point(131, 71)
        Me.Staff_nameTextBox.Name = "Staff_nameTextBox"
        Me.Staff_nameTextBox.Size = New System.Drawing.Size(141, 19)
        Me.Staff_nameTextBox.TabIndex = 4
        '
        'Staff_kanaTextBox
        '
        Me.Staff_kanaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_kana", True))
        Me.Staff_kanaTextBox.Location = New System.Drawing.Point(131, 96)
        Me.Staff_kanaTextBox.Name = "Staff_kanaTextBox"
        Me.Staff_kanaTextBox.Size = New System.Drawing.Size(141, 19)
        Me.Staff_kanaTextBox.TabIndex = 6
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(131, 171)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 19)
        Me.EmailTextBox.TabIndex = 12
        '
        'Ext_phoneTextBox
        '
        Me.Ext_phoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "ext_phone", True))
        Me.Ext_phoneTextBox.Location = New System.Drawing.Point(131, 196)
        Me.Ext_phoneTextBox.Name = "Ext_phoneTextBox"
        Me.Ext_phoneTextBox.Size = New System.Drawing.Size(56, 19)
        Me.Ext_phoneTextBox.TabIndex = 14
        '
        'Resign_flagCheckBox
        '
        Me.Resign_flagCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_staffBindingSource, "resign_flag", True))
        Me.Resign_flagCheckBox.Location = New System.Drawing.Point(278, 355)
        Me.Resign_flagCheckBox.Name = "Resign_flagCheckBox"
        Me.Resign_flagCheckBox.Size = New System.Drawing.Size(53, 24)
        Me.Resign_flagCheckBox.TabIndex = 16
        Me.Resign_flagCheckBox.Text = "退社"
        Me.Resign_flagCheckBox.UseVisualStyleBackColor = True
        '
        'MemoTextBox
        '
        Me.MemoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "memo", True))
        Me.MemoTextBox.Location = New System.Drawing.Point(131, 221)
        Me.MemoTextBox.Multiline = True
        Me.MemoTextBox.Name = "MemoTextBox"
        Me.MemoTextBox.Size = New System.Drawing.Size(200, 128)
        Me.MemoTextBox.TabIndex = 22
        '
        'Input_dateDateTimePicker
        '
        Me.Input_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_staffBindingSource, "input_date", True))
        Me.Input_dateDateTimePicker.Location = New System.Drawing.Point(131, 356)
        Me.Input_dateDateTimePicker.Name = "Input_dateDateTimePicker"
        Me.Input_dateDateTimePicker.Size = New System.Drawing.Size(124, 19)
        Me.Input_dateDateTimePicker.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbFemale)
        Me.GroupBox1.Controls.Add(Me.rdbMale)
        Me.GroupBox1.Location = New System.Drawing.Point(278, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(65, 77)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "性別"
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Location = New System.Drawing.Point(7, 19)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(47, 16)
        Me.rdbMale.TabIndex = 0
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "男性"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(6, 41)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(47, 16)
        Me.rdbFemale.TabIndex = 1
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "女性"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'Staff_sectionLabel1
        '
        Staff_sectionLabel1.AutoSize = True
        Staff_sectionLabel1.Location = New System.Drawing.Point(27, 140)
        Staff_sectionLabel1.Name = "Staff_sectionLabel1"
        Staff_sectionLabel1.Size = New System.Drawing.Size(59, 12)
        Staff_sectionLabel1.TabIndex = 27
        Staff_sectionLabel1.Text = "所属部署："
        '
        'Staff_sectionComboBox
        '
        Me.Staff_sectionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_staffBindingSource, "staff_section", True))
        Me.Staff_sectionComboBox.DataSource = Me.Tbl_sectionBindingSource
        Me.Staff_sectionComboBox.DisplayMember = "section_name"
        Me.Staff_sectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Staff_sectionComboBox.FormattingEnabled = True
        Me.Staff_sectionComboBox.Location = New System.Drawing.Point(131, 137)
        Me.Staff_sectionComboBox.Name = "Staff_sectionComboBox"
        Me.Staff_sectionComboBox.Size = New System.Drawing.Size(94, 20)
        Me.Staff_sectionComboBox.TabIndex = 28
        Me.Staff_sectionComboBox.ValueMember = "section_code"
        '
        'Tbl_staffBindingSource
        '
        Me.Tbl_staffBindingSource.DataMember = "tbl_staff"
        Me.Tbl_staffBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Project_jobDataSet
        '
        Me.Project_jobDataSet.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Me.Tbl_staffTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_sectionBindingSource
        '
        Me.Tbl_sectionBindingSource.DataMember = "tbl_section"
        Me.Tbl_sectionBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Tbl_sectionTableAdapter
        '
        Me.Tbl_sectionTableAdapter.ClearBeforeFill = True
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 399)
        Me.Controls.Add(Staff_sectionLabel1)
        Me.Controls.Add(Me.Staff_sectionComboBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Staff_codeLabel)
        Me.Controls.Add(Me.Staff_codeTextBox)
        Me.Controls.Add(Staff_nameLabel)
        Me.Controls.Add(Me.Staff_nameTextBox)
        Me.Controls.Add(Staff_kanaLabel)
        Me.Controls.Add(Me.Staff_kanaTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Ext_phoneLabel)
        Me.Controls.Add(Me.Ext_phoneTextBox)
        Me.Controls.Add(Me.Resign_flagCheckBox)
        Me.Controls.Add(MemoLabel)
        Me.Controls.Add(Me.MemoTextBox)
        Me.Controls.Add(Input_dateLabel)
        Me.Controls.Add(Me.Input_dateDateTimePicker)
        Me.Controls.Add(Me.Tbl_staffBindingNavigator)
        Me.Name = "frmStaff"
        Me.Text = "スタッフマスター管理"
        CType(Me.Tbl_staffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_staffBindingNavigator.ResumeLayout(False)
        Me.Tbl_staffBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_sectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Project_jobDataSet As project_jobDataSet
    Friend WithEvents Tbl_staffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As project_jobDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents TableAdapterManager As project_jobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_staffBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_staffBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Staff_codeTextBox As TextBox
    Friend WithEvents Staff_nameTextBox As TextBox
    Friend WithEvents Staff_kanaTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Ext_phoneTextBox As TextBox
    Friend WithEvents Resign_flagCheckBox As CheckBox
    Friend WithEvents MemoTextBox As TextBox
    Friend WithEvents Input_dateDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents Staff_sectionComboBox As ComboBox
    Friend WithEvents Tbl_sectionBindingSource As BindingSource
    Friend WithEvents Tbl_sectionTableAdapter As project_jobDataSetTableAdapters.tbl_sectionTableAdapter
End Class
