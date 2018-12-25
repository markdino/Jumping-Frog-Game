Public Class frmSplash
    Private Sub btnQMngr_Click(sender As Object, e As EventArgs) Handles btnQMngr.Click
        frmMngrQuiz.Show()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form1.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmLogin.Show()
        Close()
    End Sub
End Class