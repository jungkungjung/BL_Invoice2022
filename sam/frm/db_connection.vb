Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class db_connection
    Dim File_ini = Path.Combine(System.Windows.Forms.Application.StartupPath, "DB_Config.ini")
    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.DATA_CONFIGTableAdapter.Fill(Me.ConfigDataSet.DATA_CONFIG)
        Try
            read_from_ini()
            data_ty_switch() 'เช็คชนิด database
            Pn_not_show.Hide()
            Guna_exit.Select()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub read_from_ini()
        Try
            'แสดงค่า connection
            data_ty_str.Text = ReadIni(File_ini, "DATABASE", "DB_TYPE", "")
            data_ty_cmb.SelectedItem = ReadIni(File_ini, "DATABASE", "DB_TYPE", "")
            host_txt.Text = ReadIni(File_ini, "DATABASE", "HOST_NAME", "")
            database_txt.Text = ReadIni(File_ini, "DATABASE", "DB_NAME", "")
            User_txt.Text = ReadIni(File_ini, "DATABASE", "USER_ID", "")
            Password_txt.Text = ReadIni(File_ini, "DATABASE", "PASSWORD", "")
            'read_connection() 'อ่านค่า connection string
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub write_to_ini()
        'บันทึกค่า connection
        Try
            If File.Exists(File_ini) = False Then
                MsgBox("ไม่พบไฟล์ ini โปรแกรมจะสร้างขึ้นใหม่ ตามข้อมูลที่ระบุ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                File.Create(File_ini).Dispose()
            End If
            writeIni(File_ini, "DATABASE", "DB_TYPE", data_ty_str.Text)
            writeIni(File_ini, "DATABASE", "HOST_NAME", host_txt.Text)
            writeIni(File_ini, "DATABASE", "DB_NAME", database_txt.Text)
            writeIni(File_ini, "DATABASE", "USER_ID", User_txt.Text)
            writeIni(File_ini, "DATABASE", "PASSWORD", Password_txt.Text)
            'read_connection() 'อ่านค่า connect
            'บันทึก ini แล้วอ่านค่า connection string ใหม่
            Dim con_str1 As String = ""
            If ReadIni(File_ini, "DATABASE", "DB_TYPE", "").ToUpper = "MSSQL" Then 'MSSQL ปกติ
                con_str1 = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";Initial Catalog=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";User ID=" & ReadIni(File_ini, "DATABASE", "USER_ID", "") & "; password=" & ReadIni(File_ini, "DATABASE", "PASSWORD", "")
            ElseIf ReadIni(File_ini, "DATABASE", "DB_TYPE", "").ToUpper = "MSSQL DATABASE FILE" Then 'mssql แบบ database file (mssql express)
                con_str1 = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30;User Instance=True"
            ElseIf ReadIni(File_ini, "DATABASE", "DB_TYPE", "").ToUpper = "LOCALDB" Then 'แบบ localDb
                con_str1 = "server=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30"
            End If
            cnn_sql_main = New SqlConnection(con_str1)
            MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ผลลัพท์")
        Catch ex As Exception
            MessageBox.Show("Failed to connect ini file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub save1_Click(sender As System.Object, e As System.EventArgs) Handles Guna_save.Click
        write_to_ini() 'บันทึกค่า connection และเชื่อมต่อ
        Close()
    End Sub

    Private Sub exit1_Click(sender As System.Object, e As System.EventArgs) Handles Guna_exit.Click
        Close()
    End Sub

    Private Sub test_config_bt_Click(sender As System.Object, e As System.EventArgs) Handles test_config_bt.Click
        Dim con_str_test As String = ""
        If data_ty_cmb.SelectedItem = "MSSQL" Then
            con_str_test = "Data Source=" & host_txt.Text & ";Initial Catalog=" & database_txt.Text & ";User ID=" & User_txt.Text & "; password=" & Password_txt.Text
        ElseIf data_ty_cmb.SelectedItem = "MSSQL DATABASE FILE" Then
            con_str_test = "Data Source=" & host_txt.Text & ";AttachDbFilename=" & database_txt.Text & ";Integrated Security=True;Connect Timeout=30;User Instance=True"
        ElseIf data_ty_cmb.SelectedItem = "LocalDB" Then
            con_str_test = "server=" & host_txt.Text & ";AttachDbFilename=" & database_txt.Text & ";Integrated Security=True;;Connect Timeout=30"
        End If
        Dim cnn_sql_test As New SqlConnection(con_str_test)

        'ใช้วิธีตรวจสอบจาก textbox ไม่ใช่จาก ini เนื่องจาก user สามารถที่จะทดสอบการเชื่อมต่อ ก่อน ถ้าติดต่อได้ ค่อยบันทึกก็ได้
        If cnn_sql_test.State = ConnectionState.Closed Then
            Try
                cnn_sql_test.Open()
                cnn_sql_test.Close()
                MsgBox("สามารถติดต่อ Database ได้", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Result")
            Catch ex As Exception
                'MessageBox.Show(Err.Number)
                MsgBox("พบข้อผิดพลาดในการเชื่อมต่อ Database โปรดตรวจสอบ" & vbNewLine & Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Finally
            End Try
        End If
    End Sub

    Private Sub host_txt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles host_txt.KeyPress
        If e.KeyChar = ControlChars.Cr Then '   controlchars.cr คือ enter ใช้ = 13 แล้วจะ error
            Me.database_txt.Focus()
        End If
    End Sub

    Private Sub database_txt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles database_txt.KeyPress
        If e.KeyChar = ControlChars.Cr Then '   controlchars.cr คือ enter ใช้ = 13 แล้วจะ error
            Me.User_txt.Focus()
        End If
    End Sub

    Private Sub User_txt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles User_txt.KeyPress
        If e.KeyChar = ControlChars.Cr Then '   controlchars.cr คือ enter ใช้ = 13 แล้วจะ error
            Me.Password_txt.Focus()
        End If
    End Sub
    Private Sub data_ty_cmb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles data_ty_cmb.SelectionChangeCommitted
        Try
            data_ty_str.Text = data_ty_cmb.SelectedItem
            If data_ty_cmb.SelectedItem = "MSSQL" Then
                host_txt.Text = "Localhost"
            ElseIf data_ty_cmb.SelectedItem = "MSSQL DATABASE FILE" Then
                host_txt.Text = ".\SQLEXPRESS"
            ElseIf data_ty_cmb.SelectedItem = "LocalDB" Then
                host_txt.Text = "(localdb)\v11.0"
            End If
            data_ty_switch()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub data_ty_switch() 'เช็คชนิด database
        Try
            If data_ty_cmb.SelectedItem = "MSSQL" Then
                db_path.Enabled = False
            Else
                db_path.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub db_path_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles db_path.LinkClicked
        'Dim a As String
        'If database_txt.Text.Trim.Length = 0 Then
        '    a = ""
        'Else
        '    If Directory.Exists(System.IO.Path.GetDirectoryName(database_txt.Text)) Then
        '        a = System.IO.Path.GetDirectoryName(database_txt.Text)
        '    Else
        '        a = ""
        '    End If
        'End If
        Try
            With OpenFileDialog1
                .Title = "เลือกไฟล์"
                .Filter = "All Files (*.*)|*.*"
                .FileName = ""
                .FilterIndex = 2
                '.InitialDirectory = a 'System.IO.Path.GetDirectoryName(doc_path.Text) 'doc_path.Text
            End With
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                database_txt.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

End Class