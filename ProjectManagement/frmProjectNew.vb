Public Class frmProjectNew
    Private Sub frmProjectNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString)

            'データコマンドを作成する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand()

            'コネクションを開く
            connection.Open()

            'データリーダーの宣言
            Dim dr As SqlClient.SqlDataReader

            '### マネージャーのコンボボックスの設定　###
            'データコマンドの定義
            command.CommandText = "SELECT staff_code, staff_name FROM tbl_staff ORDER BY staff_code"

            'データリーダーからのデータの読み出し
            dr = command.ExecuteReader()
            Do While dr.Read
                '読み出したデータをコンボボックスに追加する
                cmbManager.Items.Add(dr("staff_code") & ":" & dr("staff_name"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            '### 顧客のコンボボックスの設定　###
            'データコマンドの定義
            command.CommandText = "SELECT customer_code, customer_name FROM tbl_customer ORDER BY customer_code"

            'データリーダーからのデータの読み出し
            dr = command.ExecuteReader()
            Do While dr.Read
                '読み出したデータをコンボボックスに追加する
                cmbCustomer.Items.Add(dr("customer_code") & ":" & dr("customer_name"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()
        End Using

        'プロジェクトコードにフォーカスを合わせる
        txtProjectCode.Select()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        '行の定義
        Dim newrecord As project_jobDataSet.tbl_projectRow =
            Me.Project_jobDataSet1.tbl_project.Newtbl_projectRow()

        'プロジェクトコードのチェック（必須、入力桁数）
        With txtProjectCode
            If .Text = "" OrElse Len(.Text) > 5 Then
                MsgBox("プロジェクトコードが入力されていないか、桁数をオーバーしています")
                .Select()
                Return
            End If
        End With

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

        Try
            '行にデータをセットする
            newrecord.project_code = txtProjectCode.Text                'プロジェクトコード
            newrecord.project_name = txtProjectName.Text                'プロジェクト名
            newrecord.customer_code = Strings.Left(cmbCustomer.Text, 7) '顧客
            newrecord.staff_code = Strings.Left(cmbManager.Text, 6)     'マネージャー
            newrecord.memo = txtMemo.Text                               'メモ
            newrecord.complete_flag = chkCompleteFlag.Checked           '完了フラグ
            newrecord.start_date = dtpStartDate.Value.Date              '開始日
            newrecord.end_date = dtpEndDate.Value.Date                  '終了日

            '新規行をデータテーブルに追加する
            Me.Project_jobDataSet1.tbl_project.Addtbl_projectRow(newrecord)

            'テーブルアダプターを介して、tbl_projectテーブルを更新する
            Me.Tbl_projectTableAdapter1.Update(Me.Project_jobDataSet1.tbl_project)

        Catch ex As Exception
            'エラーメッセージを表示する
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Me.Text)
            Return
        End Try

        'このフォームを閉じる
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'このフォームを閉じる
        Me.Close()
    End Sub
End Class