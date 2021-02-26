Public Class Projectile
    Inherits PictureBox
    Private intHV As Integer
    Private intVV As Integer
   
    Public Sub SetIntHV(ByVal intH As Integer)
        intHV = intH
    End Sub

    Public Function GetIntHV()
        Return intHV
    End Function

    Public Sub SetIntVV(ByVal intV As Integer)
        intVV = intV
    End Sub
    Public Function GetIntVV()
        Return intVV
    End Function
End Class
