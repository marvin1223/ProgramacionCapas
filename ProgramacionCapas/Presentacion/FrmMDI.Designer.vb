<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMDI
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstructurasSelectivasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstructurasRepetitivasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProyectosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProyectosToolStripMenuItem
        '
        Me.ProyectosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagoToolStripMenuItem, Me.EstructurasSelectivasToolStripMenuItem, Me.EstructurasRepetitivasToolStripMenuItem, Me.TrabajadorToolStripMenuItem})
        Me.ProyectosToolStripMenuItem.Name = "ProyectosToolStripMenuItem"
        Me.ProyectosToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.ProyectosToolStripMenuItem.Text = "Proyectos"
        '
        'PagoToolStripMenuItem
        '
        Me.PagoToolStripMenuItem.Name = "PagoToolStripMenuItem"
        Me.PagoToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.PagoToolStripMenuItem.Text = "Pago"
        '
        'EstructurasSelectivasToolStripMenuItem
        '
        Me.EstructurasSelectivasToolStripMenuItem.Name = "EstructurasSelectivasToolStripMenuItem"
        Me.EstructurasSelectivasToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.EstructurasSelectivasToolStripMenuItem.Text = "Estructuras Selectivas"
        '
        'EstructurasRepetitivasToolStripMenuItem
        '
        Me.EstructurasRepetitivasToolStripMenuItem.Name = "EstructurasRepetitivasToolStripMenuItem"
        Me.EstructurasRepetitivasToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.EstructurasRepetitivasToolStripMenuItem.Text = "Estructuras Repetitivas"
        '
        'TrabajadorToolStripMenuItem
        '
        Me.TrabajadorToolStripMenuItem.Name = "TrabajadorToolStripMenuItem"
        Me.TrabajadorToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.TrabajadorToolStripMenuItem.Text = "Trabajador"
        '
        'FrmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProyectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstructurasSelectivasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstructurasRepetitivasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrabajadorToolStripMenuItem As ToolStripMenuItem
End Class
