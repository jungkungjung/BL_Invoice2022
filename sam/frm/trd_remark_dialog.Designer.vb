<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trd_remark_dialog
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.save1 = New System.Windows.Forms.Button()
        Me.items_remark = New System.Windows.Forms.TextBox()
        Me.escape_lnk = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 214)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(514, 22)
        Me.StatusStrip1.TabIndex = 1351
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'save1
        '
        Me.save1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.save1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.save1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.save1.ForeColor = System.Drawing.Color.Teal
        Me.save1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save1.Location = New System.Drawing.Point(12, 183)
        Me.save1.Name = "save1"
        Me.save1.Size = New System.Drawing.Size(77, 25)
        Me.save1.TabIndex = 1357
        Me.save1.Text = "บันทึก"
        Me.save1.UseVisualStyleBackColor = True
        '
        'items_remark
        '
        Me.items_remark.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.items_remark.BackColor = System.Drawing.Color.WhiteSmoke
        Me.items_remark.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.items_remark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.items_remark.Location = New System.Drawing.Point(12, 12)
        Me.items_remark.MaxLength = 2147483647
        Me.items_remark.Multiline = True
        Me.items_remark.Name = "items_remark"
        Me.items_remark.Size = New System.Drawing.Size(490, 165)
        Me.items_remark.TabIndex = 1355
        '
        'escape_lnk
        '
        Me.escape_lnk.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.escape_lnk.AutoSize = True
        Me.escape_lnk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.escape_lnk.ForeColor = System.Drawing.Color.LightGray
        Me.escape_lnk.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.escape_lnk.Location = New System.Drawing.Point(413, 187)
        Me.escape_lnk.Name = "escape_lnk"
        Me.escape_lnk.Size = New System.Drawing.Size(87, 16)
        Me.escape_lnk.TabIndex = 1485
        Me.escape_lnk.TabStop = True
        Me.escape_lnk.Text = "escape_result"
        Me.escape_lnk.Visible = False
        '
        'trd_remark_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.escape_lnk
        Me.ClientSize = New System.Drawing.Size(514, 236)
        Me.Controls.Add(Me.escape_lnk)
        Me.Controls.Add(Me.items_remark)
        Me.Controls.Add(Me.save1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "trd_remark_dialog"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "คำอธิบายรายการ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents save1 As System.Windows.Forms.Button
    Friend WithEvents items_remark As System.Windows.Forms.TextBox
    Friend WithEvents escape_lnk As System.Windows.Forms.LinkLabel
End Class
