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

Public Class customer_filter
    Dim data As New DataSet
    Dim dtv As New DataView
    Dim t_tooltip As New ToolTip
    Dim user_type As Integer
    Public refresh_cnt As Integer
    Public filter_type As Integer = -1 'ตัวกรองจากหน้าจอ ประเภทลูกค้า

    Private Sub usc_so_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EnableDoubleBuffered(grw) 'วิธีโหลด datagrid ให้เร็วขึ้น
        'customer_type() 'ดึงตัวเลือกประเภทลูกค้า
        new_call()
    End Sub

    Private Sub usc_so_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        grw.ClearSelection()
    End Sub
    Private Sub customer_profile_DoubleClick(sender As System.Object, e As System.EventArgs) Handles MyBase.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Private Sub customer_type()
    '    If customer_alltype_table.Rows.Count > 0 Then 'ดึง data จาก module
    '        cmpn_guna_cmb.DataSource = customer_alltype_table()
    '        cmpn_guna_cmb.DisplayMember = "CUSTY_NAME"
    '        cmpn_guna_cmb.ValueMember = "CUSTY_ID"
    '    End If
    'End Sub
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
            sql6 &= " CUS_ID,CUS_CODE,CUS_NAME,CUS_BRANCH,"
            sql6 &= " LTRIM(CASE WHEN CUS_ADDB1 IS NULL THEN '' ELSE CUS_ADDB1 END + ' ' + CASE WHEN CUS_ADDB2 IS NULL THEN '' ELSE CUS_ADDB2 END) + ' ' +"
            sql6 &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE CUS_PROVINCE END  + ' ' + CASE WHEN CUS_POST IS NULL THEN '' ELSE CUS_POST END) AS ADDRESS,CUS_TEL,"
            sql6 &= " CUS_TAXID" 'CUSTY_CODE,CUSTY_NAME,
            sql6 &= " FROM CUSTOMER"
            'sql6 &= " JOIN CUSTOMER_TYPE ON CUSTOMER.CUS_CAT = CUSTOMER_TYPE.CUSTY_ID"
            'If cmpn_guna_cmb.SelectedIndex > 0 Then 'รายการแรก 0 คือเลือกทั้งหมด
            '    sql6 &= " WHERE"
            '    sql6 &= " CUS_CAT=" & cmpn_guna_cmb.SelectedValue
            'End If
            sql6 &= " ORDER BY CUS_CODE"
            Dim cmd_print As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_print As New SqlDataAdapter(cmd_print)
            adapter_print.Fill(data, "DOC")
            dtv = data.Tables("DOC").AsDataView 'EQToDataTable(ljoin).AsDataView
            grw.DataSource = dtv
            grw.Columns(0).Visible = False
            grw.Columns(6).Visible = False
            'grw.Columns(7).Visible = False
            grw.Columns(1).Width = 104
            grw.Columns(2).Width = 270
            grw.Columns(3).Width = 74
            grw.Columns(4).Width = 360
            grw.Columns(5).Width = 140
            grw.Columns(6).Width = 110
            grw.Columns(1).HeaderText = "รหัส"
            grw.Columns(2).HeaderText = "ชื่อลูกค้า"
            grw.Columns(3).HeaderText = "สาขา"
            grw.Columns(4).HeaderText = "ที่อยู่"
            grw.Columns(5).HeaderText = "โทรศัพท์"
            grw.Columns(6).HeaderText = "TaxID"
            ENTER_KEY()
            list_Guna_search.Select()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub ENTER_KEY()
        Try
            If dtv IsNot Nothing Then
                'dtv.RowFilter = "[CUS_CODE] Like " & "'%" & list_Guna_search.Text & "%' OR [CUS_NAME] Like " & "'%" & list_Guna_search.Text & "%'"
                'dtv.Sort = String.Empty 'แก้ sorting กรณีมีการ คลิก sort ที่ datagrid ก่อนนี้
                'cal()

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
        Try
            list_Guna_search.Text = ""
            If dtv IsNot Nothing Then 'ป้องกัน error
                dtv.RowFilter = Nothing
                dtv.Sort = String.Empty
            End If
            cal()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Public Sub form_refresh()
        new_call()
    End Sub

    Private Sub cmpn_ty_cmb_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmpn_guna_cmb.SelectionChangeCommitted
        'new_call()
        ENTER_KEY()
        list_Guna_search.Select()
    End Sub

    Private Sub list_Guna_search_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles list_Guna_search.KeyDown
        If e.KeyCode = Keys.Enter Then 'ถ้ากด enter ให้เลือกรายการปัจจุบัน
            If list_Guna_search.Text.Length = 0 Then
                Exit Sub 'ถ้าไม่ได้กรองเลย ไม่ต้อง return ค่า
            End If
            If grw.Rows.Count > 0 Then
                'Try
                '    Dim f3 As doc_record_new = CType(Application.OpenForms("doc_record_new"), doc_record_new)
                '    f3.TRH_CUSTextBox.Text = grw.CurrentRow.Cells("CUS_ID").Value
                '    f3.CUS_CODE.Text = grw.CurrentRow.Cells("CUS_CODE").Value
                '    DialogResult = Windows.Forms.DialogResult.OK
                '    Close()
                'Catch ex As Exception
                '    MsgBox(Err.Description)
                'End Try
                DialogResult = Windows.Forms.DialogResult.OK
                Close()
            End If
        End If
    End Sub

    Private Sub grw_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grw.CellDoubleClick
        If e.RowIndex > -1 Then
            'Try
            '    Dim f3 As doc_record_new = CType(Application.OpenForms("doc_record_new"), doc_record_new)
            '    f3.TRH_CUSTextBox.Text = grw.Rows.Item(e.RowIndex).Cells("CUS_ID").Value
            '    f3.CUS_CODE.Text = grw.Rows.Item(e.RowIndex).Cells("CUS_CODE").Value
            '    'SendKeys.Send("{TAB}")
            '    DialogResult = Windows.Forms.DialogResult.OK
            '    Me.Close()
            'Catch ex As Exception
            '    MsgBox(Err.Description)
            'End Try
            DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class