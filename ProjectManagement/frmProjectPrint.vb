Public Class frmProjectPrint
    Private Sub frmProjectPrint_Load(sender As Object, e As EventArgs) Handles Me.Load
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
            '先頭に（すべて）を追加する
            cmbManager.Items.Add("（すべて）")

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
            '先頭に（すべて）を追加する
            cmbCustomer.Items.Add("（すべて）")

            'データコマンドの定義
            command.CommandText = "SELECT customer_code, customer_name FROM tbl_customer ORDER by customer_code"

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

            '2つのコンボボックスで既定の状態として、先頭の（すべて）を選択する
            cmbManager.SelectedIndex = 0
            cmbCustomer.SelectedIndex = 0

        End Using
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim fs As String = ""
        Dim sql As String

        'マネージャーの条件指定
        If cmbManager.SelectedIndex > 0 Then
            fs = "staff_code ='" & Strings.Left(cmbManager.Text, 6) & "'"
        End If

        '顧客の条件指定
        If cmbCustomer.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= " AND "
            End If

            fs &= "customer_code='" &
                Strings.Left(cmbCustomer.Text, 7) & "'"
        End If

        '完了フラグの条件指定
        If Not chkComplete.Checked Then
            If fs <> "" Then
                fs &= " AND "
            End If

            fs &= "complete_flag=0"
        End If

        'SQLステートメントの定義
        sql = "SELECT * FROM vw_projectlist"

        '条件が指定されているときにはWHERE句を追加する
        If fs <> "" Then
            sql &= " WHERE " & fs
        End If

        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor
        '［プロジェクト一覧プレビュー］フォームのインスタンスを生成する
        Using frm As New frmProjectPreveiw
            '［プロジェクト一覧プレビュー］フォームにSQLステートメントを渡す
            frm.ProjectReportSql = sql
            '［プロジェクト一覧プレビュー］フォームを表示する
            frm.ShowDialog()
        End Using

        '待機カーソル（砂時計）を戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class