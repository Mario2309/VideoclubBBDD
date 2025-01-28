Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConSQLite_Click(sender As Object, e As EventArgs) Handles btnConSQLite.Click
        ConexionesSQLite.ConectarBD()
        ConexionesSQLite.CargarAlListView()
    End Sub

    Private Sub btnConAccess_Click(sender As Object, e As EventArgs) Handles btnConAccess.Click
        ConexionesAccess.conectar()
        ConexionesAccess.cargarListView()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ConexionesAccess.desconectar()
        ConexionesSQLite.DesconectarBD()
        Close()
    End Sub
End Class
