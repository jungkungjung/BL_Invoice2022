<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doc_tab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(doc_tab))
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.return_lnk = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.amt_sum = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.export_guna_bt = New Guna.UI.WinForms.GunaButton()
        Me.exit_guna_bt = New Guna.UI.WinForms.GunaButton()
        Me.add_guna_bt = New Guna.UI.WinForms.GunaButton()
        Me.report_guna_bt = New Guna.UI.WinForms.GunaButton()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.list_Guna_search = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.cmpn_guna_cmb = New Guna.UI.WinForms.GunaComboBox()
        Me.grw = New System.Windows.Forms.DataGridView()
        Me.GunaControlBox6 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox5 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Date_to = New System.Windows.Forms.DateTimePicker()
        Me.Date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.show_lnk = New System.Windows.Forms.LinkLabel()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Pn_not_show = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.grw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel2.SuspendLayout()
        Me.Pn_not_show.SuspendLayout()
        Me.SuspendLayout()
        '
        'return_lnk
        '
        Me.return_lnk.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.AutoSize = True
        Me.return_lnk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.return_lnk.ForeColor = System.Drawing.Color.LightGray
        Me.return_lnk.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.Location = New System.Drawing.Point(3, 5)
        Me.return_lnk.Name = "return_lnk"
        Me.return_lnk.Size = New System.Drawing.Size(52, 16)
        Me.return_lnk.TabIndex = 1484
        Me.return_lnk.TabStop = True
        Me.return_lnk.Text = "Refresh"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(909, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 894
        Me.Label2.Text = "ค้นหา"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(700, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 893
        Me.Label3.Text = "เลือกค้น"
        '
        'GunaButton1
        '
        Me.GunaButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.SlateGray
        Me.GunaButton1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Transparent
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.Khaki
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(994, 3)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.SlateGray
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.AliceBlue
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.OnPressedDepth = 0
        Me.GunaButton1.Radius = 2
        Me.GunaButton1.Size = New System.Drawing.Size(105, 22)
        Me.GunaButton1.TabIndex = 1490
        Me.GunaButton1.TabStop = False
        Me.GunaButton1.Text = "ปิดหน้าจอ"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'amt_sum
        '
        Me.amt_sum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.amt_sum.BackColor = System.Drawing.Color.SlateGray
        Me.amt_sum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.amt_sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt_sum.ForeColor = System.Drawing.Color.Gainsboro
        Me.amt_sum.Location = New System.Drawing.Point(791, 5)
        Me.amt_sum.Name = "amt_sum"
        Me.amt_sum.ReadOnly = True
        Me.amt_sum.Size = New System.Drawing.Size(197, 15)
        Me.amt_sum.TabIndex = 1489
        Me.amt_sum.TabStop = False
        Me.amt_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.export_guna_bt)
        Me.Panel2.Controls.Add(Me.exit_guna_bt)
        Me.Panel2.Controls.Add(Me.add_guna_bt)
        Me.Panel2.Controls.Add(Me.report_guna_bt)
        Me.Panel2.Location = New System.Drawing.Point(0, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(278, 28)
        Me.Panel2.TabIndex = 1488
        '
        'export_guna_bt
        '
        Me.export_guna_bt.AnimationHoverSpeed = 0.07!
        Me.export_guna_bt.AnimationSpeed = 0.03!
        Me.export_guna_bt.BackColor = System.Drawing.Color.Transparent
        Me.export_guna_bt.BaseColor = System.Drawing.Color.SlateGray
        Me.export_guna_bt.BorderColor = System.Drawing.Color.Black
        Me.export_guna_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.export_guna_bt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.export_guna_bt.FocusedColor = System.Drawing.Color.Transparent
        Me.export_guna_bt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.export_guna_bt.ForeColor = System.Drawing.Color.Khaki
        Me.export_guna_bt.Image = Nothing
        Me.export_guna_bt.ImageSize = New System.Drawing.Size(20, 20)
        Me.export_guna_bt.Location = New System.Drawing.Point(129, 1)
        Me.export_guna_bt.Name = "export_guna_bt"
        Me.export_guna_bt.OnHoverBaseColor = System.Drawing.Color.SlateGray
        Me.export_guna_bt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.export_guna_bt.OnHoverForeColor = System.Drawing.Color.AliceBlue
        Me.export_guna_bt.OnHoverImage = Nothing
        Me.export_guna_bt.OnPressedColor = System.Drawing.Color.Black
        Me.export_guna_bt.OnPressedDepth = 0
        Me.export_guna_bt.Radius = 2
        Me.export_guna_bt.Size = New System.Drawing.Size(60, 22)
        Me.export_guna_bt.TabIndex = 1483
        Me.export_guna_bt.Text = "Export"
        Me.export_guna_bt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.export_guna_bt.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'exit_guna_bt
        '
        Me.exit_guna_bt.AnimationHoverSpeed = 0.07!
        Me.exit_guna_bt.AnimationSpeed = 0.03!
        Me.exit_guna_bt.BackColor = System.Drawing.Color.Transparent
        Me.exit_guna_bt.BaseColor = System.Drawing.Color.SlateGray
        Me.exit_guna_bt.BorderColor = System.Drawing.Color.Black
        Me.exit_guna_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exit_guna_bt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.exit_guna_bt.FocusedColor = System.Drawing.Color.Transparent
        Me.exit_guna_bt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_guna_bt.ForeColor = System.Drawing.Color.Khaki
        Me.exit_guna_bt.Image = Nothing
        Me.exit_guna_bt.ImageSize = New System.Drawing.Size(20, 20)
        Me.exit_guna_bt.Location = New System.Drawing.Point(192, 1)
        Me.exit_guna_bt.Name = "exit_guna_bt"
        Me.exit_guna_bt.OnHoverBaseColor = System.Drawing.Color.SlateGray
        Me.exit_guna_bt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.exit_guna_bt.OnHoverForeColor = System.Drawing.Color.AliceBlue
        Me.exit_guna_bt.OnHoverImage = Nothing
        Me.exit_guna_bt.OnPressedColor = System.Drawing.Color.Black
        Me.exit_guna_bt.OnPressedDepth = 0
        Me.exit_guna_bt.Radius = 2
        Me.exit_guna_bt.Size = New System.Drawing.Size(64, 22)
        Me.exit_guna_bt.TabIndex = 1484
        Me.exit_guna_bt.Text = "ปิดหน้าจอ"
        Me.exit_guna_bt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.exit_guna_bt.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'add_guna_bt
        '
        Me.add_guna_bt.AnimationHoverSpeed = 0.07!
        Me.add_guna_bt.AnimationSpeed = 0.03!
        Me.add_guna_bt.BackColor = System.Drawing.Color.Transparent
        Me.add_guna_bt.BaseColor = System.Drawing.Color.SlateGray
        Me.add_guna_bt.BorderColor = System.Drawing.Color.Black
        Me.add_guna_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_guna_bt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.add_guna_bt.FocusedColor = System.Drawing.Color.Transparent
        Me.add_guna_bt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_guna_bt.ForeColor = System.Drawing.Color.Khaki
        Me.add_guna_bt.Image = Nothing
        Me.add_guna_bt.ImageSize = New System.Drawing.Size(20, 20)
        Me.add_guna_bt.Location = New System.Drawing.Point(3, 1)
        Me.add_guna_bt.Name = "add_guna_bt"
        Me.add_guna_bt.OnHoverBaseColor = System.Drawing.Color.SlateGray
        Me.add_guna_bt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.add_guna_bt.OnHoverForeColor = System.Drawing.Color.AliceBlue
        Me.add_guna_bt.OnHoverImage = Nothing
        Me.add_guna_bt.OnPressedColor = System.Drawing.Color.Black
        Me.add_guna_bt.OnPressedDepth = 0
        Me.add_guna_bt.Radius = 2
        Me.add_guna_bt.Size = New System.Drawing.Size(60, 22)
        Me.add_guna_bt.TabIndex = 1123
        Me.add_guna_bt.Text = "เพิ่มข้อมูล"
        Me.add_guna_bt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.add_guna_bt.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'report_guna_bt
        '
        Me.report_guna_bt.AnimationHoverSpeed = 0.07!
        Me.report_guna_bt.AnimationSpeed = 0.03!
        Me.report_guna_bt.BackColor = System.Drawing.Color.Transparent
        Me.report_guna_bt.BaseColor = System.Drawing.Color.SlateGray
        Me.report_guna_bt.BorderColor = System.Drawing.Color.Black
        Me.report_guna_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.report_guna_bt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.report_guna_bt.FocusedColor = System.Drawing.Color.Transparent
        Me.report_guna_bt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.report_guna_bt.ForeColor = System.Drawing.Color.Khaki
        Me.report_guna_bt.Image = Nothing
        Me.report_guna_bt.ImageSize = New System.Drawing.Size(20, 20)
        Me.report_guna_bt.Location = New System.Drawing.Point(66, 1)
        Me.report_guna_bt.Name = "report_guna_bt"
        Me.report_guna_bt.OnHoverBaseColor = System.Drawing.Color.SlateGray
        Me.report_guna_bt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.report_guna_bt.OnHoverForeColor = System.Drawing.Color.AliceBlue
        Me.report_guna_bt.OnHoverImage = Nothing
        Me.report_guna_bt.OnPressedColor = System.Drawing.Color.Black
        Me.report_guna_bt.OnPressedDepth = 0
        Me.report_guna_bt.Radius = 2
        Me.report_guna_bt.Size = New System.Drawing.Size(60, 22)
        Me.report_guna_bt.TabIndex = 1482
        Me.report_guna_bt.Text = "รายงาน"
        Me.report_guna_bt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.report_guna_bt.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.AliceBlue
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaGroupBox2.BorderSize = 1
        Me.GunaGroupBox2.Controls.Add(Me.list_Guna_search)
        Me.GunaGroupBox2.Controls.Add(Me.GunaCircleButton1)
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.LineTop = 0
        Me.GunaGroupBox2.Location = New System.Drawing.Point(946, 43)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Radius = 10
        Me.GunaGroupBox2.Size = New System.Drawing.Size(171, 26)
        Me.GunaGroupBox2.TabIndex = 1544
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'list_Guna_search
        '
        Me.list_Guna_search.BaseColor = System.Drawing.Color.AliceBlue
        Me.list_Guna_search.BorderColor = System.Drawing.Color.Silver
        Me.list_Guna_search.BorderSize = 0
        Me.list_Guna_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.list_Guna_search.FocusedBaseColor = System.Drawing.Color.AliceBlue
        Me.list_Guna_search.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.list_Guna_search.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.list_Guna_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_Guna_search.ForeColor = System.Drawing.Color.DimGray
        Me.list_Guna_search.Location = New System.Drawing.Point(10, 1)
        Me.list_Guna_search.Name = "list_Guna_search"
        Me.list_Guna_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.list_Guna_search.Size = New System.Drawing.Size(130, 24)
        Me.list_Guna_search.TabIndex = 2
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.AliceBlue
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = CType(resources.GetObject("GunaCircleButton1.Image"), System.Drawing.Image)
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(141, 1)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = CType(resources.GetObject("GunaCircleButton1.OnHoverImage"), System.Drawing.Image)
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnPressedDepth = 28
        Me.GunaCircleButton1.Size = New System.Drawing.Size(25, 24)
        Me.GunaCircleButton1.TabIndex = 1
        '
        'cmpn_guna_cmb
        '
        Me.cmpn_guna_cmb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmpn_guna_cmb.BackColor = System.Drawing.Color.Transparent
        Me.cmpn_guna_cmb.BaseColor = System.Drawing.Color.AliceBlue
        Me.cmpn_guna_cmb.BorderColor = System.Drawing.Color.Silver
        Me.cmpn_guna_cmb.BorderSize = 1
        Me.cmpn_guna_cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmpn_guna_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmpn_guna_cmb.FocusedColor = System.Drawing.Color.Empty
        Me.cmpn_guna_cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmpn_guna_cmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmpn_guna_cmb.FormattingEnabled = True
        Me.cmpn_guna_cmb.Items.AddRange(New Object() {"เลขที่เอกสาร", "เลขที่ใบกำกับภาษี", "รหัส - ชื่อลูกค้า", "รหัส - ชื่อพนักงานขาย"})
        Me.cmpn_guna_cmb.Location = New System.Drawing.Point(745, 45)
        Me.cmpn_guna_cmb.Name = "cmpn_guna_cmb"
        Me.cmpn_guna_cmb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmpn_guna_cmb.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmpn_guna_cmb.Radius = 4
        Me.cmpn_guna_cmb.Size = New System.Drawing.Size(161, 23)
        Me.cmpn_guna_cmb.StartIndex = 0
        Me.cmpn_guna_cmb.TabIndex = 1543
        '
        'grw
        '
        Me.grw.AllowUserToAddRows = False
        Me.grw.AllowUserToDeleteRows = False
        Me.grw.AllowUserToOrderColumns = True
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.Lavender
        Me.grw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.grw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.grw.ColumnHeadersHeight = 26
        Me.grw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grw.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grw.DefaultCellStyle = DataGridViewCellStyle23
        Me.grw.GridColor = System.Drawing.Color.Silver
        Me.grw.Location = New System.Drawing.Point(14, 74)
        Me.grw.Name = "grw"
        Me.grw.ReadOnly = True
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.grw.RowHeadersVisible = False
        Me.grw.RowHeadersWidth = 50
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grw.RowsDefaultCellStyle = DataGridViewCellStyle25
        Me.grw.Size = New System.Drawing.Size(1103, 818)
        Me.grw.TabIndex = 270
        '
        'GunaControlBox6
        '
        Me.GunaControlBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox6.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox6.AnimationSpeed = 0.03!
        Me.GunaControlBox6.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox6.IconSize = 15.0!
        Me.GunaControlBox6.Location = New System.Drawing.Point(1102, 1)
        Me.GunaControlBox6.Name = "GunaControlBox6"
        Me.GunaControlBox6.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox6.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox6.Size = New System.Drawing.Size(30, 28)
        Me.GunaControlBox6.TabIndex = 1846
        '
        'GunaControlBox5
        '
        Me.GunaControlBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox5.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox5.AnimationSpeed = 0.03!
        Me.GunaControlBox5.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox5.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox5.IconSize = 15.0!
        Me.GunaControlBox5.Location = New System.Drawing.Point(1069, 1)
        Me.GunaControlBox5.Name = "GunaControlBox5"
        Me.GunaControlBox5.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox5.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox5.Size = New System.Drawing.Size(30, 28)
        Me.GunaControlBox5.TabIndex = 1847
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.Image = Global.BLINVOICE.My.Resources.Resources.bill_green
        Me.GunaPictureBox1.Location = New System.Drawing.Point(13, 9)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(30, 26)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 1845
        Me.GunaPictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(43, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 1844
        Me.Label4.Text = "สรุปเอกสารขาย"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 1849
        Me.Label1.Text = "วันที่"
        '
        'Date_to
        '
        Me.Date_to.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_to.CalendarTitleBackColor = System.Drawing.Color.RoyalBlue
        Me.Date_to.CalendarTitleForeColor = System.Drawing.Color.White
        Me.Date_to.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Date_to.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_to.Location = New System.Drawing.Point(172, 47)
        Me.Date_to.Name = "Date_to"
        Me.Date_to.Size = New System.Drawing.Size(98, 22)
        Me.Date_to.TabIndex = 1851
        '
        'Date_from
        '
        Me.Date_from.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_from.CalendarTitleBackColor = System.Drawing.Color.RoyalBlue
        Me.Date_from.CalendarTitleForeColor = System.Drawing.Color.White
        Me.Date_from.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Date_from.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_from.Location = New System.Drawing.Point(44, 47)
        Me.Date_from.Name = "Date_from"
        Me.Date_from.Size = New System.Drawing.Size(98, 22)
        Me.Date_from.TabIndex = 1848
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(147, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 16)
        Me.Label5.TabIndex = 1850
        Me.Label5.Text = "ถึง"
        '
        'show_lnk
        '
        Me.show_lnk.ActiveLinkColor = System.Drawing.Color.LightSteelBlue
        Me.show_lnk.AutoSize = True
        Me.show_lnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.show_lnk.ForeColor = System.Drawing.Color.LightGray
        Me.show_lnk.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.show_lnk.LinkColor = System.Drawing.Color.SteelBlue
        Me.show_lnk.Location = New System.Drawing.Point(272, 49)
        Me.show_lnk.Name = "show_lnk"
        Me.show_lnk.Size = New System.Drawing.Size(41, 16)
        Me.show_lnk.TabIndex = 1852
        Me.show_lnk.TabStop = True
        Me.show_lnk.Text = "- แสดง"
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLinePanel2.BackColor = System.Drawing.Color.SlateGray
        Me.GunaLinePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaLinePanel2.Controls.Add(Me.Pn_not_show)
        Me.GunaLinePanel2.Controls.Add(Me.amt_sum)
        Me.GunaLinePanel2.Controls.Add(Me.GunaButton1)
        Me.GunaLinePanel2.Controls.Add(Me.Panel2)
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Gray
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(14, 892)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(1103, 30)
        Me.GunaLinePanel2.TabIndex = 1861
        '
        'Pn_not_show
        '
        Me.Pn_not_show.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Pn_not_show.BackColor = System.Drawing.Color.SlateGray
        Me.Pn_not_show.Controls.Add(Me.return_lnk)
        Me.Pn_not_show.Location = New System.Drawing.Point(690, 0)
        Me.Pn_not_show.Name = "Pn_not_show"
        Me.Pn_not_show.Size = New System.Drawing.Size(95, 28)
        Me.Pn_not_show.TabIndex = 1854
        '
        'doc_tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.return_lnk
        Me.ClientSize = New System.Drawing.Size(1134, 932)
        Me.Controls.Add(Me.GunaLinePanel2)
        Me.Controls.Add(Me.grw)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Date_to)
        Me.Controls.Add(Me.Date_from)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.show_lnk)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaControlBox6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GunaControlBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmpn_guna_cmb)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "doc_tab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "สรุปเอกสารขาย"
        Me.Panel2.ResumeLayout(False)
        Me.GunaGroupBox2.ResumeLayout(False)
        CType(Me.grw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel2.ResumeLayout(False)
        Me.GunaLinePanel2.PerformLayout()
        Me.Pn_not_show.ResumeLayout(False)
        Me.Pn_not_show.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents return_lnk As System.Windows.Forms.LinkLabel
    Friend WithEvents cmpn_guna_cmb As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents list_Guna_search As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents exit_guna_bt As Guna.UI.WinForms.GunaButton
    Friend WithEvents add_guna_bt As Guna.UI.WinForms.GunaButton
    Friend WithEvents report_guna_bt As Guna.UI.WinForms.GunaButton
    Friend WithEvents grw As System.Windows.Forms.DataGridView
    Friend WithEvents GunaControlBox6 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox5 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents show_lnk As System.Windows.Forms.LinkLabel
    Friend WithEvents amt_sum As System.Windows.Forms.TextBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents export_guna_bt As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Pn_not_show As System.Windows.Forms.Panel
    'Friend WithEvents CachedDOC_INV10021 As LADDAWAN_SOFT.CachedDOC_INV1002
End Class
