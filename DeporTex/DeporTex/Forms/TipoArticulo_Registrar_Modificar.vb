Public Class TipoArticulo_Registrar_Modificar
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim conex As New Conexion
    Dim tipo_articulo As New TipoArticulo
    Dim TE As New Tratamientos_Especiales

    Private Sub TipoArticulo_Registrar_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT id_tipo As 'Id Tipo de Articulo', nombre As 'Nombre' FROM TipoArticulo "
        Me.dgv_registrar_eliminar.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub dgv_registrar_eliminar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_registrar_eliminar.CellContentClick

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.txt_id_tipo_articulo.Focus()
    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_grabar.Click
        Me.tipo_articulo.transferir(Me)
        If control_estado_grabacion = estado_grabacion.insertar Then
            Me.tipo_articulo.insertar()
        Else
            Me.tipo_articulo.modificar()
        End If
        Me.cargar_grilla()
    End Sub
End Class