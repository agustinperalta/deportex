<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporte
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rv_clientes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rv_articulo = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_buscar2 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.rv_tipoFactura = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_buscar3 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.rv_marca = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmd_buscar4 = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmd_buscar5 = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.rv_factura = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmd_buscar6 = New System.Windows.Forms.Button()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New DataSet1()
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New DataSet1()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TipoArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(967, 450)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rv_clientes)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmd_buscar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(959, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clientes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rv_clientes
        '
        Me.rv_clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ClienteBindingSource
        Me.rv_clientes.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_clientes.LocalReport.ReportEmbeddedResource = "DeporTex.Reporte_cliente.rdlc"
        Me.rv_clientes.Location = New System.Drawing.Point(6, 67)
        Me.rv_clientes.Name = "rv_clientes"
        Me.rv_clientes.ServerReport.BearerToken = Nothing
        Me.rv_clientes.Size = New System.Drawing.Size(866, 357)
        Me.rv_clientes.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Generar Informe"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(101, 18)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 1
        Me.cmd_buscar.Text = "Generar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rv_articulo)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cmd_buscar2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(959, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Articulo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'rv_articulo
        '
        Me.rv_articulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.ArticuloBindingSource
        Me.rv_articulo.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rv_articulo.LocalReport.ReportEmbeddedResource = "DeporTex.Reporte_articulo.rdlc"
        Me.rv_articulo.Location = New System.Drawing.Point(6, 33)
        Me.rv_articulo.Name = "rv_articulo"
        Me.rv_articulo.ServerReport.BearerToken = Nothing
        Me.rv_articulo.Size = New System.Drawing.Size(1028, 385)
        Me.rv_articulo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Generar Informe"
        '
        'cmd_buscar2
        '
        Me.cmd_buscar2.AutoSize = True
        Me.cmd_buscar2.Location = New System.Drawing.Point(124, 3)
        Me.cmd_buscar2.Name = "cmd_buscar2"
        Me.cmd_buscar2.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar2.TabIndex = 4
        Me.cmd_buscar2.Text = "Generar"
        Me.cmd_buscar2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.rv_tipoFactura)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.cmd_buscar3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(959, 424)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tipo Facturas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'rv_tipoFactura
        '
        Me.rv_tipoFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.TipoFacturaBindingSource
        Me.rv_tipoFactura.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rv_tipoFactura.LocalReport.ReportEmbeddedResource = "DeporTex.Reporte_tipoFactura.rdlc"
        Me.rv_tipoFactura.Location = New System.Drawing.Point(6, 60)
        Me.rv_tipoFactura.Name = "rv_tipoFactura"
        Me.rv_tipoFactura.ServerReport.BearerToken = Nothing
        Me.rv_tipoFactura.Size = New System.Drawing.Size(950, 285)
        Me.rv_tipoFactura.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Generar Informe"
        '
        'cmd_buscar3
        '
        Me.cmd_buscar3.AutoSize = True
        Me.cmd_buscar3.Location = New System.Drawing.Point(102, 14)
        Me.cmd_buscar3.Name = "cmd_buscar3"
        Me.cmd_buscar3.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar3.TabIndex = 5
        Me.cmd_buscar3.Text = "Generar"
        Me.cmd_buscar3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.rv_marca)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.cmd_buscar4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(959, 424)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Marcas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'rv_marca
        '
        Me.rv_marca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.MarcasBindingSource
        Me.rv_marca.LocalReport.DataSources.Add(ReportDataSource4)
        Me.rv_marca.LocalReport.ReportEmbeddedResource = "DeporTex.Reporte_marcas.rdlc"
        Me.rv_marca.Location = New System.Drawing.Point(4, 35)
        Me.rv_marca.Name = "rv_marca"
        Me.rv_marca.ServerReport.BearerToken = Nothing
        Me.rv_marca.Size = New System.Drawing.Size(952, 377)
        Me.rv_marca.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Generar Informe"
        '
        'cmd_buscar4
        '
        Me.cmd_buscar4.Location = New System.Drawing.Point(98, 8)
        Me.cmd_buscar4.Name = "cmd_buscar4"
        Me.cmd_buscar4.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar4.TabIndex = 3
        Me.cmd_buscar4.Text = "Generar"
        Me.cmd_buscar4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.rv_factura)
        Me.TabPage5.Controls.Add(Me.txt_buscar)
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Controls.Add(Me.cmd_buscar5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(959, 424)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Facturas"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Generar Informe"
        '
        'cmd_buscar5
        '
        Me.cmd_buscar5.Location = New System.Drawing.Point(224, 14)
        Me.cmd_buscar5.Name = "cmd_buscar5"
        Me.cmd_buscar5.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar5.TabIndex = 5
        Me.cmd_buscar5.Text = "Generar"
        Me.cmd_buscar5.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(98, 17)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscar.TabIndex = 7
        '
        'rv_factura
        '
        Me.rv_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource5.Name = "DataSet1"
        ReportDataSource5.Value = Me.FacturaBindingSource
        Me.rv_factura.LocalReport.DataSources.Add(ReportDataSource5)
        Me.rv_factura.LocalReport.ReportEmbeddedResource = "DeporTex.Reporte_factura.rdlc"
        Me.rv_factura.Location = New System.Drawing.Point(23, 65)
        Me.rv_factura.Name = "rv_factura"
        Me.rv_factura.ServerReport.BearerToken = Nothing
        Me.rv_factura.Size = New System.Drawing.Size(918, 346)
        Me.rv_factura.TabIndex = 8
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ReportViewer1)
        Me.TabPage6.Controls.Add(Me.Label6)
        Me.TabPage6.Controls.Add(Me.cmd_buscar6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(959, 424)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Tipo Articulo"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Generar Informe"
        '
        'cmd_buscar6
        '
        Me.cmd_buscar6.Location = New System.Drawing.Point(103, 7)
        Me.cmd_buscar6.Name = "cmd_buscar6"
        Me.cmd_buscar6.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar6.TabIndex = 7
        Me.cmd_buscar6.Text = "Generar"
        Me.cmd_buscar6.UseVisualStyleBackColor = True
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataMember = "Articulo"
        Me.ArticuloBindingSource.DataSource = Me.DataSet1
        '
        'TipoFacturaBindingSource
        '
        Me.TipoFacturaBindingSource.DataMember = "TipoFactura"
        Me.TipoFacturaBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.DataSet11
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.DataSet1
        '
        'ReportViewer1
        '
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.TipoArticuloBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DeporTex.Reporte_tipoArticulo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 51)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(937, 358)
        Me.ReportViewer1.TabIndex = 9
        '
        'TipoArticuloBindingSource
        '
        Me.TipoArticuloBindingSource.DataMember = "TipoArticulo"
        Me.TipoArticuloBindingSource.DataSource = Me.DataSet1
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(991, 474)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Reporte"
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents rv_clientes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Label2 As Label
    Friend WithEvents cmd_buscar2 As Button
    Friend WithEvents rv_articulo As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ArticuloBindingSource As BindingSource
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents rv_tipoFactura As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label3 As Label
    Friend WithEvents cmd_buscar3 As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents rv_marca As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label4 As Label
    Friend WithEvents cmd_buscar4 As Button
    Friend WithEvents TipoFacturaBindingSource As BindingSource
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents MarcasBindingSource As BindingSource
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmd_buscar5 As Button
    Friend WithEvents rv_factura As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents cmd_buscar6 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TipoArticuloBindingSource As BindingSource
End Class
