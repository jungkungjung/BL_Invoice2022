Imports System.Data
Imports System.Data.SqlClient
Imports System.Environment
Imports System.Net

Public Class Frmlogin
    Dim DATA As New DataSet
    Private Sub Frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\config_pln", "user", Nothing) IsNot Nothing Then
            txtusername.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\config_pln", "user", Nothing)
            txtpassword.Select()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If txtpassword.Text = "" Or txtusername.Text = "" Then
        '    MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        '    Try
        '        DATA.Clear()
        '        Dim sql As String = "SELECT USER_CODE,USER_PASSWORD,USER_REMARK,USER_LEVEL,USER_STATUS,"
        '        sql &= " USER_TH_NAME,USER_OWN,USER_BR_SLIT,USER_PROOVE,"
        '        sql &= " USER_SEND,USER_RECIEVE,USER_PROVED"
        '        sql &= " FROM JOB_USER"
        '        sql &= " WHERE USER_CODE='" & txtusername.Text & "' AND USER_PASSWORD = '" & txtpassword.Text & "'"
        '        Dim cmd43 As New SqlCommand(sql, conn_production)
        '        Dim adapter43 As New SqlDataAdapter(cmd43)
        '        adapter43.Fill(DATA, "DOC")

        '        BplusDataDataGridView.DataSource = DATA.Tables("DOC")
        '        If DATA.Tables("DOC").Rows.Count > 0 Then
        '            login_name = DATA.Tables("DOC").Rows(0).Item(0)
        '            login_level = DATA.Tables("DOC").Rows(0).Item(3)
        '            login_status = DATA.Tables("DOC").Rows(0).Item(4)
        '            login_th_name = DATA.Tables("DOC").Rows(0).Item(5).ToString
        '            login_own = DATA.Tables("DOC").Rows(0).Item(6)
        '            login_br = DATA.Tables("DOC").Rows(0).Item(7)
        '            login_proove = DATA.Tables("DOC").Rows(0).Item(8)
        '            'ป้องกันค่า null
        '            If IsDBNull(DATA.Tables("DOC").Rows(0).Item("USER_SEND")) Then
        '                login_send = False
        '            Else
        '                login_send = DATA.Tables("DOC").Rows(0).Item("USER_SEND")
        '            End If

        '            If IsDBNull(DATA.Tables("DOC").Rows(0).Item("USER_RECIEVE")) Then
        '                login_recieve = False
        '            Else
        '                login_recieve = DATA.Tables("DOC").Rows(0).Item("USER_RECIEVE")
        '            End If

        '            If IsDBNull(DATA.Tables("DOC").Rows(0).Item("USER_PROVED")) Then
        '                login_proved = False
        '            Else
        '                login_proved = DATA.Tables("DOC").Rows(0).Item("USER_PROVED")
        '            End If

        '            'สร้าง subkey config_pln ใน current_user\software
        '            If My.Computer.Registry.CurrentUser.OpenSubKey("config_pln") Is Nothing Then
        '                My.Computer.Registry.CurrentUser.CreateSubKey("Software\config_pln")
        '            End If

        '            If txtusername.Text.Trim <> My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\config_pln", "user", Nothing) Then
        '                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\config_pln", "user", txtusername.Text.Trim)
        '            End If

        '            'If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\config_pln", "path", Nothing) Is Nothing Then
        '            '    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\config_pln", "path", "\\192.168.1.10\sharing")
        '            'End If

        '            'If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\config_pln", "id", Nothing) Is Nothing Then
        '            '    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\config_pln", "id", "administrator")
        '            'End If

        '            'If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\config_pln", "pss", Nothing) Is Nothing Then
        '            '    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\config_pln", "pss", "it@sunserver0")
        '            'End If
        '            'If Main.server_id = 2 Then
        '            '    map_server() 'map drive show picture
        '            'End If
        '            Close()
        '        Else
        '            MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '            txtpassword.Text = ""
        '            txtusername.Text = ""
        '            txtusername.Focus()
        '        End If

        '    Catch ex As Exception
        '        MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Main.Close()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = ControlChars.Cr Then '   controlchars.cr คือ enter ใช้ = 13 แล้วจะ error
            If Me.txtpassword.Text = "" Then
                MsgBox("Please input password", MsgBoxStyle.Exclamation, "Warning")
                Me.txtpassword.Focus()
            Else
                Button1.PerformClick()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = ControlChars.Cr Then '   controlchars.cr คือ enter ใช้ = 13 แล้วจะ error
            If Me.txtusername.Text = "" Then
                MsgBox("Please input User name", MsgBoxStyle.Exclamation, "Warning")
                Me.txtusername.Focus()
            Else
                Me.txtpassword.Focus()
            End If
        End If
    End Sub

    Private Sub Frmlogin_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If login_level = 20 Or login_level = 21 Then ' บัญชีส่งเอกสารปิดงาน
        '    'ขอผลิต
        'ElseIf login_level = 99 Then 'administrator
        '    'ขอผลิต
        '    'System
        '    Main.USER_MenuItem.Visible = True
        'If login_name = "sa" Then
        '    Main.Export_menu.Visible = True
        'End If
        'blown_cast
        'End If
    End Sub
End Class