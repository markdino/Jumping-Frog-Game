Public Class Form1
    Dim frogMove As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Frog_Hotkey(sender, e)

    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'Frog_Ride_To_Lag()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'picLog.Left -= 5
        Lag_MoveLeft(sender, e)
        Frog_Ride_To_Lag()
        Lag_MoveRight()
    End Sub



    Public Sub Lag_MoveLeft(sender As Object, e As EventArgs) Handles picLag1.Validated, picLag2.Validated, picLag3.Validated
        picLag1.Left -= 5
        picLag2.Left -= 5
    End Sub
    Public Sub Lag_MoveRight()
        picLag3.Left += 5
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
    Public Sub Frog_Ride_To_Lag()
        'Ride to the lag1 that is moving to the LEFT
        If picFrog.Left + picFrog.Width - 5 >= picLag1.Left And picFrog.Left <= picLag1.Left + picLag1.Width And picFrog.Top + picFrog.Height >= picLag1.Top And
            picFrog.Top <= picLag1.Top + picLag1.Height Then
            Label1.Text = "Inside"
            If picFrog.Left > 0 Then
                picFrog.Left -= 5
            End If

            'Ride to the lag2 that is moving to the LEFT
        ElseIf picFrog.Left + picFrog.Width - 5 >= picLag2.Left And picFrog.Left <= picLag2.Left + picLag2.Width And picFrog.Top + picFrog.Height >= picLag2.Top And
                picFrog.Top <= picLag2.Top + picLag2.Height Then
            Label1.Text = "Inside"
            If picFrog.Left > 0 Then
                picFrog.Left -= 5
            End If

            'Ride to the lag3 that is moving to the RIGHT
        ElseIf picFrog.Left + picFrog.Width - 5 >= picLag3.Left And picFrog.Left <= picLag3.Left + picLag3.Width And picFrog.Top + picFrog.Height >= picLag3.Top And
            picFrog.Top <= picLag3.Top + picLag3.Height Then
            Label1.Text = "Inside"
            If picFrog.Left + picFrog.Width + 15 < Me.Width Then
                picFrog.Left += 5
            End If
        Else
            Label1.Text = "Outside"
        End If
    End Sub

    Private Sub picLag1_Click(sender As Object, e As EventArgs) Handles picLag1.Click

    End Sub

    Private Sub Lag_MoveLeft_Loop(sender As Object, e As EventArgs) Handles picLag1.Move, picLag2.Move
        If sender.left + sender.width <= 0 Then
            sender.left = Me.Width
        End If
    End Sub
    Private Sub Lag_MoveRight_Loop(sender As Object, e As EventArgs) Handles picLag3.Move
        If sender.left > Me.Width Then
            sender.left = 0 - sender.Width
        End If
    End Sub

End Class
