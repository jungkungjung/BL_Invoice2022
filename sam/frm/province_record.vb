Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Public Class province_record
    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.PROVINCETableAdapter.Fill(Me.INVOICEDataSet.PROVINCE)
        Pn_not_show.Hide()
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
            PROVINCEBindingSource.AddNew()
            insert_status.Text = "1"
            PROVINCE_NAMETextBox.Select()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        create_job()
    End Sub
    Private Sub save1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_save.Click
        If PROVINCE_NAMETextBox.Text.Trim.Length = 0 Then
            MsgBox("กรุณาระบุชื่อจังหวัด", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            PROVINCE_NAMETextBox.Select()
            Exit Sub
        End If
        Try
            Me.Validate()
            Me.PROVINCEBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            insert_status.Text = "0"
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
            DialogResult = Windows.Forms.DialogResult.OK
            Close()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub delete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna_delete.Click
        If insert_status.Text = "1" Then
            MsgBox("ยังไม่บันทึกข้อมูล", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Exit Sub
        End If
        Try
            '      Dim pro_exists = (From pro In tranmain_detail_table()
            '                      Where pro("TRD_SKU") = Integer.Parse(pro.Text)
            ')
            '      If pro_exists.Count > 0 Then
            '          Dim str As String = ""
            '          For Each row3 As DataRow In pro_exists
            '              str += row3.Item("TRH_DATE") + " " + row3.Item("TRH_NO") + vbNewLine
            '          Next
            '          MsgBox("พบรายการอ้างอิง " + pro_exists.Count.ToString("#,###") + " รายการ ไม่สามารถลบได้" + vbNewLine + str, MsgBoxStyle.Information, "คำเตือน")
            '          Exit Sub
            '      End If

            Dim msgtext As String
            msgtext = MsgBox("ยืนยันการลบข้อมูล", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "คำเตือน")
            If msgtext = vbYes Then
                Me.PROVINCEBindingSource.RemoveCurrent()
                Me.Validate()
                Me.PROVINCEBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
                insert_status.Text = 0
                DialogResult = Windows.Forms.DialogResult.OK
                Close()
                MsgBox("ลบข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
            Else : Return
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub exit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

End Class