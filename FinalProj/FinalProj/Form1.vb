Imports System.IO
Public Class Form1
    'Arrays
    Dim Enemies(24) As Enemy
    Dim EnemyPosL(24) As Integer
    Dim EnemyPosT(24) As Integer

    Dim Proj(2) As Projectile
    Dim HSArray(9) As HS
    Dim OuterWalls(3) As PictureBox

    'Single variables
    Dim MyP As Person = New Person
    Dim ExtraLife As Enemy

    Dim enemiesAlive As Integer = 25
    Dim intRN As Integer = 1

    Dim NumOfProjectiles As Integer = 0
    Dim Projectilesleft As Integer = 3

    Dim dblEnemySpeed As Double = 2


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'StreamReader
        Dim fs As New FileStream("HS.txt", FileMode.OpenOrCreate, FileAccess.Read)
        Dim SR As New StreamReader(fs)
        Dim i As Integer

        Do While SR.Peek > -1

            HSArray(i).HSName = SR.ReadLine
            HSArray(i).HsScore = Val(SR.ReadLine)

            i += 1
        Loop
        fs.Close()
        SR.Close()

        

        lblHS.Text = "HighScore: " & HSArray(0).HsScore

        'Hide labels
        Me.Controls.Remove(lblScores)
        Me.Controls.Remove(btnQ)
        Me.Controls.Remove(btnR)

        'Projectile
        For intC As Integer = 0 To Proj.Length - 1
            Proj(intC) = New Projectile

        Next

        'ExtraLife PowerUp
        ExtraLife = New Enemy
        ExtraLife.Height = 12
        ExtraLife.Width = 30
        ExtraLife.Top = 55
        ExtraLife.Left = 150
        ExtraLife.BackgroundImage = My.Resources.Ship
        ExtraLife.BackgroundImageLayout = ImageLayout.Stretch

        Me.Controls.Add(ExtraLife)
        ExtraLife.SetIntHV(4)

        'Player
        MyP.Width = 100
        MyP.Height = 10
        MyP.Top = 510
        MyP.Left = 200
        MyP.SetHealth(3)
        MyP.SetScore(0)
        MyP.BackColor = Color.White

        Me.Controls.Add(MyP)

        lblLives.Text &= MyP.GetHealth
        lblScore.Text &= MyP.GetScore

        'OuterWalls 
        For intC As Integer = 0 To OuterWalls.Length - 1
            OuterWalls(intC) = New PictureBox
            OuterWalls(intC).BackColor = Color.White

            If intC < 2 Then

                OuterWalls(intC).Height = 600
                OuterWalls(intC).Width = 15

                OuterWalls(intC).Left = 0 + (Me.Width - 30) * intC
            Else

                OuterWalls(intC).Height = 15
                OuterWalls(intC).Width = 500
                If intC = 3 Then
                    OuterWalls(intC).Top = Me.Height - 53
                
                End If

            End If

            Me.Controls.Add(OuterWalls(intC))

        Next

        'Enemies
        For intC As Integer = 0 To Enemies.Length - 1
            Enemies(intC) = New Enemy

            Enemies(intC).Height = 20
            Enemies(intC).Width = 20

            Enemies(intC).SetIntHV(2)
            If intC <= 4 Then
                Enemies(intC).Top = 75
                Enemies(intC).Left = 75 + (intC * 80)
            ElseIf intC > 4 And intC <= 9 Then
                Enemies(intC).Top = 125
                Enemies(intC).Left = 75 + (intC * 80) - 400
            ElseIf intC > 9 And intC <= 14 Then
                Enemies(intC).Top = 175
                Enemies(intC).Left = 75 + (intC * 80) - 800
            ElseIf intC > 14 And intC <= 19 Then
                Enemies(intC).Top = 225
                Enemies(intC).Left = 75 + (intC * 80) - 1200
            ElseIf intC > 19 Then
                Enemies(intC).Top = 275
                Enemies(intC).Left = 75 + (intC * 80) - 1600
            End If
            Enemies(intC).setIntWhichImage(1)
            Call EnemyBackimages(My.Resources.enemy1, My.Resources.enemy3, My.Resources.enemy5, intC)

            'Set starting Positions
            EnemyPosL(intC) = Enemies(intC).Left
            EnemyPosT(intC) = Enemies(intC).Top

            Enemies(intC).BackgroundImageLayout = ImageLayout.Stretch

            Me.Controls.Add(Enemies(intC))
        Next

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Player Movement
        If e.KeyCode = 39 Then
            MyP.SetintHV(9)
        ElseIf e.KeyCode = 37 Then
            MyP.SetintHV(-9)
        ElseIf e.KeyCode = 40 Then
            MyP.SetintHV(0)
        End If
        'Creating Projectiles
        If NumOfProjectiles <= 2 And e.KeyCode = 32 Then

            Proj(NumOfProjectiles).Height = 10
            Proj(NumOfProjectiles).Width = 10
            Proj(NumOfProjectiles).Top = 480
            Proj(NumOfProjectiles).Left = MyP.Left + 45
            Proj(NumOfProjectiles).BackgroundImageLayout = ImageLayout.Stretch
            Proj(NumOfProjectiles).BackgroundImage = My.Resources.Ball

            Me.Controls.Add(Proj(NumOfProjectiles))
            Proj(NumOfProjectiles).SetIntVV(8)

            NumOfProjectiles += 1

        End If

    End Sub

    Public Sub tmrTime_Tick(sender As System.Object, e As System.EventArgs) Handles tmrTime.Tick

        'If All of the projectiles are lost then Game Over
        If Projectilesleft = 0 Then
            MyP.SetHealth(0)
        End If

        'Move Player
        MyP.Left += MyP.GetIntHV


        'End Game
        If MyP.GetHealth = 0 Then
            tmrTime.Stop()

            'Hide labels/Player
            Me.Controls.Remove(MyP)
            lblScore.Text = Nothing
            lblLives.Text = Nothing
            lblHS.Text = Nothing
            lblRN.Text = Nothing

            'Move enemies and extra life off screen
            For intC As Integer = 0 To Enemies.Length - 1
                Call MoveEnemiesOffScreen(Enemies(intC))
            Next

            Call MoveEnemiesOffScreen(ExtraLife)

            'Move projectiles off screen
            For intC As Integer = 0 To Proj.Length - 1
                Proj(intC).Left = 750
                Proj(intC).Top = 750
            Next
            'Game over message
            lblGO.Text = "Game Over"
            Call Delay(2.5)
            lblGO.Text = Nothing

            Dim intPlace As Integer
            'Set Players place
            intPlace = GetPlacement(MyP.GetScore)

            'ScoreBoard Code 
            If intPlace <> -1 Then
                MyP.SetName(InputBox("High Score! ", "Please enter your name: "))
                Call UpdateArray(HSArray, intPlace, MyP.GetMyHS)
                Call WriteHS(HSArray)
            End If

            Me.Controls.Add(btnQ)
            Me.Controls.Add(btnR)

            lblEndScores.Text = Space(5) & "High Scores: " & vbCrLf

            Me.Controls.Add(lblScores)
            For intC As Integer = 0 To HSArray.Length - 1

                lblEndScores.Text &= (intC + 1) & "." & HSArray(intC).HSName & vbCrLf
                lblScores.Text &= HSArray(intC).HsScore & vbCrLf

            Next

        End If

        'ExtraLife Movement
        ExtraLife.Left += ExtraLife.GetIntHV

        If ExtraLife.Left < 20 Or ExtraLife.Left > 435 Then
            ExtraLife.SetIntHV(ExtraLife.GetIntHV * -1)
        End If
        For intC As Integer = 0 To Proj.Length - 1
            Proj(intC).Left += Proj(intC).GetIntHV
            Proj(intC).Top += Proj(intC).GetIntVV

            'Collision Between The Projectile and the OuterWalls
            For intW As Integer = 0 To 2

                If Collide(Proj(intC), OuterWalls(intW)) Then
                    If intW < 2 Then
                        Proj(intC).SetIntHV(Proj(intC).GetIntHV * -1)
                    Else
                        Proj(intC).SetIntVV(Proj(intC).GetIntVV * -1)
                    End If

                End If

            Next
            'Projectile collision with bottom wall
            If Collide(Proj(intC), OuterWalls(3)) Then
                Proj(intC).SetIntHV(0)
                Proj(intC).SetIntVV(0)
                Proj(intC).Left = 750
                Proj(intC).Top = 750
                MyP.SetHealth(MyP.GetHealth - 1)
                lblLives.Text = "Lives: " & MyP.GetHealth

                Projectilesleft -= 1

            End If
            'Collision between the extra life and the player's projectile
            If ExtraLife.GetDead = False Then
                If Collide(Proj(intC), ExtraLife) Then
                    ExtraLife.SetIntHV(0)
                    If MyP.GetHealth <= 2 Then
                        MyP.SetHealth(MyP.GetHealth + 1)
                        lblLives.Text = "Lives: " & MyP.GetHealth
                    End If

                    If Start_Up.HardCore = False Then
                        MyP.SetScore(200)
                    ElseIf Start_Up.HardCore = True Then
                        MyP.SetScore(300)
                    End If



                    ExtraLife.SetIsExplosion(True)
                    ExtraLife.SetDead(True)
                    ExtraLife.BackgroundImage = My.Resources.ExplosionSP
                   

                    Proj(intC).SetIntVV(Proj(intC).GetIntVV * -1)
                End If
            End If

            Call Explosion(ExtraLife)

            'Projectile horizontal velocity when colliding with the player
            If Collide(MyP, Proj(intC)) Then
                Proj(intC).SetIntVV(Proj(intC).GetIntVV * -1)

                'Set horizontal direction of the projectile
                If MyP.GetIntHV = 9 Then
                    Proj(intC).SetIntHV(1)
                ElseIf MyP.GetIntHV = -9 Then
                    Proj(intC).SetIntHV(-1)
                ElseIf MyP.GetIntHV = 0 Then
                    Proj(intC).SetIntHV(0)

                End If

            End If

            'collision for projectile and enemies
            For intE As Integer = 0 To Enemies.Length - 1
                If Enemies(intE).GetDead = False Then
                    If Collide(Proj(intC), Enemies(intE)) Then
                        If enemiesAlive > 0 Then
                            Proj(intC).SetIntVV(Proj(intC).GetIntVV * -1)
                            Enemies(intE).SetDead(True)
                            Enemies(intE).SetIsExplosion(True)


                            Enemies(intE).BackgroundImage = My.Resources.Explosion
                          
                            If Start_Up.HardCore = False Then
                                MyP.SetScore(100)
                            ElseIf Start_Up.HardCore = True Then
                                MyP.SetScore(150)
                            End If



                            lblScore.Text = "Score: " & MyP.GetScore

                            enemiesAlive -= 1

                        End If

                    End If

                End If

                'Explosion 

                Call Explosion(Enemies(intE))

                'Enemy BackImages
                If Enemies(intE).GetIsExplosion = False Then
                    Enemies(intE).UpdateIntBackImage(1)
                    If Enemies(intE).GetIntBackImage > 35 Then
                        Enemies(intE).setIntWhichImage(Enemies(intE).GetIntWhichImage * -1)
                        Enemies(intE).UpdateIntBackImage(-34)
                    End If
                    If Enemies(intE).GetIntWhichImage = 1 Then
                        Call EnemyBackimages(My.Resources.enemy1, My.Resources.enemy3, My.Resources.enemy5, intE)
                    ElseIf Enemies(intE).GetIntWhichImage = -1 Then
                        Call EnemyBackimages(My.Resources.enemy2, My.Resources.enemy4, My.Resources.enemy6, intE)
                    End If

                End If

            Next

            'New Round
            If enemiesAlive <= 0 Then
                intRN += 1
                enemiesAlive = 25

                'Enemy speed stops increasing after round 5
                If dblEnemySpeed <= 3 Then
                    dblEnemySpeed += 0.2
                End If

                'HardcoreMode
                If Start_Up.HardCore = False Then

                    NumOfProjectiles = 0
                    Projectilesleft = 3

                ElseIf Start_Up.HardCore = True Then

                    NumOfProjectiles = Projectilesleft - 1
                    If Projectilesleft = 3 Then
                        Projectilesleft = 1
                    ElseIf Projectilesleft = 2 Then
                        Projectilesleft = 2
                    ElseIf Projectilesleft = 1 Then
                        Projectilesleft = 3
                    End If

                End If

                'Move Projectile off screen
                For intP As Integer = 0 To Proj.Length - 1

                    Proj(intP).SetIntVV(0)
                    Proj(intP).SetIntHV(0)
                    Proj(intP).Left = 650
                    Proj(intP).Top = 650

                Next

                'Shows Round Number
                Call Delay(0.5)
                lblGO.Text = "Round " & intRN
                MyP.BackColor = Color.Black
                MyP.Left = 200

                Call Delay(3)
                lblGO.Text = Nothing
                MyP.BackColor = Color.White


                'Reset ExtraLife Position
                ExtraLife.Left = 150
                ExtraLife.Top = 55
                ExtraLife.SetIntHV(4)
                ExtraLife.BackgroundImage = My.Resources.Ship

                'Move Enemies to starting position and changes speed
                For intEA As Integer = 0 To Enemies.Length - 1


                    Enemies(intEA).Left = EnemyPosL(intEA)
                    Enemies(intEA).Top = EnemyPosT(intEA)

                    Enemies(intEA).SetIntHV(dblEnemySpeed)

                Next

                lblRN.Text = "Round: " & intRN
            End If
        Next


        'Collsion with the side walls
        For intWW As Integer = 0 To 1

            'player movement stops when hits side wall
            If Collide(MyP, OuterWalls(intWW)) Then

                MyP.SetintHV(0)
                If intWW = 0 Then
                    MyP.Left = OuterWalls(0).Left + 15
                ElseIf intWW = 1 Then
                    MyP.Left = OuterWalls(1).Left - 100
                End If

            End If
            For intE As Integer = 0 To Enemies.Length - 1
                Enemies(intE).Left += Enemies(intE).GetIntHV

                'Collision between enemies and the side walls
                If Collide(Enemies(intE), OuterWalls(intWW)) Then

                    Enemies(intE).Top += 25
                    Enemies(intE).SetIntHV(Enemies(intE).GetIntHV * -1)
                    If Enemies(intE).Top >= 450 Then
                        MyP.SetHealth(MyP.GetHealth - 1)
                        lblLives.Text = "Lives: " & MyP.GetHealth

                        enemiesAlive -= 1

                        Call MoveEnemiesOffScreen(Enemies(intE))

                    End If
                End If


            Next

        Next


    End Sub

    'Explosion
    Sub Explosion(ByRef Enemy As Enemy)
        If Enemy.GetIsExplosion Then
            Enemy.UpdateIntExp(1)
            If Enemy.GetIntExp > 5 Then
                Call MoveEnemiesOffScreen(Enemy)

                Enemy.UpdateIntExp(-Enemy.GetIntExp)

                Enemy.SetIsExplosion(False)
                Enemy.SetDead(False)
            End If
        End If

    End Sub

    'Changes enemy back image
    Sub EnemyBackimages(ByRef image1 As Image, ByRef image2 As Image, ByRef image3 As Image, ByRef intE As Integer)

        If intE <= 4 Then
            Enemies(intE).BackgroundImage = image1
        ElseIf intE <= 9 Then
            Enemies(intE).BackgroundImage = image2
        ElseIf intE <= 14 Then
            Enemies(intE).BackgroundImage = image2
        ElseIf intE <= 19 Then
            Enemies(intE).BackgroundImage = image3
        Else
            Enemies(intE).BackgroundImage = image3
        End If
    End Sub

    'Collision for objects
    Function Collide(ByRef pb1 As PictureBox, pb2 As PictureBox) As Boolean

        If pb1.Bounds.IntersectsWith(pb2.Bounds) Then
            Return True

        End If

        Return False

    End Function

    'GetPlace 
    Function GetPlacement(ByVal intS As Integer) As Integer
        Dim intP = -1
        For intC As Integer = 0 To HSArray.Length - 1
            If intS > HSArray(intC).HsScore Then
                Return intC
            End If

        Next
        Return intP

    End Function

    'StreamWriter
    Sub WriteHS(ByRef myArray() As HS)
        Dim fs As New FileStream("HS.txt", FileMode.Open, FileAccess.Write)
        Dim SW As New StreamWriter(fs)

        For intC As Integer = 0 To myArray.Length - 1
            SW.WriteLine(HSArray(intC).HSName)
            SW.WriteLine(HSArray(intC).HsScore)
        Next
        SW.Close()
        fs.Close()

    End Sub
    'Update HSArray
    Sub UpdateArray(ByRef myArray() As HS, ByVal NewPlace As Integer, ByRef newHS As HS)

        For intC As Integer = myArray.Length - 1 To NewPlace + 1 Step -1
            myArray(intC) = myArray(intC - 1)

        Next
        myArray(NewPlace) = newHS
    End Sub

    'Moves Enemies Away
    Sub MoveEnemiesOffScreen(ByRef Enemy As Enemy)
        Enemy.Top = 800
        Enemy.Left = 800
        Enemy.SetIntHV(0)
    End Sub

    'New Game
    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        Application.Restart()
    End Sub

    'Close app
    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        Application.Exit()
    End Sub
    

End Class
