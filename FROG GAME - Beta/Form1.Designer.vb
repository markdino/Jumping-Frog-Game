﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.picLag1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picLag2 = New System.Windows.Forms.PictureBox()
        CType(Me.picFrog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLag1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLag2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'picLag1
        '
        Me.picLag1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picLag1.Location = New System.Drawing.Point(413, 237)
        Me.picLag1.Name = "picLag1"
        Me.picLag1.Size = New System.Drawing.Size(219, 55)
        Me.picLag1.TabIndex = 1
        Me.picLag1.TabStop = False
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
        'picLag2
        '
        Me.picLag2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picLag2.Location = New System.Drawing.Point(468, 176)
        Me.picLag2.Name = "picLag2"
        Me.picLag2.Size = New System.Drawing.Size(219, 55)
        Me.picLag2.TabIndex = 1
        Me.picLag2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picFrog)
        Me.Controls.Add(Me.picLag2)
        Me.Controls.Add(Me.picLag1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFrog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLag1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLag2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFrog As PictureBox
    Friend WithEvents picLag1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents picLag2 As PictureBox
End Class
