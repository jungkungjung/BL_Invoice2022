<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class address_send
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.job_link = New System.Windows.Forms.TextBox()
        Me.Pn_not_show = New System.Windows.Forms.Panel()
        Me.TDAY = New System.Windows.Forms.TextBox()
        Me.return_lnk = New System.Windows.Forms.LinkLabel()
        Me.Grbmain = New System.Windows.Forms.GroupBox()
        Me.grw = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1.SuspendLayout()
        Me.Pn_not_show.SuspendLayout()
        Me.Grbmain.SuspendLayout()
        CType(Me.grw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 689)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1287, 22)
        Me.StatusStrip1.TabIndex = 1351
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'job_link
        '
        Me.job_link.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.job_link.Location = New System.Drawing.Point(1004, 599)
        Me.job_link.Name = "job_link"
        Me.job_link.Size = New System.Drawing.Size(108, 22)
        Me.job_link.TabIndex = 1355
        '
        'Pn_not_show
        '
        Me.Pn_not_show.Controls.Add(Me.TDAY)
        Me.Pn_not_show.Controls.Add(Me.return_lnk)
        Me.Pn_not_show.Location = New System.Drawing.Point(1155, 601)
        Me.Pn_not_show.Name = "Pn_not_show"
        Me.Pn_not_show.Size = New System.Drawing.Size(78, 53)
        Me.Pn_not_show.TabIndex = 1356
        '
        'TDAY
        '
        Me.TDAY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TDAY.BackColor = System.Drawing.SystemColors.Control
        Me.TDAY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDAY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TDAY.Location = New System.Drawing.Point(32, 5)
        Me.TDAY.Name = "TDAY"
        Me.TDAY.Size = New System.Drawing.Size(35, 15)
        Me.TDAY.TabIndex = 896
        Me.TDAY.TabStop = False
        Me.TDAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TDAY.Visible = False
        '
        'return_lnk
        '
        Me.return_lnk.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.AutoSize = True
        Me.return_lnk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.return_lnk.ForeColor = System.Drawing.Color.LightGray
        Me.return_lnk.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.Location = New System.Drawing.Point(3, 28)
        Me.return_lnk.Name = "return_lnk"
        Me.return_lnk.Size = New System.Drawing.Size(52, 16)
        Me.return_lnk.TabIndex = 1358
        Me.return_lnk.TabStop = True
        Me.return_lnk.Text = "Refresh"
        Me.return_lnk.Visible = False
        '
        'Grbmain
        '
        Me.Grbmain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grbmain.Controls.Add(Me.Pn_not_show)
        Me.Grbmain.Controls.Add(Me.job_link)
        Me.Grbmain.Controls.Add(Me.grw)
        Me.Grbmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Grbmain.ForeColor = System.Drawing.Color.SteelBlue
        Me.Grbmain.Location = New System.Drawing.Point(12, 18)
        Me.Grbmain.Name = "Grbmain"
        Me.Grbmain.Size = New System.Drawing.Size(1250, 660)
        Me.Grbmain.TabIndex = 1357
        Me.Grbmain.TabStop = False
        Me.Grbmain.Text = "ดับเบิ้ลคลิกเลือก"
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
        Me.grw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.grw.Location = New System.Drawing.Point(16, 24)
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
        Me.grw.Size = New System.Drawing.Size(1217, 526)
        Me.grw.TabIndex = 270
        '
        'address_send
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton = Me.return_lnk
        Me.ClientSize = New System.Drawing.Size(1287, 711)
        Me.Controls.Add(Me.Grbmain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "address_send"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "สถานที่ส่งของ"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Pn_not_show.ResumeLayout(False)
        Me.Pn_not_show.PerformLayout()
        Me.Grbmain.ResumeLayout(False)
        Me.Grbmain.PerformLayout()
        CType(Me.grw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents job_link As System.Windows.Forms.TextBox
    Friend WithEvents Pn_not_show As System.Windows.Forms.Panel
    Friend WithEvents Grbmain As System.Windows.Forms.GroupBox
    Friend WithEvents grw As System.Windows.Forms.DataGridView
    Friend WithEvents TDAY As System.Windows.Forms.TextBox
    Friend WithEvents return_lnk As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
