<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstructurasRepetitivas
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
        Me.TxtAcumulado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbNumeros = New System.Windows.Forms.ListBox()
        Me.LblContar = New System.Windows.Forms.Label()
        Me.BtnContar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtAcumulado
        '
        Me.TxtAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcumulado.Location = New System.Drawing.Point(72, 554)
        Me.TxtAcumulado.Multiline = True
        Me.TxtAcumulado.Name = "TxtAcumulado"
        Me.TxtAcumulado.ReadOnly = True
        Me.TxtAcumulado.Size = New System.Drawing.Size(286, 41)
        Me.TxtAcumulado.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 489)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Numeros Acumulado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 99)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Numeros:"
        '
        'lbNumeros
        '
        Me.lbNumeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumeros.FormattingEnabled = True
        Me.lbNumeros.ItemHeight = 22
        Me.lbNumeros.Location = New System.Drawing.Point(72, 153)
        Me.lbNumeros.Name = "lbNumeros"
        Me.lbNumeros.Size = New System.Drawing.Size(286, 312)
        Me.lbNumeros.TabIndex = 13
        '
        'LblContar
        '
        Me.LblContar.AutoSize = True
        Me.LblContar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContar.Location = New System.Drawing.Point(223, -95)
        Me.LblContar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblContar.Name = "LblContar"
        Me.LblContar.Size = New System.Drawing.Size(293, 25)
        Me.LblContar.TabIndex = 12
        Me.LblContar.Text = "Programa que cuenta y acumula"
        '
        'BtnContar
        '
        Me.BtnContar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContar.Location = New System.Drawing.Point(72, 28)
        Me.BtnContar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnContar.Name = "BtnContar"
        Me.BtnContar.Size = New System.Drawing.Size(201, 52)
        Me.BtnContar.TabIndex = 11
        Me.BtnContar.Text = "Contar"
        Me.BtnContar.UseVisualStyleBackColor = True
        '
        'FrmEstructurasRepetitivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 630)
        Me.Controls.Add(Me.TxtAcumulado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbNumeros)
        Me.Controls.Add(Me.LblContar)
        Me.Controls.Add(Me.BtnContar)
        Me.Name = "FrmEstructurasRepetitivas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmEstructurasRepetitivas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtAcumulado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbNumeros As ListBox
    Friend WithEvents LblContar As Label
    Friend WithEvents BtnContar As Button
End Class
