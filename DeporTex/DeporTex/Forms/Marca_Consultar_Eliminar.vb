Public Class Marca_Consultar_Eliminar
    Dim conex As New Conexion
    Dim marca As New Marca
    Private Sub Articulo_Consultar_Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub txt_busqueda_Enter(sender As Object, e As EventArgs) Handles txt_busqueda.Enter
        txt_busqueda.Clear()
    End Sub
    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT id_marca As 'Codigo Marca', nombre As 'Nombre' FROM Marcas"
        Me.dgv_consultar_eliminar.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim sql As String

        sql = "Select * From Marcas Where id_marca = '" & txt_busqueda.Text & "'"
        Me.dgv_consultar_eliminar.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub cmd_refrescar_Click(sender As Object, e As EventArgs) Handles cmd_refrescar.Click
        cargar_grilla()
    End Sub

    Private Sub dgv_consultar_articulo_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_consultar_eliminar.CellContentDoubleClick
        Dim id_marca As String = Me.dgv_consultar_eliminar.CurrentRow.Cells(0).Value
        If Me.chk_borrar.Checked = True Then
            If MessageBox.Show("¿Está seguro que quiere borrar a " & Me.dgv_consultar_eliminar.CurrentRow.Cells(0).Value & "?" _
                               , "Importante", MessageBoxButtons.YesNo _
                               , MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.marca.borrar(id_marca)
                cargar_grilla()
            End If
        End If
    End Sub
End Class