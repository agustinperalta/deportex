Public Class Cliente_Consultar_Eliminar
    Dim conex As New Conexion
    Dim cliente As New Cliente
    Private Sub Cliente_Consultar_Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub txt_busqueda_Enter(sender As Object, e As EventArgs) Handles txt_busqueda.Enter
        txt_busqueda.Clear()
    End Sub
    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT cuil_cliente As 'Cuil clientes', nombre As 'Nombre', apellido As 'Apellido', sexo As 'Sexo', fecha_nac As 'Fecha de Nacimiento', calle as 'Calle', numero As 'Numero', email As 'Email', nroTarjetaBeneficio As 'Numero de Tarjeta', telefono As 'Telefono' FROM Clientes "
        Me.dgv_consultar_eliminar_cliente.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim sql As String

        sql = "Select * From Clientes Where cuil_cliente = '" & txt_busqueda.Text & "'"
        Me.dgv_consultar_eliminar_cliente.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub cmd_refrescar_Click(sender As Object, e As EventArgs) Handles cmd_refrescar.Click
        cargar_grilla()
    End Sub

    Private Sub dgv_consultar_eliminar_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_consultar_eliminar_cliente.CellContentClick
        Dim cuil_cliente As String = Me.dgv_consultar_eliminar_cliente.CurrentRow.Cells(0).Value
        If Me.chk_borrar.Checked = True Then
            If MessageBox.Show("¿Está seguro que quiere borrar a " & Me.dgv_consultar_eliminar_cliente.CurrentRow.Cells(0).Value & "?" _
                               , "Importante", MessageBoxButtons.YesNo _
                               , MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.cliente.borrar(cuil_cliente)
                cargar_grilla()
            End If
        End If
    End Sub
End Class