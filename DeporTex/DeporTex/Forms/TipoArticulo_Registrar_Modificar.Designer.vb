<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoArticulo_Registrar_Modificar
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id_tipo_articulo = New System.Windows.Forms.MaskedTextBox()
        Me.dgv_registrar_eliminar = New System.Windows.Forms.DataGridView()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgv_registrar_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(25, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Id Tipo de Articulo"
        '
        'txt_id_tipo_articulo
        '
        Me.txt_id_tipo_articulo.Location = New System.Drawing.Point(134, 76)
        Me.txt_id_tipo_articulo.Name = "txt_id_tipo_articulo"
        Me.txt_id_tipo_articulo.Size = New System.Drawing.Size(160, 20)
        Me.txt_id_tipo_articulo.TabIndex = 30
        '
        'dgv_registrar_eliminar
        '
        Me.dgv_registrar_eliminar.AllowUserToAddRows = False
        Me.dgv_registrar_eliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_registrar_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_registrar_eliminar.Location = New System.Drawing.Point(323, 23)
        Me.dgv_registrar_eliminar.Name = "dgv_registrar_eliminar"
        Me.dgv_registrar_eliminar.Size = New System.Drawing.Size(1040, 350)
        Me.dgv_registrar_eliminar.TabIndex = 44
        '
        'cmd_grabar
        '
        Me.cmd_grabar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_grabar.Location = New System.Drawing.Point(215, 210)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_grabar.TabIndex = 41
        Me.cmd_grabar.Text = "Grabar"
        Me.cmd_grabar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_nuevo.Location = New System.Drawing.Point(111, 210)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 39
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(73, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(134, 126)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(158, 20)
        Me.txt_nombre.TabIndex = 33
        '
        'TipoArticulo_Registrar_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_id_tipo_articulo)
        Me.Controls.Add(Me.dgv_registrar_eliminar)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nombre)
        Me.Name = "TipoArticulo_Registrar_Modificar"
        Me.Text = "TipoArticulo_Registrar_Modificar"
        CType(Me.dgv_registrar_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txt_id_tipo_articulo As MaskedTextBox
    Friend WithEvents dgv_registrar_eliminar As DataGridView
    Friend WithEvents cmd_grabar As Button
    Friend WithEvents cmd_nuevo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nombre As MaskedTextBox
End Class
