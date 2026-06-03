<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppMDI
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
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstructurasRepetitivasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrabajadorToolStripMenuItem, Me.EstructurasRepetitivasToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'TrabajadorToolStripMenuItem
        '
        Me.TrabajadorToolStripMenuItem.Name = "TrabajadorToolStripMenuItem"
        Me.TrabajadorToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.TrabajadorToolStripMenuItem.Text = "Trabajador"
        '
        'EstructurasRepetitivasToolStripMenuItem
        '
        Me.EstructurasRepetitivasToolStripMenuItem.Name = "EstructurasRepetitivasToolStripMenuItem"
        Me.EstructurasRepetitivasToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.EstructurasRepetitivasToolStripMenuItem.Text = "Estructuras Repetitivas"
        '
        'frmAppMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAppMDI"
        Me.Text = "Sistema Padre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrabajadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstructurasRepetitivasToolStripMenuItem As ToolStripMenuItem
End Class
