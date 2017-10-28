Public Class frmStaff
    Private Sub Tbl_staffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_staffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_staffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_jobDataSet.tbl_section' table. You can move, or remove it, as needed.
        Me.Tbl_sectionTableAdapter.Fill(Me.Project_jobDataSet.tbl_section)
        'TODO: This line of code loads data into the 'Project_jobDataSet.tbl_staff' table. You can move, or remove it, as needed.
        Me.Tbl_staffTableAdapter.Fill(Me.Project_jobDataSet.tbl_staff)

    End Sub

    Private Sub Staff_codeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rdbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMale.CheckedChanged
        '男性のラジオボタンが選択されていない場合には以降の処理を中止する
        If rdbMale.Checked() = False Then Return

        'バインディングソースから現在のデータを取得する
        Dim drv As DataRowView = Me.Tbl_staffBindingSource.Current
        'Null値または男性以外の場合には男性の値（1）をセットする
        If IsDBNull(drv("staff_sex")) OrElse drv("staff_sex") <> 1 Then
            drv("staff_sex") = 1
        End If
    End Sub

    Private Sub rdbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFemale.CheckedChanged
        '女性のラジオボタンが選択されていない場合には以降の処理を中止する
        If rdbFemale.Checked() = False Then Return

        'バインディングソースから現在のデータを取得する
        Dim drv As DataRowView = Me.Tbl_staffBindingSource.Current
        'Null値または女性以外の場合には女性の値（2）をセットする
        If IsDBNull(drv("staff_sex")) OrElse drv("staff_sex") <> 2 Then
            drv("staff_sex") = 2
        End If
    End Sub

    Private Sub Tbl_staffBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_staffBindingSource.PositionChanged
        '移動時に性別のラジオボタンを設定する

        '現在の行がないときには、何もせずに処理を終了する
        If Me.Tbl_staffBindingSource.Current Is Nothing Then Return

        'バインディングソースから現在のデータを取得する
        Dim drv As DataRowView = Me.Tbl_staffBindingSource.Current

        If IsDBNull(drv("staff_sex")) Then
            'Null値の場合にはいずれも選択しない
            rdbMale.Checked = False
            rdbFemale.Checked = False
            Exit Sub
        End If

        '性別の値によって、ラジオボタンを制御する
        Select Case drv("staff_sex")
            Case 1
                '男性
                rdbMale.Checked = True
            Case 2
                '女性
                rdbFemale.Checked = True
        End Select
    End Sub

    Private Sub Staff_sectionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Staff_sectionComboBox.SelectedIndexChanged

    End Sub
End Class
