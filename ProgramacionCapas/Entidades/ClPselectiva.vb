Public Class ClPselectiva
  Private nombre As String
  Private monto As Double
  Private descuento As Double
  Private total As Double
  Private tipo As Double

  Public Sub New(nombre As String, monto As Double, descuento As Double, total As Double, tipo As Double)
    Me.nombre = nombre
    Me.monto = monto
    Me.descuento = descuento
    Me.total = total
    Me.tipo = tipo
  End Sub

  Public Sub New()

  End Sub

  Public ReadOnly Property Nombre1 As String
    Get
      Return nombre
    End Get
  End Property

  Public ReadOnly Property Monto1 As Double
    Get
      Return monto
    End Get
  End Property

  Public ReadOnly Property Descuento1 As Double
    Get
      Return descuento
    End Get
  End Property

  Public ReadOnly Property Total1 As Double
    Get
      Return total
    End Get
  End Property

  Public ReadOnly Property Tipo1 As Double
    Get
      Return tipo
    End Get
  End Property

  Public Function Desc() As Double
    Return Me.Monto1 * Tipo1
  End Function

  Public Function Tot() As Double
    Return Me.Monto1 - Desc()
  End Function

  Public Function Mostrar(persona As String, tpagar As Double) As String
    Return MsgBox("Nombre: " & Me.Nombre1 &
      vbCrLf & "Total a Pagar: " & tpagar &
      vbCrLf & "Tipo de Persona: " & persona)
  End Function

End Class
