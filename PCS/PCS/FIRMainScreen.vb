Public Class FIRMainScreen

    Public user As Integer

    Private Sub RegFIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegFIR.Click
        'FIR.Show()
        'Me.Hide()
        Dashboard.Panel2.Controls.Clear()
        Dim fir As New FIR
        fir.TopLevel = False
        Dashboard.Panel2.Controls.Add(fir)
        fir.Show()
        Me.Close()
    End Sub

    Private Sub FIRStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FIRStat.Click
        'FIRStat.Show()
        'Me.Hide()
        Dashboard.Panel2.Controls.Clear()
        Dim firstat As New FIRStat
        firstat.TopLevel = False
        Dashboard.Panel2.Controls.Add(firstat)
        firstat.Show()
        Me.Close()
    End Sub

    Private Sub FileReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileReport.Click
        FileReport.Show()
        Me.Hide()

    End Sub

    'Private Sub NUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    NewUserReqs.Show()
    '    Me.Hide()

    'End Sub

    'Private Sub CMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CMSMainScreen.Show()
    '    Me.Hide()
    'End Sub

    'Private Sub PMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    PMSMainScreen.Show()
    '    Me.Hide()
    'End Sub

    'Private Sub dash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dashboard.Show()
    '    Me.Close()
    'End Sub

    'Private Sub SignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Login.Show()
    '    Me.Close()

    'End Sub

    'Private Sub FIRMainScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '    If Login.user = 1 Or Dashboard.user = 1 Then
    '        NUR.Enabled = True
    '        user = 1
    '    End If
    'End Sub
End Class