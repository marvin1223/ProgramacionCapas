Public Class FrmTrabajador
  Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
    Dim tipoTrabajador As Double
    If rbMaestro.Checked Then
      tipoTrabajador = 30
    ElseIf rbOficial.Checked Then
      tipoTrabajador = 25
    ElseIf rbPeon.Checked Then
      tipoTrabajador = 20
    End If

    Dim t1 As New Trabajador(txtNombre.Text, txtDni.Text, Val(txtHnormales.Text), Val(txtHextras.Text), tipoTrabajador)

    txtPnormales.Text = t1.Pnormales()
    txtPextras.Text = t1.Pextras()

  End Sub
End Class