Public Class ClSelect

  Private area As String

  Public Sub New(area As String)
    Me.Area1 = area

  End Sub

  Public Sub New()

  End Sub

  Public Property Area1 As String
    Get
      Return area
    End Get
    Set(value As String)
      area = value
    End Set
  End Property



  Public Function Triangulo(a As Double, b As Double) As Double
    Return (a * b) / 2
  End Function
  Public Function Cuadrado(a As Double) As Double
    Return a ^ 2
  End Function
  Public Function Rectangulo(a As Double, b As Double) As Double
    Return a * b
  End Function
  Public Function Rombo(a As Double, b As Double) As Double
    Return (a * b) / 2
  End Function


End Class
