Public Class Remito_consultar
    Dim BD As New Conexion_Transacciones
    Private Sub Remito_consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_numero_remito.Focus()
        blanquear()
    End Sub

    Public Sub blanquear()
        txt_numero_remito.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        If txt_numero_remito.Text = "" Then
            MsgBox("Falta numero de remito")
            Exit Sub
        End If
        If txt_fecha_desde.Text = "" Then
            MsgBox("Falta fecha desde")
            Exit Sub
        End If
        If txt_fecha_hasta.Text = "" Then
            MsgBox("Falta fecha hasta")
            Exit Sub
        End If
        Dim sql As String = ""
        sql &= "SELECT * FROM Remitos WHERE nro_remito = '" & txt_numero_remito.Text.Trim() & "' AND fecha_remito BETWEEN '" & txt_fecha_desde.Text & "' AND '" & txt_fecha_hasta.Text & "'"
        dgv_remito_consultar.DataSource = BD.leo_tabla(sql)
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        blanquear()
        txt_numero_remito.Focus()
        dgv_remito_consultar.DataSource = Nothing
    End Sub
End Class