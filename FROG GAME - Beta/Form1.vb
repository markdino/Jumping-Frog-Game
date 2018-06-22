Public Class Form1
    Dim frogMove As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            picFrog.Top -= 10
        ElseIf e.KeyCode = Keys.Down Then
            picFrog.Top += 10
        ElseIf e.KeyCode = Keys.Left Then
            picFrog.Left -= 10
        ElseIf e.KeyCode = Keys.Right Then
            picFrog.Left += 10
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        picLog.Left -= 5

        If frogMove = True Then
            picFrog.Left -= 5

        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            If picFrog.Left >= picLog.Left And picFrog.Left <= picLog.Left + picLog.Width - picFrog.Width And picFrog.Top >= picLog.Top And
            picFrog.Top <= picLog.Top + picLog.Height - picFrog.Height Then
                frogMove = True
            Else
                frogMove = False

            End If
        End If

    End Sub
End Class
