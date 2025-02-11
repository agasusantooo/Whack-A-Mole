Imports System.Media

Public Class Form1
    Private soundPlayer As New SoundPlayer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Build the full path to the WAV file.
        Dim soundPath As String = IO.Path.Combine(IO.Path.GetFullPath(Application.StartupPath & "\..\" & "\..\" & "\..\"), "Asset", "Lagu.wav")


        ' Check if the file exists.
        If IO.File.Exists(soundPath) Then
            soundPlayer.SoundLocation = soundPath
            soundPlayer.Load() ' You can also use LoadAsync() if desired.
            soundPlayer.Play() ' Use PlaySync() if you want to block until playback finishes.
        Else
            MessageBox.Show("Sound file not found: " & soundPath, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub pbPlay_Click(sender As Object, e As EventArgs) Handles pbPlay.Click
        Dim newForm As New Form2()
        newForm.Show()
        Me.Hide()
    End Sub

End Class
