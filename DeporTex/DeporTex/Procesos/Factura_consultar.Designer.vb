<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura_consultar
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
        Me.txt_numero_factura = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_factura_consultar = New System.Windows.Forms.DataGridView()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_tipo_factura = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_factura_consultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_numero_factura
        '
        Me.txt_numero_factura.Location = New System.Drawing.Point(159, 54)
        Me.txt_numero_factura.Name = "txt_numero_factura"
        Me.txt_numero_factura.Size = New System.Drawing.Size(121, 20)
        Me.txt_numero_factura.TabIndex = 0
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(159, 91)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(72, 20)
        Me.txt_fecha_desde.TabIndex = 1
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(319, 91)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(72, 20)
        Me.txt_fecha_hasta.TabIndex = 1
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero de Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha hasta"
        '
        'dgv_factura_consultar
        '
        Me.dgv_factura_consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_factura_consultar.Location = New System.Drawing.Point(58, 128)
        Me.dgv_factura_consultar.Name = "dgv_factura_consultar"
        Me.dgv_factura_consultar.Size = New System.Drawing.Size(693, 318)
        Me.dgv_factura_consultar.TabIndex = 3
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(531, 89)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 4
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(434, 89)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 4
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo Factura"
        '
        'cmb_tipo_factura
        '
        Me.cmb_tipo_factura.FormattingEnabled = True
        Me.cmb_tipo_factura.Location = New System.Drawing.Point(159, 19)
        Me.cmb_tipo_factura.Name = "cmb_tipo_factura"
        Me.cmb_tipo_factura.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo_factura.TabIndex = 5
        '
        'Factura_consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.cmb_tipo_factura)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.dgv_factura_consultar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_fecha_hasta)
        Me.Controls.Add(Me.txt_fecha_desde)
        Me.Controls.Add(Me.txt_numero_factura)
        Me.Name = "Factura_consultar"
        Me.Text = "Factura_consultar"
        CType(Me.dgv_factura_consultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_numero_factura As MaskedTextBox
    Friend WithEvents txt_fecha_desde As MaskedTextBox
    Friend WithEvents txt_fecha_hasta As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv_factura_consultar As DataGridView
    Friend WithEvents cmd_nuevo As Button
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_tipo_factura As ComboBox
End Class
