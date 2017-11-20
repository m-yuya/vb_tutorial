Public Class frmMenu

    Dim frm_st As frmStaff      '［スタッフマスター管理］フォーム

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

    Dim frm_cs As frmCustomer   '［顧客マスター管理］フォーム

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
End Class