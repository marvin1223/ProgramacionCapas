Public Class FrmPago
  Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
    Dim p1 As New Pago(txtNombre.Text, txtApellido.Text, txtDni.Text, Val(txtSueldo.Text))

    If rbAfp.Checked = True Then
      txtDafiliacion.Text = p1.Afp().ToString()
    ElseIf rbOnp.Checked = True Then
      txtDafiliacion.Text = p1.Onp().ToString()
    End If



    If chJudicial.Checked = True Then
      txtDjudicial.Text = p1.Judicial()
    End If

    If chPrestamo.Checked = True Then
      txtDprestamo.Text = p1.Prestamo()
    End If

    If chalimento.Checked = True Then
          txtDalimento.Text = p1.Alimento()
        End If

    txtTdescuento.Text = Val(txtDafiliacion.Text) + Val(txtDjudicial.Text) + Val(txtDprestamo.Text) + Val(txtDalimento.Text)

    txtSneto.Text = p1.Sue1 - Val(txtTdescuento.Text)

  End Sub
End Class