Public Class Form1
    Private Sub pbPlay_Click(sender As Object, e As EventArgs) Handles pbPlay.Click
        Dim newForm As New Form2()
        newForm.Show()
        Me.Hide()
    End Sub
End Class
