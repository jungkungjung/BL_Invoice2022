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
Public Class dragdrop_datagrid
    Dim data As New DataSet
    Dim dtv As New DataView
    Dim t_tooltip As New ToolTip
    Dim dtsource As New DataTable
    Dim drag_type As Integer
    Dim mousedownpos As Point

    Private fromIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle
    Dim b As New BindingSource
    Dim SourceRowIndex As Integer = -1
    Dim File_ini = Path.Combine(System.Windows.Forms.Application.StartupPath, "DB_Config.ini")
    Private Sub read_connection()
        Dim con_str1 As String = ""
        If ReadIni(File_ini, "DATABASE", "DB_TYPE", "").ToUpper = "MSSQL" Then 'MSSQL ปกติ
            cnn_str = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";Initial Catalog=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";User ID=" & ReadIni(File_ini, "DATABASE", "USER_ID", "") & "; password=" & ReadIni(File_ini, "DATABASE", "PASSWORD", "")
            con_str1 = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";Initial Catalog=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";User ID=" & ReadIni(File_ini, "DATABASE", "USER_ID", "") & "; password=" & ReadIni(File_ini, "DATABASE", "PASSWORD", "")
        ElseIf ReadIni(File_ini, "DATABASE", "DB_TYPE", "").ToUpper = "MSSQL DATABASE FILE" Then 'mssql แบบ database file (mssql express)
            cnn_str = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30;User Instance=True"
            con_str1 = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30;User Instance=True"
        ElseIf ReadIni(File_ini, "DATABASE", "DB_TYPE", "").ToUpper = "LOCALDB" Then 'แบบ localDb
            cnn_str = "server=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30"
            con_str1 = "server=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30"
        End If
        cnn_sql_main = New SqlConnection(con_str1) 'สร้าง sqlconnection ใช้ทั้งโปรแกรม
    End Sub
    Private Sub discout_function_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtsource.Columns.Add("CUS_ID", GetType(Integer))
        dtsource.Columns.Add("CUS_CODE", GetType(String))
        dtsource.Columns.Add("CUS_NAME", GetType(String))
        grw_target.DataSource = dtsource
        grw_target.Columns(0).Visible = False
        grw_target.Columns(0).HeaderText = "id"
        grw_target.Columns(1).HeaderText = "รหัส"
        grw_target.Columns(2).HeaderText = "ชื่อ"
        grw_target.Columns(0).Width = 50
        grw_target.Columns(1).Width = 80
        grw_target.Columns(2).Width = 260
        read_connection()
        new_call()
        Pn_not_show.Hide()
    End Sub

    Private Sub cal()
        'Dim cnt_1 As Integer = 0
        'For Each row3 As DataGridViewRow In grw_source.Rows
        '    cnt_1 += 1
        'Next
        'TDAY.Text = cnt_1.ToString("n0") + " รายการ"
    End Sub
    Private Sub new_call()
        Data.Clear()
        Dim sql6 As String = "SELECT"
        sql6 &= " CUS_ID,CUS_CODE,CUS_NAME"
        sql6 &= " FROM CUSTOMER"
        sql6 &= " ORDER BY CUS_CODE"
        Dim cmd_print As New SqlCommand(sql6, cnn_sql_main)
        Dim adapter_print As New SqlDataAdapter(cmd_print)
        adapter_print.Fill(data, "DOC")

        dtv = data.Tables("DOC").AsDataView 'EQToDataTable(ljoin).AsDataView
        grw_source.DataSource = dtv

        grw_source.Columns(0).Visible = False
        grw_source.Columns(0).Width = 50
        grw_source.Columns(1).Width = 74
        grw_source.Columns(2).Width = 260
        grw_source.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grw_source.Columns(0).HeaderText = "id"
        grw_source.Columns(1).HeaderText = "รหัส"
        grw_source.Columns(2).HeaderText = "ชื่อลูกค้า"
        ENTER_KEY()
        list_Guna_search.Select()
        grw_source.ClearSelection()
    End Sub
    Private Sub ENTER_KEY()
        Try
            If dtv IsNot Nothing Then
                dtv.RowFilter = "[CUS_CODE] Like " & "'%" & list_Guna_search.Text & "%' OR [CUS_NAME] Like " & "'%" & list_Guna_search.Text & "%'"
                'cal()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        new_call()
    End Sub

    Private Sub grw_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles grw_source.MouseDown
        'RemoveHandler grw_source.MouseDown, AddressOf grw_MouseDown
        'AddHandler grw_source.CellDoubleClick, AddressOf grw_source_CellDoubleClick
        'AddHandler grw_source.CellContentDoubleClick, AddressOf grw_source_CellContentDoubleClick
        'AddHandler grw_source.MouseDown, AddressOf grw_MouseDown

        ' ''แบบใช้จริง แก้ปัญหา ลากเลย โดยที่ยังไม่ได้รับค่า selectedrows ใช้ค่า drag_type มาเช็คก่อน ว่า ลากเลย โดย ยังไม่ได้เป็น Selectedrow รึเปล่า
        'If e.Button = Windows.Forms.MouseButtons.Left Then
        '    If grw_source.HitTest(e.X, e.Y).Type = DataGridViewHitTestType.Cell Then
        '        If grw_source.Rows(grw_source.HitTest(e.X, e.Y).RowIndex).Selected = False Then
        '            drag_type = 1 'ยังไม่ได้ Selectedrow ให้ใช้วิธี drag แบบแถวปัจจุบัน
        '            Me.grw_source.DoDragDrop(grw_source.Rows(grw_source.HitTest(e.X, e.Y).RowIndex), DragDropEffects.All)

        '        Else
        '            drag_type = 2 'ถ้า Selectedrow ให้ใช้วิธี drag เป็นแบบ array
        '            Me.grw_source.DoDragDrop(grw_source.SelectedRows.Cast(Of DataGridViewRow).OrderBy(Function(r) r.Index).ToArray, DragDropEffects.All)

        '        End If
        '    End If
        'End If
    End Sub

    Private Sub grw_target_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles grw_target.DragEnter
        'e.Effect = DragDropEffects.All
    End Sub
    Private Sub grw_target_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles grw_target.DragDrop
        'แบบที่ใช้อยู่
        'If drag_type = 1 Then
        '    Dim r As DataGridViewRow = CType(e.Data.GetData(GetType(DataGridViewRow)), DataGridViewRow)
        '    Dim chkdup = r.Cells(1).Value
        '    'เช็คข้อมูลซ้ำ
        '    Dim duplicates = (From v In dtsource
        '                     Where v.Field(Of String)("CUS_CODE") = chkdup)
        '    If duplicates.Count = 0 Then
        '        dtsource.Rows.Add(r.Cells(0).Value, r.Cells(1).Value, r.Cells(2).Value)
        '    Else
        '        MsgBox("เลือกข้อมูลซ้ำ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
        '    End If
        'ElseIf drag_type = 2 Then
        '    Dim rows() As DataGridViewRow = DirectCast(e.Data.GetData(GetType(DataGridViewRow())), DataGridViewRow())
        '    For Each ra In rows
        '        Dim chkdup = ra.Cells(1).Value.ToString
        '        'เช็คข้อมูลซ้ำ
        '        Dim duplicates = (From v In dtsource
        '                    Where v.Field(Of String)("CUS_CODE") = chkdup)
        '        If duplicates.Count = 0 Then
        '            dtsource.Rows.Add(ra.Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        '        Else
        '            If rows.Count = 1 Then 'ถ้าเลือกแบบ multi แล้วมีรายการซ้ำ ไม่ต้องฟ้อง
        '                MsgBox("เลือกข้อมูลซ้ำ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
        '            End If
        '        End If
        '        'dtsource.Rows.Add(ra.Cells(0).Value, ra.Cells(1).Value, ra.Cells(2).Value) 'แบบนี้ก็ได้
        '        'dtsource.Rows.Add(ra.Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        '    Next
        '    grw_target.ClearSelection()
        'End If
    End Sub

    Private Sub grw_source_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grw_source.CellDoubleClick
        Dim chk As Boolean = False
        If e.RowIndex > -1 Then
            For Each docrow In dtsource.Rows
                If grw_source.Rows(e.RowIndex).Cells("CUS_CODE").Value = docrow.Item("CUS_CODE").ToString Then
                    chk = True
                End If
            Next
            If chk = False Then
                dtsource.Rows.Add(grw_source.Rows(e.RowIndex).Cells("CUS_ID").Value, grw_source.Rows(e.RowIndex).Cells("CUS_CODE").Value, grw_source.Rows(e.RowIndex).Cells("CUS_NAME").Value)
            Else
                MsgBox("เลือกข้อมูลซ้ำ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                'AddHandler grw_source.MouseDown, AddressOf grw_MouseDown
            End If
            grw_target.ClearSelection()
        End If
    End Sub
    Private Sub grw_target_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grw_target.CellDoubleClick
        If e.RowIndex > -1 Then
            grw_target.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub list_Guna_search_TextChanged(sender As System.Object, e As System.EventArgs) Handles list_Guna_search.TextChanged
        ENTER_KEY()
    End Sub

    Private Sub select_lnk_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles select_lnk.LinkClicked
        'For Each irows As DataGridViewRow In grw_source.SelectedRows.Cast(Of DataGridViewRow)().OrderBy(Function(dgvr) dgvr.Index) 
        'วิธีด้านบน เนื่องจาก index ไม่เรียงค่าที่เลือก จากน้อยไปมาก ข้อเสียคือ ต้องใช้วิธี selectedrows เท่านั้น click cell ไม่ได้
        For Each irows As DataGridViewRow In grw_source.Rows 'ใช้วิธีนี้ เพื่อสามารถคลิกเลือก ที่ cell ได้
            If irows.Cells("CUS_CODE").Selected = True OrElse irows.Cells("CUS_NAME").Selected = True Then
                Dim chkdup = irows.Cells("CUS_CODE").Value.ToString
                Dim duplicates = (From r In dtsource.AsEnumerable()
                                 Where r("CUS_CODE") = chkdup)
                If duplicates.Count = 0 Then
                    dtsource.Rows.Add(irows.Cells("CUS_ID").Value, irows.Cells("CUS_CODE").Value, irows.Cells("CUS_NAME").Value)
                End If
            End If
        Next
        grw_target.ClearSelection()
    End Sub

    Private Sub clear_lnk_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles clear_lnk.LinkClicked
        dtsource.Clear()
    End Sub

    Private Sub return_lnk_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles return_lnk.LinkClicked
        list_Guna_search.Text = ""
        If dtv IsNot Nothing Then 'ป้องกัน error
            dtv.RowFilter = Nothing
            dtv.Sort = String.Empty
        End If
    End Sub

    Private Sub filename_chk1_Click(sender As System.Object, e As System.EventArgs) Handles filename_chk1.Click
        If filename_chk1.Checked = True Then 'ประเภท rpt default เป็น 0 (ฟอร์มภาษาไทย)
            filename_chk2.Checked = False
        Else
            filename_chk1.Checked = True
        End If
    End Sub

    Private Sub filename_chk2_Click(sender As System.Object, e As System.EventArgs) Handles filename_chk2.Click
        If filename_chk2.Checked = True Then 'ประเภท rpt 1 (ฟอร์มภาษาอังกฤษ)
            filename_chk1.Checked = False
        Else
            filename_chk2.Checked = True
        End If
    End Sub
End Class