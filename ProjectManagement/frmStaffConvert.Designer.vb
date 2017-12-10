<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffConvert
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbStaffCodeBefore = New System.Windows.Forms.ComboBox()
        Me.cmbStaffCodeAfter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExec = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbStaffCodeBefore
        '
        Me.cmbStaffCodeBefore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffCodeBefore.FormattingEnabled = True
        Me.cmbStaffCodeBefore.Location = New System.Drawing.Point(65, 23)
        Me.cmbStaffCodeBefore.Name = "cmbStaffCodeBefore"
        Me.cmbStaffCodeBefore.Size = New System.Drawing.Size(121, 20)
        Me.cmbStaffCodeBefore.TabIndex = 0
        '
        'cmbStaffCodeAfter
        '
        Me.cmbStaffCodeAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffCodeAfter.FormattingEnabled = True
        Me.cmbStaffCodeAfter.Location = New System.Drawing.Point(65, 64)
        Me.cmbStaffCodeAfter.Name = "cmbStaffCodeAfter"
        Me.cmbStaffCodeAfter.Size = New System.Drawing.Size(121, 20)
        Me.cmbStaffCodeAfter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "変更前"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "変更後"
        '
        'btnExec
        '
        Me.btnExec.Location = New System.Drawing.Point(220, 21)
        Me.btnExec.Name = "btnExec"
        Me.btnExec.Size = New System.Drawing.Size(75, 23)
        Me.btnExec.TabIndex = 4
        Me.btnExec.Text = "実行"
        Me.btnExec.UseVisualStyleBackColor = True
        '
        'frmStaffConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 105)
        Me.Controls.Add(Me.btnExec)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbStaffCodeAfter)
        Me.Controls.Add(Me.cmbStaffCodeBefore)
        Me.Name = "frmStaffConvert"
        Me.Text = "frmStaffConvert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbStaffCodeBefore As ComboBox
    Friend WithEvents cmbStaffCodeAfter As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExec As Button
End Class
