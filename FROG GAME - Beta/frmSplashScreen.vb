Public Class frmSplashScreen
    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim intnum As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intnum += 1
        If lblProgress.Text = "Loading . . ." Then
            lblProgress.Text = "Loading ."
        ElseIf lblProgress.Text = "Loading ." Then
            lblProgress.Text = "Loading . ."
        ElseIf lblProgress.Text = "Loading . ." Then
            lblProgress.Text = "Loading . . ."
        End If

        If intnum < 100 Then
            lblPercent.Text = intnum & "%"
            ProgressBar1.Value = intnum
        ElseIf intnum = 100 Then
            lblPercent.Text = "100%"
            lblProgress.Text = "Finished"
            ProgressBar1.Value = intnum
        ElseIf intnum = 110 Then
            Timer1.Enabled = False
            frmLogin.Show()
            Close()
        End If
    End Sub
End Class