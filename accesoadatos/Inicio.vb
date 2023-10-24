Public Class Inicio
    Dim contar As Integer
    Private Sub btnconsu_ret_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsu_ret.Click
        cliente.Show()

    End Sub

    Private Sub btnmantenimieto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmantenimieto.Click
        'MsgBox("** Acontinuación elija una de las opciones **", MsgBoxStyle.OkCancel, "Opciones")
        mantenimiento1.Show()
    End Sub

    Private Sub btnretiros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnretiros.Click
        Retiros.Show()
    End Sub

    Private Sub btndepositos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndepositos.Click
        Deposito.Show()
    End Sub

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

        Label2.Visible = False
        Label3.Visible = False

        Label2.Parent = PictureBox2
        Label3.Parent = PictureBox2

        Label3.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        contar = contar + 1
        Label1.Text = contar

        If contar = 40 Then
            PictureBox3.Image = My.Resources.caja_fuerte1
            Label2.Visible = True
            Label3.Visible = False
        End If
        If contar = 80 Then
            Label2.Visible = False
            Label3.Visible = True
            ' Timer1.Stop()
            contar = 0
            PictureBox3.Image = My.Resources.dinero22
        End If
    End Sub

    Private Sub btncrear_cuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncrear_cuenta.Click
        cuenta.Show()
    End Sub
End Class