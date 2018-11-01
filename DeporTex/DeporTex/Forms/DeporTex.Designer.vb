<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeporTex
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
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TipoDeArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarOEliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarOModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_consultar_remito = New System.Windows.Forms.Button()
        Me.cmd_registrar_remito = New System.Windows.Forms.Button()
        Me.cmd_consultar_factura = New System.Windows.Forms.Button()
        Me.cmd_registrar_nueva_factura = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_reportes = New System.Windows.Forms.Button()
        Me.cmd_estadisticas = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_titulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_titulo.Location = New System.Drawing.Point(515, 100)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(322, 73)
        Me.lbl_titulo.TabIndex = 1
        Me.lbl_titulo.Text = "DeporTex"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.RegistrarToolStripMenuItem})
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar o Eliminar"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RegistrarToolStripMenuItem.Text = "Registrar o Modificar"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem1, Me.RegistrarToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ConsultarToolStripMenuItem1
        '
        Me.ConsultarToolStripMenuItem1.Name = "ConsultarToolStripMenuItem1"
        Me.ConsultarToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.ConsultarToolStripMenuItem1.Text = "Consultar o Eliminar"
        '
        'RegistrarToolStripMenuItem1
        '
        Me.RegistrarToolStripMenuItem1.Name = "RegistrarToolStripMenuItem1"
        Me.RegistrarToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.RegistrarToolStripMenuItem1.Text = "Registrar o Modificar"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem2, Me.RegistrarToolStripMenuItem2})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ConsultarToolStripMenuItem2
        '
        Me.ConsultarToolStripMenuItem2.Name = "ConsultarToolStripMenuItem2"
        Me.ConsultarToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.ConsultarToolStripMenuItem2.Text = "Consultar o Eliminar"
        '
        'RegistrarToolStripMenuItem2
        '
        Me.RegistrarToolStripMenuItem2.Name = "RegistrarToolStripMenuItem2"
        Me.RegistrarToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.RegistrarToolStripMenuItem2.Text = "Registrar o Modificar"
        '
        'MarcaToolStripMenuItem
        '
        Me.MarcaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem3, Me.RegistrarToolStripMenuItem3})
        Me.MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem"
        Me.MarcaToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MarcaToolStripMenuItem.Text = "Marca"
        '
        'ConsultarToolStripMenuItem3
        '
        Me.ConsultarToolStripMenuItem3.Name = "ConsultarToolStripMenuItem3"
        Me.ConsultarToolStripMenuItem3.Size = New System.Drawing.Size(184, 22)
        Me.ConsultarToolStripMenuItem3.Text = "Consultar o Eliminar"
        '
        'RegistrarToolStripMenuItem3
        '
        Me.RegistrarToolStripMenuItem3.Name = "RegistrarToolStripMenuItem3"
        Me.RegistrarToolStripMenuItem3.Size = New System.Drawing.Size(184, 22)
        Me.RegistrarToolStripMenuItem3.Text = "Registrar o Modificar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.MarcaToolStripMenuItem, Me.TipoDeArticuloToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1287, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TipoDeArticuloToolStripMenuItem
        '
        Me.TipoDeArticuloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarOEliminarToolStripMenuItem, Me.RegistrarOModificarToolStripMenuItem})
        Me.TipoDeArticuloToolStripMenuItem.Name = "TipoDeArticuloToolStripMenuItem"
        Me.TipoDeArticuloToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.TipoDeArticuloToolStripMenuItem.Text = "Tipo de Articulo"
        '
        'ConsultarOEliminarToolStripMenuItem
        '
        Me.ConsultarOEliminarToolStripMenuItem.Name = "ConsultarOEliminarToolStripMenuItem"
        Me.ConsultarOEliminarToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ConsultarOEliminarToolStripMenuItem.Text = "Consultar o Eliminar"
        '
        'RegistrarOModificarToolStripMenuItem
        '
        Me.RegistrarOModificarToolStripMenuItem.Name = "RegistrarOModificarToolStripMenuItem"
        Me.RegistrarOModificarToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RegistrarOModificarToolStripMenuItem.Text = "Registrar o Modificar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_consultar_remito)
        Me.GroupBox1.Controls.Add(Me.cmd_registrar_remito)
        Me.GroupBox1.Controls.Add(Me.cmd_consultar_factura)
        Me.GroupBox1.Controls.Add(Me.cmd_registrar_nueva_factura)
        Me.GroupBox1.Location = New System.Drawing.Point(113, 209)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 143)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Procesos"
        '
        'cmd_consultar_remito
        '
        Me.cmd_consultar_remito.Location = New System.Drawing.Point(6, 106)
        Me.cmd_consultar_remito.Name = "cmd_consultar_remito"
        Me.cmd_consultar_remito.Size = New System.Drawing.Size(325, 23)
        Me.cmd_consultar_remito.TabIndex = 0
        Me.cmd_consultar_remito.Text = "Consultar remito"
        Me.cmd_consultar_remito.UseVisualStyleBackColor = True
        '
        'cmd_registrar_remito
        '
        Me.cmd_registrar_remito.Location = New System.Drawing.Point(6, 77)
        Me.cmd_registrar_remito.Name = "cmd_registrar_remito"
        Me.cmd_registrar_remito.Size = New System.Drawing.Size(325, 23)
        Me.cmd_registrar_remito.TabIndex = 0
        Me.cmd_registrar_remito.Text = "Registrar nuevo remito"
        Me.cmd_registrar_remito.UseVisualStyleBackColor = True
        '
        'cmd_consultar_factura
        '
        Me.cmd_consultar_factura.Location = New System.Drawing.Point(6, 48)
        Me.cmd_consultar_factura.Name = "cmd_consultar_factura"
        Me.cmd_consultar_factura.Size = New System.Drawing.Size(325, 23)
        Me.cmd_consultar_factura.TabIndex = 0
        Me.cmd_consultar_factura.Text = "Consultar factura"
        Me.cmd_consultar_factura.UseVisualStyleBackColor = True
        '
        'cmd_registrar_nueva_factura
        '
        Me.cmd_registrar_nueva_factura.Location = New System.Drawing.Point(6, 19)
        Me.cmd_registrar_nueva_factura.Name = "cmd_registrar_nueva_factura"
        Me.cmd_registrar_nueva_factura.Size = New System.Drawing.Size(325, 23)
        Me.cmd_registrar_nueva_factura.TabIndex = 0
        Me.cmd_registrar_nueva_factura.Text = "Registrar nueva factura"
        Me.cmd_registrar_nueva_factura.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_estadisticas)
        Me.GroupBox2.Controls.Add(Me.cmd_reportes)
        Me.GroupBox2.Location = New System.Drawing.Point(883, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 143)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reportes y Estadisticas"
        '
        'cmd_reportes
        '
        Me.cmd_reportes.Location = New System.Drawing.Point(6, 19)
        Me.cmd_reportes.Name = "cmd_reportes"
        Me.cmd_reportes.Size = New System.Drawing.Size(325, 23)
        Me.cmd_reportes.TabIndex = 1
        Me.cmd_reportes.Text = "Reportes"
        Me.cmd_reportes.UseVisualStyleBackColor = True
        '
        'cmd_estadisticas
        '
        Me.cmd_estadisticas.Location = New System.Drawing.Point(6, 77)
        Me.cmd_estadisticas.Name = "cmd_estadisticas"
        Me.cmd_estadisticas.Size = New System.Drawing.Size(325, 23)
        Me.cmd_estadisticas.TabIndex = 1
        Me.cmd_estadisticas.Text = "Estadisticas"
        Me.cmd_estadisticas.UseVisualStyleBackColor = True
        '
        'DeporTex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1287, 449)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DeporTex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeporTex"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents ArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MarcaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TipoDeArticuloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarOEliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarOModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmd_consultar_remito As Button
    Friend WithEvents cmd_registrar_remito As Button
    Friend WithEvents cmd_consultar_factura As Button
    Friend WithEvents cmd_registrar_nueva_factura As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmd_estadisticas As Button
    Friend WithEvents cmd_reportes As Button
End Class
