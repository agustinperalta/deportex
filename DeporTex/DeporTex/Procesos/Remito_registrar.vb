Public Class Remito_registrar
    Dim BD As New Conexion_Transacciones
    Dim tabla As New DataTable
    Dim total As Integer
    Private Sub SetFecha()
        ' Set the MinDate and MaxDate.
        Me.dtp_fecha_remito.MinDate = New DateTime(1985, 6, 20)
        dtp_fecha_remito.MaxDate = DateTime.Today.AddYears(2)

        ' Set the CustomFormat string.
        dtp_fecha_remito.CustomFormat = "MMMM dd, yyyy - dddd"
        dtp_fecha_remito.Format = DateTimePickerFormat.Custom
        Me.dtp_fecha_remito.Value = DateTime.Today

    End Sub

    Private Sub Remito_registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabla.Columns.Add("Marca")
        tabla.Columns.Add("TipoArticulo")
        tabla.Columns.Add("Articulo")
        tabla.Columns.Add("Cantidad")
        tabla.Columns.Add("PrecioUnitario")
        txt_numero_remito.Focus()
        cargar_combo(cmb_Marca, "SELECT * FROM Marcas")
        cargar_combo(cmb_tipo_articulo, "SELECT * FROM TipoArticulo")
        cargar_combo(cmb_articulo, "SELECT cod_articulo,nombre FROM Articulos")
        blanquear_remito()
        blanquear_detalle_remito()
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

    Public Sub blanquear_remito()
        txt_numero_remito.Text = ""
        txt_total.Text = ""
        txt_numero_remito.Focus()
        dgv_remito.DataSource = Nothing
    End Sub

    Public Sub blanquear_detalle_remito()
        cmb_Marca.SelectedIndex = -1
        cmb_tipo_articulo.SelectedIndex = -1
        cmb_articulo.SelectedIndex = -1
        txt_cantidad.Text = ""
        txt_precioUnitario.Text = ""
        txt_subtotal.Text = ""
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        blanquear_remito()
        dgv_remito.DataSource = Nothing
    End Sub

    Public Sub insertar_detalles()
        Dim c As Integer = 0
        For c = 0 To dgv_remito.Rows.Count - 1
            Dim articulo As String = dgv_remito.Rows(c).Cells(2).Value
            Dim id_articulo As String = devolver_codigo("SELECT * FROM Articulos WHERE nombre = '" & articulo & "'")
            Dim cantidad As String = dgv_remito.Rows(c).Cells(3).Value
            Dim sql As String = "INSERT INTO DetalleRemito (nro_remito, cod_articulo, cantidad) VALUES ('" & txt_numero_remito.Text.Trim() & "', '" & id_articulo & "', '" & cantidad & "')"
            BD.INS_MOD_BOR(sql)
        Next

    End Sub

    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click
        If dgv_remito.Rows.Count = 0 Then
            MsgBox("No se cargó ningun articulo en el remito.")
            Exit Sub
        End If
        BD.iniciarTransaccion()
        Dim sql As String = ""
        sql &= "INSERT INTO Remitos(nro_remito, fecha_remito) VALUES ('" & txt_numero_remito.Text.Trim() & "' , '" & dtp_fecha_remito.Text.Trim & "')"
        BD.INS_MOD_BOR(sql)
        insertar_detalles()
        BD.FinTransaccion()
        blanquear_remito()
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
        Dim conx As New Conexion
        Dim tabla As DataTable
        tabla = Me.BD.leo_tabla(sql)
        Return tabla.Rows(0).Item(0)

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
        If txt_numero_remito.Text = "" Then
            MsgBox("Falta asignar el numero de remito")
        End If
        cargar_grilla(tabla)

        total = total + Integer.Parse(txt_subtotal.Text)
        txt_total.Text = total.ToString()
        blanquear_detalle_remito()
    End Sub
    Public Sub cargar_grilla(ByRef tabla As DataTable)

        Dim fila As DataRow = tabla.NewRow

        fila("Marca") = cmb_Marca.Text
        fila("TipoArticulo") = cmb_tipo_articulo.Text
        fila("Articulo") = cmb_articulo.Text
        fila("Cantidad") = txt_cantidad.Text
        fila("PrecioUnitario") = txt_precioUnitario.Text
        tabla.Rows.Add(fila)
        dgv_remito.DataSource = tabla
    End Sub

End Class