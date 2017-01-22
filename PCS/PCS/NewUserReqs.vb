Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Data

Public Class NewUserReqs
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
          + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY)(PORT=1521))" _
          + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
          + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)
    Dim sql
    Dim cmd As New OracleCommand(sql, conn)


    Private Sub NewUserReqs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select username from login where adminapp=0"

        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        conn.Open()
        Try
            cmd.ExecuteNonQuery()
            cmd.CommandType = CommandType.Text

            Dim dr As OracleDataReader = cmd.ExecuteReader()
            While dr.Read()
                ComboBox1.Items.Add(dr.Item("username"))
            End While

        Catch ex As Exception
            MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
        End Try
        conn.Close()

        If ComboBox1.Text = "" Then
            Button1.Enabled = False
            Button2.Enabled = False
        End If

    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        sql = "select name,policeid,position,psid from police where policeid='" + ComboBox1.Text + "'"
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        conn.Open()
        Try
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            cmd.ExecuteNonQuery()
            If dr.Read Then
                pname.Text = dr("name")
                policeid.Text = dr("policeid")
                position.Text = dr("position")
                psid.Text = dr("psid")
            End If
        Catch ex As Exception
            MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
        End Try


        conn.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sql = "update login set adminapp=1 where username='" + ComboBox1.Text + "'"
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        conn.Open()
        Try
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            cmd.ExecuteNonQuery()
            MsgBox("Approval Succesful!")
            ComboBox1.Items.Remove(ComboBox1.SelectedItem)
            'ComboBox1.Text = ""
            ComboBox1.Refresh()
            pname.Text = ""
            policeid.Text = ""
            position.Text = ""
            psid.Text = ""
        Catch ex As Exception
            MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
        End Try
        conn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sql = "update login set adminapp=2 where username='" + ComboBox1.Text + "'"
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        conn.Open()
        Try
            cmd.CommandType = CommandType.Text
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            cmd.ExecuteNonQuery()
            MsgBox("Approval Succesful!")
            ComboBox1.Items.Remove(ComboBox1.SelectedItem)
            'ComboBox1.Text = ""
            ComboBox1.Refresh()
            pname.Text = ""
            policeid.Text = ""
            position.Text = ""
            psid.Text = ""
        Catch ex As Exception
            MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
        End Try
        conn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dashboard.Show()
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text <> "" Then
            Button1.Enabled = True
            Button2.Enabled = True

        End If
    End Sub
End Class