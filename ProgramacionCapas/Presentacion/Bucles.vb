Public Class Bucles
  Private Sub BtnContar_Click(sender As Object, e As EventArgs) Handles BtnContar.Click
    Dim num, cont As Integer
    num = 0
    cont = 0
    Do
      num += 1
      cont = cont + num
      MsgBox("Numero: " & num, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Contando")
      LtbNumeros.Items.Add(num)
    Loop Until (num >= 5)
    MsgBox("Numero acumulado: " & cont, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Acumulado")
    TxtAcumulado.Text = cont

    'Do
    '  num += 1
    '  cont = cont + num
    '  MsgBox("Numero: " & num, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Contando")
    'Loop While (num < 5)
    'MsgBox("Numero acumulado: " & cont, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Acumulado")

    'While (num < 5)
    '  num += 1
    '  cont = cont + num
    '  MsgBox("Numero: " & num, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Contando")
    'End While
    'MsgBox("Numero acumulado: " & cont, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Acumulado")

    'For i As Integer = 2 To 10 Step 2
    '  cont = cont + i
    '  LtbNumeros.Items.Add(i)
    'Next
    'TxtAcumulado.Text = cont
  End Sub
End Class