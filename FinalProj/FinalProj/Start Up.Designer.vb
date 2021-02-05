<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start_Up
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnHC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Console", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(28, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(410, 48)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Pong-Invaders"
        '
        'btnS
        '
        Me.btnS.BackColor = System.Drawing.Color.Black
        Me.btnS.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS.ForeColor = System.Drawing.Color.White
        Me.btnS.Location = New System.Drawing.Point(55, 107)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(328, 42)
        Me.btnS.TabIndex = 10
        Me.btnS.Text = "Start"
        Me.btnS.UseVisualStyleBackColor = False
        '
        'btnR
        '
        Me.btnR.BackColor = System.Drawing.Color.Black
        Me.btnR.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnR.ForeColor = System.Drawing.Color.White
        Me.btnR.Location = New System.Drawing.Point(55, 200)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(328, 42)
        Me.btnR.TabIndex = 11
        Me.btnR.Text = "Rules"
        Me.btnR.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(55, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(328, 42)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Controls"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.Black
        Me.btnC.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ForeColor = System.Drawing.Color.White
        Me.btnC.Location = New System.Drawing.Point(55, 296)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(328, 42)
        Me.btnC.TabIndex = 13
        Me.btnC.Text = "Close"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnHC
        '
        Me.btnHC.BackColor = System.Drawing.Color.Black
        Me.btnHC.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHC.ForeColor = System.Drawing.Color.White
        Me.btnHC.Location = New System.Drawing.Point(55, 155)
        Me.btnHC.Name = "btnHC"
        Me.btnHC.Size = New System.Drawing.Size(328, 42)
        Me.btnHC.TabIndex = 14
        Me.btnHC.Text = "Difficulty"
        Me.btnHC.UseVisualStyleBackColor = False
        '
        'Start_Up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(443, 360)
        Me.Controls.Add(Me.btnHC)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnR)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Start_Up"
        Me.Text = "Start_Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnS As Button
    Friend WithEvents btnR As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnHC As System.Windows.Forms.Button
End Class
