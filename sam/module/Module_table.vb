Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Module Module_table
    Friend Function month_table() As DataTable
        Dim month_dt As New DataTable 'เดือนไทย
        month_dt.Columns.Add("mn_id", GetType(Integer))
        month_dt.Columns.Add("mn_name", GetType(String))
        month_dt.Rows.Add(1, "มกราคม")
        month_dt.Rows.Add(2, "กุมภาพันธ์")
        month_dt.Rows.Add(3, "มีนาคม")
        month_dt.Rows.Add(4, "เมษายน")
        month_dt.Rows.Add(5, "พฤษภาคม")
        month_dt.Rows.Add(6, "มิถุนายน")
        month_dt.Rows.Add(7, "กรกฎาคม")
        month_dt.Rows.Add(8, "สิงหาคม")
        month_dt.Rows.Add(9, "กันยายน")
        month_dt.Rows.Add(10, "ตุลาคม")
        month_dt.Rows.Add(11, "พฤศจิกายน")
        month_dt.Rows.Add(12, "ธันวาคม")
        Return month_dt
    End Function
    Friend Function company_table() As DataTable
        Dim DATA As New DataSet 'ประเภทลูกหนี้
        DATA.Clear()
        Dim sql6 As String = "SELECT *"
        sql6 &= " FROM COMPANY"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "COMPANY")
            Return DATA.Tables("COMPANY")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Friend Function customer_alltype_table() As DataTable
        Dim DATA As New DataSet 'เลือกประเภทลูกหนี้ (ทั้งหมด)
        DATA.Clear()
        Dim sql6 As String = "SELECT "
        sql6 &= " CUSTY_ID,CUSTY_CODE,CUSTY_NAME"
        sql6 &= " FROM"
        sql6 &= " (SELECT 0 AS CUSTY_ID,'*' AS CUSTY_CODE,'(ทั้งหมด)' AS CUSTY_NAME FROM CUSTOMER_TYPE"
        sql6 &= " UNION"
        sql6 &= " SELECT CUSTY_ID,CUSTY_CODE,CUSTY_NAME"
        sql6 &= " FROM CUSTOMER_TYPE) AS CUSTOMER_TYPE"
        sql6 &= " ORDER BY CUSTY_CODE"

        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "CUSTOMER_TYPE")
            Return DATA.Tables("CUSTOMER_TYPE")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function customer_type_table() As DataTable
        Dim DATA As New DataSet 'ประเภทลูกหนี้
        DATA.Clear()
        Dim sql6 As String = "SELECT *"
        sql6 &= " FROM CUSTOMER_TYPE"
        sql6 &= " ORDER BY CUSTY_CODE"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "CUSTOMER_TYPE")
            Return DATA.Tables("CUSTOMER_TYPE")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function customer_table() As DataTable
        Dim DATA As New DataSet 'ลูกหนี้
        DATA.Clear()
        Dim sql6 As String = "SELECT *"
        sql6 &= " FROM CUSTOMER"
        sql6 &= " ORDER BY CUS_CODE"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "CUSTOMER")
            Return DATA.Tables("CUSTOMER")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function customer_inv_table() As DataTable
        Dim DATA As New DataSet 'ลูกหนี้ แบบแสดงที่อยู่รวม
        DATA.Clear()
        Dim sql6 As String = " SELECT"
        sql6 &= " CUS_ID,CUS_CODE,CUS_NAME,CUS_BRANCH,CUS_TAXID,"
        sql6 &= " LTRIM(CASE WHEN CUS_NAME IS NULL THEN '' ELSE CUS_NAME END + ' ' +CASE WHEN CUS_BRANCH IS NULL THEN '' ELSE CUS_BRANCH END) AS CUS_NAME_BRANCH,"
        'sql6 &= " LTRIM(CASE WHEN CUS_ADDB1 IS NULL THEN '' ELSE CUS_ADDB1 END + ' ' + CASE WHEN CUS_ADDB2 IS NULL THEN '' ELSE CUS_ADDB2 END) + ' ' +"
        sql6 &= " LTRIM(CASE WHEN CUS_ADDB1 IS NULL THEN '' ELSE CUS_ADDB1 END + CHAR(13)+CHAR(10) + CASE WHEN CUS_ADDB2 IS NULL THEN '' ELSE CUS_ADDB2 END) + ' ' +"
        'sql6 &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE CUS_PROVINCE END  + ' ' + CASE WHEN CUS_POST IS NULL THEN '' ELSE CUS_POST END) AS ADDRESS,"
        'sql6 &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE (CASE WHEN CUS_PROVINCE LIKE 'กรุงเทพ%' OR ASCII(LEFT(CUS_PROVINCE,1))<161 THEN CUS_PROVINCE ELSE 'จ.'+CUS_PROVINCE END) END) + ' ' +"
        sql6 &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE (CASE WHEN LEN(CUS_PROVINCE)>0 THEN"
        'sql6 &= " (CASE WHEN CUS_PROVINCE LIKE 'กรุงเทพ%' OR ASCII(LEFT(CUS_PROVINCE,1))<161 THEN CUS_PROVINCE ELSE 'จ.'+CUS_PROVINCE END) ELSE '' END) END) + ' ' +"
        sql6 &= " (CASE WHEN CUS_PROVINCE LIKE 'กรุงเทพ%' OR ASCII(LEFT(CUS_PROVINCE,1))<161 THEN CUS_PROVINCE ELSE 'จ.'+CUS_PROVINCE END) ELSE '' END) END) + ' ' +" 'เฉพาะ ลค.วีที ใช้คำว่า จังหวัด
        sql6 &= " CASE WHEN CUS_POST IS NULL THEN '' ELSE CUS_POST END AS ADDRESS,"
        sql6 &= " CUS_TEL,CUS_FAX,"
        sql6 &= " CUS_SLMN,CUS_CONTACT,CUS_CREDIT_TERM,CUS_TAX_TY,CUS_TAX_VATIO,CUS_DISC_PERCEN,"
        sql6 &= " 0 AS CUS_VAT_R,CUS_CAT"
        sql6 &= " FROM CUSTOMER"
        sql6 &= " ORDER BY CUS_CODE,CUS_NAME"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "CUSTOMER_INV")
            Return DATA.Tables("CUSTOMER_INV")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Friend Function dept_all_table() As DataTable
        Dim DATA_DEPT_CONDITION As New DataSet 'แผนก
        DATA_DEPT_CONDITION.Clear()
        Dim sql_dept_con As String = "SELECT"
        sql_dept_con &= " DEPT_ID,DEPT_CODE,DEPT_NAME"
        sql_dept_con &= " FROM"
        sql_dept_con &= " (SELECT 0 AS DEPT_ID,'*' AS DEPT_CODE,'(ทั้งหมด)' AS DEPT_NAME FROM DEPARTMENT"
        sql_dept_con &= " UNION"
        sql_dept_con &= " SELECT DEPT_ID,DEPT_CODE,DEPT_NAME"
        sql_dept_con &= " FROM DEPARTMENT) AS DEPARTMENT"
        sql_dept_con &= " ORDER BY DEPT_CODE"
        Try 'ตรวจสอบ connection
            Dim cmd_dept_con As New SqlCommand(sql_dept_con, cnn_sql_main)
            Dim adapter_dept_con As New SqlDataAdapter(cmd_dept_con)
            adapter_dept_con.Fill(DATA_DEPT_CONDITION, "DEPARTMENT")
            Return DATA_DEPT_CONDITION.Tables("DEPARTMENT")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Friend Function branch_table() As DataTable
        Dim DATA_BRANCH As New DataSet 'สาขา
        DATA_BRANCH.Clear()
        Dim sql_br As String = "SELECT BR_ID,BR_CODE,BR_NAME"
        sql_br &= " FROM BRANCH ORDER BY BR_CODE"
        Try 'ตรวจสอบ connection
            Dim cmd_br As New SqlCommand(sql_br, cnn_sql_main)
            Dim adapter_br As New SqlDataAdapter(cmd_br)
            adapter_br.Fill(DATA_BRANCH, "BRANCH")
            Return DATA_BRANCH.Tables("BRANCH")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function salesman_table() As DataTable
        Dim DATA As New DataSet 'พนักงานขาย
        DATA.Clear()
        Dim sql As String = "SELECT *"
        sql &= " FROM SALESMAN"
        sql &= " ORDER BY SLMN_CODE"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "SALESMAN")
            Return DATA.Tables("SALESMAN")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function product_type_table() As DataTable
        Dim DATA As New DataSet 'จังหวัด
        DATA.Clear()
        Dim sql As String = "SELECT *"
        sql &= " FROM PRODUCTS_TYPE"
        sql &= " ORDER BY PROTY_CODE"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "PRODUCT_TYPE")
            Return DATA.Tables("PRODUCT_TYPE")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function product_table() As DataTable
        Dim DATA As New DataSet 'จังหวัด
        DATA.Clear()
        Dim sql As String = "SELECT *"
        sql &= " FROM PRODUCTS"
        sql &= " ORDER BY PRO_CODE"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "PRODUCTS")
            Return DATA.Tables("PRODUCTS")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function product_alltype_table() As DataTable
        Dim DATA As New DataSet 'เลือกประเภทสินค้า (ทั้งหมด)
        DATA.Clear()
        Dim sql6 As String = "SELECT "
        sql6 &= " PROTY_ID,PROTY_CODE,PROTY_NAME"
        sql6 &= " FROM"
        sql6 &= " (SELECT 0 AS PROTY_ID,'*' AS PROTY_CODE,'(ทั้งหมด)' AS PROTY_NAME FROM PRODUCTS_TYPE"
        sql6 &= " UNION"
        sql6 &= " SELECT PROTY_ID,PROTY_CODE,PROTY_NAME"
        sql6 &= " FROM PRODUCTS_TYPE) AS PRODUCTS_TYPE"
        sql6 &= " ORDER BY PROTY_CODE"

        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql6, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "PRODUCTS_TYPE")
            Return DATA.Tables("PRODUCTS_TYPE")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function province_table() As DataTable
        Dim DATA As New DataSet 'จังหวัด
        DATA.Clear()
        Dim sql As String = "SELECT *"
        sql &= " FROM PROVINCE"
        sql &= " ORDER BY PROVINCE_NAME"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "PROVINCE")
            Return DATA.Tables("PROVINCE")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function tranmain_table() As DataTable
        Dim DATA As New DataSet 'จังหวัด
        DATA.Clear()
        Dim sql As String = "SELECT *"
        sql &= " FROM TRANMAIN"
        sql &= " ORDER BY TRH_DATE,TRH_NO"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "TRANMAIN")
            Return DATA.Tables("TRANMAIN")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function trandetail_table() As DataTable
        Dim DATA As New DataSet 'จังหวัด
        DATA.Clear()
        Dim sql As String = "SELECT *"
        sql &= " FROM TRANDETAIL"
        sql &= " ORDER BY TRD_ID"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "TRANDETAIL")
            Return DATA.Tables("TRANDETAIL")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function tranmain_detail_table() As DataTable
        Dim DATA As New DataSet 'จังหวัด
        DATA.Clear()
        Dim sql As String = "SELECT *"
        sql &= " FROM TRANMAIN"
        sql &= " JOIN TRANDETAIL ON TRH_ID=TRD_TRH"
        sql &= " ORDER BY TRH_DATE,TRH_NO"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "TRANMAIN_DETAIL")
            Return DATA.Tables("TRANMAIN_DETAIL")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function doctype_table() As DataTable
        Dim DATA As New DataSet 'จังหวัด
        DATA.Clear()
        Dim sql As String = "SELECT *"
        sql &= " FROM DOCTYPE"
        sql &= " ORDER BY DT_CODE"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DATA, "DOCTYPE")
            Return DATA.Tables("DOCTYPE")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Function doctype_running_table() As DataTable
        Dim DT As New DataSet '
        Dim sql As String = "SELECT DT_ID,DT_CODE,DT_STATUS,CASE WHEN DT_PREFIX IS NULL THEN '' ELSE DT_PREFIX END AS DT_PREFIX,"
        sql &= " (CASE WHEN DT_PREFIX IS NULL THEN '' ELSE DT_PREFIX END + CASE WHEN DT_SEPARATE IS NULL THEN '' ELSE DT_SEPARATE END) AS PREFIX_NAME,"
        sql &= " DT_DATE_SELECT,DT_DATE_TYPE,DT_DATE_DIGIT,"
        sql &= " CASE WHEN DT_DATE_SEPARATE IS NULL THEN '' ELSE DT_DATE_SEPARATE END AS DT_DATE_SEPARATE,"
        sql &= " DT_RUNNING"
        sql &= " FROM DOCTYPE"
        sql &= " WHERE"
        sql &= " DT_STATUS=1" 'ตั้งค่ารหัสอัตโนมัติ
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DT, "DOCTYPE")
            Return DT.Tables("DOCTYPE")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Friend Sub DOC_AUTORUN(ByVal tbx As TextBox)
        Dim header_name As String = ""
        Dim year_name As String = ""
        Dim header_width As Integer
        Dim number_width As Integer
        Dim separate_width As Integer
        Dim strIDAcc As String = ""
        If doctype_running_table.Rows.Count > 0 Then 'ถ้าไม่พบการตั้งค่าอัตโนมัติ
            'If Len(doctype_running_table.Rows(0).Item("PREFIX_NAME")) = 0 Then 'ไม่ต้องเช็ค prefix เพราะมี ลค. รันเฉพาะปีเดือนวัน ไม่เอา prefix
            '    tbx.Select()
            '    Exit Sub ' ให้ออกจาก sub
            'End If
            'วิธีใหม่ ไม่เอา separate ต่อท้าย มารวมเพื่อรัน ใช้ prefix + ปีเดือน แค่นี้พอ

            If doctype_running_table.Rows(0).Item("DT_DATE_SELECT") = True Then 'ถ้าเลือกรูปแแบบ ปีเดือน
                If doctype_running_table.Rows(0).Item("DT_DATE_TYPE") = 0 Then 'ถ้าเลือกปีแบบ พุทธศักราช
                    'Standard
                    If doctype_running_table.Rows(0).Item("DT_DATE_DIGIT") = 0 Then 'ถ้าเลือกปีแบบ 4 ตัว
                        header_name = doctype_running_table.Rows(0).Item("PREFIX_NAME").ToString & (Now.Year + 543).ToString("#") & Now.Month.ToString("00")
                    Else
                        header_name = doctype_running_table.Rows(0).Item("PREFIX_NAME").ToString & Microsoft.VisualBasic.Right((Now.Year + 543).ToString("#"), 2) & Now.Month.ToString("00")
                    End If

                    ''(ดีดี การ์เด้น โฮม) ไม่เอาตัวเลข เดือน
                    'If doctype_running_table.Rows(0).Item("DT_DATE_DIGIT") = 0 Then 'ถ้าเลือกปีแบบ 4 ตัว
                    '    header_name = doctype_running_table.Rows(0).Item("PREFIX_NAME").ToString & (Now.Year + 543).ToString("#")
                    'Else
                    '    header_name = doctype_running_table.Rows(0).Item("PREFIX_NAME").ToString & Microsoft.VisualBasic.Right((Now.Year + 543).ToString("#"), 2)
                    'End If 'จบ '(ดีดี การ์เด้น โฮม) ไม่เอาตัวเลข เดือน

                Else
                    'Standard
                    If doctype_running_table.Rows(0).Item("DT_DATE_DIGIT") = 0 Then
                        header_name = doctype_running_table.Rows(0).Item("PREFIX_NAME").ToString & Now.Year.ToString("#") & Now.Month.ToString("00")
                    Else
                        header_name = doctype_running_table.Rows(0).Item("PREFIX_NAME").ToString & Microsoft.VisualBasic.Right(Now.Year.ToString("#"), 2) & Now.Month.ToString("00")
                    End If

                    ''(ดีดี การ์เด้น โฮม) ไม่เอาตัวเลข เดือน
                    'If doctype_running_table.Rows(0).Item("DT_DATE_DIGIT") = 0 Then
                    '    header_name = doctype_running_table.Rows(0).Item("PREFIX_NAME").ToString & Now.Year.ToString("#")
                    'Else
                    '    header_name = doctype_running_table.Rows(0).Item("PREFIX_NAME").ToString & Microsoft.VisualBasic.Right(Now.Year.ToString("#"), 2)
                    'End If 'จบ '(ดีดี การ์เด้น โฮม) ไม่เอาตัวเลข เดือน

                End If
            Else
                header_name = doctype_running_table.Rows(0).Item("PREFIX_NAME").ToString
            End If
            header_width = header_name.Length 'อักษรหน้า
            number_width = doctype_running_table.Rows(0).Item("DT_RUNNING") 'เลข running
            separate_width = doctype_running_table.Rows(0).Item("DT_DATE_SEPARATE").ToString.Length
        Else
            tbx.Select()
            Exit Sub
        End If

        Dim data_inv As New DataSet
        Dim sql_inv As String = "SELECT TOP 1"
        sql_inv &= " TRH_NO,SUBSTRING(TRH_NO," & header_width + separate_width + 1 & ",10) AS NUM_START"
        sql_inv &= " FROM TRANMAIN"
        sql_inv &= " WHERE"
        sql_inv &= " LEFT(TRH_NO," & header_width & ")='" & header_name & "'" 'ลูกค้าปกติทั่วไป
        'If doctype_running_table.Rows(0).Item("DT_DATE_SELECT") = True Then 'เฉพาะลูกค้า ห้างหุ้นส่วนจำกัดวี.ที.เอ็นจิเนียริ่ง(2018) และลูกค้า แสงอรุณ เดคคอร์ //ดีดี การ์เด้น โฮม ไม่ต้องการ รันนิ่ง เมื่อขึ้นเดือนใหม่ ให้รันนิ่ง ปีใหม่ เท่านั้น
        '    sql_inv &= " LEFT(TRH_NO," & header_width - 2 & ")='" & Microsoft.VisualBasic.Left(header_name, header_name.Length - 2) & "'"
        'Else
        '    sql_inv &= " LEFT(TRH_NO," & header_width & ")='" & header_name & "'"
        'End If 'End เฉพาะลูกค้า

        sql_inv &= " AND ISNUMERIC(SUBSTRING(TRH_NO," & header_width + separate_width + 1 & ",10))=1"
        sql_inv &= " AND LEN(SUBSTRING(TRH_NO," & header_width + separate_width + 1 & ",10))=" & number_width
        sql_inv &= " ORDER BY TRH_NO DESC"
        Dim cmd_inv As New SqlCommand(sql_inv, cnn_sql_main)
        Dim adapter_inv As New SqlDataAdapter(cmd_inv)
        adapter_inv.Fill(data_inv, "DOC_INV")
        If data_inv.Tables("DOC_INV").Rows.Count > 0 Then
            strIDAcc = header_name & doctype_running_table.Rows(0).Item("DT_DATE_SEPARATE").ToString & (Integer.Parse(data_inv.Tables("DOC_INV").Rows(0).Item("NUM_START")) + 1).ToString(StrDup(number_width, "0")) 'strdup คือการ นับจำนวน format ตัวเลข
            tbx.Text = strIDAcc
        Else
            strIDAcc = header_name & doctype_running_table.Rows(0).Item("DT_DATE_SEPARATE").ToString & 1.ToString(StrDup(number_width, "0")) 'ถ้าไม่พบรหัสก่อนนี้ ให้ run ใหม่
            tbx.Text = strIDAcc
        End If
    End Sub
    Friend Function invoice_print_table(ByVal id As Integer) As DataTable
        Dim DT As New DataSet '
        Dim sql As String = "SELECT"
        sql &= " TRH_ID, TRH_DT,"
        sql &= " TRH_DATE, TRH_NO,"
        sql &= " CUS_ID, CUS_CODE, CUS_NAME, CUS_BRANCH, CUS_TAXID,"
        sql &= " LTRIM(CASE WHEN CUS_ADDB1 IS NULL THEN '' ELSE CUS_ADDB1 END + CHAR(13) + CASE WHEN CUS_ADDB2 IS NULL THEN '' ELSE CUS_ADDB2 END) + ' ' +"
        sql &= " LTRIM(CASE WHEN CUS_PROVINCE IS NULL THEN '' ELSE (CASE WHEN LEN(CUS_PROVINCE)>0 THEN"
        sql &= " (CASE WHEN CUS_PROVINCE LIKE 'กรุงเทพ%' OR ASCII(LEFT(CUS_PROVINCE,1))<161 THEN CUS_PROVINCE ELSE 'จ.'+CUS_PROVINCE END) ELSE '' END) END) + ' ' +" 'เฉพาะ ลค.วีที ใช้คำว่า จังหวัด
        sql &= " CASE WHEN CUS_POST IS NULL THEN '' ELSE CUS_POST END AS ADDRESS,"
        sql &= " CUS_TEL, CUS_FAX,"
        sql &= " SLMN_ID, SLMN_CODE, SLMN_NAME,"
        sql &= " TRH_VAT_NO, TRH_VAT_DATE,"
        sql &= " TRH_SHIP_DATE, TRH_BILL_DATE,"
        sql &= " TRH_CANCEL_DATE, TRH_CUS,"
        sql &= " TRH_SLMN, TRH_TERM, TRH_DUE,"
        sql &= " TRH_REF_PO, TRH_REF_SO, TRH_REF_PERSON,"
        sql &= " TRH_VATIO, TRH_VAT, TRH_VAT_TY, TRH_VAT_R,"
        sql &= " TRH_N_QTY, TRH_N_ITEMS,"
        sql &= " TRH_G_KEYIN, TRH_DISC_STR,TRH_DISC, TRH_DISC_AMT, TRH_G_SELL,TRH_G_SNV,"
        sql &= " TRH_G_SV, TRH_G_VAT, TRH_G_NET,"
        sql &= " TRH_REMARK, TRH_DOC_STATUS, TRH_STATUS,"
        sql &= " TRH_CREATE_BY, TRH_CREATE,"
        sql &= " TRD_ID, TRD_TRH, TRD_SEQ,TRD_SKU,"
        sql &= " TRD_SKU_CODE, TRD_SKU_NAME,"
        sql &= " TRD_UNIT, TRD_VAT_TY, TRD_VAT_R, TRD_QTY, TRD_UPC,"
        sql &= " TRD_DISC_STR,TRD_DISC, TRD_DISC_AMT, TRD_G_KEYIN,"
        sql &= " TRD_REMARK, TRD_CREATE,0 AS TYPE"
        sql &= " FROM TRANMAIN LEFT JOIN TRANDETAIL ON TRANMAIN.TRH_ID = TRANDETAIL.TRD_TRH" 'ไม่มีรายการสินค้า ก็แสดงได้
        sql &= " JOIN CUSTOMER ON TRANMAIN.TRH_CUS = CUSTOMER.CUS_ID"
        sql &= " JOIN SALESMAN ON TRANMAIN.TRH_SLMN = SALESMAN.SLMN_ID"
        sql &= " WHERE TRH_ID=" & id
        sql &= " ORDER BY TRH_DATE,TRH_NO,TRD_SEQ"
        Try 'ตรวจสอบ connection
            Dim cmd_dept As New SqlCommand(sql, cnn_sql_main)
            Dim adapter_dept As New SqlDataAdapter(cmd_dept)
            adapter_dept.Fill(DT, "INVOICE_PRINT")
            Return DT.Tables("INVOICE_PRINT")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module
