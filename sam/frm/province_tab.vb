Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Linq
Imports System.Xml.Linq

Public Class province_tab
    Dim data As New DataSet
    Dim dtv As New DataView
    Dim t_tooltip As New ToolTip
    Dim user_type As Integer

    Private Sub usc_so_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            EnableDoubleBuffered(grw) 'วิธีโหลด datagrid ให้เร็วขึ้น
            new_call()
            Pn_not_show.Hide()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub usc_so_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        grw.ClearSelection()
    End Sub
    Private Sub customer_profile_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
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
            sql6 &= " *"
            sql6 &= " FROM PROVINCE"
            sql6 &= " WHERE PROVINCE_ID<>1" 'ไม่เอา ชื่อลูกค้า ไม่ระบุ
            sql6 &= " ORDER BY PROVINCE_NAME"
            Dim cmd_print As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_print As New SqlDataAdapter(cmd_print)
            adapter_print.Fill(data, "DOC")
            dtv = data.Tables("DOC").AsDataView 'EQToDataTable(ljoin).AsDataView
            grw.DataSource = dtv
            grw.Columns(0).Visible = False
            grw.Columns(0).Width = 40
            grw.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            grw.Columns(0).HeaderText = "รหัส"
            grw.Columns(1).HeaderText = "ชื่อจังหวัด"
            'ENTER_KEY()
            list_Guna_search.Select()
            grw.ClearSelection()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub ENTER_KEY()
        Try
            If dtv IsNot Nothing Then
                dtv.RowFilter = "[PROVINCE_NAME] Like " & "'%" & list_Guna_search.Text & "%'"
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
            'Dim FRM As New province_record
            'FRM.insert_status.Text = 0
            'FRM.PROVINCETableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน
            'FRM.PROVINCETableAdapter.FillBy(FRM.INVOICEDataSet.PROVINCE, grw.Rows.Item(e.RowIndex).Cells("PROVINCE_ID").Value)
            'If FRM.ShowDialog(Me) = DialogResult.OK Then
            '    new_call()
            'End If
            DialogResult = Windows.Forms.DialogResult.OK
            Close()
        End If
    End Sub
    Private Sub list_Guna_search_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_Guna_search.KeyDown
        If e.KeyCode = Keys.Enter Then 'ถ้ากด enter ให้เลือกรายการปัจจุบัน
            If list_Guna_search.Text.Length = 0 Then
                Exit Sub 'ถ้าไม่ได้กรองเลย ไม่ต้อง return ค่า
            End If
            If grw.Rows.Count > 0 Then
                DialogResult = Windows.Forms.DialogResult.OK
                Close()
            End If
        End If
    End Sub

    Private Sub cmpn_ty_cmb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'new_call()
            ENTER_KEY()
            list_Guna_search.Select()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub exit_guna_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_guna_bt.Click
        Close()
    End Sub

    Private Sub add_guna_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_guna_bt.Click
        Try
            Dim FRM As New province_record
            FRM.PROVINCETableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน   
            FRM.create_job()
            If FRM.ShowDialog(Me) = DialogResult.OK Then
                new_call()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub customer_tab_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'rpt4.Dispose() 'เพื่อปิด rpt ใน temp windows
    End Sub

    Private Sub add_province_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_province.Click
        Try
            Dim FRM As New province_record
            FRM.PROVINCETableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน   
            FRM.create_job()
            If FRM.ShowDialog(Me) = DialogResult.OK Then
                new_call()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub edit_province_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_province.Click
        Try
            If grw.SelectedCells.Count > 0 Then 'เช็คว่ามีการเลือก แถวหรือไม่
                Dim FRM As New province_record
                FRM.insert_status.Text = 0
                FRM.PROVINCETableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน
                FRM.PROVINCETableAdapter.FillBy(FRM.INVOICEDataSet.PROVINCE, grw.CurrentRow.Cells("PROVINCE_ID").Value)
                If FRM.ShowDialog(Me) = DialogResult.OK Then
                    new_call()
                End If
            Else
                MsgBox("โปรดเลือกรายการ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
End Class