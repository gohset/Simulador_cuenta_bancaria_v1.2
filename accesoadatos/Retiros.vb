Imports System.Data.OleDb
Public Class Retiros
    Dim comandos As OleDbCommand
    Public Function duscarset()

        Dim dt As New DataTable
        Dim ds As New DataSet

        ds.Tables.Add(dt)
        conexion.Open()

        Dim da As New OleDb.OleDbDataAdapter("select * from datos where nucuenta", conexion)
        conexion.Open()

        For Each DataRow In dt.Rows
            If txtrencuenta.Text = DataRow(6) Then
                conexion.Close()
                Return True
            End If
        Next
        conexion.Close()
        Return False
    End Function

    Sub buscaRetiro()

        Dim set1 As New OleDb.OleDbCommand("select * from cuenta where ncuenta='" & txtrencuenta.Text & "'", conexion)
        Dim dr As OleDb.OleDbDataReader
        conexion.Open()
        'chkrecorriente.Checked = False

        dr = set1.ExecuteReader
        If dr.Read Then
            txtrecedula.Text = dr(2)
            txtresaldo1.Text = dr(5)
            chkrecorriente.Enabled = False
            chkreahorro.Checked = True
        Else
            '  MsgBox("** ERROR **")
        End If

        conexion.Close()


    End Sub

    Sub buscaRetiro2()

        Dim set1 As New OleDb.OleDbCommand("select * from datos where cedula='" & txtrecedula.Text & "'", conexion)
        Dim dr As OleDb.OleDbDataReader
        conexion.Open()

        dr = set1.ExecuteReader
        If dr.Read Then
            'txtdecedula.Text = dr(2)
            txtrenombre.Text = dr(3)
            txtreapellido.Text = dr(2)
            'txtdesaldo1.Text = dr(6)
        Else
            MsgBox("** ERROR **")
        End If

        conexion.Close()
    End Sub

    Sub buscarRetiro3()

        Dim set1 As New OleDb.OleDbCommand("select * from cuenta_corriente where ncuenta='" & txtrencuenta.Text & "'", conexion)
        Dim dr As OleDb.OleDbDataReader
        conexion.Open()
        'chkreahorro.Checked = False

        dr = set1.ExecuteReader
        If dr.Read Then
            txtrecedula.Text = dr(2)
            txtresaldo1.Text = dr(5)
            chkreahorro.Enabled = False
            chkrecorriente.Checked = True
        Else
            'MsgBox("** ERROR **")
        End If

        conexion.Close()
    End Sub

    Private Sub Retiros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtrefecha.Text = Date.Now.ToLocalTime

        txtrefecha.Enabled = False
        txtrenombre.Enabled = False
        txtreapellido.Enabled = False
        txtrecedula.Enabled = False
        txtresaldo1.Enabled = False

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
        chkreahorro.Parent = PictureBox1
        chkrecorriente.Parent = PictureBox1

        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent '......Opteniendo transparencia o el color del pictureBox1........
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label9.BackColor = Color.Transparent
        Label11.BackColor = Color.Transparent
        chkreahorro.BackColor = Color.Transparent
        chkrecorriente.BackColor = Color.Transparent

    End Sub

    Private Sub btnrebuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrebuscar.Click

        Call buscaRetiro()
        ' If chkreahorro.Checked = True And chkreahorro.Checked = False Then
        Call buscarRetiro3()
        Call buscaRetiro2()
        ' End If
        ' Call buscaRetiro2()

    End Sub

    Sub cahorro()
        '----------------------------************** < AHORRO > *******************************------------------------------
        If chkreahorro.Checked = True And chkrecorriente.Checked = False Then
            Try
                Dim consulta2 As String
                Dim a, b As Double
                a = Val(txtresaldo1.Text)
                b = Val(txtresaldo.Text)
                If a >= b Then
                    txtresaldo1.Text = txtresaldo1.Text - Val(txtresaldo.Text) '-----------------------><><><><><><><>
                    consulta2 = "update cuenta set saldo_ahorro='" & txtresaldo1.Text & "' where ncuenta='" & txtrencuenta.Text & "'"
                    comandos = New OleDbCommand(consulta2, conexion)

                    'Dim a, b As Double
                    'a = Val(txtresaldo1.Text)
                    'b = Val(txtresaldo.Text)

                    conexion.Open()

                    comandos.ExecuteNonQuery()
                    conexion.Close()
                    txtresaldo.Text = ""
                    limpiar()
                    chkreahorro.Checked = False
                    chkrecorriente.Enabled = True
                    MsgBox("** Transacción se realizo correctamente **", MsgBoxStyle.Information, "RETIRO")
                    ' Me.Close()
                Else
                    txtresaldo.Text = ""
                    Dim setgace As Byte
                    setgace = MsgBox("** Dinero insuficiente, Desea intentar nuevamente...**", vbYesNo, "RETIRO")
                    If setgace = vbNo Then
                        conexion.Close()
                        Me.Close()
                    End If
                End If
            Catch ex As Exception
                ' MsgBox(ex.ToString)
                MsgBox("*** Error en la Transacción ***")
            End Try

        End If
    End Sub

    Sub corriente()
        '----------------------------************** < CORRIENTE > *******************************------------------------------
        If chkrecorriente.Checked = True And chkreahorro.Checked = False Then
            Try
                Dim consulta2 As String
                Dim a, b As Double
                a = Val(txtresaldo1.Text)
                b = Val(txtresaldo.Text)
                If a >= b Then
                    txtresaldo1.Text = txtresaldo1.Text - Val(txtresaldo.Text) '-----------------------><><><><><><><>
                    consulta2 = "update cuenta_corriente set saldo_corriente='" & txtresaldo1.Text & "' where ncuenta='" & txtrencuenta.Text & "'"
                    comandos = New OleDbCommand(consulta2, conexion)

                    conexion.Open()
                    comandos.ExecuteNonQuery()

                    conexion.Close()
                    txtresaldo.Text = ""
                    limpiar()
                    chkrecorriente.Checked = False
                    chkreahorro.Enabled = True
                    MsgBox("** Transacción se realizo correctamente **", MsgBoxStyle.Information, "RETIRO")
                Else
                    Dim setgace As Byte
                    setgace = MsgBox("** Dinero insuficiente, Desea intentar nuevamente...**", vbYesNo, "RETIRO")
                    If setgace = vbNo Then
                        conexion.Close()
                        Me.Close()
                    End If
                End If
                'Else
                'MsgBox("** No esta permitido depósitos mayore que $ 3000 **", MsgBoxStyle.Exclamation)

            Catch ex As Exception
                ' MsgBox(ex.ToString)
                MsgBox("*** Error en la Transacción ***")
            End Try

        End If
    End Sub

    Private Sub btnreaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreaceptar.Click
        Call cahorro()
        Call corriente()

    End Sub

    Private Sub btnresalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnresalir.Click
        Me.Close()
        conexion.Close()
    End Sub

    Private Sub chkreahorro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkreahorro.CheckedChanged
        If chkreahorro.Checked = True Then
            chkrecorriente.Enabled = False
        Else
            chkreahorro.Enabled = True
            chkrecorriente.Enabled = True
        End If
    End Sub

    Private Sub chkrecorriente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkrecorriente.CheckedChanged
        If chkrecorriente.Checked = True Then
            chkreahorro.Enabled = False
        Else
            chkreahorro.Enabled = True
            chkrecorriente.Enabled = True
        End If
    End Sub

    Private Sub chkreahorro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkreahorro.Click
        If chkreahorro.Checked = True Then
            'chkdeahorro.Enabled = True
            chkrecorriente.Enabled = False
            Dim set1 As New OleDb.OleDbCommand("select * from cuenta where ncuenta='" & txtrencuenta.Text & "'", conexion)
            Dim dr As OleDb.OleDbDataReader
            conexion.Open()

            dr = set1.ExecuteReader
            If dr.Read Then
                txtresaldo1.Text = dr(6)
                'Else
                '    MsgBox("** ERROR **")
            End If
        Else
            chkreahorro.Enabled = True
            chkrecorriente.Enabled = True
        End If
        conexion.Close()
    End Sub

    Sub limpiar()
        txtrencuenta.Clear()
        txtrenombre.Clear()
        txtreapellido.Clear()
        txtrecedula.Clear()
        txtresaldo.Clear()
        txtresaldo1.Clear()
    End Sub

    Private Sub chkrecorriente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkrecorriente.Click
        If chkrecorriente.Checked = True Then
            chkreahorro.Enabled = False
            'chkdecorriente.Enabled = False
            Dim set1 As New OleDb.OleDbCommand("select * from cuenta where ncuenta='" & txtrencuenta.Text & "'", conexion)
            Dim dr As OleDb.OleDbDataReader
            conexion.Open()

            dr = set1.ExecuteReader
            If dr.Read Then
                txtresaldo1.Text = dr(7)
                'Else
                '    MsgBox("** ERROR **")
            End If

            conexion.Close()

        Else
            chkreahorro.Enabled = True
            chkrecorriente.Enabled = True
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        limpiar()
        chkreahorro.Checked = False
        chkrecorriente.Checked = False

        chkreahorro.Enabled = True
        chkrecorriente.Enabled = True
    End Sub
End Class