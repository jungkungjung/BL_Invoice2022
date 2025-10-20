Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports System.Security
Imports System.Security.Permissions
Imports Microsoft.VisualBasic

Public Class doc_record_new
    Dim DATA As New DataSet
    Dim DATA_RPT As New DataSet
    Dim DATA_GEN As New DataSet
    Dim dtv_rpt As New DataView
    Dim vat_r As Double
    Dim trd_code_check As String
    Dim rpt4 As New ReportDocument 'ประกาศตรงนี้ เพื่อลบ rpt ใน temp windows ตอนปิดหน้าจอ
    Dim cellenter_check As Integer = 0 'เอาไว้เช็คค่า enter แล้วให้ focus ที่ datacell ที่ระบุ
    Private Property TextBox As TextBox
    Dim cmpn_chk As String = "" 'เช็ค license ลูกค้า
    Dim cmpn_tax_chk As String = ""
    Dim File_ini = Path.Combine(System.Windows.Forms.Application.StartupPath, "DB_Config.ini")
    Public frm1 As doc_tab 'ใช้วิธีนี้ เพื่อคืนค่า refresh from (ผ่านค่าแบบ Form Type)
    
    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'company_licensse()
            'Console.WriteLine(str_taxid)
            'Console.WriteLine(str_cmpn)

            EnableDoubleBuffered(TRAN) 'วิธีโหลด datagrid ให้เร็วขึ้น

            'Me.TRANDETAILTableAdapter.Fill(Me.INVOICEDataSet.TRANDETAIL)
            'Me.TRANMAINTableAdapter.Fill(Me.INVOICEDataSet.TRANMAIN)

            TRANDETAILBindingSource.Sort = "TRD_SEQ" 'เฉพาะ ลูกค้า ดีดี การ์เด้น โฮม ให้แก้ไขลำดับ และเรียงใหม่ได้
            With TRAN
                .Columns("TRD_QTY").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("TRD_UPC").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("TRD_DISC").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("TRD_DISC_AMT").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("TRD_G_KEYIN").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
            main_table()
            Pn_not_show.Hide()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub customer_record_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            If insert_status.Text = 0 Then 'ค้นหา เพื่อแสดงชื่อลูกค้า เฉพาะเอกสารที่สร้างไว้แล้ว
                FIND_TRH_CUS()
                cal_label() 'แสดงจำนวนรายการ ท้ายเอกสาร
            End If
            TRAN.ClearSelection()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub FrmCustomer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub cal_label()
        lb_sum.Text = Format(Integer.Parse(TRH_N_ITEMSTextBox.Text), "n0") + " รายการ" + " จำนวน  " + Format(Double.Parse(TRH_N_QTYTextBox.Text), "#,##0.##") + " ชิ้น"
    End Sub
    Private Sub main_table()
        Dim SALES_BIN As New BindingSource
        Try
            If salesman_table.Rows.Count > 0 Then
                SALES_BIN.DataSource = salesman_table()
                SALES_CMB.DataSource = SALES_BIN
                SALES_CMB.DisplayMember = "SLMN_NAME"
                SALES_CMB.ValueMember = "SLMN_ID"
                'If refresh_cnt = 1 Then 'ถ้ามีการ update ฟิวด์ SALES_CMB ไม่ต้อง binding ใหม่
                '    Exit Sub
                'End If
                SALES_CMB.DataBindings.Add("SELECTEDVALUE", Me.TRANMAINBindingSource, "TRH_SLMN") 'วิธีนี้ จะ update หลังจากบันทึก
            End If
            If company_table.Rows.Count > 0 Then
                vat_r = company_table.Rows(0).Item("CMPN_VAT_R")
            Else
                vat_r = 0
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub vat_lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles vat_lnk.LinkClicked
        Dim FM4 As New vat_setting_new
        FM4.TRH_VAT_TYTextBox.Text = TRH_VAT_TYTextBox.Text
        FM4.TRH_VATIOTextBox.Text = TRH_VATIOTextBox.Text
        If FM4.ShowDialog(Me) = DialogResult.OK Then
            Dim vat_rate As Double
            If company_table.Rows.Count > 0 Then 'ดึงอัตราภาษี
                vat_rate = company_table.Rows(0).Item("CMPN_VAT_R")
            Else
                vat_rate = 0
            End If
            Try
                TRH_VAT_TYTextBox.Text = FM4.TRH_VAT_TYTextBox.Text
                TRH_VATIOTextBox.Text = FM4.TRH_VATIOTextBox.Text
                If TRH_VAT_TYTextBox.Text = 0 Then
                    TRH_VAT_RTextBox.Text = vat_rate 'ดึงอัตราภาษีใหม่ เมื่อมีการแก้ไข แล้วบันทึก
                Else
                    TRH_VAT_RTextBox.Text = 0
                End If
                cal_vat_setting() 'คำนวณภาษีใหม่
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        End If
    End Sub
    Public Sub cal_vat_setting() 'คำนวณใหม่ เมื่อมีการเปลี่ยนแปลง วิธีคิดภาษี
        call_skuchange_trd()
    End Sub
    Public Sub create_job()
        Try
            If company_licensse() = False Then
                If tranmain_table.Rows.Count > 9 Then
                    MsgBox("เลขทะเบียนซอฟแวร์ไม่ถูกต้องหรือเป็นเวอร์ชั่นทดลอง โปรดติดต่อเจ้าหน้าที่ เพื่อขอเลขทะเบียน", MsgBoxStyle.Question, "คำเตือน")
                    Exit Sub 'ถ้า license ไม่ถูกต้อง ออกจาก sub
                End If
            End If
            If insert_status.Text = "1" Then
                MsgBox("ยังไม่บันทึกข้อมูล", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                Exit Sub
            End If
            TRANMAINBindingSource.AddNew()
            insert_status.Text = "1"
            'default value
            TRH_DTTextBox.Text = 2 'ใบเสนอราคา
            TRH_CUSTextBox.Text = 0
            TRH_SLMNTextBox.Text = 0
            TRH_TERMTextBox.Text = 0
            TRH_VATIOTextBox.Text = 0
            TRH_VATTextBox.Text = 0
            TRH_VAT_TYTextBox.Text = 0
            TRH_VAT_RTextBox.Text = 0
            TRH_N_QTYTextBox.Text = 0
            TRH_N_ITEMSTextBox.Text = 0
            TRH_G_KEYINTextBox.Text = 0
            TRH_DISCTextBox.Text = 0
            TRH_DISC_AMTTextBox.Text = 0
            TRH_G_SELLTextBox.Text = 0
            TRH_G_SVTextBox.Text = 0
            TRH_G_SNVTextBox.Text = 0
            TRH_G_VATTextBox.Text = 0
            TRH_G_NETTextBox.Text = 0
            TRH_DOC_STATUSTextBox.Text = 0
            TRH_STATUSCheckBox.Checked = False
            '////
            lb_sum.Text = "" 'เคลียร์ จำนวนรายการ รวม
            TRANDETAILTableAdapter.FillBy(INVOICEDataSet.TRANDETAIL, -1) 'vbNull)
            'เลขที่เอกสาร auto ใช้กับระบบแลน ต้องใช้ตอน save ให้จ่ายเลขที่ ตอนบันทึก
            DOC_AUTORUN(TRH_NOTextBox) 'เลขที่เอกสาร
            DOC_AUTORUN(TRH_VAT_NOTextBox) 'เลขที่ใบกำกับภาษี
            '/////
            CUS_CODE.Clear()
            CUS_NAME.Clear()
            CUS_ADDB1.Clear()
            CUS_TAXID.Clear()
            'default
            TRH_DATEDateTimePicker.Value = Now.Date
            TRH_VAT_DATEDateTimePicker.Value = Now.Date
            TRH_DUEDateTimePicker.Value = Now.Date
            TRH_BILL_DATEDateTimePicker.Value = Now.Date
            TRH_SHIP_DATEDateTimePicker.Value = Now.Date
            TRH_CANCEL_DATEDateTimePicker.Value = Now.Date
            If salesman_table.Rows.Count > 0 Then 'ป้องกัน error รันฐานเปล่า
                SALES_CMB.SelectedIndex = 0 'ระบุค่าเริ่มต้น slmns
                TRH_SLMNTextBox.Text = SALES_CMB.SelectedValue
            End If
            'TAX_CMB.SelectedIndex = 0
            TRH_VAT_RTextBox.Text = vat_r 'default vat
            CUS_CODE.Select()
            navigator_guna_add(Guna_add, Guna_save, Guna_delete, Guna_print)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub CREATE_SUB()
        Try
            Dim new_seq As Integer = max_seq()
            TRANDETAILBindingSource.AddNew()
            With TRAN
                If insert_status.Text = "0" Then 'ถ้าอยู่่ในระบบ แก้ไข จะมีเลข id อยู่แล้ว
                    .CurrentRow.Cells("TRD_TRH").Value = Integer.Parse(TRH_IDTextBox.Text)
                End If
                .CurrentRow.Cells("TRD_SEQ").Value = new_seq + 1 '.CurrentRow.Index + 1 ใช้วิธีหาค่าสูงสุดแทน row.index แก้ปัญหาลบ record ระหว่างแถว
                .CurrentRow.Cells("TRD_QTY").Value = 1
                .CurrentRow.Cells("TRD_UPC").Value = 0
                .CurrentRow.Cells("TRD_DISC").Value = 0
                .CurrentRow.Cells("TRD_DISC_AMT").Value = 0
                .CurrentRow.Cells("TRD_G_KEYIN").Value = 0
                .CurrentRow.Cells("TRD_TDISC_AMT").Value = 0
                .CurrentRow.Cells("TRD_G_SELL").Value = 0
                .CurrentRow.Cells("TRD_G_VAT").Value = 0
                .CurrentRow.Cells("TRD_G_AMT").Value = 0
                .CurrentRow.Cells("TRD_VAT_TY").Value = 0
                .CurrentRow.Cells("TRD_VAT_R").Value = 0

                .CurrentRow.Cells("TRD_CREATE").Value = Now
                .CurrentRow.Cells("TRD_SEQ").Selected = False
                .CurrentCell = .CurrentRow.Cells("TRD_SKU_CODE")
                .BeginEdit(False)
            End With
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub doc_record_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'OrElse e.KeyCode = Keys.Down Then ไม่ต้องใช้ เนื่องจาก มีการใช้ ใน datagridcell ในการเลื่อน ถ้าจะใช้ต้องเช็คว่าอยู่ row สุดท้ายหรือไม่
        If e.KeyCode = Keys.F1 Then
            Try
                Dim new_seq As Integer = max_seq()
                TRANDETAILBindingSource.AddNew()
                With TRAN
                    If insert_status.Text = "0" Then 'ถ้าอยู่่ในระบบ แก้ไข จะมีเลข id อยู่แล้ว
                        .CurrentRow.Cells("TRD_TRH").Value = Integer.Parse(TRH_IDTextBox.Text)
                    End If
                    .CurrentRow.Cells("TRD_SEQ").Value = new_seq + 1
                    .CurrentRow.Cells("TRD_QTY").Value = 1
                    .CurrentRow.Cells("TRD_UPC").Value = 0
                    .CurrentRow.Cells("TRD_DISC").Value = 0
                    .CurrentRow.Cells("TRD_DISC_AMT").Value = 0
                    .CurrentRow.Cells("TRD_G_KEYIN").Value = 0
                    .CurrentRow.Cells("TRD_TDISC_AMT").Value = 0
                    .CurrentRow.Cells("TRD_G_SELL").Value = 0
                    .CurrentRow.Cells("TRD_G_VAT").Value = 0
                    .CurrentRow.Cells("TRD_G_AMT").Value = 0
                    .CurrentRow.Cells("TRD_VAT_TY").Value = 0
                    .CurrentRow.Cells("TRD_VAT_R").Value = 0

                    .CurrentRow.Cells("TRD_CREATE").Value = Now
                    .CurrentRow.Cells("TRD_SEQ").Selected = False
                    .CurrentCell = .CurrentRow.Cells("TRD_SKU_CODE")
                    .BeginEdit(False)
                End With
            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
            End Try
        End If
    End Sub
    Private Sub Guna_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_add.Click
        create_job()
    End Sub

    Private Sub Guna_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_save.Click
        If TRAN.Rows.Count = 0 Then 'ถ้าไม่มีรายการสินค้า ให้ออกจาก sub
            MsgBox("ไม่พบรายการสินค้า", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Exit Sub
        End If

        If CUS_CODE.Text.Trim.Length = 0 Then
            MsgBox("กรุณาใส่รหัสลูกค้า", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            CUS_CODE.Select()
            Exit Sub
        ElseIf TRH_NOTextBox.Text.Trim.Length = 0 Then
            MsgBox("กรุณาใส่เลขที่เอกสาร", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            TRH_NOTextBox.Select()
            Exit Sub
        End If

        If Double.Parse(TRH_DISCTextBox.Text) > 100 Then 'ส่วนลด ห้ามเกิน 100%
            MsgBox("ตรวจสอบส่วนลดเกิน 100%", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            TRH_DISC_AMTTextBox.Select()
            Exit Sub
        End If
        ' ตรวจสอบ ไม่พบรหัสลูกค้า ไม่สามารถบันทึกได้
        Dim cus_noexists = (From cus In customer_table()
           Where cus.Field(Of String)("CUS_CODE").ToUpper = CUS_CODE.Text.ToUpper
           )
        If cus_noexists.Count = 0 Then
            MsgBox("ไม่พบรหัสลูกค้าที่บันทึก", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            CUS_CODE.Focus()
            Exit Sub
        End If

        Try
            TRAN.EndEdit() 'มีไว้ทำไมรึ
            Dim sku As String = ""
            For Each row3 As DataGridViewRow In TRAN.Rows
                sku = row3.Cells("TRD_SKU_CODE").FormattedValue.ToString.Trim.ToUpper
                Dim ljoin_product = (From t In product_table()
                         Where t.Field(Of String)("PRO_CODE").Trim.ToUpper = sku
              )
                If ljoin_product.Count = 0 Then
                    MsgBox("ไม่พบรหัสสินค้า " & sku, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                    TRAN.CurrentCell = TRAN.Rows(row3.Index).Cells("TRD_SKU_CODE")
                    'TRAN.BeginEdit(True)
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try

        Try
            ' Dim vat_exists = (From vat In tranmain_table()
            'Where vat.Field(Of String)("TRH_VAT_NO").ToUpper = TRH_VAT_NOTextBox.Text.ToUpper And vat.Field(Of String)("TRH_NO").ToUpper <> TRH_NOTextBox.Text.ToUpper
            ')

            '2024-7-22 edit error TRH_VAT_NO is null
            Dim vat_exists = (From vat In tranmain_table()
            Where vat("TRH_VAT_NO").ToString.ToUpper = TRH_VAT_NOTextBox.Text.ToUpper And vat.Field(Of String)("TRH_NO").ToUpper <> TRH_NOTextBox.Text.ToUpper
            )

            If vat_exists.Count > 0 Then
                Dim str As String = ""
                For Each row3 As DataRow In vat_exists
                    str += row3.Item("TRH_DATE") + " " + row3.Item("TRH_NO") + vbNewLine
                Next
                MsgBox("พบเลขที่ใบกำกับภาษี  " + vat_exists.CopyToDataTable.Rows(0).Item("TRH_VAT_NO") + " ซ้ำ " + vat_exists.Count.ToString("#,###") + " รายการ" + vbNewLine + str, MsgBoxStyle.Information, "คำเตือน")
                'Exit Sub 'เตือนเฉยๆ
            End If

            If insert_status.Text = "1" Then
                TRH_CREATEDateTimePicker.Value = Now
                gen_key() 'รัน key_num ก่อน 
                sub_id()
            End If
            Me.Validate()
            Me.TRANMAINBindingSource.EndEdit()
            Me.TRANDETAILBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            insert_status.Text = "0"
            'ไม่ต้อง fill datatable ใหม่ เนื่องจากใช้ key running เอง
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
            'Close()
            navigator_gana_save(Guna_add, Guna_save, Guna_delete, Guna_print)
            '///// ใช้วิธีใหม่ refresh form
            'If Application.OpenForms().OfType(Of doc_tab).Any Then 'เช็คว่า เปิด form ก่อนรึไม่ กัน error
            '    Dim f3 As doc_tab = CType(Application.OpenForms("doc_tab"), doc_tab)
            '    If TRH_DATEDateTimePicker.Value.Date > f3.Date_to.Value.Date Then 'กรณี สร้างเอกสารใหม่แล้วแก้วันที่เอกสาร เป็นวันที่มากกว่า ตัวกรอง ถึงวันที่ (date_to.value) ให้แก้ date_to ให้เป็นวันที่เดียวกับเอกสาร เพื่อ Query
            '        f3.Date_to.Value = TRH_DATEDateTimePicker.Value
            '    End If
            '    f3.form_refresh()
            '    f3.FIND_GRW_ROWS(Integer.Parse(TRH_IDTextBox.Text))
            'End If
            'วิธีใหม่กว่า 'ใช้วิธีนี้ เพื่อคืนค่า refresh from (ผ่านค่าแบบ Form Type)
            If Not frm1.IsDisposed Then 'เช็ค กรณีปิดหน้าจอ ฟอร์มหลัก จะไม่สามารถ คืนค่า ให้ตรวจสอบว่า ฟอร์มหลักเปิดอยู่รึไม่
                If TRH_DATEDateTimePicker.Value.Date > frm1.Date_to.Value.Date Then 'กรณี สร้างเอกสารใหม่แล้วแก้วันที่เอกสาร เป็นวันที่มากกว่า ตัวกรอง ถึงวันที่ (date_to.value) ให้แก้ date_to ให้เป็นวันที่เดียวกับเอกสาร เพื่อ Query
                    frm1.Date_to.Value = TRH_DATEDateTimePicker.Value
                End If
                frm1.form_refresh()
                frm1.FIND_GRW_ROWS(Integer.Parse(TRH_IDTextBox.Text)) 'หาตำแหน่ง cursor ของ grw 
            End If
            'End If
        Catch ex As Exception
            'If Err.Number = 5 Then
            '    MsgBox("พบรหัสซ้ำ โปรดตรวจสอบ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            'Else
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
            'End If
        End Try
    End Sub

    Private Sub Guna_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_delete.Click
        If insert_status.Text = "1" Then
            MsgBox("ยังไม่บันทึกข้อมูล", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Exit Sub
        End If
        Try
            Dim msgtext As String
            msgtext = MsgBox("ยืนยันการลบข้อมูล", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "คำเตือน")
            If msgtext = vbYes Then
                If TRANDETAILBindingSource.Count > 0 Then
                    For i = 0 To TRANDETAILBindingSource.Count - 1
                        TRANDETAILBindingSource.RemoveAt(0)
                    Next
                End If
                Me.TRANMAINBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TRANMAINBindingSource.EndEdit()
                'Me.TRANMAINTableAdapter.Update(Me.DATAINVDataSet.TRANMAIN)
                Me.TRANDETAILBindingSource.EndEdit()
                'Me.TRANDETAILTableAdapter.Update(Me.DATAINVDataSet.TRANDETAIL)
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

    Private Sub Guna_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_print.Click
        rpt4.Dispose()
        rpt4.Close() 'เพื่อแก้ปัญหา กรณีเพิ่ม logo ใหม่ ให้ปิดก่อน เพื่อ refresh
        If doctype_table.Rows.Count > 0 Then
            Dim ThaiCompanyName As String = ""
            Dim ThaiAddress1 As String = ""
            Dim ThaiAddress2 As String = ""
            Dim EngCompanyName As String = ""
            Dim EngAddress1 As String = ""
            Dim EngAddress2 As String = ""
            Dim CompanyTelno As String = ""
            Dim CompanyFax As String = ""
            Dim CompanyPost As String = ""
            Dim CompanyRegno As String = ""
            Dim Company_logo As String = ""
            Dim Header_txt As String = ""
            Dim Webcompany As String = ""
            Dim Mailcompany As String = ""

            company_table() 'กรณีเพิ่ม logo ใหม่ ใน datatable company ให้ปิดหน้าจอบันทึก ออกไปก่อน แล้วเข้าใหม่ เพื่อพิมพ์ฟอร์ม
            If company_table.Rows.Count > 0 Then
                ThaiCompanyName = company_table.Rows(0).Item("CMPN_NAME").ToString
                ThaiAddress1 = company_table.Rows(0).Item("CMPN_ADDB1").ToString
                ThaiAddress2 = company_table.Rows(0).Item("CMPN_ADDB2").ToString
                CompanyPost = company_table.Rows(0).Item("CMPN_POST").ToString
                EngCompanyName = company_table.Rows(0).Item("CMPN_E_NAME").ToString
                EngAddress1 = company_table.Rows(0).Item("CMPN_E_ADDB1").ToString
                EngAddress2 = company_table.Rows(0).Item("CMPN_E_ADDB2").ToString
                CompanyPost = company_table.Rows(0).Item("CMPN_POST").ToString
                CompanyTelno = company_table.Rows(0).Item("CMPN_TEL").ToString
                CompanyFax = company_table.Rows(0).Item("CMPN_FAX").ToString
                CompanyRegno = company_table.Rows(0).Item("CMPN_TAXID").ToString
                Company_logo = company_table.Rows(0).Item("CMPN_IMAGE_PATH").ToString
                Webcompany = company_table.Rows(0).Item("CMPN_WEB").ToString
                Mailcompany = company_table.Rows(0).Item("CMPN_MAIL").ToString
            End If

            'If doctype_table.Rows(0).Item("DT_PRINT_TY") <> 7 Then
            If (doctype_table.Rows(0).Item("DT_PRINT_TY") >= 0 And doctype_table.Rows(0).Item("DT_PRINT_TY") <= 10) And doctype_table.Rows(0).Item("DT_PRINT_TY") <> 7 Then
                Dim FM4 As New preview
                If doctype_table.Rows(0).Item("DT_PRINT_TY") = 0 Then 'ฟอร์มต่อเนื่อง (ฟอร์มสั่งพิมพ์)
                    data_print(1)
                    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_INV1002.RPT")
                    rpt4.SetDataSource(dtv_rpt)
                ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 1 Then 'ใบส่งของ / ใบกำกับภาษี 
                    'dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView 'master
                    'rpt4.Load(Application.StartupPath & "\Rpt\DOC_INV1001_2PAGE.RPT") 'master
                    'rpt4.SetDataSource(dtv_rpt) 'master
                    data_print(1)
                    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_INV1001_2PAGE.RPT")
                    rpt4.SetDataSource(dtv_rpt)
                    Header_txt = "ใบส่งสินค้า/ใบกำกับภาษี"
                ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 2 Then 'ใบส่งของ / ใบกำกับภาษี พิมพ์ 2 หน้า แบบ ต้นฉบับ ,สำเนา
                    data_print(2)
                    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_INV1001_2PAGE.RPT")
                    rpt4.SetDataSource(dtv_rpt)
                    Header_txt = "ใบส่งสินค้า/ใบกำกับภาษี"
                ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 3 Then
                    data_print(1)
                    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_RVC1001_2PAGE.RPT")
                    rpt4.SetDataSource(dtv_rpt)
                    Header_txt = "ใบเสร็จรับเงิน"
                ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 4 Then 'ใบเสร็จรับเงิน พิมพ์ 2 หน้า แบบ ต้นฉบับ ,สำเนา
                    data_print(2)
                    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_RVC1001_2PAGE.RPT")
                    rpt4.SetDataSource(dtv_rpt)
                    Header_txt = "ใบเสร็จรับเงิน"
                ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 5 Then
                    data_print(1)
                    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_RVC1001_2PAGE.RPT")
                    rpt4.SetDataSource(dtv_rpt)
                    Header_txt = "ใบเสร็จรับเงิน/ใบกำกับภาษี"
                ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 6 Then 'ใบเสร็จรับเงิน พิมพ์ 2 หน้า แบบ ต้นฉบับ ,สำเนา
                    data_print(2)
                    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_RVC1001_2PAGE.RPT")
                    rpt4.SetDataSource(dtv_rpt)
                    Header_txt = "ใบเสร็จรับเงิน/ใบกำกับภาษี"

                    'ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 8 Then 'ใบส่งของ / ใบกำกับภาษี สำหรับเพิ่มเติมให้ลูกค้า custom1
                    '    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    '    rpt4.Load(Application.StartupPath & "\Rpt\DOC_INV1001_CUSTOM1.RPT")
                    '    rpt4.SetDataSource(dtv_rpt)
                    '    Header_txt = "ใบส่งสินค้า"

                    'ป.ประยุทธการช่าง จำกัด 4 สำเนา
                    'เฉพาะลูกค้า บ.เอส.เอส.ดับเบิลยู ฟู๊ด ขอเป็น 3 สำเนา
                    'บริษัท ทรัพย์บูรณนันท์ออยล์ จำกัด 2 สำเนา
                    'ห้างหุ้นส่วนจำกัด นราทิพย์เรสเตอรองท์ กระดาษ A4 ให้พิมพ์ ต้นฉบับสำเนา
                    'dtv_rpt = DATA_RPT.Tables("DOC_DUP").AsDataView 'ดีดี การ์เด้น โฮม รีสอร์ท ที่พะเยา

                ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 8 Then 'ใบส่งของ / ใบกำกับภาษี สำหรับเพิ่มเติมให้ลูกค้า custom1
                    'ลูกค้าขอเงินคืน ทำการยกเลิก เนื่องจากให้แก้ไข ฟอร์ม ด่วน เพิ่มหลายเงื่อนไข
                    'If CompanyRegno = "0643553000788" Then
                    '    data_print(6) 'เพิ่มพูล โทนเนอร์ (2010)
                    'Else
                    '    data_print(1)
                    '    'data_print(2) 'ลูกค้าใหม่
                    'End If

                    data_print(1)
                    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_INV1001_CUSTOM1.RPT")
                    rpt4.SetDataSource(dtv_rpt)
                    Header_txt = "ใบเสร็จรับเงิน/ใบกำกับภาษี"
                ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 9 Then 'ใบส่งของ / ใบกำกับภาษี สำหรับเพิ่มเติมให้ลูกค้า custom2
                    data_print(1)
                    'data_print(2) 'ลูกค้าใหม่
                    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_INV1001_CUSTOM2.RPT")
                    rpt4.SetDataSource(dtv_rpt)
                    Header_txt = "ใบส่งสินค้า/ใบกำกับภาษี"
                    'เฉพาะลูกค้า พูลทรัพย์ แถมฟอร์ม 4 ฟอร์ม
                    'ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 10 Then 'ใบส่งของ / ใบกำกับภาษี สำหรับเพิ่มเติมให้ลูกค้า custom3
                    'data_print(1)
                    '    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    '    rpt4.Load(Application.StartupPath & "\Rpt\DOC_INV1001_CUSTOM3.RPT")
                    '    rpt4.SetDataSource(dtv_rpt)
                    '    Header_txt = "ใบส่งสินค้า/ใบกำกับภาษี"
                    'ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 11 Then 'ใบส่งของ / ใบกำกับภาษี สำหรับเพิ่มเติมให้ลูกค้า custom4
                    'data_print(1)
                    '    dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                    '    rpt4.Load(Application.StartupPath & "\Rpt\DOC_INV1001_CUSTOM4.RPT")
                    '    rpt4.SetDataSource(dtv_rpt)
                    '    Header_txt = "ใบส่งสินค้า/ใบกำกับภาษี"
                End If

                'กำหนดเครื่องพิมพ์เอง
                Dim printer_str As String = ReadIni(File_ini, "DATABASE", "PRINTER", "") 'ดึงชื่อ Printer จาก ini
                Dim printer_paper As String = ReadIni(File_ini, "DATABASE", "PAPER", "")

                'default printer ,paper size
                If Drawing.Printing.PrinterSettings.InstalledPrinters.OfType(Of String)().Any(Function(s) s.Equals(printer_str)) Then 'ตรวจสอบว่ามี Printer นี้ ป้องกัน Error
                    rpt4.PrintOptions.PrinterName = printer_str
                End If

                If doctype_table.Rows(0).Item("DT_PRINT_TY") >= 1 And doctype_table.Rows(0).Item("DT_PRINT_TY") <= 6 Then 'กำหนด default paper size ให้ฟอร์มมาตรฐาน จาก ini
                    If printer_paper.Length > 0 Then
                        Dim c, rawKind As Integer
                        Dim doctoprint As New System.Drawing.Printing.PrintDocument()
                        If Drawing.Printing.PrinterSettings.InstalledPrinters.OfType(Of String)().Any(Function(s) s.Equals(printer_str)) Then
                            doctoprint.PrinterSettings.PrinterName = printer_str
                        Else
                            Dim PrinterDefault As New Drawing.Printing.PrinterSettings
                            doctoprint.PrinterSettings.PrinterName = PrinterDefault.PrinterName
                        End If
                        'find Paper size

                        For c = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
                            If doctoprint.PrinterSettings.PaperSizes(c).PaperName = printer_paper Then 'master
                                rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(c).GetType().GetField("kind", Reflection.BindingFlags.Instance Or
                                Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(c)))
                                Exit For
                            End If
                        Next
                        Dim paper_id = CType(rawKind, CrystalDecisions.Shared.PaperSize)
                        If paper_id > 0 Then
                            rpt4.PrintOptions.PaperSize = paper_id
                        End If
                    End If
                End If

                rpt4.SetParameterValue("ThaiCompanyName", ThaiCompanyName)
                rpt4.SetParameterValue("ThaiAddress1", ThaiAddress1)
                rpt4.SetParameterValue("ThaiAddress2", ThaiAddress2)
                rpt4.SetParameterValue("EngCompanyName", EngCompanyName)
                rpt4.SetParameterValue("EngAddress1", EngAddress1)
                rpt4.SetParameterValue("EngAddress2", EngAddress2)
                rpt4.SetParameterValue("CompanyPost", CompanyPost)
                rpt4.SetParameterValue("CompanyTelno", CompanyTelno)
                rpt4.SetParameterValue("CompanyFax", CompanyFax)
                rpt4.SetParameterValue("CompanyRegno", CompanyRegno)
                rpt4.SetParameterValue("image_txt", Company_logo)
                rpt4.SetParameterValue("Header_txt", Header_txt)
                rpt4.SetParameterValue("Webcompany", Webcompany)
                rpt4.SetParameterValue("Mailcompany", Mailcompany)
                If File.Exists(Company_logo) Then
                    rpt4.SetParameterValue("image_chk", "Y")
                Else
                    rpt4.SetParameterValue("image_chk", "N")
                End If
                FM4.CrystalReportViewer1.ReportSource = rpt4
                FM4.Show()
                FM4.CrystalReportViewer1.Zoom(130)

            ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 7 OrElse doctype_table.Rows(0).Item("DT_PRINT_TY") = 11 OrElse doctype_table.Rows(0).Item("DT_PRINT_TY") = 12 OrElse doctype_table.Rows(0).Item("DT_PRINT_TY") = 13 Then


                'ถ้าเลือก ty =7 กระดาษ 5.5 ให้เปิดฟอร์ม preview_new
                'ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 7 Then 'ฟอนท์ Angsana ใบส่งของ / ใบกำกับภาษี กระดาษ 8.5x5.5 ลองดู ทดสอบล่าสุด ได้แล้ว ต้องลง crystal ที่เครื่องที่ใช้ แล้วกำหนดขนาดกระดาษ ใน rpt
                data_print(1)
                dtv_rpt = DATA_RPT.Tables("DOC_RPT").AsDataView
                Dim FM4 As New preview_new

                If doctype_table.Rows(0).Item("DT_PRINT_TY") = 7 Then
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_INV1001_977.RPT")
                ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 11 Then
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_CUSTOM1_95.RPT")
                ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 12 Then
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_CUSTOM2_95.RPT")
                ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 13 Then
                    rpt4.Load(Application.StartupPath & "\Rpt\DOC_CUSTOM3_95.RPT")
                End If
                'rpt4.Load(Application.StartupPath & "\Rpt\DOC_INV1001_977.RPT")
                rpt4.SetDataSource(dtv_rpt)

                'แบบนี้ ลองดูพิมพ์แล้ว ได้
                Dim c As Integer
                Dim PrinterDefault As New Drawing.Printing.PrinterSettings 'เครื่องพิมพ์ default
                Dim doctoprint As New System.Drawing.Printing.PrintDocument()
                doctoprint.PrinterSettings.PrinterName = PrinterDefault.PrinterName
                doctoprint.OriginAtMargins = True
                doctoprint.DefaultPageSettings.Margins.Left = 0
                doctoprint.DefaultPageSettings.Margins.Right = 0
                doctoprint.DefaultPageSettings.Margins.Top = 0
                doctoprint.DefaultPageSettings.Margins.Bottom = 0
                Dim rawKind As Integer
                For c = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
                    If doctoprint.PrinterSettings.PaperSizes(c).PaperName = "8.5x5.5" Then 'master
                        'If doctoprint.PrinterSettings.PaperSizes(c).PaperName = "A555" Then
                        rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(c).GetType().GetField("kind", Reflection.BindingFlags.Instance Or
                        Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(c)))
                        Exit For
                    End If
                Next
                rpt4.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
                rpt4.PrintOptions.DissociatePageSizeAndPrinterPaperSize = False
                rpt4.PrintOptions.PaperOrientation = PaperOrientation.Portrait

                Header_txt = "ใบเสร็จรับเงิน/ใบกำกับภาษี"
                rpt4.SetParameterValue("ThaiCompanyName", ThaiCompanyName)
                rpt4.SetParameterValue("ThaiAddress1", ThaiAddress1)
                rpt4.SetParameterValue("ThaiAddress2", ThaiAddress2)
                rpt4.SetParameterValue("EngCompanyName", EngCompanyName)
                rpt4.SetParameterValue("EngAddress1", EngAddress1)
                rpt4.SetParameterValue("EngAddress2", EngAddress2)
                rpt4.SetParameterValue("CompanyPost", CompanyPost)
                rpt4.SetParameterValue("CompanyTelno", CompanyTelno)
                rpt4.SetParameterValue("CompanyFax", CompanyFax)
                rpt4.SetParameterValue("CompanyRegno", CompanyRegno)
                rpt4.SetParameterValue("image_txt", Company_logo)
                rpt4.SetParameterValue("Header_txt", Header_txt)
                rpt4.SetParameterValue("Webcompany", Webcompany)
                rpt4.SetParameterValue("Mailcompany", Mailcompany)
                If File.Exists(Company_logo) Then
                    rpt4.SetParameterValue("image_chk", "Y")
                Else
                    rpt4.SetParameterValue("image_chk", "N")
                End If

                FM4.CrystalReportViewer1.ReportSource = rpt4

                'rpt4.PrintToPrinter(1, False, 0, 0)
                FM4.print_id = 1 'ส่งค่า เพื่อให้สามารถ ดับเบิลคลิก เพื่อเลือกพิมพ์ เฉพาะฟอร์มนี้ ที่เลือกพิมพ์ตรงออกรีพอร์ท ไม่มีปุ่ม printbotton
                FM4.CrystalReportViewer1.ShowPrintButton = False 'ปิดปุ่ม print
                FM4.CrystalReportViewer1.ShowExportButton = False 'ปิดปุ่ม print
                FM4.print_strip.Enabled = True 'เลือกคลิกขวา เพื่อพิมพ์ได้ ฟอร์มอื่น ตั้ง disable ไว้
                FM4.close_strip.Enabled = True
                FM4.CrystalReportViewer1.Zoom(100) 'ยัง preview ขนาดอื่นไม่ได้

                If FM4.ShowDialog(Me) = DialogResult.OK Then
                    rpt4.PrintOptions.PrinterName = FM4.printer_guna_cmb.SelectedItem
                    Dim pmagin As New PageMargins
                    pmagin.leftMargin = 0
                    pmagin.rightMargin = 0
                    pmagin.topMargin = 0
                    pmagin.bottomMargin = 0
                    rpt4.PrintOptions.ApplyPageMargins(pmagin)

                    rpt4.PrintToPrinter(1, True, 0, 0) '0,0 คือพิมพ์ตั้งแต่หน้า - ถึง ใส่ 0 คือทุกหน้า
                End If
            End If
            End If

        'ElseIf doctype_table.Rows(0).Item("DT_PRINT_TY") = 7 Then 'ใบส่งของ / ใบกำกับภาษี ใช้ report viewer ของ microsoft
        '    Dim FM4 As New print_doc
        '    Dim rds As New ReportDataSource
        '    rds.Name = "DataSet1"
        '    rds.Value = DATA_RPT.Tables("DOC_RPT")
        '    FM4.ReportViewer1.KeepSessionAlive = True
        '    With FM4.ReportViewer1.LocalReport
        '        .DataSources.Clear()
        '        .DataSources.Add(rds)
        '        .Refresh()
        '        .SetBasePermissionsForSandboxAppDomain(New PermissionSet(PermissionState.Unrestricted))
        '    End With
        '    Dim sum_str As String = "( " & BahtText(Double.Parse(TRH_G_NETTextBox.Text)) & " )" 'แปลงเงินเป็นอักษร
        '    Dim myParam As New ReportParameter("Thaicompanyname", ThaiCompanyName)
        '    Dim myParam1 As New ReportParameter("Thaiaddress1", ThaiAddress1)
        '    Dim myParam2 As New ReportParameter("Thaiaddress2", ThaiAddress2)
        '    Dim myParam3 As New ReportParameter("Companypost", CompanyPost)
        '    Dim myParam4 As New ReportParameter("Companyregno", CompanyRegno)
        '    Dim myParam5 As New ReportParameter("Companytelno", CompanyTelno)
        '    Dim myParam6 As New ReportParameter("Companyfax", CompanyFax)
        '    Dim myParam7 As New ReportParameter("image_txt", Company_logo)
        '    Dim myParam8 As New ReportParameter("vatdate", TRH_VAT_DATEDateTimePicker.Value.Date)
        '    Dim myParam9 As New ReportParameter("sumtext", sum_str)
        '    FM4.ReportViewer1.LocalReport.SetParameters(myParam)
        '    FM4.ReportViewer1.LocalReport.SetParameters(myParam1)
        '    FM4.ReportViewer1.LocalReport.SetParameters(myParam2)
        '    FM4.ReportViewer1.LocalReport.SetParameters(myParam3)
        '    FM4.ReportViewer1.LocalReport.SetParameters(myParam4)
        '    FM4.ReportViewer1.LocalReport.SetParameters(myParam5)
        '    FM4.ReportViewer1.LocalReport.SetParameters(myParam6)
        '    FM4.ReportViewer1.LocalReport.SetParameters(myParam7)
        '    FM4.ReportViewer1.LocalReport.SetParameters(myParam8)
        '    FM4.ReportViewer1.LocalReport.SetParameters(myParam9)
        '    Dim AlmostA4 As New System.Drawing.Printing.PageSettings()
        '    AlmostA4.Margins.Left = 14
        '    AlmostA4.Margins.Right = 2
        '    AlmostA4.Margins.Top = 2
        '    AlmostA4.Margins.Bottom = 2
        '    AlmostA4.PaperSize = New System.Drawing.Printing.PaperSize("8.5x5.5", 850, 550)
        '    FM4.ReportViewer1.SetPageSettings(AlmostA4)
        '    Dim PrinterDefault As New Drawing.Printing.PrinterSettings 'เครื่องพิมพ์ default
        '    FM4.ReportViewer1.PrinterSettings.PrinterName = PrinterDefault.PrinterName
        '    FM4.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout) 'กำหนดการแสดงผล
        '    FM4.ReportViewer1.ZoomMode = ZoomMode.FullPage
        '    'FM4.ReportViewer1.ZoomMode = ZoomMode.Percent
        '    'FM4.ReportViewer1.ZoomPercent = 180

        ''วิธีนี้ก็ใช้ได้
        'Dim printerSettings As New System.Drawing.Printing.PrinterSettings()
        'Dim pSettings As New System.Drawing.Printing.PageSettings(printerSettings)
        'pSettings.PaperSize = New System.Drawing.Printing.PaperSize("newsize", 850, 550) 'custom size  hundredths (100=1 inch)
        'pSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        'rpt4.PrintOptions.DissociatePageSizeAndPrinterPaperSize = True
        'rpt4.PrintOptions.CopyFrom(printerSettings, pSettings)
        ' ''rpt4.PrintToPrinter(1, True, 0, 0)

        ''วิธีนี้ใช้ได้()
        'Dim c As Integer
        'Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        'doctoprint.PrinterSettings.PrinterName = "EPSON LQ-2090 ESC/P 2 Ver 2.0"
        'Dim rawKind As Integer
        'For c = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
        '    If doctoprint.PrinterSettings.PaperSizes(c).PaperName = "8.5x5.5" Then
        '        rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(c).GetType().GetField("kind", Reflection.BindingFlags.Instance Or _
        '        Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(c)))
        '        Exit For
        '    End If
        'Next
        'rpt4.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
        ''rpt4.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        ''rpt4.PrintToPrinter(1, True, 0, 0)
    End Sub
    Private Sub Guna_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_exit.Click
        'การยกเลิก validate ต้องกำหนดให้ button นั้นมีคุณสมบัติ  CausesValidation=false
        'ถ้ามี control อยู่ใน controller ก็ต้องตั้งที่ controler นั้น ให้ CausesValidation=false
        'เช่น button1 อยู่ใน groupbox ต้องกำหนดค่าทั้ง 2 control ด้วย
        'ยกเลิก validate หรือ e.cancel
        RemoveHandler CUS_CODE.Validated, AddressOf CUS_CODE_Validated
        'RemoveHandler TRH_DISCTextBox.Validating, AddressOf TRH_DISCTextBox_Validating
        RemoveHandler TRAN.CellValidating, AddressOf TRAN_CellValidating
        Close()
    End Sub
    Private Sub GunaControlBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaControlBox6.Click
        RemoveHandler CUS_CODE.Validated, AddressOf CUS_CODE_Validated
        'RemoveHandler TRH_DISCTextBox.Validating, AddressOf TRH_DISCTextBox_Validating
        RemoveHandler TRAN.CellValidating, AddressOf TRAN_CellValidating
        Close()
    End Sub
    Private Sub doc_record_new_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        RemoveHandler CUS_CODE.Validated, AddressOf CUS_CODE_Validated
        'RemoveHandler TRH_DISCTextBox.Validating, AddressOf TRH_DISCTextBox_Validating
        RemoveHandler TRAN.CellValidating, AddressOf TRAN_CellValidating
    End Sub
    Private Sub TAX_CMB_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TAX_CMB.SelectionChangeCommitted
        'CUS_TAX_TYTextBox.Text = TAX_CMB.SelectedIndex
    End Sub
    Private Sub cus_find_logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cus_find_logo.Click  'คลิกปุ่ม ค้นหาลูกค้า
        Dim FM4 As New customer_filter
        If FM4.ShowDialog(Me) = DialogResult.OK Then
            TRH_CUSTextBox.Text = FM4.grw.CurrentRow.Cells("CUS_ID").Value
            CUS_CODE.Text = FM4.grw.CurrentRow.Cells("CUS_CODE").Value
            RemoveHandler CUS_CODE.Validated, AddressOf CUS_CODE_Validated 'เมื่อสร้างเอกสารใหม่ จะเกิด validate ให้ ยกเลิก handle
            FIND_CUSNAME()
            AddHandler CUS_CODE.Validated, AddressOf CUS_CODE_Validated 'เรียก handle คืน
        End If
    End Sub

    Private Sub CUS_CODE_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUS_CODE.Validated  'ค้นหาวิธี validate
        Dim ljoin = (From t In customer_inv_table()
                    Where t.Field(Of String)("CUS_CODE").ToUpper = CUS_CODE.Text.ToUpper
                    )
        If ljoin.Count = 0 Then 'ถ้าไม่พบรหัส จากการ enter ให้เปิดหน้าจอค้นหา
            '    e.Cancel = True
            Dim FM4 As New customer_filter
            If FM4.ShowDialog(Me) = DialogResult.OK Then
                TRH_CUSTextBox.Text = FM4.grw.CurrentRow.Cells("CUS_ID").Value
                CUS_CODE.Text = FM4.grw.CurrentRow.Cells("CUS_CODE").Value
                FIND_CUSNAME()
            Else
                CUS_CODE.Focus()
            End If
        Else
            FIND_CUSCODE() 'แสดงรหัส ชื่อ ลูกค้า และอื่นๆ
        End If
    End Sub
    Public Sub FIND_CUSCODE() 'หาลูกค้า จากหลังค้นหา โดยวิธี validate cus_code
        Dim vat_rate As Double
        If company_table.Rows.Count > 0 Then 'ดึงอัตราภาษี
            vat_rate = company_table.Rows(0).Item("CMPN_VAT_R")
        Else
            vat_rate = 0
        End If

        Dim ljoin = (From t In customer_inv_table()
                     Where t.Field(Of String)("CUS_CODE").ToUpper = CUS_CODE.Text.ToUpper
                     )
        If ljoin.Count = 0 Then
            Exit Sub
        Else
            TRH_CUSTextBox.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_ID") 'เพิ่มฟิวด์นี้ เพื่อรองรับการค้นหา ทั้ง2แบบ แบบคีย์เอง แล้ว validate กับแบบ คลิกปุ่มค้นหา ด้วยฟอร์ม customer_filter
            CUS_NAME.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_NAME_BRANCH").ToString.Trim
            CUS_ADDB1.Text = ljoin.CopyToDataTable.Rows(0).Item("ADDRESS").ToString.Trim
            CUS_TAXID.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_TAXID").ToString
            TRH_REF_PERSONTextBox.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_CONTACT").ToString
            '    'กรณีเปลี่ยนลูกหนี้ จะดึง ส่วนลด ภาษี มาคำนวณใหม่หมด ยกเว้น อัตราภาษีทั่วไป ยังยึดค่าเดิม ต้องเปลี่ยน manaul
            If insert_status.Text = 1 Then 'กรณีเปลียนลูกค้า ที่เปิดเอกสารใหม่เท่านั้น ถึงจะส่งค่า slmn,vat,disc,term กรณีแก้ไข จะไม่ส่งค่านี้ให้ ต้อง manaul
                TRH_SLMNTextBox.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_SLMN")
                SALES_CMB.SelectedValue = TRH_SLMNTextBox.Text
                TRH_TERMTextBox.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_CREDIT_TERM") 'term จากประวัติแล้ว คำนวณใหม่
                TRH_DUEDateTimePicker.Value = cal_term(TRH_TERMTextBox.Text, TRH_DATEDateTimePicker.Value)
                TRH_DISCTextBox.Text = Format(ljoin.CopyToDataTable.Rows(0).Item("CUS_DISC_PERCEN"), "#,##0.####") 'ส่วนลด คำนวณใหม่
                'cal_b4_amt() 'คำนวณหลังหักส่วนลด
                TRH_VAT_TYTextBox.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_TAX_TY") 'วิธีคิดภาษี
                'ดึงอัตราภาษี มาแสดง เมื่อมีการเลือกลูกค้า
                If TRH_VAT_TYTextBox.Text = 0 Then
                    TRH_VAT_RTextBox.Text = vat_rate 'ดึงอัตราภาษี
                Else
                    TRH_VAT_RTextBox.Text = 0
                End If
                TRH_VATIOTextBox.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_TAX_VATIO") 'วิธีรวมราคาขาย
                cal_vat_setting() 'หาค่าภาษีจาก vat_ty 'คำนวณส่วนลด ใหม่ด้วย
                If Len(TRH_NOTextBox.Text) > 0 Then
                    TRH_DATEDateTimePicker.Select()
                Else
                    TRH_NOTextBox.Select()
                End If
            Else
                CUS_TAXID.Select()
                CUS_TAXID.SelectionStart = CUS_TAXID.SelectionLength 'ถ้าเปลี่ยนลูกค้า เอกสารที่สร้างไว้แล้ว ไม่ต้อง focus trh_no
            End If
        End If
    End Sub
    Public Sub FIND_CUSNAME() 'หาชื่อลูกค้า จากการคลิ๊กปุ่มค้นหา ด้วย form customer_filter
        Dim vat_rate As Double
        If company_table.Rows.Count > 0 Then 'ดึงอัตราภาษี
            vat_rate = company_table.Rows(0).Item("CMPN_VAT_R")
        Else
            vat_rate = 0
        End If

        Dim ljoin = (From t In customer_inv_table()
                     Where t.Field(Of String)("CUS_CODE").ToUpper = CUS_CODE.Text.ToUpper
                     )
        If ljoin.Count = 0 Then
            Exit Sub
        Else
            CUS_NAME.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_NAME_BRANCH").ToString.Trim
            CUS_ADDB1.Text = ljoin.CopyToDataTable.Rows(0).Item("ADDRESS").ToString.Trim
            CUS_TAXID.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_TAXID").ToString
            TRH_REF_PERSONTextBox.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_CONTACT").ToString
            '    'กรณีเปลี่ยนลูกหนี้ จะดึง ส่วนลด ภาษี มาคำนวณใหม่หมด ยกเว้น อัตราภาษีทั่วไป ยังยึดค่าเดิม ต้องเปลี่ยน manaul
            If insert_status.Text = 1 Then 'กรณีเปลียนลูกค้า ที่เปิดเอกสารใหม่เท่านั้น ถึงจะส่งค่า slmn,vat,disc,term กรณีแก้ไข จะไม่ส่งค่านี้ให้ ต้อง manaul
                TRH_SLMNTextBox.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_SLMN")
                SALES_CMB.SelectedValue = TRH_SLMNTextBox.Text
                TRH_TERMTextBox.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_CREDIT_TERM") 'term จากประวัติแล้ว คำนวณใหม่
                TRH_DUEDateTimePicker.Value = cal_term(TRH_TERMTextBox.Text, TRH_DATEDateTimePicker.Value)
                TRH_DISCTextBox.Text = Format(ljoin.CopyToDataTable.Rows(0).Item("CUS_DISC_PERCEN"), "#,##0.####") 'ส่วนลด คำนวณใหม่
                'cal_b4_amt() 'คำนวณหลังหักส่วนลด
                TRH_VAT_TYTextBox.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_TAX_TY") 'วิธีคิดภาษี
                'ดึงอัตราภาษี มาแสดง เมื่อมีการเลือกลูกค้า
                If TRH_VAT_TYTextBox.Text = 0 Then
                    TRH_VAT_RTextBox.Text = vat_rate 'ดึงอัตราภาษี
                Else
                    TRH_VAT_RTextBox.Text = 0
                End If
                TRH_VATIOTextBox.Text = ljoin.CopyToDataTable.Rows(0).Item("CUS_TAX_VATIO") 'วิธีรวมราคาขาย
                cal_vat_setting() 'หาค่าภาษีจาก vat_ty 'คำนวณส่วนลด ใหม่ด้วย
                'TRH_NOTextBox.Focus()
                If Len(TRH_NOTextBox.Text) > 0 Then
                    TRH_DATEDateTimePicker.Select()
                Else
                    TRH_NOTextBox.Select()
                End If
            Else
                CUS_TAXID.Select()
                CUS_TAXID.SelectionStart = CUS_TAXID.SelectionLength 'ถ้าเปลี่ยนลูกค้า เอกสารที่สร้างไว้แล้ว ไม่ต้อง focus trh_no
            End If
        End If
    End Sub
    Private Sub FIND_TRH_CUS() 'อ้างชื่อลูกค้า ตอนเปิดเอกสารที่สร้างไว้แล้ว
        Dim cus As New DataView(customer_inv_table)
        If cus IsNot Nothing Then
            'If Not String.IsNullOrEmpty(TRH_IDTextBox.Text) Then 'ป้องกันกรณี สร้างใหม่   error
            cus.RowFilter = "[CUS_ID] = " & Integer.Parse(TRH_CUSTextBox.Text)
            'End If
            If cus.Count > 0 Then
                CUS_CODE.Text = cus.Item(0).Row("CUS_CODE")
                CUS_NAME.Text = cus.Item(0).Row("CUS_NAME_BRANCH").ToString
                CUS_ADDB1.Text = cus.Item(0).Row("ADDRESS").ToString.Trim
                CUS_TAXID.Text = cus.Item(0).Row("CUS_TAXID").ToString
            Else
                MsgBox("ไม่พบรหัสลูกค้า", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            End If
        Else
            MsgBox("ไม่พบรหัสลูกค้า", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
        End If
    End Sub
    Private Sub TRH_DATEDateTimePicker_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TRH_DATEDateTimePicker.Validating
        TRH_DUEDateTimePicker.Value = cal_term(TRH_TERMTextBox.Text, TRH_DATEDateTimePicker.Value)
    End Sub
    Private Sub TRH_TERMTextBox_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRH_TERMTextBox.Validated
        TRH_DUEDateTimePicker.Value = cal_term(TRH_TERMTextBox.Text, TRH_DATEDateTimePicker.Value)
    End Sub
    Private Sub TRH_VAT_RTextBox_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRH_VAT_RTextBox.Validated
        call_skuchange_trd()
    End Sub
    Private Sub TRH_DISCTextBox_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRH_DISCTextBox.Validated, TRH_G_KEYINTextBox.Validated
        'call_skuchange_trd()
    End Sub
    Private Sub lb_creatsub_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lb_creatsub.LinkClicked
        CREATE_SUB()
    End Sub

    Private Sub gen_key() 'สร้าง autokey เอง
        DATA_GEN.Clear()
        Dim sql_g As String = "SELECT TOP 1"
        sql_g &= " TRH_ID"
        sql_g &= " FROM TRANMAIN"
        sql_g &= " ORDER BY TRH_ID DESC"
        Dim cmd_g As New SqlCommand(sql_g, cnn_sql_main)
        Dim adapter_g As New SqlDataAdapter(cmd_g)
        adapter_g.Fill(DATA_GEN, "DOC_GEN")

        Dim strIDAcc As Integer
        If DATA_GEN.Tables("DOC_GEN").Rows.Count > 0 Then
            Dim eid As Integer
            eid = DATA_GEN.Tables("DOC_GEN").Rows(0).Item("TRH_ID")
            strIDAcc = CInt(eid) + 1
        Else
            strIDAcc = 1
        End If
        TRH_IDTextBox.Text = strIDAcc
    End Sub
    Private Sub sub_id() 'เติม key อ้างอิง ก่อน save กรณีสร้างใหม่
        For Each row3 As DataGridViewRow In TRAN.Rows
            row3.Cells("TRD_TRH").Value = Integer.Parse(TRH_IDTextBox.Text)
        Next
    End Sub

    Private Sub SALES_CMB_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALES_CMB.SelectionChangeCommitted
        TRH_SLMNTextBox.Text = SALES_CMB.SelectedValue 'ใช้วิธีนี้ช่วย ป้องกันกรณี สร้างเอกสารใหม่ มีการอ้างอิง slmn_id จาก customer ที่ไม่มีใน salesman
    End Sub

    Private Sub call_skuchange_trd() 'คำนวณใหม่ เมื่อแก้ไขท้ายบิล ส่วนลด,ภาษี
        Dim item_1 As Integer = 0 : Dim qty_1 As Double = 0.0 : Dim g_sell As Double = 0.0 : Dim g_sv As Double = 0.0 : Dim g_snv As Double = 0.0 : Dim g_vat As Double = 0.0 : Dim g_amt As Double = 0.0
        Dim trd_keyin, trd_disc_key, trd_after_disc, trd_tdisc, trd_after_tdisc As Decimal
        Dim trd_gkeyin_sum As Decimal
        Dim trd_g_sell, trd_g_vat, trd_g_amt As Decimal
        'วนลูป รายการสินค้าทั้งหมด
        For Each row3 As DataGridViewRow In TRAN.Rows
            trd_keyin = row3.Cells("TRD_QTY").Value * row3.Cells("TRD_UPC").Value
            'trd_disc_key = my_discount(trd_keyin, row3.Cells("TRD_DISC").Value)
            trd_disc_key = Format(disc_multi(trd_keyin, row3.Cells("TRD_DISC_STR").Value.ToString), "N2") 'ส่วนลดรายการสินค้า วิธีใหม่
            'trd_after_disc = my_after_discount(trd_keyin, row3.Cells("TRD_DISC").Value)
            trd_after_disc = (trd_keyin - trd_disc_key) 'ยอดหลังส่วนลดรายการสินค้า วิธีใหม่
            row3.Cells("TRD_DISC_AMT").Value = trd_disc_key
            row3.Cells("TRD_G_KEYIN").Value = trd_after_disc
            trd_gkeyin_sum += trd_after_disc 'หายอดรวมท้ายบิลใหม่ เพื่อนำยอดลดท้ายบิลมาเฉลี่ยหารกลับ รายการสินค้า
        Next
        TRH_G_KEYINTextBox.Text = Math.Round(trd_gkeyin_sum, 2, MidpointRounding.AwayFromZero).ToString("N2")
        DISC_STR_BOTTOM() 'เรียก % รวมท้ายบิล และคำนวณยอดลด ท้ายบิลใหม่ เนื่องจากมีมูลค่าในรายการสินค้า มีการแก้ไข ทำให้ยอดรวมเปลี่ยน ส่วนลดท้ายบิล จึงต้องคำนวณใหม่

        Dim g_sell_sum As Decimal
        g_sell_sum = Decimal.Parse(TRH_G_KEYINTextBox.Text) - Decimal.Parse(TRH_DISC_AMTTextBox.Text) 'ยอดรวม หักส่วนลดท้ายบิล

        If TRAN.Rows.Count > 0 And trd_check_vatstep(TRAN, Double.Parse(TRH_VAT_RTextBox.Text)) = 0 Then 'ถ้ามีมากกว่ารายการเดียว และ ถ้าตรวจสอบว่า อัตราภาษีในทุกรายการสินค้า เท่ากับอัตราภาษีท้ายบิล 
            'ถ้าอัตรา vat ทุกรายการ เท่ากับอัตราของบิล ให้คำนวณยอดท้ายบิล ไปเลย
            g_sell = my_b4vat(Integer.Parse(TRH_VATIOTextBox.Text), Decimal.Parse(TRH_VAT_RTextBox.Text), g_sell_sum) 'เก็บยอดท้ายบิล
            g_vat = my_vat(Integer.Parse(TRH_VATIOTextBox.Text), Decimal.Parse(TRH_VAT_RTextBox.Text), g_sell_sum)
            g_amt = my_amt(Integer.Parse(TRH_VATIOTextBox.Text), Decimal.Parse(TRH_VAT_RTextBox.Text), g_sell_sum)

            For Each row4 As DataGridViewRow In TRAN.Rows 'ลูปอีกรอบ เพื่อคำนวณเฉลี่ยลดท้ายบิล
                Dim disc_no_last As Decimal 'ส่วนลดสะสม
                Dim b4vat_no_last As Decimal 'ก่อนภาษีสะสม
                Dim vat_no_last As Decimal 'ภาษีสะสม
                Dim amt_no_last As Decimal 'สุทธิสะสม
                If row4.Index <> TRAN.Rows.Count - 1 Then 'ถ้าไม่ใช่รายการสุดท้าย
                    trd_tdisc = my_discount(row4.Cells("TRD_G_KEYIN").Value, Double.Parse(TRH_DISCTextBox.Text)) 'ส่วนลดท้ายบิล
                    trd_after_tdisc = row4.Cells("TRD_G_KEYIN").Value - trd_tdisc 'หักส่วนลดท้ายบิล
                    If TRH_VAT_TYTextBox.Text = 0 Then 'ถ้าภาษีในเอกสารเป็น อัตราทั่วไป
                        trd_g_sell = my_b4vat(TRH_VATIOTextBox.Text, row4.Cells("TRD_VAT_R").Value, trd_after_tdisc)
                        trd_g_vat = my_vat(TRH_VATIOTextBox.Text, row4.Cells("TRD_VAT_R").Value, trd_after_tdisc)
                        trd_g_amt = my_amt(TRH_VATIOTextBox.Text, row4.Cells("TRD_VAT_R").Value, trd_after_tdisc)
                    Else
                        trd_g_sell = my_b4vat(TRH_VATIOTextBox.Text, 0, trd_after_tdisc)
                        trd_g_vat = my_vat(TRH_VATIOTextBox.Text, 0, trd_after_tdisc)
                        trd_g_amt = my_amt(TRH_VATIOTextBox.Text, 0, trd_after_tdisc)
                    End If

                    disc_no_last += trd_tdisc 'ยอดลดสะสม
                    b4vat_no_last += trd_g_sell 'ยอดก่อนภาษีสะสม
                    vat_no_last += trd_g_vat 'ยอดภาษีสะสม
                    amt_no_last += trd_g_amt 'ยอดสุทธิสะสม
                Else 'ถ้าเป็นรายการสุดท้าย หัดเอา ยอดลดท้ายบิล ลบกับ ยอดลด สะสม รายการก่อนนี้
                    trd_tdisc = Double.Parse(TRH_DISC_AMTTextBox.Text) - disc_no_last
                    trd_after_tdisc = row4.Cells("TRD_G_KEYIN").Value - trd_tdisc
                    trd_g_sell = g_sell - b4vat_no_last
                    trd_g_vat = g_vat - vat_no_last
                    trd_g_amt = g_amt - amt_no_last
                End If
                row4.Cells("TRD_TDISC_AMT").Value = trd_tdisc
                row4.Cells("TRD_G_SELL").Value = trd_g_sell
                row4.Cells("TRD_G_VAT").Value = trd_g_vat
                row4.Cells("TRD_G_AMT").Value = trd_g_amt
                item_1 += 1
                qty_1 += row4.Cells("TRD_QTY").Value
                'แยกมูลค่าสินค้า คิด,ไม่คิดภาษี
                If row4.Cells("TRD_VAT_TY").Value = 1 Then 'ประเภทสินค้ายกเว้นภาษี
                    g_snv += trd_g_sell 'สินค้ายกเว้น
                    g_sv += 0
                Else
                    g_snv += 0
                    g_sv += trd_g_sell 'สินค้าคิดภาษี
                End If
            Next
        Else 'ถ้ามีรายการเดียว หรือหลายรายการ แต่ประเภทภาษี คนละอัตรา
            For Each row4 As DataGridViewRow In TRAN.Rows 'ลูปอีกรอบ เพื่อคำนวณเฉลี่ยลดท้ายบิล
                trd_tdisc = my_discount(row4.Cells("TRD_G_KEYIN").Value, Double.Parse(TRH_DISCTextBox.Text)) 'ส่วนลดท้ายบิล
                trd_after_tdisc = row4.Cells("TRD_G_KEYIN").Value - trd_tdisc 'หักส่วนลดท้ายบิล
                If TRH_VAT_TYTextBox.Text = 0 Then 'ถ้าภาษีในเอกสารเป็น อัตราทั่วไป
                    trd_g_sell = my_b4vat(TRH_VATIOTextBox.Text, row4.Cells("TRD_VAT_R").Value, trd_after_tdisc)
                    trd_g_vat = my_vat(TRH_VATIOTextBox.Text, row4.Cells("TRD_VAT_R").Value, trd_after_tdisc)
                    trd_g_amt = my_amt(TRH_VATIOTextBox.Text, row4.Cells("TRD_VAT_R").Value, trd_after_tdisc)
                Else
                    trd_g_sell = my_b4vat(TRH_VATIOTextBox.Text, 0, trd_after_tdisc)
                    trd_g_vat = my_vat(TRH_VATIOTextBox.Text, 0, trd_after_tdisc)
                    trd_g_amt = my_amt(TRH_VATIOTextBox.Text, 0, trd_after_tdisc)
                End If

                row4.Cells("TRD_TDISC_AMT").Value = trd_tdisc
                row4.Cells("TRD_G_SELL").Value = trd_g_sell
                row4.Cells("TRD_G_VAT").Value = trd_g_vat
                row4.Cells("TRD_G_AMT").Value = trd_g_amt
                item_1 += 1
                qty_1 += row4.Cells("TRD_QTY").Value
                g_sell += trd_g_sell
                g_vat += trd_g_vat
                g_amt += trd_g_amt
                'แยกมูลค่าสินค้า คิด,ไม่คิดภาษี
                If row4.Cells("TRD_VAT_TY").Value = 1 Then 'ประเภทสินค้ายกเว้นภาษี
                    g_snv += trd_g_sell 'สินค้ายกเว้น
                    g_sv += 0
                Else
                    g_snv += 0
                    g_sv += trd_g_sell 'สินค้าคิดภาษี
                End If
            Next
        End If
        TRH_N_ITEMSTextBox.Text = item_1
        TRH_N_QTYTextBox.Text = qty_1
        TRH_G_SELLTextBox.Text = Math.Round(g_sell, 2, MidpointRounding.AwayFromZero).ToString("N2") 'มูลค่าหลังหักลดท้ายบิล
        TRH_G_SVTextBox.Text = Math.Round(g_sv, 2, MidpointRounding.AwayFromZero).ToString("N2") 'มูลค่าสินค้าคิดภาษี
        TRH_G_SNVTextBox.Text = Math.Round(g_snv, 2, MidpointRounding.AwayFromZero).ToString("N2") 'มูลค่าสินค้ายกเว้นภาษี
        TRH_G_VATTextBox.Text = Math.Round(g_vat, 2, MidpointRounding.AwayFromZero).ToString("N2") 'มูลค่าภาษี
        TRH_G_NETTextBox.Text = Math.Round(g_amt, 2, MidpointRounding.AwayFromZero).ToString("N2") 'มูลค่าสุทธิ
        cal_label() 'แสดงจำนวนรายการ ท้ายฟอร์ม
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles find_product_strip.Click
        If TRAN.SelectedCells.Count > 0 Then 'ต้องมีการคลิกเลือก cell หรือ row ก่อน เพราะต้องคืนค่า รหัสสินค้า มาที่ row ปัจจุบัน
            Dim FM4 As New product_filter
            If FM4.ShowDialog(Me) = DialogResult.OK Then
                TRAN.Focus() 'focus ที่ datagrid ก่อน ป้องกัน focus ที่ trh_no
                '/////แบบใหม่
                TRAN.EndEdit() 'endedit ก่อน
                TRAN.CurrentRow.Cells("TRD_SKU").Value = FM4.grw.CurrentRow.Cells("PRO_ID").Value
                TRAN.CurrentRow.Cells("TRD_SKU_CODE").Value = FM4.grw.CurrentRow.Cells("PRO_CODE").Value.ToString
                TRAN.CurrentRow.Cells("TRD_SKU_NAME").Value = FM4.grw.CurrentRow.Cells("PRO_NAME").Value.ToString
                TRAN.CurrentRow.Cells("TRD_UNIT").Value = FM4.grw.CurrentRow.Cells("PRO_UNIT").Value.ToString
                TRAN.CurrentRow.Cells("TRD_UPC").Value = FM4.grw.CurrentRow.Cells("PRO_PRICE").Value 'ถ้าเลือก จะดึงราคาใหม่
                TRAN.CurrentRow.Cells("TRD_VAT_TY").Value = FM4.grw.CurrentRow.Cells("PRO_VAT_TY").Value
                TRAN.CurrentRow.Cells("TRD_VAT_R").Value = FM4.grw.CurrentRow.Cells("PRO_VAT_R").Value
                '///////
                TRAN.CurrentCell = TRAN.CurrentRow.Cells("TRD_QTY")
                call_skuchange_trd()
            End If
        Else
            MsgBox("กรุณาคลิกเลือกแถวรายการ ที่ต้องการบันทึก", MsgBoxStyle.Information, "Result")
        End If
    End Sub
    Private Sub TRAN_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TRAN.CellClick
        If e.RowIndex > -1 Then
            If TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "sku_find" And e.ColumnIndex > -1 Then 'ป้องการเลือก rowheader แล้วเปิดฟอร์ม
                Dim FM4 As New product_filter
                If FM4.ShowDialog(Me) = DialogResult.OK Then
                    TRAN.Focus() 'focus ที่ datagrid ก่อน ป้องกัน focus ที่ trh_no
                    'ไม่ต้องดึงค่าจาก product_filter เพราะใช้ event ของ cellvalidating
                    '/////แบบใหม่
                    TRAN.EndEdit() 'endedit ก่อน
                    TRAN.CurrentRow.Cells("TRD_SKU").Value = FM4.grw.CurrentRow.Cells("PRO_ID").Value
                    TRAN.CurrentRow.Cells("TRD_SKU_CODE").Value = FM4.grw.CurrentRow.Cells("PRO_CODE").Value.ToString
                    TRAN.CurrentRow.Cells("TRD_SKU_NAME").Value = FM4.grw.CurrentRow.Cells("PRO_NAME").Value.ToString
                    TRAN.CurrentRow.Cells("TRD_UNIT").Value = FM4.grw.CurrentRow.Cells("PRO_UNIT").Value.ToString
                    TRAN.CurrentRow.Cells("TRD_UPC").Value = FM4.grw.CurrentRow.Cells("PRO_PRICE").Value 'ถ้าเลือก จะดึงราคาใหม่
                    TRAN.CurrentRow.Cells("TRD_VAT_TY").Value = FM4.grw.CurrentRow.Cells("PRO_VAT_TY").Value
                    TRAN.CurrentRow.Cells("TRD_VAT_R").Value = FM4.grw.CurrentRow.Cells("PRO_VAT_R").Value
                    '///////
                    TRAN.CurrentCell = TRAN.Rows(e.RowIndex).Cells("TRD_QTY")
                    call_skuchange_trd()
                    'ทดสอบ ReadOnly รหัสสินค้า "0" '
                    If TRAN.CurrentRow.Cells("TRD_SKU_CODE").Value = "0" Then
                        TRAN.CurrentRow.Cells("TRD_SKU_NAME").ReadOnly = False
                    Else
                        TRAN.CurrentRow.Cells("TRD_SKU_NAME").ReadOnly = True
                    End If
                    '===================================
                End If
        End If
        End If
    End Sub
    Private Sub TRAN_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles TRAN.CellValidating
        'MsgBox("cellvalidating")
        If TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_SKU_CODE" Then 'e.FormattedValue. ไม่ใช่ cellvalue คือค่าที่ คีย์ปัจจุบัน keydown
            Dim ljoin_product = (From t In product_table()
                     Where t.Field(Of String)("PRO_CODE").Trim.ToUpper = e.FormattedValue.ToString.Trim.ToUpper
                       )
            If ljoin_product.Count = 0 Then
                e.Cancel = True
                Guna_save.Enabled = False 'ป้องกันการกดบันทึก ขณะที่ไม่พบรายการสินค้า ให้ disable ปุ่ม Save
                'ถ้าไม่พบรหัส จากการ enter ให้เปิดหน้าจอค้นหา
                AddHandler TRAN.EditingControlShowing, AddressOf TRAN_EditingControlShowing
                Dim FM4 As New product_filter
                If FM4.ShowDialog(Me) = DialogResult.OK Then
                    TRAN.Focus() 'focus ที่ datagrid ก่อน ป้องกัน focus ที่ trh_no
                    '/////แบบใหม่
                    TRAN.EndEdit() 'endedit ก่อน
                    TRAN.Rows.Item(e.RowIndex).Cells("TRD_SKU").Value = FM4.grw.CurrentRow.Cells("PRO_ID").Value
                    TRAN.Rows.Item(e.RowIndex).Cells("TRD_SKU_CODE").Value = FM4.grw.CurrentRow.Cells("PRO_CODE").Value.ToString
                    TRAN.Rows.Item(e.RowIndex).Cells("TRD_SKU_NAME").Value = FM4.grw.CurrentRow.Cells("PRO_NAME").Value.ToString
                    TRAN.Rows.Item(e.RowIndex).Cells("TRD_UNIT").Value = FM4.grw.CurrentRow.Cells("PRO_UNIT").Value.ToString
                    TRAN.Rows.Item(e.RowIndex).Cells("TRD_UPC").Value = FM4.grw.CurrentRow.Cells("PRO_PRICE").Value 'ถ้าเลือก จะดึงราคาใหม่
                    TRAN.Rows.Item(e.RowIndex).Cells("TRD_VAT_TY").Value = FM4.grw.CurrentRow.Cells("PRO_VAT_TY").Value
                    TRAN.Rows.Item(e.RowIndex).Cells("TRD_VAT_R").Value = FM4.grw.CurrentRow.Cells("PRO_VAT_R").Value
                    '///////
                    TRAN.CurrentCell = TRAN.Rows(e.RowIndex).Cells("TRD_QTY")
                    call_skuchange_trd()

                    'ทดสอบ ReadOnly รหัสสินค้า "0" '
                    If TRAN.CurrentRow.Cells("TRD_SKU_CODE").Value = "0" Then
                        TRAN.CurrentRow.Cells("TRD_SKU_NAME").ReadOnly = False
                    Else
                        TRAN.CurrentRow.Cells("TRD_SKU_NAME").ReadOnly = True
                    End If
                    '===================================
                End If
            Else
                'ดัก e.cancel อย่างเดียว การคีย์ด้วยรหัสสินค้า ให้ค้นหาด้วย event Cellparseing
                'RemoveHandler TRAN.EditingControlShowing, AddressOf TRAN_EditingControlShowing 'แบบเดิม
                'cellenter_check = 1
                Guna_save.Enabled = True 'ถ้าพบรายการสินค้า ให้ Enable ปุ่ม Save ถ้า escape ยกเลิกรายการ หรือ key รหัสเอง ให้เลื่อนปุ่ม ไป cell อื่น เพื่อ validate ก่อน
                Exit Sub
            End If
        ElseIf TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_QTY" Then
            If IsNumeric(e.FormattedValue) = False Then
                MsgBox("ชนิดข้อมูล ต้องเป็นตัวเลข", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                e.Cancel = True
                TRAN.CancelEdit() 'undo ค่าเดิม
            Else
                If e.FormattedValue <= 0 Then
                    MsgBox("จำนวนต้องมากกว่า 0", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                    e.Cancel = True
                    TRAN.CancelEdit()
                End If
            End If
        ElseIf TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_UPC" Then
            If IsNumeric(e.FormattedValue) = False Then
                MsgBox("ชนิดข้อมูล ต้องเป็นตัวเลข", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                e.Cancel = True
                TRAN.CancelEdit()
            Else
                If e.FormattedValue < 0 Then
                    MsgBox("จำนวนน้อยกว่า 0", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                    e.Cancel = True
                    TRAN.CancelEdit()
                End If
            End If
        ElseIf TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_DISC" Then
            If IsNumeric(e.FormattedValue) = False Then
                MsgBox("ชนิดข้อมูล ต้องเป็นตัวเลข", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                e.Cancel = True
                TRAN.CancelEdit()
            Else
                If e.FormattedValue < 0 Then
                    MsgBox("จำนวนน้อยกว่า 0", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                    e.Cancel = True
                    TRAN.CancelEdit()
                ElseIf e.FormattedValue > 100 Then 'ส่วนลดเกิน 100% ไม่ได้
                    MsgBox("ส่วนลดเกิน 100 %", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                    e.Cancel = True
                    TRAN.CancelEdit()
                End If
            End If
        End If
    End Sub
    Private Sub TRAN_CellParsing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellParsingEventArgs) Handles TRAN.CellParsing
        ''ตรวจสอบว่ามีการแก้ไขรหัสก่อน วิธี parsing ถ้าแก้ไขด้วย การคีย์รหัสเดิม จะยังคง parsing
        'เมื่อค้นหาสินค้า หรือ validating แล้ว จะเกิด event cellparsing ใช้ในการ ดึงชื่อสินค้ ราคา ประเภทภาษี อัตรา
        If e.Value = trd_code_check Then 'นำค่าจาก cellbegin (ค่ารหัสสินค้าเดิม ก่อนคีย์เปลี่ยนแปลง) ว่าได้แก้ไขหรือไม่
            'MsgBox("ไม่มีการแก้ไขใดๆ") 'ไม่ต้องทำอะไร ออกจาก sub ไปเลย
            Exit Sub
        End If
        If TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_SKU_CODE" Then
            Dim ljoin_product = (From t In product_table()
                     Where t.Field(Of String)("PRO_CODE").Trim.ToUpper = e.Value.ToString.Trim.ToUpper
        Select
          PRO_ID = t("PRO_ID"),
          PRO_CODE = t.Field(Of String)("PRO_CODE"),
          PRO_NAME = t.Field(Of String)("PRO_NAME"),
          PRO_UNIT = t.Field(Of String)("PRO_UNIT"),
          PRO_PRICE = t.Field(Of Decimal)("PRO_PRICE"),
          PRO_VAT_TY = t.Field(Of Byte)("PRO_VAT_TY"),
          PRO_VAT_R = IIf(t.Field(Of Byte)("PRO_VAT_TY") = 0, vat_r, t.Field(Of Decimal)("PRO_VAT_R"))
           )
            'ถ้าชนิดภาษีเป็นอัตราทั่วไป ให้ดึงภาษีจากการตั้งค่า =vat_r จากตั้งค่าใน company เผื่อกรณี กฏหมายเปลี่ยนอัตราภาษี จะได้ไม่ต้องมาไล่แก้ ในประวัติสินค้า
            If ljoin_product.Count = 0 Then
                Exit Sub
            Else
                TRAN.CurrentRow.Cells("TRD_SKU").Value = EQToDataTable(ljoin_product).Rows(0).Item("PRO_ID")
                TRAN.CurrentRow.Cells("TRD_SKU_CODE").Value = EQToDataTable(ljoin_product).Rows(0).Item("PRO_CODE").ToString
                TRAN.CurrentRow.Cells("TRD_SKU_NAME").Value = EQToDataTable(ljoin_product).Rows(0).Item("PRO_NAME").ToString
                TRAN.CurrentRow.Cells("TRD_UNIT").Value = EQToDataTable(ljoin_product).Rows(0).Item("PRO_UNIT").ToString
                TRAN.CurrentRow.Cells("TRD_UPC").Value = EQToDataTable(ljoin_product).Rows(0).Item("PRO_PRICE") 'ถ้าแก้ไขรหัส จะดึงราคาใหม่
                TRAN.CurrentRow.Cells("TRD_VAT_TY").Value = EQToDataTable(ljoin_product).Rows(0).Item("PRO_VAT_TY")
                TRAN.CurrentRow.Cells("TRD_VAT_R").Value = EQToDataTable(ljoin_product).Rows(0).Item("PRO_VAT_R")
                'ทดสอบ ReadOnly รหัสสินค้า "0" '
                If TRAN.CurrentRow.Cells("TRD_SKU_CODE").Value = "0" Then
                    TRAN.CurrentRow.Cells("TRD_SKU_NAME").ReadOnly = False
                Else
                    TRAN.CurrentRow.Cells("TRD_SKU_NAME").ReadOnly = True
                End If
                '===================================

                'call_skuchange() 'คำนวณยอด ใหม่
                call_skuchange_trd()
            End If
        End If
    End Sub
    Private Sub TRAN_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TRAN.CellEndEdit
        'ตรวจการเพิ่มหรือแก้ไขรหัสสินค้า ใช้ cellparsing ดีกว่า endedit
        'ใช้สำหรับ กรณีแก้ไข จำนวน ราคา ส่วนลด ในรายการสินค้า
        If TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_QTY" OrElse
            TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_DISC" OrElse
            TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_DISC_STR" OrElse
            TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_UPC" Then
            call_skuchange_trd()
        End If
    End Sub
    Private Sub TRAN_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TRAN.CellDoubleClick
        If e.RowIndex > -1 Then
            Dim FM4 As New trd_remark_dialog
            FM4.items_remark.Text = TRAN.Rows(e.RowIndex).Cells("TRD_REMARK").Value.ToString
            FM4.items_remark.SelectionStart = FM4.items_remark.TextLength
            If FM4.ShowDialog(Me) = DialogResult.OK Then
                TRAN.Focus() 'focus ที่ datagrid ก่อน ป้องกัน focus ที่ trh_no
                TRAN.Rows(e.RowIndex).Cells("TRD_REMARK").Value = FM4.items_remark.Text
            End If
        End If
    End Sub
    Private Sub TRANDETAILDataGridView_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles TRAN.CellBeginEdit
        'ตรวจสอบการแก้ไขรหัส ก่อน ใช้วิธี parsing
        If TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_SKU_CODE" Then
            trd_code_check = TRAN.CurrentCell.Value.ToString 'ใส่ tostring กัน error เมื่อ add รายการใหม่
        End If
    End Sub

    Private Sub return_lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles return_lnk.LinkClicked
        TRAN.ClearSelection()
    End Sub

    Private Sub LinkLabel2_TabStopChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_creatsub.TabStopChanged
        lb_creatsub.TabStop = False
    End Sub

    Private Sub vat_lnk_TabStopChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vat_lnk.TabStopChanged
        vat_lnk.TabStop = False
    End Sub

    Private Sub TRH_DISCTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TRH_DISCTextBox.KeyPress
        e.Handled = currency_input(sender, e.KeyChar)
    End Sub

    Private Sub TRH_VAT_RTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TRH_VAT_RTextBox.KeyPress
        e.Handled = currency_input(sender, e.KeyChar)
    End Sub

    Private Sub TRH_TERMTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TRH_TERMTextBox.KeyPress
        e.Handled = integer_input(e.KeyChar)
    End Sub

    Private Sub delete_item_strip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_item_strip.Click
        If TRAN.Rows.Count > 0 Then
            TRAN.Rows.RemoveAt(TRAN.CurrentRow.Index)
            'cal() 'คำนวณท้ายบิลใหม่ เมื่อมีการลบ
            call_skuchange_trd()
        End If
    End Sub

    Private Sub TRAN_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles TRAN.UserDeletingRow
        'เตือนก่อนลบ datagridview ด้วยการกดปุ่มลบ ที่ rowheader
        'MsgBox("deleting")
        'cal()
    End Sub

    Private Sub TRAN_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TRAN.UserDeletedRow
        'หลังลบแถว ควรคำนวณ ยอดท้ายบิล ใหม่
        'cal()
        call_skuchange_trd()
    End Sub
    Private Sub doc_record_new_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        rpt4.Dispose() 'เพื่อปิด rpt ใน temp windows
    End Sub
    Private Sub TextBox_PreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
        'ใช้ sub นี้เพื่อเช็คการ enter หรือ tab ใน datagrid
        'If e.KeyCode = Keys.Tab Then 'ใช้เฉพาะวิธี tab ส่วนวิธี enter ใช้ไม่ได้ผล ให้ไปหาวิธีเช็คค่าใน endedit แทน
        '    If TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_SKU_CODE" Then
        '        TRAN.CurrentCell = TRAN.CurrentRow.Cells("TRD_QTY")
        '    End If
        'End If

        ''ใช้วิธีนี้ การใส่รหัสสินค้า แล้วกด tab เนื่องจาก ถ้าเลือกสินค้าจากตารางค้นหา จะ error
        ''ส่วนใส่รหัสสินค้า แล้วกด enter ให้ใช้ event endedit แทน
        'If e.KeyCode = Keys.Enter Then
        '    If TRAN.Columns(TRAN.CurrentCell.ColumnIndex).Name = "TRD_SKU_CODE" Then
        '        'SendKeys.Flush()
        '        'SendKeys.Send("{TAB}")
        '    End If
    End Sub

    Private Sub TRAN_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles TRAN.EditingControlShowing
        Dim tb As TextBox = CType(e.Control, TextBox)
        AddHandler tb.PreviewKeyDown, AddressOf TextBox_PreviewKeyDown
    End Sub

    Private Sub TRAN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TRAN.KeyDown
        'If e.KeyCode = Keys.Tab Or e.KeyCode = Keys.Enter Then
        '    e.SuppressKeyPress = False
        '    TRAN.CurrentRow.Cells("TRD_SKU_CODE").Selected = False
        '    TRAN.CurrentRow.Cells("TRD_SKU_NAME").Selected = False
        '    TRAN.CurrentRow.Cells("TRD_QTY").Selected = True
        '    TRAN.CurrentCell = TRAN.CurrentRow.Cells("TRD_QTY")
        '    e.Handled = True
        '    '    'TRAN.BeginEdit(False)
        'End If
    End Sub

    Private Sub TRAN_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRAN.CurrentCellDirtyStateChanged
        'Dim tb As TextBox = CType(sender.Control, TextBox)
        'AddHandler tb.PreviewKeyDown, AddressOf TextBox_PreviewKeyDown
    End Sub
    Function max_seq() 'หาค่า seq มากสุดใน datagrid แล้ว + 1 สำหรับ rows ใหม่
        Dim seq As Integer = 0
        If TRAN.Rows.Count > 0 Then
            seq = TRAN.Rows.Cast(Of DataGridViewRow)() _
            .Max(Function(row) CInt(row.Cells("TRD_SEQ").Value))
        Else
            seq = 0
        End If
        Return seq
    End Function

    Private Sub TRAN_CellMouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles TRAN.CellMouseMove
        If e.ColumnIndex = 2 Then
            TRAN.Cursor = Cursors.Hand
        Else
            TRAN.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub TRAN_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TRAN.DataError
        'If Err.Number = 0 Then
        '    MsgBox("ชนิดข้อมูล ต้องเป็นตัวเลข", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
        '    Return
        'Else
        '    MsgBox(Err.Description)
        'End If
    End Sub


    Private Sub TRH_DISCTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TRH_DISCTextBox.Validating
        'If IsNumeric(TRH_DISCTextBox.Text) = False Then 'ป้องกัน ลบเป็นค่าว่าง แล้วไปคลิกปิดหน้าจอ ไม่ได้
        '    MsgBox("ชนิดข้อมูล ต้องเป็นตัวเลข", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
        '    e.Cancel = True
        '    TRH_DISCTextBox.Focus()
        'End If
    End Sub

    Private Sub TRH_TERMTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TRH_TERMTextBox.Validating
        If IsNumeric(TRH_TERMTextBox.Text) = False Then
            MsgBox("ชนิดข้อมูล ต้องเป็นตัวเลข", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            e.Cancel = True
            TRH_TERMTextBox.Focus()
        End If
    End Sub
    Private Sub TRH_DISC_STRTextBox_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRH_DISC_STRTextBox.Validated
        'เมื่อใส่ส่วนลด str ท้ายบิล
        'TRH_DISC_AMTTextBox.Text = Format(disc_multi(Decimal.Parse(TRH_G_KEYINTextBox.Text), TRH_DISC_STRTextBox.Text), "N2") 'ใช้วิธีนี้เฉพาะส่วนลดท้ายบิล
        DISC_STR_BOTTOM() 'คำนวณยอดท้ายบิล และ % ท้ายบิล เพื่อไปคิดเฉลี่ยในรายการ
        call_skuchange_trd() 'คำนวณส่วนลดให้สินค้า แต่ละแถว ยอดลดท้ายบิล ใช้วิธี sum จาก trd_tdisc แทนการหักลบ ท้ายบิล เนื่องจากต้องใช้กับยอดก่อนภาษี ให้เป็นตัวเดียวกัน
    End Sub

    Private Sub DISC_STR_BOTTOM() 'sub สำหรับเรียกใช้ กรณีมีการแก้ไข เปลี่ยนแปลงยอดเงิน ในรายการ ต้องคำนวณยอดส่วนลดท้ายบิลใหม่
        TRH_DISC_AMTTextBox.Text = Format(disc_multi(Decimal.Parse(TRH_G_KEYINTextBox.Text), TRH_DISC_STRTextBox.Text), "N2") 'ยอดรวมส่วนลดท้ายบิล
        TRH_DISCTextBox.Text = disc_calpercen(Double.Parse(TRH_G_KEYINTextBox.Text), TRH_DISC_STRTextBox.Text) 'คำนวณยอดท้ายบิล เป็น % เพื่อไปคิดเฉลี่ยในรายการ
    End Sub
    Private Sub disc_lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles disc_lnk.LinkClicked
        Dim str As String = ""
        str &= "การบันทึกส่วนลด" & vbNewLine
        str &= "  - สามารถบันทึกได้ ทั้งแบบอัตรา % และจำนวนเงิน" & vbNewLine
        str &= "วิธีลดเปอร์เซ็น" & vbNewLine
        str &= "  - ตัวอย่าง ต้องการลด 5% ให้กรอก 5%" & vbNewLine
        str &= "วิธีลดบาท" & vbNewLine
        str &= "  - ตัวอย่าง ต้องการลด 200 บาท ให้กรอก 200" & vbNewLine
        MsgBox(str, MsgBoxStyle.Information, "แนะนำการบันทึกส่วนลด")
    End Sub

    Public Sub FIND_TRD_ROWS() 'หาแถวรายการสินค้าที่เปิด จากฟอร์มแม่ เฉพาะการเรียกจากสรุปรายละเอียดขายสินค้า
        If insert_status.Text = 0 Then
            Dim trd_find_row = (From r As DataGridViewRow In TRAN.Rows Where r.Cells("TRD_ID").Value = Integer.Parse(trd_id_lnk.Text)).ToList
            Dim trd_row As Integer = trd_find_row.Item(0).Index
            TRAN.CurrentCell = TRAN.Rows(trd_row).Cells("TRD_SEQ")
            TRAN.ClearSelection()
        End If
    End Sub

    Private Sub TRAN_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TRAN.CellEnter
        'MsgBox("ENTER")
    End Sub

    Private Sub TRAN_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TRAN.RowEnter
        'MsgBox("ENTER")
    End Sub

    Private Sub TRAN_RowValidated(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TRAN.RowValidated
        'กรณีเลื่อน มา row ใหม่
        'ทดสอบ ReadOnly รหัสสินค้า "0" '
        If IsDBNull(TRAN.CurrentRow.Cells("TRD_SKU_CODE").Value) Then
            Exit Sub
        Else
            If TRAN.CurrentRow.Cells("TRD_SKU_CODE").Value = "0" Then
                TRAN.CurrentRow.Cells("TRD_SKU_NAME").ReadOnly = False
            Else
                TRAN.CurrentRow.Cells("TRD_SKU_NAME").ReadOnly = True
            End If
        End If
        '===================================
    End Sub
    Private Sub data_dup2()
        'พิมพ์ 2 หน้า แบบ ต้นฉบับ ,สำเนา
        DATA_RPT.Clear()
        Dim sql_dup As String = "SELECT"
        sql_dup &= " TRH_ID, TRH_DT,"
        sql_dup &= " TRH_DATE, TRH_NO,"
        sql_dup &= " CUS_ID, CUS_CODE, CUS_NAME, CUS_BRANCH, CUS_TAXID,"
        sql_dup &= " LTRIM(CASE WHEN CUS_ADDB1 IS NULL THEN '' ELSE CUS_ADDB1 END + CHAR(13)+ CASE WHEN CUS_ADDB2 IS NULL THEN '' ELSE CUS_ADDB2 END) + ' ' +"
        sql_dup &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE (CASE WHEN LEN(CUS_PROVINCE)>0 THEN"
        sql_dup &= " (CASE WHEN CUS_PROVINCE LIKE 'กรุงเทพ%' OR ASCII(LEFT(CUS_PROVINCE,1))<161 THEN CUS_PROVINCE ELSE 'จ.'+CUS_PROVINCE END) ELSE '' END) END) + ' ' +" 'เฉพาะ ลค.วีที ใช้คำว่า จังหวัด
        sql_dup &= " CASE WHEN CUS_POST IS NULL THEN '' ELSE CUS_POST END AS ADDRESS,"
        sql_dup &= " CUS_TEL, CUS_FAX,"
        sql_dup &= " SLMN_ID, SLMN_CODE, SLMN_NAME,"
        sql_dup &= " TRH_VAT_NO, TRH_VAT_DATE,"
        sql_dup &= " TRH_SHIP_DATE, TRH_BILL_DATE,"
        sql_dup &= " TRH_CANCEL_DATE, TRH_CUS,"
        sql_dup &= " TRH_SLMN, TRH_TERM, TRH_DUE,"
        sql_dup &= " TRH_REF_PO, TRH_REF_SO, TRH_REF_PERSON,"
        sql_dup &= " TRH_VATIO, TRH_VAT, TRH_VAT_TY, TRH_VAT_R,"
        sql_dup &= " TRH_N_QTY, TRH_N_ITEMS,"
        sql_dup &= " TRH_G_KEYIN, TRH_DISC_STR,TRH_DISC, TRH_DISC_AMT, TRH_G_SELL,TRH_G_SNV,"
        sql_dup &= " TRH_G_SV, TRH_G_VAT, TRH_G_NET,"
        sql_dup &= " TRH_REMARK, TRH_DOC_STATUS, TRH_STATUS,"
        sql_dup &= " TRH_CREATE_BY, TRH_CREATE,"
        sql_dup &= " TRD_ID, TRD_TRH, TRD_SEQ,TRD_SKU,"
        sql_dup &= " TRD_SKU_CODE, TRD_SKU_NAME,"
        sql_dup &= " TRD_UNIT, TRD_VAT_TY, TRD_VAT_R, TRD_QTY, TRD_UPC,"
        sql_dup &= " TRD_DISC_STR,TRD_DISC, TRD_DISC_AMT, TRD_G_KEYIN,"
        sql_dup &= " TRD_REMARK, TRD_CREATE,TPAGE.TYPE"
        sql_dup &= " FROM TRANMAIN LEFT JOIN TRANDETAIL ON TRANMAIN.TRH_ID = TRANDETAIL.TRD_TRH"
        sql_dup &= " JOIN CUSTOMER ON TRANMAIN.TRH_CUS = CUSTOMER.CUS_ID"
        sql_dup &= " JOIN SALESMAN ON TRANMAIN.TRH_SLMN = SALESMAN.SLMN_ID"
        sql_dup &= " CROSS JOIN (SELECT  1 AS TYPE UNION SELECT 2 AS TYPE) AS TPAGE"
        sql_dup &= " WHERE TRH_ID=" & Integer.Parse(TRH_IDTextBox.Text)
        sql_dup &= " ORDER BY TRH_DATE,TRH_NO,TYPE,TRD_SEQ"
        Dim cmd_dup As New SqlCommand(sql_dup, cnn_sql_main)
        Dim adapter_dup As New SqlDataAdapter(cmd_dup)
        adapter_dup.Fill(DATA_RPT, "DOC_DUP")
    End Sub
    Private Sub data_dup3()
        'พิมพ์ 3 หน้า แบบ ต้นฉบับ ,สำเนา
        DATA_RPT.Clear()
        Dim sql_dup As String = "SELECT"
        sql_dup &= " TRH_ID, TRH_DT,"
        sql_dup &= " TRH_DATE, TRH_NO,"
        sql_dup &= " CUS_ID, CUS_CODE, CUS_NAME, CUS_BRANCH, CUS_TAXID,"
        sql_dup &= " LTRIM(CASE WHEN CUS_ADDB1 IS NULL THEN '' ELSE CUS_ADDB1 END + CHAR(13)+ CASE WHEN CUS_ADDB2 IS NULL THEN '' ELSE CUS_ADDB2 END) + ' ' +"
        sql_dup &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE (CASE WHEN LEN(CUS_PROVINCE)>0 THEN"
        sql_dup &= " (CASE WHEN CUS_PROVINCE LIKE 'กรุงเทพ%' OR ASCII(LEFT(CUS_PROVINCE,1))<161 THEN CUS_PROVINCE ELSE 'จ.'+CUS_PROVINCE END) ELSE '' END) END) + ' ' +" 'เฉพาะ ลค.วีที ใช้คำว่า จังหวัด
        sql_dup &= " CASE WHEN CUS_POST IS NULL THEN '' ELSE CUS_POST END AS ADDRESS,"
        sql_dup &= " CUS_TEL, CUS_FAX,"
        sql_dup &= " SLMN_ID, SLMN_CODE, SLMN_NAME,"
        sql_dup &= " TRH_VAT_NO, TRH_VAT_DATE,"
        sql_dup &= " TRH_SHIP_DATE, TRH_BILL_DATE,"
        sql_dup &= " TRH_CANCEL_DATE, TRH_CUS,"
        sql_dup &= " TRH_SLMN, TRH_TERM, TRH_DUE,"
        sql_dup &= " TRH_REF_PO, TRH_REF_SO, TRH_REF_PERSON,"
        sql_dup &= " TRH_VATIO, TRH_VAT, TRH_VAT_TY, TRH_VAT_R,"
        sql_dup &= " TRH_N_QTY, TRH_N_ITEMS,"
        sql_dup &= " TRH_G_KEYIN, TRH_DISC_STR,TRH_DISC, TRH_DISC_AMT, TRH_G_SELL,TRH_G_SNV,"
        sql_dup &= " TRH_G_SV, TRH_G_VAT, TRH_G_NET,"
        sql_dup &= " TRH_REMARK, TRH_DOC_STATUS, TRH_STATUS,"
        sql_dup &= " TRH_CREATE_BY, TRH_CREATE,"
        sql_dup &= " TRD_ID, TRD_TRH, TRD_SEQ,TRD_SKU,"
        sql_dup &= " TRD_SKU_CODE, TRD_SKU_NAME,"
        sql_dup &= " TRD_UNIT, TRD_VAT_TY, TRD_VAT_R, TRD_QTY, TRD_UPC,"
        sql_dup &= " TRD_DISC_STR,TRD_DISC, TRD_DISC_AMT, TRD_G_KEYIN,"
        sql_dup &= " TRD_REMARK, TRD_CREATE,TPAGE.TYPE"
        sql_dup &= " FROM TRANMAIN LEFT JOIN TRANDETAIL ON TRANMAIN.TRH_ID = TRANDETAIL.TRD_TRH"
        sql_dup &= " JOIN CUSTOMER ON TRANMAIN.TRH_CUS = CUSTOMER.CUS_ID"
        sql_dup &= " JOIN SALESMAN ON TRANMAIN.TRH_SLMN = SALESMAN.SLMN_ID"
        sql_dup &= " CROSS JOIN (SELECT  1 AS TYPE UNION SELECT 2 AS TYPE UNION SELECT 3 AS TYPE) AS TPAGE"
        sql_dup &= " WHERE TRH_ID=" & Integer.Parse(TRH_IDTextBox.Text)
        sql_dup &= " ORDER BY TRH_DATE,TRH_NO,TYPE,TRD_SEQ"
        Dim cmd_dup As New SqlCommand(sql_dup, cnn_sql_main)
        Dim adapter_dup As New SqlDataAdapter(cmd_dup)
        adapter_dup.Fill(DATA_RPT, "DOC_DUP")
    End Sub
    Private Sub data_dup4()
        'พิมพ์ 4 หน้า แบบ ต้นฉบับ ,สำเนา
        DATA_RPT.Clear()
        Dim sql_dup As String = "SELECT"
        sql_dup &= " TRH_ID, TRH_DT,"
        sql_dup &= " TRH_DATE, TRH_NO,"
        sql_dup &= " CUS_ID, CUS_CODE, CUS_NAME, CUS_BRANCH, CUS_TAXID,"
        sql_dup &= " LTRIM(CASE WHEN CUS_ADDB1 IS NULL THEN '' ELSE CUS_ADDB1 END + CHAR(13)+ CASE WHEN CUS_ADDB2 IS NULL THEN '' ELSE CUS_ADDB2 END) + ' ' +"
        sql_dup &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE (CASE WHEN LEN(CUS_PROVINCE)>0 THEN"
        sql_dup &= " (CASE WHEN CUS_PROVINCE LIKE 'กรุงเทพ%' OR ASCII(LEFT(CUS_PROVINCE,1))<161 THEN CUS_PROVINCE ELSE 'จ.'+CUS_PROVINCE END) ELSE '' END) END) + ' ' +" 'เฉพาะ ลค.วีที ใช้คำว่า จังหวัด
        sql_dup &= " CASE WHEN CUS_POST IS NULL THEN '' ELSE CUS_POST END AS ADDRESS,"
        sql_dup &= " CUS_TEL, CUS_FAX,"
        sql_dup &= " SLMN_ID, SLMN_CODE, SLMN_NAME,"
        sql_dup &= " TRH_VAT_NO, TRH_VAT_DATE,"
        sql_dup &= " TRH_SHIP_DATE, TRH_BILL_DATE,"
        sql_dup &= " TRH_CANCEL_DATE, TRH_CUS,"
        sql_dup &= " TRH_SLMN, TRH_TERM, TRH_DUE,"
        sql_dup &= " TRH_REF_PO, TRH_REF_SO, TRH_REF_PERSON,"
        sql_dup &= " TRH_VATIO, TRH_VAT, TRH_VAT_TY, TRH_VAT_R,"
        sql_dup &= " TRH_N_QTY, TRH_N_ITEMS,"
        sql_dup &= " TRH_G_KEYIN, TRH_DISC_STR,TRH_DISC, TRH_DISC_AMT, TRH_G_SELL,TRH_G_SNV,"
        sql_dup &= " TRH_G_SV, TRH_G_VAT, TRH_G_NET,"
        sql_dup &= " TRH_REMARK, TRH_DOC_STATUS, TRH_STATUS,"
        sql_dup &= " TRH_CREATE_BY, TRH_CREATE,"
        sql_dup &= " TRD_ID, TRD_TRH, TRD_SEQ,TRD_SKU,"
        sql_dup &= " TRD_SKU_CODE, TRD_SKU_NAME,"
        sql_dup &= " TRD_UNIT, TRD_VAT_TY, TRD_VAT_R, TRD_QTY, TRD_UPC,"
        sql_dup &= " TRD_DISC_STR,TRD_DISC, TRD_DISC_AMT, TRD_G_KEYIN,"
        sql_dup &= " TRD_REMARK, TRD_CREATE,TPAGE.TYPE"
        sql_dup &= " FROM TRANMAIN LEFT JOIN TRANDETAIL ON TRANMAIN.TRH_ID = TRANDETAIL.TRD_TRH"
        sql_dup &= " JOIN CUSTOMER ON TRANMAIN.TRH_CUS = CUSTOMER.CUS_ID"
        sql_dup &= " JOIN SALESMAN ON TRANMAIN.TRH_SLMN = SALESMAN.SLMN_ID"
        sql_dup &= " CROSS JOIN (SELECT  1 AS TYPE UNION SELECT 2 AS TYPE UNION SELECT 3 AS TYPE UNION SELECT 4 AS TYPE) AS TPAGE"
        sql_dup &= " WHERE TRH_ID=" & Integer.Parse(TRH_IDTextBox.Text)
        sql_dup &= " ORDER BY TRH_DATE,TRH_NO,TYPE,TRD_SEQ"
        Dim cmd_dup As New SqlCommand(sql_dup, cnn_sql_main)
        Dim adapter_dup As New SqlDataAdapter(cmd_dup)
        adapter_dup.Fill(DATA_RPT, "DOC_DUP")
    End Sub
    Private Sub data_print(Optional ByVal dup As Integer = 1)
        'พิมพ์ 5 หน้า แบบ ต้นฉบับ ,สำเนา
        DATA_RPT.Clear()
        Dim sql_dup As String = "SELECT"
        sql_dup &= " TRH_ID, TRH_DT,"
        sql_dup &= " TRH_DATE, TRH_NO,"
        sql_dup &= " CUS_ID, CUS_CODE, CUS_NAME, CUS_BRANCH, CUS_TAXID,"
        sql_dup &= " LTRIM(CASE WHEN CUS_ADDB1 IS NULL THEN '' ELSE CUS_ADDB1 END + CHAR(13)+ CASE WHEN CUS_ADDB2 IS NULL THEN '' ELSE CUS_ADDB2 END) + ' ' +"
        sql_dup &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE (CASE WHEN LEN(CUS_PROVINCE)>0 THEN"
        sql_dup &= " (CASE WHEN CUS_PROVINCE LIKE 'กรุงเทพ%' OR ASCII(LEFT(CUS_PROVINCE,1))<161 THEN CUS_PROVINCE ELSE 'จ.'+CUS_PROVINCE END) ELSE '' END) END) + ' ' +" 'เฉพาะ ลค.วีที ใช้คำว่า จังหวัด
        sql_dup &= " CASE WHEN CUS_POST IS NULL THEN '' ELSE CUS_POST END AS ADDRESS,"
        sql_dup &= " CUS_TEL, CUS_FAX,"
        sql_dup &= " SLMN_ID, SLMN_CODE, SLMN_NAME,"
        sql_dup &= " TRH_VAT_NO, TRH_VAT_DATE,"
        sql_dup &= " TRH_SHIP_DATE, TRH_BILL_DATE,"
        sql_dup &= " TRH_CANCEL_DATE, TRH_CUS,"
        sql_dup &= " TRH_SLMN, TRH_TERM, TRH_DUE,"
        sql_dup &= " TRH_REF_PO, TRH_REF_SO, TRH_REF_PERSON,"
        sql_dup &= " TRH_VATIO, TRH_VAT, TRH_VAT_TY, TRH_VAT_R,"
        sql_dup &= " TRH_N_QTY, TRH_N_ITEMS,"
        sql_dup &= " TRH_G_KEYIN, TRH_DISC_STR,TRH_DISC, TRH_DISC_AMT, TRH_G_SELL,TRH_G_SNV,"
        sql_dup &= " TRH_G_SV, TRH_G_VAT, TRH_G_NET,"
        sql_dup &= " TRH_REMARK, TRH_DOC_STATUS, TRH_STATUS,"
        sql_dup &= " TRH_CREATE_BY, TRH_CREATE,"
        sql_dup &= " TRD_ID, TRD_TRH, TRD_SEQ,TRD_SKU,"
        sql_dup &= " TRD_SKU_CODE, TRD_SKU_NAME,"
        sql_dup &= " TRD_UNIT, TRD_VAT_TY, TRD_VAT_R, TRD_QTY, TRD_UPC,"
        sql_dup &= " TRD_DISC_STR,TRD_DISC, TRD_DISC_AMT, TRD_G_KEYIN,"
        sql_dup &= " TRD_REMARK, TRD_CREATE,"
        If dup = 1 Then
            sql_dup &= " 0 AS TYPE"
        Else
            sql_dup &= " TPAGE.TYPE"
        End If
        sql_dup &= " FROM TRANMAIN LEFT JOIN TRANDETAIL ON TRANMAIN.TRH_ID = TRANDETAIL.TRD_TRH"
        sql_dup &= " JOIN CUSTOMER ON TRANMAIN.TRH_CUS = CUSTOMER.CUS_ID"
        sql_dup &= " JOIN SALESMAN ON TRANMAIN.TRH_SLMN = SALESMAN.SLMN_ID"
        If dup = 2 Then
            sql_dup &= " CROSS JOIN (SELECT  1 AS TYPE UNION SELECT 2 AS TYPE) AS TPAGE"
        ElseIf dup = 3 Then
            sql_dup &= " CROSS JOIN (SELECT  1 AS TYPE UNION SELECT 2 AS TYPE UNION SELECT 3 AS TYPE) AS TPAGE"
        ElseIf dup = 4 Then
            sql_dup &= " CROSS JOIN (SELECT  1 AS TYPE UNION SELECT 2 AS TYPE UNION SELECT 3 AS TYPE UNION SELECT 4 AS TYPE) AS TPAGE"
        ElseIf dup = 5 Then
            sql_dup &= " CROSS JOIN (SELECT  1 AS TYPE UNION SELECT 2 AS TYPE UNION SELECT 3 AS TYPE UNION SELECT 4 AS TYPE UNION SELECT 5 AS TYPE) AS TPAGE"
        ElseIf dup = 6 Then
            sql_dup &= " CROSS JOIN (SELECT  1 AS TYPE UNION SELECT 2 AS TYPE UNION SELECT 3 AS TYPE UNION SELECT 4 AS TYPE UNION SELECT 5 AS TYPE UNION SELECT 6 AS TYPE) AS TPAGE"
        End If
        sql_dup &= " WHERE TRH_ID=" & Integer.Parse(TRH_IDTextBox.Text)
        sql_dup &= " ORDER BY TRH_DATE,TRH_NO,TYPE,TRD_SEQ"
        Dim cmd_dup As New SqlCommand(sql_dup, cnn_sql_main)
        Dim adapter_dup As New SqlDataAdapter(cmd_dup)
        adapter_dup.Fill(DATA_RPT, "DOC_RPT")
    End Sub

End Class