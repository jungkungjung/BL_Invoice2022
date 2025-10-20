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

Public Class product_filter
    Dim dtv As New DataView
    Dim t_tooltip As New ToolTip
    Dim user_type As Integer
    Public refresh_cnt As Integer
    Dim vat_r As Double
    Public filter_type As Integer = -1 'ตัวกรองจากหน้าจอ ประเภทลูกค้า

    Private Sub usc_so_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            EnableDoubleBuffered(grw) 'วิธีโหลด datagrid ให้เร็วขึ้น
            customer_type() 'ดึงตัวเลือกประเภทลูกค้า
            new_call()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub usc_so_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        grw.ClearSelection()
    End Sub
    Private Sub customer_profile_DoubleClick(sender As System.Object, e As System.EventArgs) Handles MyBase.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub customer_type()
        Try
            If company_table.Rows.Count > 0 Then
                vat_r = company_table.Rows(0).Item("CMPN_VAT_R")
            Else
                vat_r = 0
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
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
            'Dim ljoin_product = (From t In product_table()
            '                     Join x In product_type_table() On t("PRO_CAT") Equals x("PROTY_ID")
            '                     Where IIf(cmpn_guna_cmb.SelectedIndex > 0, t("PRO_CAT") = cmpn_guna_cmb.SelectedValue, t("PRO_ID") IsNot Nothing)
            Dim ljoin_product = (From t In product_table()
                                Select
                                PRO_ID = t("PRO_ID"),
                                PRO_CODE = t.Field(Of String)("PRO_CODE"),
                                PRO_NAME = t.Field(Of String)("PRO_NAME"),
                                PRO_UNIT = t.Field(Of String)("PRO_UNIT"),
                                PRO_PRICE = t.Field(Of Decimal)("PRO_PRICE"),
                                PRO_MIN = t.Field(Of Decimal)("PRO_MIN"),
                                PRO_MAX = t.Field(Of Decimal)("PRO_MAX"),
                                PRO_VAT_TY = t.Field(Of Byte)("PRO_VAT_TY"),
                                PRO_VAT_R = IIf(t.Field(Of Byte)("PRO_VAT_TY") = 0, vat_r, t.Field(Of Decimal)("PRO_VAT_R"))
                                )
            'ถ้าชนิดภาษีเป็นอัตราทั่วไป ให้ดึงภาษีจากการตั้งค่า =vat_r
            If EQToDataTable(ljoin_product).Rows.Count = 0 Then
                dtv = Nothing
                grw.DataSource = dtv
                cal()
            Else
                dtv = EQToDataTable(ljoin_product).AsDataView
                grw.DataSource = dtv
                grw.Columns(0).Visible = False
                grw.Columns(7).Visible = False
                grw.Columns(8).Visible = False
                grw.Columns(1).Width = 140
                grw.Columns(2).Width = 460
                grw.Columns(3).Width = 80
                grw.Columns(4).Width = 100
                grw.Columns(5).Width = 80
                grw.Columns(6).Width = 80
                grw.Columns(8).Width = 118
                grw.Columns(1).HeaderText = "รหัส"
                grw.Columns(2).HeaderText = "ชื่อสินค้า"
                grw.Columns(3).HeaderText = "หน่วย"
                grw.Columns(4).HeaderText = "ราคา"
                grw.Columns(5).HeaderText = "จุดต่ำสุด"
                grw.Columns(6).HeaderText = "จุดสูงสุด"
                grw.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                grw.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                grw.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                grw.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                grw.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                grw.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                grw.Columns(4).DefaultCellStyle.Format = ("N2")
                grw.Columns(5).DefaultCellStyle.Format = ("N2")
                grw.Columns(6).DefaultCellStyle.Format = ("N2")
                ENTER_KEY()
                list_Guna_search.Select()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub ENTER_KEY()
        Try
            If dtv IsNot Nothing Then
                If cmpn_guna_cmb.SelectedIndex = 0 Then
                    dtv.RowFilter = "[PRO_CODE] Like " & "'%" & list_Guna_search.Text & "%' OR [PRO_NAME] Like " & "'%" & list_Guna_search.Text & "%'"
                ElseIf cmpn_guna_cmb.SelectedIndex = 1 Then
                    dtv.RowFilter = "[PRO_UNIT] Like " & "'%" & list_Guna_search.Text & "%'"
                End If
                dtv.Sort = String.Empty 'แก้ sorting กรณีมีการ คลิก sort ที่ datagrid ก่อนนี้
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

    Private Sub grw_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grw.ColumnHeaderMouseClick
        cal()
    End Sub

    Private Sub cmpn_ty_cmb_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmpn_guna_cmb.SelectionChangeCommitted
        new_call()
    End Sub

    Private Sub list_Guna_search_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles list_Guna_search.KeyDown
     If e.KeyCode = Keys.Enter Then 'ถ้ากด enter ให้เลือกรายการปัจจุบัน
            If grw.Rows.Count > 0 Then
                return_trandetail()
            End If
        End If
    End Sub

    Private Sub grw_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grw.CellDoubleClick
        If e.RowIndex > -1 Then
            Try
                DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        End If
    End Sub
    Private Sub return_trandetail()
        Try
            Dim f3 As doc_record_new = CType(Application.OpenForms("doc_record_new"), doc_record_new)
            DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class