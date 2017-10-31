Public Class frmCustomer
    Private Sub Tbl_customerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_customerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_customerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_jobDataSet.tbl_customer' table. You can move, or remove it, as needed.
        Me.Tbl_customerTableAdapter.Fill(Me.Project_jobDataSet.tbl_customer)

    End Sub
End Class