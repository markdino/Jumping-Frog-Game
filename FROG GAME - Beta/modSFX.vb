Module modSFX
    Public sound, music As Boolean
    Public Sub sfx_jump()
        If sound = True Then My.Computer.Audio.Play(My.Resources.jump, AudioPlayMode.Background)

    End Sub
    Public Sub sfx_splat()
        If sound = True Then My.Computer.Audio.Play(My.Resources.splat, AudioPlayMode.WaitToComplete)
    End Sub
    Public Sub sfx_splash()
        If sound = True Then My.Computer.Audio.Play(My.Resources.waterSplash, AudioPlayMode.Background)
    End Sub
    Public Sub sfx_brake()
        If sound = True Then My.Computer.Audio.Play(My.Resources.brake, AudioPlayMode.Background)
    End Sub
    Public Sub sfx_correct()
        If sound = True Then My.Computer.Audio.Play(My.Resources.correct, AudioPlayMode.Background)
    End Sub
    Public Sub sfx_music()
        If sound = True Then My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.Background)
    End Sub
    Public Sub sfx_mute()
        If sound = True Then My.Computer.Audio.Stop()
    End Sub
End Module
