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
        Lag_MoveLeft()
        Frog_Ride_To_Lag()
        Lag_MoveRight()
    End Sub



    Public Sub Lag_MoveLeft()
        picLag1.Left -= 5
        picLag2.Left -= 5
        picLag3.Left -= 5

    End Sub
    Public Sub Lag_MoveRight()
        picTurtle1.Left += 4
        picTurtle2.Left += 4
        picTurtle3.Left += 4
        picTurtle4.Left += 4
    End Sub
    Public Sub Frog_Hotkey(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            picFrog.Top -= 20
        ElseIf e.KeyCode = Keys.Down Then
            picFrog.Top += 20
        ElseIf e.KeyCode = Keys.Left Then
            If picFrog.Left - 5 > 0 Then
                picFrog.Left -= 20
            End If
        ElseIf e.KeyCode = Keys.Right Then
            If picFrog.Left + picFrog.Width + 20 < Me.Width Then
                picFrog.Left += 20
            End If
        End If
    End Sub
    Public Sub Frog_Ride_To_Lag()
        If picFrog.Top + picFrog.Height >= picRiver.Top And picFrog.Top <= picRiver.Top + picRiver.Height Then
            'Ride to the lag1
            If picFrog.Left + picFrog.Width - 5 >= picLag1.Left And picFrog.Left <= picLag1.Left + picLag1.Width And picFrog.Top + picFrog.Height >= picLag1.Top And
            picFrog.Top <= picLag1.Top + picLag1.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 5
                End If

                'Ride to the lag2
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag2.Left And picFrog.Left <= picLag2.Left + picLag2.Width And picFrog.Top + picFrog.Height >= picLag2.Top And
                picFrog.Top <= picLag2.Top + picLag2.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 5
                End If

                'Ride to the lag3
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag3.Left And picFrog.Left <= picLag3.Left + picLag3.Width And picFrog.Top + picFrog.Height >= picLag3.Top And
                picFrog.Top <= picLag3.Top + picLag2.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 5
                End If

                'Ride to the Turtle1
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle1.Left And picFrog.Left <= picTurtle1.Left + picTurtle1.Width And picFrog.Top + picFrog.Height >= picTurtle1.Top And
            picFrog.Top <= picTurtle1.Top + picTurtle1.Height Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width + 15 < Me.Width Then
                    picFrog.Left += 4
                End If

                'Ride to the Turtle2
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle2.Left And picFrog.Left <= picTurtle2.Left + picTurtle2.Width And picFrog.Top + picFrog.Height >= picTurtle2.Top And
            picFrog.Top <= picTurtle2.Top + picTurtle2.Height Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width + 15 < Me.Width Then
                    picFrog.Left += 4
                End If

                'Ride to the Turtle3
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle3.Left And picFrog.Left <= picTurtle3.Left + picTurtle3.Width And picFrog.Top + picFrog.Height >= picTurtle3.Top And
            picFrog.Top <= picTurtle3.Top + picTurtle3.Height Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width + 15 < Me.Width Then
                    picFrog.Left += 4
                End If
                'Ride to the Turtle4
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle4.Left And picFrog.Left <= picTurtle4.Left + picTurtle4.Width And picFrog.Top + picFrog.Height >= picTurtle4.Top And
            picFrog.Top <= picTurtle4.Top + picTurtle4.Height Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width + 15 < Me.Width Then
                    picFrog.Left += 4
                End If
            Else
                Label1.Text = "Outside"
            End If

        End If

    End Sub

    Private Sub picLag1_Click(sender As Object, e As EventArgs) Handles picLag1.Click

    End Sub

    Private Sub Lag_MoveLeft_Loop(sender As Object, e As EventArgs) Handles picLag1.Move, picLag2.Move, picLag3.Move
        If sender.left + sender.width <= 0 Then
            sender.left = Me.Width
        End If
    End Sub
    Private Sub Turtle_MoveRight_Loop(sender As Object, e As EventArgs) Handles picTurtle1.Move, picTurtle2.Move, picTurtle4.Move, picTurtle3.Move
        If sender.left > Me.Width Then
            sender.left = 0 - sender.Width
        End If
    End Sub

End Class
