Public Class Proveedor_Registrar_Modificar
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim conex As New Conexion
    Dim proveedor As New Proveedor
    Dim TE As New Tratamientos_Especiales

    Private Sub Articulo_Registrar_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT cuil_proveedor As 'Cuil de Proveedor', razonSocial As 'Razon Social', telefono As 'Telefono' FROM Proveedores"
        Me.dgv_registrar_eliminar.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub dgv_registrar_eliminar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_registrar_eliminar.CellContentClick

        Me.txt_cuil_proveedor.Text = dgv_registrar_eliminar.CurrentRow.Cells(0).Value
        Me.txt_razonSocial.Text = dgv_registrar_eliminar.CurrentRow.Cells(1).Value
        Me.txt_telefono.Text = dgv_registrar_eliminar.CurrentRow.Cells(2).Value

        Me.control_estado_grabacion = estado_grabacion.modificar
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.txt_cuil_proveedor.Focus()
    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_grabar.Click
        Me.proveedor.transferir(Me)
        If control_estado_grabacion = estado_grabacion.insertar Then
            Me.proveedor.insertar()
        Else
            Me.proveedor.modificar()
        End If
        Me.cargar_grilla()
    End Sub
End Class