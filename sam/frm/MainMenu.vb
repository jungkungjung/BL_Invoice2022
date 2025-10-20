Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Security.AccessControl
Imports System
Imports System.ServiceProcess
Imports System.Diagnostics
Imports System.Threading
Public Class MainMenu
    Dim File_ini = Path.Combine(System.Windows.Forms.Application.StartupPath, "DB_Config.ini")
    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sqlservice_check() '===ตรวจสอบ sql service ว่า start รึมั้ย ถ้าปิดยุ ให้ start
            read_connection()
            status_show_ini() 'แสดงชื่อ database
            Check_iniconnect() 'ตรวจสอบไฟล์ ini ถ้าข้อมูลไม่มี ให้เปิดหน้าจอ กำหนด Database
            write_permission_ini() 'กำหนด permission เปิดโปรแกรมครั้งแรก
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub read_connection()
        Try
            'ดึง connection จาก ini เพื่อใช้สำหรับหน้าจอ บันทึก
            'cnn_str = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30;User Instance=True"
            'cnn_str เอาไว้อ้าง connection หน้าจอบันทึก โดยใช้หลัก fillby อ่าน connection จาก ini แทน โดยไม่ใช้ตัวเดียวกับ con_str1 เนื่องจากมันเพื้ยน เหมือนเก็บค่าให้ใช้ครั้งเดียว แล้วเคลียร์ทิ้ง จึงสร้าง ตัวแปรต่างหาก เพื่อรับค่า
            'อ่านค่า connection string
            Dim con_str1 As String = ""
            If ReadIni(File_ini, "DATABASE", "DB_TYPE", "").ToUpper = "MSSQL" Then 'MSSQL ปกติ
                cnn_str = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";Initial Catalog=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";User ID=" & ReadIni(File_ini, "DATABASE", "USER_ID", "") & "; password=" & ReadIni(File_ini, "DATABASE", "PASSWORD", "")
                con_str1 = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";Initial Catalog=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";User ID=" & ReadIni(File_ini, "DATABASE", "USER_ID", "") & "; password=" & ReadIni(File_ini, "DATABASE", "PASSWORD", "")
            ElseIf ReadIni(File_ini, "DATABASE", "DB_TYPE", "").ToUpper = "MSSQL DATABASE FILE" Then 'mssql แบบ database file (mssql express)
                'cnn_str = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30;User Instance=True"
                'con_str1 = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30;User Instance=True"

                'ทดสอบ ตัด user_instance ออก กรณี ลค.นครจิระชัย error เกี่ยวกับ instance
                cnn_str = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30"
                con_str1 = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30;"
            ElseIf ReadIni(File_ini, "DATABASE", "DB_TYPE", "").ToUpper = "LOCALDB" Then 'แบบ localDb
                cnn_str = "server=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30"
                con_str1 = "server=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30"
            End If
            'system_ini = ReadIni(File_ini, "DATABASE", "SYSTEM", "")
            'con_str1 = "Data Source=" & ReadIni(File_ini, "DATABASE", "HOST_NAME", "") & ";AttachDbFilename=" & ReadIni(File_ini, "DATABASE", "DB_NAME", "") & ";Integrated Security=True;Connect Timeout=30;User Instance=True"
            'cnn_str ต้อง assign ค่าจาก mainmenu ไม่สามารถส่งค่า ตอนเปิดฟอร์มได้
            cnn_sql_main = New SqlConnection(con_str1) 'สร้าง sqlconnection ใช้ทั้งโปรแกรม
            If ReadIni(File_ini, "DATABASE", "SYSTEM", "") = "1" Then 'เข้าแก้ไข หน้าจอ structure ได้
                edit_structure_strip.Visible = True
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub Check_iniconnect()
        Try
            If File.Exists(File_ini) = True Then
                If ReadIni(File_ini, "DATABASE", "HOST_NAME", "").Trim.Length = 0 Then 'ไม่มีการกำหนดค่า ini หาค่าจาก host_name
                    MsgBox("กรุณาตั้งค่าการเชื่อมต่อ Database" & vbNewLine & Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                    Close()
                Else
                    If cnn_sql_main.State = ConnectionState.Closed Then
                        Try
                            cnn_sql_main.Open()
                            cnn_sql_main.Close()
                        Catch ex As Exception
                            'MessageBox.Show(Err.Number)
                            MsgBox("พบข้อผิดพลาดในการเชื่อมต่อ Database โปรดตรวจสอบ" & vbNewLine & Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                            Close()
                        Finally
                        End Try
                    End If
                End If
            Else
                'MsgBox("NO ini FILE") ให้เปิดหน้าจอ การตั้งค่า database
                MsgBox("ไม่พบไฟล์ ini กรุณาตั้งค่าการเชื่อมต่อ Database ใหม่" & vbNewLine & Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
                Close()
                'Dim frm As New db_connection
                'frm.MdiParent = Me
                'frm.Dock = DockStyle.Fill
                'frm.Show()
                'frm.host_txt.Select()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect ini file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub write_permission_ini()
        'กำหนด permission ให้ folder โปรแกรม เนื่องจาก window10 จะ read-write ฐานข้อมูลไม่ได้ ต้อง menual
        Try
            If ReadIni(File_ini, "DATABASE", "DB_PERMISSION", "") = "0" Then '0 คือค่า เปิดโปรแกรมครั้งแรก ให้กำหนด permission เลย โดยตั้งเป็น everyone แบบ full control
                Dim FolderPath As String = Application.StartupPath
                Dim UserAccount As String = "Everyone"
                Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(FolderPath)
                Dim FolderAcl As New DirectorySecurity
                FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.Modify, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
                'FolderAcl.SetAccessRuleProtection(True, False) 'uncomment to remove existing permissions
                FolderInfo.SetAccessControl(FolderAcl)
                writeIni(File_ini, "DATABASE", "DB_PERMISSION", 1) 'กำหนด db_permission =1 ครั้งต่อไปไม่ต้องเช็ค
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
            Exit Sub
        End Try
    End Sub
    Private Sub status_show_ini()
        'Dim host_status As String = ""
        'Dim db_status As String = ""
        ''แสดงค่า connection
        'host_status = ReadIni(File_ini, "DATABASE", "HOST_NAME", "")
        'db_status = ReadIni(File_ini, "DATABASE", "DB_NAME", "")
        'status_1.Text = "Host : " & host_status & "   Database : " & db_status
        status_1.Text = ProductName & "  Version " & ProductVersion
    End Sub

    Private Sub ToolStripButton8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.Click
        Close()
    End Sub

    Private Sub ToolStripButton14_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton14.Click
        Close()
    End Sub

    Private Sub ToolStripButton5_Click_2(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        Process.Start("http://www.ktsupport.co.th/Contact%20us.html")
    End Sub

    Private Sub ToolStripButton17_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton17.Click
        Try
            Dim frm As New products_type_profile
            frm.MdiParent = Me
            frm.Dock = DockStyle.Fill
            frm.Show()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub ToolStripButton28_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton28.Click
        Close()
    End Sub
    Private Sub Tool_customer_Click(sender As System.Object, e As System.EventArgs) Handles Tool_customer.Click
        Try
            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of customer_tab).Any Then
                frmCollection.Item("customer_tab").Activate()
            Else
                Dim frm As New customer_tab
                frm.MdiParent = Me
                frm.Dock = DockStyle.Fill
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub Tool_salesman_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salesman.Click
        Try
            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of salesman_tab).Any Then
                frmCollection.Item("salesman_tab").Activate()
            Else
                Dim frm As New salesman_tab
                frm.MdiParent = Me
                frm.Dock = DockStyle.Fill
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub Tool_supplier_Click(sender As System.Object, e As System.EventArgs)
        'Dim frmCollection = System.Windows.Forms.Application.OpenForms
        'If frmCollection.OfType(Of supplier_profile).Any Then
        '    frmCollection.Item("supplier_profile").Activate()
        'Else
        '    Dim frm As New supplier_profile
        '    frm.MdiParent = Me
        '    frm.Dock = DockStyle.Fill
        '    frm.Show()
        'End If

        Dim var = From g In My.Application.OpenForms Where CType(g, Form).Name = "supplier_profile" 'กรณีมีการใช้ฟอร์มเดียวกัน แต่อ้างชื่ออื่น ที่ไม่ใช่ ไม่ต้องตรวจสอบ (customer_profile88)
        'If var.Count > 0 Then
        '    Dim f3 As Form = CType(Application.OpenForms("supplier_profile"), supplier_profile)
        '    f3.Activate()
        'Else
        '    Dim frm As New supplier_profile
        '    frm.MdiParent = Me
        '    frm.Dock = DockStyle.Fill
        '    frm.Show()
        'End If
    End Sub


    Private Sub Tool_config_Click(sender As System.Object, e As System.EventArgs) Handles Tool_config.Click
        Try
            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of coderunning_config).Any Then
                frmCollection.Item("coderunning_config").Activate()
            Else
                Dim frm As New coderunning_config
                frm.MdiParent = Me
                frm.Dock = DockStyle.Fill
                frm.DOCTYPETableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน
                frm.CODE_RUNNINGTableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub Tool_contact_Click(sender As System.Object, e As System.EventArgs) Handles Tool_contact.Click
        Try
            Process.Start("https://BLSALEPAGE.SALEPAGE.IN.TH")
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Tool_company_Click(sender As System.Object, e As System.EventArgs) Handles Tool_company.Click
        Try
            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of company_record_new).Any Then
                frmCollection.Item("company_record_new").Activate()
            Else
                Dim frm As New company_record_new
                frm.MdiParent = Me
                frm.Dock = DockStyle.Fill
                frm.COMPANYTableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub TabControl13_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Tabmain.SelectedIndexChanged
        'If TabControl13.SelectedIndex = 0 Then
        '    'pn_sale.Show()
        '    'pn_purchase.Hide()
        '    sale_pn.Show()
        '    purchase_pn.Hide()
        'ElseIf TabControl13.SelectedIndex = 1 Then
        '    'pn_purchase.Show()
        '    'pn_sale.Hide()
        '    sale_pn.Hide()
        '    purchase_pn.Show()
        'End If

    End Sub

    Private Sub sales_order_mn_Click(sender As System.Object, e As System.EventArgs) Handles sales_order_mn.Click
        Try
            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of doc_tab).Any Then
                frmCollection.Item("doc_tab").Activate()
            Else
                Dim frm As New doc_tab
                frm.MdiParent = Me
                frm.Dock = DockStyle.Fill
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub sales_product_mn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sales_product_mn.Click
        Try
            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of doc_salesproduct_tab).Any Then
                frmCollection.Item("doc_salesproduct_tab").Activate()
            Else
                Dim frm As New doc_salesproduct_tab
                frm.MdiParent = Me
                frm.Dock = DockStyle.Fill
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub quatation_mn_Click(sender As System.Object, e As System.EventArgs) Handles quatation_mn.Click

    End Sub

    Private Sub Tool_products_new_Click(sender As System.Object, e As System.EventArgs) Handles Tool_products_new.Click
        Try
            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of product_tab).Any Then
                frmCollection.Item("product_tab").Activate()
            Else
                Dim frm As New product_tab
                frm.MdiParent = Me
                frm.Dock = DockStyle.Fill
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub ToolStripButton24_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton24.Click
        Close()
    End Sub

    Private Sub ToolStripButton31_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton31.Click
        Close()
    End Sub

    Private Sub Tool_db_Click(sender As System.Object, e As System.EventArgs) Handles Tool_db.Click
        Try
            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of db_connection).Any Then
                frmCollection.Item("db_connection").Activate()
            Else
                Dim frm As New db_connection
                frm.MdiParent = Me
                frm.Dock = DockStyle.Fill
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As System.Object, e As System.EventArgs) Handles GunaAdvenceButton2.Click
        Try
            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of preview_new).Any Then
                frmCollection.Item("preview_new").Activate()
            Else
                Dim frm As New preview_new
                frm.MdiParent = Me
                frm.Dock = DockStyle.Fill
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub edit_structure_strip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_structure_strip.Click
        Try
            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of struture_update_tab).Any Then
                frmCollection.Item("struture_update_tab").Activate()
            Else
                Dim frm As New struture_update_tab
                frm.MdiParent = Me
                frm.Dock = DockStyle.Fill
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub sqlservice_check() 'ตรวจสอบ sqlservice
        Dim sc As New ServiceController '("MSSQLSERVER")
        sc.ServiceName = "MSSQL$SQLEXPRESS" '"MSSQLSERVER" '
        ''If sc.Status = ServiceControllerStatus.Stopped Then
        If sc.Status.Equals(ServiceControllerStatus.Stopped) Or sc.Status.Equals(ServiceControllerStatus.StopPending) Then
            MsgBox("Service is Stoped...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warnning")
            Try
                sc.Start()
                'sc.WaitForStatus(ServiceControllerStatus.Running)
                'sc.WaitForStatus(ServiceProcess.ServiceControllerStatus.Running, System.TimeSpan.FromSeconds(15))
                sc.Refresh()
                MsgBox("Service is Started..", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Result")
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        End If
    End Sub
End Class