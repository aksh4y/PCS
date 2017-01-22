Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Data

Public Class RegisterCriminal
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
          + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY)(PORT=1521))" _
          + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
          + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)
    Dim sql
    Dim cmd As New OracleCommand(sql, conn)
    Dim stat As String

   
    Private Sub RegisterCriminal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        other.Enabled = False

        For i = 1 To 5
            heat.Items.Add(i)
        Next

        gender.Items.Add("Male")
        gender.Items.Add("Female")
        gender.Items.Add("Other")

        sql = "select firno from fir"
        Try
            connection()
            Dim dr As OracleDataReader = cmd.ExecuteReader()
            While dr.Read()
                caseid.Items.Add(dr.Item("firno"))
            End While

        Catch ex As Exception
            MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
        End Try
        conn.Close()
        criminalid.Text = GetRandom(100, 999)
       

    End Sub

    Private Function connection()
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        conn.Open()
        cmd.ExecuteNonQuery()
        cmd.CommandType = CommandType.Text
        Return Nothing
    End Function

  

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If caseid.Text = "" Or criminalname.Text = "" Or age.Text = "" Or gender.Text = "" Or height.Text = "" Or weight.Text = "" Or heat.Text = "" Or modus.Text = "" Or policeid.Text = "" Then
            MsgBox("Please Fill In All The Details.")
        Else
            If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
                MsgBox("Please Fill In All The Details.")
            ElseIf RadioButton3.Checked = True And other.Text = "" Then
                MsgBox("Please Fill In All The Details.")
            Else

                If RadioButton1.Checked = True Then
                    stat = RadioButton1.Text
                ElseIf RadioButton2.Checked = True Then
                    stat = RadioButton2.Text
                ElseIf RadioButton3.Checked = True Then
                    other.Enabled = True

                    stat = other.Text


                End If


                If addr.Text = "" Then
                    addr.Text = "-"
                End If
                If id.Text = "" Then
                    id.Text = "-"
                End If

                sql = "insert into criminal values(" + criminalid.Text + "," + caseid.Text + ",'" + criminalname.Text + "'," + age.Text + ",'" + gender.Text + "'," + height.Text + "," +
                    weight.Text + "," + heat.Text + ",'" + addr.Text + "','" + id.Text + "','" + modus.Text + "','" + stat + "','" + policeid.Text + "')"
                Try
                    connection()
                    MsgBox("Criminal Registered Successfully.")
                    CMSMainScreen.Show()
                    Me.Close()

                Catch ex As Exception
                    MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
                End Try
                conn.Close()
            End If
        End If


    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CMSMainScreen.Show()
        Me.Close()

    End Sub
End Class