Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class planning_fn
    Friend constr As String = "Data Source=192.168.1.1;Initial Catalog=Account_numwattana01;User ID=sa;Password=1042"
    Friend conn As New SqlConnection(constr)
    Friend constr1 As String = "Data Source=192.168.2.5;Initial Catalog=Account_GMP;User ID=sa;Password=1042"
    Friend conn1 As New SqlConnection(constr1)
    Friend constr_ole2 As String = "Provider=SQLOLEDB; data source=192.168.1.12; Initial Catalog =nw;USER ID=sa; Password=sa123;Auto Translate=False"
    Friend conn_ole2 As New OleDbConnection(constr_ole2)
    Friend constr_29 As String = "Data Source=192.168.1.12;Initial Catalog=NW;User ID=sa;Password=sa123"
    Friend conn_29 As New SqlConnection(constr_29)

    Public Function EQToDataTable(ByVal parIList As System.Collections.IEnumerable) As System.Data.DataTable
        Dim ret As New System.Data.DataTable()
        Try
            Dim ppi As System.Reflection.PropertyInfo() = Nothing
            If parIList Is Nothing Then Return ret
            For Each itm In parIList
                If ppi Is Nothing Then
                    ppi = DirectCast(itm.[GetType](), System.Type).GetProperties()
                    For Each pi As System.Reflection.PropertyInfo In ppi
                        Dim colType As System.Type = pi.PropertyType
                        If (colType.IsGenericType) AndAlso
                           (colType.GetGenericTypeDefinition() Is GetType(System.Nullable(Of ))) Then colType = colType.GetGenericArguments()(0)
                        ret.Columns.Add(New System.Data.DataColumn(pi.Name, colType))
                    Next
                End If
                Dim dr As System.Data.DataRow = ret.NewRow
                For Each pi As System.Reflection.PropertyInfo In ppi
                    dr(pi.Name) = If(pi.GetValue(itm, Nothing) Is Nothing, DBNull.Value, pi.GetValue(itm, Nothing))
                Next
                ret.Rows.Add(dr)
            Next
            'For Each c As System.Data.DataColumn In ret.Columns
            '    c.ColumnName = c.ColumnName.Replace("_", " ")
            'Next
        Catch ex As Exception
            ret = New System.Data.DataTable()
        End Try
        Return ret
    End Function

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
