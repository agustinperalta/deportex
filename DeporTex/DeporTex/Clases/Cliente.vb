Public Class Cliente
    Dim _BD As New Conexion
    Public Property cuil_cliente As Integer
    Public Property nombre As String
    Public Property apellido As String
    Public Property sexo As String
    Public Property fecha_nac As Date
    Public Property calle As String
    Public Property numero As Integer
    Public Property email As String
    Public Property nroTarjetaBeneficio As Integer
    Public Property telefono As Integer



    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Clientes("
        sql &= "cuil_cliente, nombre, apellido, "
        sql &= "sexo, fecha_nac, calle, numero, email, nroTarjetaBeneficio, telefono)"
        sql &= "VALUES ("
        sql &= _cuil_cliente
        sql &= ",'" & _nombre & "'"
        sql &= ",'" & _apellido & "'"
        sql &= ",'" & _sexo & "'"
        sql &= "," & _fecha_nac
        sql &= ",'" & _calle & "'"
        sql &= ", " & _numero
        sql &= ", '" & _email & "'"
        sql &= ", " & _nroTarjetaBeneficio
        sql &= ", " & _telefono & ")"

        Me._BD.INS_MOD_BOR(sql)

    End Sub
    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE Clientes "
        sql &= "SET nombre = '" & Me._nombre & "'"
        sql &= ", apellido = '" & Me._apellido & "'"
        sql &= ", sexo = " & Me._sexo & "'"
        sql &= ", fecha_nac = " & Me._fecha_nac
        sql &= ", calle = " & Me._calle & "'"
        sql &= ", numero = " & Me._numero
        sql &= ", email = " & Me._email & "'"
        sql &= ", nroTarjetaBeneficio = " & Me._nroTarjetaBeneficio
        sql &= ", _telefono = " & Me._telefono
        sql &= " WHERE cuil_cliente = '" & Me._cuil_cliente & "'"

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar(ByVal cuil_cliente As Integer)
        Dim sql As String = ""
        sql &= "DELETE FROM Clientes"
        sql &= " WHERE cuil_cliente = " & cuil_cliente

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
                Case "txt_cuil_cliente"
                    cuil_cliente = obj.Text
                Case "txt_nombre"
                    nombre = obj.Text
                Case "txt_apellido"
                    apellido = obj.Text
                Case "txt_sexo"
                    sexo = obj.Text
                Case "txt_fecha_nac"
                    fecha_nac = obj.Text
                Case "txt_calle"
                    calle = obj.Text
                Case "txt_numero"
                    numero = obj.Text
                Case "txt_email"
                    email = obj.Text
                Case "txt_nroTarjetaBeneficio"
                    nroTarjetaBeneficio = obj.Text
                Case "txt_telefono"
                    telefono = obj.Text
            End Select
        Next
    End Sub

End Class
