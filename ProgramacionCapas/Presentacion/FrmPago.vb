Public Class FrmPago


  Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

    Dim p1 As New Pago(txtNombre.Text, txtApellido.Text, txtDni.Text, Val(txtSueldo.Text))

    If rbAfp.Checked Then
      txtDafiliacion.Text = p1.Afp()
    ElseIf rbOnp.Checked Then
      txtDafiliacion.Text = p1.Onp()
    End If

    If chJudicial.Checked Then
      txtDjudicial.Text = p1.Judicial()
    End If

    If chPrestamo.Checked Then
      txtDprestamo.Text = p1.Prestamo()
    End If

    If chalimento.Checked Then
      txtDalimento.Text = p1.Alimento()
    End If

    txtTdescuento.Text = Val(txtDafiliacion.Text) + Val(txtDjudicial.Text) + Val(txtDprestamo.Text) + Val(txtDalimento.Text)

    txtSneto.Text = p1.Sue1 - Val(txtTdescuento.Text)

  End Sub

  Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    txtApellido.Clear()
    txtNombre.Clear()
    txtDni.Clear()
    rbAfp.Checked = False
    rbOnp.Checked = False
    chJudicial.Checked = False
    chPrestamo.Checked = False
    chalimento.Checked = False
    txtDafiliacion.Clear()
    txtDjudicial.Clear()
    txtDprestamo.Clear()
    txtDalimento.Clear()
  End Sub

  Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
    Me.Close()
  End Sub

  Private Sub txtDalimento_TextChanged(sender As Object, e As EventArgs) Handles txtDalimento.TextChanged

  End Sub

  Private Sub rbAfp_CheckedChanged(sender As Object, e As EventArgs) Handles rbAfp.CheckedChanged
    If rbAfp.Checked = True Then
      txtDafiliacion.Text = Val(txtSueldo.Text) * 0.11
    Else
      txtDafiliacion.Text = 0.ToString()
    End If
  End Sub

  Private Sub rbOnp_CheckedChanged(sender As Object, e As EventArgs) Handles rbOnp.CheckedChanged
    If rbOnp.Checked = True Then
      txtDafiliacion.Text = Val(txtSueldo.Text) * 0.15
    Else
      txtDafiliacion.Text = 0
    End If
  End Sub

  Private Sub chJudicial_CheckedChanged(sender As Object, e As EventArgs) Handles chJudicial.CheckedChanged
    If chJudicial.Checked = True Then
      txtDjudicial.Text = Val(txtSueldo.Text) * 0.05
    Else
      txtDjudicial.Text = 0
    End If
  End Sub

  Private Sub chPrestamo_CheckedChanged(sender As Object, e As EventArgs) Handles chPrestamo.CheckedChanged
    If chPrestamo.Checked = True Then
      txtDprestamo.Text = Val(txtSueldo.Text) * 0.1
    Else
      txtDprestamo.Text = 0
    End If
  End Sub

  Private Sub chalimento_CheckedChanged(sender As Object, e As EventArgs) Handles chalimento.CheckedChanged
    If chalimento.Checked = True Then
      txtDalimento.Text = Val(txtSueldo.Text) * 0.08
    Else
      txtDalimento.Text = 0
    End If
  End Sub
End Class