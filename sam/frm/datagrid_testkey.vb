Public Class datagrid_testkey

    Private Sub DataGridView1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        'MsgBox("key")
    End Sub

    'Private Sub DataGridView1_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing

    '    'If e.Control Is Nothing Then
    '    Dim tb As TextBox = CType(e.Control, TextBox)
    '    AddHandler tb.KeyDown, AddressOf TextBox_KeyDown
    '    AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
    '    'End If
    'End Sub
    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Space Then
        '    flag = True
        'End If
        'dtv_sku.RowFilter = "[GOODS_CODE] Like " & "'%" & TRANSTKDDataGridView.CurrentRow.Cells(4).Value.ToString & "%'"
        'grw_sku.Refresh()
        'Dim aa As String = ""
        'MsgBox(DataGridView1.CurrentRow.Cells(0).GetEditedFormattedValue)
        'MsgBox("adfa")
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'e.Handled = flag
        'flag = False
        'dtv_sku.RowFilter = "[GOODS_CODE] Like " & "'%" & TRANSTKDDataGridView.CurrentRow.Cells(4).Value.ToString & "%'"
        'grw_sku.Refresh()
        'MsgBox(DataGridView1.CurrentRow.Cells(0).Value)
        'TextBox1.Text += e.KeyChar
    End Sub

    Private Sub datagrid_testkey_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'AddHandler DataGridView1.EditingControlShowing, AddressOf DataGridView1_EditingControlShowing
        'Me.DataGridView1.RowCount = 1
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object,
ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)
        'Dim txtbox As TextBox = CType(e.Control, TextBox)
        'If Not (txtbox Is Nothing) Then
        '    AddHandler txtbox.KeyPress, AddressOf txtBox_KeyPress
        'End If
    End Sub

    Private Sub txtBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'MsgBox(e.KeyChar.ToString())
        'MsgBox(DataGridView1.Rows(0).Cells(0).Displayed)
        'TextBox1.Text = SendKeys(e.KeyChar)
        'MsgBox(DataGridView1.Rows(0).Cells(0).Selected.ToString())
    End Sub

    Private Sub DataGridView1_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        'MsgBox("currentchange")
    End Sub

    Private Sub DataGridView1_CellValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        'MsgBox("validating")
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        'MsgBox("value change")
    End Sub

    Private Sub DataGridView1_CellValueNeeded(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles DataGridView1.CellValueNeeded
        'MsgBox("valueneed")
    End Sub

    Private Sub DataGridView1_CellValuePushed(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles DataGridView1.CellValuePushed
        'MsgBox("pushed")
    End Sub

    Private Sub DataGridView1_ChangeUICues(sender As System.Object, e As System.Windows.Forms.UICuesEventArgs) Handles DataGridView1.ChangeUICues
        'MsgBox("uicues")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim key_1 As Double = 0.0
        For Each row3 As DataGridViewRow In DataGridView1.Rows 'ห่อโหล cast
            key_1 += 1
            'If row3.Cells("TRD_KEY").Value = 0 Then
            row3.Cells("COLUMN1").Value = key_1
        Next
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        DataGridView1.Rows.Add()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MAX_KEY()
        max_text.Text = DI_KEY
    End Sub

    Private Sub vat_bt_Click(sender As System.Object, e As System.EventArgs) Handles vat_bt.Click
        Dim a, b, c, b4_vat, vat_value, amt_value, v1, v2, v3 As Double
        a = Double.Parse(keyin.Text)
        b = Double.Parse(vat_ty.Text)
        c = Double.Parse(vat_rate.Text)
        If vat_ty.Text = 1 Then
            b4_vat = a
            vat_value = (a * c) / 100
            amt_value = a * ((100 + c) / 100)

            v1 = a
            v2 = (a * ((100 + c) / 100)) - a
            v3 = a * ((100 + c) / 100)

        Else : vat_ty.Text = 2
            b4_vat = a * (100 / (100 + c))
            vat_value = (b4_vat * c) / 100 '100 / (100 + c)
            amt_value = a 'a * ((100 + c) / 100)

            v1 = Math.Round(a * (100 / (100 + c)), 2)
            v2 = a - v1
            v3 = a
        End If
        ard_b_sv.Text = b4_vat 'Double.Parse(b4_vat)
        ard_b_vat.Text = vat_value 'Double.Parse(vat_value).ToString("N2")
        ard_b_amt.Text = amt_value 'Format(amt_value, "N2")

        var1.Text = v1 'Math.Round(v1, 2)
        var2.Text = v2 'v3 - v1 'Math.Round(v1, 2)
        var3.Text = v3
    End Sub

    Private Sub DataGridView1_EditingControlShowing_1(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        Dim tb As TextBox = CType(e.Control, TextBox)
        AddHandler tb.PreviewKeyDown, AddressOf TextBox_PreviewKeyDown

    End Sub

    Private Sub TextBox_PreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Enter Then 'Or e.KeyCode = Keys.Return Then
            'If e.KeyCode = Keys.Down Then
            MessageBox.Show("Success")    '''''WILL WORK
        End If
        If e.KeyCode = Keys.Space Then

            MessageBox.Show("Success")    '''''WORKS
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'var1.Text = cal_b4vat(Integer.Parse(vat_ty.Text), Double.Parse(vat_rate.Text), Double.Parse(keyin.Text))
        'var2.Text = cal_vat(Integer.Parse(vat_ty.Text), Double.Parse(vat_rate.Text), Double.Parse(keyin.Text))
        'var3.Text = cal_amt(Integer.Parse(vat_ty.Text), Double.Parse(vat_rate.Text), Double.Parse(keyin.Text))
    End Sub
End Class