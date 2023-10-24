<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnmancanton = New System.Windows.Forms.Button()
        Me.btnmanprovincia = New System.Windows.Forms.Button()
        Me.btnmancancelar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Elija el formulario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.accesoadatos.My.Resources.Resources.imagen_mantenimiento
        Me.PictureBox1.Location = New System.Drawing.Point(289, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnmancanton
        '
        Me.btnmancanton.Location = New System.Drawing.Point(11, 50)
        Me.btnmancanton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnmancanton.Name = "btnmancanton"
        Me.btnmancanton.Size = New System.Drawing.Size(74, 23)
        Me.btnmancanton.TabIndex = 2
        Me.btnmancanton.Text = "Canton"
        Me.btnmancanton.UseVisualStyleBackColor = True
        '
        'btnmanprovincia
        '
        Me.btnmanprovincia.Location = New System.Drawing.Point(102, 50)
        Me.btnmanprovincia.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnmanprovincia.Name = "btnmanprovincia"
        Me.btnmanprovincia.Size = New System.Drawing.Size(74, 23)
        Me.btnmanprovincia.TabIndex = 3
        Me.btnmanprovincia.Text = "Provincia"
        Me.btnmanprovincia.UseVisualStyleBackColor = True
        '
        'btnmancancelar
        '
        Me.btnmancancelar.Location = New System.Drawing.Point(196, 50)
        Me.btnmancancelar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnmancancelar.Name = "btnmancancelar"
        Me.btnmancancelar.Size = New System.Drawing.Size(74, 23)
        Me.btnmancancelar.TabIndex = 4
        Me.btnmancancelar.Text = "Cancelar"
        Me.btnmancancelar.UseVisualStyleBackColor = True
        '
        'mantenimiento1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 83)
        Me.Controls.Add(Me.btnmancancelar)
        Me.Controls.Add(Me.btnmanprovincia)
        Me.Controls.Add(Me.btnmancanton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "mantenimiento1"
        Me.Text = "Mantenimiento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnmancanton As System.Windows.Forms.Button
    Friend WithEvents btnmanprovincia As System.Windows.Forms.Button
    Friend WithEvents btnmancancelar As System.Windows.Forms.Button
End Class
