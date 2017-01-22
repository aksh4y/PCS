Imports System.Data.OleDb
Imports Oracle.DataAccess.Client


Public Class Register
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
           + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY-PC)(PORT=1521))" _
           + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
           + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)
    Dim sql As String = "insert into Police values("+ ' Visual Basic

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label1.Text = (Str(Int(Rnd() * 10)))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
            MsgBox("INVALID ENTRY")
        Else
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


            MsgBox("REGISTERED.")
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 31
            ComboBox1.Items.Add(i)
        Next

        For i = 1 To 12
            ComboBox2.Items.Add(i)
        Next

        For i = 1950 To 2000
            ComboBox3.Items.Add(i)
        Next
    End Sub
End Class