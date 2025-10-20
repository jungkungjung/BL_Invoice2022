Public Class trd_remark_dialog
    Private Sub vat_setting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub save1_Click(sender As System.Object, e As System.EventArgs) Handles save1.Click
        Try
            'วิธี assign ค่าให้ form อื่นแบบง่าย
            '    Dim f3 As doc_record_new = CType(Application.OpenForms("doc_record_new"), doc_record_new)
            '    f3.TRH_VAT_TYTextBox.Text = TRH_VAT_TYTextBox.Text
            '    f3.TRH_VATIOTextBox.Text = TRH_VATIOTextBox.Text
            '    If TRH_VAT_TYTextBox.Text = 0 Then
            '        f3.TRH_VAT_RTextBox.Text = vat_rate 'ดึงอัตราภาษีใหม่ เมื่อมีการแก้ไข แล้วบันทึก
            '    Else
            '        f3.TRH_VAT_RTextBox.Text = 0
            '    End If
            '    f3.cal_vat_setting() 'คำนวณภาษีใหม่
            DialogResult = DialogResult.OK
            Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub escape_lnk_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles escape_lnk.LinkClicked
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub
End Class