<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class products_type_profile
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(products_type_profile))
        Me.grw = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.return_lnk = New System.Windows.Forms.LinkLabel()
        Me.TDAY = New System.Windows.Forms.TextBox()
        Me.Grbmain = New System.Windows.Forms.GroupBox()
        Me.export1 = New System.Windows.Forms.Button()
        Me.print1 = New System.Windows.Forms.Button()
        Me.add1 = New System.Windows.Forms.Button()
        Me.exit1 = New System.Windows.Forms.Button()
        CType(Me.grw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Grbmain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grw
        '
        Me.grw.AllowUserToAddRows = False
        Me.grw.AllowUserToDeleteRows = False
        Me.grw.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grw.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grw.Cursor = System.Windows.Forms.Cursors.Default
        Me.grw.EnableHeadersVisualStyles = False
        Me.grw.Location = New System.Drawing.Point(18, 21)
        Me.grw.Name = "grw"
        Me.grw.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grw.RowHeadersVisible = False
        Me.grw.RowHeadersWidth = 50
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grw.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grw.Size = New System.Drawing.Size(976, 842)
        Me.grw.TabIndex = 270
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.TDAY)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 890)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1276, 42)
        Me.Panel3.TabIndex = 360
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.return_lnk)
        Me.Panel4.Controls.Add(Me.export1)
        Me.Panel4.Controls.Add(Me.print1)
        Me.Panel4.Controls.Add(Me.add1)
        Me.Panel4.Controls.Add(Me.exit1)
        Me.Panel4.Location = New System.Drawing.Point(16, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(469, 40)
        Me.Panel4.TabIndex = 1120
        '
        'return_lnk
        '
        Me.return_lnk.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.AutoSize = True
        Me.return_lnk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.return_lnk.ForeColor = System.Drawing.Color.LightGray
        Me.return_lnk.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.Location = New System.Drawing.Point(371, 12)
        Me.return_lnk.Name = "return_lnk"
        Me.return_lnk.Size = New System.Drawing.Size(52, 16)
        Me.return_lnk.TabIndex = 421
        Me.return_lnk.TabStop = True
        Me.return_lnk.Text = "Refresh"
        Me.return_lnk.Visible = False
        '
        'TDAY
        '
        Me.TDAY.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TDAY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDAY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TDAY.Location = New System.Drawing.Point(910, 3)
        Me.TDAY.Name = "TDAY"
        Me.TDAY.Size = New System.Drawing.Size(100, 15)
        Me.TDAY.TabIndex = 334
        Me.TDAY.TabStop = False
        Me.TDAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Grbmain
        '
        Me.Grbmain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grbmain.Controls.Add(Me.grw)
        Me.Grbmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Grbmain.ForeColor = System.Drawing.Color.SteelBlue
        Me.Grbmain.Location = New System.Drawing.Point(18, 12)
        Me.Grbmain.Name = "Grbmain"
        Me.Grbmain.Size = New System.Drawing.Size(1011, 874)
        Me.Grbmain.TabIndex = 508
        Me.Grbmain.TabStop = False
        Me.Grbmain.Text = "ประเภทสินค้า"
        '
        'export1
        '
        Me.export1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.export1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.export1.Image = Global.BLINVOICE.My.Resources.Resources.Excel26
        Me.export1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.export1.Location = New System.Drawing.Point(182, 3)
        Me.export1.Name = "export1"
        Me.export1.Size = New System.Drawing.Size(90, 34)
        Me.export1.TabIndex = 36
        Me.export1.Text = "          Export"
        Me.export1.UseVisualStyleBackColor = True
        '
        'print1
        '
        Me.print1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.print1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.print1.Image = Global.BLINVOICE.My.Resources.Resources.printer30
        Me.print1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.print1.Location = New System.Drawing.Point(89, 3)
        Me.print1.Name = "print1"
        Me.print1.Size = New System.Drawing.Size(90, 34)
        Me.print1.TabIndex = 33
        Me.print1.Text = "        พิมพ์"
        Me.print1.UseVisualStyleBackColor = True
        '
        'add1
        '
        Me.add1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.add1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.add1.Image = Global.BLINVOICE.My.Resources.Resources.add20
        Me.add1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.add1.Location = New System.Drawing.Point(2, 3)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(84, 34)
        Me.add1.TabIndex = 30
        Me.add1.Text = "       เพิ่มใหม่"
        Me.add1.UseVisualStyleBackColor = True
        '
        'exit1
        '
        Me.exit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.exit1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exit1.Image = Global.BLINVOICE.My.Resources.Resources.close26
        Me.exit1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exit1.Location = New System.Drawing.Point(275, 3)
        Me.exit1.Name = "exit1"
        Me.exit1.Size = New System.Drawing.Size(90, 34)
        Me.exit1.TabIndex = 34
        Me.exit1.Text = "  ปิดหน้าจอ"
        Me.exit1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.exit1.UseVisualStyleBackColor = True
        '
        'products_type_profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton = Me.return_lnk
        Me.ClientSize = New System.Drawing.Size(1276, 932)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Grbmain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "products_type_profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ประเภทสินค้า"
        CType(Me.grw,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        Me.Panel4.ResumeLayout(false)
        Me.Panel4.PerformLayout
        Me.Grbmain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents grw As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TDAY As System.Windows.Forms.TextBox
    Friend WithEvents Grbmain As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents print1 As System.Windows.Forms.Button
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents exit1 As System.Windows.Forms.Button
    Friend WithEvents export1 As System.Windows.Forms.Button
    Friend WithEvents return_lnk As System.Windows.Forms.LinkLabel
End Class
