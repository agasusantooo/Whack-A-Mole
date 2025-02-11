Imports System.Media

Public Class Form2

    ' Random generator to choose which hole (PictureBox) shows the mole
    Private random As New Random()

    ' Game variables
    Private score As Integer = 0
    Private highScore As Integer = 0
    Private timeLeft As Integer = 30

    ' Index of the PictureBox currently showing the mole
    Private currentMoleIndex As Integer = -1

    ' Array to hold references to all “hole” PictureBoxes
    Private holes() As PictureBox

    ' Load to play audio
    Private whackPlayer As New SoundPlayer()
    Private hitMolePlayer As New SoundPlayer()
    Private endGame As New SoundPlayer()


    ' This runs when the form loads
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Build the full paths to the WAV files
        Dim whackPath As String = IO.Path.Combine(IO.Path.GetFullPath(Application.StartupPath & "\..\" & "\..\" & "\..\"), "Asset", "Jab.wav")
        Dim hitMolePath As String = IO.Path.Combine(IO.Path.GetFullPath(Application.StartupPath & "\..\" & "\..\" & "\..\"), "Asset", "Kena.wav")
        Dim endGamePath As String = IO.Path.Combine(IO.Path.GetFullPath(Application.StartupPath & "\..\" & "\..\" & "\..\"), "Asset", "Clear.wav")

        If IO.File.Exists(whackPath) Then
            ' Set the SoundLocation for each SoundPlayer object using the file paths
            whackPlayer.SoundLocation = whackPath
            whackPlayer.Load()
        Else
            MessageBox.Show("Sound file not found: " & whackPath, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If IO.File.Exists(hitMolePath) Then
            hitMolePlayer.SoundLocation = hitMolePath
            hitMolePlayer.Load()
        Else
            MessageBox.Show("Sound file not found: " & hitMolePath, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If IO.File.Exists(endGamePath) Then
            endGame.SoundLocation = endGamePath
            endGame.Load()
        Else
            MessageBox.Show("Sound file not found: " & endGamePath, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




        ' Assign your PictureBoxes to the array
        holes = New PictureBox() {pbMole1, pbMole2, pbMole3,
                                  pbMole4, pbMole5, pbMole6, pbMole7}

        ' Ensure all moles are hidden initially
        For Each pb In holes
            pb.Visible = False
        Next

        ' Initialize labels
        lblScore.Text = "0"
        lblHighScore.Text = "0"
        lblTime.Text = "30"

        ' Reset score and time
        score = 0
        lblScore.Text = "0"
        timeLeft = 30
        lblTime.Text = timeLeft.ToString()

        ' Start the timer
        TimerGame.Interval = 1000 ' 1 second
        TimerGame.Start()

        ' Show the first mole
        ShowRandomMole()
    End Sub

    ' Handle clicks on any of the PictureBoxes
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) _
        Handles pbMole1.Click, pbMole2.Click, pbMole3.Click,
                pbMole4.Click, pbMole5.Click, pbMole6.Click, pbMole7.Click

        ' Check if the clicked PictureBox is currently showing a mole
        Dim clickedHole As PictureBox = DirectCast(sender, PictureBox)
        If clickedHole.Visible Then
            ' Increment score
            score += 1
            lblScore.Text = score.ToString()
            hitMolePlayer.Play()

            ' Hide the mole you just whacked
            clickedHole.Visible = False
        Else
            whackPlayer.Play()
        End If
    End Sub

    ' Timer tick event: updates every second (or whatever interval you set)
    Private Sub TimerGame_Tick(sender As Object, e As EventArgs) Handles TimerGame.Tick
        ' Decrease time
        If timeLeft > 0 Then
            timeLeft -= 1
            lblTime.Text = timeLeft.ToString()

            ' Move mole to a new hole
            ShowRandomMole()
        Else
            ' Time is up
            TimerGame.Stop()

            ' Update high score if needed
            If score > highScore Then
                highScore = score
                lblHighScore.Text = highScore.ToString()
            End If
            endGame.Play()
            ' Notify the user
            MessageBox.Show("Time's up! Your score: " & score.ToString(),
                            "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Hide any visible mole
            If currentMoleIndex <> -1 Then
                holes(currentMoleIndex).Visible = False
            End If
        End If
    End Sub

    ' Picks a random hole and shows the mole there
    Private Sub ShowRandomMole()
        ' Hide the old mole if any
        If currentMoleIndex <> -1 Then
            holes(currentMoleIndex).Visible = False
        End If

        ' Pick a random hole index
        currentMoleIndex = random.Next(0, holes.Length)

        ' Show the mole in the new hole
        holes(currentMoleIndex).Visible = True
    End Sub

    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        Dim newForm As New Form1()
        newForm.Show()
        Me.Hide()
    End Sub


End Class
