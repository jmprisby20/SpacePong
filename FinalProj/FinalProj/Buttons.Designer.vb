<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buttons
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
        Me.lblC = New System.Windows.Forms.Label()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.lblB = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Lucida Console", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.ForeColor = System.Drawing.Color.White
        Me.lblC.Location = New System.Drawing.Point(169, 22)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(175, 29)
        Me.lblC.TabIndex = 11
        Me.lblC.Text = "Controls:"
        '
        'btnS
        '
        Me.btnS.BackColor = System.Drawing.Color.Black
        Me.btnS.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS.ForeColor = System.Drawing.Color.White
        Me.btnS.Location = New System.Drawing.Point(381, 241)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(110, 31)
        Me.btnS.TabIndex = 20
        Me.btnS.Text = "Start"
        Me.btnS.UseVisualStyleBackColor = False
        '
        'btnM
        '
        Me.btnM.BackColor = System.Drawing.Color.Black
        Me.btnM.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnM.ForeColor = System.Drawing.Color.White
        Me.btnM.Location = New System.Drawing.Point(265, 241)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(110, 31)
        Me.btnM.TabIndex = 21
        Me.btnM.Text = "Menu"
        Me.btnM.UseVisualStyleBackColor = False
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.ForeColor = System.Drawing.Color.White
        Me.lblB.Location = New System.Drawing.Point(12, 84)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(0, 19)
        Me.lblB.TabIndex = 22
        '
        'Buttons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(494, 274)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.btnM)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.lblC)
        Me.Name = "Buttons"
        Me.Text = "Buttons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents btnM As System.Windows.Forms.Button
    Friend WithEvents lblB As System.Windows.Forms.Label
End Class
