Public Class Login
    Dim bd As New Conexion
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_ingresar_Click(sender As Object, e As EventArgs) Handles cmd_ingresar.Click
        If txt_usuario.Text = "" Then
            MsgBox("El campo de la usuario esta vacio.")
            txt_usuario.Focus()
            Exit Sub
        End If

        If txt_contrasena.Text = "" Then
            MsgBox("El campo del contraseña esta vacio.")
            txt_contrasena.Focus()
            Exit Sub
        End If

        Dim mensaje As String = validar_usuario(txt_usuario.Text, txt_contrasena.Text)
        If mensaje = "Usuario encontrado." Then
            DeporTex.ShowDialog()
        Else
            MsgBox(mensaje)
        End If

    End Sub

    Private Function validar_usuario(ByVal user As String, ByVal passwd As String) As String
        Dim tabla As New DataTable
        tabla = bd.leo_tabla("SELECT * FROM Usuarios WHERE usuario = '" & user & "' AND contraseña = '" & passwd & "'")
        If tabla.Rows.Count = 0 Then
            Return "Datos incorrectos"
        End If
        Return "Usuario encontrado."

    End Function

End Class