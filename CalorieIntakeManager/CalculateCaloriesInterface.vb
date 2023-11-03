Public Interface CalculateCaloriesInterface
    Function CalorieFormula(Age As Integer, Gender As String, Height As Double, Weight As Double, ActivityLevel As Double) As Integer
    Function BMIFormula(Weight As Double, Height As Double) As Double
End Interface
