<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectNew
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
        Dim Project_codeLabel As System.Windows.Forms.Label
        Dim Project_nameLabel As System.Windows.Forms.Label
        Dim Customer_codeLabel As System.Windows.Forms.Label
        Dim Staff_codeLabel As System.Windows.Forms.Label
        Dim Start_dateLabel As System.Windows.Forms.Label
        Dim End_dateLabel As System.Windows.Forms.Label
        Dim MemoLabel As System.Windows.Forms.Label
        Me.Project_jobDataSet1 = New ProjectManagement.project_jobDataSet()
        Me.Tbl_projectTableAdapter1 = New ProjectManagement.project_jobDataSetTableAdapters.tbl_projectTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.cmbManager = New System.Windows.Forms.ComboBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.chkCompleteFlag = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Project_codeLabel = New System.Windows.Forms.Label()
        Project_nameLabel = New System.Windows.Forms.Label()
        Customer_codeLabel = New System.Windows.Forms.Label()
        Staff_codeLabel = New System.Windows.Forms.Label()
        Start_dateLabel = New System.Windows.Forms.Label()
        End_dateLabel = New System.Windows.Forms.Label()
        MemoLabel = New System.Windows.Forms.Label()
        CType(Me.Project_jobDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        'Project_jobDataSet1
        '
        Me.Project_jobDataSet1.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_projectTableAdapter1
        '
        Me.Tbl_projectTableAdapter1.ClearBeforeFill = True
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
        Me.Panel1.TabIndex = 1
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(113, 31)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(103, 19)
        Me.txtProjectCode.TabIndex = 1
        '
        'txtProjectName
        '
        Me.txtProjectName.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtProjectName.Location = New System.Drawing.Point(113, 56)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(320, 19)
        Me.txtProjectName.TabIndex = 3
        '
        'cmbCustomer
        '
        Me.cmbCustomer.DisplayMember = "customer_name"
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(113, 81)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(320, 20)
        Me.cmbCustomer.TabIndex = 5
        Me.cmbCustomer.ValueMember = "customer_code"
        '
        'cmbManager
        '
        Me.cmbManager.DisplayMember = "staff_name"
        Me.cmbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbManager.FormattingEnabled = True
        Me.cmbManager.Location = New System.Drawing.Point(113, 107)
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(200, 20)
        Me.cmbManager.TabIndex = 7
        Me.cmbManager.ValueMember = "staff_code"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(113, 133)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 19)
        Me.dtpStartDate.TabIndex = 9
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(113, 158)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 19)
        Me.dtpEndDate.TabIndex = 11
        '
        'txtMemo
        '
        Me.txtMemo.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtMemo.Location = New System.Drawing.Point(113, 183)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(445, 83)
        Me.txtMemo.TabIndex = 13
        '
        'chkCompleteFlag
        '
        Me.chkCompleteFlag.Location = New System.Drawing.Point(499, 30)
        Me.chkCompleteFlag.Name = "chkCompleteFlag"
        Me.chkCompleteFlag.Size = New System.Drawing.Size(50, 24)
        Me.chkCompleteFlag.TabIndex = 15
        Me.chkCompleteFlag.Text = "完了"
        Me.chkCompleteFlag.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(598, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "戻る"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(598, 41)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "登録"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmProjectNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 321)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmProjectNew"
        Me.Text = "プロジェクト新規登録"
        CType(Me.Project_jobDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Project_jobDataSet1 As project_jobDataSet
    Friend WithEvents Tbl_projectTableAdapter1 As project_jobDataSetTableAdapters.tbl_projectTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtProjectCode As TextBox
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents cmbManager As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents txtMemo As TextBox
    Friend WithEvents chkCompleteFlag As CheckBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
End Class
