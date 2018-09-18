<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor_Registrar_Modificar
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.txt_razonSocial = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cuil_proveedor = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        CType(Me.dgv_registrar_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_registrar_eliminar
        '
        Me.dgv_registrar_eliminar.AllowUserToAddRows = False
        Me.dgv_registrar_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_registrar_eliminar.Location = New System.Drawing.Point(373, 64)
        Me.dgv_registrar_eliminar.Name = "dgv_registrar_eliminar"
        Me.dgv_registrar_eliminar.Size = New System.Drawing.Size(371, 338)
        Me.dgv_registrar_eliminar.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(69, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(48, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Razon Social"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(27, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cuil de Proveedor"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(124, 157)
        Me.txt_telefono.Mask = "99999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 4
        Me.txt_telefono.ValidatingType = GetType(Integer)
        '
        'txt_razonSocial
        '
        Me.txt_razonSocial.Location = New System.Drawing.Point(124, 111)
        Me.txt_razonSocial.Name = "txt_razonSocial"
        Me.txt_razonSocial.Size = New System.Drawing.Size(183, 20)
        Me.txt_razonSocial.TabIndex = 5
        '
        'txt_cuil_proveedor
        '
        Me.txt_cuil_proveedor.Location = New System.Drawing.Point(124, 64)
        Me.txt_cuil_proveedor.Mask = "999999999"
        Me.txt_cuil_proveedor.Name = "txt_cuil_proveedor"
        Me.txt_cuil_proveedor.Size = New System.Drawing.Size(76, 20)
        Me.txt_cuil_proveedor.TabIndex = 6
        Me.txt_cuil_proveedor.ValidatingType = GetType(Integer)
        '
        'cmd_grabar
        '
        Me.cmd_grabar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_grabar.Location = New System.Drawing.Point(182, 379)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_grabar.TabIndex = 11
        Me.cmd_grabar.Text = "Grabar"
        Me.cmd_grabar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_nuevo.Location = New System.Drawing.Point(74, 379)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 12
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'Proveedor_Registrar_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.dgv_registrar_eliminar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_razonSocial)
        Me.Controls.Add(Me.txt_cuil_proveedor)
        Me.Name = "Proveedor_Registrar_Modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedor_Registrar_Modificar"
        CType(Me.dgv_registrar_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_registrar_eliminar As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_telefono As MaskedTextBox
    Friend WithEvents txt_razonSocial As MaskedTextBox
    Friend WithEvents txt_cuil_proveedor As MaskedTextBox
    Friend WithEvents cmd_grabar As Button
    Friend WithEvents cmd_nuevo As Button
End Class
