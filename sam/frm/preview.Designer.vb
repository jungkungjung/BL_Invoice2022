<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class preview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(preview))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.print_context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.print_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.close_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.print_context.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.EnableToolTips = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(650, 484)
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
        'preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(650, 484)
        Me.ContextMenuStrip = Me.print_context
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "preview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.print_context.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents print_context As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents print_strip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents close_strip As System.Windows.Forms.ToolStripMenuItem
End Class
