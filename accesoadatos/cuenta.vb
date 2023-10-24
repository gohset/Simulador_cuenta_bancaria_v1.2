Imports System.Data.OleDb
Public Class cuenta
    Public setoga10, setoga11 As String
    Public atrasimagen As Byte
    Dim comandos As OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet
    Private Sub cuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcufecha.Text = Date.Now.ToLocalTime

        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Label4.Parent = PictureBox1
        Label5.Parent = PictureBox1
        Label6.Parent = PictureBox1
        Label7.Parent = PictureBox1
        Label8.Parent = PictureBox1
        Label9.Parent = PictureBox1
        Label11.Parent = PictureBox1
        Label10.Parent = PictureBox1
        ' contenedor.Parent = PictureBox1

        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label8.BackColor = Color.Transparent
        Label9.BackColor = Color.Transparent
        Label10.BackColor = Color.Transparent
        Label11.BackColor = Color.Transparent
        ' contenedor.BackColor = Color.Transparent


        conectar()

        'txtcucod_cliente.Text = cliente.txtcodigo.Text
        'txtcuid_cliente.Text = cliente.txtcedula.Text
        'cmbcutipo_cuenta.SelectedIndex = 0
        'cmbcutipo_cuenta.SelectedIndex = 1

        'Dim setga1 As New OleDb.OleDbCommand("select * from cuenta where id_cliente='" & cliente.txtcedula.Text & "'", conexion)
        'Dim dr As OleDb.OleDbDataReader
        'dr = setga1.ExecuteReader
        'If dr.Read Then
        '    txtcucodigo.Text = dr(0)
        '    txtcuncuenta.Text = dr(3)
        '    If cmbcutipo_cuenta.SelectedIndex = 1 Then
        '        cmbcutipo_cuenta.Text = dr(5)
        '        txtcusaldo.Text = dr(7)
        '    ElseIf cmbcutipo_cuenta.SelectedIndex = 0 Then
        '        cmbcutipo_cuenta.Text = dr(4)
        '        txtcusaldo.Text = dr(6)
        '    End If

        '    'cmbcutipo_cuenta.Text = dr(5)
        '    'setga2()
        '    'If cmbcutipo_cuenta.Text = dr(5) Then
        '    'setoga3()
        'End If

        'End If
    End Sub

    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ AUN NO SE ENCUENTRA DERTRO DE NINGUNA CONDICION O [BOTON] \\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Sub setga2()
        Dim setga1 As New OleDb.OleDbCommand("select * from cuenta where id_cliente='" & cliente.txtcedula.Text & "'", conexion)
        Dim dr As OleDb.OleDbDataReader
        Dim setoga1, setoga2 As String

        setoga1 = "Ahorro"
        setoga2 = "Corriente"


        dr = setga1.ExecuteReader
        If dr.Read Then
            If cmbcutipo_cuenta.SelectedIndex = 0 Then
                txtcucodigo.Text = dr(0)
                txtcuncuenta.Text = dr(3)
                cmbcutipo_cuenta.Text = dr(4)
                'cmbcutipo_cuenta.Text = dr(5)
                txtcusaldo.Text = dr(6)
                'txtcusaldo.Text = dr(7)

            End If
            If cmbcutipo_cuenta.SelectedIndex = 1 Then
                txtcucodigo.Text = dr(0)
                txtcuncuenta.Text = dr(3)
                ' cmbcutipo_cuenta.Text = dr(4)
                cmbcutipo_cuenta.Text = dr(5)
                ' txtcusaldo.Text = dr(6)
                txtcusaldo.Text = dr(7)
            End If

        End If

    End Sub
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    Sub limpiarset()
        cliente.txtcodigo.Clear()
        cliente.txtcedula.Clear()
        cliente.txtapellido.Clear()
        cliente.txtnombre.Clear()
        cliente.txtdireccion.Clear()
        cliente.txttelefono.Clear()
        cliente.txtmail.Clear()
    End Sub

    Sub limpiar()
        txtcucodigo.Clear()
        txtcucod_cliente.Clear()
        txtcuid_cliente.Clear()
        txtcunombre_cli.Clear()
        txtcuapellido_cli.Clear()
        txtcuncuenta.Clear()
        txtcusaldo.Clear()
        'cmbcutipo_cuenta.Text = cmbcutipo_cuenta.Text = ""
    End Sub


    Private Sub btnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim setoga1, setoga2 As String

        setoga1 = "Ahorro"
        setoga2 = "Corriente"

        If cmbcutipo_cuenta.Text = setoga1 Then
            Try
                Dim set1 As New OleDb.OleDbCommand("select * from cuenta where id_cliente='" & txtcuid_cliente.Text & "'", conexion)
                Dim dr As OleDb.OleDbDataReader
                'conexion.Open()
                Dim mostrar1 As Byte

                dr = set1.ExecuteReader
                If dr.Read Then
                    txtprueba_id.Text = dr(2)
                    'Else
                    '    MsgBox("** ERROR **")
                End If
                If txtprueba_id.Text = txtcuid_cliente.Text Then
                    mostrar1 = MsgBox("Estimado usuario, se le recuerda que ya tiene activa una cuenta _ Desea crear otra", vbYesNo, "<< Ya tiene una Cuenta >>")
                   
                    If vbYes Then
                        comandos = New OleDbCommand("INSERT INTO cuenta(codigo,cod_cliente,id_cliente,ncuenta,tipo_cuenta_ahorro,saldo_ahorro,fecha)VALUES(txtcucodigo,txtcucod_cliente,txtcuid_cliente,txtcuncuenta,cmbcutipo_cuenta,txtcusaldo,txtcufecha)", conexion)
                        comandos.Parameters.AddWithValue("@codigo", txtcucodigo.Text)
                        comandos.Parameters.AddWithValue("@cod_cliente", txtcucod_cliente.Text)
                        comandos.Parameters.AddWithValue("@id_cliente", txtcuid_cliente.Text)
                        comandos.Parameters.AddWithValue("@ncuenta", txtcuncuenta.Text)
                        comandos.Parameters.AddWithValue("@tipo_cuenta_ahorro", cmbcutipo_cuenta.Text)
                        comandos.Parameters.AddWithValue("@saldo_ahorro", txtcusaldo.Text)
                        comandos.Parameters.AddWithValue("@fecha", txtcufecha.Text)

                        comandos.ExecuteNonQuery()
                        MsgBox("Datos guardados")
                        limpiar()
                        txtcucodigo.Clear()
                        txtcucod_cliente.Clear()
                        txtcuid_cliente.Clear()
                        txtcunombre_cli.Clear()
                        txtcuapellido_cli.Clear()
                        txtcuncuenta.Clear()
                        txtcusaldo.Clear()
                        'Call cliente.accion() '************************************-------------------
                        'Me.Close()
                        'limpiarset()
                    End If
                   
                End If
                comandos = New OleDbCommand("INSERT INTO cuenta(codigo,cod_cliente,id_cliente,ncuenta,tipo_cuenta_ahorro,saldo_ahorro,fecha)VALUES(txtcucodigo,txtcucod_cliente,txtcuid_cliente,txtcuncuenta,cmbcutipo_cuenta,txtcusaldo,txtcufecha)", conexion)
                comandos.Parameters.AddWithValue("@codigo", txtcucodigo.Text)
                comandos.Parameters.AddWithValue("@cod_cliente", txtcucod_cliente.Text)
                comandos.Parameters.AddWithValue("@id_cliente", txtcuid_cliente.Text)
                comandos.Parameters.AddWithValue("@ncuenta", txtcuncuenta.Text)
                comandos.Parameters.AddWithValue("@tipo_cuenta_ahorro", cmbcutipo_cuenta.Text)
                comandos.Parameters.AddWithValue("@saldo_ahorro", txtcusaldo.Text)
                comandos.Parameters.AddWithValue("@fecha", txtcufecha.Text)

                comandos.ExecuteNonQuery()
                MsgBox("Datos guardados")
                limpiar()
                txtcucodigo.Clear()
                txtcucod_cliente.Clear()
                txtcuid_cliente.Clear()
                txtcunombre_cli.Clear()
                txtcuapellido_cli.Clear()
                txtcuncuenta.Clear()
                txtcusaldo.Clear()
                'Call cliente.accion() '************************************-------------------
                'Me.Close()
                limpiarset()
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("** Datos duplicados **")
            End Try

        ElseIf cmbcutipo_cuenta.Text = setoga2 Then
            Try

                Dim set1 As New OleDb.OleDbCommand("select * from cuenta_corriente where id_cliente='" & txtcuid_cliente.Text & "'", conexion)
                Dim dr As OleDb.OleDbDataReader
                'conexion.Open()
                Dim mostrar2 As Byte

                dr = set1.ExecuteReader
                If dr.Read Then
                    txtprueba_id.Text = dr(2)
                    'Else
                    '    MsgBox("** ERROR **")
                End If
                If txtprueba_id.Text = txtcuid_cliente.Text Then
                    mostrar2 = MsgBox("Estimado usuario, se le recuerda que ya tiene activa una cuenta _ Desea crear otra", vbYesNo, "<< Ya tiene una Cuenta >>")
                    If vbYes Then

                        comandos = New OleDbCommand("INSERT INTO cuenta_corriente(codigo,cod_cliente,id_cliente,ncuenta,tipo_cuenta_corriente,saldo_corriente,fecha)VALUES(txtcucodigo,txtcucod_cliente,txtcuid_cliente,txtcuncuenta,cmbcutipo_cuenta,txtcusaldo,txtcufecha)", conexion)
                        comandos.Parameters.AddWithValue("@codigo", txtcucodigo.Text)
                        comandos.Parameters.AddWithValue("@cod_cliente", txtcucod_cliente.Text)
                        comandos.Parameters.AddWithValue("@id_cliente", txtcuid_cliente.Text)
                        comandos.Parameters.AddWithValue("@ncuenta", txtcuncuenta.Text)
                        comandos.Parameters.AddWithValue("@tipo_cuenta_corriente", cmbcutipo_cuenta.Text)
                        comandos.Parameters.AddWithValue("@saldo_corriente", txtcusaldo.Text)
                        comandos.Parameters.AddWithValue("@fecha", txtcufecha.Text)

                        comandos.ExecuteNonQuery()
                        MsgBox("** Datos Guardados **")
                        limpiar()
                        txtcucodigo.Clear()
                        txtcucod_cliente.Clear()
                        txtcuid_cliente.Clear()
                        txtcunombre_cli.Clear()
                        txtcuapellido_cli.Clear()
                        txtcuncuenta.Clear()
                        txtcusaldo.Clear()
                        'Me.Close()
                        ' limpiarset()
                    End If
                    
                End If
                comandos = New OleDbCommand("INSERT INTO cuenta_corriente(codigo,cod_cliente,id_cliente,ncuenta,tipo_cuenta_corriente,saldo_corriente,fecha)VALUES(txtcucodigo,txtcucod_cliente,txtcuid_cliente,txtcuncuenta,cmbcutipo_cuenta,txtcusaldo,txtcufecha)", conexion)
                comandos.Parameters.AddWithValue("@codigo", txtcucodigo.Text)
                comandos.Parameters.AddWithValue("@cod_cliente", txtcucod_cliente.Text)
                comandos.Parameters.AddWithValue("@id_cliente", txtcuid_cliente.Text)
                comandos.Parameters.AddWithValue("@ncuenta", txtcuncuenta.Text)
                comandos.Parameters.AddWithValue("@tipo_cuenta_corriente", cmbcutipo_cuenta.Text)
                comandos.Parameters.AddWithValue("@saldo_corriente", txtcusaldo.Text)
                comandos.Parameters.AddWithValue("@fecha", txtcufecha.Text)

                comandos.ExecuteNonQuery()
                MsgBox("** Datos Guardados **")
                limpiar()
                txtcucodigo.Clear()
                txtcucod_cliente.Clear()
                txtcuid_cliente.Clear()
                txtcunombre_cli.Clear()
                txtcuapellido_cli.Clear()
                txtcuncuenta.Clear()
                txtcusaldo.Clear()
                'Me.Close()
                ' limpiarset()
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("** Datos duplicados **")
            End Try
        End If
    End Sub

    Private Sub btnactualizar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactualizar.Click
        Dim setoga3, setoga4 As String
        setoga3 = "Ahorro"
        setoga4 = "Corriente"

        If cmbcutipo_cuenta.Text = setoga3 Then
            Try
                Dim consulta2 As String

                consulta2 = "update cuenta set tipo_cuenta_ahorro='" & cmbcutipo_cuenta.Text & "',saldo_ahorro='" & txtcusaldo.Text & "' where ncuenta='" & txtcuncuenta.Text & "'"
                comandos = New OleDbCommand(consulta2, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Datos Actualizados")

                limpiar()
            Catch ex As Exception
                MsgBox("Error al actualizar")
                MsgBox(ex.ToString)
            End Try

        ElseIf cmbcutipo_cuenta.Text = setoga4 Then
            Try
                Dim consulta2 As String

                consulta2 = "update cuenta set tipo_cuenta_corriente='" & cmbcutipo_cuenta.Text & "',saldo_corriente='" & txtcusaldo.Text & "' where ncuenta='" & txtcuncuenta.Text & "'"
                comandos = New OleDbCommand(consulta2, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Datos Actualizados")

                limpiar()
            Catch ex As Exception
                MsgBox("Error al actualizar")
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btneliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim consulta1 As String
        Dim respuesta As Byte
        respuesta = MsgBox("Esta seguro de eliminar", vbYesNo, "eliminar")
        If respuesta = vbYes Then
            consulta1 = "delete * from cuenta where codigo=" & txtcucodigo.Text & ""
            comandos = New OleDbCommand(consulta1, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Registro eliminado")
            DataGridView1.Update()  '*********** Permite actualizarlo despues de borrar un dato*****???????????????????????.........................
            limpiar()
        End If
    End Sub

    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ [BUSCADORES] BUSCAR \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Sub setoga13()

        Try
            Dim buscar As String
            Dim consulta As String
            Dim lista As Byte
            buscar = InputBox("Ingrese el Nº de cuenta")
            If buscar <> "" Then '------------------------------------------------------ > MODIFICADO por [CEDULA]
                consulta = "SELECT * FROM cuenta WHERE ncuenta like '" & buscar & "%'"
                adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
                registro = New DataSet
                adaptador.Fill(registro, "cuenta")
                lista = registro.Tables("cuenta").Rows.Count

            Else

                MsgBox("Error")
            End If
            If lista <> 0 Then
                'contenedor.Left = 6
                'contenedor.Top = 8
                DataGridView1.DataSource = registro
                DataGridView1.DataMember = "cuenta"


            Else
                atrasimagen = IsMirrored = False
                contenedor.Visible = atrasimagen
                'contenedor.Top = -160 'COORDENADAS...Para poder sacar el [DataGridView1]....cuando el numero de cedula no cea correcta
                'DataGridView1.Update()
                'DataGridView1.ClearSelection()
                MsgBox("** El Nº de cuenta que solicita no se encuentra... **") '*********** Por si se ingresa mal el Nº de cedula^^????
                limpiar()
            End If
            contenedor.Visible = True
        Catch ex As Exception
            MsgBox("**< El Nº de cuenta que solicita no se encuentra... >**")
        End Try
    End Sub

    Sub setoga12()
        Try
            Dim buscar As String
            Dim consulta As String
            Dim lista As Byte
            buscar = InputBox("Ingrese el Nº de cuenta")
            If buscar <> "" Then '------------------------------------------------------ > MODIFICADO por [CEDULA]
                consulta = "SELECT * FROM cuenta_corriente WHERE ncuenta like '" & buscar & "%'"
                adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
                registro = New DataSet
                adaptador.Fill(registro, "cuenta_corriente")
                lista = registro.Tables("cuenta_corriente").Rows.Count

            Else

                MsgBox("Error")
            End If
            If lista <> 0 Then
                'contenedor.Left = 6
                'contenedor.Top = 8
                DataGridView1.DataSource = registro
                DataGridView1.DataMember = "cuenta_corriente"


            Else
                atrasimagen = IsMirrored = False
                contenedor.Visible = atrasimagen
                'contenedor.Top = -160 'COORDENADAS...Para poder sacar el [DataGridView1]....cuando el numero de cedula no cea correcta
                'DataGridView1.Update()
                'DataGridView1.ClearSelection()
                MsgBox("** El Nº de cuenta que solicita no se encuentra... **") '*********** Por si se ingresa mal el Nº de cedula^^????
                limpiar()
            End If
            contenedor.Visible = True
        Catch ex As Exception
            MsgBox("**< El Nº de cuenta que solicita no se encuentra... >**")
        End Try
    End Sub

    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    Private Sub btncancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        limpiar()
        txtcucodigo.Enabled = True
    End Sub

    Private Sub cmbcutipo_cuenta_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcutipo_cuenta.Click
        Dim setga1 As New OleDb.OleDbCommand("select * from cuenta where id_cliente='" & cliente.txtcedula.Text & "'", conexion)
        Dim dr As OleDb.OleDbDataReader
        dr = setga1.ExecuteReader
        If dr.Read Then

            If cmbcutipo_cuenta.SelectedIndex = 1 Then

                txtcusaldo.Text = dr(5)
            ElseIf cmbcutipo_cuenta.SelectedIndex = 0 Then

                txtcusaldo.Text = dr(6)
            End If
        End If

    End Sub


    Private Sub btnbuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        setoga13()
        setoga12()
    End Sub

    Private Sub DataGridView1_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtcucodigo.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
        txtcucod_cliente.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        txtcuid_cliente.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
        txtcuncuenta.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString
        cmbcutipo_cuenta.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString
        ' cmbtipo_cuenta.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString
        txtcusaldo.Text = DataGridView1.CurrentRow.Cells.Item(5).Value.ToString
        'txtcufecha.Text = DataGridView1.CurrentRow.Cells.Item(6).Value.ToString

        contenedor.Visible = False
    End Sub

    Private Sub btncusalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncusalir.Click
        Me.Close()
        conexion.Close()
    End Sub

    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\PROCEDIMIENTO UTILIZADO PARA BUSCAR LOS DATO EN LA TABLA [Datos] \\\\\\\\\\\\\\\\\\\\\\\\\\
    Sub buscliente()
        Dim set1 As New OleDb.OleDbCommand("select * from datos where cedula='" & txtcuid_cliente.Text & "'", conexion)
        Dim dr As OleDb.OleDbDataReader
        'conexion.Open()

        dr = set1.ExecuteReader
        If dr.Read Then
            txtcucod_cliente.Text = dr(0)
            txtcunombre_cli.Text = dr(3)
            txtcuapellido_cli.Text = dr(2)
        Else
            MsgBox("** ERROR **")
        End If

        'conexion.Close()
    End Sub
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buscliente()

    End Sub
End Class