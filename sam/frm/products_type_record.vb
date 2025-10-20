Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class products_type_record
    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PRODUCTS_TYPETableAdapter.Fill(Me.INVOICEDataSet.PRODUCTS_TYPE)
        Pn_not_show.Hide()
    End Sub
    Private Sub salesman_record_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        'check_nullrecord()
        exit1.Focus()
    End Sub

    Private Sub FrmCustomer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Public Sub create_job()
        If insert_status.Text = "1" Then
            MsgBox("ยังไม่บันทึกข้อมูล", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Exit Sub
        End If
        PRODUCTS_TYPEBindingSource.AddNew()
        insert_status.Text = "1"
        code_auto()
        'check_nullrecord() 'ถ้าไม่มี record ให้ enable control
        navigator_add(add1, save1, delete1, print1)
    End Sub

    Private Sub add1_Click(sender As System.Object, e As System.EventArgs) Handles add1.Click
        create_job()
    End Sub

    Private Sub save1_Click(sender As System.Object, e As System.EventArgs) Handles save1.Click
        If PROTY_CODETextBox.Text.Trim.Length = 0 Then
            MsgBox("กรุณาใส่รหัสประเภท", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            PROTY_CODETextBox.Select()
            Exit Sub
        ElseIf PROTY_NAMETextBox.Text.Trim.Length = 0 Then
            MsgBox("กรุณาใส่ชื่อประเภท", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            PROTY_NAMETextBox.Select()
            Exit Sub
        End If
        Try
            If insert_status.Text = "1" Then
                PROTY_CREATEDateTimePicker.Value = Now
                Me.Validate()
                Me.PRODUCTS_TYPEBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            Else
                Me.Validate()
                Me.PRODUCTS_TYPEBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            End If
            products_type_profile.refresh_cnt = 1
            insert_status.Text = "0"

            If MessageBox.Show("บันทึกเรียบร้อย" + vbNewLine + "กด Yes เพื่อปิดหน้าจอบันทึก", "Result", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Close()
            End If
            navigator_save(add1, save1, delete1, print1)
        Catch ex As Exception
            'MsgBox(Err.Description)
            If Err.Number = 5 Then
                MsgBox("พบรหัสซ้ำ โปรดตรวจสอบ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Else
                MsgBox(Err.Description)
            End If
        End Try
    End Sub

    Private Sub delete1_Click(sender As System.Object, e As System.EventArgs) Handles delete1.Click
        If insert_status.Text = "1" Then
            MsgBox("ยังไม่บันทึกข้อมูล", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Exit Sub
        End If
        Try
            Dim data_check As New DataSet
            Dim sql6 As String = "SELECT"
            sql6 &= " PRO_ID,PRO_CODE,PRO_NAME,PRO_CAT"
            sql6 &= " FROM PRODUCTS"
            sql6 &= " WHERE PRO_CAT=" & Integer.Parse(PROTY_IDTextBox.Text)
            sql6 &= " ORDER BY PRO_CODE"
            Dim cmd_print As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_print As New SqlDataAdapter(cmd_print)
            adapter_print.Fill(data_check, "PRODUCTS")

            If data_check.Tables("PRODUCTS").Rows.Count > 0 Then 'ตรวจสอบการอ้างอิง จาก parent customer
                Dim cnt_1 As Integer = 0
                Dim str As String = ""
                For Each row3 As DataRow In data_check.Tables("PRODUCTS").Rows
                    cnt_1 += 1
                    str += row3.Item("PRO_CODE") + " " + row3.Item("PRO_NAME") + vbNewLine
                Next
                MsgBox("พบอ้างอิงสินค้า " + cnt_1.ToString("#,###") + " รายการ ไม่สามารถลบได้" + vbNewLine + str, MsgBoxStyle.Information, "คำเตือน")
                Exit Sub
            End If

            Dim msgtext As String
            msgtext = MsgBox("ยืนยันการลบข้อมูล", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "คำเตือน")
            If msgtext = vbYes Then
                Me.PRODUCTS_TYPEBindingSource.RemoveCurrent()
                Me.Validate()
                Me.PRODUCTS_TYPEBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
                insert_status.Text = 0
                products_type_profile.refresh_cnt = 1
                Close()
                MsgBox("ลบข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
            Else : Return
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub exit1_Click(sender As System.Object, e As System.EventArgs) Handles exit1.Click
        Close()
    End Sub

    Private Sub code_auto()
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
        sql_config &= " CR_CODE='302'" 'ประเภทสินค้า
        sql_config &= " AND CR_STATUS=1" 'ตั้งค่ารหัสอัตโนมัติ
        Dim cmd_config As New SqlCommand(sql_config, cnn_sql_main)
        Dim adapter_config As New SqlDataAdapter(cmd_config)
        adapter_config.Fill(doctype_a, "CODE_RUNNING")

        If doctype_a.Tables("CODE_RUNNING").Rows.Count > 0 Then
            If Len(doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME")) = 0 Then
                PROTY_CODETextBox.Select()
                Exit Sub 'ถ้าไม่กำหนด prefix ให้ออกจาก sub
            End If
            header_first = doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME")
            header_width = Len(doctype_a.Tables("CODE_RUNNING").Rows(0).Item("PREFIX_NAME"))
            number_width = doctype_a.Tables("CODE_RUNNING").Rows(0).Item("CR_RUNNING")
        Else
            'MsgBox("ไม่พบการตั้งรหัสอัตโนมัติ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            PROTY_CODETextBox.Select()
            Exit Sub
        End If

        Dim data_cus As New DataSet
        Dim sql_cus As String = "SELECT TOP 1"
        sql_cus &= " PROTY_CODE,SUBSTRING(PROTY_CODE," & header_width + 1 & ",10) AS NUM_START"
        sql_cus &= " FROM PRODUCTS_TYPE"
        sql_cus &= " WHERE"
        sql_cus &= " LEFT(PROTY_CODE," & header_width & ")='" & header_first & "'"
        sql_cus &= " AND ISNUMERIC(SUBSTRING(PROTY_CODE," & header_width + 1 & ",10))=1"
        sql_cus &= " AND LEN(SUBSTRING(PROTY_CODE," & header_width + 1 & ",10))=" & number_width
        sql_cus &= " ORDER BY PROTY_CODE DESC"
        Dim cmd_cus As New SqlCommand(sql_cus, cnn_sql_main)
        Dim adapter_cus As New SqlDataAdapter(cmd_cus)
        adapter_cus.Fill(data_cus, "DOC_PRODUCTS_TYPE")

        If data_cus.Tables("DOC_PRODUCTS_TYPE").Rows.Count > 0 Then
            strIDAcc = header_first & (Integer.Parse(data_cus.Tables("DOC_PRODUCTS_TYPE").Rows(0).Item("NUM_START")) + 1).ToString(StrDup(number_width, "0"))
            PROTY_CODETextBox.Text = strIDAcc
            PROTY_NAMETextBox.Select()
        Else
            strIDAcc = header_first & 1.ToString(StrDup(number_width, "0")) 'ถ้าไม่พบรหัสก่อนนี้ ให้ run ใหม่
            PROTY_CODETextBox.Text = strIDAcc
            PROTY_NAMETextBox.Select()
        End If
    End Sub

    Private Sub print1_Click(sender As System.Object, e As System.EventArgs) Handles print1.Click
        MsgBox("ยังไม่ออกแบบ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
    End Sub

    Private Sub PRODUCTS_TYPEBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PRODUCTS_TYPEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
    End Sub

    Private Sub PRODUCTS_TYPEDataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PRODUCTS_TYPEDataGridView.CellDoubleClick
        'If e.RowIndex > -1 Then
        '    Dim frm As New products_profile
        '    frm.MdiParent = MainMenu
        '    frm.Name = "products_profile88" 'ตั้งชื่ออย่าให้เหมือน parent เนื่องจากต้องเช็คการเปิดหน้าจอซ้ำ ของ supplier_profile
        '    frm.Dock = DockStyle.Fill
        '    frm.filter_type = PRODUCTS_TYPEDataGridView.Rows.Item(e.RowIndex).Cells("PROTY_ID").Value 'กรองเฉพาะประเภทเจ้าหนี้
        '    frm.Show()
        '    'frm.cmpn_ty_cmb.SelectedValue = PRODUCTS_TYPEDataGridView.Rows.Item(e.RowIndex).Cells("PROTY_ID").Value
        '    frm.cmpn_ty_cmb.Enabled = False 'ห้ามเลือกประเภทสินค้า แสดงเฉพาะที่ดับเบิ้ลคลิก
        'End If
    End Sub
End Class