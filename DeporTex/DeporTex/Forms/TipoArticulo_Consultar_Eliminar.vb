Public Class TipoArticulo_Consultar_Eliminar
    Dim _bd As New Conexion
    Dim tipoArticulo As New TipoArticulo

    Private Sub TipoArticulo_Consultar_Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim sql As String
        sql = "Select * From TipoArticulo Where id_tipo = '" & txt_busqueda.Text & "'"

        Me.dgv_consultar_eliminar_tipoarticulo.DataSource = Me._bd.leo_tabla(sql)
    End Sub

    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT id_tipo As 'Id de Articulo', nombre As 'Nombre' FROM TipoArticulo "
        Me.dgv_consultar_eliminar_tipoarticulo.DataSource = Me._bd.leo_tabla(sql)
    End Sub

    Private Sub txt_busqueda_Enter(sender As Object, e As EventArgs) Handles txt_busqueda.Enter
        txt_busqueda.Clear()
    End Sub

    Private Sub cmd_refrescar_Click(sender As Object, e As EventArgs) Handles cmd_refrescar.Click
        cargar_grilla()
    End Sub

    Private Sub dgv_consultar_eliminar_tipoArticulo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_consultar_eliminar_tipoarticulo.CellContentClick
        Dim id_tipo As String = Me.dgv_consultar_eliminar_tipoarticulo.CurrentRow.Cells(0).Value
        If Me.chk_borrar.Checked = True Then
            If MessageBox.Show("¿Está seguro que quiere borrar a " & Me.dgv_consultar_eliminar_tipoarticulo.CurrentRow.Cells(0).Value & "?" _
                               , "Importante", MessageBoxButtons.YesNo _
                               , MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.tipoArticulo.borrar(id_tipo)
                cargar_grilla()
            End If
        End If
    End Sub

End Class