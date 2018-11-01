Public Class Factura_registrar
    Dim BD As New Conexion_Transacciones
    Dim tabla As New DataTable
    Dim total As Integer
    Private Sub SetFecha()
        ' Set the MinDate and MaxDate.
        Me.dtp_fecha_venta.MinDate = New DateTime(1985, 6, 20)
        dtp_fecha_venta.MaxDate = DateTime.Today.AddYears(2)

        ' Set the CustomFormat string.
        dtp_fecha_venta.CustomFormat = "MMMM dd, yyyy - dddd"
        dtp_fecha_venta.Format = DateTimePickerFormat.Custom
        Me.dtp_fecha_venta.Value = DateTime.Today

    End Sub

    Private Sub Remito_registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabla.Columns.Add("Tipo de Factura")
        tabla.Columns.Add("Codigo Articulo")
        tabla.Columns.Add("Cantidad")
        tabla.Columns.Add("Precio")
        cmb_tipo_factura.Focus()
        cargar_combo(cmb_tipo_factura, "SELECT * FROM TipoFactura")
        cargar_combo(cmb_Marca, "SELECT * FROM Marcas")
        cargar_combo(cmb_tipo_articulo, "SELECT * FROM TipoArticulo")
        cargar_combo(cmb_articulo, "SELECT cod_articulo,nombre FROM Articulos")
        'blanquear_remito()
        'blanquear_detalle_remito()
        If cmb_Marca.SelectedIndex = -1 Then
            cmb_tipo_articulo.Enabled = False
            cmb_articulo.Enabled = False
        End If
        If cmb_tipo_articulo.SelectedIndex = -1 Then
            cmb_articulo.Enabled = False
        End If
        SetFecha()
    End Sub

    Public Sub cargar_combo(ByRef combo As ComboBox, ByVal sql As String)
        Dim tabla As New DataTable
        tabla = BD.leo_tabla(sql)
        combo.DataSource = tabla
        combo.DisplayMember = tabla.Columns(1).ColumnName
        combo.ValueMember = tabla.Columns(0).ColumnName
    End Sub

    Public Sub blanquear_factura()
        cmb_tipo_factura.SelectedIndex = -1

        txt_nro_factura.Text = ""
        txt_numero_cliente.Text = ""

        txt_total.Text = ""
        txt_nro_factura.Focus()
        dgv_factura.DataSource = Nothing
    End Sub
    Public Sub blanquear_detalle()
        cmb_Marca.SelectedIndex = -1
        cmb_tipo_articulo.SelectedIndex = -1
        cmb_articulo.SelectedIndex = -1
        txt_precioUnitario.Text = ""
        txt_cantidad.Text = ""
        txt_subtotal.Text = ""

    End Sub

    Public Sub blanquear_detalle_factura()
        cmb_Marca.SelectedIndex = -1
        cmb_tipo_articulo.SelectedIndex = -1
        cmb_articulo.SelectedIndex = -1
        txt_cantidad.Text = ""
        txt_precioUnitario.Text = ""
        txt_subtotal.Text = ""
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        blanquear_factura()
        blanquear_detalle_factura()
        dgv_factura.DataSource = Nothing
    End Sub

    Public Sub insertar_detalles()
        Dim c As Integer = 0
        For c = 0 To dgv_factura.Rows.Count - 1
            Dim tipofactura As String = dgv_factura.Rows(c).Cells(0).Value
            Dim id_tipo_factura As String = devolver_codigo("SELECT tipoFactura FROM TipoFactura WHERE nombre = '" & tipofactura & "'")
            Dim numero_factura As String = txt_nro_factura.Text.Trim()
            Dim orden As String = c
            Dim articulo As String = dgv_factura.Rows(c).Cells(1).Value
            Dim id_articulo As String = devolver_codigo("SELECT * FROM Articulos WHERE nombre = '" & articulo & "'")
            Dim cantidad As String = dgv_factura.Rows(c).Cells(2).Value
            Dim precio As String = dgv_factura.Rows(c).Cells(3).Value
            Dim sql As String = "INSERT INTO DetalleFactura (tipoFactura, nro_factura, orden, cod_articulo, precio, cantidad) VALUES ('" & id_tipo_factura & "', '" & numero_factura & "','" & orden & "','" & id_articulo & "','" & precio & "', '" & cantidad & "')"
            BD.INS_MOD_BOR(sql)
        Next

    End Sub

    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click
        If dgv_factura.Rows.Count = 0 Then
            MsgBox("No se cargó ningun articulo en el remito.")
            Exit Sub
        End If
        BD.iniciarTransaccion()
        Dim sql As String = ""
        Dim tipofactura As String = cmb_tipo_factura.Text.Trim()
        Dim id_tipo_factura As String = devolver_codigo("SELECT * FROM TipoFactura WHERE nombre = '" & tipofactura & "'")
        sql &= "INSERT INTO Facturas(nro_factura, tipo_factura, fecha_venta, nro_cliente) VALUES ('" & txt_nro_factura.Text.Trim() & "','" & id_tipo_factura & "' , '" & dtp_fecha_venta.Text.Trim & "','" & txt_numero_cliente.Text.Trim() & "')"
        BD.INS_MOD_BOR(sql)
        insertar_detalles()
        BD.finTransaccion()
        blanquear_factura()
        blanquear_detalle_factura()
    End Sub

    Public Function obtener_precio()
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT precio FROM Articulos WHERE cod_articulo = '" & cmb_articulo.SelectedValue.trim() & "'"
        tabla = BD.leo_tabla(sql)
        Return tabla.Rows(0).Item(0)
    End Function

    Public Function calcular_subtotal()
        Dim subtotal As Double
        subtotal = Val(txt_cantidad.Text.Trim() * txt_precioUnitario.Text.Trim())
        Return subtotal.ToString()
    End Function

    Private Sub cmb_Marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Marca.SelectedIndexChanged
        If cmb_Marca.SelectedIndex = -1 Then
            cmb_articulo.Enabled = False
            cmb_tipo_articulo.Enabled = False
        Else
            cmb_tipo_articulo.Enabled = True
            cmb_articulo.Enabled = False
        End If
    End Sub

    Private Sub cmb_tipo_articulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_articulo.SelectedIndexChanged
        If cmb_tipo_articulo.SelectedIndex = -1 Then
            cmb_articulo.Enabled = False
        Else
            'Dim c As String = cmb_tipo_articulo.Text()
            'Dim id_tipo_articulo As String = devolver_codigo("SELECT id_tipo FROM TipoArticulo WHERE nombre = '" & c & "'")
            'cargar_combo(cmb_articulo, "SELECT * FROM Articulos WHERE id_tipo_articulo = " & id_tipo_articulo)
            cmb_articulo.Enabled = True
        End If
    End Sub
    Private Function devolver_codigo(ByVal sql As String)
        Dim tabla As New DataTable
        tabla = Me.BD.leo_tabla(sql)
        Return tabla.Rows(0).Item(0).ToString

    End Function


    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged
        If txt_cantidad.Text = "" Then
            txt_precioUnitario.Text = ""
            txt_subtotal.Text = ""
        Else
            txt_precioUnitario.Text = obtener_precio()
            txt_subtotal.Text = calcular_subtotal()
        End If
    End Sub

    Private Sub cmd_agregar_Click(sender As Object, e As EventArgs) Handles cmd_agregar.Click
        If txt_nro_factura.Text = "" Then
            MsgBox("Falta asignar el numero de factura")
        End If
        cargar_grilla(tabla)

        total = total + Integer.Parse(txt_subtotal.Text)
        txt_total.Text = total.ToString()
        blanquear_detalle_factura()
    End Sub
    Public Sub cargar_grilla(ByRef tabla As DataTable)

        Dim fila As DataRow = tabla.NewRow

        fila("Tipo de Factura") = cmb_tipo_factura.Text
        fila("Codigo Articulo") = cmb_articulo.Text
        fila("Cantidad") = txt_cantidad.Text
        fila("Precio") = txt_precioUnitario.Text
        tabla.Rows.Add(fila)
        dgv_factura.DataSource = tabla
    End Sub

    Private Sub txt_numero_factura_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub
End Class
