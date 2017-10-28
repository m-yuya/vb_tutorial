Public Class frmStaff
    Private Sub Tbl_staffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_staffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_staffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_jobDataSet.tbl_staff' table. You can move, or remove it, as needed.
        Me.Tbl_staffTableAdapter.Fill(Me.Project_jobDataSet.tbl_staff)

    End Sub

    Private Sub Staff_codeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rdbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMale.CheckedChanged

    End Sub

    Private Sub Staff_codeTextBox_TextChanged(sender As Object, e As EventArgs) Handles Staff_codeTextBox.TextChanged

    End Sub
End Class
