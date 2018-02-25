Public Class frmProjectPreveiw
    Public ProjectReportSql As String 'レポートのソースとなるSQLステートメント

    Private Sub frmProjectPreveiw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '受け取ったSQLステートメントでデータアダプターを定義する
        Dim da As New SqlClient.SqlDataAdapter(
            ProjectReportSql, My.Settings.project_jobConnectionString1)

        'データテーブルにデータアダプターを介してデータをセットする
        da.Fill(Me.Project_jobDataSet1.vw_projectlist)

        'レポートを表示する
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class