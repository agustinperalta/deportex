﻿Public Class DeporTex
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

    Private Sub ConsultarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Cliente_Consultar_Eliminar.ShowDialog()
    End Sub

    Private Sub RegistrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem1.Click
        Cliente_Registrar_Modificar.ShowDialog()
    End Sub
End Class
