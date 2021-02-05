Public Class Enemy
    Inherits PictureBox

    Private intHV As Double

    Private intExp As Integer
    Private IsExplosion As Boolean
    Private Dead As Boolean


    Private intBackImage As Integer
    Private intWhichImage As Integer
    Public Sub setIntWhichImage(ByRef intW As Integer)
        intWhichImage = intW
    End Sub
    Public Function GetIntWhichImage()
        Return intWhichImage
    End Function
    Public Sub UpdateIntBackImage(ByRef intB As Integer)
        intBackImage += intB
    End Sub
    Public Function GetIntBackImage()
        Return intBackImage
    End Function
    Public Sub SetDead(ByRef IsAlive As Boolean)
        Dead = IsAlive
    End Sub
    Public Function GetDead()
        Return Dead
    End Function
    Public Sub UpdateIntExp(ByVal intE As Integer)
        intExp += intE
    End Sub
    Public Function GetIntExp()
        Return intExp
    End Function
    Public Sub SetIsExplosion(ByRef IsTrue As Boolean)
        IsExplosion = IsTrue
    End Sub
    Public Function GetIsExplosion()
        Return IsExplosion
    End Function

    Public Sub SetIntHV(ByVal intH As Double)
        intHV = intH
    End Sub
    Public Function GetIntHV()
        Return intHV
    End Function
End Class
 