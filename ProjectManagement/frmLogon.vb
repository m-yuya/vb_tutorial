Public Class frmLogon
    Private Sub btnLogon_Click(sender As Object, e As EventArgs) Handles btnLogon.Click
        Dim sql As String

        'SQLステートメントを指定する
        sql = "SELECT password, admin_flag FROM tbl_staff WHERE userID='" &
            txtUserID.Text.Replace("'", "''") & "'"

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString1)
            '指定したSQLでデータコマンドを定義する
            Dim command As New SqlClient.SqlCommand(sql, connection)

            'コネクションを開く
            connection.Open()

            'データリーダーの生成
            Dim dr As SqlClient.SqlDataReader = command.ExecuteReader()

            '行の存在によって、該当するユーザーIDがあることを確認する
            If dr.Read() Then
                'パスワードの判定
                If RTrim(dr("password")) = txtPassword.Text Then
                    'パスワードが一致したとき
                    MsgBox("正しいユーザーであることを認証できました。システムにログオンします。")

                    'パブリック変数に管理者フラグをセットする
                    If IsDBNull(dr("admin_flag")) OrElse Not dr("admin_flag") Then
                        AdminFlag = False
                    Else
                        AdminFlag = True
                    End If

                    'メインメニューを表示する
                    Dim frm_mn As New frmMenu
                    frm_mn.Show()

                    '［ログオン］フォームを閉じる
                    Me.Close()

                Else
                    'パスワードが一致しないとき
                    MsgBox("正しいパスワードを指定してください")
                End If
            Else
                'ユーザーIDが存在しないとき
                MsgBox("正しいユーザーIDを指定してください")
            End If

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '［ログオン］フォームを閉じる（アプリケーションを終了する）
        Me.Close()
    End Sub
End Class