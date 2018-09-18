Public Class Proveedor_Consultar_eliminar
    Dim conex As New Conexion
    Dim proveedor As New Proveedor
    Private Sub Articulo_Consultar_Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub txt_busqueda_Enter(sender As Object, e As EventArgs) Handles txt_busqueda.Enter
        txt_busqueda.Clear()
    End Sub
    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT cuil_proveedor As 'Cuil Proveedor', razonSocial As 'Razon Social', telefono As 'Telefono' FROM Proveedores"
        Me.dgv_consultar_proveedor.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim sql As String

        sql = "Select * From Proveedores Where cuil_proveedor = '" & txt_busqueda.Text & "'"
        Me.dgv_consultar_proveedor.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub cmd_refrescar_Click(sender As Object, e As EventArgs) Handles cmd_refrescar.Click
        cargar_grilla()
    End Sub

    Private Sub dgv_consultar_proveedor_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_consultar_proveedor.CellContentDoubleClick
        Dim cuil_proveedor As String = Me.dgv_consultar_proveedor.CurrentRow.Cells(0).Value
        If Me.chk_borrar.Checked = True Then
            If MessageBox.Show("¿Está seguro que quiere borrar a " & Me.dgv_consultar_proveedor.CurrentRow.Cells(0).Value & "?" _
                               , "Importante", MessageBoxButtons.YesNo _
                               , MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.proveedor.borrar(cuil_proveedor)
                cargar_grilla()
            End If
        End If
    End Sub
End Class