<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblHS = New System.Windows.Forms.Label()
        Me.lblEndScores = New System.Windows.Forms.Label()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.lblGO = New System.Windows.Forms.Label()
        Me.lblScores = New System.Windows.Forms.Label()
        Me.lblRN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrTime
        '
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(37, 552)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(74, 16)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "Score:"
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.BackColor = System.Drawing.Color.Transparent
        Me.lblLives.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.Color.White
        Me.lblLives.Location = New System.Drawing.Point(371, 552)
        Me.lblLives.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(85, 16)
        Me.lblLives.TabIndex = 1
        Me.lblLives.Text = "Lives: "
        '
        'lblHS
        '
        Me.lblHS.AutoSize = True
        Me.lblHS.BackColor = System.Drawing.Color.Transparent
        Me.lblHS.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHS.ForeColor = System.Drawing.Color.White
        Me.lblHS.Location = New System.Drawing.Point(37, 29)
        Me.lblHS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHS.Name = "lblHS"
        Me.lblHS.Size = New System.Drawing.Size(129, 16)
        Me.lblHS.TabIndex = 3
        Me.lblHS.Text = "HighScore: "
        '
        'lblEndScores
        '
        Me.lblEndScores.AutoSize = True
        Me.lblEndScores.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndScores.ForeColor = System.Drawing.Color.White
        Me.lblEndScores.Location = New System.Drawing.Point(55, 29)
        Me.lblEndScores.Name = "lblEndScores"
        Me.lblEndScores.Size = New System.Drawing.Size(0, 27)
        Me.lblEndScores.TabIndex = 4
        '
        'btnR
        '
        Me.btnR.BackColor = System.Drawing.Color.Black
        Me.btnR.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnR.ForeColor = System.Drawing.Color.White
        Me.btnR.Location = New System.Drawing.Point(191, 453)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(94, 31)
        Me.btnR.TabIndex = 5
        Me.btnR.Text = "Restart"
        Me.btnR.UseVisualStyleBackColor = False
        '
        'btnQ
        '
        Me.btnQ.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnQ.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQ.ForeColor = System.Drawing.Color.White
        Me.btnQ.Location = New System.Drawing.Point(191, 490)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(94, 31)
        Me.btnQ.TabIndex = 6
        Me.btnQ.Text = "Quit"
        Me.btnQ.UseVisualStyleBackColor = False
        '
        'lblGO
        '
        Me.lblGO.AutoSize = True
        Me.lblGO.Font = New System.Drawing.Font("Lucida Console", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGO.ForeColor = System.Drawing.Color.White
        Me.lblGO.Location = New System.Drawing.Point(166, 250)
        Me.lblGO.Name = "lblGO"
        Me.lblGO.Size = New System.Drawing.Size(0, 35)
        Me.lblGO.TabIndex = 7
        '
        'lblScores
        '
        Me.lblScores.AutoSize = True
        Me.lblScores.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScores.ForeColor = System.Drawing.Color.White
        Me.lblScores.Location = New System.Drawing.Point(369, 60)
        Me.lblScores.Name = "lblScores"
        Me.lblScores.Size = New System.Drawing.Size(0, 27)
        Me.lblScores.TabIndex = 8
        '
        'lblRN
        '
        Me.lblRN.AutoSize = True
        Me.lblRN.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRN.ForeColor = System.Drawing.Color.White
        Me.lblRN.Location = New System.Drawing.Point(371, 29)
        Me.lblRN.Name = "lblRN"
        Me.lblRN.Size = New System.Drawing.Size(96, 16)
        Me.lblRN.TabIndex = 9
        Me.lblRN.Text = "Round: 1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(500, 601)
        Me.Controls.Add(Me.lblRN)
        Me.Controls.Add(Me.lblScores)
        Me.Controls.Add(Me.lblGO)
        Me.Controls.Add(Me.btnQ)
        Me.Controls.Add(Me.btnR)
        Me.Controls.Add(Me.lblEndScores)
        Me.Controls.Add(Me.lblHS)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblScore)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.Text = "Pong-Invaders"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents lblHS As Label
    Friend WithEvents lblEndScores As Label
    Friend WithEvents btnR As Button
    Friend WithEvents btnQ As Button
    Friend WithEvents lblGO As Label
    Friend WithEvents lblScores As Label
    Friend WithEvents lblRN As Label
End Class
