<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer_filter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer_filter))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TDAY = New System.Windows.Forms.TextBox()
        Me.return_lnk = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.list_Guna_search = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.grw = New System.Windows.Forms.DataGridView()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmpn_guna_cmb = New Guna.UI.WinForms.GunaComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaLinePanel1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.grw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TDAY
        '
        Me.TDAY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDAY.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TDAY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDAY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TDAY.Location = New System.Drawing.Point(1033, 7)
        Me.TDAY.Name = "TDAY"
        Me.TDAY.ReadOnly = True
        Me.TDAY.Size = New System.Drawing.Size(100, 15)
        Me.TDAY.TabIndex = 334
        Me.TDAY.TabStop = False
        Me.TDAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'return_lnk
        '
        Me.return_lnk.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.AutoSize = True
        Me.return_lnk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.return_lnk.ForeColor = System.Drawing.Color.LightGray
        Me.return_lnk.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.Location = New System.Drawing.Point(587, 7)
        Me.return_lnk.Name = "return_lnk"
        Me.return_lnk.Size = New System.Drawing.Size(52, 16)
        Me.return_lnk.TabIndex = 1484
        Me.return_lnk.TabStop = True
        Me.return_lnk.Text = "Refresh"
        Me.return_lnk.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(949, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 894
        Me.Label2.Text = "ค้นหา"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLinePanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GunaLinePanel1.Controls.Add(Me.return_lnk)
        Me.GunaLinePanel1.Controls.Add(Me.TDAY)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Gray
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(11, 650)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(1146, 30)
        Me.GunaLinePanel1.TabIndex = 1545
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
        Me.GunaGroupBox2.Location = New System.Drawing.Point(986, 40)
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
        'grw
        '
        Me.grw.AllowUserToAddRows = False
        Me.grw.AllowUserToDeleteRows = False
        Me.grw.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.grw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grw.ColumnHeadersHeight = 26
        Me.grw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grw.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grw.DefaultCellStyle = DataGridViewCellStyle3
        Me.grw.GridColor = System.Drawing.Color.Silver
        Me.grw.Location = New System.Drawing.Point(14, 71)
        Me.grw.MultiSelect = False
        Me.grw.Name = "grw"
        Me.grw.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grw.RowHeadersVisible = False
        Me.grw.RowHeadersWidth = 50
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grw.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.grw.Size = New System.Drawing.Size(1143, 578)
        Me.grw.TabIndex = 270
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.BLINVOICE.My.Resources.Resources.Customer4233
        Me.GunaPictureBox1.Location = New System.Drawing.Point(11, 9)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(30, 26)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 1845
        Me.GunaPictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(42, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 1844
        Me.Label4.Text = "รายชื่อลูกค้า"
        '
        'cmpn_guna_cmb
        '
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
        Me.cmpn_guna_cmb.Items.AddRange(New Object() {"รหัส - ชื่อ", "ที่อยู่ - ไปรษณีย์", "โทรศัพท์"})
        Me.cmpn_guna_cmb.Location = New System.Drawing.Point(60, 42)
        Me.cmpn_guna_cmb.Name = "cmpn_guna_cmb"
        Me.cmpn_guna_cmb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmpn_guna_cmb.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmpn_guna_cmb.Radius = 4
        Me.cmpn_guna_cmb.Size = New System.Drawing.Size(161, 23)
        Me.cmpn_guna_cmb.StartIndex = 0
        Me.cmpn_guna_cmb.TabIndex = 1543
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(15, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 893
        Me.Label3.Text = "เลือกค้น"
        '
        'customer_filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton = Me.return_lnk
        Me.ClientSize = New System.Drawing.Size(1174, 692)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grw)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmpn_guna_cmb)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "customer_filter"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ค้นหาลูกค้า"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.GunaGroupBox2.ResumeLayout(False)
        CType(Me.grw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TDAY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents return_lnk As System.Windows.Forms.LinkLabel
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents list_Guna_search As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents grw As System.Windows.Forms.DataGridView
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmpn_guna_cmb As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    'Friend WithEvents CachedDOC_INV10021 As LADDAWAN_SOFT.CachedDOC_INV1002
End Class
