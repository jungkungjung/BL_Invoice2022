Imports Microsoft.Office.Interop

Module Module_exportExcel
    Private Sub export_excel(ByVal grw As DataGridView)
        Dim xlApp As New Excel.Application
        Dim xlWorkBook2 As Excel.Workbook '= New Excel.Workbook
        xlWorkBook2 = Nothing
        Dim misValue As Object = System.Reflection.Missing.Value

        If grw Is Nothing OrElse grw.RowCount <= 0 Then
            MsgBox("I think the the Datatable is empty!!!")
            Exit Sub
        End If
        Try
            xlWorkBook2 = xlApp.Workbooks.Add(misValue)
            xlApp.Visible = True
            Dim xlWorkSheet = xlWorkBook2.ActiveSheet
            'Data transfer from grid to Excel. 
            'With xlWorkSheet
            '.Range("A1", misValue).EntireRow.Font.Bold = True

            Dim formatRange As Excel.Range
            formatRange = xlWorkSheet.Range("A:A", "L:L")
            formatRange.NumberFormat = "@"

            'Set Clipboard Copy Mode
            grw.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            grw.SelectAll()

            'Get the content from Grid for Clipboard
            Dim str As String = TryCast(grw.GetClipboardContent().GetData(DataFormats.UnicodeText), String)

            'Set the content to Clipboard
            Clipboard.SetText(str, TextDataFormat.UnicodeText)

            'Identifiy and select the range of cells in excel to paste the clipboard data.
            '.Range("A1:" & ConvertToLetter(grw.ColumnCount) & grw.RowCount, misValue).Select()

            'Paste the clipboard data
            xlWorkSheet.Paste()
            'xlApp.Columns.AutoFit()
            xlWorkSheet.Columns.AutoFit()
            grw.ClearSelection()
            Clipboard.Clear()

            'End With
            releaseObject(xlWorkSheet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            releaseObject(xlWorkBook2)
            releaseObject(xlApp)
        End Try
    End Sub

End Module
