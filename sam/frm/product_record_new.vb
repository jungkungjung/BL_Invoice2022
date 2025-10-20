Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Public Class product_record_new
    Dim vat_r As Double 'อัตราภาษี
    Public frm1 As product_tab 'ใช้วิธีนี้ เพื่อคืนค่า refresh from (ผ่านค่าแบบ Form Type)
    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.PRODUCTSTableAdapter.Fill(Me.INVOICEDataSet.PRODUCTS) 'ไม่ต้อง fill เนื่องจากเปิดโดย Fillby
        'custype_salesman()
        Try
            If company_table.Rows.Count > 0 Then
                vat_r = company_table.Rows(0).Item("CMPN_VAT_R")
            Else
                vat_r = 0
            End If
            Pn_not_show.Hide()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub customer_record_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            radio_choose()
            SHOWIMAGE()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Public Sub custype_salesman() 'combobox พนักงานขาย ,ประเภทลูกหนี้ ,จังหวัด refresh ข้ามฟอร์มได้
        'Dim PROTYPE_BIN As New BindingSource
        'If product_type_table.Rows.Count > 0 Then
        '    PROTYPE_BIN.DataSource = product_type_table()
        '    protype_cmb.DataSource = PROTYPE_BIN
        '    protype_cmb.DisplayMember = "PROTY_NAME"
        '    protype_cmb.ValueMember = "PROTY_ID"
        '    protype_cmb.DataBindings.Add("SELECTEDVALUE", Me.PRODUCTSBindingSource, "PRO_CAT") 'วิธีนี้ จะ update หลังจากบันทึก
        'End If
    End Sub

    Private Sub radio_choose()
        Try
            TAX_CMB.SelectedIndex = Integer.Parse(PRO_VAT_TYTextBox.Text)
            vat_enable()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
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
            PRODUCTSBindingSource.AddNew()
            PRO_UNITTextBox.Text = "ชิ้น"
            PRO_CATTextBox.Text = 0
            PRO_PRICETextBox.Text = 0
            PRO_BUYTextBox.Text = 0
            PRO_VAT_TYTextBox.Text = 0
            PRO_VAT_RTextBox.Text = 0
            PRO_MINTextBox.Text = 0
            PRO_MAXTextBox.Text = 0
            PRO_STATUSCheckBox.Checked = False
            TAX_CMB.SelectedIndex = Integer.Parse(PRO_VAT_TYTextBox.Text) '0 'ระบุค่าเริ่มต้น เป็นตัวแรก
            CLEAR_IMAGE()
            'PRO_CATTextBox.Text = 1 'กำหนดประเภทเป็น default เวอร์ชั่นนี้ ไม่ต้องใช้ ประเภทสินค้า default 1 อยู่แล้ว ไม่ใช้ 0 เนื่องจากฟิวด์ประเภทสินค้า id เป็นแบบ auto เริ่มจาก 1
            'If protype_cmb.Items.Count > 0 Then 'ป้องกัน ไม่มีประเภทสินค้า
            '    protype_cmb.SelectedIndex = 0
            'Else
            'PRO_CATTextBox.Text = 0
            'End If
            insert_status.Text = "1"
            code_auto()
            navigator_guna_add(Guna_add, Guna_save, Guna_delete, Guna_print)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_add.Click
        create_job()
    End Sub
    Private Sub save1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_save.Click
        If PRO_CODETextBox.Text.Trim.Length = 0 Then
            MsgBox("กรุณาใส่รหัสสินค้า", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            PRO_CODETextBox.Select()
            Exit Sub
        ElseIf PRO_NAMETextBox.Text.Trim.Length = 0 Then
            MsgBox("กรุณาใส่ชื่อสินค้าค้า", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            PRO_NAMETextBox.Select()
            Exit Sub
        End If
        If Double.Parse(PRO_VAT_RTextBox.Text) > 30 Then
            MsgBox("ตรวจสอบอัตราภาษี", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            PRO_VAT_RTextBox.Select()
            Exit Sub
        End If
        Try
            If insert_status.Text = "1" Then
                PRO_CREATEDateTimePicker.Value = Now
                Me.Validate()
                Me.PRODUCTSBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            Else
                Me.Validate()
                Me.PRODUCTSBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            End If

            If Not frm1.IsDisposed Then 'เช็ค กรณีปิดหน้าจอ ฟอร์มหลัก จะไม่สามารถ คืนค่า ให้ตรวจสอบว่า ฟอร์มหลักเปิดอยู่รึไม่
                frm1.form_refresh()
                frm1.FIND_GRW_ROWS(Integer.Parse(PRO_IDTextBox.Text)) 'หาตำแหน่ง cursor ของ grw 
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
    Private Sub delete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_delete.Click
        If insert_status.Text = "1" Then
            MsgBox("ยังไม่บันทึกข้อมูล", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Exit Sub
        End If
        Try
            Dim pro_exists = (From pro In tranmain_detail_table()
                            Where pro("TRD_SKU") = Integer.Parse(PRO_IDTextBox.Text)
                            )
            If pro_exists.Count > 0 Then
                Dim str As String = ""
                For Each row3 As DataRow In pro_exists
                    str += row3.Item("TRH_DATE") + " " + row3.Item("TRH_NO") + vbNewLine
                Next
                MsgBox("พบรายการอ้างอิง " + pro_exists.Count.ToString("#,###") + " รายการ ไม่สามารถลบได้" + vbNewLine + str, MsgBoxStyle.Information, "คำเตือน")
                Exit Sub
            End If

            Dim msgtext As String
            msgtext = MsgBox("ยืนยันการลบข้อมูล", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "คำเตือน")
            If msgtext = vbYes Then
                Me.PRODUCTSBindingSource.RemoveCurrent()
                Me.Validate()
                Me.PRODUCTSBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
                insert_status.Text = 0
                'วิธีใหม่กว่า 'ใช้วิธีนี้ เพื่อคืนค่า refresh from (ผ่านค่าแบบ Form Type)
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
    Private Sub TAX_CMB_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TAX_CMB.SelectionChangeCommitted
        Try
            PRO_VAT_TYTextBox.Text = TAX_CMB.SelectedIndex
            'vat_enable()
            If TAX_CMB.SelectedIndex = 0 Then 'อัตราทั่วไป
                PRO_VAT_RTextBox.ReadOnly = True
                PRO_VAT_RTextBox.Text = 0 'vat_r ใช้วิธีเดิมไปก่อน คือ อัตราทั่วไป ตัวเลขอัตราเป็น 0 เวลาคำนวณในบิล ให้ไปดึง จากตั้งค่า company เผื่อกรณี กฏหมายเปลี่ยนอัตราภาษี จะได้ไม่ต้องมาไล่แก้ ในประวัติสินค้า
            ElseIf TAX_CMB.SelectedIndex = 1 Then 'ยกเว้นภาษี
                PRO_VAT_RTextBox.ReadOnly = True
                PRO_VAT_RTextBox.Text = 0
            ElseIf TAX_CMB.SelectedIndex = 2 Then 'กำหนดเอง
                PRO_VAT_RTextBox.ReadOnly = False
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub vat_enable()
        Try
            If TAX_CMB.SelectedIndex = 0 Then 'อัตราทั่วไป
                PRO_VAT_RTextBox.ReadOnly = True
            ElseIf TAX_CMB.SelectedIndex = 1 Then 'ยกเว้นภาษี
                PRO_VAT_RTextBox.ReadOnly = True
            ElseIf TAX_CMB.SelectedIndex = 2 Then 'กำหนดเอง
                PRO_VAT_RTextBox.ReadOnly = False
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
            sql_config &= " CR_CODE='301'" 'รหัสสินค้า
            sql_config &= " AND CR_STATUS=1" 'ตั้งค่ารหัสอัตโนมัติ
            Dim cmd_config As New SqlCommand(sql_config, cnn_sql_main)
            Dim adapter_config As New SqlDataAdapter(cmd_config)
            adapter_config.Fill(doctype_a, "CODE_RUNNING")

            If doctype_a.Tables("CODE_RUNNING").Rows.Count > 0 Then
                If Len(doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME")) = 0 Then
                    PRO_CODETextBox.Select()
                    Exit Sub 'ถ้าไม่กำหนด prefix ให้ออกจาก sub
                End If
                header_first = doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME")
                header_width = Len(doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME"))
                number_width = doctype_a.Tables("CODE_RUNNING").Rows(0).Item("CR_RUNNING")
            Else
                'MsgBox("ไม่พบการตั้งรหัสอัตโนมัติ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                PRO_CODETextBox.Select()
                Exit Sub
            End If

            Dim data_cus As New DataSet
            Dim sql_cus As String = "SELECT TOP 1"
            sql_cus &= " PRO_CODE,SUBSTRING(PRO_CODE," & header_width + 1 & ",10) AS NUM_START"
            sql_cus &= " FROM PRODUCTS"
            sql_cus &= " WHERE"
            sql_cus &= " LEFT(PRO_CODE," & header_width & ")='" & header_first & "'"
            sql_cus &= " AND ISNUMERIC(SUBSTRING(PRO_CODE," & header_width + 1 & ",10))=1"
            sql_cus &= " AND LEN(SUBSTRING(PRO_CODE," & header_width + 1 & ",10))=" & number_width
            sql_cus &= " ORDER BY PRO_CODE DESC"
            Dim cmd_cus As New SqlCommand(sql_cus, cnn_sql_main)
            Dim adapter_cus As New SqlDataAdapter(cmd_cus)
            adapter_cus.Fill(data_cus, "DOC_PRODUCTS")

            If data_cus.Tables("DOC_PRODUCTS").Rows.Count > 0 Then
                strIDAcc = header_first & (Integer.Parse(data_cus.Tables("DOC_PRODUCTS").Rows(0).Item("NUM_START")) + 1).ToString(StrDup(number_width, "0"))
                PRO_CODETextBox.Text = strIDAcc
                PRO_NAMETextBox.Select()
            Else
                strIDAcc = header_first & 1.ToString(StrDup(number_width, "0")) 'ถ้าไม่พบรหัสก่อนนี้ ให้ run ใหม่
                PRO_CODETextBox.Text = strIDAcc
                PRO_NAMETextBox.Select()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub exit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_exit.Click
        Close()
    End Sub

    Private Sub print1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_print.Click
        'MsgBox("ยังไม่ออกแบบ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
    End Sub

    Private Sub PRO_MINTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PRO_MINTextBox.KeyPress
        e.Handled = currency_input(sender, e.KeyChar)
    End Sub

    Private Sub PRO_MAXTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PRO_MAXTextBox.KeyPress
        e.Handled = currency_input(sender, e.KeyChar)
    End Sub

    Private Sub PRO_PRICETextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PRO_PRICETextBox.KeyPress
        e.Handled = currency_input(sender, e.KeyChar)
    End Sub

    Private Sub PRO_VAT_RTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PRO_VAT_RTextBox.KeyPress
        e.Handled = currency_input(sender, e.KeyChar)
    End Sub

    Private Sub SHOWIMAGE()
        Try
            If File.Exists(PRO_IMAGETextBox.Text.Trim) Then
                Using fs As New System.IO.FileStream(PRO_IMAGETextBox.Text, IO.FileMode.Open, IO.FileAccess.Read) 'ใช้วิธีนี้ หรือใช้ imagelocation แทน ป้องกันเวลาลบภาพ จะ error ล็อคไฟล์
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
            If File.Exists(PRO_IMAGETextBox.Text) Then
                File.Delete(PRO_IMAGETextBox.Text)
            End If
            PRO_IMAGETextBox.Clear()
            create_picture.Image = Nothing
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub open_image()
        Try
            Dim a As String
            If PRO_IMAGETextBox.Text.Trim.Length = 0 Then
                a = ""
            Else
                If Directory.Exists(System.IO.Path.GetDirectoryName(PRO_IMAGETextBox.Text)) Then
                    a = System.IO.Path.GetDirectoryName(PRO_IMAGETextBox.Text)
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
                Dim pro_refcheck As String = "" 'replace ชื่อไฟล์เอกสารก่อน กัน error
                If PRO_CODETextBox.Text.Contains("/") OrElse PRO_CODETextBox.Text.Contains("\") Then 'ตรวจสอบชื่อเอกสาร ที่มีเครื่องหมาย "/" หรือ "\" จะใช้สร้างชื่อไฟล์ไม่ได้ ให้ใช้ "-" แทน
                    pro_refcheck = Replace(Replace(PRO_CODETextBox.Text, "/", "-"), "\", "-")
                Else
                    pro_refcheck = PRO_CODETextBox.Text
                End If
                'File.Copy(OpenFileDialog1.FileName, Path.Combine(Application.StartupPath & "\Image\Products", Path.GetFileName(OpenFileDialog1.FileName)), False) 'ถ้ามีไฟล์อยู่แล้ว ไม่ต้องทับ
                'PRO_IMAGETextBox.Text = Path.Combine(Application.StartupPath & "\Image\Products", Path.GetFileName(OpenFileDialog1.FileName))
                File.Copy(OpenFileDialog1.FileName, Path.Combine(Application.StartupPath & "\Image\Products", pro_refcheck & Path.GetExtension(OpenFileDialog1.FileName)), True) 'ถ้ามีไฟล์อยู่แล้ว ไม่ต้องทับ
                PRO_IMAGETextBox.Text = Path.Combine(Application.StartupPath & "\Image\Products", pro_refcheck & Path.GetExtension(OpenFileDialog1.FileName))
                SHOWIMAGE()
            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
            End Try
        End If
    End Sub

    Private Sub addr_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addr_add.Click
        open_image()
    End Sub

    Private Sub addr_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addr_edit.Click
        CLEAR_IMAGE()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim FRM As New info_products
        FRM.StartPosition = FormStartPosition.CenterParent
        FRM.ShowDialog()
    End Sub

    Private Sub create_picture_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles create_picture.MouseDown
        If e.Button = MouseButtons.Left Then
            open_image()
        End If
    End Sub

    Private Sub PRO_VAT_RTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PRO_VAT_RTextBox.Validating
        Try
            If Double.Parse(PRO_VAT_RTextBox.Text) > 100 Then
                MsgBox("ส่วนลดเกิน 100 %", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                e.Cancel = True
                PRO_VAT_RTextBox.Undo() ''undo ค่าเดิม
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
End Class