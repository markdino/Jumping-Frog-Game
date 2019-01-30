Module modSFX
    Public Sub sfx_jump()
        My.Computer.Audio.Play(My.Resources.jump, AudioPlayMode.Background)
    End Sub
    Public Sub sfx_splat()
        My.Computer.Audio.Play(My.Resources.splat, AudioPlayMode.WaitToComplete)
    End Sub
    Public Sub sfx_splash()
        My.Computer.Audio.Play(My.Resources.waterSplash, AudioPlayMode.Background)
    End Sub
    Public Sub sfx_brake()
        My.Computer.Audio.Play(My.Resources.brake, AudioPlayMode.Background)
    End Sub
    Public Sub sfx_correct()
        My.Computer.Audio.Play(My.Resources.correct, AudioPlayMode.Background)
    End Sub
    Public Sub sfx_music()
        My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.Background)
    End Sub

End Module
