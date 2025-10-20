Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Public Class company_record_new
    Dim t_tooltip As New ToolTip
    'Dim File_ini = Path.Combine(System.Windows.Forms.Application.StartupPath, "DB_Config.ini")
    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'COMPANYTableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน
        Try
            Me.COMPANYTableAdapter.Fill(Me.INVOICEDataSet.COMPANY)
            Pn_not_show.Hide()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub customer_record_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        'radio_choose()
        SHOWIMAGE()
    End Sub

    Private Sub FrmCustomer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub save1_Click(sender As System.Object, e As System.EventArgs) Handles Guna_save.Click
        If CMPN_NAMETextBox.Text.Trim.Length = 0 Then
            MsgBox("กรุณาใส่รหัสลูกค้า", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            CMPN_NAMETextBox.Select()
            Exit Sub
        End If
        If Double.Parse(CMPN_VAT_RTextBox.Text) > 30 Then
            MsgBox("ตรวจสอบอัตราภาษี", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            CMPN_VAT_RTextBox.Select()
            Exit Sub
        End If
        Try
            Me.Validate()
            Me.COMPANYBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            company_table() 'เพื่อ refresh ใน datatable กรณีเพิ่มข้อมูลใหม่
            insert_status.Text = "0"
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
            Close()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub exit1_Click(sender As System.Object, e As System.EventArgs) Handles Guna_exit.Click
        Close()
    End Sub

    Private Sub CMPN_VAT_RTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CMPN_VAT_RTextBox.KeyPress
        e.Handled = currency_input(sender, e.KeyChar)
    End Sub
    Private Sub open_image()
        'เลือกด้วย path เพื่อส่ง logo ไปออก rpt
        Try
            Dim a As String
            If CMPN_IMAGE_PATHTextBox.Text.Trim.Length = 0 Then
                a = ""
            Else
                If Directory.Exists(System.IO.Path.GetDirectoryName(CMPN_IMAGE_PATHTextBox.Text)) Then
                    a = System.IO.Path.GetDirectoryName(CMPN_IMAGE_PATHTextBox.Text)
                Else
                    a = ""
                End If
            End If
            With OpenFileDialog1
                .Title = "เลือกไฟล์"
                '.Filter = "All Files (*.*)|*.*"
                .Filter = "All Files (*.*)|*.*|Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
                .FileName = ""
                .FilterIndex = 2 'default file type
                .InitialDirectory = a 'System.IO.Path.GetDirectoryName(doc_path.Text) 'doc_path.Text
            End With
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                File.Copy(OpenFileDialog1.FileName, Path.Combine(Application.StartupPath, "BL_LOGO" & Path.GetExtension(OpenFileDialog1.FileName)), True)
                CMPN_IMAGE_PATHTextBox.Text = Path.Combine(Application.StartupPath, "BL_LOGO" & Path.GetExtension(OpenFileDialog1.FileName))
                SHOWIMAGE()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub SHOWIMAGE()
        Try
            If File.Exists(CMPN_IMAGE_PATHTextBox.Text.Trim) Then
                Using fs As New System.IO.FileStream(CMPN_IMAGE_PATHTextBox.Text, IO.FileMode.Open, IO.FileAccess.Read) 'ใช้วิธีนี้ หรือใช้ imagelocation แทน ป้องกันเวลาลบภาพ จะ error ล็อคไฟล์
                    cmpn_image.Image = System.Drawing.Image.FromStream(fs)
                End Using
            Else
                cmpn_image.ImageLocation = Nothing
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub CLEAR_IMAGE()
        CMPN_IMAGE_PATHTextBox.Clear()
        cmpn_image.Image = Nothing
    End Sub

    Private Sub cmpn_image_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmpn_image.MouseDown
        If e.Button = MouseButtons.Left Then
            open_image()
        End If
    End Sub
    Private Sub addr_add_Click(sender As System.Object, e As System.EventArgs) Handles addr_add.Click
        open_image()
    End Sub

    Private Sub addr_edit_Click(sender As System.Object, e As System.EventArgs) Handles addr_edit.Click
        CLEAR_IMAGE()
    End Sub

    Private Sub cmpn_image_MouseHover(sender As System.Object, e As System.EventArgs) Handles cmpn_image.MouseHover
        'If e.KeyCode = Keys.Escape Then
        '    list_search.Clear()
        '    DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
        '    ENTER_KEY()
        '    t_tooltip.RemoveAll()
        'ElseIf e.KeyCode = Keys.Enter Then
        '    ENTER_KEY()
        '    t_tooltip.RemoveAll()
        'Else
        t_tooltip.Show("ขนาดภาพ 256x256", cmpn_image)
        'End If
    End Sub
End Class