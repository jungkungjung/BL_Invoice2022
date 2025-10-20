<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datagrid_testkey
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.max_text = New System.Windows.Forms.TextBox()
        Me.ard_b_sv = New System.Windows.Forms.TextBox()
        Me.ard_b_vat = New System.Windows.Forms.TextBox()
        Me.ard_b_amt = New System.Windows.Forms.TextBox()
        Me.vat_rate = New System.Windows.Forms.TextBox()
        Me.vat_bt = New System.Windows.Forms.Button()
        Me.vat_ty = New System.Windows.Forms.TextBox()
        Me.keyin = New System.Windows.Forms.TextBox()
        Me.var3 = New System.Windows.Forms.TextBox()
        Me.var2 = New System.Windows.Forms.TextBox()
        Me.var1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(64, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(779, 166)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 227)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(343, 20)
        Me.TextBox1.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(271, 284)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(73, 284)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "LinkLabel2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "max_key"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'max_text
        '
        Me.max_text.Location = New System.Drawing.Point(64, 345)
        Me.max_text.Name = "max_text"
        Me.max_text.Size = New System.Drawing.Size(100, 20)
        Me.max_text.TabIndex = 5
        '
        'ard_b_sv
        '
        Me.ard_b_sv.Location = New System.Drawing.Point(711, 287)
        Me.ard_b_sv.Name = "ard_b_sv"
        Me.ard_b_sv.Size = New System.Drawing.Size(132, 20)
        Me.ard_b_sv.TabIndex = 6
        Me.ard_b_sv.Text = "0"
        '
        'ard_b_vat
        '
        Me.ard_b_vat.Location = New System.Drawing.Point(711, 311)
        Me.ard_b_vat.Name = "ard_b_vat"
        Me.ard_b_vat.Size = New System.Drawing.Size(132, 20)
        Me.ard_b_vat.TabIndex = 7
        Me.ard_b_vat.Text = "0"
        '
        'ard_b_amt
        '
        Me.ard_b_amt.Location = New System.Drawing.Point(711, 335)
        Me.ard_b_amt.Name = "ard_b_amt"
        Me.ard_b_amt.Size = New System.Drawing.Size(132, 20)
        Me.ard_b_amt.TabIndex = 8
        Me.ard_b_amt.Text = "0"
        '
        'vat_rate
        '
        Me.vat_rate.Location = New System.Drawing.Point(648, 310)
        Me.vat_rate.Name = "vat_rate"
        Me.vat_rate.Size = New System.Drawing.Size(48, 20)
        Me.vat_rate.TabIndex = 9
        Me.vat_rate.Text = "7"
        '
        'vat_bt
        '
        Me.vat_bt.Location = New System.Drawing.Point(726, 359)
        Me.vat_bt.Name = "vat_bt"
        Me.vat_bt.Size = New System.Drawing.Size(75, 23)
        Me.vat_bt.TabIndex = 10
        Me.vat_bt.Text = "vat"
        Me.vat_bt.UseVisualStyleBackColor = True
        '
        'vat_ty
        '
        Me.vat_ty.Location = New System.Drawing.Point(648, 287)
        Me.vat_ty.Name = "vat_ty"
        Me.vat_ty.Size = New System.Drawing.Size(48, 20)
        Me.vat_ty.TabIndex = 11
        Me.vat_ty.Text = "1"
        '
        'keyin
        '
        Me.keyin.Location = New System.Drawing.Point(711, 261)
        Me.keyin.Name = "keyin"
        Me.keyin.Size = New System.Drawing.Size(132, 20)
        Me.keyin.TabIndex = 12
        Me.keyin.Text = "0"
        '
        'var3
        '
        Me.var3.Location = New System.Drawing.Point(880, 335)
        Me.var3.Name = "var3"
        Me.var3.Size = New System.Drawing.Size(132, 20)
        Me.var3.TabIndex = 15
        Me.var3.Text = "0"
        '
        'var2
        '
        Me.var2.Location = New System.Drawing.Point(880, 311)
        Me.var2.Name = "var2"
        Me.var2.Size = New System.Drawing.Size(132, 20)
        Me.var2.TabIndex = 14
        Me.var2.Text = "0"
        '
        'var1
        '
        Me.var1.Location = New System.Drawing.Point(880, 287)
        Me.var1.Name = "var1"
        Me.var1.Size = New System.Drawing.Size(132, 20)
        Me.var1.TabIndex = 13
        Me.var1.Text = "0"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(867, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "function"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'datagrid_testkey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 465)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.var3)
        Me.Controls.Add(Me.var2)
        Me.Controls.Add(Me.var1)
        Me.Controls.Add(Me.keyin)
        Me.Controls.Add(Me.vat_ty)
        Me.Controls.Add(Me.vat_bt)
        Me.Controls.Add(Me.vat_rate)
        Me.Controls.Add(Me.ard_b_amt)
        Me.Controls.Add(Me.ard_b_vat)
        Me.Controls.Add(Me.ard_b_sv)
        Me.Controls.Add(Me.max_text)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "datagrid_testkey"
        Me.Text = "datagrid_testkey"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents max_text As System.Windows.Forms.TextBox
    Friend WithEvents ard_b_sv As System.Windows.Forms.TextBox
    Friend WithEvents ard_b_vat As System.Windows.Forms.TextBox
    Friend WithEvents ard_b_amt As System.Windows.Forms.TextBox
    Friend WithEvents vat_rate As System.Windows.Forms.TextBox
    Friend WithEvents vat_bt As System.Windows.Forms.Button
    Friend WithEvents vat_ty As System.Windows.Forms.TextBox
    Friend WithEvents keyin As System.Windows.Forms.TextBox
    Friend WithEvents var3 As System.Windows.Forms.TextBox
    Friend WithEvents var2 As System.Windows.Forms.TextBox
    Friend WithEvents var1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
