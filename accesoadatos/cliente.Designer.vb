<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cliente
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
        Me.contenedor = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbcanton = New System.Windows.Forms.ComboBox()
        Me.cmbprovincia = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnclisalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.contenedor.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'contenedor
        '
        Me.contenedor.Controls.Add(Me.DataGridView1)
        Me.contenedor.Location = New System.Drawing.Point(12, 45)
        Me.contenedor.Name = "contenedor"
        Me.contenedor.Size = New System.Drawing.Size(662, 146)
        Me.contenedor.TabIndex = 93
        Me.contenedor.TabStop = False
        Me.contenedor.Text = "Búsqueda"
        Me.contenedor.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(627, 115)
        Me.DataGridView1.TabIndex = 0
        '
        'cmbcanton
        '
        Me.cmbcanton.FormattingEnabled = True
        Me.cmbcanton.Location = New System.Drawing.Point(271, 82)
        Me.cmbcanton.Name = "cmbcanton"
        Me.cmbcanton.Size = New System.Drawing.Size(121, 21)
        Me.cmbcanton.TabIndex = 88
        '
        'cmbprovincia
        '
        Me.cmbprovincia.FormattingEnabled = True
        Me.cmbprovincia.Location = New System.Drawing.Point(80, 82)
        Me.cmbprovincia.Name = "cmbprovincia"
        Me.cmbprovincia.Size = New System.Drawing.Size(121, 21)
        Me.cmbprovincia.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Provincia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(222, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Cantón"
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(211, 109)
        Me.txtmail.MaxLength = 50
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(150, 20)
        Me.txtmail.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(181, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Mail"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(80, 109)
        Me.txttelefono.MaxLength = 10
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(95, 20)
        Me.txttelefono.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Teléfono"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(469, 82)
        Me.txtdireccion.MaxLength = 50
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(183, 20)
        Me.txtdireccion.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(405, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Dirección"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(339, 56)
        Me.txtapellido.MaxLength = 20
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(125, 20)
        Me.txtapellido.TabIndex = 76
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(523, 56)
        Me.txtnombre.MaxLength = 20
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(129, 20)
        Me.txtnombre.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(466, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Nombres"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(115, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Cédula"
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(172, 53)
        Me.txtcedula.MaxLength = 10
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(95, 20)
        Me.txtcedula.TabIndex = 72
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Código"
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(577, 194)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(60, 23)
        Me.btnbuscar.TabIndex = 70
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(469, 143)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 69
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(322, 143)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 68
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.Location = New System.Drawing.Point(201, 143)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 67
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(85, 143)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 66
        Me.btnGuardar.Text = "Grabar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(279, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "Apellidos"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(66, 53)
        Me.txtcodigo.MaxLength = 7
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(47, 20)
        Me.txtcodigo.TabIndex = 64
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(246, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(156, 31)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "CLIENTES"
        '
        'btnclisalir
        '
        Me.btnclisalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclisalir.Location = New System.Drawing.Point(577, 9)
        Me.btnclisalir.Name = "btnclisalir"
        Me.btnclisalir.Size = New System.Drawing.Size(97, 23)
        Me.btnclisalir.TabIndex = 94
        Me.btnclisalir.Tag = ""
        Me.btnclisalir.Text = "Salir"
        Me.btnclisalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.accesoadatos.My.Resources.Resources._222
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(690, 235)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 220)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclisalir)
        Me.Controls.Add(Me.contenedor)
        Me.Controls.Add(Me.cmbcanton)
        Me.Controls.Add(Me.cmbprovincia)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "cliente"
        Me.Text = "CLIENTE"
        Me.contenedor.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents contenedor As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbcanton As System.Windows.Forms.ComboBox
    Friend WithEvents cmbprovincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnclisalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
