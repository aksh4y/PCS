Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class Login
    Public user As Integer

    Dim oradb As String = "Data Source=(DESCRIPTION=" _
           + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY)(PORT=1521))" _
           + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
           + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginbtn.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please Enter User ID And Password.")
        Else

            conn.Open()
            Dim sql As String = "select adminapp from login where username = '" + TextBox1.Text + "' and password='" + TextBox2.Text + "'"
            Dim cmd As New OracleCommand(sql, conn)
            cmd.CommandType = CommandType.Text
            Try
                Dim dr As OracleDataReader = cmd.ExecuteReader()
                cmd = New OracleCommand(sql, conn)
                If dr.Read() Then
                    If Val(dr(0)) = 1 Then
                        MsgBox("Admin Access Granted")
                        Dashboard.Show()
                        user = 1
                        'FIRStat.Update.Enabled = True
                        'Dashboard.NUR.Enabled = True
                        'FIRMainScreen.NUR.Enabled = True
                        Me.Close()
                    ElseIf Val(dr(0)) = 2 Then
                        MsgBox("User Acess Granted")
                        Dashboard.Show()
                        Me.Close()
                    Else
                        MsgBox("Admin Approval Pending")

                    End If


                Else
                    MsgBox("Access Denied")
                End If
            Catch ex As Exception
                MsgBox("Access Denied")
            End Try

            conn.Close()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles register.Click
        NewUserReg.Show()
        Me.Close()
    End Sub


    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        currdate.Text = Now.Date
        currtime.Text = Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString
    End Sub
End Class
