Public Class FoodClass
    Inherits AccountClass
    Implements CalculateCaloriesInterface
    Private food_Search As Integer
    Dim categoryBMI As String
    Public Property foodSearchID As Integer
        Get
            Return food_Search
        End Get
        Set(value As Integer)

            If value >= 0 AndAlso value <= 1000 Then
                food_Search = value
            ElseIf value = Nothing Then
                food_Search = 1
            Else
                food_Search = 0
            End If
        End Set
    End Property
    Public Overrides Property getHeight As Double
        Get
            Return MyBase.getHeight
        End Get
        Set(value As Double)
            If value < 3 Then
                MyBase.getHeight = 0
            ElseIf value > 3 Then
                MyBase.getHeight = -1
            End If
        End Set
    End Property
    Public Overrides Property getWeight As Double
        Get
            Return MyBase.getWeight
        End Get
        Set(value As Double)
            If value < 100 Then
                MyBase.getWeight = 0
            ElseIf value > 100 Then
                MyBase.getWeight = -1
            End If
        End Set
    End Property

    Function CalorieFormula(Age As Integer, Gender As String, Height As Double, Weight As Double, ActivityLevel As Double) As Integer Implements CalculateCaloriesInterface.CalorieFormula
        Dim total As Integer
        If Gender = "MALE" Then
            total = ((10 * Weight) + (6.25 * Height) - (5 * Age) + 5) * ActivityLevel
        ElseIf Gender = "FEMALE" Then
            total = ((10 * Weight) + (6.25 * Height) - (5 * Age) - 161) * ActivityLevel
        End If
        Return total
    End Function

    Function BMIFormula(Weight As Double, Height As Double) As Double Implements CalculateCaloriesInterface.BMIFormula
        Dim BMIOUtput As Double
        Height = Height * Height
        BMIOUtput = Weight / Height
        Return BMIOUtput
    End Function

    Public Property BMICategory As String
        Get
            Return categoryBMI
        End Get
        Set(ByVal value As String)
            If (value < 18.5) Then
                categoryBMI = "Underweight"
            ElseIf (value >= 18.5 And value <= 24.9) Then
                categoryBMI = "Normal Weight"
            ElseIf (value >= 25 And value <= 29.9) Then
                categoryBMI = "Overweight"
            ElseIf (value >= 30) Then
                categoryBMI = "Obese"
            End If
        End Set
    End Property
End Class
