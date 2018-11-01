Public Class Factura_consultar
    Dim BD As New Conexion_Transacciones
    Private Sub Remito_consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo(cmb_tipo_factura, "SELECT * FROM TipoFactura")
        txt_numero_factura.Focus()
        blanquear()
    End Sub
    Public Sub cargar_combo(ByRef combo As ComboBox, ByVal sql As String)
        Dim tabla As New DataTable
        tabla = BD.leo_tabla(sql)
        combo.DataSource = tabla
        combo.DisplayMember = tabla.Columns(1).ColumnName
        combo.ValueMember = tabla.Columns(0).ColumnName
    End Sub

    Public Sub blanquear()
        txt_numero_factura.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        If txt_numero_factura.Text = "" Then
            MsgBox("Falta numero de factura")
            Exit Sub
        End If
        If txt_fecha_desde.Text = "" Then
            MsgBox("Falta fecha desde")
            Exit Sub
        End If
        If txt_fecha_hasta.Text = "" Then
            MsgBox("Falta fecha hasta")
            Exit Sub
        End If
        Dim sql As String = ""
        Dim id_tipo As String = devolver_codigo("SELECT * FROM TipoFactura WHERE nombre = '" & cmb_tipo_factura.Text.Trim() & "'")
        sql &= "SELECT * FROM Facturas WHERE nro_factura = '" & txt_numero_factura.Text.Trim() & "' AND tipo_factura = '" & id_tipo & "'" ' AND fecha_venta BETWEEN '" & txt_fecha_desde.Text.Trim() & "' AND '" & txt_fecha_hasta.Text.Trim() & "'"
        dgv_factura_consultar.DataSource = BD.leo_tabla(sql)
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        blanquear()
        txt_numero_factura.Focus()
        dgv_factura_consultar.DataSource = Nothing
    End Sub
    Private Function devolver_codigo(ByVal sql As String)
        Dim conx As New Conexion
        Dim tabla As DataTable
        tabla = Me.BD.leo_tabla(sql)
        Return tabla.Rows(0).Item(0)

    End Function
End Class