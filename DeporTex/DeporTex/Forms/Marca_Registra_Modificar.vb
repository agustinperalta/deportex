Public Class Marca_Registra_Modificar
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim conex As New Conexion
    Dim marca As New Marca
    Dim TE As New Tratamientos_Especiales

    Private Sub Articulo_Registrar_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT id_marca As 'Codigo Marca', nombre As 'Nombre' FROM Marcas"
        Me.dgv_registrar_modificar.DataSource = Me.conex.leo_tabla(sql)
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.txt_id_marca.Focus()
    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_grabar.Click
        Me.marca.transferir(Me)
        If control_estado_grabacion = estado_grabacion.insertar Then
            Me.marca.insertar()
        Else
            Me.marca.modificar()
        End If
        Me.cargar_grilla()
    End Sub

    Private Sub dgv_registrar_modificar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_registrar_modificar.CellContentClick
        Me.txt_id_marca.Text = dgv_registrar_modificar.CurrentRow.Cells(0).Value
        Me.txt_nombre.Text = dgv_registrar_modificar.CurrentRow.Cells(1).Value
        Me.control_estado_grabacion = estado_grabacion.modificar
    End Sub
End Class