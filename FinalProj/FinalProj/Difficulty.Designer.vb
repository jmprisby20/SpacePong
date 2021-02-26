<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Difficulty
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
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnHC = New System.Windows.Forms.Button()
        Me.lblD = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnN
        '
        Me.btnN.BackColor = System.Drawing.Color.Black
        Me.btnN.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnN.ForeColor = System.Drawing.Color.White
        Me.btnN.Location = New System.Drawing.Point(12, 68)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(110, 31)
        Me.btnN.TabIndex = 21
        Me.btnN.Text = "Normal"
        Me.btnN.UseVisualStyleBackColor = False
        '
        'btnHC
        '
        Me.btnHC.BackColor = System.Drawing.Color.Black
        Me.btnHC.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHC.ForeColor = System.Drawing.Color.White
        Me.btnHC.Location = New System.Drawing.Point(12, 105)
        Me.btnHC.Name = "btnHC"
        Me.btnHC.Size = New System.Drawing.Size(110, 31)
        Me.btnHC.TabIndex = 22
        Me.btnHC.Text = "Hardcore"
        Me.btnHC.UseVisualStyleBackColor = False
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.ForeColor = System.Drawing.Color.White
        Me.lblD.Location = New System.Drawing.Point(12, 28)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(115, 13)
        Me.lblD.TabIndex = 23
        Me.lblD.Text = "Difficulty: "
        '
        'Difficulty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(200, 154)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.btnHC)
        Me.Controls.Add(Me.btnN)
        Me.Name = "Difficulty"
        Me.Text = "Difficulty"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnN As System.Windows.Forms.Button
    Friend WithEvents btnHC As System.Windows.Forms.Button
    Friend WithEvents lblD As System.Windows.Forms.Label
End Class
