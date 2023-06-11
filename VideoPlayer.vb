Imports WMPLib

Public Class Form1

    ' 创建一个Windows Media Player对象
    Dim WithEvents player As New WindowsMediaPlayer

    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        Dim openFileDialog As New OpenFileDialog()
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            player.URL = openFileDialog.FileName
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        ' 播放视频
        player.controls.play()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        ' 暂停视频
        player.controls.pause()
    End Sub

    Private Sub trackBarSpeed_Scroll(sender As Object, e As EventArgs) Handles trackBarSpeed.Scroll
        ' 改变视频播放速度
        player.settings.rate = trackBarSpeed.Value
    End Sub

    Private Sub trackBarVolume_Scroll(sender As Object, e As EventArgs) Handles trackBarVolume.Scroll
        ' 改变视频音量
        player.settings.volume = trackBarVolume.Value
    End Sub

End Class
