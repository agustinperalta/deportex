Imports System.Data
Imports System.Data.SqlClient

Public Class Tratamientos_Especiales
    Dim _cadena_conexion As String = "Provider=SQLNCLI11;Data Source=LAPTOP-VLNG4BCV\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=_DB_DEPORTEX"
    Public Sub blanquear_objetos(controles As Object)
        For Each obj In controles.controls
            Dim tipoObjeto As String = obj.GetType().Name
            Select Case tipoObjeto
                Case "MaskedTextBox"
                    obj.Text = ""
                Case "ComboBox"
                    Dim local As ComboBox = obj
                    local.SelectedIndex = -1
            End Select
        Next
    End Sub

    Public Sub cargar_combo(ByRef _combo As ComboBox, ByVal consulta As String)
        Dim _BD As New Conexion
        Dim datatable As New DataTable
        Dim sqlstring As String = consulta
        datatable = _BD.leo_tabla(sqlstring)
        _combo.DataSource = datatable
        _combo.DisplayMember = datatable.Columns(1).ColumnName
        _combo.ValueMember = datatable.Columns(0).ColumnName
    End Sub
End Class
