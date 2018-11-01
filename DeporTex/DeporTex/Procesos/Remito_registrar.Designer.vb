<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Remito_registrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.GroupBoxDetalle = New System.Windows.Forms.GroupBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_remito = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.txt_numero_remito = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.box_detalles = New System.Windows.Forms.GroupBox()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_precioUnitario = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_articulo = New System.Windows.Forms.ComboBox()
        Me.cmb_Marca = New System.Windows.Forms.ComboBox()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_articulo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_fecha_remito = New System.Windows.Forms.DateTimePicker()
        Me.GroupBoxDetalle.SuspendLayout()
        CType(Me.dgv_remito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box_detalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_nuevo.Location = New System.Drawing.Point(486, 443)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 45
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'GroupBoxDetalle
        '
        Me.GroupBoxDetalle.Controls.Add(Me.txt_total)
        Me.GroupBoxDetalle.Controls.Add(Me.Label8)
        Me.GroupBoxDetalle.Controls.Add(Me.dgv_remito)
        Me.GroupBoxDetalle.Location = New System.Drawing.Point(31, 81)
        Me.GroupBoxDetalle.Name = "GroupBoxDetalle"
        Me.GroupBoxDetalle.Size = New System.Drawing.Size(611, 341)
        Me.GroupBoxDetalle.TabIndex = 49
        Me.GroupBoxDetalle.TabStop = False
        Me.GroupBoxDetalle.Text = "Detalle de remito"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(536, 311)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(59, 20)
        Me.txt_total.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(494, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Total"
        '
        'dgv_remito
        '
        Me.dgv_remito.AllowUserToAddRows = False
        Me.dgv_remito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_remito.Location = New System.Drawing.Point(6, 19)
        Me.dgv_remito.Name = "dgv_remito"
        Me.dgv_remito.ReadOnly = True
        Me.dgv_remito.Size = New System.Drawing.Size(585, 283)
        Me.dgv_remito.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Numero remito"
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Location = New System.Drawing.Point(567, 443)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_registrar.TabIndex = 50
        Me.cmd_registrar.Text = "Registrar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'txt_numero_remito
        '
        Me.txt_numero_remito.Location = New System.Drawing.Point(125, 17)
        Me.txt_numero_remito.Name = "txt_numero_remito"
        Me.txt_numero_remito.Size = New System.Drawing.Size(127, 20)
        Me.txt_numero_remito.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Fecha de remito"
        '
        'box_detalles
        '
        Me.box_detalles.Controls.Add(Me.cmd_agregar)
        Me.box_detalles.Controls.Add(Me.txt_cantidad)
        Me.box_detalles.Controls.Add(Me.txt_subtotal)
        Me.box_detalles.Controls.Add(Me.txt_precioUnitario)
        Me.box_detalles.Controls.Add(Me.cmb_tipo_articulo)
        Me.box_detalles.Controls.Add(Me.cmb_Marca)
        Me.box_detalles.Controls.Add(Me.lbl_1)
        Me.box_detalles.Controls.Add(Me.Label6)
        Me.box_detalles.Controls.Add(Me.Label7)
        Me.box_detalles.Controls.Add(Me.Label4)
        Me.box_detalles.Controls.Add(Me.Label3)
        Me.box_detalles.Controls.Add(Me.cmb_articulo)
        Me.box_detalles.Controls.Add(Me.Label5)
        Me.box_detalles.Location = New System.Drawing.Point(648, 81)
        Me.box_detalles.Name = "box_detalles"
        Me.box_detalles.Size = New System.Drawing.Size(258, 341)
        Me.box_detalles.TabIndex = 53
        Me.box_detalles.TabStop = False
        Me.box_detalles.Text = "Cargar Articulo"
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Location = New System.Drawing.Point(167, 205)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_agregar.TabIndex = 54
        Me.cmd_agregar.Text = "Agregar"
        Me.cmd_agregar.UseVisualStyleBackColor = True
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
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(102, 159)
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
        Me.Label7.Location = New System.Drawing.Point(42, 166)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Marca"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Articulo"
        '
        'dtp_fecha_remito
        '
        Me.dtp_fecha_remito.Location = New System.Drawing.Point(125, 43)
        Me.dtp_fecha_remito.Name = "dtp_fecha_remito"
        Me.dtp_fecha_remito.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fecha_remito.TabIndex = 54
        '
        'Remito_registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 478)
        Me.Controls.Add(Me.dtp_fecha_remito)
        Me.Controls.Add(Me.box_detalles)
        Me.Controls.Add(Me.txt_numero_remito)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.GroupBoxDetalle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Remito_registrar"
        Me.Text = "Remito_registrar"
        Me.GroupBoxDetalle.ResumeLayout(False)
        Me.GroupBoxDetalle.PerformLayout()
        CType(Me.dgv_remito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box_detalles.ResumeLayout(False)
        Me.box_detalles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_nuevo As Button
    Friend WithEvents GroupBoxDetalle As GroupBox
    Friend WithEvents dgv_remito As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cmd_registrar As Button
    Friend WithEvents txt_numero_remito As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents box_detalles As GroupBox
    Friend WithEvents cmd_agregar As Button
    Friend WithEvents txt_cantidad As MaskedTextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents txt_precioUnitario As TextBox
    Friend WithEvents cmb_tipo_articulo As ComboBox
    Friend WithEvents cmb_Marca As ComboBox
    Friend WithEvents lbl_1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_articulo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_fecha_remito As DateTimePicker
End Class
