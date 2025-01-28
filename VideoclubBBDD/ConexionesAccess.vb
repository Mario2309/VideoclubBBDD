Imports System.Data.OleDb

Module ConexionesAccess

    Public conexionNueva As OleDbConnection
    Public cadenaConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alvar\OneDrive\Escritorio\DBVideoClub.accdb"

    Public AdaptadorDatosPeliculas As OleDbDataAdapter
    Public DatosConjuntosPeliculas As New DataSet()

    Public Sub conectar()
        Try
            If conexionNueva Is Nothing Then
                conexionNueva = New OleDbConnection(cadenaConexion)
            End If

            If conexionNueva.State <> ConnectionState.Open Then
                conexionNueva.Open()
                MsgBox("Conexión establecida correctamente.")
            Else
                MsgBox("La conexión ya está abierta.")
            End If
        Catch ex As Exception
            MsgBox("No se pudo establecer conexión. Error: " & ex.Message)
        End Try
    End Sub


    Public Sub desconectar()
        Try
            If conexionNueva IsNot Nothing AndAlso conexionNueva.State = ConnectionState.Open Then
                conexionNueva.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub


    Public Sub cargarListView()
        If Form1.ListaPeliculas Is Nothing Then
            MsgBox("No se puede cargar la lista porque el control ListView no está inicializado.")
            Return
        End If

        If DatosConjuntosPeliculas.Tables.Count = 0 OrElse DatosConjuntosPeliculas.Tables(0).Rows.Count = 0 Then
            MsgBox("No hay datos para mostrar.")
            Return
        End If

        Form1.ListaPeliculas.Items.Clear()

        For Each fila As DataRow In DatosConjuntosPeliculas.Tables(0).Rows
            Dim listaPelis As New ListViewItem(fila(0).ToString())
            For i As Integer = 1 To fila.ItemArray.Length - 1
                listaPelis.SubItems.Add(fila(i).ToString())
            Next
            Form1.ListaPeliculas.Items.Add(listaPelis)
        Next
    End Sub


    Public Sub cargarDatosPeliculas()
        Try
            If conexionNueva Is Nothing OrElse conexionNueva.State <> ConnectionState.Open Then
                conectar() ' Asegurar que la conexión esté abierta
            End If

            AdaptadorDatosPeliculas = New OleDbDataAdapter("SELECT * FROM Peliculas", conexionNueva)
            If DatosConjuntosPeliculas IsNot Nothing Then DatosConjuntosPeliculas.Clear()
            AdaptadorDatosPeliculas.Fill(DatosConjuntosPeliculas)

            MsgBox("Datos cargados correctamente.")
        Catch ex As Exception
            MsgBox("Error al cargar datos: " & ex.Message)
        Finally
            desconectar() ' Cerrar conexión al finalizar
        End Try
    End Sub


End Module
