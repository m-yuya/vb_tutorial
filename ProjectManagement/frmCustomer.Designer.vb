<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.Tbl_customerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_customerTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_customerTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_customerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_customerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_customerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FilternameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.FilternameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_customerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_customerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_customerBindingNavigator.SuspendLayout()
        CType(Me.Tbl_customerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByNameToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Project_jobDataSet
        '
        Me.Project_jobDataSet.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_customerBindingSource
        '
        Me.Tbl_customerBindingSource.DataMember = "tbl_customer"
        Me.Tbl_customerBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Tbl_customerTableAdapter
        '
        Me.Tbl_customerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_customerTableAdapter = Me.Tbl_customerTableAdapter
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_customerBindingNavigator
        '
        Me.Tbl_customerBindingNavigator.AddNewItem = Nothing
        Me.Tbl_customerBindingNavigator.BindingSource = Me.Tbl_customerBindingSource
        Me.Tbl_customerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_customerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_customerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_customerBindingNavigatorSaveItem})
        Me.Tbl_customerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_customerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_customerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_customerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_customerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_customerBindingNavigator.Name = "Tbl_customerBindingNavigator"
        Me.Tbl_customerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_customerBindingNavigator.Size = New System.Drawing.Size(724, 25)
        Me.Tbl_customerBindingNavigator.TabIndex = 0
        Me.Tbl_customerBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_customerBindingNavigatorSaveItem
        '
        Me.Tbl_customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_customerBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_customerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_customerBindingNavigatorSaveItem.Name = "Tbl_customerBindingNavigatorSaveItem"
        Me.Tbl_customerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_customerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_customerDataGridView
        '
        Me.Tbl_customerDataGridView.AllowUserToOrderColumns = True
        Me.Tbl_customerDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbl_customerDataGridView.AutoGenerateColumns = False
        Me.Tbl_customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_customerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Tbl_customerDataGridView.DataSource = Me.Tbl_customerBindingSource
        Me.Tbl_customerDataGridView.Location = New System.Drawing.Point(0, 51)
        Me.Tbl_customerDataGridView.Name = "Tbl_customerDataGridView"
        Me.Tbl_customerDataGridView.RowTemplate.Height = 21
        Me.Tbl_customerDataGridView.Size = New System.Drawing.Size(724, 432)
        Me.Tbl_customerDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "customer_code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "顧客コード"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 85
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "customer_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "顧客名"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "zipcode"
        Me.DataGridViewTextBoxColumn3.HeaderText = "郵便番号"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "住所"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "person"
        Me.DataGridViewTextBoxColumn5.HeaderText = "担当者"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tel"
        Me.DataGridViewTextBoxColumn6.HeaderText = "電話番号"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "rank"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ランク"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "input_date"
        Me.DataGridViewTextBoxColumn8.HeaderText = "入力日"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'FillByNameToolStrip
        '
        Me.FillByNameToolStrip.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.FillByNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilternameToolStripLabel, Me.FilternameToolStripTextBox, Me.FillByNameToolStripButton})
        Me.FillByNameToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByNameToolStrip.Name = "FillByNameToolStrip"
        Me.FillByNameToolStrip.Size = New System.Drawing.Size(724, 25)
        Me.FillByNameToolStrip.TabIndex = 2
        Me.FillByNameToolStrip.Text = "FillByNameToolStrip"
        '
        'FilternameToolStripLabel
        '
        Me.FilternameToolStripLabel.Name = "FilternameToolStripLabel"
        Me.FilternameToolStripLabel.Size = New System.Drawing.Size(46, 22)
        Me.FilternameToolStripLabel.Text = "顧客名:"
        '
        'FilternameToolStripTextBox
        '
        Me.FilternameToolStripTextBox.Name = "FilternameToolStripTextBox"
        Me.FilternameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByNameToolStripButton
        '
        Me.FillByNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByNameToolStripButton.Name = "FillByNameToolStripButton"
        Me.FillByNameToolStripButton.Size = New System.Drawing.Size(77, 22)
        Me.FillByNameToolStripButton.Text = "フィルター実行"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 482)
        Me.Controls.Add(Me.FillByNameToolStrip)
        Me.Controls.Add(Me.Tbl_customerDataGridView)
        Me.Controls.Add(Me.Tbl_customerBindingNavigator)
        Me.Name = "frmCustomer"
        Me.Text = "顧客マスター管理"
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_customerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_customerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_customerBindingNavigator.ResumeLayout(False)
        Me.Tbl_customerBindingNavigator.PerformLayout()
        CType(Me.Tbl_customerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByNameToolStrip.ResumeLayout(False)
        Me.FillByNameToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Project_jobDataSet As project_jobDataSet
    Friend WithEvents Tbl_customerBindingSource As BindingSource
    Friend WithEvents Tbl_customerTableAdapter As project_jobDataSetTableAdapters.tbl_customerTableAdapter
    Friend WithEvents TableAdapterManager As project_jobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_customerBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_customerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_customerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents FillByNameToolStrip As ToolStrip
    Friend WithEvents FilternameToolStripLabel As ToolStripLabel
    Friend WithEvents FilternameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByNameToolStripButton As ToolStripButton
End Class
