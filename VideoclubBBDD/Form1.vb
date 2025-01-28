Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionesSQLite.ConectarBD()
        ConexionesSQLite.CargarAlListView()
    End Sub
End Class
