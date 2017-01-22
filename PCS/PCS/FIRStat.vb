Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
    Public Class FIRStat
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
        + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY)(PORT=1521))" _
        + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
        + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)
    Dim sql
    Dim cmd As New OracleCommand(Sql, conn)

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

        Private Sub FIRStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        status.Items.Add("Pending")
        status.Items.Add("Closed")
        status.Visible = False
        sql = "select firno from fir"
        Try
            connection()
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            While dr.Read()
                firno.Items.Add(dr.Item("firno"))
            End While

        Catch ex As Exception
            MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
        End Try
        conn.Close()
        End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        MsgBox("Select a value from the box to update.")
        status.Visible = True


    End Sub

    
    Private Sub status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles status.SelectedIndexChanged
        sql = "update fir set status='" + status.Text + "' where firno=" + firno.Text
        Try
            connection()
            MsgBox("Status Updated Successfully.")
            status.Visible = False
            Me.Refresh()
        Catch ex As Exception
            MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
        End Try
        conn.Close()
        TextBox1.Text = status.Text
    End Sub

    Private Sub firno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firno.SelectedIndexChanged
        sql = "select status from fir where firno=" + firno.Text
        Try
            connection()
            cmd.CommandType = CommandType.Text

            Dim dr As OracleDataReader = cmd.ExecuteReader()
            dr.Read()
            TextBox1.Text = dr(0)
        Catch ex As Exception
            MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
        End Try
        conn.Close()

    End Sub


    Private Function connection()
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        conn.Open()
            cmd.ExecuteNonQuery()
            cmd.CommandType = CommandType.Text
        Return Nothing
    End Function

End Class