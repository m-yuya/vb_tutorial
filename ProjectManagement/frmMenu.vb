Public Class frmMenu

    Dim frm_st As frmStaff      '［スタッフマスター管理］フォーム
    Dim frm_cs As frmCustomer   '［顧客マスター管理］フォーム
    Dim frm_pr As frmProjectList    '［プロジェクト一覧］フォーム
    Dim frm_pp As frmProjectPrint   '［プロジェクト一覧印刷］フォーム
    Dim frm_su As frmStaffConvert   '［スタッフの一括更新］フォーム
    Dim frm_sc As frmSection        '［部署マスタ管理］フォーム
    Dim frm_us As frmUser           '［ユーザーマスタ管理］フォーム
    Dim frm_job As frmJobList   '［ジョブ一覧］フォーム  [Development task]

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_st Is Nothing OrElse frm_st.IsDisposed() Then
            frm_st = New frmStaff()
        End If

        'フォームを表示する
        frm_st.ShowDialog()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        If AdminFlag <> True Then
            '管理者権限を持たないユーザーの場合
            btnStaffConvert.Enabled = False
            btnUser.Enabled = False
        End If
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_cs Is Nothing OrElse frm_cs.IsDisposed() Then
            frm_cs = New frmCustomer()
        End If

        'フォームを表示する
        frm_cs.ShowDialog()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim sr As IO.StreamWriter

        Dim exfolder As String
        Dim linetext As String

        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '保存先フォルダーの指定
        exfolder = IO.Path.Combine(Application.StartupPath, "データ出力\")

        'フォルダーが存在しない場合には作成する
        If IO.Directory.Exists(exfolder) = False Then
            IO.Directory.CreateDirectory(exfolder)
        End If

        'ファイルを作成する
        sr = New IO.StreamWriter(exfolder & "顧客データ.csv", False,
                                 System.Text.Encoding.GetEncoding("Shift_JIS"))

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString1)

            'データコマンドを定義する
            Dim command As New SqlClient.SqlCommand("SELECT * FROM tbl_customer",
                                                    connection)

            'コネクションを開く
            connection.Open()

            'データリーダーの生成
            Dim dr As SqlClient.SqlDataReader = command.ExecuteReader()

            'データの分だけ処理を繰り返す
            Do While dr.Read
                '書き込むデータの生成（カンマ区切り）
                linetext = dr("customer_code") & ","
                linetext &= dr("customer_name") & ","
                linetext &= dr("zipcode") & ","
                linetext &= dr("address") & ","
                linetext &= dr("person") & ","
                linetext &= dr("tel") & ","
                linetext &= dr("input_date")

                'ファイルの書き込み
                sr.WriteLine(linetext)
            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()
        End Using

        'ファイルを閉じる
        sr.Close()

        '待機カーソル（砂時計）を戻す
        Me.Cursor = Cursors.Default

        MsgBox("顧客データを以下のフォルダーにエクスポートしました。" &
               vbCrLf & vbCrLf & exfolder)
    End Sub

    Private Sub btnProject_Click(sender As Object, e As EventArgs) Handles btnProject.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_pr Is Nothing OrElse frm_pr.IsDisposed() Then
            frm_pr = New frmProjectList()
        End If

        'フォームを表示する
        frm_pr.ShowDialog()
        frm_pr.Dispose()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnProjectReport_Click(sender As Object, e As EventArgs) Handles btnProjectReport.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_pp Is Nothing OrElse frm_pp.IsDisposed() Then
            frm_pp = New frmProjectPrint()
        End If

        'フォームを表示する
        frm_pp.ShowDialog()
        frm_pp.Dispose()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnStaffConvert_Click(sender As Object, e As EventArgs) Handles btnStaffConvert.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_su Is Nothing OrElse frm_su.IsDisposed() Then
            frm_su = New frmStaffConvert()
        End If

        'フォームを表示する
        frm_su.ShowDialog()
        frm_su.Dispose()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub btnJob_Click(sender As Object, e As EventArgs) Handles btnJob.Click ' Development task
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_job Is Nothing OrElse frm_job.IsDisposed() Then
            frm_job = New frmJobList()
        End If

        'フォームを表示する
        frm_job.ShowDialog()
        frm_job.Dispose()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_us Is Nothing OrElse frm_us.IsDisposed() Then
            frm_us = New frmUser()
        End If

        'フォームを表示する
        frm_us.ShowDialog()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSection_Click(sender As Object, e As EventArgs) Handles btnSection.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_sc Is Nothing OrElse frm_sc.IsDisposed() Then
            frm_sc = New frmSection()
        End If

        'フォームを表示する
        frm_sc.ShowDialog()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

End Class