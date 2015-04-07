Imports Microsoft.DirectX.AudioVideoPlayback

Public Class Form1
    ' Private _video As Microsoft.DirectX.AudioVideoPlayback.Video


    Private Sub BeendenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ÖffnenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        _playFile(OpenFileDialog1.FileName.ToString)
    End Sub

    Private Sub _playFile(_file As String)
        Try

            Dim _video As Microsoft.DirectX.AudioVideoPlayback.Video = New Microsoft.DirectX.AudioVideoPlayback.Video(_file)
            _video.Owner = Panel1
            _video.Play()
        Catch ex As Exception

        End Try
    End Sub
End Class
