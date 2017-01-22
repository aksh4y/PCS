Imports System.Data.OleDb
Imports Oracle.DataAccess.Client


Public Class Form1
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
           + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY)(PORT=1521))" _
           + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
           + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)
    Dim sql As String = "select department_name from departments where department_id = 10" ' Visual Basic


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn.Open()
        
        'connect.Enabled = False
        
        Dim sql As String = "select LName from Police" ' where PoliceID=3133"
        'Dim sql1 As String = "select FName from Police"
        'Dim sql2 As String = "select LName from Police"
        'Dim sql3 As String = "select PSCode from Police"
        Dim cmd As New OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader() ' Visual Basic
        dr.Read()
            TextBox1.Text = dr(0)
        sql = "select FName from Police where PoliceID=3133"
        cmd = New OracleCommand(sql, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        TextBox2.Text = dr(0)


        conn.Close()


    End Sub

End Class