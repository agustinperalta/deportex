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

    Public Sub cargar_combobox(ByVal combo As ComboBox, ByVal displaymember As String, ByVal valuemember As String)
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        Try
            DA = New SqlDataAdapter("SELECT nombre FROM Marcas", _cadena_conexion)
            DA.Fill(DT)
            combo.DataSource = DT
            combo.DisplayMember = displaymember
            combo.ValueMember = valuemember
        Catch ex As Exception

        End Try
    End Sub
End Class
