Public Class Dashboard
    Public id As String
    Public user As Integer

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        id = Login.TextBox1.Text
        Me.Text = "PCS::DASHBOARD-" + id
        If Login.user = 1 Or FIRMainScreen.user = 1 Then
            NUR.Enabled = True
            user = 1
        Else : user = 2
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FMS.Click
        'FIRMainScreen.Show()
        'Me.Hide()
        Panel2.Controls.Clear()
        Dim fms As New FIRMainScreen
        fms.TopLevel = False
        Me.Panel2.Controls.Add(fms)
        fms.Show()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PMS.Click
        PMSMainScreen.Show()
        Me.Hide()

    End Sub

    Private Sub NUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NewUserReqs.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMS.Click
        'CMSMainScreen.Show()
        'Me.Hide()
        Me.Panel2.Controls.Clear()
        Dim cms As New CMSMainScreen
        cms.TopLevel = False
        Me.Panel2.Controls.Add(cms)
        cms.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignOut.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUR.Click
        NewUserReqs.Show()
        Me.Hide()
    End Sub
End Class