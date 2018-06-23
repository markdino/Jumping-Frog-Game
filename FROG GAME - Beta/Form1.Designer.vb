<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.picFrog = New System.Windows.Forms.PictureBox()
        Me.picLog = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picFrog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFrog
        '
        Me.picFrog.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picFrog.Location = New System.Drawing.Point(441, 374)
        Me.picFrog.Name = "picFrog"
        Me.picFrog.Size = New System.Drawing.Size(50, 48)
        Me.picFrog.TabIndex = 0
        Me.picFrog.TabStop = False
        '
        'picLog
        '
        Me.picLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picLog.Location = New System.Drawing.Point(413, 237)
        Me.picLog.Name = "picLog"
        Me.picLog.Size = New System.Drawing.Size(219, 55)
        Me.picLog.TabIndex = 1
        Me.picLog.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(490, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picFrog)
        Me.Controls.Add(Me.picLog)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFrog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFrog As PictureBox
    Friend WithEvents picLog As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
