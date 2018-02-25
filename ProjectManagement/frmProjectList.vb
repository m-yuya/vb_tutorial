Public Class frmProjectList

    Class CustomerItem
        Public CustomerName As String '顧客名
        Public CustomerCode As String '顧客コード
        Public Rank As String 'ランク
    End Class
    Class ManagerItem ' Development task
        Public ManagerName As String 'スタッフ名
        Public ManagerCode As String 'スタッフコード
        Public ManagerSection As String 'スタッフ部署コード
    End Class


    Private m_Customers As New List(Of CustomerItem)

    Private m_Managers As New List(Of ManagerItem) ' Development task

    Private Sub frmProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString1)

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
            command.CommandText = "SELECT staff_code, staff_name, staff_section FROM tbl_staff ORDER BY staff_code"

            'データリーダーからのデータの読み出し
            dr = command.ExecuteReader()
            Do While dr.Read
                '読み出したデータをコンボボックスに追加する
                cmbManager.Items.Add(dr("staff_code") & ":" & dr("staff_name"))

                'CustomerItemクラスに読み出したデータをセットする
                Dim item As New ManagerItem
                item.ManagerCode = dr("staff_code")
                item.ManagerName = dr("staff_name")
                item.ManagerSection = dr("staff_section")

                m_Managers.Add(item) ' Development task
            Loop

            'データリーダーを閉じる
            dr.Close()

            '### 顧客のコンボボックスの設定###
            'データコマンドの定義
            command.CommandText = "SELECT customer_code, customer_name, rank FROM tbl_customer ORDER BY customer_code"

            'データリーダーからのデータの読み出し
            dr = command.ExecuteReader()
            Do While dr.Read
                'CustomerItemクラスに読み出したデータをセットする
                Dim item As New CustomerItem
                item.CustomerCode = dr("customer_code")
                item.CustomerName = dr("customer_name")
                item.Rank = dr("rank").ToString

                'm_CustomersコレクションにCustomerItemクラスを追加する
                m_Customers.Add(item)
            Loop

            'データリーダーを閉じる
            dr.Close()


            '### 部署のコンボボックスの設定 (Development task) ###
            '先頭に（すべて）を追加する
            cmbSection.Items.Add("（すべて）")
            'データコマンドの定義
            command.CommandText = "SELECT section_code, section_name FROM tbl_section ORDER BY section_code"

            'データリーダーからのデータの読み出し
            dr = command.ExecuteReader()
            Do While dr.Read
                '読み出したデータをコンボボックスに追加する
                cmbSection.Items.Add(dr("section_code") & ":" & dr("section_name"))
            Loop

            'データリーダーを閉じる
            dr.Close()


            'コネクションを閉じる
            connection.Close()

            '3つのコンボボックスで既定の状態として、先頭の（すべて）を選択する
            cmbManager.SelectedIndex = 0
            cmbCustomer.SelectedIndex = 0
            cmbSection.SelectedIndex = 0

            '［ランク］コンボボックスの既定値として［全］を選択する
            'この処理でイベントが発生し、［顧客］コンボボックスの一覧が生成される
            cmbRank.SelectedIndex = 0
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

        ' 部署の顧客の条件指定と条件式の作成 (Development task) 
        If cmbSection.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= " AND "
            End If

            fs &= "staff_section = '" & Strings.Left(cmbSection.Text, 4) & "'"
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
            sql, My.Settings.project_jobConnectionString1)

        'データテーブルをクリアする
        Me.Project_jobDataSet1.vw_projectlist.Clear()

        'データテーブルにデータアダプターを介してデータをセットする
        da.Fill(Me.Project_jobDataSet1.vw_projectlist)
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

    Private Sub cmbRank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRank.SelectedIndexChanged
        '［顧客］コンボボックスの一覧を作り直す
        SetCustomerCombobox()
    End Sub

    Private Sub rdbOrderCode_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOrderCode.CheckedChanged
        '［顧客］コンボボックスの一覧を作り直す
        SetCustomerCombobox()
    End Sub

    Private Sub rdbOrderName_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOrderName.CheckedChanged
        '［顧客］コンボボックスの一覧を作り直す
        SetCustomerCombobox()
    End Sub

    '［顧客］コンボボックスの一覧の生成
    Private Sub SetCustomerCombobox()
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        'コンボボックスの項目をクリアする
        cmbCustomer.Items.Clear()
        '先頭に（すべて）を追加する
        cmbCustomer.Items.Add("（すべて）")

        '選択したランクを取得する
        Dim rank As Integer = cmbRank.SelectedIndex

        '顧客データの配列を宣言する
        Dim customerarray() As CustomerItem = Nothing

        '条件によって、顧客データの配列を生成する
        If rank = 0 Then
            'ランクが「全」の場合
            If rdbOrderCode.Checked Then
                'コード順が選択されているとき（Where句なし）
                customerarray = (From a In m_Customers Order By a.CustomerCode).ToArray
            ElseIf rdbOrderName.Checked Then
                '名前順が選択されているとき（Where句なし）
                customerarray = (From a In m_Customers Order By a.CustomerName).ToArray
            End If
        Else
            'ランクが「A」～「C」の場合
            If rdbOrderCode.Checked Then
                'コード順が選択されているとき（ランクによるWhere句あり）
                customerarray = (From a In m_Customers
                                 Where a.Rank = cmbRank.SelectedItem
                                 Order By a.CustomerCode).ToArray
            ElseIf rdbOrderName.Checked Then
                '名前順が選択されているとき（ランクによるWhere句あり）
                customerarray = (From a In m_Customers
                                 Where a.Rank = cmbRank.SelectedItem
                                 Order By a.CustomerName).ToArray
            End If
        End If
        '配列からデータを取得して、コンボボックスに追加する
        For Each c In customerarray
            cmbCustomer.Items.Add(c.CustomerCode & ":" & c.CustomerName)
        Next

        '先頭の（すべて）を選択する
        cmbCustomer.SelectedIndex = 0

        '待機カーソル（砂時計）を戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSection.SelectedIndexChanged
        '［部署］コンボボックスの一覧を作り直す ' Development task
        SetSectionCombobox()
    End Sub


    Private Sub SetSectionCombobox() ' Development task
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        'コンボボックスの項目をクリアする
        cmbManager.Items.Clear()
        '先頭に（すべて）を追加する
        cmbManager.Items.Add("（すべて）")

        '選択した部署を取得する
        Dim section_code As Integer = cmbSection.SelectedIndex

        'マネージャーデータの配列を宣言する
        Dim managerarray() As ManagerItem = Nothing

        '条件によって、顧客データの配列を生成する
        If section_code = 0 Then
            '部署が"すべて"の場合
            managerarray = (From a In m_Managers Order By a.ManagerCode).ToArray
        Else
            managerarray = (From a In m_Managers
                            Where a.ManagerSection = Strings.Left(cmbSection.Text, 4)
                            Order By a.ManagerCode).ToArray
        End If
        '配列からデータを取得して、コンボボックスに追加する
        For Each c In managerarray
            cmbManager.Items.Add(c.ManagerCode & ":" & c.ManagerName)
        Next


        '先頭の（すべて）を選択する
        cmbManager.SelectedIndex = 0

        '待機カーソル（砂時計）を戻す
        Me.Cursor = Cursors.Default

    End Sub
End Class