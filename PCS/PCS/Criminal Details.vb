Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Data
Public Class Criminal_Details
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
         + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY)(PORT=1521))" _
         + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
         + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)
    Dim sql As String
    Dim cmd As New OracleCommand(sql, conn)
    Dim stat As String
    Private Sub Criminal_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "select criminalid from criminal"
        Try
            connection()
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            While dr.Read()
                criminalid.Items.Add(dr.Item("criminalid"))
            End While

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

    Private Sub criminalid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles criminalid.SelectedIndexChanged
        sql = "select caseid,name,age,gender,height,weight,heat,addr,id,modus,status,policeid from criminal where criminalid=" + criminalid.Text
        Try
            connection()
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            dr.Read()
            caseid.Text = dr.Item("caseid")
            criminalname.Text = dr.Item("name")
            age.Text = dr.Item("age")
            gender.Text = dr.Item("gender")
            height.Text = dr.Item("height")
            weight.Text = dr.Item("weight")
            heat.Text = dr.Item("heat")
            addr.Text = dr.Item("addr")
            id.Text = dr.Item("id")
            modus.Text = dr.Item("modus")
            status.Text = dr.Item("status")
            policeid.Text = dr.Item("policeid")

        Catch ex As Exception
            MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class