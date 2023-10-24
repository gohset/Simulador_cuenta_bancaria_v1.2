<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deposito
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
        Me.btndesalir = New System.Windows.Forms.Button()
        Me.btndebuscar = New System.Windows.Forms.Button()
        Me.btndeaceptar = New System.Windows.Forms.Button()
        Me.txtdefecha = New System.Windows.Forms.TextBox()
        Me.txtdecedula = New System.Windows.Forms.TextBox()
        Me.txtdesaldo = New System.Windows.Forms.TextBox()
        Me.txtdeapellido = New System.Windows.Forms.TextBox()
        Me.txtdenombre = New System.Windows.Forms.TextBox()
        Me.chkdecorriente = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkdeahorro = New System.Windows.Forms.CheckBox()
        Me.txtdencuenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdesaldo1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndesalir
        '
        Me.btndesalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndesalir.Location = New System.Drawing.Point(265, 264)
        Me.btndesalir.Name = "btndesalir"
        Me.btndesalir.Size = New System.Drawing.Size(97, 23)
        Me.btndesalir.TabIndex = 36
        Me.btndesalir.Text = "Salir"
        Me.btndesalir.UseVisualStyleBackColor = True
        '
        'btndebuscar
        '
        Me.btndebuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndebuscar.Location = New System.Drawing.Point(222, 87)
        Me.btndebuscar.Name = "btndebuscar"
        Me.btndebuscar.Size = New System.Drawing.Size(97, 23)
        Me.btndebuscar.TabIndex = 35
        Me.btndebuscar.Text = "Buscar"
        Me.btndebuscar.UseVisualStyleBackColor = True
        '
        'btndeaceptar
        '
        Me.btndeaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeaceptar.Location = New System.Drawing.Point(147, 264)
        Me.btndeaceptar.Name = "btndeaceptar"
        Me.btndeaceptar.Size = New System.Drawing.Size(97, 23)
        Me.btndeaceptar.TabIndex = 34
        Me.btndeaceptar.Text = "Aceptar"
        Me.btndeaceptar.UseVisualStyleBackColor = True
        '
        'txtdefecha
        '
        Me.txtdefecha.BackColor = System.Drawing.Color.White
        Me.txtdefecha.Location = New System.Drawing.Point(400, 92)
        Me.txtdefecha.Name = "txtdefecha"
        Me.txtdefecha.Size = New System.Drawing.Size(65, 20)
        Me.txtdefecha.TabIndex = 33
        '
        'txtdecedula
        '
        Me.txtdecedula.BackColor = System.Drawing.Color.White
        Me.txtdecedula.Location = New System.Drawing.Point(131, 145)
        Me.txtdecedula.Name = "txtdecedula"
        Me.txtdecedula.Size = New System.Drawing.Size(145, 20)
        Me.txtdecedula.TabIndex = 32
        '
        'txtdesaldo
        '
        Me.txtdesaldo.Location = New System.Drawing.Point(288, 216)
        Me.txtdesaldo.Name = "txtdesaldo"
        Me.txtdesaldo.Size = New System.Drawing.Size(77, 20)
        Me.txtdesaldo.TabIndex = 31
        '
        'txtdeapellido
        '
        Me.txtdeapellido.BackColor = System.Drawing.Color.White
        Me.txtdeapellido.Location = New System.Drawing.Point(372, 176)
        Me.txtdeapellido.Name = "txtdeapellido"
        Me.txtdeapellido.Size = New System.Drawing.Size(166, 20)
        Me.txtdeapellido.TabIndex = 30
        '
        'txtdenombre
        '
        Me.txtdenombre.BackColor = System.Drawing.Color.White
        Me.txtdenombre.Location = New System.Drawing.Point(131, 176)
        Me.txtdenombre.Name = "txtdenombre"
        Me.txtdenombre.Size = New System.Drawing.Size(145, 20)
        Me.txtdenombre.TabIndex = 29
        '
        'chkdecorriente
        '
        Me.chkdecorriente.AutoSize = True
        Me.chkdecorriente.Location = New System.Drawing.Point(442, 143)
        Me.chkdecorriente.Name = "chkdecorriente"
        Me.chkdecorriente.Size = New System.Drawing.Size(68, 17)
        Me.chkdecorriente.TabIndex = 28
        Me.chkdecorriente.Text = "Corriente"
        Me.chkdecorriente.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(388, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Tipo de Cuenta "
        '
        'chkdeahorro
        '
        Me.chkdeahorro.AutoSize = True
        Me.chkdeahorro.Location = New System.Drawing.Point(381, 143)
        Me.chkdeahorro.Name = "chkdeahorro"
        Me.chkdeahorro.Size = New System.Drawing.Size(57, 17)
        Me.chkdeahorro.TabIndex = 26
        Me.chkdeahorro.Text = "Ahorro"
        Me.chkdeahorro.UseVisualStyleBackColor = True
        '
        'txtdencuenta
        '
        Me.txtdencuenta.Location = New System.Drawing.Point(98, 89)
        Me.txtdencuenta.MaxLength = 10
        Me.txtdencuenta.Name = "txtdencuenta"
        Me.txtdencuenta.Size = New System.Drawing.Size(122, 20)
        Me.txtdencuenta.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Nombres"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Cedula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(299, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageKey = "(ninguno)"
        Me.Label1.Location = New System.Drawing.Point(20, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nº Cuenta"
        '
        'txtdesaldo1
        '
        Me.txtdesaldo1.Location = New System.Drawing.Point(129, 216)
        Me.txtdesaldo1.Name = "txtdesaldo1"
        Me.txtdesaldo1.Size = New System.Drawing.Size(77, 20)
        Me.txtdesaldo1.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(344, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Fecha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(201, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 37)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "DEPOSITO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.accesoadatos.My.Resources.Resources._222
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(610, 312)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Saldo"
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(379, 264)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(97, 23)
        Me.btncancelar.TabIndex = 44
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(103, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Escriba la cédula"
        '
        'Deposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(611, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdesaldo1)
        Me.Controls.Add(Me.btndesalir)
        Me.Controls.Add(Me.btndebuscar)
        Me.Controls.Add(Me.btndeaceptar)
        Me.Controls.Add(Me.txtdefecha)
        Me.Controls.Add(Me.txtdecedula)
        Me.Controls.Add(Me.txtdesaldo)
        Me.Controls.Add(Me.txtdeapellido)
        Me.Controls.Add(Me.txtdenombre)
        Me.Controls.Add(Me.chkdecorriente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkdeahorro)
        Me.Controls.Add(Me.txtdencuenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Deposito"
        Me.Text = "Deposito"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btndesalir As System.Windows.Forms.Button
    Friend WithEvents btndebuscar As System.Windows.Forms.Button
    Friend WithEvents btndeaceptar As System.Windows.Forms.Button
    Friend WithEvents txtdefecha As System.Windows.Forms.TextBox
    Friend WithEvents txtdecedula As System.Windows.Forms.TextBox
    Friend WithEvents txtdesaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtdeapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtdenombre As System.Windows.Forms.TextBox
    Friend WithEvents chkdecorriente As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkdeahorro As System.Windows.Forms.CheckBox
    Friend WithEvents txtdencuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdesaldo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
