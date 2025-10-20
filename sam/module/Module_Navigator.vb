Module Module_Navigator
    'Friend Function navigato_button(ByVal vat_ty As BindingSource, ByVal vat_rate As Double, ByVal g_amt As Double) As Double
    Friend Sub navigator_add(ByVal add_button As Button, ByVal save_button As Button, ByVal delete_button As Button, ByVal print_button As Button)
        add_button.Enabled = False
        save_button.Enabled = True
        delete_button.Enabled = False
        print_button.Enabled = False
    End Sub
    Friend Sub navigator_save(ByVal add_button As Button, ByVal save_button As Button, ByVal delete_button As Button, ByVal print_button As Button)
        add_button.Enabled = True
        save_button.Enabled = True
        delete_button.Enabled = True
        print_button.Enabled = True
    End Sub

    Friend Sub navigator_guna_add(ByVal add_button As Guna.UI.WinForms.GunaButton, ByVal save_button As Guna.UI.WinForms.GunaButton, ByVal delete_button As Guna.UI.WinForms.GunaButton, ByVal print_button As Guna.UI.WinForms.GunaButton)
        add_button.Enabled = False
        save_button.Enabled = True
        delete_button.Enabled = False
        print_button.Enabled = False
    End Sub
    Friend Sub navigator_gana_save(ByVal add_button As Guna.UI.WinForms.GunaButton, ByVal save_button As Guna.UI.WinForms.GunaButton, ByVal delete_button As Guna.UI.WinForms.GunaButton, ByVal print_button As Guna.UI.WinForms.GunaButton)
        add_button.Enabled = True
        save_button.Enabled = True
        delete_button.Enabled = True
        print_button.Enabled = True
    End Sub
End Module
