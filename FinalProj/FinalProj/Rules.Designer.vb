<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rules
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
        Me.lblRules = New System.Windows.Forms.Label()
        Me.btnMM = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Lucida Console", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.ForeColor = System.Drawing.Color.White
        Me.lblC.Location = New System.Drawing.Point(383, 31)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(121, 29)
        Me.lblC.TabIndex = 0
        Me.lblC.Text = "Rules:"
        '
        'lblRules
        '
        Me.lblRules.AutoSize = True
        Me.lblRules.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRules.ForeColor = System.Drawing.Color.White
        Me.lblRules.Location = New System.Drawing.Point(12, 72)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(61, 13)
        Me.lblRules.TabIndex = 1
        Me.lblRules.Text = "Rules:"
        '
        'btnMM
        '
        Me.btnMM.BackColor = System.Drawing.Color.Black
        Me.btnMM.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMM.ForeColor = System.Drawing.Color.White
        Me.btnMM.Location = New System.Drawing.Point(705, 567)
        Me.btnMM.Name = "btnMM"
        Me.btnMM.Size = New System.Drawing.Size(110, 31)
        Me.btnMM.TabIndex = 6
        Me.btnMM.Text = "Menu"
        Me.btnMM.UseVisualStyleBackColor = False
        '
        'btnP
        '
        Me.btnP.BackColor = System.Drawing.Color.Black
        Me.btnP.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP.ForeColor = System.Drawing.Color.White
        Me.btnP.Location = New System.Drawing.Point(821, 567)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(110, 31)
        Me.btnP.TabIndex = 7
        Me.btnP.Text = "Start"
        Me.btnP.UseVisualStyleBackColor = False
        '
        'Rules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(943, 610)
        Me.Controls.Add(Me.btnP)
        Me.Controls.Add(Me.btnMM)
        Me.Controls.Add(Me.lblRules)
        Me.Controls.Add(Me.lblC)
        Me.Name = "Rules"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblRules As System.Windows.Forms.Label
    Friend WithEvents btnMM As System.Windows.Forms.Button
    Friend WithEvents btnP As System.Windows.Forms.Button
End Class
