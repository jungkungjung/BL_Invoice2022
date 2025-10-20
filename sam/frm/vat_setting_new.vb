Public Class vat_setting_new
    Private Sub vat_setting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Pn_not_show.Hide()
            If TRH_VAT_TYTextBox.Text = 0 Then
                vat_ty0.Checked = True
            ElseIf TRH_VAT_TYTextBox.Text = 1 Then
                vat_ty1.Checked = True
            ElseIf TRH_VAT_TYTextBox.Text = 2 Then
                vat_ty2.Checked = True
            End If

            If TRH_VATIOTextBox.Text = 0 Then
                vat_inex0.Checked = True
            ElseIf TRH_VATIOTextBox.Text = 1 Then
                vat_inex1.Checked = True
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub vat_ty0_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles vat_ty0.CheckedChanged, vat_ty1.CheckedChanged, vat_ty2.CheckedChanged
        Try
            If vat_ty0.Checked = True Then
                TRH_VAT_TYTextBox.Text = 0
            ElseIf vat_ty1.Checked = True Then
                TRH_VAT_TYTextBox.Text = 1
            ElseIf vat_ty2.Checked = True Then
                TRH_VAT_TYTextBox.Text = 2
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub vat_inex0_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles vat_inex0.CheckedChanged, vat_inex1.CheckedChanged
        Try
            If vat_inex0.Checked = True Then
                TRH_VATIOTextBox.Text = 0
            ElseIf vat_inex1.Checked = True Then
                TRH_VATIOTextBox.Text = 1
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub save1_Click(sender As System.Object, e As System.EventArgs) Handles save1.Click
        'Dim vat_rate As Double
        'If company_table.Rows.Count > 0 Then 'ดึงอัตราภาษี
        '    vat_rate = company_table.Rows(0).Item("CMPN_VAT_R")
        'Else
        '    vat_rate = 0
        'End If
        'Try
        '    'วิธี assign ค่าให้ form อื่นแบบง่าย
        '    Dim f3 As doc_record_new = CType(Application.OpenForms("doc_record_new"), doc_record_new)
        '    f3.TRH_VAT_TYTextBox.Text = TRH_VAT_TYTextBox.Text
        '    f3.TRH_VATIOTextBox.Text = TRH_VATIOTextBox.Text
        '    If TRH_VAT_TYTextBox.Text = 0 Then
        '        f3.TRH_VAT_RTextBox.Text = vat_rate 'ดึงอัตราภาษีใหม่ เมื่อมีการแก้ไข แล้วบันทึก
        '    Else
        '        f3.TRH_VAT_RTextBox.Text = 0
        '    End If
        '    f3.cal_vat_setting() 'คำนวณภาษีใหม่
        '    Close()
        'Catch ex As Exception
        '    MsgBox(Err.Description)
        'End Try
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub
End Class