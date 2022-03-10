Imports System.Net
Public Class Form3


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        download = New WebClient
        download.DownloadFileAsync(New Uri(TextBox1.Text), TextBox2.Text)


    End Sub
    Public WithEvents download As WebClient


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveFileDialog1.Filter = " Format de fichier |*.jpg|.exe|*.exe|.*rar|*.rar|.*mp3|.*mp3|.*mp4|*.mp4|.*flv|*flv|.*iso|*.iso|.psd|*.psd"
        SaveFileDialog1.ShowDialog()
        TextBox2.Text = SaveFileDialog1.FileName

    End Sub

    Private Sub download_downloadprogresschanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
