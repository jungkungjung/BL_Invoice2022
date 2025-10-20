Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Linq
Imports System.Xml.Linq
Imports System.Configuration

Public Class struture_update_tab
    Dim data As New DataSet
    Dim dtv As New DataView
    Private Sub customer_profile_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub new_call()
        Try
            data.Clear()
            Dim sql6 As String = "SELECT *"
            sql6 &= " FROM TRANMAIN"
            Dim cmd_print As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_print As New SqlDataAdapter(cmd_print)
            adapter_print.Fill(data, "DOC")

            Dim sql_trd As String = "SELECT *"
            sql_trd &= " FROM TRANDETAIL"
            Dim cmd_trd As New SqlCommand(sql_trd, cnn_sql_main)
            Dim adapter_trd As New SqlDataAdapter(cmd_trd)
            adapter_trd.Fill(data, "DOC_TRD")
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Public Sub form_refresh()
        new_call()
    End Sub

    Private Sub disc_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disc_bt.Click
        Try
            new_call()
            If cnn_sql_main.State = ConnectionState.Closed Then
                cnn_sql_main.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try

        Dim transaction As SqlTransaction = cnn_sql_main.BeginTransaction 'กำหนด transaction เนื่องจากใช้คำสั่งแบบ multi query
        Try
            If Not data.Tables("DOC").Columns.Contains("TRH_DISC_STR") Then 'tranmain
                Dim sql_alter As String = "ALTER TABLE TRANMAIN ADD TRH_DISC_STR VARCHAR(20) NULL" 'เพิ่ม column ส่วนลดท้ายบิล
                Dim cmd_alter As New SqlCommand(sql_alter, cnn_sql_main)
                cmd_alter.Transaction = transaction 'ใส่ตรงนี้ เนื่องจาก ต้องประกาศ command แบบอยู่บนก่อน เช่น Dim SQLCmd As New SqlCommand("", conn)
                cmd_alter.ExecuteNonQuery()
                Dim sql_update As String = "UPDATE TRANMAIN" 'update ส่วนลด จากฟิวด์เดิม
                'sql_update &= " SET TRH_DISC_STR=CAST(FORMAT(TRH_DISC,'###0.##') AS VARCHAR) +'%'" 'SQLSERVER 2008 ใช้ function format ไม่ได้
                sql_update &= " SET TRH_DISC_STR=CAST(TRH_DISC AS VARCHAR) +'%'"
                sql_update &= " WHERE TRH_DISC_STR IS NULL AND TRH_DISC <>0"
                Dim cmd_update As New SqlCommand(sql_update, cnn_sql_main)
                cmd_update.Transaction = transaction
                cmd_update.ExecuteNonQuery()
            End If
            If Not data.Tables("DOC_TRD").Columns.Contains("TRD_DISC_STR") Then 'trandetail
                Dim sql_disc_trd As String = "ALTER TABLE TRANDETAIL ADD TRD_DISC_STR VARCHAR(20) NULL" 'เพิ่ม column ส่วนลดรายการ
                Dim cmd_alter_trd As New SqlCommand(sql_disc_trd, cnn_sql_main)
                cmd_alter_trd.Transaction = transaction
                cmd_alter_trd.ExecuteNonQuery()
                Dim sql_trd_update As String = "UPDATE TRANDETAIL" 'update ส่วนลดรายการ จากฟิวด์เดิม
                'sql_trd_update &= " SET TRD_DISC_STR=CAST(FORMAT(TRD_DISC,'###0.##') AS VARCHAR) +'%'" 'SQLSERVER 2008 ใช้ function format ไม่ได้
                sql_trd_update &= " SET TRD_DISC_STR=CAST(TRD_DISC AS VARCHAR) +'%'"
                sql_trd_update &= " WHERE TRD_DISC_STR IS NULL AND TRD_DISC <>0"
                Dim cmd_trd_update As New SqlCommand(sql_trd_update, cnn_sql_main)
                cmd_trd_update.Transaction = transaction
                cmd_trd_update.ExecuteNonQuery()
            End If

            transaction.Commit() 'commit
            MsgBox("ปรับปรุงข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
        cnn_sql_main.Close()
    End Sub

    Private Sub trdremark_bt_Click(sender As System.Object, e As System.EventArgs) Handles trdremark_bt.Click
        Try
            Dim DATA_REMARK As New DataSet
            Dim DT_REMARK As New DataTable
            Dim sql_trd As String = "SELECT"
            sql_trd &= " COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH AS MAX_LENGTH"
            sql_trd &= " FROM INFORMATION_SCHEMA.COLUMNS"
            sql_trd &= " WHERE TABLE_NAME = 'TRANDETAIL'"
            sql_trd &= " AND COLUMN_NAME = 'TRD_REMARK' AND CHARACTER_MAXIMUM_LENGTH<>-1" 'เช็คว่า ฟิวด์เดิมเป็น varchar(max) รึไม่ ก่อน modify
            Dim cmd_trd As New SqlCommand(sql_trd, cnn_sql_main)
            Dim adapter_trd As New SqlDataAdapter(cmd_trd)
            adapter_trd.Fill(DATA_REMARK, "DOC_REMARK")

            If cnn_sql_main.State = ConnectionState.Closed Then
                cnn_sql_main.Open()
            End If
            Dim transaction As SqlTransaction = cnn_sql_main.BeginTransaction 'กำหนด transaction

            If DATA_REMARK.Tables("DOC_REMARK").Rows.Count > 0 Then
                Try
                    'MsgBox("it not Memo")
                    Dim sql_remark As String = "ALTER TABLE TRANDETAIL ALTER COLUMN TRD_REMARK VARCHAR(MAX) NULL" 'modify trd_remark เดิมจาก varchar() เป็น varchar(max)
                    Dim cmd_alter_remark As New SqlCommand(sql_remark, cnn_sql_main)
                    cmd_alter_remark.Transaction = transaction
                    cmd_alter_remark.ExecuteNonQuery()
                    transaction.Commit() 'commit
                    MsgBox("ปรับปรุงข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
                Catch ex As Exception
                    transaction.Rollback()
                    MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
                End Try
                cnn_sql_main.Close()
            End If

        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
End Class