<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrabajador
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbPeon = New System.Windows.Forms.RadioButton()
        Me.rbOficial = New System.Windows.Forms.RadioButton()
        Me.rbMaestro = New System.Windows.Forms.RadioButton()
        Me.txtHnormales = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHextras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPextras = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPnormales = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSueldoNeto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat SemiBold", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(84, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 129)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Trabajador"
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(131, 79)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(385, 29)
        Me.txtDni.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(131, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(385, 29)
        Me.txtNombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dni:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbPeon)
        Me.GroupBox5.Controls.Add(Me.rbOficial)
        Me.GroupBox5.Controls.Add(Me.rbMaestro)
        Me.GroupBox5.Font = New System.Drawing.Font("Montserrat SemiBold", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(73, 158)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(188, 162)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Descuento"
        '
        'rbPeon
        '
        Me.rbPeon.AutoSize = True
        Me.rbPeon.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPeon.Location = New System.Drawing.Point(21, 111)
        Me.rbPeon.Name = "rbPeon"
        Me.rbPeon.Size = New System.Drawing.Size(81, 32)
        Me.rbPeon.TabIndex = 4
        Me.rbPeon.TabStop = True
        Me.rbPeon.Text = "Peon"
        Me.rbPeon.UseVisualStyleBackColor = True
        '
        'rbOficial
        '
        Me.rbOficial.AutoSize = True
        Me.rbOficial.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOficial.Location = New System.Drawing.Point(21, 73)
        Me.rbOficial.Name = "rbOficial"
        Me.rbOficial.Size = New System.Drawing.Size(91, 32)
        Me.rbOficial.TabIndex = 3
        Me.rbOficial.TabStop = True
        Me.rbOficial.Text = "Oficial"
        Me.rbOficial.UseVisualStyleBackColor = True
        '
        'rbMaestro
        '
        Me.rbMaestro.AutoSize = True
        Me.rbMaestro.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMaestro.Location = New System.Drawing.Point(21, 35)
        Me.rbMaestro.Name = "rbMaestro"
        Me.rbMaestro.Size = New System.Drawing.Size(109, 32)
        Me.rbMaestro.TabIndex = 2
        Me.rbMaestro.TabStop = True
        Me.rbMaestro.Text = "Maestro"
        Me.rbMaestro.UseVisualStyleBackColor = True
        '
        'txtHnormales
        '
        Me.txtHnormales.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHnormales.Location = New System.Drawing.Point(478, 174)
        Me.txtHnormales.Name = "txtHnormales"
        Me.txtHnormales.Size = New System.Drawing.Size(192, 29)
        Me.txtHnormales.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Horas Normales"
        '
        'txtHextras
        '
        Me.txtHextras.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHextras.Location = New System.Drawing.Point(478, 220)
        Me.txtHextras.Name = "txtHextras"
        Me.txtHextras.Size = New System.Drawing.Size(192, 29)
        Me.txtHextras.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 27)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Horas Extras"
        '
        'txtPextras
        '
        Me.txtPextras.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPextras.Location = New System.Drawing.Point(368, 390)
        Me.txtPextras.Name = "txtPextras"
        Me.txtPextras.Size = New System.Drawing.Size(192, 29)
        Me.txtPextras.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(178, 394)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 27)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Pago Horas Extras"
        '
        'txtPnormales
        '
        Me.txtPnormales.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPnormales.Location = New System.Drawing.Point(368, 344)
        Me.txtPnormales.Name = "txtPnormales"
        Me.txtPnormales.Size = New System.Drawing.Size(192, 29)
        Me.txtPnormales.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(147, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 27)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Pago Horas Normales"
        '
        'txtSueldoNeto
        '
        Me.txtSueldoNeto.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSueldoNeto.Location = New System.Drawing.Point(368, 442)
        Me.txtSueldoNeto.Name = "txtSueldoNeto"
        Me.txtSueldoNeto.Size = New System.Drawing.Size(192, 29)
        Me.txtSueldoNeto.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(232, 446)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 27)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sueldo Total"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnSalir.Font = New System.Drawing.Font("Montserrat ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(478, 506)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(157, 37)
        Me.BtnSalir.TabIndex = 18
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCalcular.Font = New System.Drawing.Font("Montserrat ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(315, 506)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(157, 37)
        Me.BtnCalcular.TabIndex = 17
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNuevo.Font = New System.Drawing.Font("Montserrat ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(152, 506)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(157, 37)
        Me.btnNuevo.TabIndex = 16
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'FrmTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 595)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtSueldoNeto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPextras)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPnormales)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHextras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHnormales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmTrabajador"
        Me.Text = "FrmTrabajador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Protected WithEvents Label2 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbPeon As RadioButton
    Friend WithEvents rbOficial As RadioButton
    Friend WithEvents rbMaestro As RadioButton
    Friend WithEvents txtHnormales As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHextras As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPextras As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPnormales As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSueldoNeto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents btnNuevo As Button
End Class
