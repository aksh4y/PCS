Public Class CMSMainScreen

    Private Sub CRSMainScreen_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dashboard.Show()

    End Sub

    Private Sub CRSMainScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'RegisterCriminal.Show()
        'Me.Hide()
        Dashboard.Panel2.Controls.Clear()
        Dim regcrim As New RegisterCriminal
        regcrim.TopLevel = False
        Dashboard.Panel2.Controls.Add(regcrim)
        regcrim.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Criminal_Details.Show()
        'Me.Hide()
        Dashboard.Panel2.Controls.Clear()
        Dim cdet As New Criminal_Details
        cdet.TopLevel = False
        Dashboard.Panel2.Controls.Add(cdet)
        cdet.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CrimeDetails.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dashboard.Show()
        Me.Close()

    End Sub
End Class