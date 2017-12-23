Public Class frmProjectPreveiw
    Public ProjectReportSql As String 'レポートのソースとなるSQLステートメント

    Private Sub frmProjectPreveiw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '受け取ったSQLステートメントでデータアダプターを定義する
        Dim da As New SqlClient.SqlDataAdapter(
            ProjectReportSql, My.Settings.project_jobConnectionString)

        'データテーブルにデータアダプターを介してデータをセットする
        da.Fill(Me.project_jobDataSet.vw_projectlist)

        'レポートを表示する
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class