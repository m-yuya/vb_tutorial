Public Class frmJobList  ' Development task

    Private Sub frmJobList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString1)

            'データコマンドを作成する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand()

            'コネクションを開く
            connection.Open()

            'データリーダーの宣言
            Dim dr As SqlClient.SqlDataReader

            '### 部署のコンボボックスの設定 ###
            '先頭に（すべて）を追加する
            cmbSection.Items.Add("（すべて）")
            'データコマンドの定義
            command.CommandText = "SELECT section_code, section_name FROM tbl_section ORDER BY section_code"

            'データリーダーからのデータの読み出し
            dr = command.ExecuteReader()
            Do While dr.Read
                '読み出したデータをコンボボックスに追加する
                cmbSection.Items.Add(dr("section_code") & ": " & dr("section_name"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

            '3つのコンボボックスで既定の状態として、先頭の（すべて）を選択する
            cmbSection.SelectedIndex = 0

        End Using

        '指定された条件でデータベースを読み込む
        LoadDatabase()
    End Sub

    Public Sub LoadDatabase()
        Dim fs As String = ""
        Dim sql As String

        ' 部署の顧客の条件指定と条件式の作成
        If cmbSection.SelectedIndex > 0 Then
            fs &= "staff_section= '" & Strings.Left(cmbSection.Text, 4) & "'"
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
        sql = "SELECT * FROM vw_joblist"

        '条件が指定されているときにはWHERE句を追加する
        If fs <> "" Then
            sql &= " WHERE " & fs
        End If

        'データアダプターにSQLステートメントを設定する
        Dim da As New SqlClient.SqlDataAdapter(
            sql, My.Settings.project_jobConnectionString1)

        'データテーブルをクリアする
        Me.Project_jobDataSet1.vw_joblist.Clear()

        'データテーブルにデータアダプターを介してデータをセットする
        da.Fill(Me.Project_jobDataSet1.vw_joblist)
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        '指定された条件でデータベースを読み込む
        LoadDatabase()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'このフォームを閉じる
        Me.Close()
    End Sub

    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        'データグリッドビューが空のときは終了する
        If grdJobList.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim name As String
        Dim code As String

        'データグリッドビューの選択行を取得する
        row = grdJobList.CurrentRow.Index

        '選択行からプロジェクト名を取得する
        name = grdJobList.Item(2, row).Value.ToString()

        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString1)

            'データコマンドを作成する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand()

            'コネクションを開く
            connection.Open()

            'データリーダーの宣言
            Dim dr As SqlClient.SqlDataReader

            Dim sql As String

            'プロジェクト名からプロジェクトコードの取得
            sql = "SELECT project_code FROM tbl_project WHERE project_name='" & name & "'"

            'データコマンドの定義
            command.CommandText = sql

            'データリーダーからのデータの読み出し
            dr = command.ExecuteReader()
            If dr.Read() Then
                code = dr("project_code")
            Else
                Return
            End If

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

        End Using

        Dim frm As New frmProject '［プロジェクト管理］フォーム

        '［プロジェクト管理］フォームのSetProjectCode_joblistプロシージャを呼び出して、
        '指定したプロジェクトコードのデータを表示する
        frm.SetProjectCode_joblist(code, Me)

        '［プロジェクト管理］フォームを表示する
        frm.ShowDialog(Me)

        '［プロジェクト管理］フォームから戻ってきたら、このフォームを更新する
        LoadDatabase()
    End Sub
End Class