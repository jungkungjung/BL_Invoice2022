Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Reflection

Module Module_plan
    Friend cnn_str As String = "" 'ดึง connection จาก ini เพื่อใช้สำหรับหน้าจอ บันทึก
    Friend cnn_sql As SqlConnection

    'Friend cnn_menaul As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=D:\data\INVOICE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
    'Friend db_str As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Data\INVOICE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
    'Friend db_str As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=D:\data\INVOICE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
    'Friend db_str As String = "Data Source=127.0.0.1;Initial Catalog=invoice;User ID=sa;Password=1234"
    'Friend db_conn As New SqlConnection(db_str)
    Friend cnn_sql_main As SqlConnection
    Public Sub EnableDoubleBuffered(ByVal dgv As DataGridView) 'วิธีโหลด datagrid ให้เร็วขึ้น
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, True, Nothing)
    End Sub
    Public Function EQToDataTable(ByVal parIList As System.Collections.IEnumerable) As System.Data.DataTable
        Dim ret As New System.Data.DataTable()
        Try
            Dim ppi As System.Reflection.PropertyInfo() = Nothing
            If parIList Is Nothing Then Return ret
            For Each itm In parIList
                If ppi Is Nothing Then
                    ppi = DirectCast(itm.[GetType](), System.Type).GetProperties()
                    For Each pi As System.Reflection.PropertyInfo In ppi
                        Dim colType As System.Type = pi.PropertyType
                        If (colType.IsGenericType) AndAlso
                           (colType.GetGenericTypeDefinition() Is GetType(System.Nullable(Of ))) Then colType = colType.GetGenericArguments()(0)
                        ret.Columns.Add(New System.Data.DataColumn(pi.Name, colType))
                    Next
                End If
                Dim dr As System.Data.DataRow = ret.NewRow
                For Each pi As System.Reflection.PropertyInfo In ppi
                    dr(pi.Name) = If(pi.GetValue(itm, Nothing) Is Nothing, DBNull.Value, pi.GetValue(itm, Nothing))
                Next
                ret.Rows.Add(dr)
            Next
        Catch ex As Exception
            ret = New System.Data.DataTable()
        End Try
        Return ret
    End Function
    'Function BahtText(ByVal sNum)
    '    Dim sNumber As String() = {"", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า"}
    '    Dim sDigit As String() = {"", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน"}
    '    Dim sDigit10 As String() = {"", "สิบ", "ยี่สิบ", "สามสิบ", "สี่สิบ", "ห้าสิบ", "หกสิบ", "เจ็ดสิบ", "แปดสิบ", "เก้าสิบ"}
    '    Dim nLen, sWord
    '    Dim sByte1, I, J

    '    sNum = Replace(FormatNumber(sNum, 2), ",", "")
    '    nLen = Len(sNum)

    '    If sNum = ".00" Then BahtText = "ศูนย์"
    '    For I = 1 To nLen - 3
    '        J = (15 + nLen - I) Mod 6
    '        sByte1 = Mid(sNum, I, 1)
    '        If sByte1 <> "0" Then
    '            If J = 1 Then sWord = sDigit10(sByte1) Else sWord = sNumber(sByte1) & sDigit(J)
    '            BahtText = BahtText & sWord
    '        End If
    '        If J = 0 And I <> nLen - 3 Then BahtText = BahtText & "ล้าน" : BahtText = Replace(BahtText, "หนึ่งล้าน", "เอ็ดล้าน")
    '    Next
    '    If Microsoft.VisualBasic.Left(sNum, 1) = "1" Then BahtText = Replace(BahtText, "เอ็ดล้าน", "หนึ่งล้าน")
    '    If Microsoft.VisualBasic.Left(sNum, 2) = "11" Then BahtText = Replace(BahtText, "สิบหนึ่งล้าน", "สิบเอ็ดล้าน")
    '    If Len(BahtText) > 0 Then BahtText = BahtText & "บาท"
    '    If nLen > 4 Then BahtText = Replace(BahtText, "หนึ่งบาท", "เอ็ดบาท")
    '    sNum = Microsoft.VisualBasic.Right(sNum, 2)
    '    If sNum = "00" Then
    '        BahtText = BahtText & "ถ้วน"
    '    Else
    '        If Microsoft.VisualBasic.Left(sNum, 1) <> "0" Then BahtText = BahtText & sDigit10(Microsoft.VisualBasic.Left(sNum, 1))
    '        If Microsoft.VisualBasic.Right(sNum, 1) <> "0" Then BahtText = BahtText & sNumber(Microsoft.VisualBasic.Right(sNum, 1))
    '        BahtText = BahtText & "สตางค์"
    '        If Microsoft.VisualBasic.Left(sNum, 1) <> "0" Then BahtText = Replace(BahtText, "หนึ่งสตางค์", "เอ็ดสตางค์")
    '    End If
    'End Function

    Friend Function cal_term(ByVal term_day As Integer, ByVal date_start As DateTime) As DateTime 'คำนวณ duedate
        Dim result As DateTime
        result = date_start.AddDays(term_day)
        Return result
    End Function
    Friend Function discountstep(ByVal amt As Decimal, ByVal disc_step As String) As Decimal 'คำนวณส่วนลดแบบ step แบบหักสะสม ลงเรื่อยๆ
        'ใช้เครื่องหมาย + เพื่อลดตามสเต็ป โดยลดบาท ใช้ตัวเลขปกติ ลด% ใช้เครื่องหมาย% หลังตัวเลข เช่น 10+5%+2%+400
        Dim result As Decimal 'ยอดลดสะสม
        Dim x As String() = disc_step.Split("+"c) 'สัญลักษณ์การลดที่กรอก มี + เป็นตัวคั่น
        For Each s As String In x
            Dim disc_percen As Decimal
            If Microsoft.VisualBasic.Right(s.Trim, 1) = "%" Then
                If IsNumeric(s.Trim.Remove(s.Trim.Length - 1)) Then
                    disc_percen = Decimal.Parse(s.Trim.Remove(s.Trim.Length - 1))
                    amt = amt - ((amt * disc_percen) / 100)
                End If
            ElseIf IsNumeric(s.Trim) Then
                amt = amt - Decimal.Parse(s.Trim)
            End If
        Next
        result = amt
        Return result
    End Function
    Friend Function disc_multi(ByVal amt As Decimal, ByVal disc_str As String) As Decimal 'คำนวณส่วนลดแบบ %และบาท โดยใช้เครื่องหมาย + คั่น กรณีลดหลายแบบ แต่ไม่ใช่แบบ step
        'ใช้เครื่องหมาย + คั่น โดยลดบาท ใช้ตัวเลขปกติ ลด% ใช้เครื่องหมาย% หลังตัวเลข เช่น 10+5%+2%+400
        Dim result As Decimal
        Dim x As String() = disc_str.Split("+"c) 'สัญลักษณ์การลดที่กรอก มี + เป็นตัวคั่น
        For Each s As String In x
            Dim disc_percen As Decimal
            If Microsoft.VisualBasic.Right(s.Trim, 1) = "%" Then
                If IsNumeric(s.Trim.Remove(s.Trim.Length - 1)) Then
                    disc_percen = Decimal.Parse(s.Trim.Remove(s.Trim.Length - 1))
                    result += (amt * disc_percen) / 100
                End If
            ElseIf IsNumeric(s.Trim) Then
                result += Decimal.Parse(s.Trim)
            End If
        Next
        Return Math.Round(result, 2, MidpointRounding.AwayFromZero)
    End Function
    Friend Function disc_calpercen(ByVal amt As Decimal, ByVal disc_str As String) As Decimal 'คำนวณส่วนลดแบบ %และบาท โดยใช้เครื่องหมาย + คั่น กรณีลดหลายแบบ แต่ไม่ใช่แบบ step
        'ใช้เครื่องหมาย + คั่น โดยลดบาท ใช้ตัวเลขปกติ ลด% ใช้เครื่องหมาย% หลังตัวเลข เช่น 10+5%+2%+400
        Dim result As Decimal
        Dim x As String() = disc_str.Split("+"c) 'สัญลักษณ์การลดที่กรอก มี + เป็นตัวคั่น
        For Each s As String In x
            Dim disc_percen As Decimal
            If Microsoft.VisualBasic.Right(s.Trim, 1) = "%" Then
                If IsNumeric(s.Trim.Remove(s.Trim.Length - 1)) Then
                    disc_percen = Decimal.Parse(s.Trim.Remove(s.Trim.Length - 1))
                    result += (amt * disc_percen) / 100
                End If
            ElseIf IsNumeric(s.Trim) Then
                result += Decimal.Parse(s.Trim)
            End If
        Next
        If amt > 0 Then
            result = (result / amt) * 100
        Else
            result = 0
        End If
        Return Math.Round(result, 6, MidpointRounding.AwayFromZero) '% ลดท้ายบิล ใช้ทศนิยม 6 ตำแหน่ง เพื่อไปเฉลี่ยส่วนลดในรายการ
    End Function
    Friend Function my_discount(ByVal g_keyin As Double, ByVal disc_rate As Double) As Double
        Dim result As Double
        If disc_rate > 0 Then 'คิดเฉพาะ % มากกว่า 0
            result = (g_keyin * disc_rate) / 100
        End If
        Return Math.Round(result, 2, MidpointRounding.AwayFromZero)
    End Function
    Friend Function my_after_discount(ByVal g_keyin As Double, ByVal disc_rate As Double) As Double
        Dim result As Double
        If disc_rate > 0 Then 'คิดเฉพาะ % มากกว่า 0
            result = g_keyin - Math.Round(((g_keyin * disc_rate) / 100), 2, MidpointRounding.AwayFromZero)
        Else
            result = g_keyin
        End If
        Return Math.Round(result, 2, MidpointRounding.AwayFromZero)
    End Function
    Friend Function my_b4vat(ByVal vatio As Integer, ByVal vat_rate As Double, ByVal g_amt As Double) As Double
        Dim result As Double
        If vatio = 0 Then 'ยังไม่รวมภาษี
            result = g_amt
        ElseIf vatio = 1 Then
            'result = Math.Round(g_amt * (100 / (100 + vat_rate)), 6, MidpointRounding.AwayFromZero)
            result = g_amt * (100 / (100 + vat_rate))
        End If
        Return Math.Round(result, 2, MidpointRounding.AwayFromZero) 'result
    End Function
    Friend Function my_vat(ByVal vatio As Integer, ByVal vat_rate As Double, ByVal g_amt As Double) As Double
        Dim keyin As Double
        Dim amt As Double
        Dim result As Double
        If vatio = 0 Then 'ยังไม่รวมภาษี
            keyin = Math.Round(g_amt, 2, MidpointRounding.AwayFromZero)
            amt = Math.Round(g_amt * ((100 + vat_rate) / 100), 2, MidpointRounding.AwayFromZero) 'ใช้วิธีนี้ แก้ปัญหาปัดทศนิยม หลังบวก trh_vat แล้ว ไม่ตรงกับ trh_net
            result = amt - keyin
        ElseIf vatio = 1 Then
            keyin = Math.Round(g_amt * (100 / (100 + vat_rate)), 2, MidpointRounding.AwayFromZero) ''ใช้วิธีนี้ แก้ปัญหาปัดทศนิยม หลังบวก trh_vat แล้ว ไม่ตรงกับ trh_net
            amt = Math.Round(g_amt, 2, MidpointRounding.AwayFromZero)
            result = amt - keyin
        End If
        Return Math.Round(result, 2, MidpointRounding.AwayFromZero) 'result
    End Function
    Friend Function my_amt(ByVal vatio As Integer, ByVal vat_rate As Double, ByVal g_amt As Double) As Double
        Dim result As Double
        If vatio = 0 Then 'ยังไม่รวมภาษี
            result = g_amt * ((100 + vat_rate) / 100)
        ElseIf vatio = 1 Then
            result = g_amt
        End If
        Return Math.Round(result, 2, MidpointRounding.AwayFromZero)
    End Function
    Friend Function trd_check_vatstep(ByVal grw As DataGridView, ByVal trh_vat_rate As Double) As Integer
        'จุดประสงค์ เอาไว้เช็ค กรณีมีสินค้าหลายรายการ  เผลรวมยอดภาษี อาจมีการปัดเศษทศนิยม ไม่ตรง ให้เช็คว่า ภาษีทุกรายการเป็นอัตราเดียวกันมั้ย ถ้าใช่ให้หาผลรวม เพื่อไปปัดเศษรายการสุดท้าย ให้ถูกต้อง
        Dim same_vat As Integer 'เช็คก่อนว่า ทุกรายการ อัตราภาษี เหมือนกันมั้ย
        For Each row3 As DataGridViewRow In grw.Rows
            If trh_vat_rate = row3.Cells("TRD_VAT_R").Value Then
                same_vat += 0
            Else
                same_vat += 1
            End If
        Next
        Return same_vat
    End Function
    'Friend Function trd_vatlast_amt(ByVal vatio As Integer, ByVal trh_vat_rate As Double, ByVal g_amt As Double) As Double
    '    'ยอดภาษี เอาท้ายบิล หายอดภาษีตรงๆ เพื่อเอาไปปัดเศษ มูลค่าภาษี ตามรายการสินค้า
    '    Dim keyin As Double
    '    Dim amt As Double
    '    Dim result As Double
    '    'หาค่า อัตราภาษีรวม กรณีคูณจากรายการสินค้า แล้วท้ายบิล มีเศษเกิน ต่างจากยอดภาษีเต็ม ที่ควรจะเป็น เนื่องจาก เป็นผลรวม ยอดภาษี หลายรายการ อาจมีการปัดเศษทศนิยม ไม่ตรง
    '    If vatio = 0 Then 'ยังไม่รวมภาษี
    '        keyin = g_amt
    '        amt = g_amt * ((100 + trh_vat_rate) / 100)
    '        result = amt - keyin
    '    ElseIf vatio = 1 Then
    '        keyin = g_amt * (100 / (100 + trh_vat_rate))
    '        amt = g_amt
    '        result = amt - keyin
    '    End If
    '    Return Math.Round(result, 2, MidpointRounding.AwayFromZero) 'result
    'End Function
    'Public Function ConvertToLetter(ByVal num As Integer) As String
    '    '    num = num - 1
    '    '    If num < 0 Or num >= 27 * 26 Then
    '    '        ConvertToLetter = "-"
    '    '    Else
    '    '        If num < 26 Then
    '    '            ConvertToLetter = Chr(num + 65)
    '    '        Else
    '    '            ConvertToLetter = Chr(num \ 26 + 64) + Chr(num Mod 26 + 65)
    '    '        End If
    '    '    End If
    'End Function
    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Function splittext(ByVal oldtext As String, ByVal b4text As String) As String
        'Chr(13)&chr(10) เครื่องหมาย enter ขึ้นบรรทัดใหม่
        Dim result_b4 As String = "" 'ผลลัพท์การหั่น ชุดแรก
        Dim result_midle As String = "" 'BF- ซ้ำชุดแรก อีกรอบ
        Dim result As String = ""
        Dim min_position() As Integer
        Dim midle_position() As Integer
        Dim last_position() As Integer
        If oldtext.Trim.StartsWith(b4text) Then 'b4text หั่นตัวหน้าออกก่อน ด้วยเครื่องหมายแรกคือ b4_sp1,ตามด้วย b4_sp2
            min_position = {oldtext.Trim.IndexOf(Chr(9)), oldtext.Trim.IndexOf(","), oldtext.Trim.IndexOf(Chr(13)), oldtext.Trim.IndexOf(" ")}
            Dim x = (From t In min_position
                   Where t > -1)
            If x.Count = 0 Then
                result_b4 = oldtext.Trim
            Else
                result_b4 = (Mid(oldtext.Trim, x.Min + 2)).Trim
            End If
        Else
            result_b4 = oldtext.Trim
        End If

        'BF- ซ้ำชุดแรก อีกรอบ
        If result_b4.StartsWith(b4text) Then 'b4text หั่นตัวหน้าออกก่อน ด้วยเครื่องหมายแรกคือ b4_sp1,ตามด้วย b4_sp2
            midle_position = {result_b4.IndexOf(Chr(9)), result_b4.IndexOf(","), result_b4.IndexOf(Chr(13)), result_b4.IndexOf(" ")}
            Dim x = (From t In midle_position
                   Where t > -1)
            If x.Count = 0 Then
                result_midle = result_b4
            Else
                result_midle = (Mid(result_b4, x.Min + 2)).Trim
            End If
        Else
            result_midle = result_b4
        End If

        'นำผลลัพท์การหั่น ชุดกลาง มาหาค่า indexof น้อยสุด
        last_position = {result_midle.IndexOf(Chr(9)), result_midle.IndexOf(","), result_midle.IndexOf(Chr(13)), result_midle.IndexOf(" ")}
        Dim y = (From n In last_position
                  Where n > -1)
        If y.Count = 0 Then
            result = result_midle
        Else
            result = Mid(result_midle, 1, y.Min)
        End If
        Return result
    End Function

    Public Function splittest(ByVal oldtext As String, ByVal b4text As String, ByVal b4_sp1 As String, ByVal b4_sp2 As String) As String
        Dim result_b4 As String = "" 'ผลลัพท์การหั่น ชุดแรก
        Dim result As String = ""
        'Dim ix1, ix2 As Integer
        Dim min_position() As Integer
        If oldtext.Trim.StartsWith(b4text) Then 'b4text หั่นตัวหน้าออกก่อน ด้วยเครื่องหมายแรกคือ b4_sp1,ตามด้วย b4_sp2
            min_position = {oldtext.Trim.IndexOf(Chr(9)), oldtext.Trim.IndexOf(","), oldtext.Trim.IndexOf(Chr(13)), oldtext.Trim.IndexOf(" ")}
            Dim x = (From t In min_position
                   Where t > -1)
            If x.Count = 0 Then
                result_b4 = oldtext.Trim
            Else
                result_b4 = Mid(oldtext.Trim, x.Min + 2)
            End If
        Else
            result_b4 = oldtext.Trim
        End If
        'นำผลลัพท์การหั่น ชุดแรก มา split ตามลำดับ
        Return result_b4
    End Function
    'Friend head_color As Color = Color.Teal
    Friend login_name As String
    Friend login_th_name As String
    Friend DI_KEY As Integer = 0
    Public Sub MAX_KEY() 'หาค่า max key
        Dim data_max As New DataSet
        data_max.Clear()
        Dim TRH_KEY As Integer = 0
        Dim TRD_KEY As Integer = 0
        Dim DR_KEY As Integer = 0
        Dim sql_doc As String = "SELECT MAX(DI_KEY) AS MAX_DI FROM DOCINFO"
        Dim cmd_doc As New SqlCommand(sql_doc, cnn_sql)
        Dim adapter_doc As New SqlDataAdapter(cmd_doc)
        adapter_doc.Fill(data_max, "DOC")

        Dim sql_tranh As String = "SELECT MAX(TRH_KEY) AS MAX_H FROM TRANSTKH"
        Dim cmd_tranh As New SqlCommand(sql_tranh, cnn_sql)
        Dim adapter_tranh As New SqlDataAdapter(cmd_tranh)
        adapter_tranh.Fill(data_max, "TRANH")

        Dim sql_trand As String = "SELECT MAX(TRD_KEY) AS MAX_D FROM TRANSTKD"
        Dim cmd_trand As New SqlCommand(sql_trand, cnn_sql)
        Dim adapter_trand As New SqlDataAdapter(cmd_trand)
        adapter_trand.Fill(data_max, "TRAND")

        'SELECT DR_SEQ, DR_KEY FROM DOCRUN WHERE (DR_DT = 82) AND (DR_YEAR = 2019) AND (DR_MONTH = 9)
        Dim sql_docrun As String = "SELECT MAX(DR_KEY) AS MAX_D FROM DOCRUN"
        Dim cmd_docrun As New SqlCommand(sql_docrun, cnn_sql)
        Dim adapter_docrun As New SqlDataAdapter(cmd_docrun)
        adapter_docrun.Fill(data_max, "DOCRUN")

        Dim sql_syn As String = "SELECT * FROM BPLUSSYNC WHERE SYN_KEY= 1"
        Dim cmd_syn As New SqlCommand(sql_syn, cnn_sql)
        Dim adapter_syn As New SqlDataAdapter(cmd_syn)
        adapter_syn.Fill(data_max, "SYNC")

        DI_KEY = data_max.Tables("DOC").Rows(0).Item(0) + 1
        'MAX_TRH = data_max.Tables("TRANH").Rows(0).Item(0) + 1
        'MAX_TRD = data_max.Tables("TRAND").Rows(0).Item(0) + 1
        'MAX_DR = data_max.Tables("DOCRUN").Rows(0).Item(0) + 1
        'MAX_SYNC = Integer.Parse(data_max.Tables("SYNC").Rows(0).Item("SYN_LASTSEND")) + 1
    End Sub
    Friend Function currency_input(ByVal txt As TextBox, ByVal str As Char) As Boolean
        If IsNumeric(str) = True Then
            Return False
        End If
        If CBool(((Convert.ToString(str) = "." AndAlso CBool(InStr(txt.Text, "."))))) Then
            Return True
        End If
        If Convert.ToString(str) = "." OrElse str = vbBack Then
            Return False
        End If
        Return True
    End Function
    'e.Handled = currency_guna(ps_salary, e.KeyChar) 'วิธีใช้ ให้ใช้กับ event keypress
    Friend Function currency_guna(ByVal txt As Guna.UI.WinForms.GunaTextBox, ByVal str As Char) As Boolean
        If IsNumeric(str) = True Then
            Return False
        End If
        If CBool(((Convert.ToString(str) = "." AndAlso CBool(InStr(txt.Text, "."))))) Then
            Return True
        End If
        If Convert.ToString(str) = "." OrElse str = vbBack Then
            Return False
        End If
        Return True
    End Function
    Friend Function integer_input(ByVal str As Char) As Boolean
        Dim result As Boolean
        If str = vbBack Then
            Return False
        ElseIf str < "0" OrElse str > "9" Then
            result = True
        End If
        Return result
    End Function
    Friend Function integer_guna(ByVal str As Char) As Boolean
        Dim result As Boolean
        If str = vbBack Then
            Return False
        ElseIf str < "0" OrElse str > "9" Then
            result = True
        End If
        Return result
    End Function
End Module
