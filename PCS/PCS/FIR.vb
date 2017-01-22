Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Data

Public Class FIR
    Dim dd, mm, yy As String
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
          + "(ADDRESS=(PROTOCOL=TCP)(HOST=AKSHAY)(PORT=1521))" _
          + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
          + "User Id=scott;Password=tiger;"
    Dim conn As New OracleConnection(oradb)

    Private Sub FIR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fdd.Text = Today.Day
        fmm.Text = Today.Month
        fyy.Text = Today.Year
        fhh.Text = Now.Hour
        fmin.Text = Now.Minute
        policeid.Text = Dashboard.id
        MonthCalendar1.MaxDate = Today


        Dim i As Integer
        For i = 1 To 31
            '     dd.Items.Add(i)
            fdd.Items.Add(i)
        Next

        For i = 1 To 12
            '    mm.Items.Add(i)
            fmm.Items.Add(i)
        Next

        For i = 1980 To Now.Year
            '   yy.Items.Add(i)
            fyy.Items.Add(i)
        Next
        For i = 1 To 24
            hh.Items.Add(i)
            ' fhh.Items.Add(i)
        Next
        For i = 0 To 55 Step 5
            min.Items.Add(i)
            'fmin.Items.Add(i)
        Next
        FirNo.Text = GetRandom(100, 999)


    End Sub


    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        'FIRMainScreen.Show()
        'Me.Hide()
        Dashboard.Panel2.Controls.Clear()
        Dim fms As New FIRMainScreen
        fms.TopLevel = False
        Dashboard.Panel2.Controls.Add(fms)
        fms.Show()
        Me.Close()
    End Sub


    Private Sub register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles register.Click
        If infname.Text = "" Or infadd.Text = "" Or infid.Text = "" Or dd = "" Or mm = "" Or yy = "" Or hh.Text = "" Or min.Text = "" Or fdd.Text = "" Or fmm.Text = "" Or fyy.Text = "" Or fhh.Text = "" Or loc.Text = "" Or actinfo.Text = "" Or policeid.Text = "" Or Label14.Text = "" Then
            MsgBox("Please fill in all the details. For further information contact administrator.")
        Else


            Dim sql = "insert into fir values(" + FirNo.Text + ",'" + infname.Text + "','" + infadd.Text + "','" + infid.Text + "'," + dd + "," + mm + "," + yy + "," + hh.Text + "," + min.Text + "," +
            fdd.Text + "," + fmm.Text + "," + fyy.Text + "," + fhh.Text + "," + fmin.Text + ",'" + loc.Text _
                  + "','" + actinfo.Text + "','" + policeid.Text + "','Pending')"
            Dim cmd As New OracleCommand(sql, conn)
            cmd.CommandText = sql
            cmd.CommandType = CommandType.Text
            conn.Open()
            Try
                cmd.ExecuteNonQuery()
                MsgBox("FIR Registered Successfully.")
                FIRMainScreen.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox("Server Down. Please try again later : Error (" & ex.Message & ")")
            End Try
            conn.Close()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MonthCalendar1.Visible = True Then
            MonthCalendar1.Visible = False
            dd = MonthCalendar1.SelectionRange.Start.Day
            mm = MonthCalendar1.SelectionRange.Start.Month
            yy = MonthCalendar1.SelectionRange.Start.Year
            Label14.Text = dd + "/" + mm + "/" + yy
            Label14.Visible = True

            Button1.Text = "Show Calendar"
        Else
            MonthCalendar1.Visible = True
            Button1.Text = "Select Date"
            Label14.Visible = False
        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class