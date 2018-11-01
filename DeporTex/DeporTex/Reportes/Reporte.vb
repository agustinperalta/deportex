Public Class Reporte
    Dim _BD As New Conexion
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load







    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim sql As String = "SELECT cuil_cliente, nombre, apellido, COUNT(F.nro_factura) FROM Clientes C INNER JOIN FACTURAS F ON (C.cuil_cliente = F.nro_cliente)  GROUP BY cuil_cliente, nombre, apellido ORDER BY COUNT(F.nro_factura) DESC"
        'If IsNumeric(txt_datos_buscar.Text) Then
        '    sql &= " WHERE id_estado = '" & Me.txt_datos_buscar.Text & "'"
        'Else
        '    If Me.txt_datos_buscar.Text.IndexOf("-") >= 1 Then
        '        Dim extremos As String()
        '        extremos = Me.txt_datos_buscar.Text.Split("-")
        '        If IsNumeric(extremos(0)) And IsNumeric(extremos(1)) Then
        '            sql &= " WHERE id_estado BETWEEN " & extremos(0) & " AND " & extremos(1)
        '        Else
        '            MsgBox("Error en dato de calculo.")
        '        End If
        '    Else
        '        sql &= " WHERE n_estado LIKE '%" & Me.txt_datos_buscar.Text.Trim() & "%'"
        '    End If
        'End If

        'Forma de programacion mejorada
        ClienteBindingSource.DataSource = _BD.leo_tabla(sql)
        Me.rv_clientes.RefreshReport()
    End Sub

    Private Sub cmd_buscar2_Click(sender As Object, e As EventArgs) Handles cmd_buscar2.Click
        Dim sql As String = "SELECT DF.cod_articulo, A.nombre, COUNT(DF.cod_articulo) FROM Articulos A INNER JOIN DetalleFactura DF ON (A.cod_articulo = DF.cod_articulo) GROUP BY DF.cod_Articulo, A.nombre ORDER BY COUNT(DF.cod_articulo) DESC"
        'If IsNumeric(txt_datos_buscar.Text) Then
        '    sql &= " WHERE id_estado = '" & Me.txt_datos_buscar.Text & "'"
        'Else
        '    If Me.txt_datos_buscar.Text.IndexOf("-") >= 1 Then
        '        Dim extremos As String()
        '        extremos = Me.txt_datos_buscar.Text.Split("-")
        '        If IsNumeric(extremos(0)) And IsNumeric(extremos(1)) Then
        '            sql &= " WHERE id_estado BETWEEN " & extremos(0) & " AND " & extremos(1)
        '        Else
        '            MsgBox("Error en dato de calculo.")
        '        End If
        '    Else
        '        sql &= " WHERE n_estado LIKE '%" & Me.txt_datos_buscar.Text.Trim() & "%'"
        '    End If
        'End If

        'Forma de programacion mejorada
        ArticuloBindingSource.DataSource = _BD.leo_tabla(sql)
        Me.rv_articulo.RefreshReport()
    End Sub

    Private Sub cmd_buscar3_Click(sender As Object, e As EventArgs) Handles cmd_buscar3.Click
        Dim sql As String = "SELECT tipoFactura,nombre,COUNT(f.tipo_factura)
                                FROM TipoFactura TF inner join Facturas f on (f.tipo_factura = tf.tipofactura) 
                                Group by tipoFactura,nombre
                                order by COUNT(f.tipo_factura) desc"

        TipoFacturaBindingSource.DataSource = _BD.leo_tabla(sql)
        Me.rv_tipoFactura.RefreshReport()
    End Sub

    Private Sub cmd_buscar4_Click(sender As Object, e As EventArgs) Handles cmd_buscar4.Click
        Dim sql As String = "SELECT M.id_marca, M.nombre,COUNT(a.id_marca)
                                FROM marcas m inner join articulos a on (a.id_marca = m.id_marca) inner join detalleFactura df on (df.cod_articulo = a.cod_articulo) 
                                Group by M.id_marca, M.nombre
                                order by COUNT(a.id_marca) desc "

        MarcasBindingSource.DataSource = _BD.leo_tabla(Sql)
        Me.rv_marca.RefreshReport()
    End Sub

    Private Sub cmd_buscar5_Click(sender As Object, e As EventArgs) Handles cmd_buscar5.Click
        Dim sql As String = "SELECT f.nro_factura, f.tipo_factura, f.nro_cliente, SUM(df.precio)
                                from facturas f inner join detalleFactura df on (f.nro_factura = df.nro_factura and f.tipo_factura = df.tipofactura)
                                group by f.nro_factura, f.tipo_factura, f.nro_cliente  
                                having SUM(df.precio) >= '" & txt_buscar.Text.Trim & "'"

        FacturaBindingSource.DataSource = _BD.leo_tabla(sql)
        Me.rv_factura.RefreshReport()
    End Sub

    Private Sub cmd_buscar6_Click(sender As Object, e As EventArgs) Handles cmd_buscar6.Click
        Dim sql As String = "SELECT ta.id_tipo, ta.nombre,COUNT(a.id_tipo_articulo)
                            FROM tipoArticulo ta inner join articulos a on (a.id_tipo_articulo = ta.id_tipo) 
                            Group by ta.id_tipo, ta.nombre
                            order by COUNT(a.id_tipo_articulo) "

        TipoArticuloBindingSource.DataSource = _BD.leo_tabla(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class