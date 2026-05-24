<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bucles
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
        Me.BtnContar = New System.Windows.Forms.Button()
        Me.LblContar = New System.Windows.Forms.Label()
        Me.LtbNumeros = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAcumulado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnContar
        '
        Me.BtnContar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContar.Location = New System.Drawing.Point(149, 78)
        Me.BtnContar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnContar.Name = "BtnContar"
        Me.BtnContar.Size = New System.Drawing.Size(201, 52)
        Me.BtnContar.TabIndex = 5
        Me.BtnContar.Text = "Contar"
        Me.BtnContar.UseVisualStyleBackColor = True
        '
        'LblContar
        '
        Me.LblContar.AutoSize = True
        Me.LblContar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContar.Location = New System.Drawing.Point(82, 21)
        Me.LblContar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblContar.Name = "LblContar"
        Me.LblContar.Size = New System.Drawing.Size(355, 31)
        Me.LblContar.TabIndex = 6
        Me.LblContar.Text = "Programa que cuenta y acumula"
        '
        'LtbNumeros
        '
        Me.LtbNumeros.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtbNumeros.FormattingEnabled = True
        Me.LtbNumeros.ItemHeight = 28
        Me.LtbNumeros.Location = New System.Drawing.Point(104, 237)
        Me.LtbNumeros.Name = "LtbNumeros"
        Me.LtbNumeros.Size = New System.Drawing.Size(286, 312)
        Me.LtbNumeros.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 188)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Numeros:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 573)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Numeros Acumulado:"
        '
        'TxtAcumulado
        '
        Me.TxtAcumulado.Font = New System.Drawing.Font("Montserrat ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcumulado.Location = New System.Drawing.Point(104, 620)
        Me.TxtAcumulado.Multiline = True
        Me.TxtAcumulado.Name = "TxtAcumulado"
        Me.TxtAcumulado.ReadOnly = True
        Me.TxtAcumulado.Size = New System.Drawing.Size(97, 41)
        Me.TxtAcumulado.TabIndex = 10
        '
        'Bucles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 712)
        Me.Controls.Add(Me.TxtAcumulado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LtbNumeros)
        Me.Controls.Add(Me.LblContar)
        Me.Controls.Add(Me.BtnContar)
        Me.Name = "Bucles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bucles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnContar As Button
    Friend WithEvents LblContar As Label
    Friend WithEvents LtbNumeros As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAcumulado As TextBox
End Class
