<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.components = New System.ComponentModel.Container()
        Me.btnmantenimieto = New System.Windows.Forms.Button()
        Me.btndepositos = New System.Windows.Forms.Button()
        Me.btnretiros = New System.Windows.Forms.Button()
        Me.btnconsu_ret = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncrear_cuenta = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnmantenimieto
        '
        Me.btnmantenimieto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmantenimieto.BackColor = System.Drawing.Color.BlueViolet
        Me.btnmantenimieto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmantenimieto.Location = New System.Drawing.Point(564, 289)
        Me.btnmantenimieto.Name = "btnmantenimieto"
        Me.btnmantenimieto.Size = New System.Drawing.Size(125, 24)
        Me.btnmantenimieto.TabIndex = 1
        Me.btnmantenimieto.Text = "Mantenimiento"
        Me.btnmantenimieto.UseVisualStyleBackColor = False
        '
        'btndepositos
        '
        Me.btndepositos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndepositos.BackColor = System.Drawing.Color.BlueViolet
        Me.btndepositos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndepositos.Location = New System.Drawing.Point(564, 209)
        Me.btndepositos.Name = "btndepositos"
        Me.btndepositos.Size = New System.Drawing.Size(125, 24)
        Me.btndepositos.TabIndex = 2
        Me.btndepositos.Text = "Depositos"
        Me.btndepositos.UseVisualStyleBackColor = False
        '
        'btnretiros
        '
        Me.btnretiros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnretiros.BackColor = System.Drawing.Color.BlueViolet
        Me.btnretiros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnretiros.Location = New System.Drawing.Point(564, 176)
        Me.btnretiros.Name = "btnretiros"
        Me.btnretiros.Size = New System.Drawing.Size(125, 24)
        Me.btnretiros.TabIndex = 3
        Me.btnretiros.Text = "Retiros"
        Me.btnretiros.UseVisualStyleBackColor = False
        '
        'btnconsu_ret
        '
        Me.btnconsu_ret.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconsu_ret.BackColor = System.Drawing.Color.BlueViolet
        Me.btnconsu_ret.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsu_ret.Location = New System.Drawing.Point(542, 135)
        Me.btnconsu_ret.Name = "btnconsu_ret"
        Me.btnconsu_ret.Size = New System.Drawing.Size(162, 24)
        Me.btnconsu_ret.TabIndex = 4
        Me.btnconsu_ret.Text = " Registro Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnconsu_ret.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 60
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "SU DINERO ES NUESTRA RESPONSABILIDAD"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SU CONFIANZA, NUESTRO BIENESTAR"
        '
        'btncrear_cuenta
        '
        Me.btncrear_cuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncrear_cuenta.BackColor = System.Drawing.Color.BlueViolet
        Me.btncrear_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear_cuenta.Location = New System.Drawing.Point(564, 247)
        Me.btncrear_cuenta.Name = "btncrear_cuenta"
        Me.btncrear_cuenta.Size = New System.Drawing.Size(125, 24)
        Me.btncrear_cuenta.TabIndex = 10
        Me.btncrear_cuenta.Text = "Crear Cuenta"
        Me.btncrear_cuenta.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.accesoadatos.My.Resources.Resources.dinero22
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 242)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(177, 104)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.accesoadatos.My.Resources.Resources.Bank1
        Me.PictureBox2.Location = New System.Drawing.Point(-8, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(488, 345)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.accesoadatos.My.Resources.Resources.ytr
        Me.PictureBox1.Location = New System.Drawing.Point(5, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(725, 345)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 345)
        Me.Controls.Add(Me.btncrear_cuenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnconsu_ret)
        Me.Controls.Add(Me.btnretiros)
        Me.Controls.Add(Me.btndepositos)
        Me.Controls.Add(Me.btnmantenimieto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Inicio"
        Me.Text = "INICIO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnmantenimieto As System.Windows.Forms.Button
    Friend WithEvents btndepositos As System.Windows.Forms.Button
    Friend WithEvents btnretiros As System.Windows.Forms.Button
    Friend WithEvents btnconsu_ret As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btncrear_cuenta As System.Windows.Forms.Button
End Class
