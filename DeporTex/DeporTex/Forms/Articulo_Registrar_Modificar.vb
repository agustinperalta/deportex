Public Class Articulo_Registrar_Modificar
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim conex As New Conexion
    Dim articulo As New Articulo
    Dim TE As New Tratamientos_Especiales

    Private Sub Articulo_Registrar_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
        TE.cargar_combo(cmb_marca, "SELECT * FROM Marcas")
        TE.cargar_combo(cmb_proveedor, "SELECT * FROM Proveedores")
    End Sub

    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT cod_articulo As 'Codigo Articulos', M.nombre As 'Marca', A.nombre As 'Nombre', precio As 'Precio', P.razonSocial As 'Proveedor' FROM Articulos A INNER JOIN Marcas M ON (A.id_marca = M.id_marca) INNER JOIN Proveedores P ON (A.proveedor=P.cuil_proveedor)"
        Me.dgv_registrar_eliminar.DataSource = Me.conex.leo_tabla(sql)
    End Sub
    Private Function devolver_item(ByVal sql As String)
        Dim conx As New Conexion
        Dim tabla As DataTable
        tabla = Me.conex.leo_tabla(sql)
        Return tabla.Rows(0).Item(0)

    End Function
    Private Sub dgv_registrar_eliminar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_registrar_eliminar.CellContentClick
        Dim buscar_marca As String = dgv_registrar_eliminar.CurrentRow.Cells(1).Value
        Dim buscar_proveedor As String = dgv_registrar_eliminar.CurrentRow.Cells(4).Value
        Me.txt_cod_articulo.Text = dgv_registrar_eliminar.CurrentRow.Cells(0).Value
        Me.cmb_marca.SelectedValue = devolver_item("SELECT id_marca FROM Marcas WHERE nombre = '" & buscar_marca & "'")
        Me.txt_nombre.Text = dgv_registrar_eliminar.CurrentRow.Cells(2).Value
        Me.txt_precio.Text = dgv_registrar_eliminar.CurrentRow.Cells(3).Value
        Me.cmb_proveedor.SelectedValue = devolver_item("SELECT cuil_proveedor FROM Proveedores WHERE razonSocial = '" & buscar_proveedor & "'")

        Me.control_estado_grabacion = estado_grabacion.modificar
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.txt_cod_articulo.Focus()
    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_grabar.Click
        Me.articulo.transferir(Me)
        If control_estado_grabacion = estado_grabacion.insertar Then
            Me.articulo.insertar()
        Else
            Me.articulo.modificar()
        End If
        Me.cargar_grilla()
    End Sub
End Class