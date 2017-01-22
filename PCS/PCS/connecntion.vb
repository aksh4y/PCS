Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class connecntion
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
           + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY)(PORT=1521))" _
           + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
           + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)
    Private Sub connecntion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Function write()
        
        Return Nothing
    End Function
End Class