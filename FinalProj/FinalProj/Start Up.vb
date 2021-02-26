Public Class Start_Up
    Public HardCore As Boolean
    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        Me.Hide()
        Form1.Show()
        Form1.tmrTime.Enabled = True

    End Sub

    Private Sub btnR_Click(sender As System.Object, e As System.EventArgs) Handles btnR.Click
        Me.Hide()
        Rules.Show()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Buttons.Show()

    End Sub

    Private Sub btnC_Click(sender As System.Object, e As System.EventArgs) Handles btnC.Click
        Application.Exit()

    End Sub

    

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnHC.Click

        Difficulty.Show()

    End Sub
End Class