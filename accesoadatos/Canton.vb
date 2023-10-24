Imports System.Data.OleDb
Public Class Canton
    Dim comandos As OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet
    Private Sub Canton_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conectar()
        'Me.Height = 220


        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        ' contenedor.Parent = PictureBox1

        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        'contenedor.BackColor = Color.Transparent


    End Sub
    Sub limpiar()
        txtcodigo.Text = ""
        txtnombre.Text = ""
        txtcodigo.Focus()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        limpiar()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            comandos = New OleDbCommand("INSERT INTO tb_canton(cod_canton,canton)VALUES(txtcodigo,txtnombre)", conexion)
            comandos.Parameters.AddWithValue("@cod_canton", txtcodigo.Text)
            comandos.Parameters.AddWithValue("@canton", txtnombre.Text)
            comandos.ExecuteNonQuery()
            MsgBox("datos guardados")
            limpiar()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        'Me.Height = 401
        Dim buscar As String
        Dim consulta As String
        Dim lista As Byte
        buscar = InputBox("Ingrese el Cantón")
        If buscar <> "" Then
            consulta = "SELECT * FROM tb_canton WHERE canton like '" & buscar & "%'"
            adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
            registro = New DataSet
            adaptador.Fill(registro, "tb_canton")
            lista = registro.Tables("tb_canton").Rows.Count
        Else
            MsgBox("Error")
        End If
        If lista <> 0 Then
            DataGridView1.DataSource = registro
            DataGridView1.DataMember = "tb_canton"
        End If
        contenedor.Visible = True
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtcodigo.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
        txtnombre.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString

        contenedor.Visible = False
        ' Me.Height = 220
    End Sub

    Private Sub btactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btactualizar.Click
        Try
            comandos = New OleDbCommand("update tb_canton set canton='" & txtnombre.Text & "' where cod_canton=" & txtcodigo.Text & "", conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Datos Actualizados")

            limpiar()
        Catch ex As Exception
            MsgBox("Error al actualizar")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim respuesta As Byte
        respuesta = MsgBox("Esta seguro de eliminar", vbYesNo, "Eliminar")
        If respuesta = vbYes Then

            comandos = New OleDbCommand("delete * from tb_canton where cod_canton=" & txtcodigo.Text & "", conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Registro eliminado")

        End If

        limpiar()
    End Sub

    Private Sub btncansalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncansalir.Click
        Me.Close()
        conexion.Close()
    End Sub
End Class