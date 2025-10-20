<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer_record_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer_record_new))
        Me.return_lnk = New System.Windows.Forms.LinkLabel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.bottom_line = New Guna.UI.WinForms.GunaSeparator()
        Me.Pn_not_show = New System.Windows.Forms.Panel()
        Me.CUS_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVOICEDataSet = New BLINVOICE.INVOICEDataSet()
        Me.CUS_CATTextBox = New System.Windows.Forms.TextBox()
        Me.insert_status = New System.Windows.Forms.TextBox()
        Me.CUS_SLMNTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_TAX_TYTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_TAX_VATIOTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_STATUSCheckBox = New System.Windows.Forms.CheckBox()
        Me.CUS_CREATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.province_cmb = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna_print = New Guna.UI.WinForms.GunaButton()
        Me.Guna_delete = New Guna.UI.WinForms.GunaButton()
        Me.Guna_add = New Guna.UI.WinForms.GunaButton()
        Me.Guna_exit = New Guna.UI.WinForms.GunaButton()
        Me.Guna_save = New Guna.UI.WinForms.GunaButton()
        Me.CUS_PROVINCETextBox = New System.Windows.Forms.TextBox()
        Me.GunaTextBox17 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox18 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox19 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox20 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox21 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox22 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox23 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox24 = New Guna.UI.WinForms.GunaTextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.CUSTOMERTableAdapter = New BLINVOICE.INVOICEDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.TableAdapterManager = New BLINVOICE.INVOICEDataSetTableAdapters.TableAdapterManager()
        Me.CUS_CODETextBox = New System.Windows.Forms.TextBox()
        Me.CUS_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.CUS_BRANCHTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_TAXIDTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_ADDB1TextBox = New System.Windows.Forms.TextBox()
        Me.CUS_ADDB2TextBox = New System.Windows.Forms.TextBox()
        Me.CUS_POSTTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_TELTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_FAXTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_MAILTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_WEBTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_CONTACTTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_CREDIT_TERMTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_CREDIT_LIMITTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_DISC_PERCENTextBox = New System.Windows.Forms.TextBox()
        Me.CUS_REMARKTextBox = New System.Windows.Forms.TextBox()
        Me.SurenameLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MailLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FaxLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.CustnameLabel = New System.Windows.Forms.Label()
        Me.ADDR1Label = New System.Windows.Forms.Label()
        Me.ZIPLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TAX_VATIO = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TAX_CMB = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SALES_CMB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RemarkLabel = New System.Windows.Forms.Label()
        Me.SLMCODLabel = New System.Windows.Forms.Label()
        Me.CONTACTLabel = New System.Windows.Forms.Label()
        Me.GunaControlBox6 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox5 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaPictureBox3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.province_lnk = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.Pn_not_show.SuspendLayout()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVOICEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.province_lnk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'return_lnk
        '
        Me.return_lnk.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.AutoSize = True
        Me.return_lnk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.return_lnk.ForeColor = System.Drawing.Color.LightGray
        Me.return_lnk.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.Location = New System.Drawing.Point(198, 9)
        Me.return_lnk.Name = "return_lnk"
        Me.return_lnk.Size = New System.Drawing.Size(52, 16)
        Me.return_lnk.TabIndex = 1123
        Me.return_lnk.TabStop = True
        Me.return_lnk.Text = "Refresh"
        Me.return_lnk.Visible = False
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.LightGray
        Me.GunaElipsePanel1.Controls.Add(Me.bottom_line)
        Me.GunaElipsePanel1.Controls.Add(Me.Pn_not_show)
        Me.GunaElipsePanel1.Controls.Add(Me.Panel3)
        Me.GunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(0, 872)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 1
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(1164, 60)
        Me.GunaElipsePanel1.TabIndex = 1538
        '
        'bottom_line
        '
        Me.bottom_line.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bottom_line.LineColor = System.Drawing.Color.Silver
        Me.bottom_line.Location = New System.Drawing.Point(0, -5)
        Me.bottom_line.Name = "bottom_line"
        Me.bottom_line.Size = New System.Drawing.Size(1164, 10)
        Me.bottom_line.TabIndex = 1556
        Me.bottom_line.TabStop = False
        '
        'Pn_not_show
        '
        Me.Pn_not_show.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Pn_not_show.Controls.Add(Me.return_lnk)
        Me.Pn_not_show.Controls.Add(Me.CUS_IDTextBox)
        Me.Pn_not_show.Controls.Add(Me.CUS_CATTextBox)
        Me.Pn_not_show.Controls.Add(Me.insert_status)
        Me.Pn_not_show.Controls.Add(Me.CUS_SLMNTextBox)
        Me.Pn_not_show.Controls.Add(Me.CUS_TAX_TYTextBox)
        Me.Pn_not_show.Controls.Add(Me.CUS_TAX_VATIOTextBox)
        Me.Pn_not_show.Controls.Add(Me.CUS_STATUSCheckBox)
        Me.Pn_not_show.Controls.Add(Me.CUS_CREATEDateTimePicker)
        Me.Pn_not_show.Controls.Add(Me.province_cmb)
        Me.Pn_not_show.Location = New System.Drawing.Point(534, 8)
        Me.Pn_not_show.Name = "Pn_not_show"
        Me.Pn_not_show.Size = New System.Drawing.Size(477, 33)
        Me.Pn_not_show.TabIndex = 852
        '
        'CUS_IDTextBox
        '
        Me.CUS_IDTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_ID", True))
        Me.CUS_IDTextBox.Location = New System.Drawing.Point(33, 3)
        Me.CUS_IDTextBox.Name = "CUS_IDTextBox"
        Me.CUS_IDTextBox.Size = New System.Drawing.Size(24, 22)
        Me.CUS_IDTextBox.TabIndex = 1881
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.INVOICEDataSet
        '
        'INVOICEDataSet
        '
        Me.INVOICEDataSet.DataSetName = "INVOICEDataSet"
        Me.INVOICEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CUS_CATTextBox
        '
        Me.CUS_CATTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_CATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_CAT", True))
        Me.CUS_CATTextBox.Location = New System.Drawing.Point(88, 3)
        Me.CUS_CATTextBox.Name = "CUS_CATTextBox"
        Me.CUS_CATTextBox.Size = New System.Drawing.Size(23, 22)
        Me.CUS_CATTextBox.TabIndex = 1907
        '
        'insert_status
        '
        Me.insert_status.BackColor = System.Drawing.Color.WhiteSmoke
        Me.insert_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.insert_status.Location = New System.Drawing.Point(5, 5)
        Me.insert_status.Name = "insert_status"
        Me.insert_status.Size = New System.Drawing.Size(22, 20)
        Me.insert_status.TabIndex = 488
        Me.insert_status.TabStop = False
        Me.insert_status.Text = "0"
        '
        'CUS_SLMNTextBox
        '
        Me.CUS_SLMNTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_SLMNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_SLMN", True))
        Me.CUS_SLMNTextBox.Location = New System.Drawing.Point(117, 3)
        Me.CUS_SLMNTextBox.Name = "CUS_SLMNTextBox"
        Me.CUS_SLMNTextBox.Size = New System.Drawing.Size(19, 22)
        Me.CUS_SLMNTextBox.TabIndex = 1909
        '
        'CUS_TAX_TYTextBox
        '
        Me.CUS_TAX_TYTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_TAX_TYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_TAX_TY", True))
        Me.CUS_TAX_TYTextBox.Location = New System.Drawing.Point(142, 3)
        Me.CUS_TAX_TYTextBox.Name = "CUS_TAX_TYTextBox"
        Me.CUS_TAX_TYTextBox.Size = New System.Drawing.Size(23, 22)
        Me.CUS_TAX_TYTextBox.TabIndex = 1919
        '
        'CUS_TAX_VATIOTextBox
        '
        Me.CUS_TAX_VATIOTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_TAX_VATIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_TAX_VATIO", True))
        Me.CUS_TAX_VATIOTextBox.Location = New System.Drawing.Point(169, 3)
        Me.CUS_TAX_VATIOTextBox.Name = "CUS_TAX_VATIOTextBox"
        Me.CUS_TAX_VATIOTextBox.Size = New System.Drawing.Size(23, 22)
        Me.CUS_TAX_VATIOTextBox.TabIndex = 1921
        '
        'CUS_STATUSCheckBox
        '
        Me.CUS_STATUSCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CUSTOMERBindingSource, "CUS_STATUS", True))
        Me.CUS_STATUSCheckBox.Location = New System.Drawing.Point(256, 6)
        Me.CUS_STATUSCheckBox.Name = "CUS_STATUSCheckBox"
        Me.CUS_STATUSCheckBox.Size = New System.Drawing.Size(65, 24)
        Me.CUS_STATUSCheckBox.TabIndex = 1925
        Me.CUS_STATUSCheckBox.Text = "status"
        Me.CUS_STATUSCheckBox.UseVisualStyleBackColor = True
        '
        'CUS_CREATEDateTimePicker
        '
        Me.CUS_CREATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CUSTOMERBindingSource, "CUS_CREATE", True))
        Me.CUS_CREATEDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CUS_CREATEDateTimePicker.Location = New System.Drawing.Point(317, 6)
        Me.CUS_CREATEDateTimePicker.Name = "CUS_CREATEDateTimePicker"
        Me.CUS_CREATEDateTimePicker.Size = New System.Drawing.Size(52, 22)
        Me.CUS_CREATEDateTimePicker.TabIndex = 1927
        '
        'province_cmb
        '
        Me.province_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.province_cmb.BackColor = System.Drawing.Color.WhiteSmoke
        Me.province_cmb.DropDownHeight = 300
        Me.province_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.province_cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.province_cmb.ForeColor = System.Drawing.SystemColors.WindowText
        Me.province_cmb.FormattingEnabled = True
        Me.province_cmb.IntegralHeight = False
        Me.province_cmb.Location = New System.Drawing.Point(375, 4)
        Me.province_cmb.Name = "province_cmb"
        Me.province_cmb.Size = New System.Drawing.Size(31, 24)
        Me.province_cmb.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.CausesValidation = False
        Me.Panel3.Controls.Add(Me.Guna_print)
        Me.Panel3.Controls.Add(Me.Guna_delete)
        Me.Panel3.Controls.Add(Me.Guna_add)
        Me.Panel3.Controls.Add(Me.Guna_exit)
        Me.Panel3.Controls.Add(Me.Guna_save)
        Me.Panel3.Location = New System.Drawing.Point(12, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(516, 39)
        Me.Panel3.TabIndex = 1481
        '
        'Guna_print
        '
        Me.Guna_print.AnimationHoverSpeed = 0.07!
        Me.Guna_print.AnimationSpeed = 0.03!
        Me.Guna_print.BackColor = System.Drawing.Color.Transparent
        Me.Guna_print.BaseColor = System.Drawing.SystemColors.ControlLight
        Me.Guna_print.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_print.BorderSize = 2
        Me.Guna_print.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Guna_print.FocusedColor = System.Drawing.Color.SteelBlue
        Me.Guna_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna_print.ForeColor = System.Drawing.Color.DimGray
        Me.Guna_print.Image = Global.BLINVOICE.My.Resources.Resources.Print_32x32
        Me.Guna_print.ImageSize = New System.Drawing.Size(28, 28)
        Me.Guna_print.Location = New System.Drawing.Point(297, 3)
        Me.Guna_print.Name = "Guna_print"
        Me.Guna_print.OnHoverBaseColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_print.OnHoverBorderColor = System.Drawing.Color.SteelBlue
        Me.Guna_print.OnHoverForeColor = System.Drawing.Color.DarkSlateGray
        Me.Guna_print.OnHoverImage = Nothing
        Me.Guna_print.OnPressedColor = System.Drawing.Color.Black
        Me.Guna_print.Radius = 2
        Me.Guna_print.Size = New System.Drawing.Size(94, 32)
        Me.Guna_print.TabIndex = 1478
        Me.Guna_print.Text = "พิมพ์"
        Me.Guna_print.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'Guna_delete
        '
        Me.Guna_delete.AnimationHoverSpeed = 0.07!
        Me.Guna_delete.AnimationSpeed = 0.03!
        Me.Guna_delete.BackColor = System.Drawing.Color.Transparent
        Me.Guna_delete.BaseColor = System.Drawing.SystemColors.ControlLight
        Me.Guna_delete.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_delete.BorderSize = 2
        Me.Guna_delete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Guna_delete.FocusedColor = System.Drawing.Color.SteelBlue
        Me.Guna_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna_delete.ForeColor = System.Drawing.Color.DimGray
        Me.Guna_delete.Image = Global.BLINVOICE.My.Resources.Resources.delete301
        Me.Guna_delete.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna_delete.Location = New System.Drawing.Point(199, 3)
        Me.Guna_delete.Name = "Guna_delete"
        Me.Guna_delete.OnHoverBaseColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_delete.OnHoverBorderColor = System.Drawing.Color.SteelBlue
        Me.Guna_delete.OnHoverForeColor = System.Drawing.Color.DarkSlateGray
        Me.Guna_delete.OnHoverImage = Nothing
        Me.Guna_delete.OnPressedColor = System.Drawing.Color.Black
        Me.Guna_delete.Radius = 2
        Me.Guna_delete.Size = New System.Drawing.Size(94, 32)
        Me.Guna_delete.TabIndex = 1477
        Me.Guna_delete.Text = "ลบข้อมูล"
        Me.Guna_delete.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'Guna_add
        '
        Me.Guna_add.AnimationHoverSpeed = 0.07!
        Me.Guna_add.AnimationSpeed = 0.03!
        Me.Guna_add.BackColor = System.Drawing.Color.Transparent
        Me.Guna_add.BaseColor = System.Drawing.SystemColors.ControlLight
        Me.Guna_add.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_add.BorderSize = 2
        Me.Guna_add.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Guna_add.FocusedColor = System.Drawing.Color.SteelBlue
        Me.Guna_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna_add.ForeColor = System.Drawing.Color.DimGray
        Me.Guna_add.Image = Global.BLINVOICE.My.Resources.Resources.Add_32x32
        Me.Guna_add.ImageSize = New System.Drawing.Size(22, 22)
        Me.Guna_add.Location = New System.Drawing.Point(3, 3)
        Me.Guna_add.Name = "Guna_add"
        Me.Guna_add.OnHoverBaseColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_add.OnHoverBorderColor = System.Drawing.Color.SteelBlue
        Me.Guna_add.OnHoverForeColor = System.Drawing.Color.DarkSlateGray
        Me.Guna_add.OnHoverImage = Nothing
        Me.Guna_add.OnPressedColor = System.Drawing.Color.Black
        Me.Guna_add.Radius = 2
        Me.Guna_add.Size = New System.Drawing.Size(94, 32)
        Me.Guna_add.TabIndex = 1475
        Me.Guna_add.Text = "เพิ่มใหม่"
        Me.Guna_add.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'Guna_exit
        '
        Me.Guna_exit.AnimationHoverSpeed = 0.07!
        Me.Guna_exit.AnimationSpeed = 0.03!
        Me.Guna_exit.BackColor = System.Drawing.Color.Transparent
        Me.Guna_exit.BaseColor = System.Drawing.SystemColors.ControlLight
        Me.Guna_exit.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_exit.BorderSize = 2
        Me.Guna_exit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Guna_exit.FocusedColor = System.Drawing.Color.SteelBlue
        Me.Guna_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna_exit.ForeColor = System.Drawing.Color.DimGray
        Me.Guna_exit.Image = Global.BLINVOICE.My.Resources.Resources.close26
        Me.Guna_exit.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna_exit.Location = New System.Drawing.Point(395, 3)
        Me.Guna_exit.Name = "Guna_exit"
        Me.Guna_exit.OnHoverBaseColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_exit.OnHoverBorderColor = System.Drawing.Color.SteelBlue
        Me.Guna_exit.OnHoverForeColor = System.Drawing.Color.DarkSlateGray
        Me.Guna_exit.OnHoverImage = Nothing
        Me.Guna_exit.OnPressedColor = System.Drawing.Color.Black
        Me.Guna_exit.Radius = 2
        Me.Guna_exit.Size = New System.Drawing.Size(96, 32)
        Me.Guna_exit.TabIndex = 1479
        Me.Guna_exit.Text = "ปิดหน้าจอ"
        Me.Guna_exit.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'Guna_save
        '
        Me.Guna_save.AnimationHoverSpeed = 0.07!
        Me.Guna_save.AnimationSpeed = 0.03!
        Me.Guna_save.BackColor = System.Drawing.Color.Transparent
        Me.Guna_save.BaseColor = System.Drawing.SystemColors.ControlLight
        Me.Guna_save.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_save.BorderSize = 2
        Me.Guna_save.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Guna_save.FocusedColor = System.Drawing.Color.SteelBlue
        Me.Guna_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna_save.ForeColor = System.Drawing.Color.DimGray
        Me.Guna_save.Image = CType(resources.GetObject("Guna_save.Image"), System.Drawing.Image)
        Me.Guna_save.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna_save.Location = New System.Drawing.Point(101, 3)
        Me.Guna_save.Name = "Guna_save"
        Me.Guna_save.OnHoverBaseColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_save.OnHoverBorderColor = System.Drawing.Color.SteelBlue
        Me.Guna_save.OnHoverForeColor = System.Drawing.Color.DarkSlateGray
        Me.Guna_save.OnHoverImage = Nothing
        Me.Guna_save.OnPressedColor = System.Drawing.Color.Black
        Me.Guna_save.Radius = 2
        Me.Guna_save.Size = New System.Drawing.Size(94, 32)
        Me.Guna_save.TabIndex = 1476
        Me.Guna_save.Text = "บันทึก"
        Me.Guna_save.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'CUS_PROVINCETextBox
        '
        Me.CUS_PROVINCETextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_PROVINCETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_PROVINCE", True))
        Me.CUS_PROVINCETextBox.Location = New System.Drawing.Point(90, 199)
        Me.CUS_PROVINCETextBox.Name = "CUS_PROVINCETextBox"
        Me.CUS_PROVINCETextBox.Size = New System.Drawing.Size(145, 22)
        Me.CUS_PROVINCETextBox.TabIndex = 8
        '
        'GunaTextBox17
        '
        Me.GunaTextBox17.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox17.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox17.BorderSize = 1
        Me.GunaTextBox17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox17.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox17.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox17.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextBox17.Location = New System.Drawing.Point(80, 90)
        Me.GunaTextBox17.Name = "GunaTextBox17"
        Me.GunaTextBox17.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox17.Size = New System.Drawing.Size(120, 25)
        Me.GunaTextBox17.TabIndex = 1784
        '
        'GunaTextBox18
        '
        Me.GunaTextBox18.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox18.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox18.BorderSize = 1
        Me.GunaTextBox18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox18.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox18.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox18.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextBox18.Location = New System.Drawing.Point(80, 63)
        Me.GunaTextBox18.MaxLength = 10
        Me.GunaTextBox18.Name = "GunaTextBox18"
        Me.GunaTextBox18.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox18.Size = New System.Drawing.Size(120, 25)
        Me.GunaTextBox18.TabIndex = 1787
        '
        'GunaTextBox19
        '
        Me.GunaTextBox19.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox19.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox19.BorderSize = 1
        Me.GunaTextBox19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox19.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox19.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox19.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextBox19.Location = New System.Drawing.Point(80, 36)
        Me.GunaTextBox19.MaxLength = 30
        Me.GunaTextBox19.Name = "GunaTextBox19"
        Me.GunaTextBox19.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox19.Size = New System.Drawing.Size(120, 25)
        Me.GunaTextBox19.TabIndex = 1786
        '
        'GunaTextBox20
        '
        Me.GunaTextBox20.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox20.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox20.BorderSize = 1
        Me.GunaTextBox20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox20.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox20.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox20.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextBox20.Location = New System.Drawing.Point(273, 90)
        Me.GunaTextBox20.Name = "GunaTextBox20"
        Me.GunaTextBox20.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox20.Size = New System.Drawing.Size(190, 25)
        Me.GunaTextBox20.TabIndex = 1785
        '
        'GunaTextBox21
        '
        Me.GunaTextBox21.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox21.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox21.BorderSize = 1
        Me.GunaTextBox21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox21.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox21.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox21.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextBox21.Location = New System.Drawing.Point(273, 63)
        Me.GunaTextBox21.Name = "GunaTextBox21"
        Me.GunaTextBox21.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox21.Size = New System.Drawing.Size(190, 25)
        Me.GunaTextBox21.TabIndex = 1788
        '
        'GunaTextBox22
        '
        Me.GunaTextBox22.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox22.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox22.BorderSize = 1
        Me.GunaTextBox22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox22.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox22.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox22.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextBox22.Location = New System.Drawing.Point(273, 36)
        Me.GunaTextBox22.Name = "GunaTextBox22"
        Me.GunaTextBox22.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox22.Size = New System.Drawing.Size(190, 25)
        Me.GunaTextBox22.TabIndex = 1791
        '
        'GunaTextBox23
        '
        Me.GunaTextBox23.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox23.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox23.BorderSize = 1
        Me.GunaTextBox23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox23.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox23.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox23.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextBox23.Location = New System.Drawing.Point(273, 9)
        Me.GunaTextBox23.Name = "GunaTextBox23"
        Me.GunaTextBox23.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox23.Size = New System.Drawing.Size(190, 25)
        Me.GunaTextBox23.TabIndex = 1790
        '
        'GunaTextBox24
        '
        Me.GunaTextBox24.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox24.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox24.BorderSize = 1
        Me.GunaTextBox24.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox24.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox24.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox24.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextBox24.Location = New System.Drawing.Point(80, 9)
        Me.GunaTextBox24.MaxLength = 30
        Me.GunaTextBox24.Name = "GunaTextBox24"
        Me.GunaTextBox24.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox24.Size = New System.Drawing.Size(120, 25)
        Me.GunaTextBox24.TabIndex = 1789
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(11, 14)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(68, 16)
        Me.Label41.TabIndex = 1779
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(209, 94)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(63, 16)
        Me.Label42.TabIndex = 1781
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(210, 68)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(46, 16)
        Me.Label43.TabIndex = 1782
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(211, 40)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(35, 16)
        Me.Label44.TabIndex = 1783
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(212, 14)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(33, 16)
        Me.Label45.TabIndex = 1780
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(11, 94)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(66, 16)
        Me.Label46.TabIndex = 1777
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(12, 67)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(66, 16)
        Me.Label47.TabIndex = 1776
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(11, 40)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(67, 16)
        Me.Label48.TabIndex = 1778
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ADDRESSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CODE_RUNNINGTableAdapter = Nothing
        Me.TableAdapterManager.COMPANYTableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMER_TYPETableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMERTableAdapter = Me.CUSTOMERTableAdapter
        Me.TableAdapterManager.DOCTYPETableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTS_TYPETableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTSTableAdapter = Nothing
        Me.TableAdapterManager.PROVINCETableAdapter = Nothing
        Me.TableAdapterManager.SALESMANTableAdapter = Nothing
        Me.TableAdapterManager.TRANDETAILTableAdapter = Nothing
        Me.TableAdapterManager.TRANMAINTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BLINVOICE.INVOICEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CUS_CODETextBox
        '
        Me.CUS_CODETextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_CODE", True))
        Me.CUS_CODETextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_CODETextBox.Location = New System.Drawing.Point(90, 53)
        Me.CUS_CODETextBox.MaxLength = 20
        Me.CUS_CODETextBox.Name = "CUS_CODETextBox"
        Me.CUS_CODETextBox.Size = New System.Drawing.Size(146, 22)
        Me.CUS_CODETextBox.TabIndex = 1
        '
        'CUS_NAMETextBox
        '
        Me.CUS_NAMETextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_NAME", True))
        Me.CUS_NAMETextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_NAMETextBox.Location = New System.Drawing.Point(90, 82)
        Me.CUS_NAMETextBox.Name = "CUS_NAMETextBox"
        Me.CUS_NAMETextBox.Size = New System.Drawing.Size(501, 22)
        Me.CUS_NAMETextBox.TabIndex = 3
        '
        'CUS_BRANCHTextBox
        '
        Me.CUS_BRANCHTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_BRANCHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_BRANCH", True))
        Me.CUS_BRANCHTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_BRANCHTextBox.Location = New System.Drawing.Point(90, 110)
        Me.CUS_BRANCHTextBox.Name = "CUS_BRANCHTextBox"
        Me.CUS_BRANCHTextBox.Size = New System.Drawing.Size(145, 22)
        Me.CUS_BRANCHTextBox.TabIndex = 4
        '
        'CUS_TAXIDTextBox
        '
        Me.CUS_TAXIDTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_TAXIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_TAXID", True))
        Me.CUS_TAXIDTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_TAXIDTextBox.Location = New System.Drawing.Point(400, 110)
        Me.CUS_TAXIDTextBox.MaxLength = 13
        Me.CUS_TAXIDTextBox.Name = "CUS_TAXIDTextBox"
        Me.CUS_TAXIDTextBox.Size = New System.Drawing.Size(191, 22)
        Me.CUS_TAXIDTextBox.TabIndex = 5
        '
        'CUS_ADDB1TextBox
        '
        Me.CUS_ADDB1TextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_ADDB1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_ADDB1", True))
        Me.CUS_ADDB1TextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_ADDB1TextBox.Location = New System.Drawing.Point(90, 139)
        Me.CUS_ADDB1TextBox.Name = "CUS_ADDB1TextBox"
        Me.CUS_ADDB1TextBox.Size = New System.Drawing.Size(501, 22)
        Me.CUS_ADDB1TextBox.TabIndex = 6
        '
        'CUS_ADDB2TextBox
        '
        Me.CUS_ADDB2TextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_ADDB2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_ADDB2", True))
        Me.CUS_ADDB2TextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_ADDB2TextBox.Location = New System.Drawing.Point(90, 169)
        Me.CUS_ADDB2TextBox.Name = "CUS_ADDB2TextBox"
        Me.CUS_ADDB2TextBox.Size = New System.Drawing.Size(501, 22)
        Me.CUS_ADDB2TextBox.TabIndex = 7
        '
        'CUS_POSTTextBox
        '
        Me.CUS_POSTTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_POSTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_POST", True))
        Me.CUS_POSTTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CUS_POSTTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_POSTTextBox.Location = New System.Drawing.Point(400, 198)
        Me.CUS_POSTTextBox.MaxLength = 5
        Me.CUS_POSTTextBox.Name = "CUS_POSTTextBox"
        Me.CUS_POSTTextBox.Size = New System.Drawing.Size(191, 22)
        Me.CUS_POSTTextBox.TabIndex = 9
        '
        'CUS_TELTextBox
        '
        Me.CUS_TELTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_TELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_TEL", True))
        Me.CUS_TELTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_TELTextBox.Location = New System.Drawing.Point(90, 227)
        Me.CUS_TELTextBox.Name = "CUS_TELTextBox"
        Me.CUS_TELTextBox.Size = New System.Drawing.Size(501, 22)
        Me.CUS_TELTextBox.TabIndex = 10
        '
        'CUS_FAXTextBox
        '
        Me.CUS_FAXTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_FAXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_FAX", True))
        Me.CUS_FAXTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_FAXTextBox.Location = New System.Drawing.Point(90, 255)
        Me.CUS_FAXTextBox.Name = "CUS_FAXTextBox"
        Me.CUS_FAXTextBox.Size = New System.Drawing.Size(501, 22)
        Me.CUS_FAXTextBox.TabIndex = 11
        '
        'CUS_MAILTextBox
        '
        Me.CUS_MAILTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_MAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_MAIL", True))
        Me.CUS_MAILTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_MAILTextBox.Location = New System.Drawing.Point(90, 283)
        Me.CUS_MAILTextBox.Name = "CUS_MAILTextBox"
        Me.CUS_MAILTextBox.Size = New System.Drawing.Size(209, 22)
        Me.CUS_MAILTextBox.TabIndex = 12
        '
        'CUS_WEBTextBox
        '
        Me.CUS_WEBTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_WEBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_WEB", True))
        Me.CUS_WEBTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_WEBTextBox.Location = New System.Drawing.Point(400, 283)
        Me.CUS_WEBTextBox.Name = "CUS_WEBTextBox"
        Me.CUS_WEBTextBox.Size = New System.Drawing.Size(191, 22)
        Me.CUS_WEBTextBox.TabIndex = 13
        '
        'CUS_CONTACTTextBox
        '
        Me.CUS_CONTACTTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_CONTACTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_CONTACT", True))
        Me.CUS_CONTACTTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_CONTACTTextBox.Location = New System.Drawing.Point(400, 312)
        Me.CUS_CONTACTTextBox.Name = "CUS_CONTACTTextBox"
        Me.CUS_CONTACTTextBox.Size = New System.Drawing.Size(191, 22)
        Me.CUS_CONTACTTextBox.TabIndex = 15
        '
        'CUS_CREDIT_TERMTextBox
        '
        Me.CUS_CREDIT_TERMTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_CREDIT_TERMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_CREDIT_TERM", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.CUS_CREDIT_TERMTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_CREDIT_TERMTextBox.Location = New System.Drawing.Point(229, 340)
        Me.CUS_CREDIT_TERMTextBox.MaxLength = 3
        Me.CUS_CREDIT_TERMTextBox.Name = "CUS_CREDIT_TERMTextBox"
        Me.CUS_CREDIT_TERMTextBox.Size = New System.Drawing.Size(70, 22)
        Me.CUS_CREDIT_TERMTextBox.TabIndex = 17
        Me.CUS_CREDIT_TERMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CUS_CREDIT_LIMITTextBox
        '
        Me.CUS_CREDIT_LIMITTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_CREDIT_LIMITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_CREDIT_LIMIT", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.CUS_CREDIT_LIMITTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_CREDIT_LIMITTextBox.Location = New System.Drawing.Point(400, 340)
        Me.CUS_CREDIT_LIMITTextBox.Name = "CUS_CREDIT_LIMITTextBox"
        Me.CUS_CREDIT_LIMITTextBox.Size = New System.Drawing.Size(191, 22)
        Me.CUS_CREDIT_LIMITTextBox.TabIndex = 18
        Me.CUS_CREDIT_LIMITTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CUS_DISC_PERCENTextBox
        '
        Me.CUS_DISC_PERCENTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_DISC_PERCENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_DISC_PERCEN", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.CUS_DISC_PERCENTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_DISC_PERCENTextBox.Location = New System.Drawing.Point(90, 340)
        Me.CUS_DISC_PERCENTextBox.Name = "CUS_DISC_PERCENTextBox"
        Me.CUS_DISC_PERCENTextBox.Size = New System.Drawing.Size(70, 22)
        Me.CUS_DISC_PERCENTextBox.TabIndex = 16
        Me.CUS_DISC_PERCENTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CUS_REMARKTextBox
        '
        Me.CUS_REMARKTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUS_REMARKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUS_REMARK", True))
        Me.CUS_REMARKTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CUS_REMARKTextBox.Location = New System.Drawing.Point(90, 399)
        Me.CUS_REMARKTextBox.Multiline = True
        Me.CUS_REMARKTextBox.Name = "CUS_REMARKTextBox"
        Me.CUS_REMARKTextBox.Size = New System.Drawing.Size(501, 63)
        Me.CUS_REMARKTextBox.TabIndex = 21
        '
        'SurenameLabel
        '
        Me.SurenameLabel.AutoSize = True
        Me.SurenameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SurenameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SurenameLabel.Location = New System.Drawing.Point(26, 56)
        Me.SurenameLabel.Name = "SurenameLabel"
        Me.SurenameLabel.Size = New System.Drawing.Size(53, 16)
        Me.SurenameLabel.TabIndex = 1930
        Me.SurenameLabel.Text = "รหัสลูกค้า"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(353, 285)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 16)
        Me.Label11.TabIndex = 1936
        Me.Label11.Text = "เว็บไซด์"
        '
        'MailLabel
        '
        Me.MailLabel.AutoSize = True
        Me.MailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MailLabel.Location = New System.Drawing.Point(26, 285)
        Me.MailLabel.Name = "MailLabel"
        Me.MailLabel.Size = New System.Drawing.Size(30, 16)
        Me.MailLabel.TabIndex = 1934
        Me.MailLabel.Text = "อีเมล์"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(26, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 16)
        Me.Label12.TabIndex = 1935
        Me.Label12.Text = "สาขา"
        '
        'FaxLabel
        '
        Me.FaxLabel.AutoSize = True
        Me.FaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FaxLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FaxLabel.Location = New System.Drawing.Point(26, 257)
        Me.FaxLabel.Name = "FaxLabel"
        Me.FaxLabel.Size = New System.Drawing.Size(35, 16)
        Me.FaxLabel.TabIndex = 1929
        Me.FaxLabel.Text = "แฟกซ์"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PhoneLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PhoneLabel.Location = New System.Drawing.Point(26, 229)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(50, 16)
        Me.PhoneLabel.TabIndex = 1933
        Me.PhoneLabel.Text = "โทรศัพท์"
        '
        'CustnameLabel
        '
        Me.CustnameLabel.AutoSize = True
        Me.CustnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CustnameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustnameLabel.Location = New System.Drawing.Point(26, 84)
        Me.CustnameLabel.Name = "CustnameLabel"
        Me.CustnameLabel.Size = New System.Drawing.Size(45, 16)
        Me.CustnameLabel.TabIndex = 1931
        Me.CustnameLabel.Text = "ชื่อลูกค้า"
        '
        'ADDR1Label
        '
        Me.ADDR1Label.AutoSize = True
        Me.ADDR1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ADDR1Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ADDR1Label.Location = New System.Drawing.Point(26, 142)
        Me.ADDR1Label.Name = "ADDR1Label"
        Me.ADDR1Label.Size = New System.Drawing.Size(28, 16)
        Me.ADDR1Label.TabIndex = 1928
        Me.ADDR1Label.Text = "ที่อยู่"
        '
        'ZIPLabel
        '
        Me.ZIPLabel.AutoSize = True
        Me.ZIPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ZIPLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ZIPLabel.Location = New System.Drawing.Point(348, 201)
        Me.ZIPLabel.Name = "ZIPLabel"
        Me.ZIPLabel.Size = New System.Drawing.Size(48, 16)
        Me.ZIPLabel.TabIndex = 1942
        Me.ZIPLabel.Text = "ไปรษณีย์"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(26, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 1941
        Me.Label6.Text = "จังหวัด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(330, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 1944
        Me.Label7.Text = "เลขผู้เสียภาษี"
        '
        'TAX_VATIO
        '
        Me.TAX_VATIO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TAX_VATIO.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TAX_VATIO.DropDownHeight = 300
        Me.TAX_VATIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TAX_VATIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TAX_VATIO.FormattingEnabled = True
        Me.TAX_VATIO.IntegralHeight = False
        Me.TAX_VATIO.Items.AddRange(New Object() {"ยังไม่รวมภาษี", "รวมภาษีแล้ว"})
        Me.TAX_VATIO.Location = New System.Drawing.Point(400, 368)
        Me.TAX_VATIO.Name = "TAX_VATIO"
        Me.TAX_VATIO.Size = New System.Drawing.Size(191, 24)
        Me.TAX_VATIO.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(339, 371)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 1957
        Me.Label10.Text = "วิธีคิดราคา"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(162, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 16)
        Me.Label9.TabIndex = 1956
        Me.Label9.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 1955
        Me.Label2.Text = "ส่วนลด"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 1954
        Me.Label1.Text = "วิธีคิดภาษี"
        '
        'TAX_CMB
        '
        Me.TAX_CMB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TAX_CMB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TAX_CMB.DropDownHeight = 300
        Me.TAX_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TAX_CMB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TAX_CMB.FormattingEnabled = True
        Me.TAX_CMB.IntegralHeight = False
        Me.TAX_CMB.Items.AddRange(New Object() {"อัตราทั่วไป", "ยกเว้นภาษี", "ไม่มีภาษี"})
        Me.TAX_CMB.Location = New System.Drawing.Point(90, 368)
        Me.TAX_CMB.Name = "TAX_CMB"
        Me.TAX_CMB.Size = New System.Drawing.Size(209, 24)
        Me.TAX_CMB.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(359, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 1952
        Me.Label8.Text = "วงเงิน"
        '
        'SALES_CMB
        '
        Me.SALES_CMB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SALES_CMB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SALES_CMB.DropDownHeight = 300
        Me.SALES_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SALES_CMB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SALES_CMB.FormattingEnabled = True
        Me.SALES_CMB.IntegralHeight = False
        Me.SALES_CMB.Location = New System.Drawing.Point(90, 310)
        Me.SALES_CMB.Name = "SALES_CMB"
        Me.SALES_CMB.Size = New System.Drawing.Size(209, 24)
        Me.SALES_CMB.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(189, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 1951
        Me.Label3.Text = "เครดิต"
        '
        'RemarkLabel
        '
        Me.RemarkLabel.AutoSize = True
        Me.RemarkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RemarkLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RemarkLabel.Location = New System.Drawing.Point(26, 399)
        Me.RemarkLabel.Name = "RemarkLabel"
        Me.RemarkLabel.Size = New System.Drawing.Size(52, 16)
        Me.RemarkLabel.TabIndex = 1950
        Me.RemarkLabel.Text = "หมายเหตุ"
        '
        'SLMCODLabel
        '
        Me.SLMCODLabel.AutoSize = True
        Me.SLMCODLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SLMCODLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SLMCODLabel.Location = New System.Drawing.Point(26, 314)
        Me.SLMCODLabel.Name = "SLMCODLabel"
        Me.SLMCODLabel.Size = New System.Drawing.Size(50, 16)
        Me.SLMCODLabel.TabIndex = 1945
        Me.SLMCODLabel.Text = "พนง.ขาย"
        '
        'CONTACTLabel
        '
        Me.CONTACTLabel.AutoSize = True
        Me.CONTACTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CONTACTLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CONTACTLabel.Location = New System.Drawing.Point(354, 314)
        Me.CONTACTLabel.Name = "CONTACTLabel"
        Me.CONTACTLabel.Size = New System.Drawing.Size(42, 16)
        Me.CONTACTLabel.TabIndex = 1949
        Me.CONTACTLabel.Text = "ผู้ติดต่อ"
        '
        'GunaControlBox6
        '
        Me.GunaControlBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox6.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox6.AnimationSpeed = 0.03!
        Me.GunaControlBox6.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox6.IconSize = 15.0!
        Me.GunaControlBox6.Location = New System.Drawing.Point(1135, 0)
        Me.GunaControlBox6.Name = "GunaControlBox6"
        Me.GunaControlBox6.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox6.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox6.Size = New System.Drawing.Size(30, 28)
        Me.GunaControlBox6.TabIndex = 1960
        Me.GunaControlBox6.TabStop = False
        '
        'GunaControlBox5
        '
        Me.GunaControlBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox5.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox5.AnimationSpeed = 0.03!
        Me.GunaControlBox5.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox5.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox5.IconSize = 15.0!
        Me.GunaControlBox5.Location = New System.Drawing.Point(1102, 0)
        Me.GunaControlBox5.Name = "GunaControlBox5"
        Me.GunaControlBox5.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox5.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox5.Size = New System.Drawing.Size(30, 28)
        Me.GunaControlBox5.TabIndex = 1961
        Me.GunaControlBox5.TabStop = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel2.Location = New System.Drawing.Point(40, 6)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(72, 18)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "บันทึกลูกค้า"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.Silver
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaPictureBox3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaControlBox6)
        Me.GunaGroupBox1.Controls.Add(Me.GunaControlBox5)
        Me.GunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.DarkGray
        Me.GunaGroupBox1.LineTop = 0
        Me.GunaGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(1164, 28)
        Me.GunaGroupBox1.TabIndex = 1966
        Me.GunaGroupBox1.TabStop = False
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaPictureBox3
        '
        Me.GunaPictureBox3.BaseColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox3.Image = Global.BLINVOICE.My.Resources.Resources.Customer4233
        Me.GunaPictureBox3.Location = New System.Drawing.Point(5, 2)
        Me.GunaPictureBox3.Name = "GunaPictureBox3"
        Me.GunaPictureBox3.Size = New System.Drawing.Size(30, 26)
        Me.GunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox3.TabIndex = 2
        Me.GunaPictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(301, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 16)
        Me.Label4.TabIndex = 1967
        Me.Label4.Text = "วัน"
        '
        'province_lnk
        '
        Me.province_lnk.BaseColor = System.Drawing.Color.White
        Me.province_lnk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.province_lnk.Image = Global.BLINVOICE.My.Resources.Resources.Search38
        Me.province_lnk.Location = New System.Drawing.Point(238, 200)
        Me.province_lnk.Name = "province_lnk"
        Me.province_lnk.Size = New System.Drawing.Size(24, 24)
        Me.province_lnk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.province_lnk.TabIndex = 1969
        Me.province_lnk.TabStop = False
        '
        'customer_record_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton = Me.return_lnk
        Me.ClientSize = New System.Drawing.Size(1164, 932)
        Me.Controls.Add(Me.province_lnk)
        Me.Controls.Add(Me.CUS_PROVINCETextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SurenameLabel)
        Me.Controls.Add(Me.ADDR1Label)
        Me.Controls.Add(Me.SLMCODLabel)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.CUS_CONTACTTextBox)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.CUS_REMARKTextBox)
        Me.Controls.Add(Me.ZIPLabel)
        Me.Controls.Add(Me.CUS_POSTTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CUS_TAXIDTextBox)
        Me.Controls.Add(Me.FaxLabel)
        Me.Controls.Add(Me.MailLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CUS_DISC_PERCENTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CUS_FAXTextBox)
        Me.Controls.Add(Me.CUS_BRANCHTextBox)
        Me.Controls.Add(Me.CUS_NAMETextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CUS_ADDB2TextBox)
        Me.Controls.Add(Me.RemarkLabel)
        Me.Controls.Add(Me.CUS_MAILTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.SALES_CMB)
        Me.Controls.Add(Me.CUS_CREDIT_LIMITTextBox)
        Me.Controls.Add(Me.TAX_VATIO)
        Me.Controls.Add(Me.CUS_CREDIT_TERMTextBox)
        Me.Controls.Add(Me.CUS_TELTextBox)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.TAX_CMB)
        Me.Controls.Add(Me.CustnameLabel)
        Me.Controls.Add(Me.CUS_ADDB1TextBox)
        Me.Controls.Add(Me.CONTACTLabel)
        Me.Controls.Add(Me.CUS_CODETextBox)
        Me.Controls.Add(Me.CUS_WEBTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "customer_record_new"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "บันทึกลูกค้า"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.Pn_not_show.ResumeLayout(False)
        Me.Pn_not_show.PerformLayout()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVOICEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.province_lnk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pn_not_show As System.Windows.Forms.Panel
    Friend WithEvents insert_status As System.Windows.Forms.TextBox
    Friend WithEvents return_lnk As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Guna_add As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna_exit As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna_save As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna_delete As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna_print As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents bottom_line As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaTextBox17 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox18 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox19 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox20 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox21 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox22 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox23 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox24 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents INVOICEDataSet As BLINVOICE.INVOICEDataSet
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As BLINVOICE.INVOICEDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents TableAdapterManager As BLINVOICE.INVOICEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CUS_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_CODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_BRANCHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_TAXIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_ADDB1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_ADDB2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_PROVINCETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_POSTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_TELTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_FAXTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_MAILTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_WEBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_CATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_SLMNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_CONTACTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_CREDIT_TERMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_CREDIT_LIMITTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_DISC_PERCENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_TAX_TYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_TAX_VATIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_REMARKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUS_STATUSCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CUS_CREATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SurenameLabel As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MailLabel As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents FaxLabel As System.Windows.Forms.Label
    Friend WithEvents PhoneLabel As System.Windows.Forms.Label
    Friend WithEvents CustnameLabel As System.Windows.Forms.Label
    Friend WithEvents ADDR1Label As System.Windows.Forms.Label
    Friend WithEvents province_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents ZIPLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TAX_VATIO As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TAX_CMB As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SALES_CMB As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RemarkLabel As System.Windows.Forms.Label
    Friend WithEvents SLMCODLabel As System.Windows.Forms.Label
    Friend WithEvents CONTACTLabel As System.Windows.Forms.Label
    Friend WithEvents GunaControlBox6 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox5 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents province_lnk As Guna.UI.WinForms.GunaPictureBox
End Class
