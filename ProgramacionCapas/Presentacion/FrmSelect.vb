Public Class FrmSelect
  Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click

    Dim a1 As New ClSelect(cbArea.Text)
    Dim b, a, l As Double

    'If cbArea.Text = "Seleccione Area" Then
    '  MsgBox("Debe selecionar Area", MsgBoxStyle.Critical, "Cuidado")
    '  btnLimpiar.Enabled = False

    'Else

    Select Case a1.Area1
      Case "TRIANGULO"
        b = InputBox("Ingrese la base")
        a = InputBox("Ingrese la altura")
        txtResultado.Text = a1.Triangulo(b, a)
        lbDatos.Items.Add("La base es: " & b)
        lbDatos.Items.Add("La altura es: " & a)

      Case "CUADRADO"
        l = InputBox("Ingrese el lado")
        txtResultado.Text = a1.Cuadrado(l)
        lbDatos.Items.Add("EL lado es: " & l)

      Case "RECTANGULO"
        b = InputBox("Ingrese la base")
        a = InputBox("Ingrese la altura")
        txtResultado.Text = a1.Rectangulo(b, a)
        lbDatos.Items.Add("La base es: " & b)
        lbDatos.Items.Add("La altura es: " & a)

      Case "ROMBO"
        b = InputBox("Ingrese diagonal mayor")
        a = InputBox("Ingrese diagonal menor")
        txtResultado.Text = a1.Rombo(b, a)
        lbDatos.Items.Add("Diagonal mayor: " & b)
        lbDatos.Items.Add("Diagonal menor: " & a)
    End Select
    'btnLimpiar.Enabled = True

    'End If


  End Sub

  Private Sub FrmSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    btnLimpiar.Enabled = False

  End Sub

  Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

  Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
    cbArea.Text = "Seleccione Area"
    lbDatos.Items.Clear()
    txtResultado.Clear()
  End Sub
End Class