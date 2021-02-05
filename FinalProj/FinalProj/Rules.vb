Public Class Rules

    Private Sub Rules_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblRules.Text = "1. The Player goal is to get the highest score they can. " &
            vbCrLf &
            vbCrLf &
            "2. The player will start with three lives and will have three balls which they can use to hit the " & vbCrLf & vbCrLf & "twenty-five enemies in each wave." &
            vbCrLf &
            vbCrLf &
            "3. If a ball hits the top or side walls then it will reflect, but if it hits the bottom wall then" & vbCrLf & vbCrLf & "the player will lose the ball and one life." &
            vbCrLf &
            vbCrLf &
            "4. When a ball hits one of the enemies then player will receive 100 points and the ball will reverse" & vbCrLf & vbCrLf & " it's direction." &
            vbCrLf &
            vbCrLf &
            "5. If the player loses all their balls or has enough enemies reach the bottom then the game will end." &
            vbCrLf &
            vbCrLf &
            "6. If the Player hits the spaceship on the top then they will receive and extra life." &
            vbCrLf &
            vbCrLf &
            "7. When all of the enemies are eliminated a new wave will spawn in." &
            vbCrLf &
            vbCrLf &
            "8. When enemies Hit the side walls they will move farther down, when they reach a certain point they" & vbCrLf & vbCrLf & " will disappear and the player will lose a life." &
            vbCrLf &
            vbCrLf &
            "9. If the player already has three lives and a ball hits the extra life, then the player will " & vbCrLf & vbCrLf & "not receive an extra life." &
            vbCrLf &
            vbCrLf &
            "10. All of the player's balls will be refunded at the beginning of a new round if playing in" & vbCrLf & vbCrLf & " Normal Mode." &
            vbCrLf &
            vbCrLf &
            "11. The enemies speed will increase after every round until round six where after that the speed will " & vbCrLf & vbCrLf & "remain the same." &
            vbCrLf &
            vbCrLf &
            "12. If the player chooses Hard Mode then they will not be refunded balls they lost in previous rounds" & vbCrLf & vbCrLf & " and all points earned will be mulitiplied by 1.5."



            
    End Sub

    Private Sub btnMM_Click(sender As System.Object, e As System.EventArgs) Handles btnMM.Click
        Me.Hide()
        Start_Up.Show()
    End Sub

    Private Sub btnP_Click(sender As System.Object, e As System.EventArgs) Handles btnP.Click

        Me.Hide()
        Form1.Show()
        Form1.tmrTime.Enabled = True
    End Sub


    

End Class