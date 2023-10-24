Imports System.Data.OleDb
Public Class cliente
    Public atrasimagen As Byte
    Dim comandos As OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        conectar()
        provincia()
        canton()
        ' cuentaset()

        Label10.Parent = PictureBox1
        Label11.Parent = PictureBox1
        Label14.Parent = PictureBox1
        Label15.Parent = PictureBox1
        Label16.Parent = PictureBox1
        Label17.Parent = PictureBox1
        Label4.Parent = PictureBox1
        Label5.Parent = PictureBox1
        Label7.Parent = PictureBox1
        Label8.Parent = PictureBox1

        Label10.BackColor = Color.Transparent
        Label11.BackColor = Color.Transparent
        Label14.BackColor = Color.Transparent
        Label15.BackColor = Color.Transparent
        Label16.BackColor = Color.Transparent
        Label17.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label8.BackColor = Color.Transparent

    End Sub


    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        txtcodigo.Text = registro.Tables("datos").Rows(0).Item("codigo")
        txtApellido.Text = registro.Tables("datos").Rows(0).Item("apellido")
        TxtNombre.Text = registro.Tables("datos").Rows(0).Item("nombre")
        txtcedula.Text = registro.Tables("datos").Rows(0).Item("cedula")
        'txtncuenta.Text = registro.Tables("datos").Rows(0).Item("nucuenta")

        contenedor.Visible = False
    End Sub


    Sub limpiar_caja()
        txtcodigo.Clear()
        txtcedula.Clear()
        txtapellido.Clear()
        txtnombre.Clear()
        txtdireccion.Clear()
        txttelefono.Clear()
        txtmail.Clear()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
        limpiar_caja()
        txtcodigo.Enabled = True
        
    End Sub


    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ ESTE PROCEDIMIENTO ES LLAMADO DESDE EL LOAD \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Sub provincia()
        Dim consulta As String
        Dim dt As DataTable = New DataTable("tb_provincia")

        consulta = "select * from tb_provincia "
        adaptador = New OleDbDataAdapter(consulta, conexion)
        'registro = New DataSetcmbpais.DisplayMember = "nombre_pais"
        cmbprovincia.ValueMember = "provincia"
        adaptador.Fill(dt)
        cmbprovincia.DataSource = dt

    End Sub
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ ESTE PROCEDIMIENTO ES LLAMADO DESDE EL LOAD \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Sub canton()
        Dim consulta As String
        Dim dt As DataTable = New DataTable("tb_canton")

        consulta = "select * from tb_canton "
        adaptador = New OleDbDataAdapter(consulta, conexion)
        'registro = New DataSetcmbcanton.DisplayMember = "nombre_pais"
        cmbcanton.ValueMember = "canton"
        adaptador.Fill(dt)
        cmbcanton.DataSource = dt

    End Sub
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ PROCEDIMIENTO PARA [GUARDAR] \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Public Sub accion() '-----------------------PARA PODER LLAMAR ES FUNCION O PROCESO DESDE CUALCLIER [FORMULARIO]--------------
        '--------------------------------------------+++Y HACE REFERENCIA AL BOTON [[[[[[[[ *GUARDAR *]]]]]]]]]]
        ' Dim consulta1 As String
        'Dim respuesta As Byte
        'respuesta = MsgBox("Debe activar su cuenta", vbYesNo, "Activación")
        'If respuesta = vbYes Then
        Try
            comandos = New OleDbCommand("INSERT INTO datos (codigo,cedula,apellido,nombre,provincia,canton,direccion,telefono,mail)VALUES(txtcodigo,Txtcedula,Txtnombre,txtapellido,cmbprovincia,cmbcanton,txtdireccion,txttelefono,txtmail)", conexion)
            comandos.Parameters.AddWithValue("@codigo", txtcodigo.Text)
            comandos.Parameters.AddWithValue("@cedula", txtcedula.Text)
            comandos.Parameters.AddWithValue("@apellido", txtapellido.Text)
            comandos.Parameters.AddWithValue("@nombre", txtnombre.Text)
            comandos.Parameters.AddWithValue("@canton", cmbcanton.Text) '******** Se guarda nadamas el indice ****
            comandos.Parameters.AddWithValue("@provincia", cmbprovincia.Text)
            comandos.Parameters.AddWithValue("@direccion", txtdireccion.Text)
            comandos.Parameters.AddWithValue("@telefono", txttelefono.Text)
            comandos.Parameters.AddWithValue("@mail", txtmail.Text)
            comandos.ExecuteNonQuery()


            'cuenta.Show()

            MsgBox("** Datos guardados correctamente **")
            limpiar_caja()
            'conexion.Close()

        Catch ex As Exception
            ' MsgBox(ex.ToString)
            MsgBox("** Error Datos duplicados ***")
        End Try

        'End If

    End Sub
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Sub actualizarguardar() '-------------No utilizado aun
        Try
            Dim consulta2 As String

            consulta2 = "update datos set nombre='" & txtnombre.Text & "',apellido='" & txtapellido.Text & "',direccion='" & txtdireccion.Text & "',telefono='" & txttelefono.Text & "',mail='" & txtmail.Text & "' where cedula='" & txtcedula.Text & "'"
            comandos = New OleDbCommand(consulta2, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Datos Actualizados")

            limpiar_caja()
        Catch ex As Exception
            MsgBox("error al actualizar")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Call accion()
        'Call actualizarguardar()

        'cuenta.Show() 'LLAMO AL * FORMULARIO [CUENTA] *...........Y LUEGO QUE GUARDE LOS CAMBIOS EN ESTE FORMULARIO....SE GUARDARA
        '--------------TODO LO QUE HALLA ESCRITO EN EL FORMULARIO [[[[[[[ * CLIENTE * ]]]]]]]]-------------
    End Sub


    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click

        
        Try
            Dim buscar As String
            Dim consulta As String
            Dim lista As Byte
            buscar = InputBox("Ingrese el apellido")
            If buscar <> "" Then '------------------------------------------------------ > MODIFICADO por [CEDULA]
                consulta = "SELECT * FROM datos WHERE apellido like '" & buscar & "%'"
                adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
                registro = New DataSet
                adaptador.Fill(registro, "datos")
                lista = registro.Tables("datos").Rows.Count

            Else

                MsgBox("Error")
            End If
            If lista <> 0 Then
                'contenedor.Left = 6
                'contenedor.Top = 8
                DataGridView1.DataSource = registro
                DataGridView1.DataMember = "datos"

            Else
                'atrasimagen = IsMirrored = False
                'contenedor.Visible = atrasimagen
                'contenedor.Top = -160 'COORDENADAS...Para poder sacar el [DataGridView1]....cuando el numero de cedula no cea correcta
                'DataGridView1.Update()
                'DataGridView1.ClearSelection()
                MsgBox("** El APELLIDO que solicita no se encuentra... **") '*********** Por si se ingresa mal el Nº de cedula^^????
                limpiar_caja()
            End If
            contenedor.Visible = True
            
        Catch ex As Exception
            MsgBox("**< El APELLIDO que solicita no se encuentra... **")
        End Try
    End Sub


    Private Sub DataGridView1_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick


        txtcodigo.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
        txtcedula.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        txtapellido.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
        txtnombre.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString
        cmbprovincia.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString
        cmbcanton.Text = DataGridView1.CurrentRow.Cells.Item(5).Value.ToString
        txtdireccion.Text = DataGridView1.CurrentRow.Cells.Item(6).Value.ToString
        txttelefono.Text = DataGridView1.CurrentRow.Cells.Item(7).Value.ToString
        txtmail.Text = DataGridView1.CurrentRow.Cells.Item(8).Value.ToString
        contenedor.Visible = False

        


    End Sub


    Private Sub btneliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim consulta1 As String
        Dim respuesta As Byte
        respuesta = MsgBox("Esta seguro deeliminar", vbYesNo, "eliminar")
        Try
            If respuesta = vbYes Then
                consulta1 = "delete * from datos where codigo=" & txtcodigo.Text & ""
                comandos = New OleDbCommand(consulta1, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("registro eliminado")
                'DataGridView1.Update()  '*********** Permite actualizarlo despues de borrar un dato*****???????????????????????.........................
                limpiar_caja()
            End If
        Catch ex As Exception
            MsgBox(ex.TargetSite)
        End Try
       
    End Sub

   
    Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactualizar.Click
        'cuenta.Show()
        'Dim lista As Byte
        'registro = New DataSet
        'adaptador.Fill(registro, "datos")
        'lista = registro.Tables("datos").Rows.Count
        'DataGridView1.DataSource = registro
        'DataGridView1.DataMember = "datos"

        Try
            Dim consulta2 As String

            consulta2 = "update datos set nombre='" & txtnombre.Text & "',apellido='" & txtapellido.Text & "',direccion='" & txtdireccion.Text & "',telefono='" & txttelefono.Text & "',mail='" & txtmail.Text & "',provincia='" & cmbprovincia.Text & "',canton='" & cmbcanton.Text & "' where CODIGO=" & txtcodigo.Text & ""
            comandos = New OleDbCommand(consulta2, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Datos Actualizados")

            limpiar_caja()
        Catch ex As Exception
            MsgBox("error al actualizar")
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub btnclisalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclisalir.Click
        Me.Close()
        conexion.Close()
    End Sub


    Private Sub btncancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        limpiar_caja()
    End Sub
End Class
