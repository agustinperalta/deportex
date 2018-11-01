Public Class Proveedor
    Dim _BD As New Conexion
    Public Property cuil_proveedor As Integer
    Public Property razonSocial As String
    Public Property telefono As Integer

    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Proveedores(cuil_proveedor, razonSocial, telefono)"
        sql &= "VALUES (" & Me._cuil_proveedor
        sql &= ",'" & Me._razonSocial & "'"
        sql &= ", " & Me._telefono & ")"
        Me._BD.INS_MOD_BOR(sql)

    End Sub
    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE Proveedores "
        sql &= "SET razonSocial = '" & Me._razonSocial & "'"
        sql &= ", telefono = " & Me._telefono
        sql &= " WHERE cuil_proveedor = '" & Me._cuil_proveedor & "'"

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar(ByVal cuil_proveedor As String)
        Dim sql As String = ""
        sql &= "DELETE FROM Proveedores"
        sql &= " WHERE cuil_proveedor = '" & cuil_proveedor & "'"

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
                Case "txt_cuil_proveedor"
                    cuil_proveedor = obj.Text
                Case "txt_razonSocial"
                    razonSocial = obj.Text
                Case "txt_telefono"
                    telefono = obj.Text
            End Select

        Next
    End Sub
End Class
