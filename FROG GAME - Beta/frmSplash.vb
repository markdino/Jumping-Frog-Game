Imports AxWMPLib

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

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWMP.URL = Application.StartupPath & "\sfx.wav"
        music = My.Settings.music
        sound = My.Settings.sound
        HScrollBar1.Value = My.Settings.musicVolume

        load_music()
        check_volume()
        check_sfx()
    End Sub
    Private Sub play_music()
        If music = False Then
            AxWMP.Ctlcontrols.play()
            AxWMP.settings.setMode("Loop", True)
            btnMusic.Image = My.Resources.music_on
            music = True
        Else
            AxWMP.Ctlcontrols.stop()
            btnMusic.Image = My.Resources.music_off
            music = False
        End If
        My.Settings.music = music
    End Sub
    Private Sub load_music()
        If music = True Then
            AxWMP.Ctlcontrols.play()
            AxWMP.settings.setMode("Loop", True)
            btnMusic.Image = My.Resources.music_on
        Else
            AxWMP.Ctlcontrols.stop()
            btnMusic.Image = My.Resources.music_off
        End If
    End Sub
    Private Sub check_volume()
        AxWMP.settings.volume = HScrollBar1.Value
    End Sub
    Private Sub check_sfx()
        If sound = True Then
            btnSound.Image = My.Resources.sound_on
        Else
            btnSound.Image = My.Resources.sound_off
        End If
    End Sub
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        check_volume()
    End Sub

    Private Sub btnMusic_Click(sender As Object, e As EventArgs) Handles btnMusic.Click
        play_music()
    End Sub

    Private Sub btnSound_Click(sender As Object, e As EventArgs) Handles btnSound.Click
        If sound = True Then
            sfx_mute()
            btnSound.Image = My.Resources.sound_off
            sound = False
        Else
            btnSound.Image = My.Resources.sound_on
            sound = True
        End If
        My.Settings.sound = sound
    End Sub
End Class