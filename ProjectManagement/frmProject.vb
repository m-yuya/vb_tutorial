Public Class frmProject
    Private Sub Tbl_projectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_projectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_projectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private frm_projectlist As frmProjectList

    Public Sub SetProjectCode(pcode As String, f As frmProjectList)
        '呼び出し元フォームを格納する
        frm_projectlist = f

        'スタッフマスターのデータをデータテーブルにセットする
        Me.Tbl_staffTableAdapter.Fill(Me.Project_jobDataSet.tbl_staff)

        '顧客マスターのデータをデータテーブルにセットする
        Me.Tbl_customerTableAdapter.Fill(Me.Project_jobDataSet.tbl_customer)

        '受け取ったプロジェクトコードを使用して、該当するプロジェクトデータをデータテーブルにセットする
        Me.Tbl_projectTableAdapter.FillByPCode(Me.Project_jobDataSet.tbl_project, pcode)

        '受け取ったプロジェクトコードを使用して、該当するジョブデータをデータテーブルにセットする
        Me.Tbl_jobTableAdapter.FillByPCode(Me.Project_jobDataSet.tbl_job, pcode)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'プロジェクト名の必須チェック
        With txtProjectName
            If .Text = "" Then
                MsgBox("プロジェクト名を入力してください")
                .Select()
                Return
            End If
        End With

        '顧客の必須チェック
        With cmbCustomer
            If .SelectedIndex < 0 Then
                MsgBox("顧客を指定してください")
                .Select()
                Return
            End If
        End With

        'マネージャーの必須チェック
        With cmbManager
            If .SelectedIndex < 0 Then
                MsgBox("マネージャーを指定してください")
                .Select()
                Return
            End If
        End With

        '保存確認と保存処理
        If MsgBox("これまでの修正内容をデータベースに保存しますか？ ",
                  MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            '編集状態を確定する
            Tbl_projectBindingSource.EndEdit()

            'テーブルアダプターを介して、tbl_projectテーブルを更新する
            Me.Tbl_projectTableAdapter.Update(Me.Project_jobDataSet.tbl_project)

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '呼び出し元のフォームを表示する
        frm_projectlist.Visible = True

        'このフォームを閉じる
        Me.Close()
    End Sub
End Class