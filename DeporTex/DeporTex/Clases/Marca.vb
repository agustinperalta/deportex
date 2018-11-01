Public Class Marca
    Dim _BD As New Conexion
    Public Property id_marca As Integer
    Public Property nombre As String

    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Marcas("
        sql &= " id_marca, nombre)"
        sql &= "VALUES ("
        sql &= "'" & Me._id_marca & "'"
        sql &= ",'" & Me._nombre & "')"
        Me._BD.INS_MOD_BOR(sql)

    End Sub
    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE Marcas "
        sql &= "SET nombre = '" & Me._nombre & "'"
        sql &= " WHERE id_marca = '" & Me._id_marca & "'"

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar(ByVal id_marca As String)
        Dim sql As String = ""
        sql &= "DELETE FROM Marcas"
        sql &= " WHERE id_marca = '" & id_marca & "'"

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
                Case "txt_nombre"
                    nombre = obj.Text
                Case "txt_id_marca"
                    id_marca = obj.Text
            End Select

        Next
    End Sub
End Class
