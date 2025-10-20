Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared.PrintLayoutSettings
Public Class preview
    Public print_id As Integer = 0
    Private Sub CrystalReportViewer1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.DoubleClick
        Try
            If print_id <> 1 Then 'ถ้าไม่ใช่ฟอร์มพิมพ์ออกตรง ใช้ double click ไม่ด้
                Exit Sub
            End If

            Dim msgtext As String
            msgtext = MsgBox("พิมพ์ออกเครื่องพิมพ์", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If msgtext = vbYes Then
                DialogResult = Windows.Forms.DialogResult.OK
                Close()
                'MsgBox("ลบข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
            Else : Return
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub close_strip_Click(sender As System.Object, e As System.EventArgs) Handles close_strip.Click
        Close()
    End Sub

    Private Sub print_strip_Click(sender As System.Object, e As System.EventArgs) Handles print_strip.Click
        DialogResult = Windows.Forms.DialogResult.OK 'ถ้าเลือกพิมพ์ ให้ ส่งค่า ok
        Close()
    End Sub
End Class