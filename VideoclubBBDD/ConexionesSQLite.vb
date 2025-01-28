Imports System.Data.Sqlite

Module ConexionesSQLite

    Public ConexionNueva As SQLiteConnection
    Public CadenaConexion As String = "Data Source=C:\Users\Diurno\Desktop\videoclub.db; Version=3"

    Public AdaptadorDatosPelis As SQLiteDataAdapter
    Public DatosConjuntosPelis As DataSet
    Public fila As DataRow

    Public CadenaConsultar As String = "SELECT * FROM Peliculas"

    Public Sub ConectarBD()
        Try
            Using ConexionNueva As New SQLiteConnection(CadenaConexion)
                ConexionNueva.Open()

                AdaptadorDatosPelis = New SQLiteDataAdapter(CadenaConsultar, ConexionNueva)

                DatosConjuntosPelis = New DataSet()
                AdaptadorDatosPelis.Fill(DatosConjuntosPelis)

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
        End Try
    End Sub

    Public Sub DesconectarBD()
        Try
            If ConexionNueva IsNot Nothing AndAlso ConexionNueva.State = ConnectionState.Open Then
                ConexionNueva.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub

    Public Sub CargarAlListView()
        Dim ListaPeliculas As ListViewItem

        Form1.ListaPeliculas.Items.Clear()

        If DatosConjuntosPelis IsNot Nothing AndAlso DatosConjuntosPelis.Tables.Count > 0 AndAlso DatosConjuntosPelis.Tables(0).Rows.Count > 0 Then
            For pos As Integer = 0 To DatosConjuntosPelis.Tables(0).Rows.Count - 1
                ListaPeliculas = Form1.ListaPeliculas.Items.Add(DatosConjuntosPelis.Tables(0).Rows(pos).Item(0).ToString())

                For col As Integer = 1 To DatosConjuntosPelis.Tables(0).Columns.Count - 1
                    ListaPeliculas.SubItems.Add(DatosConjuntosPelis.Tables(0).Rows(pos).Item(col).ToString())
                Next
            Next
        Else
            MessageBox.Show("No hay datos disponibles para mostrar en el ListView.")
        End If
    End Sub

End Module
