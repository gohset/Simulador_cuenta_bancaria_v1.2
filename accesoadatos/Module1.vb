Module Module1
    Public conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=prueba.accdb") ' decalro la vriable publica para la conexion
    Public Sub conectar() 'crea un procedim einto para conectarme a la base de datos y poder abrir la misma
        Try 'maneja excepciones as conocidos como errores se codifica sin error
            conexion.Open()
            ' MsgBox("conectado")
        Catch ex As Exception 'codifico los errores
            ' MsgBox(ex.ToString)
            ' MsgBox("** Error en la Conexion **")
        End Try
    End Sub
End Module
