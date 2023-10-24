<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retiros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Retiros))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtrencuenta = New System.Windows.Forms.TextBox()
        Me.chkreahorro = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkrecorriente = New System.Windows.Forms.CheckBox()
        Me.txtrenombre = New System.Windows.Forms.TextBox()
        Me.txtreapellido = New System.Windows.Forms.TextBox()
        Me.txtresaldo = New System.Windows.Forms.TextBox()
        Me.txtrecedula = New System.Windows.Forms.TextBox()
        Me.txtrefecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnreaceptar = New System.Windows.Forms.Button()
        Me.btnrebuscar = New System.Windows.Forms.Button()
        Me.txtresaldo1 = New System.Windows.Forms.TextBox()
        Me.btnresalir = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.accesoadatos.My.Resources.Resources._222
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(590, 305)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nº Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Saldo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(290, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cedula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombres"
        '
        'txtrencuenta
        '
        Me.txtrencuenta.Location = New System.Drawing.Point(129, 87)
        Me.txtrencuenta.MaxLength = 10
        Me.txtrencuenta.Name = "txtrencuenta"
        Me.txtrencuenta.Size = New System.Drawing.Size(115, 20)
        Me.txtrencuenta.TabIndex = 6
        '
        'chkreahorro
        '
        Me.chkreahorro.AutoSize = True
        Me.chkreahorro.Location = New System.Drawing.Point(351, 146)
        Me.chkreahorro.Name = "chkreahorro"
        Me.chkreahorro.Size = New System.Drawing.Size(57, 17)
        Me.chkreahorro.TabIndex = 7
        Me.chkreahorro.Text = "Ahorro"
        Me.chkreahorro.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(364, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tipo de Cuenta "
        '
        'chkrecorriente
        '
        Me.chkrecorriente.AutoSize = True
        Me.chkrecorriente.Location = New System.Drawing.Point(425, 148)
        Me.chkrecorriente.Name = "chkrecorriente"
        Me.chkrecorriente.Size = New System.Drawing.Size(68, 17)
        Me.chkrecorriente.TabIndex = 9
        Me.chkrecorriente.Text = "Corriente"
        Me.chkrecorriente.UseVisualStyleBackColor = True
        '
        'txtrenombre
        '
        Me.txtrenombre.BackColor = System.Drawing.Color.White
        Me.txtrenombre.Location = New System.Drawing.Point(123, 175)
        Me.txtrenombre.Name = "txtrenombre"
        Me.txtrenombre.ReadOnly = True
        Me.txtrenombre.Size = New System.Drawing.Size(145, 20)
        Me.txtrenombre.TabIndex = 10
        '
        'txtreapellido
        '
        Me.txtreapellido.BackColor = System.Drawing.Color.White
        Me.txtreapellido.Location = New System.Drawing.Point(370, 178)
        Me.txtreapellido.Name = "txtreapellido"
        Me.txtreapellido.ReadOnly = True
        Me.txtreapellido.Size = New System.Drawing.Size(168, 20)
        Me.txtreapellido.TabIndex = 11
        '
        'txtresaldo
        '
        Me.txtresaldo.Location = New System.Drawing.Point(287, 212)
        Me.txtresaldo.Name = "txtresaldo"
        Me.txtresaldo.Size = New System.Drawing.Size(77, 20)
        Me.txtresaldo.TabIndex = 12
        '
        'txtrecedula
        '
        Me.txtrecedula.BackColor = System.Drawing.Color.White
        Me.txtrecedula.Location = New System.Drawing.Point(123, 144)
        Me.txtrecedula.Name = "txtrecedula"
        Me.txtrecedula.ReadOnly = True
        Me.txtrecedula.Size = New System.Drawing.Size(145, 20)
        Me.txtrecedula.TabIndex = 13
        '
        'txtrefecha
        '
        Me.txtrefecha.BackColor = System.Drawing.Color.White
        Me.txtrefecha.Location = New System.Drawing.Point(427, 85)
        Me.txtrefecha.Name = "txtrefecha"
        Me.txtrefecha.ReadOnly = True
        Me.txtrefecha.Size = New System.Drawing.Size(66, 20)
        Me.txtrefecha.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(367, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Fecha"
        '
        'btnreaceptar
        '
        Me.btnreaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreaceptar.Location = New System.Drawing.Point(119, 259)
        Me.btnreaceptar.Name = "btnreaceptar"
        Me.btnreaceptar.Size = New System.Drawing.Size(97, 23)
        Me.btnreaceptar.TabIndex = 16
        Me.btnreaceptar.Text = "Aceptar"
        Me.btnreaceptar.UseVisualStyleBackColor = True
        '
        'btnrebuscar
        '
        Me.btnrebuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrebuscar.Location = New System.Drawing.Point(250, 85)
        Me.btnrebuscar.Name = "btnrebuscar"
        Me.btnrebuscar.Size = New System.Drawing.Size(97, 23)
        Me.btnrebuscar.TabIndex = 17
        Me.btnrebuscar.Text = "Buscar"
        Me.btnrebuscar.UseVisualStyleBackColor = True
        '
        'txtresaldo1
        '
        Me.txtresaldo1.Location = New System.Drawing.Point(124, 212)
        Me.txtresaldo1.Name = "txtresaldo1"
        Me.txtresaldo1.Size = New System.Drawing.Size(77, 20)
        Me.txtresaldo1.TabIndex = 18
        '
        'btnresalir
        '
        Me.btnresalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresalir.Location = New System.Drawing.Point(243, 259)
        Me.btnresalir.Name = "btnresalir"
        Me.btnresalir.Size = New System.Drawing.Size(97, 23)
        Me.btnresalir.TabIndex = 19
        Me.btnresalir.Text = "Salir"
        Me.btnresalir.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label9.Location = New System.Drawing.Point(223, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 37)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "RETIROS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(232, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Monto"
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(368, 259)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(97, 23)
        Me.btncancelar.TabIndex = 43
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(126, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Escriba la cédula"
        '
        'Retiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtresaldo1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnresalir)
        Me.Controls.Add(Me.btnrebuscar)
        Me.Controls.Add(Me.btnreaceptar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtrefecha)
        Me.Controls.Add(Me.txtrecedula)
        Me.Controls.Add(Me.txtresaldo)
        Me.Controls.Add(Me.txtreapellido)
        Me.Controls.Add(Me.txtrenombre)
        Me.Controls.Add(Me.chkrecorriente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkreahorro)
        Me.Controls.Add(Me.txtrencuenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Retiros"
        Me.Text = "Retiros"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtrencuenta As System.Windows.Forms.TextBox
    Friend WithEvents chkreahorro As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkrecorriente As System.Windows.Forms.CheckBox
    Friend WithEvents txtrenombre As System.Windows.Forms.TextBox
    Friend WithEvents txtreapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtresaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtrecedula As System.Windows.Forms.TextBox
    Friend WithEvents txtrefecha As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnreaceptar As System.Windows.Forms.Button
    Friend WithEvents btnrebuscar As System.Windows.Forms.Button
    Friend WithEvents txtresaldo1 As System.Windows.Forms.TextBox
    Friend WithEvents btnresalir As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
