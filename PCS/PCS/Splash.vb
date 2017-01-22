Public Class Splash
    Dim lb1 As New ListBox()
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
        Else

            Timer1.Enabled = False
            Me.Hide()
            Login.Show()

        End If


    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenFileDialog1.FileName = System.Reflection.Assembly.GetExecutingAssembly().Location
        'Dim x As Integer


    End Sub
End Class