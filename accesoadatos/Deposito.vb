Imports System.Data.OleDb
Public Class Deposito
    Dim comandos As OleDbCommand
    Public Function duscarset()

        Dim dt As New DataTable
        Dim ds As New DataSet

        ds.Tables.Add(dt)
        conexion.Open()

        Dim da As New OleDb.OleDbDataAdapter("select * from datos where nucuenta", conexion)
        conexion.Open()

        For Each DataRow In dt.Rows
            If txtdencuenta.Text = DataRow(3) Then
                conexion.Close()
                Return True
            End If
        Next
        conexion.Close()
        Return False
    End Function

    Private Sub Deposito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdefecha.Text = Date.Now.ToLocalTime
        'chkdeahorro.Checked = False
        'chkdecorriente.Checked = False

        txtdefecha.Enabled = False
        txtdenombre.Enabled = False
        txtdeapellido.Enabled = False
        txtdecedula.Enabled = False
        txtdesaldo1.Enabled = False

        txtdefecha.BackColor = Color.White
        txtdenombre.BackColor = Color.White
        txtdeapellido.BackColor = Color.White
        txtdecedula.BackColor = Color.White
        txtdesaldo1.BackColor = Color.White

        '*********---------------********* <<<<< TRANSPARENCIA >>>>> ********-----------------***********
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Label4.Parent = PictureBox1 '....Quiere decir que ..el color de fondo del contenedor ya no es del del formulario ya no es en
        Label5.Parent = PictureBox1 '....si no del [PictureBox1]..........................
        Label6.Parent = PictureBox1
        Label7.Parent = PictureBox1
        Label9.Parent = PictureBox1
        Label11.Parent = PictureBox1
        chkdeahorro.Parent = PictureBox1
        chkdecorriente.Parent = PictureBox1


        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent '......Opteniendo transparencia o el color del pictureBox1........
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label9.BackColor = Color.Transparent
        Label11.BackColor = Color.Transparent
        chkdeahorro.BackColor = Color.Transparent
        chkdecorriente.BackColor = Color.Transparent


    End Sub

    Sub cahorro()
        '----------------------------************** < AHORRO > *******************************------------------------------
        If chkdeahorro.Checked = True And chkdecorriente.Checked = False Then
            Try
                Dim consulta2 As String
                Dim a, b As Double

                a = Val(txtdesaldo1.Text)
                b = Val(txtdesaldo.Text)
                txtdesaldo1.Text = txtdesaldo1.Text + Val(txtdesaldo.Text) '-----------------------><><><><><><><>
                consulta2 = "update cuenta set saldo_ahorro='" & txtdesaldo1.Text & "' where ncuenta='" & txtdencuenta.Text & "'"
                comandos = New OleDbCommand(consulta2, conexion)

                conexion.Open()

                comandos.ExecuteNonQuery()
                conexion.Close()
                txtdesaldo.Text = ""
                limpiar()
                chkdeahorro.Checked = False
                chkdecorriente.Enabled = True
                MsgBox("** Transacción se realizo correctamente **", MsgBoxStyle.Information, "DEPOSITO")
                ' Me.Close()
                'Else
                'Dim setgace As Byte
                'setgace = MsgBox("** No esta permitido depósitos mayore que $ 10000 Desea continuar..**", vbYesNo, "DEPOCITO")
                'If setgace = vbNo Then
                '    conexion.Close()
                '    Me.Close()
                'End If

                'End If
            Catch ex As Exception
            ' MsgBox(ex.ToString)
            MsgBox("*** Error en la Transacción ***")
        End Try

        End If
    End Sub

    Sub corriente()
        '----------------------------************** < CORRIENTE > *******************************------------------------------
        If chkdecorriente.Checked = True And chkdeahorro.Checked = False Then
            Try
                Dim consulta2 As String
                Dim a, b As Double
                'Dim c As Double
                'c = Val(txtdesaldo.Text)
                a = Val(txtdesaldo1.Text)
                b = Val(txtdesaldo.Text)
                txtdesaldo1.Text = txtdesaldo1.Text + Val(txtdesaldo.Text) '-----------------------><><><><><><><>
                consulta2 = "update cuenta_corriente set saldo_corriente='" & txtdesaldo1.Text & "' where ncuenta='" & txtdencuenta.Text & "'"
                comandos = New OleDbCommand(consulta2, conexion)

                conexion.Open()
                comandos.ExecuteNonQuery()

                conexion.Close()
                txtdesaldo.Text = ""
                limpiar()
                chkdecorriente.Checked = False
                chkdeahorro.Enabled = True
                MsgBox("** Transacción se realizo correctamente **", MsgBoxStyle.Information, "DEPOSITO")
                'Me.Close()
            Catch ex As Exception
            ' MsgBox(ex.ToString)
            MsgBox("*** Error en la Transacción ***")
        End Try

        End If
    End Sub

    Private Sub btndeaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeaceptar.Click
        Call cahorro()
        Call corriente()

    End Sub

    Sub buscaDeposito()

        Dim set1 As New OleDb.OleDbCommand("select * from cuenta where ncuenta='" & txtdencuenta.Text & "'", conexion)
        Dim dr As OleDb.OleDbDataReader
        conexion.Open()
        'chkrecorriente.Checked = False

        dr = set1.ExecuteReader
        If dr.Read Then
            txtdecedula.Text = dr(2)
            txtdesaldo1.Text = dr(5)
            chkdecorriente.Enabled = False
            chkdeahorro.Checked = True
        Else
            '  MsgBox("** ERROR **")
        End If

        conexion.Close()


    End Sub

    Sub buscaDepocito2()

        Dim set1 As New OleDb.OleDbCommand("select * from datos where cedula='" & txtdecedula.Text & "'", conexion)
        Dim dr As OleDb.OleDbDataReader
        conexion.Open()

        dr = set1.ExecuteReader
        If dr.Read Then
            'txtdecedula.Text = dr(2)
            txtdenombre.Text = dr(3)
            txtdeapellido.Text = dr(2)
            'txtdesaldo1.Text = dr(6)
        Else
            MsgBox("** ERROR **")
        End If

        conexion.Close()
    End Sub

    Sub buscarDepocito3()

        Dim set1 As New OleDb.OleDbCommand("select * from cuenta_corriente where ncuenta='" & txtdencuenta.Text & "'", conexion)
        Dim dr As OleDb.OleDbDataReader
        conexion.Open()
        'chkreahorro.Checked = False

        dr = set1.ExecuteReader
        If dr.Read Then
            txtdecedula.Text = dr(2)
            txtdesaldo1.Text = dr(5)
            chkdeahorro.Enabled = False
            chkdecorriente.Checked = True
        Else
            'MsgBox("** ERROR **")
        End If

        conexion.Close()
    End Sub

    Private Sub btndebuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndebuscar.Click
        Call buscaDeposito()
        Call buscarDepocito3()
        Call buscaDepocito2()
    End Sub

    Private Sub btndesalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndesalir.Click
        Me.Close()
        conexion.Close()
    End Sub

    Private Sub chkdeahorro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkdeahorro.Click
        If chkdeahorro.Checked = True Then
            'chkdeahorro.Enabled = True
            chkdecorriente.Enabled = False
            Dim set1 As New OleDb.OleDbCommand("select * from cuenta where ncuenta='" & txtdencuenta.Text & "'", conexion)
            Dim dr As OleDb.OleDbDataReader
            conexion.Open()

            dr = set1.ExecuteReader
            If dr.Read Then
                txtdesaldo1.Text = dr(6)
                'Else
                '    MsgBox("** ERROR **")
            End If
        Else
            chkdeahorro.Enabled = True
            chkdecorriente.Enabled = True
        End If
        conexion.Close()

    End Sub

    Private Sub chkdecorriente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkdecorriente.Click
        If chkdecorriente.Checked = True Then
            chkdeahorro.Enabled = False
            'chkdecorriente.Enabled = False
            Dim set1 As New OleDb.OleDbCommand("select * from cuenta_corriente where ncuenta='" & txtdencuenta.Text & "'", conexion)
            Dim dr As OleDb.OleDbDataReader
            conexion.Open()

            dr = set1.ExecuteReader
            If dr.Read Then
                txtdesaldo1.Text = dr(7)
                'Else
                '    MsgBox("** ERROR **")
            End If

            conexion.Close()

        Else
            chkdeahorro.Enabled = True
            chkdecorriente.Enabled = True
        End If
    End Sub

    Sub limpiar()
        txtdencuenta.Clear()
        txtdenombre.Clear()
        txtdeapellido.Clear()
        txtdecedula.Clear()
        txtdesaldo.Clear()
        txtdesaldo1.Clear()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        limpiar()
        chkdeahorro.Checked = False
        chkdecorriente.Checked = False

        chkdeahorro.Enabled = True
        chkdecorriente.Enabled = True
    End Sub

   
End Class