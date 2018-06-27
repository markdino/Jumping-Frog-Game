Public Class Form1
    'Dim frogMove As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fix the position of naugthy turtles
        picTurtle1.Left = 245
        picTurtle2.Left = 206
        picTurtle3.Left = 167
        picTurtle9.Left = 471
        picTurtle10.Left = 432
        picTurtle11.Left = 393
        picTurtle12.Left = 290
        picTurtle13.Left = 251
        picTurtle14.Left = 212
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Frog_Hotkey(sender, e)
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'Frog_Ride_To_Lag()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lag_Move()
        Turtle_Move()
        Frog_Ride_To_Lag()
    End Sub



    Public Sub Lag_Move()
        picLag1.Left -= 5
        picLag2.Left -= 5
        picLag3.Left -= 5
        picLag4.Left -= 5
        '--- 2nd row --- 
        picLag5.Left -= 7
        picLag6.Left -= 7
        '--- 3rd row --- 
        picLag7.Left -= 5
        picLag8.Left -= 5
        '--- 4th row --- 
        picLag9.Left -= 7
        picLag10.Left -= 7
        picLag11.Left -= 7
        '--- 5th row --- 
        picLag12.Left -= 7
        picLag13.Left -= 7
        picLag14.Left -= 7

    End Sub
    Public Sub Turtle_Move()
        '--- 2nd row ---
        picTurtle1.Left += 4
        picTurtle2.Left += 4
        picTurtle3.Left += 4
        picTurtle4.Left += 4
        '--- 4th row ---
        picTurtle5.Left -= 6
        picTurtle6.Left -= 6
        picTurtle7.Left -= 6
        picTurtle8.Left -= 6
        '--- 5th row ---
        picTurtle9.Left += 4
        picTurtle10.Left += 4
        picTurtle11.Left += 4
        picTurtle12.Left += 4
        picTurtle13.Left += 4
        picTurtle14.Left += 4
        picTurtle15.Left += 4
        picTurtle16.Left += 4
        picTurtle17.Left += 4


    End Sub
    Private Sub Lag_MoveLeft_Loop(sender As Object, e As EventArgs) Handles picLag1.Move, picLag2.Move, picLag3.Move, picLag4.Move, picLag6.Move, picLag5.Move, picLag8.Move, picLag7.Move, picTurtle8.Move, picTurtle7.Move, picTurtle6.Move, picTurtle5.Move, picLag9.Move, picLag10.Move, picLag11.Move, picLag14.Move, picLag13.Move, picLag12.Move
        If sender.left + sender.width <= 0 Then
            sender.left = picRiver.Width
        End If
    End Sub
    Private Sub Turtle_MoveRight_Loop(sender As Object, e As EventArgs) Handles picTurtle1.Move, picTurtle2.Move, picTurtle4.Move, picTurtle3.Move, picTurtle9.Move, picTurtle17.Move, picTurtle16.Move, picTurtle15.Move, picTurtle14.Move, picTurtle13.Move, picTurtle12.Move, picTurtle11.Move, picTurtle10.Move
        If sender.left > picRiver.Width Then
            sender.left = 0 - sender.Width
        End If
    End Sub

    Public Sub Frog_Ride_To_Lag()
        If picFrog.Top >= picRiver.Top And picFrog.Top <= picRiver.Top + picRiver.Height - picFrog.Height Then
            '*********** Ride to the lag *********** 
            If picFrog.Left + picFrog.Width - 5 >= picLag1.Left And picFrog.Left <= picLag1.Left + picLag1.Width And picFrog.Top + picFrog.Height >= picLag1.Top And
            picFrog.Top <= picLag1.Top + picLag1.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 5
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag2.Left And picFrog.Left <= picLag2.Left + picLag2.Width And picFrog.Top + picFrog.Height >= picLag2.Top And
                picFrog.Top <= picLag2.Top + picLag2.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 5
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag3.Left And picFrog.Left <= picLag3.Left + picLag3.Width And picFrog.Top + picFrog.Height >= picLag3.Top And
                picFrog.Top <= picLag3.Top + picLag3.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 5
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag4.Left And picFrog.Left <= picLag4.Left + picLag4.Width And picFrog.Top + picFrog.Height >= picLag4.Top And
            picFrog.Top <= picLag4.Top + picLag4.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 5
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag5.Left And picFrog.Left <= picLag5.Left + picLag5.Width And picFrog.Top + picFrog.Height >= picLag5.Top And
        picFrog.Top <= picLag5.Top + picLag5.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 7
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag6.Left And picFrog.Left <= picLag6.Left + picLag6.Width And picFrog.Top + picFrog.Height >= picLag6.Top And
        picFrog.Top <= picLag6.Top + picLag6.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 7
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag7.Left And picFrog.Left <= picLag7.Left + picLag7.Width And picFrog.Top + picFrog.Height >= picLag7.Top And
            picFrog.Top <= picLag7.Top + picLag7.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 5
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag8.Left And picFrog.Left <= picLag8.Left + picLag8.Width And picFrog.Top + picFrog.Height >= picLag8.Top And
            picFrog.Top <= picLag8.Top + picLag8.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 5
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag9.Left And picFrog.Left <= picLag9.Left + picLag9.Width And picFrog.Top + picFrog.Height >= picLag9.Top And
    picFrog.Top <= picLag9.Top + picLag9.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 7
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag10.Left And picFrog.Left <= picLag10.Left + picLag10.Width And picFrog.Top + picFrog.Height >= picLag10.Top And
        picFrog.Top <= picLag10.Top + picLag10.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 7
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag11.Left And picFrog.Left <= picLag11.Left + picLag11.Width And picFrog.Top + picFrog.Height >= picLag11.Top And
        picFrog.Top <= picLag11.Top + picLag11.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 7
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag12.Left And picFrog.Left <= picLag12.Left + picLag12.Width And picFrog.Top + picFrog.Height >= picLag12.Top And
picFrog.Top <= picLag12.Top + picLag12.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 7
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag13.Left And picFrog.Left <= picLag13.Left + picLag13.Width And picFrog.Top + picFrog.Height >= picLag13.Top And
        picFrog.Top <= picLag13.Top + picLag13.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 7
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picLag14.Left And picFrog.Left <= picLag14.Left + picLag14.Width And picFrog.Top + picFrog.Height >= picLag14.Top And
        picFrog.Top <= picLag14.Top + picLag14.Height Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 7
                End If


                '*********** Ride to the Turtle *************
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle1.Left And picFrog.Left <= picTurtle1.Left + picTurtle1.Width And picFrog.Top + picFrog.Height >= picTurtle1.Top And
            picFrog.Top <= picTurtle1.Top + picTurtle1.Height And t1 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle2.Left And picFrog.Left <= picTurtle2.Left + picTurtle2.Width And picFrog.Top + picFrog.Height >= picTurtle2.Top And
            picFrog.Top <= picTurtle2.Top + picTurtle2.Height And t2 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle3.Left And picFrog.Left <= picTurtle3.Left + picTurtle3.Width And picFrog.Top + picFrog.Height >= picTurtle3.Top And
            picFrog.Top <= picTurtle3.Top + picTurtle3.Height And t3 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle4.Left And picFrog.Left <= picTurtle4.Left + picTurtle4.Width And picFrog.Top + picFrog.Height >= picTurtle4.Top And
            picFrog.Top <= picTurtle4.Top + picTurtle4.Height And t4 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
                '*********** Ride to the Turtle moving right *************
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle5.Left And picFrog.Left <= picTurtle5.Left + picTurtle5.Width And picFrog.Top + picFrog.Height >= picTurtle5.Top And
        picFrog.Top <= picTurtle5.Top + picTurtle5.Height And t5 = True Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 6
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle6.Left And picFrog.Left <= picTurtle6.Left + picTurtle6.Width And picFrog.Top + picFrog.Height >= picTurtle6.Top And
    picFrog.Top <= picTurtle6.Top + picTurtle6.Height And t6 = True Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 6
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle7.Left And picFrog.Left <= picTurtle7.Left + picTurtle7.Width And picFrog.Top + picFrog.Height >= picTurtle7.Top And
    picFrog.Top <= picTurtle7.Top + picTurtle7.Height And t7 = True Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 6
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle8.Left And picFrog.Left <= picTurtle8.Left + picTurtle8.Width And picFrog.Top + picFrog.Height >= picTurtle8.Top And
    picFrog.Top <= picTurtle8.Top + picTurtle8.Height And t8 = True Then
                Label1.Text = "Inside"
                If picFrog.Left > 0 Then
                    picFrog.Left -= 6
                End If
                '************************

            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle9.Left And picFrog.Left <= picTurtle9.Left + picTurtle9.Width And picFrog.Top + picFrog.Height >= picTurtle9.Top And
        picFrog.Top <= picTurtle9.Top + picTurtle9.Height And t9 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle10.Left And picFrog.Left <= picTurtle10.Left + picTurtle10.Width And picFrog.Top + picFrog.Height >= picTurtle10.Top And
        picFrog.Top <= picTurtle10.Top + picTurtle10.Height And t10 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle11.Left And picFrog.Left <= picTurtle11.Left + picTurtle11.Width And picFrog.Top + picFrog.Height >= picTurtle11.Top And
        picFrog.Top <= picTurtle11.Top + picTurtle11.Height And t11 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle12.Left And picFrog.Left <= picTurtle12.Left + picTurtle12.Width And picFrog.Top + picFrog.Height >= picTurtle12.Top And
        picFrog.Top <= picTurtle12.Top + picTurtle12.Height And t12 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle13.Left And picFrog.Left <= picTurtle13.Left + picTurtle13.Width And picFrog.Top + picFrog.Height >= picTurtle13.Top And
        picFrog.Top <= picTurtle13.Top + picTurtle13.Height And t13 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle14.Left And picFrog.Left <= picTurtle14.Left + picTurtle14.Width And picFrog.Top + picFrog.Height >= picTurtle14.Top And
        picFrog.Top <= picTurtle14.Top + picTurtle14.Height And t14 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle15.Left And picFrog.Left <= picTurtle15.Left + picTurtle15.Width And picFrog.Top + picFrog.Height >= picTurtle15.Top And
        picFrog.Top <= picTurtle15.Top + picTurtle15.Height And t15 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle16.Left And picFrog.Left <= picTurtle16.Left + picTurtle16.Width And picFrog.Top + picFrog.Height >= picTurtle16.Top And
        picFrog.Top <= picTurtle16.Top + picTurtle16.Height And t16 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If
            ElseIf picFrog.Left + picFrog.Width - 5 >= picTurtle17.Left And picFrog.Left <= picTurtle17.Left + picTurtle17.Width And picFrog.Top + picFrog.Height >= picTurtle17.Top And
        picFrog.Top <= picTurtle17.Top + picTurtle17.Height And t17 = True Then
                Label1.Text = "Inside"
                If picFrog.Left + picFrog.Width < picRiver.Width Then
                    picFrog.Left += 4
                End If

            Else
                Label1.Text = "Outside"
            End If

        End If

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
            If picFrog.Left + picFrog.Width + 8 < picRiver.Width Then
                picFrog.Left += 20
            End If
        End If
    End Sub
    Dim TurtleIntervals As Integer = 0
    Dim intrv1 As Integer = 0
    Dim intrv2 As Integer = 0
    Dim intrv3 As Integer = 0
    Dim intrv4 As Integer = 0
    Dim intrv5 As Integer = 0
    Dim t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17 As Boolean

    Private Sub TurtleIntrv_Tick(sender As Object, e As EventArgs) Handles TurtleIntrv.Tick
        TurtleIntervals += 1
        If TurtleIntervals = 32 Then
            TurtleGrp2.Enabled = True
        ElseIf TurtleIntervals = 4 Then
            TurtleGrp1.Enabled = True
        ElseIf TurtleIntervals = 13 Then
            TurtleGrp3.Enabled = True
        ElseIf TurtleIntervals = 20 Then
            TurtleGrp4.Enabled = True
        ElseIf TurtleIntervals = 40 Then
            TurtleGrp5.Enabled = True
        End If
    End Sub

    Private Sub TurtleGrp1_Tick(sender As Object, e As EventArgs) Handles TurtleGrp1.Tick
        intrv1 += 1
        'Turtle sink
        If intrv1 = 1 Then
            picTurtle1.BackColor = Color.Blue
            t1 = False
        ElseIf intrv1 = 2 Then
            picTurtle2.BackColor = Color.Blue
            t2 = False
        ElseIf intrv1 = 3 Then
            picTurtle3.BackColor = Color.Blue
            t3 = False
        ElseIf intrv1 = 4 Then
            picTurtle4.BackColor = Color.Blue
            t4 = False

            'Turtle float
        ElseIf intrv1 = 25 Then
            picTurtle1.BackColor = Color.Green
            t1 = True
        ElseIf intrv1 = 26 Then
            picTurtle2.BackColor = Color.Green
            t2 = True
        ElseIf intrv1 = 27 Then
            picTurtle3.BackColor = Color.Green
            t3 = True
        ElseIf intrv1 = 28 Then
            picTurtle4.BackColor = Color.Green
            t4 = True
        ElseIf intrv1 = 65 Then
            intrv1 = 0
        End If
    End Sub
    Private Sub TurtleGrp2_Tick(sender As Object, e As EventArgs) Handles TurtleGrp2.Tick
        intrv2 += 1
        'Turtle sink
        If intrv2 = 1 Then
            picTurtle5.BackColor = Color.Blue
            t5 = False
        ElseIf intrv2 = 2 Then
            picTurtle6.BackColor = Color.Blue
            t6 = False
        ElseIf intrv2 = 3 Then
            picTurtle7.BackColor = Color.Blue
            t7 = False
        ElseIf intrv2 = 4 Then
            picTurtle8.BackColor = Color.Blue
            t8 = False

            'Turtle float
        ElseIf intrv2 = 25 Then
            picTurtle5.BackColor = Color.Green
            t5 = True
        ElseIf intrv2 = 26 Then
            picTurtle6.BackColor = Color.Green
            t6 = True
        ElseIf intrv2 = 27 Then
            picTurtle7.BackColor = Color.Green
            t7 = True
        ElseIf intrv2 = 28 Then
            picTurtle8.BackColor = Color.Green
            t8 = True
        ElseIf intrv2 = 60 Then
            intrv2 = 0
        End If
    End Sub
    Private Sub TurtleGrp3_Tick(sender As Object, e As EventArgs) Handles TurtleGrp3.Tick
        intrv3 += 1
        'Turtle sink
        If intrv3 = 1 Then
            picTurtle9.BackColor = Color.Blue
            t9 = False
        ElseIf intrv3 = 2 Then
            picTurtle10.BackColor = Color.Blue
            t10 = False
        ElseIf intrv3 = 3 Then
            picTurtle11.BackColor = Color.Blue
            t11 = False

            'Turtle float
        ElseIf intrv3 = 25 Then
            picTurtle9.BackColor = Color.Green
            t9 = True
        ElseIf intrv3 = 26 Then
            picTurtle10.BackColor = Color.Green
            t10 = True
        ElseIf intrv3 = 27 Then
            picTurtle11.BackColor = Color.Green
            t11 = True
        ElseIf intrv3 = 60 Then
            intrv3 = 0
        End If
    End Sub
    Private Sub TurtleGrp4_Tick(sender As Object, e As EventArgs) Handles TurtleGrp4.Tick
        intrv4 += 1
        'Turtle sink
        If intrv4 = 1 Then
            picTurtle12.BackColor = Color.Blue
            t12 = False
        ElseIf intrv4 = 2 Then
            picTurtle13.BackColor = Color.Blue
            t13 = False
        ElseIf intrv4 = 3 Then
            picTurtle14.BackColor = Color.Blue
            t14 = False

            'Turtle float
        ElseIf intrv4 = 25 Then
            picTurtle12.BackColor = Color.Green
            t12 = True
        ElseIf intrv4 = 26 Then
            picTurtle13.BackColor = Color.Green
            t13 = True
        ElseIf intrv4 = 27 Then
            picTurtle14.BackColor = Color.Green
            t13 = True
        ElseIf intrv4 = 60 Then
            intrv4 = 0
        End If
    End Sub
    Private Sub TurtleGrp5_Tick(sender As Object, e As EventArgs) Handles TurtleGrp5.Tick
        intrv5 += 1
        'Turtle sink
        If intrv5 = 1 Then
            picTurtle15.BackColor = Color.Blue
            t15 = False
        ElseIf intrv5 = 2 Then
            picTurtle16.BackColor = Color.Blue
            t16 = False
        ElseIf intrv5 = 3 Then
            picTurtle17.BackColor = Color.Blue
            t17 = False

            'Turtle float
        ElseIf intrv5 = 25 Then
            picTurtle15.BackColor = Color.Green
            t15 = True
        ElseIf intrv5 = 26 Then
            picTurtle16.BackColor = Color.Green
            t16 = True
        ElseIf intrv5 = 27 Then
            picTurtle17.BackColor = Color.Green
            t17 = True
        ElseIf intrv5 = 60 Then
            intrv5 = 0
        End If
    End Sub


End Class
