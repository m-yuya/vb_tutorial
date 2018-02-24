<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnJob = New System.Windows.Forms.Button()
        Me.btnProjectReport = New System.Windows.Forms.Button()
        Me.btnProject = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSection = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnStaffConvert = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "プロジェクト管理システム"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnJob)
        Me.Panel1.Controls.Add(Me.btnProjectReport)
        Me.Panel1.Controls.Add(Me.btnProject)
        Me.Panel1.Location = New System.Drawing.Point(12, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 251)
        Me.Panel1.TabIndex = 1
        '
        'btnJob
        '
        Me.btnJob.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnJob.Location = New System.Drawing.Point(14, 175)
        Me.btnJob.Name = "btnJob"
        Me.btnJob.Size = New System.Drawing.Size(154, 61)
        Me.btnJob.TabIndex = 6
        Me.btnJob.Text = "ジョブ管理"
        Me.btnJob.UseVisualStyleBackColor = True
        '
        'btnProjectReport
        '
        Me.btnProjectReport.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnProjectReport.Location = New System.Drawing.Point(14, 94)
        Me.btnProjectReport.Name = "btnProjectReport"
        Me.btnProjectReport.Size = New System.Drawing.Size(154, 61)
        Me.btnProjectReport.TabIndex = 1
        Me.btnProjectReport.Text = "プロジェクト一覧印刷"
        Me.btnProjectReport.UseVisualStyleBackColor = True
        '
        'btnProject
        '
        Me.btnProject.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnProject.Location = New System.Drawing.Point(14, 12)
        Me.btnProject.Name = "btnProject"
        Me.btnProject.Size = New System.Drawing.Size(154, 61)
        Me.btnProject.TabIndex = 0
        Me.btnProject.Text = "プロジェクト管理"
        Me.btnProject.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSection)
        Me.Panel2.Controls.Add(Me.btnStaff)
        Me.Panel2.Controls.Add(Me.btnCustomer)
        Me.Panel2.Location = New System.Drawing.Point(199, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(181, 251)
        Me.Panel2.TabIndex = 2
        '
        'btnSection
        '
        Me.btnSection.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSection.Location = New System.Drawing.Point(14, 175)
        Me.btnSection.Name = "btnSection"
        Me.btnSection.Size = New System.Drawing.Size(154, 61)
        Me.btnSection.TabIndex = 5
        Me.btnSection.Text = "部署マスター"
        Me.btnSection.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStaff.Location = New System.Drawing.Point(14, 12)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(154, 61)
        Me.btnStaff.TabIndex = 3
        Me.btnStaff.Text = "スタッフマスター"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCustomer.Location = New System.Drawing.Point(14, 94)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(154, 61)
        Me.btnCustomer.TabIndex = 4
        Me.btnCustomer.Text = "顧客マスター"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnUser)
        Me.Panel3.Controls.Add(Me.btnExport)
        Me.Panel3.Controls.Add(Me.btnStaffConvert)
        Me.Panel3.Location = New System.Drawing.Point(386, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(181, 251)
        Me.Panel3.TabIndex = 3
        '
        'btnUser
        '
        Me.btnUser.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnUser.Location = New System.Drawing.Point(14, 175)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(154, 61)
        Me.btnUser.TabIndex = 8
        Me.btnUser.Text = "ユーザー管理"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnExport.Location = New System.Drawing.Point(14, 12)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(154, 61)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "顧客データの" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "エクスポート"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnStaffConvert
        '
        Me.btnStaffConvert.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStaffConvert.Location = New System.Drawing.Point(14, 94)
        Me.btnStaffConvert.Name = "btnStaffConvert"
        Me.btnStaffConvert.Size = New System.Drawing.Size(154, 61)
        Me.btnStaffConvert.TabIndex = 7
        Me.btnStaffConvert.Text = "スタッフの一括置換"
        Me.btnStaffConvert.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(482, 9)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(85, 29)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "終了"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 321)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMenu"
        Me.Text = "メインメニュー"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnProjectReport As Button
    Friend WithEvents btnProject As Button
    Friend WithEvents btnSection As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnStaffConvert As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnJob As Button
End Class
