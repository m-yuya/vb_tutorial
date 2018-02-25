<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJobList
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.grdJobList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Vw_joblistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_jobDataSet1 = New ProjectManagement.Project_jobDataSet1()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnCard = New System.Windows.Forms.Button()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkComplete = New System.Windows.Forms.CheckBox()
        Me.Vw_joblistTableAdapter = New ProjectManagement.Project_jobDataSet1TableAdapters.vw_joblistTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.Project_jobDataSet1TableAdapters.TableAdapterManager()
        CType(Me.grdJobList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_joblistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_jobDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(831, 7)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(85, 27)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "戻る"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'grdJobList
        '
        Me.grdJobList.AllowUserToAddRows = False
        Me.grdJobList.AllowUserToDeleteRows = False
        Me.grdJobList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdJobList.AutoGenerateColumns = False
        Me.grdJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdJobList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1})
        Me.grdJobList.DataSource = Me.Vw_joblistBindingSource
        Me.grdJobList.Location = New System.Drawing.Point(12, 45)
        Me.grdJobList.Name = "grdJobList"
        Me.grdJobList.RowTemplate.Height = 21
        Me.grdJobList.Size = New System.Drawing.Size(917, 321)
        Me.grdJobList.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "job_title"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ジョブタイトル"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 145
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "staff_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "担当スタッフ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "project_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "プロジェクト名"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "manager"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ﾌﾟﾛｼﾞｪｸﾄﾏﾈｰｼﾞｬｰ"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "customer_name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "顧客名"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 145
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "start_date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ジョブ開始日"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "end_date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ジョブ終了日"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "complete_flag"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "完了"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'Vw_joblistBindingSource
        '
        Me.Vw_joblistBindingSource.DataMember = "vw_joblist"
        Me.Vw_joblistBindingSource.DataSource = Me.Project_jobDataSet1
        '
        'Project_jobDataSet1
        '
        Me.Project_jobDataSet1.DataSetName = "Project_jobDataSet1"
        Me.Project_jobDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(731, 7)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(85, 27)
        Me.btnFilter.TabIndex = 2
        Me.btnFilter.Text = "フィルタ実行"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnCard
        '
        Me.btnCard.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCard.Location = New System.Drawing.Point(831, 372)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(85, 24)
        Me.btnCard.TabIndex = 3
        Me.btnCard.Text = "カード表示"
        Me.btnCard.UseVisualStyleBackColor = True
        '
        'cmbSection
        '
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(77, 11)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(121, 20)
        Me.cmbSection.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "部署："
        '
        'chkComplete
        '
        Me.chkComplete.AutoSize = True
        Me.chkComplete.Location = New System.Drawing.Point(218, 13)
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.Size = New System.Drawing.Size(104, 16)
        Me.chkComplete.TabIndex = 6
        Me.chkComplete.Text = "完了ジョブを含む"
        Me.chkComplete.UseVisualStyleBackColor = True
        '
        'Vw_joblistTableAdapter
        '
        Me.Vw_joblistTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_customerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_jobTableAdapter = Nothing
        Me.TableAdapterManager.tbl_projectTableAdapter = Nothing
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.Project_jobDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmJobList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 400)
        Me.Controls.Add(Me.chkComplete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.btnCard)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.grdJobList)
        Me.Controls.Add(Me.btnQuit)
        Me.Name = "frmJobList"
        Me.Text = "　ジョブ一覧"
        CType(Me.grdJobList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_joblistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_jobDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents Project_jobDataSet1 As Project_jobDataSet1
    Friend WithEvents Vw_joblistBindingSource As BindingSource
    Friend WithEvents Vw_joblistTableAdapter As Project_jobDataSet1TableAdapters.vw_joblistTableAdapter
    Friend WithEvents TableAdapterManager As Project_jobDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents grdJobList As DataGridView
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnCard As Button
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkComplete As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
