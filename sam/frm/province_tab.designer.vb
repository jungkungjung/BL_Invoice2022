<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class province_tab
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(province_tab))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TDAY = New System.Windows.Forms.TextBox()
        Me.return_lnk = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.exit_guna_bt = New Guna.UI.WinForms.GunaButton()
        Me.add_guna_bt = New Guna.UI.WinForms.GunaButton()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.list_Guna_search = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.grw = New System.Windows.Forms.DataGridView()
        Me.address_context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.add_province = New System.Windows.Forms.ToolStripMenuItem()
        Me.edit_province = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Pn_not_show = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.grw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.address_context.SuspendLayout()
        Me.GunaLinePanel2.SuspendLayout()
        Me.Pn_not_show.SuspendLayout()
        Me.SuspendLayout()
        '
        'TDAY
        '
        Me.TDAY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDAY.BackColor = System.Drawing.Color.SlateGray
        Me.TDAY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDAY.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TDAY.Location = New System.Drawing.Point(300, 7)
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
        Me.return_lnk.Location = New System.Drawing.Point(15, 5)
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
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(219, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 894
        Me.Label2.Text = "ค้นหา"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.exit_guna_bt)
        Me.Panel2.Controls.Add(Me.add_guna_bt)
        Me.Panel2.Location = New System.Drawing.Point(0, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(278, 28)
        Me.Panel2.TabIndex = 1488
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
        Me.exit_guna_bt.Location = New System.Drawing.Point(66, 1)
        Me.exit_guna_bt.Name = "exit_guna_bt"
        Me.exit_guna_bt.OnHoverBaseColor = System.Drawing.Color.SlateGray
        Me.exit_guna_bt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.exit_guna_bt.OnHoverForeColor = System.Drawing.Color.Gainsboro
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
        Me.add_guna_bt.OnHoverForeColor = System.Drawing.Color.Gainsboro
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
        Me.GunaGroupBox2.Location = New System.Drawing.Point(256, 17)
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
        Me.grw.ContextMenuStrip = Me.address_context
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
        Me.grw.Location = New System.Drawing.Point(14, 48)
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
        Me.grw.Size = New System.Drawing.Size(413, 685)
        Me.grw.TabIndex = 270
        '
        'address_context
        '
        Me.address_context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.add_province, Me.edit_province})
        Me.address_context.Name = "address_context"
        Me.address_context.Size = New System.Drawing.Size(126, 48)
        '
        'add_province
        '
        Me.add_province.Name = "add_province"
        Me.add_province.Size = New System.Drawing.Size(125, 22)
        Me.add_province.Text = "เพิ่มข้อมูล"
        '
        'edit_province
        '
        Me.edit_province.Name = "edit_province"
        Me.edit_province.Size = New System.Drawing.Size(125, 22)
        Me.edit_province.Text = "แก้ไขข้อมูล"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(14, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 1844
        Me.Label4.Text = "รายชื่อจังหวัด"
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLinePanel2.BackColor = System.Drawing.Color.SlateGray
        Me.GunaLinePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaLinePanel2.Controls.Add(Me.TDAY)
        Me.GunaLinePanel2.Controls.Add(Me.Panel2)
        Me.GunaLinePanel2.Controls.Add(Me.Pn_not_show)
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Gray
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(14, 733)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(413, 30)
        Me.GunaLinePanel2.TabIndex = 1862
        '
        'Pn_not_show
        '
        Me.Pn_not_show.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Pn_not_show.BackColor = System.Drawing.Color.Snow
        Me.Pn_not_show.Controls.Add(Me.return_lnk)
        Me.Pn_not_show.Location = New System.Drawing.Point(690, 0)
        Me.Pn_not_show.Name = "Pn_not_show"
        Me.Pn_not_show.Size = New System.Drawing.Size(95, 28)
        Me.Pn_not_show.TabIndex = 1854
        '
        'province_tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton = Me.return_lnk
        Me.ClientSize = New System.Drawing.Size(444, 773)
        Me.Controls.Add(Me.GunaLinePanel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grw)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "province_tab"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "รายชื่อจังหวัด"
        Me.Panel2.ResumeLayout(False)
        Me.GunaGroupBox2.ResumeLayout(False)
        CType(Me.grw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.address_context.ResumeLayout(False)
        Me.GunaLinePanel2.ResumeLayout(False)
        Me.GunaLinePanel2.PerformLayout()
        Me.Pn_not_show.ResumeLayout(False)
        Me.Pn_not_show.PerformLayout()
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents exit_guna_bt As Guna.UI.WinForms.GunaButton
    Friend WithEvents add_guna_bt As Guna.UI.WinForms.GunaButton
    Friend WithEvents grw As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Pn_not_show As System.Windows.Forms.Panel
    Friend WithEvents address_context As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents add_province As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents edit_province As System.Windows.Forms.ToolStripMenuItem
    'Friend WithEvents CachedDOC_INV10021 As LADDAWAN_SOFT.CachedDOC_INV1002
End Class
