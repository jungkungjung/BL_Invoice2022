<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class preview_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(preview_new))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.print_context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.print_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.close_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.printer_guna_cmb = New Guna.UI.WinForms.GunaComboBox()
        Me.Guna_print = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.print_context.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.EnableToolTips = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 43)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(650, 441)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'print_context
        '
        Me.print_context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.print_strip, Me.close_strip})
        Me.print_context.Name = "address_context"
        Me.print_context.Size = New System.Drawing.Size(121, 48)
        '
        'print_strip
        '
        Me.print_strip.Enabled = False
        Me.print_strip.Name = "print_strip"
        Me.print_strip.Size = New System.Drawing.Size(120, 22)
        Me.print_strip.Text = "พิมพ์"
        '
        'close_strip
        '
        Me.close_strip.Enabled = False
        Me.close_strip.Name = "close_strip"
        Me.close_strip.Size = New System.Drawing.Size(120, 22)
        Me.close_strip.Text = "ปิดหน้าจอ"
        '
        'printer_guna_cmb
        '
        Me.printer_guna_cmb.BackColor = System.Drawing.Color.Transparent
        Me.printer_guna_cmb.BaseColor = System.Drawing.Color.AliceBlue
        Me.printer_guna_cmb.BorderColor = System.Drawing.Color.Silver
        Me.printer_guna_cmb.BorderSize = 1
        Me.printer_guna_cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.printer_guna_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.printer_guna_cmb.FocusedColor = System.Drawing.Color.Empty
        Me.printer_guna_cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printer_guna_cmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.printer_guna_cmb.FormattingEnabled = True
        Me.printer_guna_cmb.Location = New System.Drawing.Point(56, 11)
        Me.printer_guna_cmb.Name = "printer_guna_cmb"
        Me.printer_guna_cmb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.printer_guna_cmb.OnHoverItemForeColor = System.Drawing.Color.White
        Me.printer_guna_cmb.Radius = 4
        Me.printer_guna_cmb.Size = New System.Drawing.Size(228, 23)
        Me.printer_guna_cmb.StartIndex = 0
        Me.printer_guna_cmb.TabIndex = 1544
        '
        'Guna_print
        '
        Me.Guna_print.AnimationHoverSpeed = 0.07!
        Me.Guna_print.AnimationSpeed = 0.03!
        Me.Guna_print.BackColor = System.Drawing.Color.Transparent
        Me.Guna_print.BaseColor = System.Drawing.Color.Transparent
        Me.Guna_print.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_print.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Guna_print.FocusedColor = System.Drawing.Color.Empty
        Me.Guna_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna_print.ForeColor = System.Drawing.Color.DimGray
        Me.Guna_print.Image = Global.BLINVOICE.My.Resources.Resources.Print_32x321
        Me.Guna_print.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna_print.ImageSize = New System.Drawing.Size(26, 26)
        Me.Guna_print.Location = New System.Drawing.Point(288, 6)
        Me.Guna_print.Name = "Guna_print"
        Me.Guna_print.OnHoverBaseColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_print.OnHoverBorderColor = System.Drawing.Color.SteelBlue
        Me.Guna_print.OnHoverForeColor = System.Drawing.Color.DarkSlateGray
        Me.Guna_print.OnHoverImage = Nothing
        Me.Guna_print.OnPressedColor = System.Drawing.Color.Black
        Me.Guna_print.Radius = 2
        Me.Guna_print.Size = New System.Drawing.Size(36, 32)
        Me.Guna_print.TabIndex = 1546
        Me.Guna_print.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 1548
        Me.Label1.Text = "Printer"
        '
        'preview_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(650, 484)
        Me.ContextMenuStrip = Me.print_context
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna_print)
        Me.Controls.Add(Me.printer_guna_cmb)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "preview_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.print_context.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents print_context As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents print_strip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents close_strip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents printer_guna_cmb As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Guna_print As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
