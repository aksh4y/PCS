Imports  System.Data
Imports Oracle.DataAccess.Client

Imports System.Data.SqlClient
Public Class Db
    Inherits System.Windows.Forms.Form

    Private Sub Db_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oradb As String = "Data Source=OraDb;User Id=scott;Password=tiger;" ' VB.NET
        'Dim oradb As String = "Data Source=(DESCRIPTION=" _
        '   + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=OTNSRVR)(PORT=1521)))" _
        '   + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));" _
        '   + "User Id=scott;Password=tiger;"
        Dim conn As New OracleConnection() ' VB.NET
        conn.ConnectionString = oradb
        Dim sql As String = "select ename from emp where sal= 1300" ' VB.NET
        'Dim cmd As New OracleCommand(sql, conn)
        'cmd.CommandType = CommandType.Text
        'Dim dr As OracleDataReader = cmd.ExecuteReader() ' Visual Basic
        'dr.Read()

        'Label1.Text = dr.Item("ename") ' retrieve by column name
        'Label1.Text = dr.Item(0) ' retrieve the first column in the select list
        'Label1.Text = dr.GetString(0) ' return a .NET data type
        'Label1.Text = dr.GetOracleString(0) ' return an Oracle data type

        ' Visual Basic

        Try
            conn.Open()

            Dim cmd As New OracleCommand
            cmd.Connection = conn
            cmd.CommandText = "select ename from emp where sal=1300" + TextBox1.Text
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                Label1.Text = dr.Item("ename") ' or use dr.Item(0)
            End If
        Catch ex As Exception ' catches any error
            MessageBox.Show(ex.Message.ToString())
        Finally
            ' In a real application, put cleanup code here.

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oradb As String = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" _
                     + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY-PC)(PORT=1521)))" _
                     + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));" _
                     + "User Id=scott;Password=tiger;"

        Dim conn As New OracleConnection(oradb) ' VB.NET
        conn.Open()

        Dim cmd As New OracleCommand
        cmd.Connection = conn
        cmd.CommandText = "select ename from emp where sal = 1300"
        cmd.CommandType = CommandType.Text

        Dim dr As OracleDataReader = cmd.ExecuteReader()
        dr.Read()  ' replace this statement in next lab
        Label1.Text = dr.Item("ename") ' or dr.Item(0), remove in next lab

        dr.Dispose()
        cmd.Dispose()
        conn.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class