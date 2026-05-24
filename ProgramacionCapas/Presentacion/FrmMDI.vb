Public Class FrmMDI
  Private Sub EstructurasSelectivasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstructurasSelectivasToolStripMenuItem.Click
    FrmSelect.MdiParent = Me
    FrmSelect.Show()
  End Sub

  Private Sub PagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagoToolStripMenuItem.Click
    FrmPago.MdiParent = Me
    FrmPago.Show()
  End Sub

  Private Sub EstructurasRepetitivasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstructurasRepetitivasToolStripMenuItem.Click
    FrmEstructurasRepetitivas.MdiParent = Me
    FrmEstructurasRepetitivas.Show()
  End Sub

  Private Sub TrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrabajadorToolStripMenuItem.Click
    FrmTrabajador.MdiParent = Me
    FrmTrabajador.Show()
  End Sub
End Class