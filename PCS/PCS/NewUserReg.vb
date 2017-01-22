Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Public Class NewUserReg
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
          + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY)(PORT=1521))" _
          + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
          + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)


    Private Sub NewUserReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        policeid.Text = FIR.GetRandom(100, 999)


        For i = 1 To 31
            dd.Items.Add(i)
        Next
        For i = 1 To 12
            mm.Items.Add(i)
        Next
        For i = 1980 To Now.Year
            yy.Items.Add(i)
        Next
        Label1.Text = "Police Registration"
        sex.Items.Add("Male")
        sex.Items.Add("Female")
    End Sub

    Private Sub Register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Register.Click
        If pname.Text = "" Or mm.Text = "" Or dd.Text = "" Or yy.Text = "" Or sex.Text = "" Or position.Text = "" Or addr.Text = "" Or phone.Text = "" Or psid.Text = "" Then
            MsgBox("Please Enter All The Details. For Further Details Contact Administrator.")
        Else
            Dim sqlins = "insert into police values(" + policeid.Text + ",'" + pname.Text + "'," + dd.Text + "," + mm.Text + "," + yy.Text + ",'" + sex.Text _
            + "','" + position.Text + "','" + addr.Text + "'," + phone.Text + "," + psid.Text + ")"

            Dim cmd As New OracleCommand(sqlins, conn)
            cmd.CommandText = sqlins
            cmd.CommandType = CommandType.Text
            conn.Open()
            Try
                cmd.ExecuteNonQuery()
                'MsgBox("Registration Succesful!")
                Dim sql = "insert into login values('" + policeid.Text + "','xxxxxx',0)"
                Dim cmd1 As New OracleCommand(sql, conn)
                cmd1.CommandText = sql
                cmd1.CommandType = CommandType.Text
                Try
                    cmd1.ExecuteNonQuery()
                    MsgBox("Registration Succesful!")
                Catch ex As Exception
                    MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
                End Try
                Login.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
                Login.Show()
                Me.Close()
            End Try

            conn.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Login.Show()
        Me.Close()

    End Sub
End Class