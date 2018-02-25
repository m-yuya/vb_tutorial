<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSection))
        Me.Project_jobDataSet1 = New ProjectManagement.Project_jobDataSet1()
        Me.Tbl_sectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_sectionTableAdapter = New ProjectManagement.Project_jobDataSet1TableAdapters.tbl_sectionTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.Project_jobDataSet1TableAdapters.TableAdapterManager()
        Me.Tbl_sectionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_sectionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_sectionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Project_jobDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_sectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_sectionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_sectionBindingNavigator.SuspendLayout()
        CType(Me.Tbl_sectionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Project_jobDataSet1
        '
        Me.Project_jobDataSet1.DataSetName = "Project_jobDataSet1"
        Me.Project_jobDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_sectionBindingSource
        '
        Me.Tbl_sectionBindingSource.DataMember = "tbl_section"
        Me.Tbl_sectionBindingSource.DataSource = Me.Project_jobDataSet1
        '
        'Tbl_sectionTableAdapter
        '
        Me.Tbl_sectionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_customerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_jobTableAdapter = Nothing
        Me.TableAdapterManager.tbl_projectTableAdapter = Nothing
        Me.TableAdapterManager.tbl_sectionTableAdapter = Me.Tbl_sectionTableAdapter
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.Project_jobDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_sectionBindingNavigator
        '
        Me.Tbl_sectionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_sectionBindingNavigator.BindingSource = Me.Tbl_sectionBindingSource
        Me.Tbl_sectionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_sectionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_sectionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_sectionBindingNavigatorSaveItem})
        Me.Tbl_sectionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_sectionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_sectionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_sectionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_sectionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_sectionBindingNavigator.Name = "Tbl_sectionBindingNavigator"
        Me.Tbl_sectionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_sectionBindingNavigator.Size = New System.Drawing.Size(299, 25)
        Me.Tbl_sectionBindingNavigator.TabIndex = 0
        Me.Tbl_sectionBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Tbl_sectionBindingNavigatorSaveItem
        '
        Me.Tbl_sectionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_sectionBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_sectionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_sectionBindingNavigatorSaveItem.Name = "Tbl_sectionBindingNavigatorSaveItem"
        Me.Tbl_sectionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Tbl_sectionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_sectionDataGridView
        '
        Me.Tbl_sectionDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbl_sectionDataGridView.AutoGenerateColumns = False
        Me.Tbl_sectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_sectionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_sectionDataGridView.DataSource = Me.Tbl_sectionBindingSource
        Me.Tbl_sectionDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.Tbl_sectionDataGridView.Name = "Tbl_sectionDataGridView"
        Me.Tbl_sectionDataGridView.RowTemplate.Height = 21
        Me.Tbl_sectionDataGridView.Size = New System.Drawing.Size(275, 174)
        Me.Tbl_sectionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "section_code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "部署コード"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "section_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "部署名"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 214)
        Me.Controls.Add(Me.Tbl_sectionDataGridView)
        Me.Controls.Add(Me.Tbl_sectionBindingNavigator)
        Me.Name = "frmSection"
        Me.Text = "部署マスター管理"
        CType(Me.Project_jobDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_sectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_sectionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_sectionBindingNavigator.ResumeLayout(False)
        Me.Tbl_sectionBindingNavigator.PerformLayout()
        CType(Me.Tbl_sectionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Project_jobDataSet1 As Project_jobDataSet1
    Friend WithEvents Tbl_sectionBindingSource As BindingSource
    Friend WithEvents Tbl_sectionTableAdapter As Project_jobDataSet1TableAdapters.tbl_sectionTableAdapter
    Friend WithEvents TableAdapterManager As Project_jobDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Tbl_sectionBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_sectionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_sectionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
