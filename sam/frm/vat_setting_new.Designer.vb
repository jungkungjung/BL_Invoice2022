<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vat_setting_new
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.vat_ty2 = New System.Windows.Forms.RadioButton()
        Me.vat_ty1 = New System.Windows.Forms.RadioButton()
        Me.vat_ty0 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.vat_inex1 = New System.Windows.Forms.RadioButton()
        Me.vat_inex0 = New System.Windows.Forms.RadioButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TRH_VAT_TYTextBox = New System.Windows.Forms.TextBox()
        Me.TRH_VATIOTextBox = New System.Windows.Forms.TextBox()
        Me.Pn_not_show = New System.Windows.Forms.Panel()
        Me.save1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Pn_not_show.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.vat_ty2)
        Me.GroupBox2.Controls.Add(Me.vat_ty1)
        Me.GroupBox2.Controls.Add(Me.vat_ty0)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(24, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 102)
        Me.GroupBox2.TabIndex = 1349
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "วิธีคิดภาษี"
        '
        'vat_ty2
        '
        Me.vat_ty2.AutoSize = True
        Me.vat_ty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.vat_ty2.ForeColor = System.Drawing.Color.DimGray
        Me.vat_ty2.Location = New System.Drawing.Point(18, 68)
        Me.vat_ty2.Name = "vat_ty2"
        Me.vat_ty2.Size = New System.Drawing.Size(64, 20)
        Me.vat_ty2.TabIndex = 0
        Me.vat_ty2.Text = "ไม่มีภาษี"
        Me.vat_ty2.UseVisualStyleBackColor = True
        '
        'vat_ty1
        '
        Me.vat_ty1.AutoSize = True
        Me.vat_ty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.vat_ty1.ForeColor = System.Drawing.Color.DimGray
        Me.vat_ty1.Location = New System.Drawing.Point(18, 44)
        Me.vat_ty1.Name = "vat_ty1"
        Me.vat_ty1.Size = New System.Drawing.Size(73, 20)
        Me.vat_ty1.TabIndex = 0
        Me.vat_ty1.Text = "ยกเว้นภาษี"
        Me.vat_ty1.UseVisualStyleBackColor = True
        '
        'vat_ty0
        '
        Me.vat_ty0.AutoSize = True
        Me.vat_ty0.Checked = True
        Me.vat_ty0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.vat_ty0.ForeColor = System.Drawing.Color.DimGray
        Me.vat_ty0.Location = New System.Drawing.Point(17, 20)
        Me.vat_ty0.Name = "vat_ty0"
        Me.vat_ty0.Size = New System.Drawing.Size(76, 20)
        Me.vat_ty0.TabIndex = 0
        Me.vat_ty0.TabStop = True
        Me.vat_ty0.Text = "อัตราทั่วไป"
        Me.vat_ty0.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.vat_inex1)
        Me.GroupBox1.Controls.Add(Me.vat_inex0)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(168, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 102)
        Me.GroupBox1.TabIndex = 1350
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "วิธีคิดราคา"
        '
        'vat_inex1
        '
        Me.vat_inex1.AutoSize = True
        Me.vat_inex1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.vat_inex1.ForeColor = System.Drawing.Color.DimGray
        Me.vat_inex1.Location = New System.Drawing.Point(17, 44)
        Me.vat_inex1.Name = "vat_inex1"
        Me.vat_inex1.Size = New System.Drawing.Size(82, 20)
        Me.vat_inex1.TabIndex = 0
        Me.vat_inex1.Text = "รวมภาษีแล้ว"
        Me.vat_inex1.UseVisualStyleBackColor = True
        '
        'vat_inex0
        '
        Me.vat_inex0.AutoSize = True
        Me.vat_inex0.Checked = True
        Me.vat_inex0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.vat_inex0.ForeColor = System.Drawing.Color.DimGray
        Me.vat_inex0.Location = New System.Drawing.Point(16, 20)
        Me.vat_inex0.Name = "vat_inex0"
        Me.vat_inex0.Size = New System.Drawing.Size(88, 20)
        Me.vat_inex0.TabIndex = 0
        Me.vat_inex0.TabStop = True
        Me.vat_inex0.Text = "ยังไม่รวมภาษี"
        Me.vat_inex0.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 175)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(390, 22)
        Me.StatusStrip1.TabIndex = 1351
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TRH_VAT_TYTextBox
        '
        Me.TRH_VAT_TYTextBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TRH_VAT_TYTextBox.Location = New System.Drawing.Point(3, 3)
        Me.TRH_VAT_TYTextBox.Name = "TRH_VAT_TYTextBox"
        Me.TRH_VAT_TYTextBox.Size = New System.Drawing.Size(23, 22)
        Me.TRH_VAT_TYTextBox.TabIndex = 1355
        '
        'TRH_VATIOTextBox
        '
        Me.TRH_VATIOTextBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TRH_VATIOTextBox.Location = New System.Drawing.Point(3, 27)
        Me.TRH_VATIOTextBox.Name = "TRH_VATIOTextBox"
        Me.TRH_VATIOTextBox.Size = New System.Drawing.Size(23, 22)
        Me.TRH_VATIOTextBox.TabIndex = 1354
        '
        'Pn_not_show
        '
        Me.Pn_not_show.Controls.Add(Me.TRH_VAT_TYTextBox)
        Me.Pn_not_show.Controls.Add(Me.TRH_VATIOTextBox)
        Me.Pn_not_show.Location = New System.Drawing.Point(305, 30)
        Me.Pn_not_show.Name = "Pn_not_show"
        Me.Pn_not_show.Size = New System.Drawing.Size(32, 53)
        Me.Pn_not_show.TabIndex = 1356
        '
        'save1
        '
        Me.save1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.save1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.save1.ForeColor = System.Drawing.Color.Teal
        Me.save1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save1.Location = New System.Drawing.Point(24, 130)
        Me.save1.Name = "save1"
        Me.save1.Size = New System.Drawing.Size(77, 25)
        Me.save1.TabIndex = 1357
        Me.save1.Text = "บันทึก"
        Me.save1.UseVisualStyleBackColor = True
        '
        'vat_setting_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 197)
        Me.Controls.Add(Me.save1)
        Me.Controls.Add(Me.Pn_not_show)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "vat_setting_new"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ตั้งค่าภาษี"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Pn_not_show.ResumeLayout(False)
        Me.Pn_not_show.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents vat_ty2 As System.Windows.Forms.RadioButton
    Friend WithEvents vat_ty1 As System.Windows.Forms.RadioButton
    Friend WithEvents vat_ty0 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents vat_inex1 As System.Windows.Forms.RadioButton
    Friend WithEvents vat_inex0 As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TRH_VAT_TYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRH_VATIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pn_not_show As System.Windows.Forms.Panel
    Friend WithEvents save1 As System.Windows.Forms.Button
End Class
