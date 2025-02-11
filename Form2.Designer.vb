<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        pbRefresh = New PictureBox()
        pbMole1 = New PictureBox()
        pbMole2 = New PictureBox()
        pbMole3 = New PictureBox()
        pbMole4 = New PictureBox()
        pbMole5 = New PictureBox()
        pbMole6 = New PictureBox()
        pbMole7 = New PictureBox()
        lblScore = New Label()
        lblTime = New Label()
        Label1 = New Label()
        lblHighScore = New Label()
        TimerGame = New Timer(components)
        CType(pbRefresh, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole3, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole4, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole5, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole6, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbRefresh
        ' 
        pbRefresh.BackColor = Color.Transparent
        pbRefresh.BackgroundImage = CType(resources.GetObject("pbRefresh.BackgroundImage"), Image)
        pbRefresh.BackgroundImageLayout = ImageLayout.Stretch
        pbRefresh.Location = New Point(10, 10)
        pbRefresh.Margin = New Padding(2, 2, 2, 2)
        pbRefresh.Name = "pbRefresh"
        pbRefresh.Size = New Size(81, 73)
        pbRefresh.TabIndex = 0
        pbRefresh.TabStop = False
        ' 
        ' pbMole1
        ' 
        pbMole1.BackColor = Color.Transparent
        pbMole1.BackgroundImage = CType(resources.GetObject("pbMole1.BackgroundImage"), Image)
        pbMole1.BackgroundImageLayout = ImageLayout.Stretch
        pbMole1.Location = New Point(50, 235)
        pbMole1.Margin = New Padding(2, 2, 2, 2)
        pbMole1.Name = "pbMole1"
        pbMole1.Size = New Size(112, 106)
        pbMole1.TabIndex = 1
        pbMole1.TabStop = False
        ' 
        ' pbMole2
        ' 
        pbMole2.BackColor = Color.Transparent
        pbMole2.BackgroundImage = CType(resources.GetObject("pbMole2.BackgroundImage"), Image)
        pbMole2.BackgroundImageLayout = ImageLayout.Stretch
        pbMole2.Location = New Point(259, 175)
        pbMole2.Margin = New Padding(2, 2, 2, 2)
        pbMole2.Name = "pbMole2"
        pbMole2.Size = New Size(112, 106)
        pbMole2.TabIndex = 2
        pbMole2.TabStop = False
        ' 
        ' pbMole3
        ' 
        pbMole3.BackColor = Color.Transparent
        pbMole3.BackgroundImage = CType(resources.GetObject("pbMole3.BackgroundImage"), Image)
        pbMole3.BackgroundImageLayout = ImageLayout.Stretch
        pbMole3.Location = New Point(155, 334)
        pbMole3.Margin = New Padding(2, 2, 2, 2)
        pbMole3.Name = "pbMole3"
        pbMole3.Size = New Size(112, 106)
        pbMole3.TabIndex = 3
        pbMole3.TabStop = False
        ' 
        ' pbMole4
        ' 
        pbMole4.BackColor = Color.Transparent
        pbMole4.BackgroundImage = CType(resources.GetObject("pbMole4.BackgroundImage"), Image)
        pbMole4.BackgroundImageLayout = ImageLayout.Stretch
        pbMole4.Location = New Point(381, 288)
        pbMole4.Margin = New Padding(2, 2, 2, 2)
        pbMole4.Name = "pbMole4"
        pbMole4.Size = New Size(112, 106)
        pbMole4.TabIndex = 4
        pbMole4.TabStop = False
        ' 
        ' pbMole5
        ' 
        pbMole5.BackColor = Color.Transparent
        pbMole5.BackgroundImage = CType(resources.GetObject("pbMole5.BackgroundImage"), Image)
        pbMole5.BackgroundImageLayout = ImageLayout.Stretch
        pbMole5.Location = New Point(40, 462)
        pbMole5.Margin = New Padding(2, 2, 2, 2)
        pbMole5.Name = "pbMole5"
        pbMole5.Size = New Size(112, 106)
        pbMole5.TabIndex = 5
        pbMole5.TabStop = False
        ' 
        ' pbMole6
        ' 
        pbMole6.BackColor = Color.Transparent
        pbMole6.BackgroundImage = CType(resources.GetObject("pbMole6.BackgroundImage"), Image)
        pbMole6.BackgroundImageLayout = ImageLayout.Stretch
        pbMole6.Location = New Point(399, 410)
        pbMole6.Margin = New Padding(2, 2, 2, 2)
        pbMole6.Name = "pbMole6"
        pbMole6.Size = New Size(112, 106)
        pbMole6.TabIndex = 6
        pbMole6.TabStop = False
        ' 
        ' pbMole7
        ' 
        pbMole7.BackColor = Color.Transparent
        pbMole7.BackgroundImage = CType(resources.GetObject("pbMole7.BackgroundImage"), Image)
        pbMole7.BackgroundImageLayout = ImageLayout.Stretch
        pbMole7.Location = New Point(270, 541)
        pbMole7.Margin = New Padding(2, 2, 2, 2)
        pbMole7.Name = "pbMole7"
        pbMole7.Size = New Size(112, 106)
        pbMole7.TabIndex = 7
        pbMole7.TabStop = False
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.BackColor = Color.Transparent
        lblScore.Font = New Font("Felix Titling", 35.1428566F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScore.ForeColor = Color.White
        lblScore.Location = New Point(40, 134)
        lblScore.Margin = New Padding(2, 0, 2, 0)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(77, 83)
        lblScore.TabIndex = 8
        lblScore.Text = "0"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.BackColor = Color.Transparent
        lblTime.Font = New Font("Felix Titling", 35.1428566F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(471, 123)
        lblTime.Margin = New Padding(2, 0, 2, 0)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(77, 83)
        lblTime.TabIndex = 9
        lblTime.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Felix Titling", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(211, 58)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 27)
        Label1.TabIndex = 10
        Label1.Text = "High Score"
        ' 
        ' lblHighScore
        ' 
        lblHighScore.AutoSize = True
        lblHighScore.BackColor = Color.Transparent
        lblHighScore.Font = New Font("Felix Titling", 35.1428566F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHighScore.ForeColor = Color.White
        lblHighScore.Location = New Point(259, 84)
        lblHighScore.Margin = New Padding(2, 0, 2, 0)
        lblHighScore.Name = "lblHighScore"
        lblHighScore.Size = New Size(77, 83)
        lblHighScore.TabIndex = 11
        lblHighScore.Text = "0"
        ' 
        ' TimerGame
        ' 
        TimerGame.Interval = 1000
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(563, 683)
        Controls.Add(lblHighScore)
        Controls.Add(Label1)
        Controls.Add(lblTime)
        Controls.Add(lblScore)
        Controls.Add(pbMole7)
        Controls.Add(pbMole6)
        Controls.Add(pbMole5)
        Controls.Add(pbMole4)
        Controls.Add(pbMole3)
        Controls.Add(pbMole2)
        Controls.Add(pbMole1)
        Controls.Add(pbRefresh)
        DoubleBuffered = True
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form2"
        Text = "Whack a Mole!"
        CType(pbRefresh, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole3, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole4, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole5, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole6, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbRefresh As PictureBox
    Friend WithEvents pbMole1 As PictureBox
    Friend WithEvents pbMole2 As PictureBox
    Friend WithEvents pbMole3 As PictureBox
    Friend WithEvents pbMole4 As PictureBox
    Friend WithEvents pbMole5 As PictureBox
    Friend WithEvents pbMole6 As PictureBox
    Friend WithEvents pbMole7 As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHighScore As Label
    Friend WithEvents TimerGame As Timer
End Class
