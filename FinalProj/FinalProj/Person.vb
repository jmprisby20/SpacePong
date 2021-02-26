Public Class Person

    Inherits PictureBox


    Private intHV As Integer
    Private MyHs As HS
    Private intHealth As Integer



    Public Function GetMyHS()
        Return MyHs
    End Function

    Public Sub SetintHV(ByVal intV As Integer)

        intHV = intV

    End Sub

    Public Function GetIntHV()

        Return intHV

    End Function

    Public Sub SetHealth(ByVal intH As Integer)

        intHealth = intH

    End Sub

    Public Function GetHealth()

        Return intHealth

    End Function

    Public Sub SetScore(ByVal intS As Integer)

        MyHs.HsScore += intS

    End Sub
    Public Function GetScore()

        Return MyHs.HsScore

    End Function

    Public Sub SetName(ByRef strN As String)

        MyHs.HSName = strN

    End Sub

    Public Function GetName()
        Return MyHs.HSName
    End Function

End Class
