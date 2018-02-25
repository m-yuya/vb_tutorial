Public Class frmStaffConvert
    Private Sub frmStaffConvert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String

        'SQLステートメントを指定する
        sql = "SELECT staff_code, staff_name FROM tbl_staff ORDER BY staff_code"

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString1)

            'データコマンドを定義する
            Dim command As New SqlClient.SqlCommand(sql, connection)

            'コネクションを開く
            connection.Open()

            'データリーダーの生成
            Dim dr As SqlClient.SqlDataReader = command.ExecuteReader()

            'データが存在する場合に、コンボボックスに項目を追加する
            Do While dr.Read
                cmbStaffCodeBefore.Items.Add(dr("staff_code") & ":" & dr("staff_name"))
                cmbStaffCodeAfter.Items.Add(dr("staff_code") & ":" & dr("staff_name"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

        End Using
    End Sub

    Private Sub btnExec_Click(sender As Object, e As EventArgs) Handles btnExec.Click
        Dim stcode_before As String, stcode_after As String

        'コンボボックスでスタッフが指定されていない場合は処理を中断する
        If cmbStaffCodeBefore.Text = "" Then
            MsgBox("変更前のスタッフを指定してください")
            Return
        End If

        If cmbStaffCodeAfter.Text = "" Then
            MsgBox("変更後のスタッフを指定してください")
            Return
        End If

        'スタッフコードの取得（先頭6文字）
        stcode_before = Strings.Left(cmbStaffCodeBefore.Text, 6)
        stcode_after = Strings.Left(cmbStaffCodeAfter.Text, 6)

        '変更前と変更後のスタッフコードが同じ場合には処理を中断する
        If stcode_before = stcode_after Then
            MsgBox("異なるスタッフを選択してください")
            Return
        End If

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString1)

            'データコマンドを作成する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand()

            'コネクションを開く
            connection.Open()

            'トランザクションの開始
            command.Transaction = connection.BeginTransaction()
            Try
                'データコマンドの定義と実行
                'tbl_projectテーブルの処理
                command.CommandText =
                    "UPDATE tbl_project SET staff_code='" & stcode_after & "' " &
                    "WHERE staff_code='" & stcode_before & "' AND complete_flag=0"
                command.ExecuteNonQuery()

                'tbl_jobテーブルの処理
                command.CommandText =
                    "UPDATE tbl_job SET staff_code='" & stcode_after & "' " &
                    "WHERE staff_code='" & stcode_before & "' AND complete_flag=0"
                command.ExecuteNonQuery()

                'トランザクションのコミット
                command.Transaction.Commit()

                MsgBox("プロジェクトとジョブのスタッフを変更しました")

            Catch ex As Exception
                '処理が失敗したとき
                'トランザクションのロールバック
                command.Transaction.Rollback()

                MsgBox("エラーが発生したため、処理を中止します。" & vbCrLf & ex.Message)
            End Try

            'コネクションを閉じる
            connection.Close()

        End Using
    End Sub
End Class