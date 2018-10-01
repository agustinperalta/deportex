Public Class TipoArticulo
    Dim _BD As New Conexion
    Public Property id_tipo As Integer
    Public Property nombre As String

    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO TipoArticulo("
        sql &= "id_tipo, nombre "
        sql &= "VALUES (" & _id_tipo & ", " & nombre & ")"

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql = "UPDATE TipoArticulo SET nombre = '" & nombre & "'"
        sql &= " WHERE id_tipo = " & id_tipo

        _BD.INS_MOD_BOR(sql)

    End Sub

    Public Sub borrar(ByVal id_tipo As Integer)
        Dim sql As String = ""
        sql &= "DELETE FROM TipoArticulo"
        sql &= " WHERE id_tipo = " & id_tipo

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub transferir(ByRef controles As Object)
        For Each obj In controles.Controls
            If obj.GetType().Name = "MaskedTextBox" Then

                If obj.text = "" Then
                    MsgBox("el " & obj.nombre_campo & " está vacío")
                    obj.Focus()
                    Exit Sub
                End If
            End If
            Select Case obj.Name
                Case "txt_id_tipo_articulo"
                    id_tipo = obj.Text
                Case "txt_nombre"
                    nombre = obj.Text
            End Select

        Next
    End Sub

End Class
