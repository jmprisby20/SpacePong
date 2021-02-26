Public Class Buttons

    Private Sub btnM_Click(sender As System.Object, e As System.EventArgs) Handles btnM.Click
        Me.Hide()
        Start_Up.Show()

    End Sub

    Private Sub btnS_Click(sender As System.Object, e As System.EventArgs) Handles btnS.Click

        Me.Hide()
        Form1.Show()
        Form1.tmrTime.Enabled = True

    End Sub

    Private Sub Buttons_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblB.Text =
            "Left = Move Player Left" &
            vbCrLf &
            vbCrLf &
            "Right = Move Player Right" &
            vbCrLf &
            vbCrLf &
            "Down = Stops Player" &
            vbCrLf &
            vbCrLf &
            "Space = Shoot Balls"
    End Sub

   
End Class