Public Class frmProjectPreveiw
    Private Sub frmProjectPreveiw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'project_jobDataSet.vw_projectlist' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.vw_projectlistTableAdapter.Fill(Me.project_jobDataSet.vw_projectlist)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class