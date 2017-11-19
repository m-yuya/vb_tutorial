Public Class frmProjectList
    Private Sub frmProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_jobDataSet.vw_projectlist' table. You can move, or remove it, as needed.
        Me.Vw_projectlistTableAdapter.Fill(Me.Project_jobDataSet.vw_projectlist)

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

            '2つのコンボボックスで既定の状態として、先頭の（すべて）を選択する
            cmbManager.SelectedIndex = 0
            cmbCustomer.SelectedIndex = 0
        End Using

        '指定された条件でデータベースを読み込む
        LoadDatabase()
    End Sub

    Public Sub LoadDatabase()
        Dim fs As String = ""
        Dim sql As String

        'プロジェクト名の条件指定（部分一致）と条件式の作成
        If txtProjectName.Text <> "" Then
            fs = "project_name Like '%" & txtProjectName.Text & "%'"
        End If

        'マネージャーの条件指定と条件式の作成
        If cmbManager.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= " AND "
            End If

            fs &= "staff_code = '" & Strings.Left(cmbManager.Text, 6) & "'"
        End If

        '顧客の条件指定と条件式の作成
        If cmbCustomer.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= " AND "
            End If

            fs &= "customer_code = '" &
                Strings.Left(cmbCustomer.Text, 7) & "'"
        End If

        '完了フラグの条件指定と条件式の作成
        If Not chkComplete.Checked Then
            If fs <> "" Then
                fs &= " AND "
            End If

            '未完了データのみにする
            fs &= "complete_flag = 0"
        End If

        'SQLステートメントの定義
        sql = "SELECT * FROM vw_projectlist"

        '条件が指定されているときにはWHERE句を追加する
        If fs <> "" Then
            sql &= " WHERE " & fs
        End If

        'データアダプターにSQLステートメントを設定する
        Dim da As New SqlClient.SqlDataAdapter(
            sql, My.Settings.project_jobConnectionString)

        'データテーブルをクリアする
        Me.Project_jobDataSet.vw_projectlist.Clear()

        'データテーブルにデータアダプターを介してデータをセットする
        da.Fill(Me.Project_jobDataSet.vw_projectlist)
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        '指定された条件でデータベースを読み込む
        LoadDatabase()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'このフォームを閉じる
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim f As New frmProjectNew() '［プロジェクト新規登録］フォーム

        '［プロジェクト新規登録］フォームを表示する
        f.ShowDialog(Me)

        '新規登録の処理から戻ってきたら、このフォームを更新する
        LoadDatabase()
    End Sub

    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        'データグリッドビューが空のときは終了する
        If grdProjectList.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim code As String

        'データグリッドビューの行番号を取得する
        row = grdProjectList.CurrentRow.Index

        '行番号からプロジェクトコードを取得する
        code = grdProjectList.Item(0, row).Value.ToString()

        Dim frm As New frmProject '［プロジェクト管理］フォーム

        '［プロジェクト管理］フォームのSetProjectCodeプロシージャを呼び出して、
        '指定したプロジェクトコードのデータを表示する
        frm.SetProjectCode(code, Me)

        '［プロジェクト管理］フォームを表示する
        frm.ShowDialog(Me)

        '［プロジェクト管理］フォームから戻ってきたら、このフォームを更新する
        LoadDatabase()
    End Sub
End Class