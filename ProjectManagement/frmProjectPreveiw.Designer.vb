<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectPreveiw
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Project_jobDataSet1 = New ProjectManagement.Project_jobDataSet1()
        Me.vw_projectlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vw_projectlistTableAdapter = New ProjectManagement.Project_jobDataSet1TableAdapters.vw_projectlistTableAdapter()
        CType(Me.Project_jobDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_projectlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.vw_projectlistBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProjectManagement.rptProjectList.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'Project_jobDataSet1
        '
        Me.Project_jobDataSet1.DataSetName = "Project_jobDataSet1"
        Me.Project_jobDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vw_projectlistBindingSource
        '
        Me.vw_projectlistBindingSource.DataMember = "vw_projectlist"
        Me.vw_projectlistBindingSource.DataSource = Me.Project_jobDataSet1
        '
        'vw_projectlistTableAdapter
        '
        Me.vw_projectlistTableAdapter.ClearBeforeFill = True
        '
        'frmProjectPreveiw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmProjectPreveiw"
        Me.Text = "プロジェクト一覧プレビュー"
        CType(Me.Project_jobDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_projectlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vw_projectlistBindingSource As BindingSource
    Friend WithEvents Project_jobDataSet1 As Project_jobDataSet1
    Friend WithEvents vw_projectlistTableAdapter As Project_jobDataSet1TableAdapters.vw_projectlistTableAdapter
End Class
