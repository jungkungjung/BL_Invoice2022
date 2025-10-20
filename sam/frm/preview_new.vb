'Imports CrystalDecisions.Shared.PrintLayoutSettings
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class preview_new
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
                MsgBox("ลบข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
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

    Private Sub preview_new_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim default_printer As New Drawing.Printing.PrinterSettings 'default เครื่องพิมพ์
            For Each strprintername As String In Drawing.Printing.PrinterSettings.InstalledPrinters
                'printer_cmb.SelectedIndex = 0
                printer_guna_cmb.Items.Add(strprintername)
                printer_guna_cmb.SelectedItem = default_printer.PrinterName.ToString
            Next
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub print_bt_Click(sender As System.Object, e As System.EventArgs)
        'Dim rpt As New Report1
        'Dim txtrp_printername As CrystalDecisions.CrystalReports.Engine.TextObject
        'txtrp_printername = CType(rpt.ReportDefinition.ReportObjects.Item("Text2"), CrystalDecisions.CrystalReports.Engine.TextObject)
        'txtrp_printername.Text = printer_cmb.Text
        'rpt.PrintOptions.PrinterName = printer_cmb.Text
        'rpt.PrintOptions.PaperSize = PaperSize.DefaultPaperSize
        'rpt.PrintToPrinter(1, False, 0, 0)
    End Sub

    Private Sub Guna_print_Click(sender As System.Object, e As System.EventArgs) Handles Guna_print.Click
        DialogResult = Windows.Forms.DialogResult.OK 'ถ้าเลือกพิมพ์ ให้ ส่งค่า ok
        Close()
    End Sub
End Class