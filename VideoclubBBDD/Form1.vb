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

    Private Sub ListaPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPeliculas.SelectedIndexChanged

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Me.Hide()
        FormInicial.Show()
        FormInicial.btn.Text = "Agregar"
    End Sub
End Class
