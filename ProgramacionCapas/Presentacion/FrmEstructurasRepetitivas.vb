Public Class FrmEstructurasRepetitivas
  Private Sub BtnContar_Click(sender As Object, e As EventArgs) Handles BtnContar.Click

    Dim contador, acumulador, limite, mult, a As Integer
    contador = 0
    acumulador = 0


    limite = InputBox("hasta donde quieres contar?")

    'Do
    '  contador += 1
    '  acumulador = acumulador + contador
    '  MsgBox("Numero: " & contador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Contando")
    '  LtbNumeros.Items.Add(contador)
    'Loop Until (contador >= limite)
    'MsgBox("Numero acumulado: " & acumulador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Acumulado")
    'TxtAcumulado.Text = acumulador

    'Do
    '  contador += 1
    '  acumulador = acumulador + contador
    '  MsgBox("Numero: " & contador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Contando")
    '  lbNumeros.Items.Add(contador)

    'Loop While (contador < 5)
    'MsgBox("Numero acumulado: " & acumulador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Acumulado")
    'TxtAcumulado.Text = acumulador


    While (contador < limite)
      contador += 2
      acumulador = acumulador + contador
      MsgBox("Numero: " & contador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Contando")
      lbNumeros.Items.Add(contador)
    End While
    MsgBox("Numero acumulado: " & acumulador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Acumulado")
    TxtAcumulado.Text = acumulador
    'a = InputBox("INGRESAR EL NUMERO QUE QUIERE MULTIPLICAR")

    'For i As Integer = 1 To 12
    '  mult = a * i
    '  acumulador = acumulador + a * i
    '  lbNumeros.Items.Add(a & " x " & i & " = " & mult)
    '  MsgBox("Numero: " & i, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Contando")
    'Next
    'MsgBox("Numero acumulado: " & acumulador, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Acumulado")
    'TxtAcumulado.Text = acumulador
  End Sub

End Class