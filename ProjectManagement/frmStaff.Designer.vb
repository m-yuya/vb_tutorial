﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim Staff_sectionLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.Tbl_staffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Tbl_staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_jobDataSet1 = New ProjectManagement.Project_jobDataSet1()
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
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_staffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtStaffCode = New System.Windows.Forms.TextBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.txtStaffKana = New System.Windows.Forms.TextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtExtPhone = New System.Windows.Forms.TextBox()
        Me.chkResignFlag = New System.Windows.Forms.CheckBox()
        Me.MemoTextBox = New System.Windows.Forms.TextBox()
        Me.Input_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.Tbl_sectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_staffTableAdapter = New ProjectManagement.Project_jobDataSet1TableAdapters.tbl_staffTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.Project_jobDataSet1TableAdapters.TableAdapterManager()
        Me.Tbl_sectionTableAdapter = New ProjectManagement.Project_jobDataSet1TableAdapters.tbl_sectionTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.データDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoveFirst = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMovePrev = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoveNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoveLast = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
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
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_jobDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_sectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        'Staff_sectionLabel1
        '
        Staff_sectionLabel1.AutoSize = True
        Staff_sectionLabel1.Location = New System.Drawing.Point(27, 140)
        Staff_sectionLabel1.Name = "Staff_sectionLabel1"
        Staff_sectionLabel1.Size = New System.Drawing.Size(59, 12)
        Staff_sectionLabel1.TabIndex = 27
        Staff_sectionLabel1.Text = "所属部署："
        '
        'Tbl_staffBindingNavigator
        '
        Me.Tbl_staffBindingNavigator.AddNewItem = Nothing
        Me.Tbl_staffBindingNavigator.BindingSource = Me.Tbl_staffBindingSource
        Me.Tbl_staffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_staffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_staffBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Tbl_staffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_staffBindingNavigatorSaveItem})
        Me.Tbl_staffBindingNavigator.Location = New System.Drawing.Point(0, 424)
        Me.Tbl_staffBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_staffBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_staffBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_staffBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_staffBindingNavigator.Name = "Tbl_staffBindingNavigator"
        Me.Tbl_staffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_staffBindingNavigator.Size = New System.Drawing.Size(363, 25)
        Me.Tbl_staffBindingNavigator.TabIndex = 0
        Me.Tbl_staffBindingNavigator.Text = "BindingNavigator1"
        '
        'Tbl_staffBindingSource
        '
        Me.Tbl_staffBindingSource.DataMember = "tbl_staff"
        Me.Tbl_staffBindingSource.DataSource = Me.Project_jobDataSet1
        '
        'Project_jobDataSet1
        '
        Me.Project_jobDataSet1.DataSetName = "Project_jobDataSet1"
        Me.Project_jobDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem.ReadOnly = True
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Tbl_staffBindingNavigatorSaveItem
        '
        Me.Tbl_staffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_staffBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_staffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_staffBindingNavigatorSaveItem.Name = "Tbl_staffBindingNavigatorSaveItem"
        Me.Tbl_staffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_staffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtStaffCode
        '
        Me.txtStaffCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_code", True))
        Me.txtStaffCode.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtStaffCode.Location = New System.Drawing.Point(131, 46)
        Me.txtStaffCode.Name = "txtStaffCode"
        Me.txtStaffCode.ReadOnly = True
        Me.txtStaffCode.Size = New System.Drawing.Size(56, 19)
        Me.txtStaffCode.TabIndex = 1
        '
        'txtStaffName
        '
        Me.txtStaffName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_name", True))
        Me.txtStaffName.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtStaffName.Location = New System.Drawing.Point(131, 71)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(141, 19)
        Me.txtStaffName.TabIndex = 2
        '
        'txtStaffKana
        '
        Me.txtStaffKana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_kana", True))
        Me.txtStaffKana.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtStaffKana.Location = New System.Drawing.Point(131, 96)
        Me.txtStaffKana.Name = "txtStaffKana"
        Me.txtStaffKana.Size = New System.Drawing.Size(141, 19)
        Me.txtStaffKana.TabIndex = 3
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "email", True))
        Me.txtEmailAddress.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtEmailAddress.Location = New System.Drawing.Point(131, 171)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(200, 19)
        Me.txtEmailAddress.TabIndex = 5
        '
        'txtExtPhone
        '
        Me.txtExtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "ext_phone", True))
        Me.txtExtPhone.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtExtPhone.Location = New System.Drawing.Point(131, 196)
        Me.txtExtPhone.Name = "txtExtPhone"
        Me.txtExtPhone.Size = New System.Drawing.Size(56, 19)
        Me.txtExtPhone.TabIndex = 6
        '
        'chkResignFlag
        '
        Me.chkResignFlag.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_staffBindingSource, "resign_flag", True))
        Me.chkResignFlag.Location = New System.Drawing.Point(278, 355)
        Me.chkResignFlag.Name = "chkResignFlag"
        Me.chkResignFlag.Size = New System.Drawing.Size(53, 24)
        Me.chkResignFlag.TabIndex = 10
        Me.chkResignFlag.TabStop = False
        Me.chkResignFlag.Text = "退社"
        Me.chkResignFlag.UseVisualStyleBackColor = True
        '
        'MemoTextBox
        '
        Me.MemoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "memo", True))
        Me.MemoTextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.MemoTextBox.Location = New System.Drawing.Point(131, 221)
        Me.MemoTextBox.Multiline = True
        Me.MemoTextBox.Name = "MemoTextBox"
        Me.MemoTextBox.Size = New System.Drawing.Size(200, 128)
        Me.MemoTextBox.TabIndex = 7
        '
        'Input_dateDateTimePicker
        '
        Me.Input_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_staffBindingSource, "input_date", True))
        Me.Input_dateDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Input_dateDateTimePicker.Location = New System.Drawing.Point(131, 356)
        Me.Input_dateDateTimePicker.Name = "Input_dateDateTimePicker"
        Me.Input_dateDateTimePicker.Size = New System.Drawing.Size(124, 19)
        Me.Input_dateDateTimePicker.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbFemale)
        Me.GroupBox1.Controls.Add(Me.rdbMale)
        Me.GroupBox1.Location = New System.Drawing.Point(278, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(65, 77)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "性別"
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(6, 41)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(47, 16)
        Me.rdbFemale.TabIndex = 0
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "女性"
        Me.rdbFemale.UseVisualStyleBackColor = True
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
        'cmbSection
        '
        Me.cmbSection.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_staffBindingSource, "staff_section", True))
        Me.cmbSection.DataSource = Me.Tbl_sectionBindingSource
        Me.cmbSection.DisplayMember = "section_name"
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(131, 137)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(94, 20)
        Me.cmbSection.TabIndex = 4
        Me.cmbSection.ValueMember = "section_code"
        '
        'Tbl_sectionBindingSource
        '
        Me.Tbl_sectionBindingSource.DataMember = "tbl_section"
        Me.Tbl_sectionBindingSource.DataSource = Me.Project_jobDataSet1
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_customerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_jobTableAdapter = Nothing
        Me.TableAdapterManager.tbl_projectTableAdapter = Nothing
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Me.Tbl_staffTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.Project_jobDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_sectionTableAdapter
        '
        Me.Tbl_sectionTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.データDToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(363, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'データDToolStripMenuItem
        '
        Me.データDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMoveFirst, Me.mnuMovePrev, Me.mnuMoveNext, Me.mnuMoveLast, Me.ToolStripSeparator1, Me.MnuNew, Me.mnuDelete, Me.mnuSave, Me.ToolStripSeparator2, Me.mnuMenu})
        Me.データDToolStripMenuItem.Name = "データDToolStripMenuItem"
        Me.データDToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.データDToolStripMenuItem.Text = "データ(&D)"
        '
        'mnuMoveFirst
        '
        Me.mnuMoveFirst.Name = "mnuMoveFirst"
        Me.mnuMoveFirst.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuMoveFirst.Size = New System.Drawing.Size(200, 22)
        Me.mnuMoveFirst.Text = "最初に移動(&F)"
        '
        'mnuMovePrev
        '
        Me.mnuMovePrev.Name = "mnuMovePrev"
        Me.mnuMovePrev.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.mnuMovePrev.Size = New System.Drawing.Size(200, 22)
        Me.mnuMovePrev.Text = "前に戻る(&P)"
        '
        'mnuMoveNext
        '
        Me.mnuMoveNext.Name = "mnuMoveNext"
        Me.mnuMoveNext.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuMoveNext.Size = New System.Drawing.Size(200, 22)
        Me.mnuMoveNext.Text = "次に移動(&N)"
        '
        'mnuMoveLast
        '
        Me.mnuMoveLast.Name = "mnuMoveLast"
        Me.mnuMoveLast.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mnuMoveLast.Size = New System.Drawing.Size(200, 22)
        Me.mnuMoveLast.Text = "最後に移動(&L)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(197, 6)
        '
        'MnuNew
        '
        Me.MnuNew.Name = "MnuNew"
        Me.MnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MnuNew.Size = New System.Drawing.Size(200, 22)
        Me.MnuNew.Text = "新規追加(&A)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.mnuDelete.Size = New System.Drawing.Size(200, 22)
        Me.mnuDelete.Text = "削除(&D)"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(200, 22)
        Me.mnuSave.Text = "データの保存(&U)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(197, 6)
        '
        'mnuMenu
        '
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mnuMenu.Size = New System.Drawing.Size(200, 22)
        Me.mnuMenu.Text = "メニューに戻る(&M)"
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 449)
        Me.Controls.Add(Staff_sectionLabel1)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Staff_codeLabel)
        Me.Controls.Add(Me.txtStaffCode)
        Me.Controls.Add(Staff_nameLabel)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Staff_kanaLabel)
        Me.Controls.Add(Me.txtStaffKana)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Ext_phoneLabel)
        Me.Controls.Add(Me.txtExtPhone)
        Me.Controls.Add(Me.chkResignFlag)
        Me.Controls.Add(MemoLabel)
        Me.Controls.Add(Me.MemoTextBox)
        Me.Controls.Add(Input_dateLabel)
        Me.Controls.Add(Me.Input_dateDateTimePicker)
        Me.Controls.Add(Me.Tbl_staffBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmStaff"
        Me.Text = "スタッフマスター管理"
        CType(Me.Tbl_staffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_staffBindingNavigator.ResumeLayout(False)
        Me.Tbl_staffBindingNavigator.PerformLayout()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_jobDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_sectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Project_jobDataSet1 As Project_jobDataSet1
    Friend WithEvents Tbl_staffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As Project_jobDataSet1TableAdapters.tbl_staffTableAdapter
    Friend WithEvents TableAdapterManager As Project_jobDataSet1TableAdapters.TableAdapterManager
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
    Friend WithEvents txtStaffCode As TextBox
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtStaffKana As TextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtExtPhone As TextBox
    Friend WithEvents chkResignFlag As CheckBox
    Friend WithEvents MemoTextBox As TextBox
    Friend WithEvents Input_dateDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents Tbl_sectionBindingSource As BindingSource
    Friend WithEvents Tbl_sectionTableAdapter As Project_jobDataSet1TableAdapters.tbl_sectionTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents データDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuMoveFirst As ToolStripMenuItem
    Friend WithEvents mnuMovePrev As ToolStripMenuItem
    Friend WithEvents mnuMoveNext As ToolStripMenuItem
    Friend WithEvents mnuMoveLast As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MnuNew As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuMenu As ToolStripMenuItem
End Class
