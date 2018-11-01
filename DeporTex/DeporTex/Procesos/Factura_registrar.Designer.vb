<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura_registrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_tipo_factura = New System.Windows.Forms.ComboBox()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.GroupBoxDetalle = New System.Windows.Forms.GroupBox()
        Me.dgv_factura = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_numero_cliente = New System.Windows.Forms.MaskedTextBox()
        Me.dtp_fecha_venta = New System.Windows.Forms.DateTimePicker()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.box_detalles = New System.Windows.Forms.GroupBox()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_precioUnitario = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_articulo = New System.Windows.Forms.ComboBox()
        Me.cmb_Marca = New System.Windows.Forms.ComboBox()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_articulo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_nro_factura = New System.Windows.Forms.MaskedTextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBoxDetalle.SuspendLayout()
        CType(Me.dgv_factura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box_detalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Tipo de factura"
        '
        'cmb_tipo_factura
        '
        Me.cmb_tipo_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_factura.FormattingEnabled = True
        Me.cmb_tipo_factura.Location = New System.Drawing.Point(137, 23)
        Me.cmb_tipo_factura.Name = "cmb_tipo_factura"
        Me.cmb_tipo_factura.Size = New System.Drawing.Size(126, 21)
        Me.cmb_tipo_factura.TabIndex = 39
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_nuevo.Location = New System.Drawing.Point(501, 499)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 51
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'GroupBoxDetalle
        '
        Me.GroupBoxDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDetalle.Controls.Add(Me.Label10)
        Me.GroupBoxDetalle.Controls.Add(Me.txt_total)
        Me.GroupBoxDetalle.Controls.Add(Me.dgv_factura)
        Me.GroupBoxDetalle.Location = New System.Drawing.Point(31, 148)
        Me.GroupBoxDetalle.Name = "GroupBoxDetalle"
        Me.GroupBoxDetalle.Size = New System.Drawing.Size(637, 341)
        Me.GroupBoxDetalle.TabIndex = 38
        Me.GroupBoxDetalle.TabStop = False
        Me.GroupBoxDetalle.Text = "Detalle de Factura"
        '
        'dgv_factura
        '
        Me.dgv_factura.AllowUserToAddRows = False
        Me.dgv_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_factura.Location = New System.Drawing.Point(10, 22)
        Me.dgv_factura.Name = "dgv_factura"
        Me.dgv_factura.ReadOnly = True
        Me.dgv_factura.Size = New System.Drawing.Size(616, 277)
        Me.dgv_factura.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Numero de cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Numero Factura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Fecha de venta"
        '
        'txt_numero_cliente
        '
        Me.txt_numero_cliente.Location = New System.Drawing.Point(137, 109)
        Me.txt_numero_cliente.Name = "txt_numero_cliente"
        Me.txt_numero_cliente.Size = New System.Drawing.Size(71, 20)
        Me.txt_numero_cliente.TabIndex = 30
        '
        'dtp_fecha_venta
        '
        Me.dtp_fecha_venta.CalendarTitleBackColor = System.Drawing.Color.LightSeaGreen
        Me.dtp_fecha_venta.Location = New System.Drawing.Point(137, 80)
        Me.dtp_fecha_venta.MaxDate = New Date(2018, 5, 30, 0, 0, 0, 0)
        Me.dtp_fecha_venta.Name = "dtp_fecha_venta"
        Me.dtp_fecha_venta.Size = New System.Drawing.Size(211, 20)
        Me.dtp_fecha_venta.TabIndex = 29
        Me.dtp_fecha_venta.Value = New Date(2018, 5, 27, 0, 0, 0, 0)
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Location = New System.Drawing.Point(582, 499)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_registrar.TabIndex = 51
        Me.cmd_registrar.Text = "Registrar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'box_detalles
        '
        Me.box_detalles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.box_detalles.Controls.Add(Me.txt_cantidad)
        Me.box_detalles.Controls.Add(Me.cmd_agregar)
        Me.box_detalles.Controls.Add(Me.txt_subtotal)
        Me.box_detalles.Controls.Add(Me.txt_precioUnitario)
        Me.box_detalles.Controls.Add(Me.cmb_tipo_articulo)
        Me.box_detalles.Controls.Add(Me.cmb_Marca)
        Me.box_detalles.Controls.Add(Me.lbl_1)
        Me.box_detalles.Controls.Add(Me.Label6)
        Me.box_detalles.Controls.Add(Me.Label7)
        Me.box_detalles.Controls.Add(Me.Label4)
        Me.box_detalles.Controls.Add(Me.Label8)
        Me.box_detalles.Controls.Add(Me.cmb_articulo)
        Me.box_detalles.Controls.Add(Me.Label9)
        Me.box_detalles.Location = New System.Drawing.Point(684, 148)
        Me.box_detalles.Name = "box_detalles"
        Me.box_detalles.Size = New System.Drawing.Size(250, 341)
        Me.box_detalles.TabIndex = 54
        Me.box_detalles.TabStop = False
        Me.box_detalles.Text = "Cargar Articulo"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(102, 105)
        Me.txt_cantidad.Mask = "99999"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(59, 20)
        Me.txt_cantidad.TabIndex = 59
        Me.txt_cantidad.ValidatingType = GetType(Integer)
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Location = New System.Drawing.Point(163, 221)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_agregar.TabIndex = 53
        Me.cmd_agregar.Text = "Agregar"
        Me.cmd_agregar.UseVisualStyleBackColor = True
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(102, 175)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(59, 20)
        Me.txt_subtotal.TabIndex = 58
        '
        'txt_precioUnitario
        '
        Me.txt_precioUnitario.Location = New System.Drawing.Point(102, 133)
        Me.txt_precioUnitario.Name = "txt_precioUnitario"
        Me.txt_precioUnitario.ReadOnly = True
        Me.txt_precioUnitario.Size = New System.Drawing.Size(59, 20)
        Me.txt_precioUnitario.TabIndex = 57
        '
        'cmb_tipo_articulo
        '
        Me.cmb_tipo_articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_articulo.FormattingEnabled = True
        Me.cmb_tipo_articulo.Location = New System.Drawing.Point(102, 46)
        Me.cmb_tipo_articulo.Name = "cmb_tipo_articulo"
        Me.cmb_tipo_articulo.Size = New System.Drawing.Size(136, 21)
        Me.cmb_tipo_articulo.TabIndex = 55
        '
        'cmb_Marca
        '
        Me.cmb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Marca.FormattingEnabled = True
        Me.cmb_Marca.Location = New System.Drawing.Point(102, 19)
        Me.cmb_Marca.Name = "cmb_Marca"
        Me.cmb_Marca.Size = New System.Drawing.Size(136, 21)
        Me.cmb_Marca.TabIndex = 53
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Location = New System.Drawing.Point(47, 112)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(49, 13)
        Me.lbl_1.TabIndex = 45
        Me.lbl_1.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Precio unitario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Subtotal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Tipo de articulo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Marca"
        '
        'cmb_articulo
        '
        Me.cmb_articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_articulo.FormattingEnabled = True
        Me.cmb_articulo.Location = New System.Drawing.Point(102, 75)
        Me.cmb_articulo.Name = "cmb_articulo"
        Me.cmb_articulo.Size = New System.Drawing.Size(136, 21)
        Me.cmb_articulo.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Articulo"
        '
        'txt_nro_factura
        '
        Me.txt_nro_factura.Location = New System.Drawing.Point(137, 50)
        Me.txt_nro_factura.Name = "txt_nro_factura"
        Me.txt_nro_factura.Size = New System.Drawing.Size(126, 20)
        Me.txt_nro_factura.TabIndex = 55
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(567, 305)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(59, 20)
        Me.txt_total.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(525, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Total"
        '
        'Factura_registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 534)
        Me.Controls.Add(Me.txt_nro_factura)
        Me.Controls.Add(Me.box_detalles)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_tipo_factura)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.GroupBoxDetalle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_numero_cliente)
        Me.Controls.Add(Me.dtp_fecha_venta)
        Me.Name = "Factura_registrar"
        Me.Text = "Factura_registrar"
        Me.GroupBoxDetalle.ResumeLayout(False)
        Me.GroupBoxDetalle.PerformLayout()
        CType(Me.dgv_factura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box_detalles.ResumeLayout(False)
        Me.box_detalles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_tipo_factura As ComboBox
    Friend WithEvents cmd_nuevo As Button
    Friend WithEvents GroupBoxDetalle As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_numero_cliente As MaskedTextBox
    Friend WithEvents dtp_fecha_venta As DateTimePicker
    Friend WithEvents dgv_factura As DataGridView
    Friend WithEvents cmd_registrar As Button
    Friend WithEvents box_detalles As GroupBox
    Friend WithEvents txt_cantidad As MaskedTextBox
    Friend WithEvents cmd_agregar As Button
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents txt_precioUnitario As TextBox
    Friend WithEvents cmb_tipo_articulo As ComboBox
    Friend WithEvents cmb_Marca As ComboBox
    Friend WithEvents lbl_1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_articulo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_nro_factura As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_total As TextBox
End Class
