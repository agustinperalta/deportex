Public Class Cliente_Registrar_Modificar
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim conex As New Conexion
    Dim cliente As New Cliente
    Dim TE As New Tratamientos_Especiales

    Private Sub Cliente_Registrar_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT cuil_cliente As 'Cuil clientes', nombre As 'Nombre', apellido As 'Apellido', sexo As 'Sexo', fecha_nac As 'Fecha de Nacimiento', calle as 'Calle', numero As 'Numero', email As 'Email', nroTarjetaBeneficio As 'Numero de Tarjeta', telefono As 'Telefono' FROM Clientes "
        Me.dgv_registrar_eliminar.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub dgv_registrar_eliminar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_registrar_eliminar.CellContentClick

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.txt_cuil_cliente.Focus()
    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_grabar.Click
        Me.cliente.transferir(Me)
        If control_estado_grabacion = estado_grabacion.insertar Then
            Me.cliente.insertar()
        Else
            Me.cliente.modificar()
        End If
        Me.cargar_grilla()
    End Sub
End Class