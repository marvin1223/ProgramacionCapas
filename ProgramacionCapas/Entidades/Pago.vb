Public Class Pago
  Private nom As String
  Private ape As String
  Private dni As String
  Private sue As Double

  Public Property Nom1 As String
    Get
      Return nom
    End Get
    Set(value As String)
      nom = value
    End Set
  End Property

  Public Property Ape1 As String
    Get
      Return ape
    End Get
    Set(value As String)
      ape = value
    End Set
  End Property

  Public Property Dni1 As String
    Get
      Return dni
    End Get
    Set(value As String)
      dni = value
    End Set
  End Property

  Public Property Sue1 As Double
    Get
      Return sue
    End Get
    Set(value As Double)
      sue = value
    End Set
  End Property

  Public Sub New(nom As String, ape As String, dni As String, sue As Double)
    Me.Nom1 = nom
    Me.Ape1 = ape
    Me.Dni1 = dni
    Me.Sue1 = sue
  End Sub

  Public Sub New()

  End Sub

  Public Function Afp() As Double
    Return Me.Sue1 * 0.11
  End Function

  Public Function Onp() As Double
    Return Me.Sue1 * 0.15
  End Function

  Public Function Judicial() As Double
    Return Me.Sue1 * 0.05
  End Function

  Public Function Prestamo() As Double
    Return Me.Sue1 * 0.1
  End Function

  Public Function Alimento() As Double
    Return Me.Sue1 * 0.08
  End Function


End Class
