Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Linq
Imports System.Xml.Linq
Imports System.Configuration

Public Class customer_tab
    Dim data As New DataSet
    Dim dtv As New DataView
    Dim t_tooltip As New ToolTip
    Dim user_type As Integer
    Dim rpt4 As New ReportDocument 'ประกาศตรงนี้ เพื่อลบ rpt ใน temp windows ตอนปิดหน้าจอ

    Private Sub usc_so_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            EnableDoubleBuffered(grw) 'วิธีโหลด datagrid ให้เร็วขึ้น
            new_call()
            'bplus_binding() 'สร้าง bindingsource
            Pn_not_show.Hide()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub usc_so_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        grw.ClearSelection()
        'color_cancel()
    End Sub
    Private Sub customer_profile_DoubleClick(sender As System.Object, e As System.EventArgs) Handles MyBase.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub cal()
        Try
            Dim cnt_1 As Integer = 0
            For Each row3 As DataGridViewRow In grw.Rows
                cnt_1 += 1
            Next
            TDAY.Text = cnt_1.ToString("n0") + " รายการ"
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub new_call()
        Try
            data.Clear()
            Dim sql6 As String = "SELECT"
            sql6 &= " CUS_ID,CUS_CODE,CUS_NAME,CUS_BRANCH,CUS_TAXID,"
            sql6 &= " CUS_ADDB1,CUS_ADDB2,CUS_PROVINCE,CUS_POST,CUS_TEL,CUS_REMARK,"
            sql6 &= " LTRIM(CASE WHEN CUS_ADDB1 IS NULL THEN '' ELSE CUS_ADDB1 END + ' ' + CASE WHEN CUS_ADDB2 IS NULL THEN '' ELSE CUS_ADDB2 END) + ' ' +"
            'sql6 &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE CUS_PROVINCE END  + ' ' + CASE WHEN CUS_POST IS NULL THEN '' ELSE CUS_POST END) AS ADDRESS"
            'sql6 &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE IIF(CUS_PROVINCE='กรุงเทพฯ',CUS_PROVINCE,'จ.'+CUS_PROVINCE) END) + ' ' +"
            sql6 &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE (CASE WHEN CUS_PROVINCE='กรุงเทพฯ' OR ASCII(LEFT(CUS_PROVINCE,1))<161 THEN CUS_PROVINCE ELSE 'จ.'+CUS_PROVINCE END) END) + ' ' +"
            sql6 &= " CASE WHEN CUS_POST IS NULL THEN '' ELSE CUS_POST END AS ADDRESS,"
            sql6 &= " CUS_MAIL,CUS_WEB,CUS_CONTACT"
            'sql6 &= " CASE WHEN CUS_POST IS NULL THEN '' ELSE (CASE WHEN CUS_PROVINCE='กรุงเทพฯ' THEN CUS_PROVINCE ELSE 'จ.'+CUS_PROVINCE END) END AS ADDRESS"
            sql6 &= " FROM CUSTOMER"
            sql6 &= " ORDER BY CUS_CODE"
            Dim cmd_print As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_print As New SqlDataAdapter(cmd_print)
            adapter_print.Fill(data, "DOC")

            dtv = data.Tables("DOC").AsDataView 'EQToDataTable(ljoin).AsDataView
            grw.DataSource = dtv
            grw.Columns(0).Visible = False
            'grw.Columns(4).Visible = False
            grw.Columns(10).Visible = False
            grw.Columns(11).Visible = False
            grw.Columns(1).Width = 100
            grw.Columns(2).Width = 260
            grw.Columns(3).Width = 75
            grw.Columns(4).Width = 100
            grw.Columns(5).Width = 200
            grw.Columns(6).Width = 200
            grw.Columns(7).Width = 80
            grw.Columns(8).Width = 58
            grw.Columns(9).Width = 150
            grw.Columns(12).Width = 140
            grw.Columns(13).Width = 140
            grw.Columns(14).Width = 140
            'grw.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            grw.Columns(1).HeaderText = "รหัส"
            grw.Columns(2).HeaderText = "ชื่อลูกค้า"
            grw.Columns(3).HeaderText = "สาขา"
            grw.Columns(4).HeaderText = "TaxID"
            grw.Columns(5).HeaderText = "ที่อยู่1"
            grw.Columns(6).HeaderText = "ที่อยู่2"
            grw.Columns(7).HeaderText = "จังหวัด"
            grw.Columns(8).HeaderText = "ไปรษณีย์"
            grw.Columns(9).HeaderText = "โทรศัพท์"
            grw.Columns(10).HeaderText = "หมายเหตุ"
            grw.Columns(12).HeaderText = "อีเมล์"
            grw.Columns(13).HeaderText = "เว็บไซด์"
            grw.Columns(14).HeaderText = "ผู้ติดต่อ"
            ENTER_KEY()
            list_Guna_search.Select()
            grw.ClearSelection()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub ENTER_KEY()
        Try
            If dtv IsNot Nothing Then
                If list_Guna_search.Text.Length = 0 Then 'ป้องกันกรองค่า null ไมได้
                    dtv.RowFilter = Nothing
                    cal()
                    Exit Sub
                End If
                If cmpn_guna_cmb.SelectedIndex = 0 Then
                    dtv.RowFilter = "[CUS_CODE] Like " & "'%" & list_Guna_search.Text & "%' OR [CUS_NAME] Like " & "'%" & list_Guna_search.Text & "%'"
                ElseIf cmpn_guna_cmb.SelectedIndex = 1 Then
                    dtv.RowFilter = "[ADDRESS] Like " & "'%" & list_Guna_search.Text & "%'"
                ElseIf cmpn_guna_cmb.SelectedIndex = 2 Then
                    dtv.RowFilter = "[CUS_TEL] Like " & "'%" & list_Guna_search.Text & "%'"
                End If
                cal()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub list_Guna_search_TextChanged(sender As System.Object, e As System.EventArgs) Handles list_Guna_search.TextChanged
        ENTER_KEY()
    End Sub
    Private Sub return_lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles return_lnk.LinkClicked
        list_Guna_search.Text = ""
        ENTER_KEY()
    End Sub
    Public Sub form_refresh()
        new_call()
    End Sub

    Private Sub grw_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grw.CellDoubleClick
        If e.RowIndex > -1 Then
            Try
                Dim FRM As New customer_record_new
                FRM.frm1 = Me 'ใช้วิธีนี้ เพื่อคืนค่า refresh from (ผ่านค่าแบบ Form Type)
                FRM.MdiParent = MainMenu
                FRM.Dock = DockStyle.Fill
                FRM.insert_status.Text = 0
                'ทดสอบแก้ไข config เอง
                'FRM.CUSTOMERTableAdapter.Connection.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=D:\data\INVOICE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
                'FRM.CUSTOMERTableAdapter.Connection.ConnectionString = "Data Source=.\SQLEXPRESS11;AttachDbFilename=D:\data\BL\INVOICE_BL.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
                FRM.CUSTOMERTableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน
                FRM.CUSTOMERTableAdapter.FillBy(FRM.INVOICEDataSet.CUSTOMER, grw.Rows.Item(e.RowIndex).Cells("CUS_ID").Value)
                FRM.Show()
                FRM.bottom_line.Focus()
            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
            End Try
        End If
    End Sub

    Private Sub cmpn_ty_cmb_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmpn_guna_cmb.SelectionChangeCommitted
        'new_call()
        ENTER_KEY()
        list_Guna_search.Select()
    End Sub

    Private Sub exit_guna_bt_Click(sender As System.Object, e As System.EventArgs) Handles exit_guna_bt.Click
        Close()
    End Sub

    Private Sub add_guna_bt_Click(sender As System.Object, e As System.EventArgs) Handles add_guna_bt.Click
        'If customer_type_table.Rows.Count = 0 Then 'ตรวจสอบ ถ้าไม่มีประเภทลูกค้า
        '    MsgBox("ไม่พบประเภทลูกหนี้ เปิดหน้าจอบันทึก", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
        '    Dim frm4 As New customer_type_record
        '    frm4.MdiParent = MainMenu
        '    frm4.Dock = DockStyle.Fill
        '    frm4.Show()
        '    frm4.create_job()
        '    Exit Sub
        'End If
        Try
            Dim FRM As New customer_record_new
            FRM.frm1 = Me 'ใช้วิธีนี้ เพื่อคืนค่า refresh from (ผ่านค่าแบบ Form Type)
            FRM.MdiParent = MainMenu
            FRM.Dock = DockStyle.Fill
            FRM.CUSTOMERTableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน
            'FRM.CUSTOMERTableAdapter.FillBy(FRM.INVOICEDataSet.CUSTOMER, -1) 'กรณีกด สร้างใหม่ ให้หา fillby เป็น -1 ซึ่งไม่มีอยู่แล้ว เป็นการสร้างใหม่
            FRM.Show()
            FRM.create_job()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub export_guna_bt_Click(sender As System.Object, e As System.EventArgs) Handles export_guna_bt.Click
        Dim xlApp As New Excel.Application
        Dim xlWorkBook2 As Excel.Workbook '= New Excel.Workbook
        xlWorkBook2 = Nothing
        Dim misValue As Object = System.Reflection.Missing.Value

        If grw Is Nothing OrElse grw.RowCount <= 0 Then
            MsgBox("I think the the Datatable is empty!!!")
            Exit Sub
        End If
        Try
            xlWorkBook2 = xlApp.Workbooks.Add(misValue)
            xlApp.Visible = True
            Dim xlWorkSheet = xlWorkBook2.ActiveSheet
            'Data transfer from grid to Excel. 
            'With xlWorkSheet
            '.Range("A1", misValue).EntireRow.Font.Bold = True

            Dim formatRange As Excel.Range
            formatRange = xlWorkSheet.Range("A:A", "L:L")
            formatRange.NumberFormat = "@"

            'Set Clipboard Copy Mode
            grw.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            grw.SelectAll()

            'Get the content from Grid for Clipboard
            Dim str As String = TryCast(grw.GetClipboardContent().GetData(DataFormats.UnicodeText), String)

            'Set the content to Clipboard
            Clipboard.SetText(str, TextDataFormat.UnicodeText)

            'Identifiy and select the range of cells in excel to paste the clipboard data.
            '.Range("A1:" & ConvertToLetter(grw.ColumnCount) & grw.RowCount, misValue).Select()

            'Paste the clipboard data
            xlWorkSheet.Paste()
            'xlApp.Columns.AutoFit()
            xlWorkSheet.Columns.AutoFit()
            grw.ClearSelection()
            Clipboard.Clear()

            'End With
            releaseObject(xlWorkSheet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            releaseObject(xlWorkBook2)
            releaseObject(xlApp)
        End Try
    End Sub

    Private Sub report_guna_bt_Click(sender As System.Object, e As System.EventArgs) Handles report_guna_bt.Click
        Try
            If dtv Is Nothing OrElse dtv.Count = 0 Then
                MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Else
                Dim ThaiCompanyName As String = ""
                If company_table.Rows.Count > 0 Then
                    ThaiCompanyName = company_table.Rows(0).Item("CMPN_NAME").ToString
                End If
                Dim FM4 As New preview
                'Dim rpt4 As New ReportDocument
                rpt4.Load(Application.StartupPath & "\Rpt\CUSTOMER_1001.rpt")
                rpt4.SetDataSource(dtv)
                FM4.CrystalReportViewer1.ReportSource = rpt4
                rpt4.SetParameterValue("ThaiCompanyName", ThaiCompanyName)
                rpt4.SetParameterValue("head_text", "สรุปรายชื่อลูกค้า")
                FM4.Show()
                FM4.CrystalReportViewer1.Zoom(110)
                'rpt4.Dispose()
                'FM4.Dispose()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub customer_tab_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        rpt4.Dispose() 'เพื่อปิด rpt ใน temp windows
    End Sub
    Public Sub FIND_GRW_ROWS(ByVal id As Integer) 'id ของ talbe หาแถวรายการ เมื่อมีการแก้ไขจาก ฟอร์มลูก และ form_refresh
        Try
            Dim trd_find_row = (From r As DataGridViewRow In grw.Rows Where r.Cells("CUS_ID").Value = id).ToList
            If trd_find_row.Count > 0 Then 'ป้องกัน กรณี สร้างเอกสารใหม่ และเป็นวันที่เอกสาร ที่ไม่อยู่ในช่วงที่กรองข้อมูล จะ error index out of rang
                Dim trd_row As Integer = trd_find_row.Item(0).Index
                grw.CurrentCell = grw.Rows(trd_row).Cells("CUS_CODE")
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
End Class