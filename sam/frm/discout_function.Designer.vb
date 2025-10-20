<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class discout_function
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.disc_test = New System.Windows.Forms.TextBox()
        Me.gkeyin_amt = New System.Windows.Forms.TextBox()
        Me.disc_amt = New System.Windows.Forms.TextBox()
        Me.after_disc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.disc_sum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.amt_parse = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(395, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 29)
        Me.Button1.TabIndex = 1478
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'disc_test
        '
        Me.disc_test.Location = New System.Drawing.Point(117, 80)
        Me.disc_test.Name = "disc_test"
        Me.disc_test.Size = New System.Drawing.Size(115, 22)
        Me.disc_test.TabIndex = 1477
        '
        'gkeyin_amt
        '
        Me.gkeyin_amt.Location = New System.Drawing.Point(117, 48)
        Me.gkeyin_amt.Name = "gkeyin_amt"
        Me.gkeyin_amt.Size = New System.Drawing.Size(115, 22)
        Me.gkeyin_amt.TabIndex = 1479
        Me.gkeyin_amt.Text = "200"
        '
        'disc_amt
        '
        Me.disc_amt.Location = New System.Drawing.Point(117, 112)
        Me.disc_amt.Name = "disc_amt"
        Me.disc_amt.Size = New System.Drawing.Size(115, 22)
        Me.disc_amt.TabIndex = 1480
        '
        'after_disc
        '
        Me.after_disc.Location = New System.Drawing.Point(117, 144)
        Me.after_disc.Name = "after_disc"
        Me.after_disc.Size = New System.Drawing.Size(115, 22)
        Me.after_disc.TabIndex = 1481
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(68, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 1482
        Me.Label1.Text = "ยอดเงิน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(68, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 1482
        Me.Label2.Text = "ส่วนลด"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(68, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 1482
        Me.Label3.Text = "ยอดลด"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(69, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 1483
        Me.Label4.Text = "หลังลด"
        '
        'disc_sum
        '
        Me.disc_sum.Location = New System.Drawing.Point(301, 80)
        Me.disc_sum.Name = "disc_sum"
        Me.disc_sum.Size = New System.Drawing.Size(78, 22)
        Me.disc_sum.TabIndex = 1484
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(247, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 1485
        Me.Label5.Text = "ลดสะสม"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(395, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 29)
        Me.Button2.TabIndex = 1486
        Me.Button2.Text = "ตรวจสอบ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(395, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 29)
        Me.Button3.TabIndex = 1487
        Me.Button3.Text = "ยอดลดรวม"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'amt_parse
        '
        Me.amt_parse.Location = New System.Drawing.Point(301, 109)
        Me.amt_parse.Name = "amt_parse"
        Me.amt_parse.Size = New System.Drawing.Size(78, 22)
        Me.amt_parse.TabIndex = 1488
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(395, 253)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 29)
        Me.Button4.TabIndex = 1489
        Me.Button4.Text = "ยอดลดรวม"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(46, 221)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(65, 22)
        Me.TextBox1.TabIndex = 1490
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(130, 221)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(88, 22)
        Me.TextBox2.TabIndex = 1491
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(237, 221)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 22)
        Me.TextBox3.TabIndex = 1492
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(395, 218)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 29)
        Me.Button5.TabIndex = 1493
        Me.Button5.Text = "คำนวณ"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(237, 249)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(88, 22)
        Me.TextBox4.TabIndex = 1494
        '
        'discout_function
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 681)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.amt_parse)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.disc_sum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.after_disc)
        Me.Controls.Add(Me.disc_amt)
        Me.Controls.Add(Me.gkeyin_amt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.disc_test)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.KeyPreview = True
        Me.Name = "discout_function"
        Me.Text = "discout_function"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents disc_test As System.Windows.Forms.TextBox
    Friend WithEvents gkeyin_amt As System.Windows.Forms.TextBox
    Friend WithEvents disc_amt As System.Windows.Forms.TextBox
    Friend WithEvents after_disc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents disc_sum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents amt_parse As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
