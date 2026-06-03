Public Class FrmPSelectiva

  Dim p1 As ClPselectiva

  Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    Dim tipo As Double
    If cbTcliente.Text = "Bronce" Then
      tipo = 0.05
    ElseIf cbTcliente.Text = "Plata" Then
      tipo = 0.1
    ElseIf cbTcliente.Text = "Oro" Then
      tipo = 0.15
    ElseIf cbTcliente.Text = "Platinium" Then
      tipo = 0.2
    End If

    p1 = New ClPselectiva(txtNombre.Text, Val(txtMonto.Text), Val(txtDescuento.Text), Val(txtTotal.Text), tipo)

    Select Case cbTcliente.Text
      Case "Bronce"
        txtDescuento.Text = p1.Desc()
        txtTotal.Text = p1.Tot()
      Case "Plata"
        txtDescuento.Text = p1.Desc()
        txtTotal.Text = p1.Tot()
      Case "Oro"
        txtDescuento.Text = p1.Desc()
        txtTotal.Text = p1.Tot()
      Case "Platinium"
        txtDescuento.Text = p1.Desc()
        txtTotal.Text = p1.Tot()
    End Select

  End Sub

  Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
    p1.Mostrar(cbTcliente.Text, Val(txtTotal.Text))
  End Sub
End Class