Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Data

Public Class RegisterPrisoner
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
      + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY)(PORT=1521))" _
      + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
      + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)
    Dim sql
    Dim cmd As New OracleCommand(Sql, conn)
    Dim stat As String
    Dim dd, mm, yy, rdd, rmm, ryy As String


    Private Sub RegisterPrisoner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MonthCalendar1.MaxDate = Today
        prisonerid.Text = GetRandom(100, 999)
        policeid.Text = Dashboard.id

        imp.Visible = False
        rel.Visible = False

        gender.Items.Add("Male")
        gender.Items.Add("Female")
        gender.Items.Add("Other")

        For i = 1 To 5
            heat.Items.Add(i)

        Next

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


        prisons.Items.Add("Hosur Road")
        prisons.Items.Add("Koramangala")
        prisons.Items.Add("Jayanagar")
        prisons.Items.Add("Wilson Garden")
        prisons.Items.Add("Brigade Road")
        prisons.Items.Add("Commercial Street")
        prisons.Items.Add("Indhiranagar")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PMSMainScreen.Show()
        Me.Close()
    End Sub





   




Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If criminalid.Text = "" Or prisonername.Text = "" Or age.Text = "" Or gender.Text = "" Or height.Text = "" Or weight.Text = "" Or heat.Text = "" Or dd = "" Or rdd = "" Then
            MsgBox("Please Fill In All The Details.")
        Else

            sql = "insert into prisoner values(" + prisonerid.Text + "," + criminalid.Text + ",'" + prisonername.Text + "'," + age.Text + ",'" + gender.Text + "'," + height.Text + "," +
                weight.Text + "," + heat.Text + "," + dd + "," + mm + "," + yy + "," + rdd + "," + rmm + "," + ryy + ",'" + prisons.Text + "','" + policeid.Text + "')"
            Try
                connection()
                MsgBox("Prisoner Registered Successfully.")
                CMSMainScreen.Show()
                Me.Close()

            Catch ex As Exception
                MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
            End Try
            conn.Close()
        End If



End Sub



Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
    Dim Generator As System.Random = New System.Random()
    Return Generator.Next(Min, Max)
End Function

Private Function connection()
    cmd.CommandText = sql
    cmd.CommandType = CommandType.Text
    conn.Open()
    cmd.ExecuteNonQuery()
    cmd.CommandType = CommandType.Text
    Return Nothing
End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MonthCalendar1.Visible = True Then
            MonthCalendar1.Visible = False
            dd = MonthCalendar1.SelectionRange.Start.Day
            mm = MonthCalendar1.SelectionRange.Start.Month
            yy = MonthCalendar1.SelectionRange.Start.Year
            imp.Text = dd + "/" + mm + "/" + yy
            imp.Visible = True

            Button3.Text = "Show Calendar"
        Else
            MonthCalendar1.Visible = True
            Button3.Text = "Select Date"
            imp.Visible = False
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MonthCalendar1.Visible = True Then
            MonthCalendar1.Visible = False
            rdd = MonthCalendar1.SelectionRange.Start.Day
            rmm = MonthCalendar1.SelectionRange.Start.Month
            ryy = MonthCalendar1.SelectionRange.Start.Year
            rel.Text = rdd + "/" + rmm + "/" + ryy
            rel.Visible = True

            Button4.Text = "Show Calendar"
        Else
            MonthCalendar1.Visible = True
            Button4.Text = "Select Date"
            rel.Visible = False
        End If
    End Sub
End Class