<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Articulo_Consultar_Eliminar
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
        Me.dgv_consultar_articulo = New System.Windows.Forms.DataGridView()
        Me.txt_busqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_refrescar = New System.Windows.Forms.Button()
        Me.chk_borrar = New System.Windows.Forms.CheckBox()
        CType(Me.dgv_consultar_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_consultar_articulo
        '
        Me.dgv_consultar_articulo.AllowUserToAddRows = False
        Me.dgv_consultar_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consultar_articulo.Location = New System.Drawing.Point(61, 116)
        Me.dgv_consultar_articulo.Name = "dgv_consultar_articulo"
        Me.dgv_consultar_articulo.Size = New System.Drawing.Size(575, 333)
        Me.dgv_consultar_articulo.TabIndex = 0
        '
        'txt_busqueda
        '
        Me.txt_busqueda.Location = New System.Drawing.Point(101, 51)
        Me.txt_busqueda.Name = "txt_busqueda"
        Me.txt_busqueda.Size = New System.Drawing.Size(162, 20)
        Me.txt_busqueda.TabIndex = 1
        Me.txt_busqueda.Text = "Ingrese codigo de articulo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar.Location = New System.Drawing.Point(285, 51)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 3
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_refrescar
        '
        Me.cmd_refrescar.Location = New System.Drawing.Point(389, 51)
        Me.cmd_refrescar.Name = "cmd_refrescar"
        Me.cmd_refrescar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_refrescar.TabIndex = 4
        Me.cmd_refrescar.Text = "Refrescar"
        Me.cmd_refrescar.UseVisualStyleBackColor = True
        '
        'chk_borrar
        '
        Me.chk_borrar.AutoSize = True
        Me.chk_borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_borrar.Location = New System.Drawing.Point(503, 51)
        Me.chk_borrar.Name = "chk_borrar"
        Me.chk_borrar.Size = New System.Drawing.Size(70, 20)
        Me.chk_borrar.TabIndex = 5
        Me.chk_borrar.Text = "Borrar"
        Me.chk_borrar.UseVisualStyleBackColor = True
        '
        'Articulo_Consultar_Eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.chk_borrar)
        Me.Controls.Add(Me.cmd_refrescar)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_busqueda)
        Me.Controls.Add(Me.dgv_consultar_articulo)
        Me.Name = "Articulo_Consultar_Eliminar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulo_Consultar_Eliminar"
        CType(Me.dgv_consultar_articulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_consultar_articulo As System.Windows.Forms.DataGridView
    Friend WithEvents txt_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents cmd_refrescar As Button
    Friend WithEvents chk_borrar As CheckBox
End Class
