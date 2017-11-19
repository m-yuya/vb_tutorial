Public Class frmProjectList
    Private Sub frmProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_jobDataSet.vw_projectlist' table. You can move, or remove it, as needed.
        Me.Vw_projectlistTableAdapter.Fill(Me.Project_jobDataSet.vw_projectlist)

    End Sub
End Class