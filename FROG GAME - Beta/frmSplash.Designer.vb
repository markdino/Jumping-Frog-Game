<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnQMngr = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AxWMP = New AxWMPLib.AxWindowsMediaPlayer()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.btnSound = New System.Windows.Forms.PictureBox()
        Me.btnMusic = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.AxWMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(431, 407)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(258, 77)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnQMngr
        '
        Me.btnQMngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQMngr.Location = New System.Drawing.Point(431, 324)
        Me.btnQMngr.Name = "btnQMngr"
        Me.btnQMngr.Size = New System.Drawing.Size(258, 77)
        Me.btnQMngr.TabIndex = 0
        Me.btnQMngr.Text = "Quiz Manager"
        Me.btnQMngr.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(431, 490)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(258, 77)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ravie", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(376, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 63)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(259, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(612, 182)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumping Frog" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Math Quiz"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AxWMP
        '
        Me.AxWMP.Enabled = True
        Me.AxWMP.Location = New System.Drawing.Point(2, 3)
        Me.AxWMP.Name = "AxWMP"
        Me.AxWMP.OcxState = CType(resources.GetObject("AxWMP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWMP.Size = New System.Drawing.Size(218, 31)
        Me.AxWMP.TabIndex = 2
        Me.AxWMP.Visible = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HScrollBar1.Location = New System.Drawing.Point(12, 580)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(169, 28)
        Me.HScrollBar1.TabIndex = 4
        Me.HScrollBar1.Value = 50
        '
        'btnSound
        '
        Me.btnSound.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSound.BackColor = System.Drawing.Color.Transparent
        Me.btnSound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSound.Image = Global.FROG_GAME___Beta.My.Resources.Resources.sound_on
        Me.btnSound.Location = New System.Drawing.Point(12, 433)
        Me.btnSound.Name = "btnSound"
        Me.btnSound.Size = New System.Drawing.Size(52, 51)
        Me.btnSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSound.TabIndex = 3
        Me.btnSound.TabStop = False
        '
        'btnMusic
        '
        Me.btnMusic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMusic.BackColor = System.Drawing.Color.Transparent
        Me.btnMusic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMusic.Image = Global.FROG_GAME___Beta.My.Resources.Resources.music_on
        Me.btnMusic.Location = New System.Drawing.Point(12, 493)
        Me.btnMusic.Name = "btnMusic"
        Me.btnMusic.Size = New System.Drawing.Size(52, 51)
        Me.btnMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMusic.TabIndex = 3
        Me.btnMusic.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(12, 555)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Volume"
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.FROG_GAME___Beta.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1087, 617)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.btnSound)
        Me.Controls.Add(Me.btnMusic)
        Me.Controls.Add(Me.AxWMP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQMngr)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1105, 664)
        Me.MinimumSize = New System.Drawing.Size(1105, 664)
        Me.Name = "frmSplash"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.AxWMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMusic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents btnQMngr As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AxWMP As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnMusic As PictureBox
    Friend WithEvents btnSound As PictureBox
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents Label3 As Label
End Class
