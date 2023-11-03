Public Class AccountClass
    Private FullName, Gender As String
    Private Age As Integer
    Private height, weight As Double
    Public Property getName As String
        Get
            Return FullName
        End Get
        Set(value As String)
            FullName = value.ToUpper()
        End Set
    End Property
    Public Property getGender As String
        Get
            Return Gender
        End Get
        Set(value As String)
            If value = "FEMALE" Then
                Gender = "FEMALE"
            ElseIf value = "MALE" Then
                Gender = "MALE"
            End If
        End Set
    End Property
    Public Property getAge As Integer
        Get
            Return Age
        End Get
        Set(value As Integer)
            If value < 13 Then
                Age = -1
            ElseIf value > 59 Then
                Age = 0
            Else
                Age = value
            End If
        End Set
    End Property
    Public Overridable Property getHeight As Double
        Get
            Return height
        End Get
        Set(value As Double)
            If value < 1 AndAlso value > 9 Then
                height = 0
            Else
                height = Format(value, "0.00")
            End If
        End Set
    End Property
    Public Overridable Property getWeight As Double
        Get
            Return weight
        End Get
        Set(value As Double)
            If value < 30 Then
                weight = 0
            ElseIf value = Nothing Then
                weight = 0
            Else
                weight = Format(value, "0.00")
            End If
        End Set
    End Property
    Public Function Multiply(input As Double, value As Double) As Double
        input *= value
        Return Format(input, "0.00")
    End Function
    Public Function Divide(input As Double, value As Double) As Double
        input /= value
        Return Format(input, "0.00")
    End Function
End Class
