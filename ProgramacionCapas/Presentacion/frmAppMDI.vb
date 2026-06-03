Public Class frmAppMDI
  Private Sub TrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrabajadorToolStripMenuItem.Click
    FrmTrabajador.MdiParent = Me
    FrmTrabajador.Show()

  End Sub

  Private Sub EstructurasRepetitivasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstructurasRepetitivasToolStripMenuItem.Click
    FrmEstructurasRepetitivas.MdiParent = Me
    FrmEstructurasRepetitivas.Show()
  End Sub
End Class