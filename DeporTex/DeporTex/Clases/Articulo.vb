Public Class Articulo
    Dim _BD As New Conexion
    Public Property cod_articulo As String
    Public Property id_marca As Integer
    Public Property nombre As String
    Public Property precio As Double
    Public Property proveedor As Integer


    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Articulos("
        sql &= "cod_articulo, id_marca, nombre, "
        sql &= "precio, proveedor)"
        sql &= "VALUES ("
        sql &= "'" & _cod_articulo & "'"
        sql &= "," & _id_marca
        sql &= ",'" & _nombre & "'"
        sql &= ", '" & _precio & "'"
        sql &= ", " & _proveedor & ")"

        Me._BD.INS_MOD_BOR(sql)

    End Sub
    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE Articulos "
        sql &= "SET id_marca = '" & Me._id_marca & "'"
        sql &= ", nombre = '" & Me._nombre & "'"
        sql &= ", precio = " & Me._precio
        sql &= ", proveedor = " & Me._proveedor
        sql &= " WHERE cod_articulo = '" & Me._cod_articulo & "'"

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar(ByVal cod_articulo As String)
        Dim sql As String = ""
        sql &= "DELETE FROM Articulos"
        sql &= " WHERE cod_articulo = '" & cod_articulo & "'"

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
                Case "txt_cod_articulo"
                    cod_articulo = obj.Text
                Case "txt_nombre"
                    nombre = obj.Text
                Case "txt_precio"
                    precio = obj.Text
            End Select

            If obj.GetType().Name = "ComboBox" Then

                If obj.SelectedIndex = -1 Then
                    MsgBox("el " & obj.nombre_campo & " está sin selección")
                    obj.Focus()
                    Exit Sub
                End If
            End If
            Select Case obj.Name
                Case "cmb_marca"
                    id_marca = obj.SelectedValue
                Case "cmb_proveedor"
                    proveedor = obj.SelectedValue
            End Select


        Next
    End Sub

End Class
