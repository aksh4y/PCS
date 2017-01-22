Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Data
Public Class CrimeDetails
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
         + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY)(PORT=1521))" _
         + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
         + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)
    Dim sql As String
    Dim cmd As New OracleCommand(sql, conn)


    Private Sub CrimeDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select firno from fir"
        Try
            conn.Close()

            connection()
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            While dr.Read()
                caseid.Items.Add(dr.Item("firno"))
            End While

        Catch ex As Exception
            MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
        End Try
        conn.Close()
    End Sub



    Private Sub caseid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caseid.SelectedIndexChanged
        sql = "select name,addr,infid,dd,mm,yy,hh,min,firdd,firmm,firyy,firhh,firmin,location,info,policeid,status from fir where firno=" + caseid.Text
        Try
            connection()
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            dr.Read()
            infname.Text = dr.Item("name")
            infadd.Text = dr.Item("addr")
            infid.Text = dr.Item("infid")
            dd.Text = dr.Item("dd")
            mm.Text = dr.Item("mm")
            yy.Text = dr.Item("yy")
            hh.Text = dr.Item("hh")
            min.Text = dr.Item("min")
            fdd.Text = dr.Item("firdd")
            fmm.Text = dr.Item("firmm")
            fyy.Text = dr.Item("firyy")
            fhh.Text = dr.Item("firhh")
            fmin.Text = dr.Item("firmin")
            loc.Text = dr.Item("location")
            actinfo.Text = dr.Item("info")
            policeid.Text = dr.Item("policeid")
            status.Text = dr.Item("status")

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


    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        CMSMainScreen.Show()
        Me.Close()
    End Sub
End Class