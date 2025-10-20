Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Public Class salesman_record_new
    Public frm1 As salesman_tab 'ใช้วิธีนี้ เพื่อคืนค่า refresh from (ผ่านค่าแบบ Form Type)
    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SALESMANTableAdapter.Fill(Me.INVOICEDataSet.SALESMAN) 'ไม่ต้อง fill เนื่องจากเปิดโดย Fillby
        Pn_not_show.Hide()
    End Sub
    Private Sub customer_record_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        'radio_choose()
        SHOWIMAGE()
    End Sub

    Private Sub radio_choose()
    End Sub
    Private Sub FrmCustomer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub create_job()
        Try
            If insert_status.Text = "1" Then
                MsgBox("ยังไม่บันทึกข้อมูล", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                Exit Sub
            End If
            SALESMANBindingSource.AddNew()
            SLMN_CATTextBox.Text = 0
            SLMN_COMMISSIONTextBox.Text = 0
            SLMN_SL_TARGETTextBox.Text = 0
            SLMN_SL_TARGET_QUARTERTextBox.Text = 0
            SLMN_SL_TARGET_YEARTextBox.Text = 0
            SLMN_STATUSCheckBox.Checked = False
            CLEAR_IMAGE()
            insert_status.Text = "1"
            code_auto()
            navigator_guna_add(Guna_add, Guna_save, Guna_delete, Guna_print)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub add1_Click(sender As System.Object, e As System.EventArgs) Handles Guna_add.Click
        create_job()
    End Sub
    Private Sub save1_Click(sender As System.Object, e As System.EventArgs) Handles Guna_save.Click
        If SLMN_CODETextBox.Text.Trim.Length = 0 Then
            MsgBox("กรุณาใส่รหัสพนักงานขาย", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            SLMN_CODETextBox.Select()
            Exit Sub
        ElseIf SLMN_NAMETextBox.Text.Trim.Length = 0 Then
            MsgBox("กรุณาใส่ชื่อพนักงานขาย", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            SLMN_NAMETextBox.Select()
            Exit Sub
        End If
        Try
            If insert_status.Text = "1" Then
                SLMN_CREATEDateTimePicker.Value = Now
                Me.Validate()
                Me.SALESMANBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            Else
                Me.Validate()
                Me.SALESMANBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            End If
            '    '    '///// ใช้วิธีใหม่ refresh form
            If Not frm1.IsDisposed Then 'เช็ค กรณีปิดหน้าจอ ฟอร์มหลัก จะไม่สามารถ คืนค่า ให้ตรวจสอบว่า ฟอร์มหลักเปิดอยู่รึไม่
                frm1.form_refresh()
                frm1.FIND_GRW_ROWS(Integer.Parse(SLMN_IDTextBox.Text)) 'หาตำแหน่ง cursor ของ grw 
            End If

            insert_status.Text = "0"
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
            'Close()
            navigator_gana_save(Guna_add, Guna_save, Guna_delete, Guna_print)
        Catch ex As Exception
            'If Err.Number = 5 Then
            '    MsgBox("พบรหัสซ้ำ โปรดตรวจสอบ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            'Else
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
            'End If
        End Try
    End Sub
    Private Sub delete1_Click(sender As System.Object, e As System.EventArgs) Handles Guna_delete.Click
        If insert_status.Text = "1" Then
            MsgBox("ยังไม่บันทึกข้อมูล", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Exit Sub
        End If
        Try
            'ตรวจสอบ มีประวัติลูกค้าอ้างอิง
            Dim cus_exists = (From cus In customer_table()
                           Where cus("CUS_SLMN") = Integer.Parse(SLMN_IDTextBox.Text)
                               )
            If cus_exists.Count > 0 Then
                Dim str As String = ""
                For Each row3 As DataRow In cus_exists
                    str += row3.Item("CUS_CODE") + " " + row3.Item("CUS_NAME") + vbNewLine
                Next
                MsgBox("พบรายการอ้างอิง " + cus_exists.Count.ToString("#,###") + " รายการ ไม่สามารถลบได้" + vbNewLine + str, MsgBoxStyle.Information, "คำเตือน")
                Exit Sub
            End If
            'ตรวจสอบ มีเอกสารอ้างอิง
            Dim trn_exists = (From pro In tranmain_table()
                            Where pro("TRH_SLMN") = Integer.Parse(SLMN_IDTextBox.Text)
                                )
            If trn_exists.Count > 0 Then
                Dim str As String = ""
                For Each row3 As DataRow In trn_exists
                    str += row3.Item("TRH_DATE") + " " + row3.Item("TRH_NO") + vbNewLine
                Next
                MsgBox("พบรายการอ้างอิง " + trn_exists.Count.ToString("#,###") + " รายการ ไม่สามารถลบได้" + vbNewLine + str, MsgBoxStyle.Information, "คำเตือน")
                Exit Sub
            End If

            Dim msgtext As String
            msgtext = MsgBox("ยืนยันการลบข้อมูล", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "คำเตือน")
            If msgtext = vbYes Then
                Me.SALESMANBindingSource.RemoveCurrent()
                Me.Validate()
                Me.SALESMANBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
                insert_status.Text = 0
                '    '///// ใช้วิธีใหม่ refresh form
                If Not frm1.IsDisposed Then 'เช็ค กรณีปิดหน้าจอ ฟอร์มหลัก จะไม่สามารถ คืนค่า ให้ตรวจสอบว่า ฟอร์มหลักเปิดอยู่รึไม่
                    frm1.form_refresh()
                End If
                Close()
                'MsgBox("ลบข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
            Else : Return
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub code_auto()
        Try
            Dim header_first As String = ""
            Dim header_width As Integer
            Dim number_width As Integer
            Dim strIDAcc As String = ""

            Dim doctype_a As New DataSet 'รูปแบบเลขที่เอกสารจาก Doctype
            doctype_a.Clear()
            Dim sql_config As String = "SELECT CR_ID,CR_CODE,CR_STATUS,CASE WHEN CR_PREFIX IS NULL THEN '' ELSE CR_PREFIX END AS CR_PREFIX,"
            sql_config &= " (CASE WHEN CR_PREFIX IS NULL THEN '' ELSE CR_PREFIX END + CASE WHEN CR_SEPARATE IS NULL THEN '' ELSE CR_SEPARATE END) AS PREFIX_NAME,CR_RUNNING"
            sql_config &= " FROM CODE_RUNNING"
            sql_config &= " WHERE"
            sql_config &= " CR_CODE='201'" 'พนักงานขาย
            sql_config &= " AND CR_STATUS=1" 'ตั้งค่ารหัสอัตโนมัติ
            Dim cmd_config As New SqlCommand(sql_config, cnn_sql_main)
            Dim adapter_config As New SqlDataAdapter(cmd_config)
            adapter_config.Fill(doctype_a, "CODE_RUNNING")

            If doctype_a.Tables("CODE_RUNNING").Rows.Count > 0 Then
                If Len(doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME")) = 0 Then
                    SLMN_CODETextBox.Select()
                    Exit Sub 'ถ้าไม่กำหนด prefix ให้ออกจาก sub
                End If
                header_first = doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME")
                header_width = Len(doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME"))
                number_width = doctype_a.Tables("CODE_RUNNING").Rows(0).Item("CR_RUNNING")
            Else
                'MsgBox("ไม่พบการตั้งรหัสอัตโนมัติ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                SLMN_CODETextBox.Select()
                Exit Sub
            End If

            Dim data_cus As New DataSet
            Dim sql_cus As String = "SELECT TOP 1"
            sql_cus &= " SLMN_CODE,SUBSTRING(SLMN_CODE," & header_width + 1 & ",10) AS NUM_START"
            sql_cus &= " FROM SALESMAN"
            sql_cus &= " WHERE"
            sql_cus &= " LEFT(SLMN_CODE," & header_width & ")='" & header_first & "'"
            sql_cus &= " AND ISNUMERIC(SUBSTRING(SLMN_CODE," & header_width + 1 & ",10))=1"
            sql_cus &= " AND LEN(SUBSTRING(SLMN_CODE," & header_width + 1 & ",10))=" & number_width
            sql_cus &= " ORDER BY SLMN_CODE DESC"
            Dim cmd_cus As New SqlCommand(sql_cus, cnn_sql_main)
            Dim adapter_cus As New SqlDataAdapter(cmd_cus)
            adapter_cus.Fill(data_cus, "DOC_SALESMAN")

            If data_cus.Tables("DOC_SALESMAN").Rows.Count > 0 Then
                strIDAcc = header_first & (Integer.Parse(data_cus.Tables("DOC_SALESMAN").Rows(0).Item("NUM_START")) + 1).ToString(StrDup(number_width, "0"))
                SLMN_CODETextBox.Text = strIDAcc
                SLMN_NAMETextBox.Select()
            Else
                strIDAcc = header_first & 1.ToString(StrDup(number_width, "0")) 'ถ้าไม่พบรหัสก่อนนี้ ให้ run ใหม่
                SLMN_CODETextBox.Text = strIDAcc
                SLMN_NAMETextBox.Select()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub exit1_Click(sender As System.Object, e As System.EventArgs) Handles Guna_exit.Click
        Close()
    End Sub

    Private Sub print1_Click(sender As System.Object, e As System.EventArgs) Handles Guna_print.Click
        'MsgBox("ยังไม่ออกแบบ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
    End Sub
    Private Sub SHOWIMAGE()
        Try
            If File.Exists(SLMN_PATHTextBox.Text.Trim) Then
                'create_picture.Image = Image.FromFile(SLMN_PATHTextBox.Text)
                'create_picture.ImageLocation = SLMN_PATHTextBox.Text.Trim
                'create_picture.Load(SLMN_PATHTextBox.Text)
                Using fs As New System.IO.FileStream(SLMN_PATHTextBox.Text, IO.FileMode.Open, IO.FileAccess.Read) 'ใช้วิธีนี้ หรือใช้ imagelocation แทน ป้องกันเวลาลบภาพ จะ error ล็อคไฟล์
                    create_picture.Image = System.Drawing.Image.FromStream(fs)
                End Using
            Else
                create_picture.ImageLocation = Nothing
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub CLEAR_IMAGE()
        Try
            'slmn_image.Image = Nothing
            If File.Exists(SLMN_PATHTextBox.Text) Then
                File.Delete(SLMN_PATHTextBox.Text)
            End If
            SLMN_PATHTextBox.Clear()
            create_picture.Image = Nothing
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub open_image_old()
        'With OpenFileDialog1
        '    .Title = "เลือกไฟล์"
        '    '.Filter = "All Files (*.*)|*.*"
        '    .Filter = "All Files (*.*)|*.*|Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        '    .FileName = ""
        '    .FilterIndex = 2 'default file type
        '    '.InitialDirectory = a 'System.IO.Path.GetDirectoryName(doc_path.Text) 'doc_path.Text
        'End With
        'If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    'SLMN_IMAGEPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        '    slmn_image.Image = Image.FromFile(OpenFileDialog1.FileName)
        'End If
    End Sub

    Private Sub open_image()
        Try
            Dim a As String
            If SLMN_PATHTextBox.Text.Trim.Length = 0 Then
                a = ""
            Else
                If Directory.Exists(System.IO.Path.GetDirectoryName(SLMN_PATHTextBox.Text)) Then
                    a = System.IO.Path.GetDirectoryName(SLMN_PATHTextBox.Text)
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
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'การตั้งชื่อไฟล์
                Dim slmn_refcheck As String = "" 'replace ชื่อไฟล์เอกสารก่อน กัน error
                If SLMN_CODETextBox.Text.Contains("/") OrElse SLMN_CODETextBox.Text.Contains("\") Then 'ตรวจสอบชื่อเอกสาร ที่มีเครื่องหมาย "/" หรือ "\" จะใช้สร้างชื่อไฟล์ไม่ได้ ให้ใช้ "-" แทน
                    slmn_refcheck = Replace(Replace(SLMN_CODETextBox.Text, "/", "-"), "\", "-")
                Else
                    slmn_refcheck = SLMN_CODETextBox.Text
                End If
                'File.Copy(OpenFileDialog1.FileName, Path.Combine(Application.StartupPath & "\Image\Salesman", Path.GetFileName(OpenFileDialog1.FileName)), False) 'ถ้ามีไฟล์อยู่แล้ว ไม่ต้องทับ
                'SLMN_PATHTextBox.Text = Path.Combine(Application.StartupPath & "\Image\Salesman", Path.GetFileName(OpenFileDialog1.FileName))
                File.Copy(OpenFileDialog1.FileName, Path.Combine(Application.StartupPath & "\Image\Salesman", slmn_refcheck & Path.GetExtension(OpenFileDialog1.FileName)), True) 'ถ้ามีไฟล์อยู่แล้ว ไม่ต้องทับ
                SLMN_PATHTextBox.Text = Path.Combine(Application.StartupPath & "\Image\Salesman", slmn_refcheck & Path.GetExtension(OpenFileDialog1.FileName))
                SHOWIMAGE()
            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
            End Try
        End If
    End Sub

    Private Sub addr_add_Click(sender As System.Object, e As System.EventArgs) Handles addr_add.Click
        open_image()
    End Sub

    Private Sub addr_edit_Click(sender As System.Object, e As System.EventArgs) Handles addr_edit.Click
        CLEAR_IMAGE()
    End Sub

    Private Sub SLMN_COMMISSIONTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles SLMN_COMMISSIONTextBox.KeyPress
        e.Handled = currency_input(sender, e.KeyChar)
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Try
            Dim FRM As New info_salesman
            FRM.StartPosition = FormStartPosition.CenterParent
            FRM.ShowDialog()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub slmn_image_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles slmn_image.MouseDown
        If e.Button = MouseButtons.Left Then
            open_image_old()
        End If
    End Sub

    Private Sub create_picture_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles create_picture.MouseDown
        If e.Button = MouseButtons.Left Then
            open_image()
        End If
    End Sub
End Class