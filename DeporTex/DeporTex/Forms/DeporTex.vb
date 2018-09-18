Public Class DeporTex
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Articulo_Consultar_Eliminar.ShowDialog()
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Articulo_Registrar_Modificar.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem3.Click
        Marca_Consultar_Eliminar.ShowDialog()
    End Sub

    Private Sub RegistrarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem3.Click
        Marca_Registra_Modificar.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem2.Click
        Proveedor_Consultar_eliminar.ShowDialog()
    End Sub

    Private Sub RegistrarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem2.Click
        Proveedor_Registrar_Modificar.ShowDialog()
    End Sub
End Class
