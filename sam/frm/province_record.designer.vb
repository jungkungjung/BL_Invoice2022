<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class province_record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(province_record))
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaSeparator3 = New Guna.UI.WinForms.GunaSeparator()
        Me.Pn_not_show = New System.Windows.Forms.Panel()
        Me.insert_status = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna_delete = New Guna.UI.WinForms.GunaButton()
        Me.Guna_save = New Guna.UI.WinForms.GunaButton()
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
        Me.Label19 = New System.Windows.Forms.Label()
        Me.INVOICEDataSet = New BLINVOICE.INVOICEDataSet()
        Me.PROVINCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROVINCETableAdapter = New BLINVOICE.INVOICEDataSetTableAdapters.PROVINCETableAdapter()
        Me.TableAdapterManager = New BLINVOICE.INVOICEDataSetTableAdapters.TableAdapterManager()
        Me.PROVINCE_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PROVINCE_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.Pn_not_show.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.INVOICEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVINCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.LightGray
        Me.GunaElipsePanel1.Controls.Add(Me.GunaSeparator3)
        Me.GunaElipsePanel1.Controls.Add(Me.Pn_not_show)
        Me.GunaElipsePanel1.Controls.Add(Me.Panel3)
        Me.GunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(0, 97)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 1
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(335, 46)
        Me.GunaElipsePanel1.TabIndex = 1538
        '
        'GunaSeparator3
        '
        Me.GunaSeparator3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator3.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator3.Location = New System.Drawing.Point(0, -9)
        Me.GunaSeparator3.Name = "GunaSeparator3"
        Me.GunaSeparator3.Size = New System.Drawing.Size(344, 10)
        Me.GunaSeparator3.TabIndex = 1556
        '
        'Pn_not_show
        '
        Me.Pn_not_show.BackColor = System.Drawing.Color.Transparent
        Me.Pn_not_show.Controls.Add(Me.PROVINCE_IDTextBox)
        Me.Pn_not_show.Controls.Add(Me.insert_status)
        Me.Pn_not_show.Location = New System.Drawing.Point(246, 7)
        Me.Pn_not_show.Name = "Pn_not_show"
        Me.Pn_not_show.Size = New System.Drawing.Size(65, 32)
        Me.Pn_not_show.TabIndex = 852
        '
        'insert_status
        '
        Me.insert_status.BackColor = System.Drawing.Color.WhiteSmoke
        Me.insert_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.insert_status.Location = New System.Drawing.Point(3, 3)
        Me.insert_status.Name = "insert_status"
        Me.insert_status.Size = New System.Drawing.Size(22, 20)
        Me.insert_status.TabIndex = 488
        Me.insert_status.TabStop = False
        Me.insert_status.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.CausesValidation = False
        Me.Panel3.Controls.Add(Me.Guna_delete)
        Me.Panel3.Controls.Add(Me.Guna_save)
        Me.Panel3.Location = New System.Drawing.Point(12, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(228, 39)
        Me.Panel3.TabIndex = 1481
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
        Me.Guna_delete.FocusedColor = System.Drawing.Color.Empty
        Me.Guna_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna_delete.ForeColor = System.Drawing.Color.DimGray
        Me.Guna_delete.Image = Global.BLINVOICE.My.Resources.Resources.delete301
        Me.Guna_delete.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna_delete.Location = New System.Drawing.Point(101, 3)
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
        'Guna_save
        '
        Me.Guna_save.AnimationHoverSpeed = 0.07!
        Me.Guna_save.AnimationSpeed = 0.03!
        Me.Guna_save.BackColor = System.Drawing.Color.Transparent
        Me.Guna_save.BaseColor = System.Drawing.SystemColors.ControlLight
        Me.Guna_save.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Guna_save.BorderSize = 2
        Me.Guna_save.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Guna_save.FocusedColor = System.Drawing.Color.Empty
        Me.Guna_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna_save.ForeColor = System.Drawing.Color.DimGray
        Me.Guna_save.Image = CType(resources.GetObject("Guna_save.Image"), System.Drawing.Image)
        Me.Guna_save.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna_save.Location = New System.Drawing.Point(3, 3)
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(32, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 18)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "ชื่อ"
        '
        'INVOICEDataSet
        '
        Me.INVOICEDataSet.DataSetName = "INVOICEDataSet"
        Me.INVOICEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROVINCEBindingSource
        '
        Me.PROVINCEBindingSource.DataMember = "PROVINCE"
        Me.PROVINCEBindingSource.DataSource = Me.INVOICEDataSet
        '
        'PROVINCETableAdapter
        '
        Me.PROVINCETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ADDRESSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CODE_RUNNINGTableAdapter = Nothing
        Me.TableAdapterManager.COMPANYTableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMER_TYPETableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.DOCTYPETableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTS_TYPETableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTSTableAdapter = Nothing
        Me.TableAdapterManager.PROVINCETableAdapter = Me.PROVINCETableAdapter
        Me.TableAdapterManager.SALESMANTableAdapter = Nothing
        Me.TableAdapterManager.TRANDETAILTableAdapter = Nothing
        Me.TableAdapterManager.TRANMAINTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BLINVOICE.INVOICEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PROVINCE_IDTextBox
        '
        Me.PROVINCE_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVINCEBindingSource, "PROVINCE_ID", True))
        Me.PROVINCE_IDTextBox.Location = New System.Drawing.Point(31, 3)
        Me.PROVINCE_IDTextBox.Name = "PROVINCE_IDTextBox"
        Me.PROVINCE_IDTextBox.Size = New System.Drawing.Size(26, 22)
        Me.PROVINCE_IDTextBox.TabIndex = 1968
        Me.PROVINCE_IDTextBox.TabStop = False
        '
        'PROVINCE_NAMETextBox
        '
        Me.PROVINCE_NAMETextBox.BackColor = System.Drawing.Color.AliceBlue
        Me.PROVINCE_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVINCEBindingSource, "PROVINCE_NAME", True))
        Me.PROVINCE_NAMETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PROVINCE_NAMETextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.PROVINCE_NAMETextBox.Location = New System.Drawing.Point(61, 32)
        Me.PROVINCE_NAMETextBox.Name = "PROVINCE_NAMETextBox"
        Me.PROVINCE_NAMETextBox.Size = New System.Drawing.Size(210, 24)
        Me.PROVINCE_NAMETextBox.TabIndex = 1970
        '
        'province_record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(335, 143)
        Me.Controls.Add(Me.PROVINCE_NAMETextBox)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.Label19)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "province_record"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "บันทึกจังหวัด"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.Pn_not_show.ResumeLayout(False)
        Me.Pn_not_show.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.INVOICEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVINCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pn_not_show As System.Windows.Forms.Panel
    Friend WithEvents insert_status As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Guna_save As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna_delete As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaSeparator3 As Guna.UI.WinForms.GunaSeparator
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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents INVOICEDataSet As BLINVOICE.INVOICEDataSet
    Friend WithEvents PROVINCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROVINCETableAdapter As BLINVOICE.INVOICEDataSetTableAdapters.PROVINCETableAdapter
    Friend WithEvents TableAdapterManager As BLINVOICE.INVOICEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PROVINCE_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PROVINCE_NAMETextBox As System.Windows.Forms.TextBox
End Class
