﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente_Consultar_Eliminar
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
        Me.chk_borrar = New System.Windows.Forms.CheckBox()
        Me.cmd_refrescar = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_busqueda = New System.Windows.Forms.TextBox()
        Me.dgv_consultar_eliminar_cliente = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_consultar_eliminar_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_borrar
        '
        Me.chk_borrar.AutoSize = True
        Me.chk_borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_borrar.Location = New System.Drawing.Point(535, 58)
        Me.chk_borrar.Name = "chk_borrar"
        Me.chk_borrar.Size = New System.Drawing.Size(70, 20)
        Me.chk_borrar.TabIndex = 11
        Me.chk_borrar.Text = "Borrar"
        Me.chk_borrar.UseVisualStyleBackColor = True
        '
        'cmd_refrescar
        '
        Me.cmd_refrescar.Location = New System.Drawing.Point(421, 58)
        Me.cmd_refrescar.Name = "cmd_refrescar"
        Me.cmd_refrescar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_refrescar.TabIndex = 10
        Me.cmd_refrescar.Text = "Refrescar"
        Me.cmd_refrescar.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar.Location = New System.Drawing.Point(317, 58)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 9
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'txt_busqueda
        '
        Me.txt_busqueda.Location = New System.Drawing.Point(133, 58)
        Me.txt_busqueda.Name = "txt_busqueda"
        Me.txt_busqueda.Size = New System.Drawing.Size(162, 20)
        Me.txt_busqueda.TabIndex = 7
        Me.txt_busqueda.Text = "Ingrese cuil de cliente"
        '
        'dgv_consultar_eliminar_cliente
        '
        Me.dgv_consultar_eliminar_cliente.AllowUserToAddRows = False
        Me.dgv_consultar_eliminar_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consultar_eliminar_cliente.Location = New System.Drawing.Point(93, 123)
        Me.dgv_consultar_eliminar_cliente.Name = "dgv_consultar_eliminar_cliente"
        Me.dgv_consultar_eliminar_cliente.Size = New System.Drawing.Size(575, 333)
        Me.dgv_consultar_eliminar_cliente.TabIndex = 6
        '
        'Cliente_Consultar_Eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chk_borrar)
        Me.Controls.Add(Me.cmd_refrescar)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_busqueda)
        Me.Controls.Add(Me.dgv_consultar_eliminar_cliente)
        Me.Name = "Cliente_Consultar_Eliminar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente_Consultar_Eliminar"
        CType(Me.dgv_consultar_eliminar_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk_borrar As CheckBox
    Friend WithEvents cmd_refrescar As Button
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_busqueda As TextBox
    Friend WithEvents dgv_consultar_eliminar_cliente As DataGridView
End Class
