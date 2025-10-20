<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dragdrop_datagrid
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dragdrop_datagrid))
        Me.grw_source = New System.Windows.Forms.DataGridView()
        Me.grw_target = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.select_lnk = New System.Windows.Forms.LinkLabel()
        Me.list_Guna_search = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.clear_lnk = New System.Windows.Forms.LinkLabel()
        Me.Pn_not_show = New System.Windows.Forms.Panel()
        Me.return_lnk = New System.Windows.Forms.LinkLabel()
        Me.filename_chk1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.filename_chk2 = New Guna.UI.WinForms.GunaCheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grw_source, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grw_target, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox2.SuspendLayout()
        Me.Pn_not_show.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grw_source
        '
        Me.grw_source.AllowDrop = True
        Me.grw_source.AllowUserToAddRows = False
        Me.grw_source.AllowUserToDeleteRows = False
        Me.grw_source.AllowUserToOrderColumns = True
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Lavender
        Me.grw_source.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.grw_source.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grw_source.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grw_source.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grw_source.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw_source.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.grw_source.ColumnHeadersHeight = 26
        Me.grw_source.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grw_source.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grw_source.DefaultCellStyle = DataGridViewCellStyle13
        Me.grw_source.GridColor = System.Drawing.Color.Silver
        Me.grw_source.Location = New System.Drawing.Point(490, 104)
        Me.grw_source.Name = "grw_source"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw_source.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.grw_source.RowHeadersWidth = 30
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grw_source.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.grw_source.Size = New System.Drawing.Size(416, 527)
        Me.grw_source.TabIndex = 1489
        '
        'grw_target
        '
        Me.grw_target.AllowDrop = True
        Me.grw_target.AllowUserToAddRows = False
        Me.grw_target.AllowUserToOrderColumns = True
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.Lavender
        Me.grw_target.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.grw_target.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grw_target.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grw_target.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grw_target.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw_target.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.grw_target.ColumnHeadersHeight = 26
        Me.grw_target.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grw_target.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grw_target.DefaultCellStyle = DataGridViewCellStyle18
        Me.grw_target.GridColor = System.Drawing.Color.Silver
        Me.grw_target.Location = New System.Drawing.Point(26, 104)
        Me.grw_target.Name = "grw_target"
        Me.grw_target.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw_target.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.grw_target.RowHeadersVisible = False
        Me.grw_target.RowHeadersWidth = 50
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grw_target.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.grw_target.Size = New System.Drawing.Size(428, 527)
        Me.grw_target.TabIndex = 1490
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(696, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ค้นหา"
        '
        'select_lnk
        '
        Me.select_lnk.AutoSize = True
        Me.select_lnk.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.select_lnk.LinkColor = System.Drawing.Color.DarkSlateGray
        Me.select_lnk.Location = New System.Drawing.Point(487, 85)
        Me.select_lnk.Name = "select_lnk"
        Me.select_lnk.Size = New System.Drawing.Size(52, 16)
        Me.select_lnk.TabIndex = 1503
        Me.select_lnk.TabStop = True
        Me.select_lnk.Text = "เพิ่มข้อมูล"
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
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.AliceBlue
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaGroupBox2.BorderSize = 1
        Me.GunaGroupBox2.Controls.Add(Me.list_Guna_search)
        Me.GunaGroupBox2.Controls.Add(Me.GunaCircleButton1)
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.LineTop = 0
        Me.GunaGroupBox2.Location = New System.Drawing.Point(735, 73)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Radius = 10
        Me.GunaGroupBox2.Size = New System.Drawing.Size(171, 26)
        Me.GunaGroupBox2.TabIndex = 1545
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'clear_lnk
        '
        Me.clear_lnk.AutoSize = True
        Me.clear_lnk.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.clear_lnk.LinkColor = System.Drawing.Color.DarkSlateGray
        Me.clear_lnk.Location = New System.Drawing.Point(23, 85)
        Me.clear_lnk.Name = "clear_lnk"
        Me.clear_lnk.Size = New System.Drawing.Size(51, 16)
        Me.clear_lnk.TabIndex = 1546
        Me.clear_lnk.TabStop = True
        Me.clear_lnk.Text = "ล้างข้อมูล"
        '
        'Pn_not_show
        '
        Me.Pn_not_show.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Pn_not_show.BackColor = System.Drawing.Color.Transparent
        Me.Pn_not_show.Controls.Add(Me.return_lnk)
        Me.Pn_not_show.Location = New System.Drawing.Point(304, 12)
        Me.Pn_not_show.Name = "Pn_not_show"
        Me.Pn_not_show.Size = New System.Drawing.Size(95, 28)
        Me.Pn_not_show.TabIndex = 1855
        '
        'return_lnk
        '
        Me.return_lnk.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.AutoSize = True
        Me.return_lnk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.return_lnk.ForeColor = System.Drawing.Color.LightGray
        Me.return_lnk.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.Location = New System.Drawing.Point(14, 6)
        Me.return_lnk.Name = "return_lnk"
        Me.return_lnk.Size = New System.Drawing.Size(52, 16)
        Me.return_lnk.TabIndex = 1484
        Me.return_lnk.TabStop = True
        Me.return_lnk.Text = "Refresh"
        '
        'filename_chk1
        '
        Me.filename_chk1.BaseColor = System.Drawing.Color.White
        Me.filename_chk1.Checked = True
        Me.filename_chk1.CheckedOffColor = System.Drawing.Color.Gray
        Me.filename_chk1.CheckedOnColor = System.Drawing.Color.Teal
        Me.filename_chk1.FillColor = System.Drawing.Color.White
        Me.filename_chk1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.filename_chk1.Location = New System.Drawing.Point(3, 7)
        Me.filename_chk1.Name = "filename_chk1"
        Me.filename_chk1.Size = New System.Drawing.Size(64, 20)
        Me.filename_chk1.TabIndex = 2006
        Me.filename_chk1.TabStop = False
        Me.filename_chk1.Text = " ทั้งหมด"
        Me.filename_chk1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'filename_chk2
        '
        Me.filename_chk2.BaseColor = System.Drawing.Color.White
        Me.filename_chk2.CheckedOffColor = System.Drawing.Color.Gray
        Me.filename_chk2.CheckedOnColor = System.Drawing.Color.Teal
        Me.filename_chk2.FillColor = System.Drawing.Color.White
        Me.filename_chk2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.filename_chk2.Location = New System.Drawing.Point(92, 7)
        Me.filename_chk2.Name = "filename_chk2"
        Me.filename_chk2.Size = New System.Drawing.Size(86, 20)
        Me.filename_chk2.TabIndex = 2007
        Me.filename_chk2.TabStop = False
        Me.filename_chk2.Text = " เลือกเงื่อนไข "
        Me.filename_chk2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.filename_chk2)
        Me.Panel1.Controls.Add(Me.filename_chk1)
        Me.Panel1.Location = New System.Drawing.Point(23, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 35)
        Me.Panel1.TabIndex = 1856
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(23, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 16)
        Me.Label2.TabIndex = 1857
        Me.Label2.Text = "เลือกประเภทสินค้า"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkSlateGray
        Me.LinkLabel1.Location = New System.Drawing.Point(402, 85)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(54, 16)
        Me.LinkLabel1.TabIndex = 1859
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ปิดหน้าจอ"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1860
        Me.Button1.Text = "ตกลง"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dragdrop_datagrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.return_lnk
        Me.ClientSize = New System.Drawing.Size(945, 681)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pn_not_show)
        Me.Controls.Add(Me.clear_lnk)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.select_lnk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grw_target)
        Me.Controls.Add(Me.grw_source)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Name = "dragdrop_datagrid"
        Me.ShowIcon = False
        Me.Text = "กรองเงื่อนไข"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grw_source, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grw_target, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.Pn_not_show.ResumeLayout(False)
        Me.Pn_not_show.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grw_source As System.Windows.Forms.DataGridView
    Friend WithEvents grw_target As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents select_lnk As System.Windows.Forms.LinkLabel
    Friend WithEvents list_Guna_search As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents clear_lnk As System.Windows.Forms.LinkLabel
    Friend WithEvents Pn_not_show As System.Windows.Forms.Panel
    Friend WithEvents return_lnk As System.Windows.Forms.LinkLabel
    Friend WithEvents filename_chk1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents filename_chk2 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
