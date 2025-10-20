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

Public Class products_type_profile
    Dim data As New DataSet
    Dim data_ty As New DataSet
    Dim B As New BindingSource
    Dim dtv As New DataView
    Dim ljoin_condition As Object
    Dim t_tooltip As New ToolTip
    Dim user_type As Integer
    Public refresh_cnt As Integer

    Private Sub usc_so_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        new_call()
    End Sub
    Private Sub usc_so_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'color_cancel()
    End Sub
    Private Sub products_profile_DoubleClick(sender As System.Object, e As System.EventArgs) Handles MyBase.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cal()
        Dim cnt_1 As Integer = 0
        For Each row3 As DataGridViewRow In grw.Rows
            cnt_1 += 1
        Next
        TDAY.Text = cnt_1.ToString("n0") + " รายการ"
    End Sub

    Private Sub new_call()
        data.Clear()
        Dim sql6 As String = "SELECT"
        sql6 &= " PROTY_ID,PROTY_CODE,PROTY_NAME"
        sql6 &= " FROM PRODUCTS_TYPE"
        sql6 &= " ORDER BY PROTY_CODE"
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
            grw.Columns(0).Visible = False
            grw.Columns(1).Width = 120
            grw.Columns(2).Width = 838
            grw.Columns(1).HeaderText = "รหัส"
            grw.Columns(2).HeaderText = "ชื่อประเภท"
            cal()
        End If
    End Sub

    Private Sub ENTER_KEY()
    End Sub
    Private Sub list_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ENTER_KEY()
    End Sub
    Private Sub return_lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles return_lnk.LinkClicked
        If dtv IsNot Nothing Then 'ป้องกัน error
            dtv.RowFilter = Nothing
            dtv.Sort = String.Empty
        End If
        cal()
    End Sub
    Public Sub form_refresh()
        new_call()
    End Sub

    Private Sub grw_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grw.ColumnHeaderMouseClick
        cal()
    End Sub

    Private Sub grw_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grw.CellDoubleClick
        If e.RowIndex > -1 Then
            Dim FRM As New products_type_record
            FRM.MdiParent = MainMenu
            FRM.insert_status.Text = 0
            FRM.job_link.Text = grw.Rows.Item(e.RowIndex).Cells("PROTY_ID").Value
            FRM.PRODUCTS_TYPETableAdapter.FillBy(FRM.INVOICEDataSet.PRODUCTS_TYPE, grw.Rows.Item(e.RowIndex).Cells("PROTY_ID").Value)
            FRM.Dock = DockStyle.Fill
            FRM.Show()
            'FRM.PRODUCTSBindingSource.Position = FRM.PRODUCTSBindingSource.Find("PRO_ID", grw.Rows.Item(e.RowIndex).Cells("PRO_ID").Value)
            FRM.exit1.Focus()
        End If
    End Sub

    Private Sub add1_Click(sender As System.Object, e As System.EventArgs) Handles add1.Click
        Dim FRM As New products_type_record
        FRM.MdiParent = MainMenu
        FRM.Dock = DockStyle.Fill
        FRM.Show()
        FRM.create_job()
    End Sub

    Private Sub print1_Click(sender As System.Object, e As System.EventArgs) Handles print1.Click
        MsgBox("ยังไม่ออกแบบ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
    End Sub

    Private Sub exit1_Click(sender As System.Object, e As System.EventArgs) Handles exit1.Click
        Close()
    End Sub

    Private Sub export1_Click(sender As System.Object, e As System.EventArgs) Handles export1.Click
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
            formatRange = xlWorkSheet.Range("A:A", "C:C")
            formatRange.NumberFormat = "@"

            Dim formatRange2 As Excel.Range
            formatRange2 = xlWorkSheet.Range("G:G", "G:G")
            formatRange2.NumberFormat = "@"

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

End Class