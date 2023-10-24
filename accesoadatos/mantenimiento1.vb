Public Class mantenimiento1

    Private Sub btnmancanton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmancanton.Click

        Canton.Show()
        Me.Close()
    End Sub

    Private Sub btnmanprovincia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmanprovincia.Click

        Provincia.Show()
        Me.Close()
    End Sub

    Private Sub btnmancancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmancancelar.Click
        Me.Close()
    End Sub
End Class