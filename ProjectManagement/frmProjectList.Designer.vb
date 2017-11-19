<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectList))
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.Vw_projectlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_projectlistTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.vw_projectlistTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Vw_projectlistBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Vw_projectlistBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.grdProjectList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.cmbManager = New System.Windows.Forms.ComboBox()
        Me.chkComplete = New System.Windows.Forms.CheckBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnCard = New System.Windows.Forms.Button()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_projectlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_projectlistBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vw_projectlistBindingNavigator.SuspendLayout()
        CType(Me.grdProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Project_jobDataSet
        '
        Me.Project_jobDataSet.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_projectlistBindingSource
        '
        Me.Vw_projectlistBindingSource.DataMember = "vw_projectlist"
        Me.Vw_projectlistBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Vw_projectlistTableAdapter
        '
        Me.Vw_projectlistTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_customerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Vw_projectlistBindingNavigator
        '
        Me.Vw_projectlistBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vw_projectlistBindingNavigator.BindingSource = Me.Vw_projectlistBindingSource
        Me.Vw_projectlistBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vw_projectlistBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Vw_projectlistBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Vw_projectlistBindingNavigatorSaveItem})
        Me.Vw_projectlistBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vw_projectlistBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vw_projectlistBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vw_projectlistBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vw_projectlistBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vw_projectlistBindingNavigator.Name = "Vw_projectlistBindingNavigator"
        Me.Vw_projectlistBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vw_projectlistBindingNavigator.Size = New System.Drawing.Size(704, 25)
        Me.Vw_projectlistBindingNavigator.TabIndex = 0
        Me.Vw_projectlistBindingNavigator.Text = "BindingNavigator1"
        Me.Vw_projectlistBindingNavigator.Visible = False
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
        'Vw_projectlistBindingNavigatorSaveItem
        '
        Me.Vw_projectlistBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vw_projectlistBindingNavigatorSaveItem.Enabled = False
        Me.Vw_projectlistBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vw_projectlistBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vw_projectlistBindingNavigatorSaveItem.Name = "Vw_projectlistBindingNavigatorSaveItem"
        Me.Vw_projectlistBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Vw_projectlistBindingNavigatorSaveItem.Text = "Save Data"
        '
        'grdProjectList
        '
        Me.grdProjectList.AllowUserToAddRows = False
        Me.grdProjectList.AllowUserToDeleteRows = False
        Me.grdProjectList.AutoGenerateColumns = False
        Me.grdProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProjectList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1})
        Me.grdProjectList.DataSource = Me.Vw_projectlistBindingSource
        Me.grdProjectList.Location = New System.Drawing.Point(12, 51)
        Me.grdProjectList.Name = "grdProjectList"
        Me.grdProjectList.ReadOnly = True
        Me.grdProjectList.RowTemplate.Height = 21
        Me.grdProjectList.Size = New System.Drawing.Size(680, 378)
        Me.grdProjectList.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "project_code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "プロジェクトコード"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "project_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "プロジェクト名"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "customer_name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "顧客名"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 145
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "staff_name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "マネージャー名"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 90
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "プロジェクト名："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "顧客："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "マネージャー："
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(87, 4)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(185, 19)
        Me.txtProjectName.TabIndex = 5
        '
        'cmbCustomer
        '
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(87, 25)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(166, 20)
        Me.cmbCustomer.TabIndex = 6
        '
        'cmbManager
        '
        Me.cmbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbManager.FormattingEnabled = True
        Me.cmbManager.Location = New System.Drawing.Point(350, 25)
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(166, 20)
        Me.cmbManager.TabIndex = 7
        '
        'chkComplete
        '
        Me.chkComplete.AutoSize = True
        Me.chkComplete.Location = New System.Drawing.Point(278, 6)
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.Size = New System.Drawing.Size(107, 16)
        Me.chkComplete.TabIndex = 8
        Me.chkComplete.Text = "完了データを含む"
        Me.chkComplete.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(525, 2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(85, 23)
        Me.btnFilter.TabIndex = 9
        Me.btnFilter.Text = "フィルター実行"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(617, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "戻る"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(12, 435)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "新規追加"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnCard
        '
        Me.btnCard.Location = New System.Drawing.Point(617, 435)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(75, 23)
        Me.btnCard.TabIndex = 12
        Me.btnCard.Text = "カード表示"
        Me.btnCard.UseVisualStyleBackColor = True
        '
        'frmProjectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 461)
        Me.Controls.Add(Me.btnCard)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.chkComplete)
        Me.Controls.Add(Me.cmbManager)
        Me.Controls.Add(Me.cmbCustomer)
        Me.Controls.Add(Me.txtProjectName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdProjectList)
        Me.Controls.Add(Me.Vw_projectlistBindingNavigator)
        Me.Name = "frmProjectList"
        Me.Text = "プロジェクト一覧"
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_projectlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_projectlistBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vw_projectlistBindingNavigator.ResumeLayout(False)
        Me.Vw_projectlistBindingNavigator.PerformLayout()
        CType(Me.grdProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Project_jobDataSet As project_jobDataSet
    Friend WithEvents Vw_projectlistBindingSource As BindingSource
    Friend WithEvents Vw_projectlistTableAdapter As project_jobDataSetTableAdapters.vw_projectlistTableAdapter
    Friend WithEvents TableAdapterManager As project_jobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Vw_projectlistBindingNavigator As BindingNavigator
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
    Friend WithEvents Vw_projectlistBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents grdProjectList As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents cmbManager As ComboBox
    Friend WithEvents chkComplete As CheckBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnCard As Button
End Class
