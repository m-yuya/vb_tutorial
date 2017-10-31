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

    Private Sub FillByNameToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByNameToolStripButton.Click
        Try
            Me.Tbl_customerTableAdapter.FillByName(Me.Project_jobDataSet.tbl_customer, "%" & FilternameToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Tbl_customerDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_customerDataGridView.DataError
        MsgBox("データの登録時にエラーが発生しました。" & vbCrLf & vbCrLf & e.Exception.Message)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Try
            With Tbl_customerDataGridView
                'データグリッドビューのセルの選択を解除する
                .ClearSelection()
                'データグリッドビューの最終行の先頭列に移動する
                .CurrentCell = .Rows(.NewRowIndex).Cells(0)
                '編集モードに遷移する
                .BeginEdit(False)
            End With

        Catch ex As Exception
            '例外時のエラーメッセージ
            MsgBox(ex.Message)
            Return
        End Try
    End Sub
End Class