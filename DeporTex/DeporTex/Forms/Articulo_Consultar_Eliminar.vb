Public Class Articulo_Consultar_Eliminar
    Dim conex As New Conexion
    Private Sub Articulo_Consultar_Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_consultar_articulo.CellContentClick
        Dim sql As String
        sql = "DELETE FROM Articulos Where cod_articulo = '" & dgv_consultar_articulo.CurrentRow.Cells(0).Value & "'"
        Me.conex.INS_MOD_BOR(Sql)
    End Sub

    Private Sub txt_busqueda_Enter(sender As Object, e As EventArgs) Handles txt_busqueda.Enter
        txt_busqueda.Clear()
    End Sub
    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT cod_articulo As 'Codigo Articulos', M.nombre As 'Marca', A.nombre As 'Nombre', precio As 'Precio', P.razonSocial As 'Proveedor' FROM Articulos A INNER JOIN Marcas M ON (A.id_marca = M.id_marca) INNER JOIN Proveedores P ON (A.proveedor=P.cuil_proveedor)"
        Me.dgv_consultar_articulo.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim sql As String

        sql = "Select * From Articulos Where cod_articulo = '" & txt_busqueda.Text & "'"
        Me.dgv_consultar_articulo.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub cmd_refrescar_Click(sender As Object, e As EventArgs) Handles cmd_refrescar.Click
        cargar_grilla()
    End Sub

    Private Sub chk_borrar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_borrar.CheckedChanged

    End Sub
End Class