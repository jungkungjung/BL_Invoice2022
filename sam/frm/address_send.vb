Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Linq
Imports System.Xml.Linq
Public Class address_send
    Dim data As New DataSet
    Dim data_ty As New DataSet
    Dim B As New BindingSource
    Dim dtv As New DataView
    Dim t_tooltip As New ToolTip
    Public refresh_cnt As Integer
    Private Sub vat_setting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        company_type()
        new_call()
        Pn_not_show.Hide()
    End Sub
    Private Sub company_type()
        data_ty.Clear()
        Dim sql6 As String = "SELECT "
        sql6 &= " CUSTY_ID,CUSTY_CODE,CUSTY_NAME"
        sql6 &= " FROM"
        sql6 &= " (SELECT 0 AS CUSTY_ID,'*' AS CUSTY_CODE,'(ทั้งหมด)' AS CUSTY_NAME FROM CUSTOMER_TYPE"
        sql6 &= " UNION"
        sql6 &= " SELECT CUSTY_ID,CUSTY_CODE,CUSTY_NAME"
        sql6 &= " FROM CUSTOMER_TYPE) AS CUSTOMER_TYPE"
        sql6 &= " ORDER BY CUSTY_CODE"
        Dim cmd_print As New SqlCommand(sql6, cnn_sql_main)
        Dim adapter_print As New SqlDataAdapter(cmd_print)
        adapter_print.Fill(data_ty, "COMPANY_TY")
        'Dim FML_BIN As New BindingSource
        'If data_ty.Tables("COMPANY_TY").Rows.Count = 0 Then
        '    cmpn_ty_cmb.DataSource = Nothing
        'Else
        '    cmpn_ty_cmb.DataSource = data_ty.Tables("COMPANY_TY")
        '    cmpn_ty_cmb.DisplayMember = "CUSTY_NAME"
        '    cmpn_ty_cmb.ValueMember = "CUSTY_ID"
        'End If
        'cmpn_ty_cmb.SelectedIndex = -1
    End Sub

    Private Sub cal()
        Dim cnt_1 As Integer = 0
        For Each row3 As DataGridViewRow In grw.Rows
            cnt_1 += 1
        Next
        TDAY.Text = cnt_1.ToString("n0") + " รายการ"
        ToolStripStatusLabel1.Text = cnt_1.ToString("n0") + " รายการ"
    End Sub

    Private Sub new_call()
        data.Clear()
        Dim sql6 As String = "SELECT * FROM"
        sql6 &= " (SELECT 0 AS ADDR_ID,CUS_ID,CUS_NAME,CUS_BRANCH,"
        sql6 &= " LTRIM(CASE WHEN CUS_ADDB1 IS NULL THEN '' ELSE CUS_ADDB1 END + ' ' + CASE WHEN CUS_ADDB2 IS NULL THEN '' ELSE CUS_ADDB2 END) + ' ' +"
        sql6 &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE CUS_PROVINCE END  + ' ' + CASE WHEN CUS_POST IS NULL THEN '' ELSE CUS_POST END) AS ADDRESS,CUS_TEL,"
        sql6 &= " CUS_FAX,CUS_TAXID"
        sql6 &= " FROM CUSTOMER"
        sql6 &= " UNION ALL"
        sql6 &= " SELECT"
        sql6 &= " ADDR_ID,ADDR_AR,ADDR_NAME,ADDR_BRANCH,"
        sql6 &= " LTRIM(CASE WHEN ADDR_ADDB1 IS NULL THEN '' ELSE ADDR_ADDB1 END + ' ' + CASE WHEN ADDR_ADDB2 IS NULL THEN '' ELSE ADDR_ADDB2 END) + ' ' +"
        sql6 &= " LTRIM(CASE WHEN ADDR_PROVINCE IS NULL THEN '' ELSE ADDR_PROVINCE END  + ' ' + CASE WHEN ADDR_POST IS NULL THEN '' ELSE ADDR_POST END) AS ADDRESS,ADDR_TEL,"
        sql6 &= " ADDR_FAX,ADDR_TAXID"
        sql6 &= " FROM ADDRESS) AS SEND_ADDRESS"
        sql6 &= " WHERE CUS_ID=" & Integer.Parse(job_link.Text)
        sql6 &= " ORDER BY CUS_BRANCH,ADDR_ID"
        Dim cmd_print As New SqlCommand(sql6, cnn_sql_main)
        Dim adapter_print As New SqlDataAdapter(cmd_print)
        adapter_print.Fill(data, "DOC")
        If data.Tables("DOC").Rows.Count = 0 Then
            dtv = Nothing
            grw.DataSource = dtv
            cal()
        Else
            dtv = data.Tables("DOC").AsDataView 'EQToDataTable(ljoin).AsDataView
            grw.DataSource = dtv
            'grw.Columns(0).Visible = False
            'grw.Columns(6).Visible = False
            'grw.Columns(8).Visible = False
            'grw.Columns(1).Width = 104
            'grw.Columns(2).Width = 280
            'grw.Columns(3).Width = 60
            'grw.Columns(4).Width = 400
            'grw.Columns(5).Width = 140
            'grw.Columns(7).Width = 74
            'grw.Columns(1).HeaderText = "รหัส"
            'grw.Columns(2).HeaderText = "ชื่อลูกค้า"
            'grw.Columns(3).HeaderText = "สาขา"
            'grw.Columns(4).HeaderText = "ที่อยู่"
            'grw.Columns(5).HeaderText = "โทรศัพท์"
            'grw.Columns(7).HeaderText = "ประเภท"
            'ENTER_KEY()
            'list_search.Select()
        End If
    End Sub

    Private Sub ENTER_KEY()
        'Try
        '    If dtv IsNot Nothing Then
        '        If code_name_radio.Checked = True Then
        '            dtv.RowFilter = "[CUS_CODE] Like " & "'%" & list_search.Text & "%' OR [CUS_NAME] Like " & "'%" & list_search.Text & "%'"
        '        ElseIf address_post_radio.Checked = True Then
        '            dtv.RowFilter = "[ADDRESS] Like " & "'%" & list_search.Text & "%'"
        '        ElseIf tel_radio.Checked = True Then
        '            dtv.RowFilter = "[CUS_TEL] Like " & "'%" & list_search.Text & "%'"
        '        End If
        '        dtv.Sort = String.Empty 'แก้ sorting กรณีมีการ คลิก sort ที่ datagrid ก่อนนี้
        '        cal()
        '    End If
        'Catch ex As Exception
        '    MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        'End Try
    End Sub
    Private Sub return_lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles return_lnk.LinkClicked
        'list_search.Clear()
        If dtv IsNot Nothing Then 'ป้องกัน error
            dtv.RowFilter = Nothing
            dtv.Sort = String.Empty
        End If
        cal()
    End Sub
    Public Sub form_refresh()
        new_call()
    End Sub
    Private Sub cmpn_ty_cmb_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs)
        new_call()
    End Sub

    Private Sub list_search_TextChanged(sender As System.Object, e As System.EventArgs)
        ENTER_KEY()
    End Sub

    Private Sub list_search_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then 'ถ้ากด enter ให้เลือกรายการปัจจุบัน
        '    If grw.Rows.Count > 0 Then
        '        Try
        '            Dim f3 As doc_record = CType(Application.OpenForms("doc_record"), doc_record)
        '            f3.TRH_CUSTextBox.Text = grw.CurrentRow.Cells("CUS_ID").Value
        '            f3.CUS_CODE.Text = grw.CurrentRow.Cells("CUS_CODE").Value
        '            DialogResult = Windows.Forms.DialogResult.OK
        '            Close()
        '        Catch ex As Exception
        '            MsgBox(Err.Description)
        '        End Try
        '    End If
        'End If
    End Sub

    Private Sub code_name_radio_CheckedChanged(sender As System.Object, e As System.EventArgs)
        ENTER_KEY()
        'list_search.Focus()
    End Sub

    Private Sub grw_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grw.CellDoubleClick
        If e.RowIndex > -1 Then
            'Try
            '    Dim f3 As doc_record = CType(Application.OpenForms("doc_record"), doc_record)
            '    f3.TRH_CUSTextBox.Text = grw.Rows.Item(e.RowIndex).Cells("CUS_ID").Value
            '    f3.CUS_CODE.Text = grw.Rows.Item(e.RowIndex).Cells("CUS_CODE").Value
            '    'SendKeys.Send("{TAB}")
            '    DialogResult = Windows.Forms.DialogResult.OK
            '    Me.Close()
            'Catch ex As Exception
            '    MsgBox(Err.Description)
            'End Try
        End If
    End Sub
End Class