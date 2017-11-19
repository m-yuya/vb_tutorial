Public Class frmProject
    Private Sub Tbl_projectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_projectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_projectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub frmProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_jobDataSet.tbl_job' table. You can move, or remove it, as needed.
        Me.Tbl_jobTableAdapter.Fill(Me.Project_jobDataSet.tbl_job)
        'TODO: This line of code loads data into the 'Project_jobDataSet.tbl_staff' table. You can move, or remove it, as needed.
        Me.Tbl_staffTableAdapter.Fill(Me.Project_jobDataSet.tbl_staff)
        'TODO: This line of code loads data into the 'Project_jobDataSet.tbl_customer' table. You can move, or remove it, as needed.
        Me.Tbl_customerTableAdapter.Fill(Me.Project_jobDataSet.tbl_customer)
        'TODO: This line of code loads data into the 'Project_jobDataSet.tbl_project' table. You can move, or remove it, as needed.
        Me.Tbl_projectTableAdapter.Fill(Me.Project_jobDataSet.tbl_project)

    End Sub
End Class