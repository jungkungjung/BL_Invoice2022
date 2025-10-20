Imports System.Data
Imports System.Data.SqlClient

Partial Public Class INVOICEDataSet
End Class

Namespace INVOICEDataSetTableAdapters
    
    Partial Public Class COMPANYTableAdapter
        Private str As String
        Public Property my_str As String
            Get
                Return str
            End Get
            Set(value As String)
                str = value
            End Set
        End Property
    End Class
End Namespace
