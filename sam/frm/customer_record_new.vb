Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class customer_record_new
    Public frm1 As customer_tab 'ใช้วิธีนี้ เพื่อคืนค่า refresh from (ผ่านค่าแบบ Form Type)
    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.CUSTOMERTableAdapter.Fill(Me.INVOICEDataSet.CUSTOMER) 'ไม่ต้อง fill เนื่องจากเปิดโดย Fillby
        Try
            custype_salesman()
            Pn_not_show.Hide()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub customer_record_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Try
            If CType(CUSTOMERBindingSource.Current, DataRowView).Item(0) > -1 Then 'ป้องกัน error เมื่อสร้างใหม่ เนื่องจากไม่ได้ default value ใน dataset
                TAX_CMB.SelectedIndex = Integer.Parse(CUS_TAX_TYTextBox.Text) 'ดึงค่าไปผูกกับ combobox
                TAX_VATIO.SelectedIndex = Integer.Parse(CUS_TAX_VATIOTextBox.Text)
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Public Sub custype_salesman() 'combobox พนักงานขาย ,ประเภทลูกหนี้ ,จังหวัด refresh ข้ามฟอร์มได้
        Dim SALES_BIN As New BindingSource
        Try
            If salesman_table.Rows.Count > 0 Then
                SALES_BIN.DataSource = salesman_table()
                SALES_CMB.DataSource = SALES_BIN
                SALES_CMB.DisplayMember = "SLMN_NAME"
                SALES_CMB.ValueMember = "SLMN_ID"
                SALES_CMB.DataBindings.Add("SELECTEDVALUE", Me.CUSTOMERBindingSource, "CUS_SLMN") 'วิธีนี้ จะ update หลังจากบันทึก
            End If
            'SALES_CMB.Refresh()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try

        'Dim CUSTYPE_BIN As New BindingSource
        'If customer_type_table.Rows.Count > 0 Then
        '    CUSTYPE_BIN.DataSource = customer_type_table()
        '    custype_cmb.DataSource = CUSTYPE_BIN
        '    custype_cmb.DisplayMember = "CUSTY_NAME"
        '    custype_cmb.ValueMember = "CUSTY_ID"
        '    custype_cmb.DataBindings.Add("SELECTEDVALUE", Me.CUSTOMERBindingSource, "CUS_CAT") 'วิธีนี้ จะ update หลังจากบันทึก
        'End If

        'จังหวัด ใช้ฟิวด์ตรง ไปเลย คีย์เองได้ หรือเลือกจากตาราง ได้ ไม่ต้องใช้ combobox
        'Dim PROVINCE_BIN As New BindingSource
        'If province_table.Rows.Count > 0 Then
        '    PROVINCE_BIN.DataSource = province_table()
        '    province_cmb.DataSource = PROVINCE_BIN
        '    province_cmb.DisplayMember = "PROVINCE_NAME"
        '    province_cmb.ValueMember = "PROVINCE_NAME"
        '    province_cmb.DataBindings.Add("SELECTEDVALUE", Me.CUSTOMERBindingSource, "CUS_PROVINCE") 'วิธีนี้ จะ update หลังจากบันทึก
        'End If
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
            CUSTOMERBindingSource.AddNew()
            'ใส่ default แทนการกำหนดใน dataset
            CUS_CATTextBox.Text = 0
            CUS_CREDIT_TERMTextBox.Text = 0
            CUS_CREDIT_LIMITTextBox.Text = 0
            CUS_DISC_PERCENTextBox.Text = 0
            CUS_TAX_TYTextBox.Text = 0
            CUS_TAX_VATIOTextBox.Text = 0
            TAX_CMB.SelectedIndex = 0 'CUS_TAX_TYTextBox.Text
            TAX_VATIO.SelectedIndex = 0 'CUS_TAX_VATIOTextBox.Text
            CUS_STATUSCheckBox.Checked = False
            'ระบุค่าเริ่มต้น เป็นตัวแรก
            'กำหนดประเภทเป็น default เวอร์ชั่นนี้ ไม่ต้องใช้ ประเภทลูกค้า default 1 อยู่แล้ว ไม่ใช้ 0 เนื่องจากฟิวด์ประเภทลูกค้า id เป็นแบบ auto เริ่มจาก 1
            'If custype_cmb.Items.Count > 0 Then 'ป้องกัน ไม่มีประเภทลูกค้า
            '    custype_cmb.SelectedIndex = 0
            'Else
            '    CUS_CATTextBox.Text = 0
            'End If
            If SALES_CMB.Items.Count > 0 Then 'ป้องกัน ไม่มีพนักงานขาย
                SALES_CMB.SelectedIndex = 0
            Else
                CUS_SLMNTextBox.Text = 0
            End If

            'ยกเลิก วิธีเลือกจังหวัดจาก combobox
            'province_cmb.SelectedIndex = 0
            'ถ้าสร้างลูกค้าใหม่ default จังหวัด=กรุงเทพฯ
            'Dim bkk = (From provine In province_table()
            '        Where provine("PROVINCE_NAME").ToString.Contains("กรุงเทพฯ")
            '        )
            'If bkk.Count > 0 Then
            '    province_cmb.SelectedValue = "กรุงเทพฯ"
            'End If
            'DEFAULT
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
        If CUS_CODETextBox.Text.Trim.Length = 0 Then
            MsgBox("กรุณาใส่รหัสลูกค้า", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            CUS_CODETextBox.Select()
            Exit Sub
        ElseIf CUS_NAMETextBox.Text.Trim.Length = 0 Then
            MsgBox("กรุณาใส่ชื่อลูกค้า", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            CUS_NAMETextBox.Select()
            Exit Sub
        End If
        If Double.Parse(CUS_DISC_PERCENTextBox.Text) > 100 Then
            MsgBox("ตรวจสอบส่วนลดเกิน 100%", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            CUS_DISC_PERCENTextBox.Select()
            Exit Sub
        End If

        Try
            If insert_status.Text = "1" Then
                CUS_CREATEDateTimePicker.Value = Now
                Me.Validate()
                Me.CUSTOMERBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            Else
                Me.Validate()
                Me.CUSTOMERBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            End If

            If Not frm1.IsDisposed Then 'เช็ค กรณีปิดหน้าจอ ฟอร์มหลัก จะไม่สามารถ คืนค่า ให้ตรวจสอบว่า ฟอร์มหลักเปิดอยู่รึไม่
                frm1.form_refresh()
                frm1.FIND_GRW_ROWS(Integer.Parse(CUS_IDTextBox.Text)) 'หาตำแหน่ง cursor ของ grw 
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
            Dim cus_exists = (From cus In tranmain_table()
             Where cus("TRH_CUS") = Integer.Parse(CUS_IDTextBox.Text)
             )
            If cus_exists.Count > 0 Then
                Dim str As String = ""
                For Each row3 As DataRow In cus_exists
                    str += row3.Item("TRH_DATE") + " " + row3.Item("TRH_NO") + vbNewLine
                Next
                MsgBox("พบการอ้างอิง " + cus_exists.Count.ToString("#,###") + " รายการ ไม่สามารถลบได้" + vbNewLine + str, MsgBoxStyle.Information, "คำเตือน")
                Exit Sub
            End If

            Dim msgtext As String
            msgtext = MsgBox("ยืนยันการลบข้อมูล", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "คำเตือน")
            If msgtext = vbYes Then
                Me.CUSTOMERBindingSource.RemoveCurrent()
                Me.Validate()
                Me.CUSTOMERBindingSource.EndEdit()
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
            'MsgBox(Err.Number)
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
            sql_config &= " CR_CODE='101'"
            sql_config &= " AND CR_STATUS=1" 'ตั้งค่ารหัสอัตโนมัติ
            Dim cmd_config As New SqlCommand(sql_config, cnn_sql_main)
            Dim adapter_config As New SqlDataAdapter(cmd_config)
            adapter_config.Fill(doctype_a, "CODE_RUNNING")

            If doctype_a.Tables("CODE_RUNNING").Rows.Count > 0 Then
                If Len(doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME")) = 0 Then
                    CUS_CODETextBox.Select()
                    Exit Sub 'ถ้าไม่กำหนด prefix ให้ออกจาก sub
                End If
                header_first = doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME")
                header_width = Len(doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME"))
                number_width = doctype_a.Tables("CODE_RUNNING").Rows(0).Item("CR_RUNNING")
            Else
                'MsgBox("ไม่พบการตั้งรหัสอัตโนมัติ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                CUS_CODETextBox.Select()
                Exit Sub
            End If

            Dim data_cus As New DataSet
            Dim sql_cus As String = "SELECT TOP 1"
            sql_cus &= " CUS_CODE,SUBSTRING(CUS_CODE," & header_width + 1 & ",10) AS NUM_START"
            sql_cus &= " FROM CUSTOMER"
            sql_cus &= " WHERE"
            sql_cus &= " LEFT(CUS_CODE," & header_width & ")='" & header_first & "'"
            sql_cus &= " AND ISNUMERIC(SUBSTRING(CUS_CODE," & header_width + 1 & ",10))=1"
            sql_cus &= " AND LEN(SUBSTRING(CUS_CODE," & header_width + 1 & ",10))=" & number_width
            sql_cus &= " ORDER BY CUS_CODE DESC"
            Dim cmd_cus As New SqlCommand(sql_cus, cnn_sql_main)
            Dim adapter_cus As New SqlDataAdapter(cmd_cus)
            adapter_cus.Fill(data_cus, "DOC_CUS")

            If data_cus.Tables("DOC_CUS").Rows.Count > 0 Then
                strIDAcc = header_first & (Integer.Parse(data_cus.Tables("DOC_CUS").Rows(0).Item("NUM_START")) + 1).ToString(StrDup(number_width, "0"))
                CUS_CODETextBox.Text = strIDAcc
                CUS_NAMETextBox.Select()
            Else
                strIDAcc = header_first & 1.ToString(StrDup(number_width, "0")) 'ถ้าไม่พบรหัสก่อนนี้ ให้ run ใหม่
                CUS_CODETextBox.Text = strIDAcc
                CUS_NAMETextBox.Select()
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

    Private Sub return_lnk_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles return_lnk.LinkClicked
        'grw.ClearSelection()
    End Sub

    Private Sub TAX_CMB_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles TAX_CMB.SelectionChangeCommitted
        CUS_TAX_TYTextBox.Text = TAX_CMB.SelectedIndex
    End Sub

    Private Sub TAX_VATIO_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles TAX_VATIO.SelectionChangeCommitted
        CUS_TAX_VATIOTextBox.Text = TAX_VATIO.SelectedIndex
    End Sub

    Private Sub CUS_CREDIT_LIMITTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CUS_CREDIT_LIMITTextBox.KeyPress
        e.Handled = currency_input(sender, e.KeyChar)
    End Sub
    Private Sub CUS_DISC_PERCENTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CUS_DISC_PERCENTextBox.KeyPress
        e.Handled = currency_input(sender, e.KeyChar)
    End Sub
    Private Sub CUS_CREDIT_TERMTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CUS_CREDIT_TERMTextBox.KeyPress
        e.Handled = integer_input(e.KeyChar)
    End Sub

    Private Sub GunaButton1_Click(sender As System.Object, e As System.EventArgs)
        Try
            Dim cus_exists = (From cus In tranmain_table()
                 Where cus("TRH_CUS") = Integer.Parse(CUS_IDTextBox.Text)
                 )
            If cus_exists.Count > 0 Then
                Dim str As String = ""
                For Each row3 As DataRow In cus_exists
                    str += row3.Item("TRH_DATE") + " " + row3.Item("TRH_NO") + vbNewLine
                Next
                MsgBox("พบการอ้างอิง " + cus_exists.Count.ToString("#,###") + " รายการ ไม่สามารถลบได้" + vbNewLine + str, MsgBoxStyle.Information, "คำเตือน")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub CUS_DISC_PERCENTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles CUS_DISC_PERCENTextBox.Validating
        'If Double.Parse(CUS_DISC_PERCENTextBox.Text) > 100 Then 'ให้เช็คตอนกดปุ่มบันทึก เนื่องจากจะ error ถ้าลบออก เป็นค่าว่าง
        '    MsgBox("ส่วนลดเกิน 100 %", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
        '    e.Cancel = True
        '    CUS_DISC_PERCENTextBox.Undo() ''undo ค่าเดิม
        'End If
    End Sub

    Private Sub province_lnk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles province_lnk.Click
        Try
            Dim FM4 As New province_tab
            If FM4.ShowDialog(Me) = DialogResult.OK Then
                CUS_PROVINCETextBox.Text = FM4.grw.CurrentRow.Cells("PROVINCE_NAME").Value
                If CUS_POSTTextBox.Text.Length = 0 Then
                    CUS_POSTTextBox.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
End Class