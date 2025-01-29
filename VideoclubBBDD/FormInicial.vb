Public Class FormInicial
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        ConexionesSQLite.AgregarConDataAdpater()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ConexionesAccess.desconectar()
        ConexionesSQLite.DesconectarBD()
    End Sub
End Class