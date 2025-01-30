Public Class FormInicial
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnSqlite.Click
        If btnAcces.Text = "Agregar Access" Then
            ConexionesSQLite.AgregarConDataAdpater()
        ElseIf btnAcces.Text = "Eliminar Access" Then

        ElseIf btnAcces.Text = "Modificar Access" Then

        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ConexionesAccess.desconectar()
        ConexionesSQLite.DesconectarBD()
        Form1.Close()
    End Sub

    Private Sub btnAcces_Click(sender As Object, e As EventArgs) Handles btnAcces.Click
        If btnAcces.Text = "Agregar Access" Then
            ConexionesAccess.AgregarConDataAdpater()
        ElseIf btnAcces.Text = "Eliminar Access" Then

        ElseIf btnAcces.Text = "Modificar Access" Then

        End If

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub FormInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
End Class