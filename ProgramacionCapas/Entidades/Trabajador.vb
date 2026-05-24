Public Class Trabajador
  Private nom As String
  Private dni As String
  Private hnormales As Double
  Private hextras As Double
  Private htrabajador As Double

  Public Sub New(nom As String, dni As String, hnormales As Double, hextras As Double, htrabajador As Double)
    Me.Nom1 = nom
    Me.Dni1 = dni
    Me.Hnormales1 = hnormales
    Me.Hextras1 = hextras
    Me.Htrabajador1 = htrabajador
  End Sub

  Public Sub New()

  End Sub

  Public Property Nom1 As String
    Get
      Return nom
    End Get
    Set(value As String)
      nom = value
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

  Public Property Hnormales1 As Double
    Get
      Return hnormales
    End Get
    Set(value As Double)
      hnormales = value
    End Set
  End Property

  Public Property Hextras1 As Double
    Get
      Return hextras
    End Get
    Set(value As Double)
      hextras = value
    End Set
  End Property

  Public Property Htrabajador1 As Double
    Get
      Return htrabajador
    End Get
    Set(value As Double)
      htrabajador = value
    End Set
  End Property

  Public Function Pnormales() As Double
    Return Hnormales1 * Htrabajador1
  End Function

  Public Function Pextras() As Double
    Return Hextras1 * Htrabajador1 + (Hextras1 * Htrabajador1) * 0.5
  End Function



End Class
