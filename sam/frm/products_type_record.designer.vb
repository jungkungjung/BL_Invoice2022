<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class products_type_record
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Pn_not_show = New System.Windows.Forms.Panel()
        Me.job_link = New System.Windows.Forms.TextBox()
        Me.PROTY_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCTS_TYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVOICEDataSet = New BLINVOICE.INVOICEDataSet()
        Me.insert_status = New System.Windows.Forms.TextBox()
        Me.PROTY_REMARKTextBox = New System.Windows.Forms.TextBox()
        Me.PROTY_CREATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Grb_sales = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SurenameLabel = New System.Windows.Forms.Label()
        Me.PROTY_CODETextBox = New System.Windows.Forms.TextBox()
        Me.PROTY_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.print1 = New System.Windows.Forms.Button()
        Me.add1 = New System.Windows.Forms.Button()
        Me.save1 = New System.Windows.Forms.Button()
        Me.delete1 = New System.Windows.Forms.Button()
        Me.exit1 = New System.Windows.Forms.Button()
        Me.PRODUCTS_TYPETableAdapter = New BLINVOICE.INVOICEDataSetTableAdapters.PRODUCTS_TYPETableAdapter()
        Me.TableAdapterManager = New BLINVOICE.INVOICEDataSetTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PRODUCTS_TYPEDataGridView = New System.Windows.Forms.DataGridView()
        Me.PROTY_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROTY_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROTY_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pn_not_show.SuspendLayout()
        CType(Me.PRODUCTS_TYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVOICEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb_sales.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PRODUCTS_TYPEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pn_not_show
        '
        Me.Pn_not_show.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Pn_not_show.Controls.Add(Me.job_link)
        Me.Pn_not_show.Controls.Add(Me.PROTY_IDTextBox)
        Me.Pn_not_show.Controls.Add(Me.insert_status)
        Me.Pn_not_show.Controls.Add(Me.PROTY_REMARKTextBox)
        Me.Pn_not_show.Controls.Add(Me.PROTY_CREATEDateTimePicker)
        Me.Pn_not_show.Location = New System.Drawing.Point(366, 186)
        Me.Pn_not_show.Name = "Pn_not_show"
        Me.Pn_not_show.Size = New System.Drawing.Size(186, 34)
        Me.Pn_not_show.TabIndex = 852
        '
        'job_link
        '
        Me.job_link.BackColor = System.Drawing.Color.OldLace
        Me.job_link.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.job_link.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.job_link.ForeColor = System.Drawing.Color.RoyalBlue
        Me.job_link.Location = New System.Drawing.Point(50, 6)
        Me.job_link.Name = "job_link"
        Me.job_link.ReadOnly = True
        Me.job_link.Size = New System.Drawing.Size(25, 20)
        Me.job_link.TabIndex = 1288
        Me.job_link.TabStop = False
        '
        'PROTY_IDTextBox
        '
        Me.PROTY_IDTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PROTY_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTS_TYPEBindingSource, "PROTY_ID", True))
        Me.PROTY_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PROTY_IDTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PROTY_IDTextBox.Location = New System.Drawing.Point(81, 5)
        Me.PROTY_IDTextBox.Name = "PROTY_IDTextBox"
        Me.PROTY_IDTextBox.Size = New System.Drawing.Size(24, 22)
        Me.PROTY_IDTextBox.TabIndex = 1125
        '
        'PRODUCTS_TYPEBindingSource
        '
        Me.PRODUCTS_TYPEBindingSource.DataMember = "PRODUCTS_TYPE"
        Me.PRODUCTS_TYPEBindingSource.DataSource = Me.INVOICEDataSet
        '
        'INVOICEDataSet
        '
        Me.INVOICEDataSet.DataSetName = "INVOICEDataSet"
        Me.INVOICEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'insert_status
        '
        Me.insert_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.insert_status.Location = New System.Drawing.Point(8, 6)
        Me.insert_status.Name = "insert_status"
        Me.insert_status.Size = New System.Drawing.Size(36, 20)
        Me.insert_status.TabIndex = 488
        Me.insert_status.TabStop = False
        Me.insert_status.Text = "0"
        '
        'PROTY_REMARKTextBox
        '
        Me.PROTY_REMARKTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PROTY_REMARKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTS_TYPEBindingSource, "PROTY_REMARK", True))
        Me.PROTY_REMARKTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PROTY_REMARKTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PROTY_REMARKTextBox.Location = New System.Drawing.Point(111, 5)
        Me.PROTY_REMARKTextBox.Name = "PROTY_REMARKTextBox"
        Me.PROTY_REMARKTextBox.Size = New System.Drawing.Size(25, 22)
        Me.PROTY_REMARKTextBox.TabIndex = 1131
        '
        'PROTY_CREATEDateTimePicker
        '
        Me.PROTY_CREATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PRODUCTS_TYPEBindingSource, "PROTY_CREATE", True))
        Me.PROTY_CREATEDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PROTY_CREATEDateTimePicker.Location = New System.Drawing.Point(142, 5)
        Me.PROTY_CREATEDateTimePicker.Name = "PROTY_CREATEDateTimePicker"
        Me.PROTY_CREATEDateTimePicker.Size = New System.Drawing.Size(36, 20)
        Me.PROTY_CREATEDateTimePicker.TabIndex = 1133
        '
        'Grb_sales
        '
        Me.Grb_sales.Controls.Add(Me.Label1)
        Me.Grb_sales.Controls.Add(Me.SurenameLabel)
        Me.Grb_sales.Controls.Add(Me.PROTY_CODETextBox)
        Me.Grb_sales.Controls.Add(Me.PROTY_NAMETextBox)
        Me.Grb_sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Grb_sales.ForeColor = System.Drawing.Color.SteelBlue
        Me.Grb_sales.Location = New System.Drawing.Point(366, 11)
        Me.Grb_sales.Name = "Grb_sales"
        Me.Grb_sales.Size = New System.Drawing.Size(439, 125)
        Me.Grb_sales.TabIndex = 1118
        Me.Grb_sales.TabStop = False
        Me.Grb_sales.Text = "บันทึกข้อมูล"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 1138
        Me.Label1.Text = "ชื่อประเภท"
        '
        'SurenameLabel
        '
        Me.SurenameLabel.AutoSize = True
        Me.SurenameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SurenameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SurenameLabel.Location = New System.Drawing.Point(20, 29)
        Me.SurenameLabel.Name = "SurenameLabel"
        Me.SurenameLabel.Size = New System.Drawing.Size(66, 16)
        Me.SurenameLabel.TabIndex = 3
        Me.SurenameLabel.Text = "รหัสประเภท"
        '
        'PROTY_CODETextBox
        '
        Me.PROTY_CODETextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PROTY_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTS_TYPEBindingSource, "PROTY_CODE", True))
        Me.PROTY_CODETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PROTY_CODETextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PROTY_CODETextBox.Location = New System.Drawing.Point(89, 26)
        Me.PROTY_CODETextBox.Name = "PROTY_CODETextBox"
        Me.PROTY_CODETextBox.Size = New System.Drawing.Size(276, 22)
        Me.PROTY_CODETextBox.TabIndex = 1127
        '
        'PROTY_NAMETextBox
        '
        Me.PROTY_NAMETextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PROTY_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTS_TYPEBindingSource, "PROTY_NAME", True))
        Me.PROTY_NAMETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PROTY_NAMETextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PROTY_NAMETextBox.Location = New System.Drawing.Point(89, 52)
        Me.PROTY_NAMETextBox.Name = "PROTY_NAMETextBox"
        Me.PROTY_NAMETextBox.Size = New System.Drawing.Size(276, 22)
        Me.PROTY_NAMETextBox.TabIndex = 1129
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.print1)
        Me.Panel1.Controls.Add(Me.add1)
        Me.Panel1.Controls.Add(Me.save1)
        Me.Panel1.Controls.Add(Me.delete1)
        Me.Panel1.Controls.Add(Me.exit1)
        Me.Panel1.Location = New System.Drawing.Point(363, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 42)
        Me.Panel1.TabIndex = 1119
        '
        'print1
        '
        Me.print1.Enabled = False
        Me.print1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.print1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.print1.Image = Global.BLINVOICE.My.Resources.Resources.printer36002
        Me.print1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.print1.Location = New System.Drawing.Point(260, 3)
        Me.print1.Name = "print1"
        Me.print1.Size = New System.Drawing.Size(90, 38)
        Me.print1.TabIndex = 33
        Me.print1.Text = "          พิมพ์"
        Me.print1.UseVisualStyleBackColor = True
        '
        'add1
        '
        Me.add1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.add1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.add1.Image = Global.BLINVOICE.My.Resources.Resources.add24
        Me.add1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.add1.Location = New System.Drawing.Point(2, 3)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(84, 38)
        Me.add1.TabIndex = 30
        Me.add1.Text = "       เพิ่มใหม่"
        Me.add1.UseVisualStyleBackColor = True
        '
        'save1
        '
        Me.save1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.save1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.save1.Image = Global.BLINVOICE.My.Resources.Resources.Save302
        Me.save1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save1.Location = New System.Drawing.Point(88, 3)
        Me.save1.Name = "save1"
        Me.save1.Size = New System.Drawing.Size(84, 38)
        Me.save1.TabIndex = 31
        Me.save1.Text = "        บันทึก"
        Me.save1.UseVisualStyleBackColor = True
        '
        'delete1
        '
        Me.delete1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.delete1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.delete1.Image = Global.BLINVOICE.My.Resources.Resources.delete301
        Me.delete1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delete1.Location = New System.Drawing.Point(174, 3)
        Me.delete1.Name = "delete1"
        Me.delete1.Size = New System.Drawing.Size(84, 38)
        Me.delete1.TabIndex = 32
        Me.delete1.Text = "         ลบข้อมูล"
        Me.delete1.UseVisualStyleBackColor = True
        '
        'exit1
        '
        Me.exit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.exit1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exit1.Image = Global.BLINVOICE.My.Resources.Resources.close26
        Me.exit1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exit1.Location = New System.Drawing.Point(352, 3)
        Me.exit1.Name = "exit1"
        Me.exit1.Size = New System.Drawing.Size(90, 38)
        Me.exit1.TabIndex = 34
        Me.exit1.Text = "  ปิดหน้าจอ"
        Me.exit1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.exit1.UseVisualStyleBackColor = True
        '
        'PRODUCTS_TYPETableAdapter
        '
        Me.PRODUCTS_TYPETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CODE_RUNNINGTableAdapter = Nothing
        Me.TableAdapterManager.COMPANYTableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMER_TYPETableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.DOCTYPETableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTS_TYPETableAdapter = Me.PRODUCTS_TYPETableAdapter
        Me.TableAdapterManager.PRODUCTSTableAdapter = Nothing
        Me.TableAdapterManager.PROVINCETableAdapter = Nothing
        Me.TableAdapterManager.SALESMANTableAdapter = Nothing
        Me.TableAdapterManager.TRANDETAILTableAdapter = Nothing
        Me.TableAdapterManager.TRANMAINTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BLINVOICE.INVOICEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PRODUCTS_TYPEDataGridView)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 1042)
        Me.Panel2.TabIndex = 1126
        '
        'PRODUCTS_TYPEDataGridView
        '
        Me.PRODUCTS_TYPEDataGridView.AllowUserToAddRows = False
        Me.PRODUCTS_TYPEDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PRODUCTS_TYPEDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PRODUCTS_TYPEDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PRODUCTS_TYPEDataGridView.AutoGenerateColumns = False
        Me.PRODUCTS_TYPEDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.PRODUCTS_TYPEDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PRODUCTS_TYPEDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PRODUCTS_TYPEDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PRODUCTS_TYPEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCTS_TYPEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PROTY_ID, Me.PROTY_CODE, Me.PROTY_NAME, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PRODUCTS_TYPEDataGridView.DataSource = Me.PRODUCTS_TYPEBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PRODUCTS_TYPEDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.PRODUCTS_TYPEDataGridView.EnableHeadersVisualStyles = False
        Me.PRODUCTS_TYPEDataGridView.Location = New System.Drawing.Point(11, 28)
        Me.PRODUCTS_TYPEDataGridView.Name = "PRODUCTS_TYPEDataGridView"
        Me.PRODUCTS_TYPEDataGridView.ReadOnly = True
        Me.PRODUCTS_TYPEDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PRODUCTS_TYPEDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.PRODUCTS_TYPEDataGridView.RowHeadersWidth = 26
        Me.PRODUCTS_TYPEDataGridView.Size = New System.Drawing.Size(324, 1001)
        Me.PRODUCTS_TYPEDataGridView.TabIndex = 1126
        '
        'PROTY_ID
        '
        Me.PROTY_ID.DataPropertyName = "PROTY_ID"
        Me.PROTY_ID.HeaderText = "PROTY_ID"
        Me.PROTY_ID.Name = "PROTY_ID"
        Me.PROTY_ID.ReadOnly = True
        Me.PROTY_ID.Visible = False
        '
        'PROTY_CODE
        '
        Me.PROTY_CODE.DataPropertyName = "PROTY_CODE"
        Me.PROTY_CODE.HeaderText = "รหัสประเภท"
        Me.PROTY_CODE.Name = "PROTY_CODE"
        Me.PROTY_CODE.ReadOnly = True
        '
        'PROTY_NAME
        '
        Me.PROTY_NAME.DataPropertyName = "PROTY_NAME"
        Me.PROTY_NAME.FillWeight = 181.0!
        Me.PROTY_NAME.HeaderText = "ชื่อประเภท"
        Me.PROTY_NAME.Name = "PROTY_NAME"
        Me.PROTY_NAME.ReadOnly = True
        Me.PROTY_NAME.Width = 181
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PROTY_REMARK"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PROTY_REMARK"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PROTY_CREATE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PROTY_CREATE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 1139
        Me.Label2.Text = "ประเภทสินค้า"
        '
        'products_type_record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1690, 1042)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Grb_sales)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pn_not_show)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "products_type_record"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ประเภทสินค้า"
        Me.Pn_not_show.ResumeLayout(False)
        Me.Pn_not_show.PerformLayout()
        CType(Me.PRODUCTS_TYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVOICEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb_sales.ResumeLayout(False)
        Me.Grb_sales.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PRODUCTS_TYPEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents delete1 As System.Windows.Forms.Button
    Friend WithEvents save1 As System.Windows.Forms.Button
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents exit1 As System.Windows.Forms.Button
    'Friend WithEvents SCRSQLDataSet As Reporter3.SCRSQLDataSet
    'Friend WithEvents TbcustomerTableAdapter As Reporter3.SCRSQLDataSetTableAdapters.tbcustomerTableAdapter
    'Friend WithEvents TableAdapterManager As Reporter3.SCRSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Pn_not_show As System.Windows.Forms.Panel
    Friend WithEvents job_link As System.Windows.Forms.TextBox
    Friend WithEvents insert_status As System.Windows.Forms.TextBox
    Friend WithEvents Grb_sales As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents print1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SurenameLabel As System.Windows.Forms.Label
    Friend WithEvents INVOICEDataSet As BLINVOICE.INVOICEDataSet
    Friend WithEvents PRODUCTS_TYPEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUCTS_TYPETableAdapter As BLINVOICE.INVOICEDataSetTableAdapters.PRODUCTS_TYPETableAdapter
    Friend WithEvents TableAdapterManager As BLINVOICE.INVOICEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PROTY_CODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PROTY_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PROTY_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PROTY_REMARKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PROTY_CREATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PRODUCTS_TYPEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PROTY_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROTY_CODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROTY_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
