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

<<<<<<< HEAD
    Private Sub ConsultarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem2.Click
        Proveedor_Consultar_eliminar.ShowDialog()
    End Sub

    Private Sub RegistrarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem2.Click
        Proveedor_Registrar_Modificar.ShowDialog()
=======
    Private Sub ConsultarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Cliente_Consultar_Eliminar.ShowDialog()
    End Sub

    Private Sub RegistrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem1.Click
        Cliente_Registrar_Modificar.ShowDialog()
>>>>>>> 47012688faff4b14ee09992e4659eb87029cf7be
    End Sub
End Class
