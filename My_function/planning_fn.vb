Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class planning_fn
    Public Function conn_cnn()
        Dim constr As String = "Data Source=192.168.1.1;Initial Catalog=Account_numwattana01;User ID=sa;Password=1042"
        Dim conn As New SqlConnection(constr)
        Return conn
    End Function
    Public Function conn1_cnn()
        Dim constr1 As String = "Data Source=192.168.2.5;Initial Catalog=Account_GMP;User ID=sa;Password=1042"
        Dim conn1 As New SqlConnection(constr1)
        Return conn1
    End Function
    Public Function conn_ole2_cnn()
        Dim constr_ole2 As String = "Provider=SQLOLEDB; data source=192.168.1.12; Initial Catalog =nw;USER ID=sa; Password=sa123;Auto Translate=False"
        Dim conn_ole2 As New OleDbConnection(constr_ole2)
        Return conn_ole2
    End Function
    Public Function conn_29_cnn()
        Dim constr_29 As String = "Data Source=192.168.1.12;Initial Catalog=NW;User ID=sa;Password=sa123"
        Dim conn_29 As New SqlConnection(constr_29)
        Return conn_29
    End Function
    Public Function conn_production_cnn()
        Dim constr_production As String = "Data Source=192.168.1.12;Initial Catalog=PRODUCTION;User ID=sa;Password=sa123"
        Dim conn_production As New SqlConnection(constr_production)
        Return conn_production
    End Function
    Public Function EQLT(ByVal parIList As System.Collections.IEnumerable) As System.Data.DataTable
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
