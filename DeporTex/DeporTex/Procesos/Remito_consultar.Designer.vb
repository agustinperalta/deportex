<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remito_consultar
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
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.dgv_remito_consultar = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.txt_numero_remito = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgv_remito_consultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(431, 47)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 14
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(528, 47)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 15
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'dgv_remito_consultar
        '
        Me.dgv_remito_consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_remito_consultar.Location = New System.Drawing.Point(45, 89)
        Me.dgv_remito_consultar.Name = "dgv_remito_consultar"
        Me.dgv_remito_consultar.Size = New System.Drawing.Size(693, 318)
        Me.dgv_remito_consultar.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha desde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Numero de remito"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(316, 49)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(72, 20)
        Me.txt_fecha_hasta.TabIndex = 7
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(156, 49)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(72, 20)
        Me.txt_fecha_desde.TabIndex = 8
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'txt_numero_remito
        '
        Me.txt_numero_remito.Location = New System.Drawing.Point(156, 12)
        Me.txt_numero_remito.Name = "txt_numero_remito"
        Me.txt_numero_remito.Size = New System.Drawing.Size(121, 20)
        Me.txt_numero_remito.TabIndex = 6
        '
        'Remito_consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 426)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.dgv_remito_consultar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_fecha_hasta)
        Me.Controls.Add(Me.txt_fecha_desde)
        Me.Controls.Add(Me.txt_numero_remito)
        Me.Name = "Remito_consultar"
        Me.Text = "Remito_consultar"
        CType(Me.dgv_remito_consultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents cmd_nuevo As Button
    Friend WithEvents dgv_remito_consultar As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_fecha_hasta As MaskedTextBox
    Friend WithEvents txt_fecha_desde As MaskedTextBox
    Friend WithEvents txt_numero_remito As MaskedTextBox
End Class
