<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Marca_Registra_Modificar
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
        Me.txt_id_marca = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.MaskedTextBox()
        Me.dgv_registrar_modificar = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        CType(Me.dgv_registrar_modificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_id_marca
        '
        Me.txt_id_marca.Location = New System.Drawing.Point(97, 39)
        Me.txt_id_marca.Name = "txt_id_marca"
        Me.txt_id_marca.Size = New System.Drawing.Size(194, 20)
        Me.txt_id_marca.TabIndex = 0
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(97, 86)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(194, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'dgv_registrar_modificar
        '
        Me.dgv_registrar_modificar.AllowUserToAddRows = False
        Me.dgv_registrar_modificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_registrar_modificar.Location = New System.Drawing.Point(335, 39)
        Me.dgv_registrar_modificar.Name = "dgv_registrar_modificar"
        Me.dgv_registrar_modificar.Size = New System.Drawing.Size(264, 295)
        Me.dgv_registrar_modificar.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Codigo Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre"
        '
        'cmd_grabar
        '
        Me.cmd_grabar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_grabar.Location = New System.Drawing.Point(216, 311)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_grabar.TabIndex = 9
        Me.cmd_grabar.Text = "Grabar"
        Me.cmd_grabar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_nuevo.Location = New System.Drawing.Point(108, 311)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 10
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'Marca_Registra_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(637, 387)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_registrar_modificar)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id_marca)
        Me.Name = "Marca_Registra_Modificar"
        Me.Text = "Marca_Registra_Modificar"
        CType(Me.dgv_registrar_modificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_id_marca As MaskedTextBox
    Friend WithEvents txt_nombre As MaskedTextBox
    Friend WithEvents dgv_registrar_modificar As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmd_grabar As Button
    Friend WithEvents cmd_nuevo As Button
End Class
