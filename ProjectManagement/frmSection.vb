Public Class frmSection
    Private Sub Tbl_sectionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_sectionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_sectionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub frmSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_jobDataSet.tbl_section' table. You can move, or remove it, as needed.
        Me.Tbl_sectionTableAdapter.Fill(Me.Project_jobDataSet.tbl_section)

    End Sub
End Class