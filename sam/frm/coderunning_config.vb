Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Public Class coderunning_config
    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DOCTYPETableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน 'ต้องกำหนดค่า จาก mainmenu แทน
        'CODE_RUNNINGTableAdapter.Connection.ConnectionString = cnn_str ''กำหนด connection จาก ini แทน
        Try
            Me.DOCTYPETableAdapter.Fill(Me.INVOICEDataSet.DOCTYPE)
            Me.CODE_RUNNINGTableAdapter.Fill(Me.INVOICEDataSet.CODE_RUNNING)
            Pn_not_show.Hide()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub customer_record_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Try
            CODE_RUNNINGDataGridView.ClearSelection()
            DATE_TYPE_CMB.SelectedIndex = Integer.Parse(DT_DATE_TYPETextBox.Text)
            DATE_DIGIT_CMB.SelectedIndex = Integer.Parse(DT_DATE_DIGITTextBox.Text)
            PRINT_TY_CMB.SelectedIndex = Integer.Parse(DT_PRINT_TYTextBox.Text)
            If DT_DATE_SELECTCheckBox.Checked = True Then
                DATE_TYPE_CMB.Enabled = True
                DATE_DIGIT_CMB.Enabled = True
                DT_DATE_SEPARATETextBox.Enabled = True
            Else
                DATE_TYPE_CMB.Enabled = False
                DATE_DIGIT_CMB.Enabled = False
                DT_DATE_SEPARATETextBox.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub FrmCustomer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub DATE_TYPE_CMB_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles DATE_TYPE_CMB.SelectionChangeCommitted
        Try
            DT_DATE_TYPETextBox.Text = DATE_TYPE_CMB.SelectedIndex
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub DATE_DIGIT_CMB_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles DATE_DIGIT_CMB.SelectionChangeCommitted
        Try
            DT_DATE_DIGITTextBox.Text = DATE_DIGIT_CMB.SelectedIndex
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub PRINT_TY_CMB_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles PRINT_TY_CMB.SelectionChangeCommitted
        DT_PRINT_TYTextBox.Text = PRINT_TY_CMB.SelectedIndex
    End Sub
    Private Sub save1_Click(sender As System.Object, e As System.EventArgs) Handles Guna_save.Click
        Try
            Me.Validate()
            Me.CODE_RUNNINGBindingSource.EndEdit()
            Me.DOCTYPEBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
            insert_status.Text = "0"
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Result")
            Close()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
        'Try
        '    Me.Validate()
        '    Me.DOCTYPEBindingSource.EndEdit()
        '    Me.DOCTYPETableAdapter.Update(Me.INVOICEDataSet.DOCTYPE)
        '    MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.Information, "Result")
        'Catch ex As Exception
        '    MsgBox(Err.Description)
        'End Try
    End Sub

    Private Sub exit1_Click(sender As System.Object, e As System.EventArgs) Handles Guna_exit.Click
        Close()
    End Sub

    Private Sub DT_DATE_SELECTCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles DT_DATE_SELECTCheckBox.CheckedChanged
        Try
            If DT_DATE_SELECTCheckBox.Checked = True Then
                'date_grb.Enabled = True
                DATE_TYPE_CMB.Enabled = True
                DATE_DIGIT_CMB.Enabled = True
                DT_DATE_SEPARATETextBox.Enabled = True
            Else
                'date_grb.Enabled = False
                DATE_TYPE_CMB.Enabled = False
                DATE_DIGIT_CMB.Enabled = False
                DT_DATE_SEPARATETextBox.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub
    Private Sub CODE_RUNNINGBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.Validate()
            Me.CODE_RUNNINGBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.INVOICEDataSet)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Result")
        End Try
    End Sub

    Private Sub DT_RUNNINGTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DT_RUNNINGTextBox.KeyPress
        e.Handled = integer_input(e.KeyChar)
    End Sub
End Class