Public Class FrmEstructurasRepetitivas
  Private Sub BtnContar_Click(sender As Object, e As EventArgs) Handles BtnContar.Click

    Dim contador, acumulador, limite As Integer
    contador = 0
    acumulador = 0

    'limite = InputBox("Hasta donde quieres contar?")

    'Do
    '  contador += 1
    '  acumulador = acumulador + contador
    '  MsgBox("Numero: " & contador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Contando")
    '  LtbNumeros.Items.Add(contador)
    'Loop Until (contador >= limite)
    'MsgBox("Numero acumulado: " & acumulador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Acumulado")
    'TxtAcumulado.Text = acumulador

    Do
      contador += 1
      acumulador = acumulador + contador
      MsgBox("Numero: " & contador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Contando")

    Loop While (contador < 5)
    MsgBox("Numero acumulado: " & acumulador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Acumulado")


    'While (contador < 5)
    '  contador += 1
    '  acumulador = acumulador + contador
    '  MsgBox("Numero: " & contador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Contando")
    'End While
    'MsgBox("Numero acumulado: " & acumulador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Acumulado")

    'For i As Integer = 2 To 10 Step 2
    '  acumulador = acumulador + i
    '  LtbNumeros.Items.Add(i)
    'Next
    'TxtAcumulado.Text = acumulador
  End Sub

End Class