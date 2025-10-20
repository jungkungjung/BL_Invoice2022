Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Linq
Imports System.Xml.Linq
Imports System.Configuration
Public Class discout_function
    Private Sub discout_function_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        disc_sum.Text = discountstep(Decimal.Parse(gkeyin_amt.Text), disc_test.Text)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim ISK As Decimal = 0D
        Dim y As Decimal = 1D

        Dim amt As Decimal = Decimal.Parse(gkeyin_amt.Text) 'ยอดก่อนลด
        Dim disc_amt As Decimal = 0.0 'ยอดลบสะสม

        Dim x As String() = disc_test.Text.Split("+"c)
        Dim i As Integer = 0
        For Each s As String In x
            i += 1
            Dim discount As Decimal

            If Decimal.TryParse(s, discount) Then
                'If i = 1 Then
                y = y * (1 - discount / 100D)
                'disc_amt = amt - ((amt * s) / 100)
                amt = amt - ((amt * s) / 100)
                'Else
                '    disc_amt = disc_amt - ((disc_amt * s) / 100)
                'End If
                MsgBox(i)
            End If
        Next
        disc_sum.Text = amt
    End Sub
    Friend Function disc_step(ByVal amt As Decimal, ByVal disc_str As String) As Decimal 'คำนวณส่วนลดแบบ step
        'ใช้เครื่องหมาย + เพื่อลดตามสเต็ป โดยลดบาท ใช้ตัวเลขปกติ ลด% ใช้เครื่องหมาย% หลังตัวเลข เช่น 10+5%+2%+400
        Dim result As Decimal 'ยอดลดสะสม
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
        'result = amt
        Return result
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        disc_sum.Text = disc_step(Decimal.Parse(gkeyin_amt.Text), disc_test.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox4.Text = my_after_discount(Decimal.Parse(TextBox3.Text), Decimal.Parse(disc_test.Text))
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a As Decimal
        a = Decimal.Parse(TextBox1.Text) * Decimal.Parse(TextBox2.Text)
        TextBox3.Text = Math.Round(a, 2)
    End Sub
End Class