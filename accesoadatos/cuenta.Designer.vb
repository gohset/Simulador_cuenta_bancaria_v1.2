<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contenedor = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btncusalir = New System.Windows.Forms.Button()
        Me.txtcufecha = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbcutipo_cuenta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcucodigo = New System.Windows.Forms.TextBox()
        Me.txtcuncuenta = New System.Windows.Forms.TextBox()
        Me.txtcusaldo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcuid_cliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcucod_cliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcunombre_cli = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcuapellido_cli = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtprueba_id = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.contenedor.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 37)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "CUENTA"
        '
        'contenedor
        '
        Me.contenedor.Controls.Add(Me.DataGridView1)
        Me.contenedor.Location = New System.Drawing.Point(25, 223)
        Me.contenedor.Name = "contenedor"
        Me.contenedor.Size = New System.Drawing.Size(645, 164)
        Me.contenedor.TabIndex = 44
        Me.contenedor.TabStop = False
        Me.contenedor.Visible = False
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 19)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(624, 129)
        Me.DataGridView1.TabIndex = 32
        '
        'btncusalir
        '
        Me.btncusalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncusalir.Location = New System.Drawing.Point(566, 4)
        Me.btncusalir.Name = "btncusalir"
        Me.btncusalir.Size = New System.Drawing.Size(97, 23)
        Me.btncusalir.TabIndex = 95
        Me.btncusalir.Tag = ""
        Me.btncusalir.Text = "Salir"
        Me.btncusalir.UseVisualStyleBackColor = True
        '
        'txtcufecha
        '
        Me.txtcufecha.Location = New System.Drawing.Point(336, 77)
        Me.txtcufecha.Name = "txtcufecha"
        Me.txtcufecha.Size = New System.Drawing.Size(66, 20)
        Me.txtcufecha.TabIndex = 102
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(280, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Fecha"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(123, 185)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(95, 23)
        Me.btnGuardar.TabIndex = 39
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(589, 223)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 40
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(356, 185)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 41
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.Location = New System.Drawing.Point(236, 185)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(95, 23)
        Me.btnactualizar.TabIndex = 42
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(473, 185)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(93, 23)
        Me.btncancelar.TabIndex = 43
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(374, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Tipo Cuenta"
        '
        'cmbcutipo_cuenta
        '
        Me.cmbcutipo_cuenta.FormattingEnabled = True
        Me.cmbcutipo_cuenta.Items.AddRange(New Object() {"Ahorro", "Corriente"})
        Me.cmbcutipo_cuenta.Location = New System.Drawing.Point(472, 149)
        Me.cmbcutipo_cuenta.Name = "cmbcutipo_cuenta"
        Me.cmbcutipo_cuenta.Size = New System.Drawing.Size(71, 21)
        Me.cmbcutipo_cuenta.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Nº Cuenta"
        '
        'txtcucodigo
        '
        Me.txtcucodigo.Location = New System.Drawing.Point(102, 148)
        Me.txtcucodigo.Name = "txtcucodigo"
        Me.txtcucodigo.Size = New System.Drawing.Size(47, 20)
        Me.txtcucodigo.TabIndex = 37
        '
        'txtcuncuenta
        '
        Me.txtcuncuenta.Location = New System.Drawing.Point(237, 149)
        Me.txtcuncuenta.MaxLength = 10
        Me.txtcuncuenta.Name = "txtcuncuenta"
        Me.txtcuncuenta.Size = New System.Drawing.Size(130, 20)
        Me.txtcuncuenta.TabIndex = 45
        '
        'txtcusaldo
        '
        Me.txtcusaldo.Location = New System.Drawing.Point(617, 150)
        Me.txtcusaldo.Name = "txtcusaldo"
        Me.txtcusaldo.Size = New System.Drawing.Size(48, 20)
        Me.txtcusaldo.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(561, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Monto"
        '
        'txtcuid_cliente
        '
        Me.txtcuid_cliente.Location = New System.Drawing.Point(102, 78)
        Me.txtcuid_cliente.MaxLength = 10
        Me.txtcuid_cliente.Name = "txtcuid_cliente"
        Me.txtcuid_cliente.Size = New System.Drawing.Size(100, 20)
        Me.txtcuid_cliente.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Cédula"
        '
        'txtcucod_cliente
        '
        Me.txtcucod_cliente.Location = New System.Drawing.Point(617, 117)
        Me.txtcucod_cliente.Name = "txtcucod_cliente"
        Me.txtcucod_cliente.Size = New System.Drawing.Size(44, 20)
        Me.txtcucod_cliente.TabIndex = 49
        Me.txtcucod_cliente.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(528, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Cod. cliente"
        Me.Label6.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(208, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 22)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtcunombre_cli
        '
        Me.txtcunombre_cli.BackColor = System.Drawing.Color.White
        Me.txtcunombre_cli.Location = New System.Drawing.Point(112, 117)
        Me.txtcunombre_cli.Name = "txtcunombre_cli"
        Me.txtcunombre_cli.ReadOnly = True
        Me.txtcunombre_cli.Size = New System.Drawing.Size(165, 20)
        Me.txtcunombre_cli.TabIndex = 98
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Nombres"
        '
        'txtcuapellido_cli
        '
        Me.txtcuapellido_cli.BackColor = System.Drawing.Color.White
        Me.txtcuapellido_cli.Location = New System.Drawing.Point(355, 117)
        Me.txtcuapellido_cli.Name = "txtcuapellido_cli"
        Me.txtcuapellido_cli.ReadOnly = True
        Me.txtcuapellido_cli.Size = New System.Drawing.Size(172, 20)
        Me.txtcuapellido_cli.TabIndex = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(280, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 16)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Apellidos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(99, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Escriba la cédula"
        '
        'txtprueba_id
        '
        Me.txtprueba_id.Location = New System.Drawing.Point(12, 4)
        Me.txtprueba_id.Name = "txtprueba_id"
        Me.txtprueba_id.Size = New System.Drawing.Size(165, 20)
        Me.txtprueba_id.TabIndex = 105
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.accesoadatos.My.Resources.Resources._222
        Me.PictureBox1.Location = New System.Drawing.Point(1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(682, 260)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 106
        Me.PictureBox1.TabStop = False
        '
        'cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 253)
        Me.ControlBox = False
        Me.Controls.Add(Me.contenedor)
        Me.Controls.Add(Me.btncusalir)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcufecha)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcuapellido_cli)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcunombre_cli)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcusaldo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcucod_cliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbcutipo_cuenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcuncuenta)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtcuid_cliente)
        Me.Controls.Add(Me.txtcucodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtprueba_id)
        Me.Name = "cuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cuenta"
        Me.contenedor.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents contenedor As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btncusalir As System.Windows.Forms.Button
    Friend WithEvents txtcufecha As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbcutipo_cuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcucodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtcuncuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtcusaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcuid_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcucod_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtcunombre_cli As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcuapellido_cli As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtprueba_id As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
