# Visual-Basic.NET-VideoPlayer
Visual Basic .NET视频播放器
Imports WMPLib

这一行导入了WMPLib库，它是Windows Media Player的控件库。

Public Class Form1

定义一个名为Form1的公共类。这是一个窗口类，代表了用户界面。

Dim WithEvents player As New WindowsMediaPlayer

在类的范围内，声明了一个新的WindowsMediaPlayer对象，命名为player。WithEvents关键字表示该对象可以定义事件。

Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click

定义了一个名为btnSelectFile_Click的私有子程序。当btnSelectFile（应该是一个按钮控件）被点击时，此子程序将被执行。

Dim openFileDialog As New OpenFileDialog()

在子程序内部，声明并初始化了一个OpenFileDialog对象，这是一个文件选择对话框。

If openFileDialog.ShowDialog() = DialogResult.OK Then

如果用户在打开的文件对话框中选择了一个文件并点击了OK，那么这个If语句为真。

player.URL = openFileDialog.FileName

将所选文件的路径赋给player的URL属性，这样player就可以找到并播放这个文件了。

Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

定义了一个名为btnPlay_Click的私有子程序。当btnPlay（应该是一个按钮控件）被点击时，此子程序将被执行。

player.controls.play()

调用player对象的play方法，开始播放视频。

同理，`btnPause_Click` 和 `player.controls.pause()` 是用来定义暂停按钮和暂停视频的功能的。

Private Sub trackBarSpeed_Scroll(sender As Object, e As EventArgs) Handles trackBarSpeed.Scroll

定义了一个名为trackBarSpeed_Scroll的私有子程序。当trackBarSpeed（应该是一个滑块控件）的位置发生变化时，此子程序将被执行。

player.settings.rate = trackBarSpeed.Value

将滑块的值赋给player的rate属性，这样就可以改变视频的播放速度了。

同理，`trackBarVolume_Scroll` 和 `player.settings.volume = trackBarVolume.Value` 是用来定义音量滑块和调整音量的功能的。

最后，

End Class

这一行表示类定义的结束。
