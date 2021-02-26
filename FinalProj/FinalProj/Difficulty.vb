Public Class Difficulty

    Private Sub btnS_Click(sender As System.Object, e As System.EventArgs) Handles btnN.Click
        Start_Up.HardCore = False
        lblD.Text = "Difficulty: Normal"
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnHC.Click
        Start_Up.HardCore = True
        lblD.Text = "Difficulty: Hardcore"
        Me.Hide()
    End Sub

    Private Sub Difficulty_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Start_Up.HardCore = True Then
            lblD.Text = "Difficulty: Hardcore"
        ElseIf Start_Up.HardCore = False Then
            lblD.Text = "Difficulty: Normal"
        End If

    End Sub
End Class