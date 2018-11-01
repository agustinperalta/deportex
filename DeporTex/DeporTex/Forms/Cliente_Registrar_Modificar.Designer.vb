<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente_Registrar_Modificar
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
        Me.dgv_registrar_eliminar = New System.Windows.Forms.DataGridView()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_nac = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cuil_cliente = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_sexo = New System.Windows.Forms.MaskedTextBox()
        Me.txt_numero = New System.Windows.Forms.MaskedTextBox()
        Me.txt_email = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_nro_tarjeta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgv_registrar_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_registrar_eliminar
        '
        Me.dgv_registrar_eliminar.AllowUserToAddRows = False
        Me.dgv_registrar_eliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_registrar_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_registrar_eliminar.Location = New System.Drawing.Point(320, 42)
        Me.dgv_registrar_eliminar.Name = "dgv_registrar_eliminar"
        Me.dgv_registrar_eliminar.Size = New System.Drawing.Size(1038, 338)
        Me.dgv_registrar_eliminar.TabIndex = 16
        '
        'cmd_grabar
        '
        Me.cmd_grabar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_grabar.Location = New System.Drawing.Point(227, 449)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_grabar.TabIndex = 11
        Me.cmd_grabar.Text = "Grabar"
        Me.cmd_grabar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_nuevo.Location = New System.Drawing.Point(123, 449)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 10
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(71, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(87, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Calle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(9, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha de nacimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(84, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Sexo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(42, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cuil de cliente"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(123, 243)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(181, 20)
        Me.txt_calle.TabIndex = 5
        '
        'txt_fecha_nac
        '
        Me.txt_fecha_nac.Location = New System.Drawing.Point(121, 204)
        Me.txt_fecha_nac.Mask = "00/00/0000"
        Me.txt_fecha_nac.Name = "txt_fecha_nac"
        Me.txt_fecha_nac.Size = New System.Drawing.Size(77, 20)
        Me.txt_fecha_nac.TabIndex = 4
        Me.txt_fecha_nac.ValidatingType = GetType(Date)
        '
        'txt_cuil_cliente
        '
        Me.txt_cuil_cliente.Location = New System.Drawing.Point(121, 43)
        Me.txt_cuil_cliente.Mask = "9999999999"
        Me.txt_cuil_cliente.Name = "txt_cuil_cliente"
        Me.txt_cuil_cliente.Size = New System.Drawing.Size(77, 20)
        Me.txt_cuil_cliente.TabIndex = 0
        Me.txt_cuil_cliente.ValidatingType = GetType(Integer)
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(121, 80)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(183, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(71, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Nombre"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(121, 122)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(183, 20)
        Me.txt_apellido.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(71, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Apellido"
        '
        'txt_sexo
        '
        Me.txt_sexo.Location = New System.Drawing.Point(121, 161)
        Me.txt_sexo.Mask = "a"
        Me.txt_sexo.Name = "txt_sexo"
        Me.txt_sexo.Size = New System.Drawing.Size(24, 20)
        Me.txt_sexo.TabIndex = 3
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(121, 282)
        Me.txt_numero.Mask = "999999999"
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(99, 20)
        Me.txt_numero.TabIndex = 6
        Me.txt_numero.ValidatingType = GetType(Integer)
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(121, 325)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(181, 20)
        Me.txt_email.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(71, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(26, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Numero de tarjeta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(66, 407)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Telefono"
        '
        'txt_nro_tarjeta
        '
        Me.txt_nro_tarjeta.Location = New System.Drawing.Point(123, 364)
        Me.txt_nro_tarjeta.Name = "txt_nro_tarjeta"
        Me.txt_nro_tarjeta.Size = New System.Drawing.Size(181, 20)
        Me.txt_nro_tarjeta.TabIndex = 8
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(123, 404)
        Me.txt_telefono.Mask = "9999999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(97, 20)
        Me.txt_telefono.TabIndex = 9
        Me.txt_telefono.ValidatingType = GetType(Integer)
        '
        'Cliente_Registrar_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 496)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_nro_tarjeta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.txt_sexo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.dgv_registrar_eliminar)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_fecha_nac)
        Me.Controls.Add(Me.txt_cuil_cliente)
        Me.Name = "Cliente_Registrar_Modificar"
        Me.Text = "Cliente_Registrar_Modificar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_registrar_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_registrar_eliminar As DataGridView
    Friend WithEvents cmd_grabar As Button
    Friend WithEvents cmd_nuevo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_calle As MaskedTextBox
    Friend WithEvents txt_fecha_nac As MaskedTextBox
    Friend WithEvents txt_cuil_cliente As MaskedTextBox
    Friend WithEvents txt_nombre As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_apellido As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_sexo As MaskedTextBox
    Friend WithEvents txt_numero As MaskedTextBox
    Friend WithEvents txt_email As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_nro_tarjeta As MaskedTextBox
    Friend WithEvents txt_telefono As MaskedTextBox
End Class
