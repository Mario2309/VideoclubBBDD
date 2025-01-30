Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Inicio"
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

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Me.Hide()
        FormInicial.Show()
        FormInicial.btnSqlite.Text = "Agregar SQLite"
        FormInicial.btnAcces.Text = "Agregar Access"
        FormInicial.Text = "Agregar"
        FormInicial.ComboBoxIdAccess.Hide()
        FormInicial.ComboBoxIdSQLite.Hide()
        FormInicial.btnBuscar.Hide()
        FormInicial.LabeliD.Hide()
    End Sub

    Private Sub SQLiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SQLiteToolStripMenuItem.Click
        Me.Hide()
        FormInicial.Show()
        FormInicial.btnSqlite.Text = "Modificar SQLite"
        FormInicial.btnSqlite.Enabled = True
        FormInicial.btnAcces.Text = "Modificar Access"
        FormInicial.btnAcces.Enabled = False
        FormInicial.Text = "Modificar SQLite"
        FormInicial.ComboBoxIdSQLite.Show()
        FormInicial.ComboBoxIdAccess.Hide()
        FormInicial.btnBuscar.Show()
        FormInicial.LabeliD.Show()
        OperacionesComunes.cargarIdsEnCombobox(ListaPeliculas, FormInicial.ComboBoxIdSQLite)

    End Sub

    Private Sub AccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccessToolStripMenuItem.Click
        Me.Hide()
        FormInicial.Show()
        FormInicial.btnSqlite.Text = "Modificar SQLite"
        FormInicial.btnSqlite.Enabled = False
        FormInicial.btnAcces.Text = "Modificar Access"
        FormInicial.btnAcces.Enabled = True
        FormInicial.Text = "Modificar Access"
        FormInicial.ComboBoxIdAccess.Show()
        FormInicial.ComboBoxIdSQLite.Hide()
        FormInicial.btnBuscar.Show()
        FormInicial.LabeliD.Show()
        OperacionesComunes.cargarIdsEnCombobox(ListaPeliculas, FormInicial.ComboBoxIdAccess)

    End Sub

    Private Sub SQLiteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SQLiteToolStripMenuItem1.Click
        Me.Hide()
        FormInicial.Show()
        FormInicial.btnSqlite.Text = "Eliminar SQLite"
        FormInicial.btnSqlite.Enabled = True
        FormInicial.btnAcces.Text = "Eliminar Access"
        FormInicial.btnAcces.Enabled = False
        FormInicial.Text = "Eliminar SQLite"
        FormInicial.ComboBoxIdSQLite.Show()
        FormInicial.ComboBoxIdAccess.Hide()
        FormInicial.btnBuscar.Show()
        FormInicial.LabeliD.Show()
        OperacionesComunes.cargarIdsEnCombobox(ListaPeliculas, FormInicial.ComboBoxIdSQLite)

    End Sub

    Private Sub AccessToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AccessToolStripMenuItem1.Click
        Me.Hide()
        FormInicial.Show()
        FormInicial.btnSqlite.Text = "Eliminar SQLite"
        FormInicial.btnSqlite.Enabled = False
        FormInicial.btnAcces.Text = "Eliminar Access"
        FormInicial.btnAcces.Enabled = True
        FormInicial.Text = "Eliminar Access"
        FormInicial.ComboBoxIdAccess.Show()
        FormInicial.ComboBoxIdSQLite.Hide()
        FormInicial.btnBuscar.Show()
        FormInicial.LabeliD.Show()
        OperacionesComunes.cargarIdsEnCombobox(ListaPeliculas, FormInicial.ComboBoxIdAccess)
    End Sub
End Class
