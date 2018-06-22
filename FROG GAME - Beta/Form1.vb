Public Class Form1
    Dim frogMove As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            picFrog.Top -= 10

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        picLag.Left -= 5

        If frogMove = True Then
            picFrog.Left -= 5

        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            If picFrog.Left >= picLag.Left And picFrog.Left <= picLag.Left + picLag.Width - picFrog.Width And picFrog.Top >= picLag.Top And
            picFrog.Top <= picLag.Top + picLag.Height - picFrog.Height Then
                frogMove = True
            Else
                frogMove = False

            End If
        End If

    End Sub
End Class
