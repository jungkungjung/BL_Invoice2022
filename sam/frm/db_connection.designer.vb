<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class db_connection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.db_path = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.data_ty_cmb = New Guna.UI.WinForms.GunaComboBox()
        Me.SurenameLabel = New System.Windows.Forms.Label()
        Me.test_config_bt = New Guna.UI.WinForms.GunaButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.User_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.database_txt = New System.Windows.Forms.TextBox()
        Me.lb_status = New System.Windows.Forms.Label()
        Me.host_txt = New System.Windows.Forms.TextBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.data_ty_str = New System.Windows.Forms.TextBox()
        Me.GunaSeparator4 = New Guna.UI.WinForms.GunaSeparator()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna_exit = New Guna.UI.WinForms.GunaButton()
        Me.Guna_save = New Guna.UI.WinForms.GunaButton()
        Me.Pn_not_show = New System.Windows.Forms.Panel()
        Me.insert_status = New System.Windows.Forms.TextBox()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Pn_not_show.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaGroupBox1.BorderSize = 1
        Me.GunaGroupBox1.Controls.Add(Me.GroupBox2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaControlBox2)
        Me.GunaGroupBox1.Controls.Add(Me.Panel5)
        Me.GunaGroupBox1.Controls.Add(Me.GunaSeparator2)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Silver
        Me.GunaGroupBox1.Location = New System.Drawing.Point(23, 21)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(1095, 362)
        Me.GunaGroupBox1.TabIndex = 1124
        Me.GunaGroupBox1.Text = "Database Config"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.db_path)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.data_ty_cmb)
        Me.GroupBox2.Controls.Add(Me.SurenameLabel)
        Me.GroupBox2.Controls.Add(Me.test_config_bt)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Password_txt)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.User_txt)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.database_txt)
        Me.GroupBox2.Controls.Add(Me.lb_status)
        Me.GroupBox2.Controls.Add(Me.host_txt)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.GroupBox2.Location = New System.Drawing.Point(28, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 215)
        Me.GroupBox2.TabIndex = 1581
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ตั้งค่าฐานข้อมูล"
        '
        'db_path
        '
        Me.db_path.ActiveLinkColor = System.Drawing.Color.LightGray
        Me.db_path.AutoSize = True
        Me.db_path.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.db_path.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.db_path.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.db_path.LinkColor = System.Drawing.Color.DimGray
        Me.db_path.Location = New System.Drawing.Point(438, 91)
        Me.db_path.Name = "db_path"
        Me.db_path.Size = New System.Drawing.Size(29, 16)
        Me.db_path.TabIndex = 1584
        Me.db_path.TabStop = True
        Me.db_path.Text = "เลือก"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(20, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 1583
        Me.Label4.Text = "DB Type"
        '
        'data_ty_cmb
        '
        Me.data_ty_cmb.BackColor = System.Drawing.Color.Transparent
        Me.data_ty_cmb.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.data_ty_cmb.BorderColor = System.Drawing.Color.Silver
        Me.data_ty_cmb.BorderSize = 1
        Me.data_ty_cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.data_ty_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.data_ty_cmb.FocusedColor = System.Drawing.Color.Empty
        Me.data_ty_cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_ty_cmb.ForeColor = System.Drawing.Color.MidnightBlue
        Me.data_ty_cmb.FormattingEnabled = True
        Me.data_ty_cmb.Items.AddRange(New Object() {"MSSQL", "MSSQL DATABASE FILE", "LocalDB"})
        Me.data_ty_cmb.Location = New System.Drawing.Point(93, 32)
        Me.data_ty_cmb.Name = "data_ty_cmb"
        Me.data_ty_cmb.OnHoverItemBaseColor = System.Drawing.Color.LightSeaGreen
        Me.data_ty_cmb.OnHoverItemForeColor = System.Drawing.Color.White
        Me.data_ty_cmb.Radius = 4
        Me.data_ty_cmb.Size = New System.Drawing.Size(339, 23)
        Me.data_ty_cmb.StartIndex = 0
        Me.data_ty_cmb.TabIndex = 1582
        '
        'SurenameLabel
        '
        Me.SurenameLabel.AutoSize = True
        Me.SurenameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SurenameLabel.ForeColor = System.Drawing.Color.DimGray
        Me.SurenameLabel.Location = New System.Drawing.Point(20, 64)
        Me.SurenameLabel.Name = "SurenameLabel"
        Me.SurenameLabel.Size = New System.Drawing.Size(36, 16)
        Me.SurenameLabel.TabIndex = 1407
        Me.SurenameLabel.Text = "Host"
        '
        'test_config_bt
        '
        Me.test_config_bt.AnimationHoverSpeed = 0.07!
        Me.test_config_bt.AnimationSpeed = 0.03!
        Me.test_config_bt.BackColor = System.Drawing.Color.Transparent
        Me.test_config_bt.BaseColor = System.Drawing.Color.Gray
        Me.test_config_bt.BorderColor = System.Drawing.Color.Black
        Me.test_config_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.test_config_bt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.test_config_bt.FocusedColor = System.Drawing.Color.Transparent
        Me.test_config_bt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.test_config_bt.ForeColor = System.Drawing.Color.Gainsboro
        Me.test_config_bt.Image = Nothing
        Me.test_config_bt.ImageSize = New System.Drawing.Size(20, 20)
        Me.test_config_bt.Location = New System.Drawing.Point(164, 176)
        Me.test_config_bt.Name = "test_config_bt"
        Me.test_config_bt.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.test_config_bt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.test_config_bt.OnHoverForeColor = System.Drawing.Color.PaleGoldenrod
        Me.test_config_bt.OnHoverImage = Nothing
        Me.test_config_bt.OnPressedColor = System.Drawing.Color.Black
        Me.test_config_bt.OnPressedDepth = 0
        Me.test_config_bt.Radius = 8
        Me.test_config_bt.Size = New System.Drawing.Size(110, 24)
        Me.test_config_bt.TabIndex = 5
        Me.test_config_bt.Text = "ทดสอบการเชื่อมต่อ"
        Me.test_config_bt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.test_config_bt.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(20, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 1415
        Me.Label2.Text = "Database"
        '
        'Password_txt
        '
        Me.Password_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Password_txt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Password_txt.Location = New System.Drawing.Point(93, 142)
        Me.Password_txt.Name = "Password_txt"
        Me.Password_txt.Size = New System.Drawing.Size(339, 22)
        Me.Password_txt.TabIndex = 4
        Me.Password_txt.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(20, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 1416
        Me.Label1.Text = "Password"
        '
        'User_txt
        '
        Me.User_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.User_txt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.User_txt.Location = New System.Drawing.Point(93, 115)
        Me.User_txt.Name = "User_txt"
        Me.User_txt.Size = New System.Drawing.Size(339, 22)
        Me.User_txt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(20, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 1417
        Me.Label3.Text = "User"
        '
        'database_txt
        '
        Me.database_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.database_txt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.database_txt.Location = New System.Drawing.Point(93, 88)
        Me.database_txt.Name = "database_txt"
        Me.database_txt.Size = New System.Drawing.Size(339, 22)
        Me.database_txt.TabIndex = 2
        '
        'lb_status
        '
        Me.lb_status.AutoSize = True
        Me.lb_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lb_status.Location = New System.Drawing.Point(112, 145)
        Me.lb_status.Name = "lb_status"
        Me.lb_status.Size = New System.Drawing.Size(0, 16)
        Me.lb_status.TabIndex = 1538
        '
        'host_txt
        '
        Me.host_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.host_txt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.host_txt.Location = New System.Drawing.Point(93, 61)
        Me.host_txt.Name = "host_txt"
        Me.host_txt.Size = New System.Drawing.Size(339, 22)
        Me.host_txt.TabIndex = 1
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.IconColor = System.Drawing.Color.DimGray
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(1049, 0)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox2.TabIndex = 1540
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Controls.Add(Me.GunaSeparator4)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Pn_not_show)
        Me.Panel5.Location = New System.Drawing.Point(1, 302)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1093, 59)
        Me.Panel5.TabIndex = 1557
        '
        'data_ty_str
        '
        Me.data_ty_str.BackColor = System.Drawing.Color.WhiteSmoke
        Me.data_ty_str.ForeColor = System.Drawing.Color.MidnightBlue
        Me.data_ty_str.Location = New System.Drawing.Point(52, 4)
        Me.data_ty_str.Name = "data_ty_str"
        Me.data_ty_str.Size = New System.Drawing.Size(29, 22)
        Me.data_ty_str.TabIndex = 1583
        '
        'GunaSeparator4
        '
        Me.GunaSeparator4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator4.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator4.Location = New System.Drawing.Point(0, -5)
        Me.GunaSeparator4.Name = "GunaSeparator4"
        Me.GunaSeparator4.Size = New System.Drawing.Size(1093, 10)
        Me.GunaSeparator4.TabIndex = 1556
        '
        'Panel3
        '
        Me.Panel3.CausesValidation = False
        Me.Panel3.Controls.Add(Me.Guna_exit)
        Me.Panel3.Controls.Add(Me.Guna_save)
        Me.Panel3.Location = New System.Drawing.Point(12, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(231, 39)
        Me.Panel3.TabIndex = 1482
        '
        'Guna_exit
        '
        Me.Guna_exit.AnimationHoverSpeed = 0.07!
        Me.Guna_exit.AnimationSpeed = 0.03!
        Me.Guna_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna_exit.BaseColor = System.Drawing.SystemColors.ControlLight
        Me.Guna_exit.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_exit.BorderSize = 2
        Me.Guna_exit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Guna_exit.FocusedColor = System.Drawing.Color.Empty
        Me.Guna_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna_exit.ForeColor = System.Drawing.Color.DimGray
        Me.Guna_exit.Image = Global.BLINVOICE.My.Resources.Resources.close26
        Me.Guna_exit.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna_exit.Location = New System.Drawing.Point(104, 3)
        Me.Guna_exit.Name = "Guna_exit"
        Me.Guna_exit.OnHoverBaseColor = System.Drawing.Color.LightSlateGray
        Me.Guna_exit.OnHoverBorderColor = System.Drawing.Color.MediumAquamarine
        Me.Guna_exit.OnHoverForeColor = System.Drawing.Color.White
        Me.Guna_exit.OnHoverImage = Nothing
        Me.Guna_exit.OnPressedColor = System.Drawing.Color.Black
        Me.Guna_exit.Size = New System.Drawing.Size(96, 32)
        Me.Guna_exit.TabIndex = 1479
        Me.Guna_exit.Text = "ปิดหน้าจอ"
        Me.Guna_exit.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'Guna_save
        '
        Me.Guna_save.AnimationHoverSpeed = 0.07!
        Me.Guna_save.AnimationSpeed = 0.03!
        Me.Guna_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna_save.BaseColor = System.Drawing.SystemColors.ControlLight
        Me.Guna_save.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_save.BorderSize = 2
        Me.Guna_save.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Guna_save.FocusedColor = System.Drawing.Color.Empty
        Me.Guna_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna_save.ForeColor = System.Drawing.Color.DimGray
        Me.Guna_save.Image = Global.BLINVOICE.My.Resources.Resources.Save302
        Me.Guna_save.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna_save.Location = New System.Drawing.Point(5, 3)
        Me.Guna_save.Name = "Guna_save"
        Me.Guna_save.OnHoverBaseColor = System.Drawing.Color.LightSlateGray
        Me.Guna_save.OnHoverBorderColor = System.Drawing.Color.MediumAquamarine
        Me.Guna_save.OnHoverForeColor = System.Drawing.Color.White
        Me.Guna_save.OnHoverImage = Nothing
        Me.Guna_save.OnPressedColor = System.Drawing.Color.Black
        Me.Guna_save.Size = New System.Drawing.Size(94, 32)
        Me.Guna_save.TabIndex = 1476
        Me.Guna_save.Text = "บันทึก"
        Me.Guna_save.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'Pn_not_show
        '
        Me.Pn_not_show.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Pn_not_show.Controls.Add(Me.data_ty_str)
        Me.Pn_not_show.Controls.Add(Me.insert_status)
        Me.Pn_not_show.Location = New System.Drawing.Point(249, 14)
        Me.Pn_not_show.Name = "Pn_not_show"
        Me.Pn_not_show.Size = New System.Drawing.Size(11, 35)
        Me.Pn_not_show.TabIndex = 852
        '
        'insert_status
        '
        Me.insert_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.insert_status.Location = New System.Drawing.Point(10, 6)
        Me.insert_status.Name = "insert_status"
        Me.insert_status.Size = New System.Drawing.Size(36, 20)
        Me.insert_status.TabIndex = 488
        Me.insert_status.TabStop = False
        Me.insert_status.Text = "0"
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator2.LineColor = System.Drawing.Color.LightGray
        Me.GunaSeparator2.Location = New System.Drawing.Point(0, 25)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(1095, 10)
        Me.GunaSeparator2.TabIndex = 1554
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'db_connection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1694, 1036)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "db_connection"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Database Config"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Pn_not_show.ResumeLayout(False)
        Me.Pn_not_show.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents SCRSQLDataSet As Reporter3.SCRSQLDataSet
    'Friend WithEvents TbcustomerTableAdapter As Reporter3.SCRSQLDataSetTableAdapters.tbcustomerTableAdapter
    'Friend WithEvents TableAdapterManager As Reporter3.SCRSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SurenameLabel As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Guna_exit As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna_save As Guna.UI.WinForms.GunaButton
    Friend WithEvents lb_status As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaSeparator4 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents insert_status As System.Windows.Forms.TextBox
    Friend WithEvents Pn_not_show As System.Windows.Forms.Panel
    Friend WithEvents Password_txt As System.Windows.Forms.TextBox
    Friend WithEvents User_txt As System.Windows.Forms.TextBox
    Friend WithEvents database_txt As System.Windows.Forms.TextBox
    Friend WithEvents test_config_bt As Guna.UI.WinForms.GunaButton
    Friend WithEvents host_txt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents db_path As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents data_ty_cmb As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents data_ty_str As TextBox
    'Friend WithEvents CachedDOC_INV10021 As LADDAWAN_SOFT.CachedDOC_INV1002
    'Friend WithEvents CachedDOC_INV10022 As LADDAWAN_SOFT.CachedDOC_INV1002
End Class
