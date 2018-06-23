Public Class Form1
    Dim frogMove As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Frog_Hotkey(sender, e)

    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            'If picFrog.Left >= picLog.Left And picFrog.Left <= picLog.Left + picLog.Width - picFrog.Width And picFrog.Top >= picLog.Top And
            'picFrog.Top <= picLog.Top + picLog.Height - picFrog.Height Then
            '    frogMove = True
            '    Label1.Text = "Inside"
            'Else
            '    frogMove = False
            '    Label1.Text = "Outside"
            'End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'picLog.Left -= 5
        Car_moveLeft(sender, e)

        If picFrog.Left >= picLog.Left And picFrog.Left <= picLog.Left + picLog.Width - picFrog.Width And picFrog.Top >= picLog.Top And
            picFrog.Top <= picLog.Top + picLog.Height - picFrog.Height Then
            frogMove = True
            Label1.Text = "Inside"
        Else
            frogMove = False
            Label1.Text = "Outside"
        End If

        If frogMove = True Then
            picFrog.Left -= 5
        Else
            picFrog.Left = picFrog.Left
        End If
    End Sub



    Public Sub Car_moveLeft(sender As Object, e As EventArgs) Handles picLog.Validated
        picLog.Left -= 5
    End Sub
    Public Sub Frog_Hotkey(sender As Object, e As KeyEventArgs)
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
End Class
