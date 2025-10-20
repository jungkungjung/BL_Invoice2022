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
Imports System.Reflection

Public Class doc_salesproduct_tab
    Dim data As New DataSet
    Dim dtv As New DataView
    Dim t_tooltip As New ToolTip
    Dim user_type As Integer
    Dim rpt4 As New ReportDocument 'ประกาศตรงนี้ เพื่อลบ rpt ใน temp windows ตอนปิดหน้าจอ
    Dim cmpn_chk As String = "" 'เช็ค license ลูกค้า
    Dim cmpn_tax_chk As String = ""
    Dim cmpn_regno_chk As String = ""
    Public Sub EnableDoubleBuffered(ByVal dgv As DataGridView) 'วิธีโหลด datagrid ให้เร็วขึ้น
        Try
            Dim dgvType As Type = dgv.[GetType]()
            Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
            pi.SetValue(dgv, True, Nothing)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub usc_so_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            EnableDoubleBuffered(grw) 'วิธีโหลด datagrid ให้เร็วขึ้น
            ''Date_from.Value = Now.AddYears(-1)
            Date_from.Value = New Date(Now.Year, 1, 1)
            'company_type() 'ดึงตัวเลือกประเภทลูกค้า
            new_call()
            Pn_not_show.Hide()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub usc_so_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        grw.ClearSelection()
        'color_cancel()
    End Sub

    Private Sub customer_profile_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub show_lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles show_lnk.LinkClicked
        If Date_from.Value.Date > Date_to.Value.Date Then
            MsgBox("รูปแบบการเลือกวันที่ไม่ถูกต้อง", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
        Else
            new_call()
        End If
    End Sub
    'Private Sub company_type()
    '    If customer_alltype_table.Rows.Count > 0 Then 'ดึง data จาก module
    '        cmpn_guna_cmb.DataSource = customer_alltype_table()
    '        cmpn_guna_cmb.DisplayMember = "CUSTY_NAME"
    '        cmpn_guna_cmb.ValueMember = "CUSTY_ID"
    '    End If
    'End Sub
    Private Sub cal()
        Try
            'Dim cnt_1 As Integer = 0
            Dim amt_1 As Double = 0
            Dim qty_1 As Double = 0
            For Each row3 As DataGridViewRow In grw.Rows
                'cnt_1 += 1 'cnt_1.ToString("n0") +
                qty_1 += row3.Cells("TRD_QTY").Value
                amt_1 += row3.Cells("TRD_G_KEYIN").Value
            Next
            amt_sum.Text = "รวม  " + grw.Rows.Count.ToString("n0") + " รายการ" + "  จำนวน " + qty_1.ToString("#,##0.##") + " ชิ้น" '         ยอดรวม : " + amt_1.ToString("n2")
            GunaButton1.Text = amt_1.ToString("n2")
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub new_call()
        Try
            Dim datefrom, dateto As String
            datefrom = Date_from.Value.Date.ToString("MM/dd/") + Date_from.Value.Year.ToString("#")
            dateto = Date_to.Value.Date.ToString("MM/dd/") + Date_to.Value.Year.ToString("#")
            data.Clear()
            Dim sql6 As String = "SELECT"
            'ไม่ต้อง check license โชว์ได้หมดทุกรายการ แต่ตัดปุ่ม เพิ่มใหม่ออก
            sql6 &= " TRH_ID,TRH_DATE,TRH_NO,"
            sql6 &= " CUS_ID,CUS_CODE,CUS_NAME,CUS_BRANCH,CUS_TAXID,"
            sql6 &= " TRH_TERM,TRH_DUE,"
            sql6 &= " TRH_VAT_DATE,TRH_VAT_NO,SLMN_CODE,SLMN_NAME,"
            sql6 &= " TRH_G_KEYIN,TRH_DISC_AMT,TRH_G_SELL,TRH_G_VAT,TRH_G_NET,"
            sql6 &= " TRD_ID,TRD_SEQ,TRD_SKU_CODE, TRD_SKU_NAME,"
            sql6 &= " TRD_UNIT, TRD_QTY, TRD_UPC,TRD_G_KEYIN,TRD_G_SELL,TRD_G_VAT,TRD_G_AMT"
            sql6 &= " FROM TRANMAIN"
            sql6 &= " JOIN CUSTOMER ON TRANMAIN.TRH_CUS=CUSTOMER.CUS_ID"
            sql6 &= " JOIN SALESMAN ON TRH_SLMN = SLMN_ID"
            sql6 &= " JOIN TRANDETAIL ON TRH_ID = TRD_TRH"
            sql6 &= " WHERE"
            sql6 &= " (TRH_DATE >= " & "'" & datefrom & "'"
            sql6 &= " AND TRH_DATE <= " & "'" & dateto & "')"
            'If cmpn_guna_cmb.SelectedIndex > 0 Then 'รายการแรก 0 คือเลือกทั้งหมด
            '    sql6 &= " AND CUS_CAT=" & cmpn_guna_cmb.SelectedValue
            'End If
            sql6 &= " ORDER BY TRH_DATE,TRH_NO,TRD_SEQ"
            Dim cmd_print As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_print As New SqlDataAdapter(cmd_print)
            adapter_print.Fill(data, "DOC")

            dtv = data.Tables("DOC").AsDataView 'EQToDataTable(ljoin).AsDataView
            grw.DataSource = dtv
            grw.Columns(0).Visible = False
            grw.Columns(3).Visible = False
            grw.Columns(6).Visible = False
            grw.Columns("CUS_TAXID").Visible = False
            grw.Columns("TRH_DUE").Visible = False
            grw.Columns("TRH_TERM").Visible = False
            grw.Columns("TRH_DUE").Visible = False
            'grw.Columns("SLMN_NAME").Visible = False       
            grw.Columns("SLMN_CODE").Visible = False
            grw.Columns("TRH_G_KEYIN").Visible = False
            grw.Columns("TRH_DISC_AMT").Visible = False
            grw.Columns("TRD_ID").Visible = False
            grw.Columns("TRD_SEQ").Visible = False
            grw.Columns("TRD_G_SELL").Visible = False
            grw.Columns("TRD_G_VAT").Visible = False
            grw.Columns("TRD_G_AMT").Visible = False
            grw.Columns(1).Width = 74
            grw.Columns(2).Width = 114
            grw.Columns(4).Width = 84
            grw.Columns(5).Width = 230 '250
            grw.Columns(6).Width = 44
            grw.Columns(8).Width = 44
            grw.Columns(9).Width = 74
            grw.Columns(10).Width = 74
            grw.Columns(11).Width = 110
            grw.Columns(13).Width = 74
            grw.Columns(16).Width = 90
            grw.Columns(17).Width = 90
            grw.Columns(18).Width = 90
            grw.Columns("TRD_SKU_CODE").Width = 104
            grw.Columns("TRD_SKU_NAME").Width = 230
            grw.Columns("TRD_UNIT").Width = 56
            grw.Columns("TRD_QTY").Width = 84
            grw.Columns("TRD_UPC").Width = 90
            grw.Columns("TRD_G_KEYIN").Width = 90
            grw.Columns(1).HeaderText = "วันที่"
            grw.Columns(2).HeaderText = "เลขที่เอกสาร"
            grw.Columns(4).HeaderText = "รหัสลูกค้า"
            grw.Columns(5).HeaderText = "ชื่อลูกค้า"
            grw.Columns(10).HeaderText = "วันที่ใบกำกับ"
            grw.Columns(11).HeaderText = "ใบกำกับภาษี"
            grw.Columns("SLMN_NAME").HeaderText = "พนง.ขาย"
            grw.Columns(16).HeaderText = "มูลค่าสินค้า"
            grw.Columns(17).HeaderText = "มูลค่าภาษี"
            grw.Columns(18).HeaderText = "ยอดสุทธิ"
            grw.Columns("TRD_SKU_CODE").HeaderText = "รหัสสินค้า"
            grw.Columns("TRD_SKU_NAME").HeaderText = "ชื่อสินค้า"
            grw.Columns("TRD_UNIT").HeaderText = "หน่วย"
            grw.Columns("TRD_QTY").HeaderText = "จำนวน"
            grw.Columns("TRD_UPC").HeaderText = "ราคา"
            grw.Columns("TRD_G_KEYIN").HeaderText = "ยอดเงิน"
            'grw.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            'grw.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            grw.Columns("TRH_G_SELL").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRH_G_VAT").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRH_G_NET").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRD_QTY").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRD_UPC").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRD_G_KEYIN").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRH_G_SELL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRH_G_VAT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRH_G_NET").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRD_QTY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRD_UPC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRD_G_KEYIN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grw.Columns("TRH_G_SELL").DefaultCellStyle.Format = ("N2")
            grw.Columns("TRH_G_VAT").DefaultCellStyle.Format = ("N2")
            grw.Columns("TRH_G_NET").DefaultCellStyle.Format = ("N2")
            grw.Columns("TRD_QTY").DefaultCellStyle.Format = ("N2")
            grw.Columns("TRD_UPC").DefaultCellStyle.Format = ("N2")
            grw.Columns("TRD_G_KEYIN").DefaultCellStyle.Format = ("N2")
            ENTER_KEY()
            list_Guna_search.Select()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub ENTER_KEY()
        Try
            If dtv IsNot Nothing Then
                If cmpn_guna_cmb.SelectedIndex = 0 Then
                    dtv.RowFilter = "[TRH_NO] Like " & "'%" & list_Guna_search.Text & "%'"
                ElseIf cmpn_guna_cmb.SelectedIndex = 1 Then
                    dtv.RowFilter = "[TRH_VAT_NO] Like " & "'%" & list_Guna_search.Text & "%'"
                ElseIf cmpn_guna_cmb.SelectedIndex = 2 Then
                    dtv.RowFilter = "[CUS_CODE] Like " & "'%" & list_Guna_search.Text & "%' OR [CUS_NAME] Like " & "'%" & list_Guna_search.Text & "%'"
                ElseIf cmpn_guna_cmb.SelectedIndex = 3 Then
                    dtv.RowFilter = "[SLMN_CODE] Like " & "'%" & list_Guna_search.Text & "%' OR [SLMN_NAME] Like " & "'%" & list_Guna_search.Text & "%'"
                ElseIf cmpn_guna_cmb.SelectedIndex = 4 Then
                    dtv.RowFilter = "[TRD_SKU_CODE] Like " & "'%" & list_Guna_search.Text & "%' OR [TRD_SKU_NAME] Like " & "'%" & list_Guna_search.Text & "%'"
                End If
                cal()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub list_Guna_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_Guna_search.TextChanged
        ENTER_KEY()
    End Sub
    Private Sub return_lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles return_lnk.LinkClicked
        Try
            list_Guna_search.Text = ""
            If dtv IsNot Nothing Then 'ป้องกัน error
                dtv.RowFilter = Nothing
                dtv.Sort = String.Empty
            End If
            'color_cancel()
            'new_call()
            cal()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Public Sub form_refresh()
        new_call()
    End Sub

    Private Sub grw_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grw.CellDoubleClick
        If e.RowIndex > -1 Then
            Try
                Dim FRM As New doc_record_new
                FRM.MdiParent = MainMenu
                FRM.insert_status.Text = 0
                FRM.job_link.Text = grw.Rows.Item(e.RowIndex).Cells("TRH_ID").Value
                FRM.trd_id_lnk.Text = grw.Rows(e.RowIndex).Cells("TRD_ID").Value 'ส่งค่า id ของ tran เพื่อหาตำแหน่งแถว
                FRM.TRANMAINTableAdapter.Connection.ConnectionString = cnn_str 'ดึง connection จาก ini สามารถแก้ไข ini ได้
                FRM.TRANDETAILTableAdapter.Connection.ConnectionString = cnn_str
                FRM.TRANMAINTableAdapter.FillBy(FRM.INVOICEDataSet.TRANMAIN, grw.Rows.Item(e.RowIndex).Cells("TRH_ID").Value)
                FRM.TRANDETAILTableAdapter.FillBy(FRM.INVOICEDataSet.TRANDETAIL, grw.Rows.Item(e.RowIndex).Cells("TRH_ID").Value)
                FRM.Dock = DockStyle.Fill
                FRM.Show()
                FRM.FIND_TRD_ROWS() 'ไปยังตำแหน่ง record รายการสินค้าที่เลือก
                FRM.bottom_line.Focus()
            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
            End Try
        End If
    End Sub

    Private Sub cmpn_ty_cmb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmpn_guna_cmb.SelectionChangeCommitted
        'new_call()
        ENTER_KEY()
        list_Guna_search.Select()
    End Sub

    Private Sub exit_guna_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_guna_bt.Click
        Close()
    End Sub

    Private Sub add_guna_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If company_licensse() = False Then
                If tranmain_table.Rows.Count > 9 Then
                    MsgBox("เลขทะเบียนซอฟแวร์ไม่ถูกต้องหรือเป็นเวอร์ชั่นทดลอง โปรดติดต่อเจ้าหน้าที่ เพื่อขอเลขทะเบียน", MsgBoxStyle.Question, "คำเตือน")
                    Exit Sub 'ถ้า license ไม่ถูกต้อง ออกจาก sub
                End If
            End If
            Dim FRM As New doc_record_new
            FRM.MdiParent = MainMenu
            FRM.Dock = DockStyle.Fill
            FRM.TRANMAINTableAdapter.Connection.ConnectionString = cnn_str 'ดึง connection จาก ini สามารถแก้ไข ini ได้
            FRM.TRANDETAILTableAdapter.Connection.ConnectionString = cnn_str
            FRM.TRANMAINTableAdapter.FillBy(FRM.INVOICEDataSet.TRANMAIN, -1) 'ใช้แบบนี้ ป้องกัน error จาก fillby
            FRM.TRANDETAILTableAdapter.FillBy(FRM.INVOICEDataSet.TRANDETAIL, -1)
            FRM.Show()
            FRM.create_job()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub report_guna_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles report_guna_bt.Click
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
                rpt4.Load(Application.StartupPath & "\Rpt\SELL_DETAIL_1001.rpt")
                rpt4.SetDataSource(dtv)
                FM4.CrystalReportViewer1.ReportSource = rpt4
                rpt4.SetParameterValue("ThaiCompanyName", ThaiCompanyName)
                rpt4.SetParameterValue("head_text", "สรุปรายละเอียดขายสินค้า")
                rpt4.SetParameterValue("datefrom_text", Date_from.Value.Date)
                rpt4.SetParameterValue("dateto_text", Date_to.Value.Date)
                FM4.Show()
                FM4.CrystalReportViewer1.Zoom(140) 'ขยายหน้าจอ รายงานแบบ landscape
                'rpt4.Dispose()
                'FM4.Dispose()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub export_guna_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles export_guna_bt.Click
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
            formatRange = xlWorkSheet.Range("A:A", "G:G")
            formatRange.NumberFormat = "@"

            Dim formatFI As Excel.Range
            formatFI = xlWorkSheet.Range("K:K", "M:M")
            formatFI.NumberFormat = "@"

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

    Private Sub doc_tab_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        rpt4.Dispose() 'เพื่อปิด rpt ใน temp windows
    End Sub
End Class