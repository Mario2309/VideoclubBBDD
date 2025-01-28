Imports System.Data.Sqlite

Module ConexionesSQLite

    Public ConexionNueva As SQLiteConnection
    Public CadenaConexion As String = "Data Source=C:\Users\Diurno\Desktop\videoclub.db; Version=3"

    Public AdaptadorDatosPelis As SQLiteDataAdapter
    Public DatosConjuntosPelis As DataSet
    Public fila As DataRow

    ' Consulta SQL para obtener los datos
    Public CadenaConsultar As String = "SELECT * FROM Peliculas"

    Public Sub ConectarBD()
        Try
            ' Crea una nueva conexión
            Using conexion As New SQLiteConnection(CadenaConexion)
                ' Abre la conexión
                conexion.Open()

                ' Inicializa el adaptador con la consulta y la conexión
                AdaptadorDatosPelis = New SQLiteDataAdapter(CadenaConsultar, conexion)

                ' Crea un nuevo DataSet y llénalo con los datos de la consulta
                DatosConjuntosPelis = New DataSet()
                AdaptadorDatosPelis.Fill(DatosConjuntosPelis)

                ' Cierra la conexión automáticamente (gracias al "Using")
            End Using

        Catch ex As Exception
            ' Muestra un mensaje si ocurre un error
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
        End Try
    End Sub

    Public Sub DesconectarBD()
        If ConexionNueva.State = ConnectionState.Open Then
            ConexionNueva.Close()
        Else
            MsgBox("No se puede cerrar")
        End If
    End Sub

    ' Método para cargar datos en el ListView
    Public Sub CargarAlListView()
        Dim ListaPeliculas As ListViewItem

        ' Asegúrate de limpiar los elementos existentes en el ListView antes de cargar nuevos datos
        Form1.ListaPeliculas.Items.Clear()

        ' Verifica si hay datos en el DataSet y en la tabla antes de intentar acceder a ellos
        If DatosConjuntosPelis IsNot Nothing AndAlso DatosConjuntosPelis.Tables.Count > 0 AndAlso DatosConjuntosPelis.Tables(0).Rows.Count > 0 Then
            ' Recorre cada fila del DataTable en el DataSet
            For pos As Integer = 0 To DatosConjuntosPelis.Tables(0).Rows.Count - 1
                ' Agrega el primer valor como el elemento principal del ListViewItem
                ListaPeliculas = Form1.ListaPeliculas.Items.Add(DatosConjuntosPelis.Tables(0).Rows(pos).Item(0).ToString())

                ' Agrega los valores restantes como subitems
                For col As Integer = 1 To DatosConjuntosPelis.Tables(0).Columns.Count - 1
                    ListaPeliculas.SubItems.Add(DatosConjuntosPelis.Tables(0).Rows(pos).Item(col).ToString())
                Next
            Next
        Else
            ' Muestra un mensaje si no hay datos disponibles
            MessageBox.Show("No hay datos disponibles para mostrar en el ListView.")
        End If
    End Sub

End Module
