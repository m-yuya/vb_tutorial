<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject
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
        Dim Project_codeLabel As System.Windows.Forms.Label
        Dim Project_nameLabel As System.Windows.Forms.Label
        Dim Customer_codeLabel As System.Windows.Forms.Label
        Dim Staff_codeLabel As System.Windows.Forms.Label
        Dim Start_dateLabel As System.Windows.Forms.Label
        Dim End_dateLabel As System.Windows.Forms.Label
        Dim MemoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProject))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Tbl_projectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.Tbl_customerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbManager = New System.Windows.Forms.ComboBox()
        Me.Tbl_staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.chkCompleteFlag = New System.Windows.Forms.CheckBox()
        Me.Tbl_projectTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_projectTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_customerTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_customerTableAdapter()
        Me.Tbl_staffTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_staffTableAdapter()
        Me.Tbl_projectBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_projectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Tbl_jobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_jobTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_jobTableAdapter()
        Me.Tbl_jobDataGridView = New System.Windows.Forms.DataGridView()
        Me.TblstaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staff_code = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Project_codeLabel = New System.Windows.Forms.Label()
        Project_nameLabel = New System.Windows.Forms.Label()
        Customer_codeLabel = New System.Windows.Forms.Label()
        Staff_codeLabel = New System.Windows.Forms.Label()
        Start_dateLabel = New System.Windows.Forms.Label()
        End_dateLabel = New System.Windows.Forms.Label()
        MemoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_projectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_customerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_projectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_projectBindingNavigator.SuspendLayout()
        CType(Me.Tbl_jobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_jobDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Project_codeLabel
        '
        Project_codeLabel.AutoSize = True
        Project_codeLabel.Location = New System.Drawing.Point(16, 35)
        Project_codeLabel.Name = "Project_codeLabel"
        Project_codeLabel.Size = New System.Drawing.Size(89, 12)
        Project_codeLabel.TabIndex = 0
        Project_codeLabel.Text = "プロジェクトコード："
        '
        'Project_nameLabel
        '
        Project_nameLabel.AutoSize = True
        Project_nameLabel.Location = New System.Drawing.Point(16, 60)
        Project_nameLabel.Name = "Project_nameLabel"
        Project_nameLabel.Size = New System.Drawing.Size(74, 12)
        Project_nameLabel.TabIndex = 2
        Project_nameLabel.Text = "プロジェクト名："
        '
        'Customer_codeLabel
        '
        Customer_codeLabel.AutoSize = True
        Customer_codeLabel.Location = New System.Drawing.Point(16, 85)
        Customer_codeLabel.Name = "Customer_codeLabel"
        Customer_codeLabel.Size = New System.Drawing.Size(35, 12)
        Customer_codeLabel.TabIndex = 4
        Customer_codeLabel.Text = "顧客："
        '
        'Staff_codeLabel
        '
        Staff_codeLabel.AutoSize = True
        Staff_codeLabel.Location = New System.Drawing.Point(16, 111)
        Staff_codeLabel.Name = "Staff_codeLabel"
        Staff_codeLabel.Size = New System.Drawing.Size(68, 12)
        Staff_codeLabel.TabIndex = 6
        Staff_codeLabel.Text = "マネージャー："
        '
        'Start_dateLabel
        '
        Start_dateLabel.AutoSize = True
        Start_dateLabel.Location = New System.Drawing.Point(16, 138)
        Start_dateLabel.Name = "Start_dateLabel"
        Start_dateLabel.Size = New System.Drawing.Size(47, 12)
        Start_dateLabel.TabIndex = 8
        Start_dateLabel.Text = "開始日："
        '
        'End_dateLabel
        '
        End_dateLabel.AutoSize = True
        End_dateLabel.Location = New System.Drawing.Point(16, 163)
        End_dateLabel.Name = "End_dateLabel"
        End_dateLabel.Size = New System.Drawing.Size(47, 12)
        End_dateLabel.TabIndex = 10
        End_dateLabel.Text = "終了日："
        '
        'MemoLabel
        '
        MemoLabel.AutoSize = True
        MemoLabel.Location = New System.Drawing.Point(16, 187)
        MemoLabel.Name = "MemoLabel"
        MemoLabel.Size = New System.Drawing.Size(28, 12)
        MemoLabel.TabIndex = 12
        MemoLabel.Text = "メモ："
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Project_codeLabel)
        Me.Panel1.Controls.Add(Me.txtProjectCode)
        Me.Panel1.Controls.Add(Project_nameLabel)
        Me.Panel1.Controls.Add(Me.txtProjectName)
        Me.Panel1.Controls.Add(Customer_codeLabel)
        Me.Panel1.Controls.Add(Me.cmbCustomer)
        Me.Panel1.Controls.Add(Staff_codeLabel)
        Me.Panel1.Controls.Add(Me.cmbManager)
        Me.Panel1.Controls.Add(Start_dateLabel)
        Me.Panel1.Controls.Add(Me.dtpStartDate)
        Me.Panel1.Controls.Add(End_dateLabel)
        Me.Panel1.Controls.Add(Me.dtpEndDate)
        Me.Panel1.Controls.Add(MemoLabel)
        Me.Panel1.Controls.Add(Me.txtMemo)
        Me.Panel1.Controls.Add(Me.chkCompleteFlag)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 284)
        Me.Panel1.TabIndex = 0
        '
        'txtProjectCode
        '
        Me.txtProjectCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_projectBindingSource, "project_code", True))
        Me.txtProjectCode.Location = New System.Drawing.Point(113, 31)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(103, 19)
        Me.txtProjectCode.TabIndex = 1
        '
        'Tbl_projectBindingSource
        '
        Me.Tbl_projectBindingSource.DataMember = "tbl_project"
        Me.Tbl_projectBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Project_jobDataSet
        '
        Me.Project_jobDataSet.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtProjectName
        '
        Me.txtProjectName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_projectBindingSource, "project_name", True))
        Me.txtProjectName.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtProjectName.Location = New System.Drawing.Point(113, 56)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(320, 19)
        Me.txtProjectName.TabIndex = 3
        '
        'cmbCustomer
        '
        Me.cmbCustomer.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_projectBindingSource, "customer_code", True))
        Me.cmbCustomer.DataSource = Me.Tbl_customerBindingSource
        Me.cmbCustomer.DisplayMember = "customer_name"
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(113, 81)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(320, 20)
        Me.cmbCustomer.TabIndex = 5
        Me.cmbCustomer.ValueMember = "customer_code"
        '
        'Tbl_customerBindingSource
        '
        Me.Tbl_customerBindingSource.DataMember = "tbl_customer"
        Me.Tbl_customerBindingSource.DataSource = Me.Project_jobDataSet
        '
        'cmbManager
        '
        Me.cmbManager.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_projectBindingSource, "staff_code", True))
        Me.cmbManager.DataSource = Me.Tbl_staffBindingSource
        Me.cmbManager.DisplayMember = "staff_name"
        Me.cmbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbManager.FormattingEnabled = True
        Me.cmbManager.Location = New System.Drawing.Point(113, 107)
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(200, 20)
        Me.cmbManager.TabIndex = 7
        Me.cmbManager.ValueMember = "staff_code"
        '
        'Tbl_staffBindingSource
        '
        Me.Tbl_staffBindingSource.DataMember = "tbl_staff"
        Me.Tbl_staffBindingSource.DataSource = Me.Project_jobDataSet
        '
        'dtpStartDate
        '
        Me.dtpStartDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_projectBindingSource, "start_date", True))
        Me.dtpStartDate.Location = New System.Drawing.Point(113, 133)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 19)
        Me.dtpStartDate.TabIndex = 9
        '
        'dtpEndDate
        '
        Me.dtpEndDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_projectBindingSource, "end_date", True))
        Me.dtpEndDate.Location = New System.Drawing.Point(113, 158)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 19)
        Me.dtpEndDate.TabIndex = 11
        '
        'txtMemo
        '
        Me.txtMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_projectBindingSource, "memo", True))
        Me.txtMemo.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtMemo.Location = New System.Drawing.Point(113, 183)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(445, 83)
        Me.txtMemo.TabIndex = 13
        '
        'chkCompleteFlag
        '
        Me.chkCompleteFlag.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_projectBindingSource, "complete_flag", True))
        Me.chkCompleteFlag.Location = New System.Drawing.Point(499, 30)
        Me.chkCompleteFlag.Name = "chkCompleteFlag"
        Me.chkCompleteFlag.Size = New System.Drawing.Size(50, 24)
        Me.chkCompleteFlag.TabIndex = 15
        Me.chkCompleteFlag.Text = "完了"
        Me.chkCompleteFlag.UseVisualStyleBackColor = True
        '
        'Tbl_projectTableAdapter
        '
        Me.Tbl_projectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_customerTableAdapter = Me.Tbl_customerTableAdapter
        Me.TableAdapterManager.tbl_jobTableAdapter = Nothing
        Me.TableAdapterManager.tbl_projectTableAdapter = Me.Tbl_projectTableAdapter
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Me.Tbl_staffTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_customerTableAdapter
        '
        Me.Tbl_customerTableAdapter.ClearBeforeFill = True
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'Tbl_projectBindingNavigator
        '
        Me.Tbl_projectBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_projectBindingNavigator.BindingSource = Me.Tbl_projectBindingSource
        Me.Tbl_projectBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_projectBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_projectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_projectBindingNavigatorSaveItem})
        Me.Tbl_projectBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_projectBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_projectBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_projectBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_projectBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_projectBindingNavigator.Name = "Tbl_projectBindingNavigator"
        Me.Tbl_projectBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_projectBindingNavigator.Size = New System.Drawing.Size(684, 25)
        Me.Tbl_projectBindingNavigator.TabIndex = 1
        Me.Tbl_projectBindingNavigator.Text = "BindingNavigator1"
        Me.Tbl_projectBindingNavigator.Visible = False
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
        'Tbl_projectBindingNavigatorSaveItem
        '
        Me.Tbl_projectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_projectBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_projectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_projectBindingNavigatorSaveItem.Name = "Tbl_projectBindingNavigatorSaveItem"
        Me.Tbl_projectBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_projectBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(597, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "戻る"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(597, 51)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "登録"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(597, 88)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Tbl_jobBindingSource
        '
        Me.Tbl_jobBindingSource.DataMember = "tbl_job"
        Me.Tbl_jobBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Tbl_jobTableAdapter
        '
        Me.Tbl_jobTableAdapter.ClearBeforeFill = True
        '
        'Tbl_jobDataGridView
        '
        Me.Tbl_jobDataGridView.AllowUserToAddRows = False
        Me.Tbl_jobDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_jobDataGridView.AutoGenerateColumns = False
        Me.Tbl_jobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_jobDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.staff_code, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1})
        Me.Tbl_jobDataGridView.DataSource = Me.Tbl_jobBindingSource
        Me.Tbl_jobDataGridView.Location = New System.Drawing.Point(12, 302)
        Me.Tbl_jobDataGridView.Name = "Tbl_jobDataGridView"
        Me.Tbl_jobDataGridView.ReadOnly = True
        Me.Tbl_jobDataGridView.RowTemplate.Height = 21
        Me.Tbl_jobDataGridView.Size = New System.Drawing.Size(579, 220)
        Me.Tbl_jobDataGridView.TabIndex = 5
        '
        'TblstaffBindingSource
        '
        Me.TblstaffBindingSource.DataMember = "tbl_staff"
        Me.TblstaffBindingSource.DataSource = Me.Project_jobDataSet
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "job_number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 30
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "job_title"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ジョブタイトル"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 135
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "staff_code"
        Me.DataGridViewTextBoxColumn4.HeaderText = "スタッフコード"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'staff_code
        '
        Me.staff_code.DataPropertyName = "staff_code"
        Me.staff_code.DataSource = Me.TblstaffBindingSource
        Me.staff_code.DisplayMember = "staff_name"
        Me.staff_code.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.staff_code.HeaderText = "スタッフ名"
        Me.staff_code.Name = "staff_code"
        Me.staff_code.ReadOnly = True
        Me.staff_code.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.staff_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.staff_code.ValueMember = "staff_code"
        Me.staff_code.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "start_date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "開始日"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "end_date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "終了日"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "complete_flag"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "完了"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 40
        '
        'frmProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 567)
        Me.Controls.Add(Me.Tbl_jobDataGridView)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Tbl_projectBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmProject"
        Me.Text = "プロジェクト管理"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_projectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_customerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_projectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_projectBindingNavigator.ResumeLayout(False)
        Me.Tbl_projectBindingNavigator.PerformLayout()
        CType(Me.Tbl_jobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_jobDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Project_jobDataSet As project_jobDataSet
    Friend WithEvents Tbl_projectBindingSource As BindingSource
    Friend WithEvents Tbl_projectTableAdapter As project_jobDataSetTableAdapters.tbl_projectTableAdapter
    Friend WithEvents TableAdapterManager As project_jobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_projectBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_projectBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtProjectCode As TextBox
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents cmbManager As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents txtMemo As TextBox
    Friend WithEvents chkCompleteFlag As CheckBox
    Friend WithEvents Tbl_customerTableAdapter As project_jobDataSetTableAdapters.tbl_customerTableAdapter
    Friend WithEvents Tbl_customerBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As project_jobDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents Tbl_staffBindingSource As BindingSource
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Tbl_jobBindingSource As BindingSource
    Friend WithEvents Tbl_jobTableAdapter As project_jobDataSetTableAdapters.tbl_jobTableAdapter
    Friend WithEvents Tbl_jobDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents staff_code As DataGridViewComboBoxColumn
    Friend WithEvents TblstaffBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
