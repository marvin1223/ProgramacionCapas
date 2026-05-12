<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPago
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.rbAfp = New System.Windows.Forms.RadioButton()
        Me.rbOnp = New System.Windows.Forms.RadioButton()
        Me.chJudicial = New System.Windows.Forms.CheckBox()
        Me.chPrestamo = New System.Windows.Forms.CheckBox()
        Me.chalimento = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDafiliacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDjudicial = New System.Windows.Forms.TextBox()
        Me.txtDprestamo = New System.Windows.Forms.TextBox()
        Me.txtDalimento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTdescuento = New System.Windows.Forms.TextBox()
        Me.txtSneto = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat SemiBold", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(78, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Trabajador"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDalimento)
        Me.GroupBox3.Controls.Add(Me.txtDprestamo)
        Me.GroupBox3.Controls.Add(Me.txtDjudicial)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtDafiliacion)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(78, 417)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(553, 161)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSneto)
        Me.GroupBox4.Controls.Add(Me.txtTdescuento)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(209, 602)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(327, 117)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbOnp)
        Me.GroupBox2.Controls.Add(Me.rbAfp)
        Me.GroupBox2.Font = New System.Drawing.Font("Montserrat SemiBold", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(157, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 136)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Afiliación"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chalimento)
        Me.GroupBox5.Controls.Add(Me.chPrestamo)
        Me.GroupBox5.Controls.Add(Me.chJudicial)
        Me.GroupBox5.Font = New System.Drawing.Font("Montserrat SemiBold", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(391, 275)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(188, 136)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Descuento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sueldo:"
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(17, 73)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(185, 29)
        Me.txtDni.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(354, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(226, 29)
        Me.txtNombre.TabIndex = 4
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(354, 79)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(226, 29)
        Me.txtApellido.TabIndex = 5
        '
        'txtSueldo
        '
        Me.txtSueldo.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSueldo.Location = New System.Drawing.Point(166, 200)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(114, 29)
        Me.txtSueldo.TabIndex = 5
        '
        'rbAfp
        '
        Me.rbAfp.AutoSize = True
        Me.rbAfp.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAfp.Location = New System.Drawing.Point(19, 46)
        Me.rbAfp.Name = "rbAfp"
        Me.rbAfp.Size = New System.Drawing.Size(104, 32)
        Me.rbAfp.TabIndex = 0
        Me.rbAfp.TabStop = True
        Me.rbAfp.Text = "AFP 11%"
        Me.rbAfp.UseVisualStyleBackColor = True
        '
        'rbOnp
        '
        Me.rbOnp.AutoSize = True
        Me.rbOnp.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOnp.Location = New System.Drawing.Point(19, 84)
        Me.rbOnp.Name = "rbOnp"
        Me.rbOnp.Size = New System.Drawing.Size(114, 32)
        Me.rbOnp.TabIndex = 1
        Me.rbOnp.TabStop = True
        Me.rbOnp.Text = "ONP 15%"
        Me.rbOnp.UseVisualStyleBackColor = True
        '
        'chJudicial
        '
        Me.chJudicial.AutoSize = True
        Me.chJudicial.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chJudicial.Location = New System.Drawing.Point(20, 35)
        Me.chJudicial.Name = "chJudicial"
        Me.chJudicial.Size = New System.Drawing.Size(103, 32)
        Me.chJudicial.TabIndex = 0
        Me.chJudicial.Text = "Judicial"
        Me.chJudicial.UseVisualStyleBackColor = True
        '
        'chPrestamo
        '
        Me.chPrestamo.AutoSize = True
        Me.chPrestamo.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chPrestamo.Location = New System.Drawing.Point(20, 60)
        Me.chPrestamo.Name = "chPrestamo"
        Me.chPrestamo.Size = New System.Drawing.Size(125, 32)
        Me.chPrestamo.TabIndex = 1
        Me.chPrestamo.Text = "Prestamo"
        Me.chPrestamo.UseVisualStyleBackColor = True
        '
        'chalimento
        '
        Me.chalimento.AutoSize = True
        Me.chalimento.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chalimento.Location = New System.Drawing.Point(20, 85)
        Me.chalimento.Name = "chalimento"
        Me.chalimento.Size = New System.Drawing.Size(119, 32)
        Me.chalimento.TabIndex = 2
        Me.chalimento.Text = "Alimento"
        Me.chalimento.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "D. Afiliación: "
        '
        'txtDafiliacion
        '
        Me.txtDafiliacion.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDafiliacion.Location = New System.Drawing.Point(147, 41)
        Me.txtDafiliacion.Name = "txtDafiliacion"
        Me.txtDafiliacion.Size = New System.Drawing.Size(114, 29)
        Me.txtDafiliacion.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 27)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "D. Judicial: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(296, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 27)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "D. Prestamo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(296, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 27)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "D. Alimento:"
        '
        'txtDjudicial
        '
        Me.txtDjudicial.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDjudicial.Location = New System.Drawing.Point(431, 14)
        Me.txtDjudicial.Name = "txtDjudicial"
        Me.txtDjudicial.Size = New System.Drawing.Size(114, 29)
        Me.txtDjudicial.TabIndex = 10
        '
        'txtDprestamo
        '
        Me.txtDprestamo.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDprestamo.Location = New System.Drawing.Point(431, 53)
        Me.txtDprestamo.Name = "txtDprestamo"
        Me.txtDprestamo.Size = New System.Drawing.Size(114, 29)
        Me.txtDprestamo.TabIndex = 11
        '
        'txtDalimento
        '
        Me.txtDalimento.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDalimento.Location = New System.Drawing.Point(431, 91)
        Me.txtDalimento.Name = "txtDalimento"
        Me.txtDalimento.Size = New System.Drawing.Size(114, 29)
        Me.txtDalimento.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 27)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Total Descuento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 27)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Sueldo Neto:"
        '
        'txtTdescuento
        '
        Me.txtTdescuento.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTdescuento.Location = New System.Drawing.Point(191, 14)
        Me.txtTdescuento.Name = "txtTdescuento"
        Me.txtTdescuento.Size = New System.Drawing.Size(114, 29)
        Me.txtTdescuento.TabIndex = 13
        '
        'txtSneto
        '
        Me.txtSneto.Font = New System.Drawing.Font("Montserrat SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSneto.Location = New System.Drawing.Point(191, 59)
        Me.txtSneto.Name = "txtSneto"
        Me.txtSneto.Size = New System.Drawing.Size(114, 29)
        Me.txtSneto.TabIndex = 15
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNuevo.Font = New System.Drawing.Font("Montserrat ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(133, 735)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(157, 37)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCalcular.Font = New System.Drawing.Font("Montserrat ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(296, 735)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(157, 37)
        Me.BtnCalcular.TabIndex = 7
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnSalir.Font = New System.Drawing.Font("Montserrat ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(459, 735)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(157, 37)
        Me.BtnSalir.TabIndex = 8
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'FrmPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 784)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmPago"
        Me.Text = "FrmPago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label3 As Label
    Protected WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDalimento As TextBox
    Friend WithEvents txtDprestamo As TextBox
    Friend WithEvents txtDjudicial As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDafiliacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rbOnp As RadioButton
    Friend WithEvents rbAfp As RadioButton
    Friend WithEvents chalimento As CheckBox
    Friend WithEvents chPrestamo As CheckBox
    Friend WithEvents chJudicial As CheckBox
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents txtSneto As TextBox
    Friend WithEvents txtTdescuento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnSalir As Button
End Class
