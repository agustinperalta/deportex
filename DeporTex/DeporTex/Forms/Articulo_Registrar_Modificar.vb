Public Class Articulo_Registrar_Modificar
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim conex As New Conexion
    Dim TE As New Tratamientos_Especiales

    Private Sub Articulo_Registrar_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TE.cargar_combobox(cmb_marca, "nombre", "id_marca")
        cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT cod_articulo As 'Codigo Articulos', M.nombre As 'Marca', A.nombre As 'Nombre', precio As 'Precio', P.razonSocial As 'Proveedor' FROM Articulos A INNER JOIN Marcas M ON (A.id_marca = M.id_marca) INNER JOIN Proveedores P ON (A.proveedor=P.cuil_proveedor)"
        Me.dgv_registrar_eliminar.DataSource = Me.conex.leo_tabla(sql)
    End Sub
    Private Sub dgv_registrar_eliminar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_registrar_eliminar.CellContentClick
        Me.txt_cod_articulo.Text = dgv_registrar_eliminar.CurrentRow.Cells(0).Value
        Me.cmb_marca.SelectedValue = dgv_registrar_eliminar.CurrentRow.Cells(1).Value
        Me.txt_nombre.Text = dgv_registrar_eliminar.CurrentRow.Cells(2).Value
        Me.txt_precio.Text = dgv_registrar_eliminar.CurrentRow.Cells(3).Value
        Me.cmb_proveedor.SelectedValue = dgv_registrar_eliminar.CurrentRow.Cells(4).Value

        Me.control_estado_grabacion = estado_grabacion.modificar
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.txt_cod_articulo.Focus()
    End Sub

End Class