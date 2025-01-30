Imports System.Data.OleDb

Module ConexionesAccess

    Public conexionNueva As OleDbConnection
    Public cadenaConexion As String = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=C:\Users\alvar\Source\Repos\Mario2309\VideoclubBBDD\VideoclubBBDD\VideoClubBBDD.mdb"
    'Public cadenaConexion As String = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & IO.Path.Combine(Application.StartupPath, "VideoClubBBDD.mdb")

    Public AdaptadorDatosPeliculas As OleDbDataAdapter
    Public DatosConjuntosPeliculas As New DataSet()

    Public CadenaConsultar As String = "select * from Peliculas"
    Public CadenaInsertarReg As String = "insert into Peliculas values (@idP, @Tl, @Dir, @IdGen, @Anio, @Cal, @Desc)"


    Public Sub conectar()

        Try
            If conexionNueva Is Nothing Then
                conexionNueva = New OleDbConnection(cadenaConexion)
            End If

            If conexionNueva.State <> ConnectionState.Open Then

                conexionNueva.Open()
                MsgBox("Conectado correctamente.", vbInformation, "Conexión Exitosa")

                AdaptadorDatosPeliculas = New OleDbDataAdapter(CadenaConsultar, conexionNueva)
                DatosConjuntosPeliculas = New DataSet
                AdaptadorDatosPeliculas.Fill(DatosConjuntosPeliculas, "Peliculas")
            End If

        Catch ex As Exception
            MsgBox("No se pudo conectar: " & ex.Message, vbCritical, "Error de Conexión")
        Finally
            If conexionNueva.State = ConnectionState.Open Then
                conexionNueva.Close()
            End If
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

    Public Sub AgregarConDataAdpater()
        Try
            ' Verificar conexión
            If conexionNueva.State = ConnectionState.Closed Then
                conexionNueva.Open()
            End If

            ' Validar campos
            validarCampos()

            ' Convertir valores numéricos con seguridad
            Dim anio As Integer
            Dim calificacion As Decimal

            If Not Integer.TryParse(FormInicial.txAnio.Text, anio) Then
                MessageBox.Show("Año debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Not Decimal.TryParse(FormInicial.txCalific.Text, calificacion) Then
                MessageBox.Show("Calificación debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Obtener el último ID registrado
            Dim ultimoID As Integer = 0
            Dim comandoID As New OleDbCommand("SELECT MAX(num_registro) FROM peliculas", conexionNueva)
            Dim resultado As Object = comandoID.ExecuteScalar()

            If resultado IsNot DBNull.Value AndAlso resultado IsNot Nothing Then
                ultimoID = Convert.ToInt32(resultado)
            End If

            ' Nuevo ID calculado
            Dim nuevoID As Integer = ultimoID + 1

            ' Crear comando SQL
            Dim Comando As New OleDbCommand(CadenaInsertarReg, conexionNueva)
            AdaptadorDatosPeliculas.InsertCommand = Comando

            ' Asignar parámetros
            Comando.Parameters.AddWithValue("@idP", nuevoID)
            Comando.Parameters.AddWithValue("@Tl", FormInicial.txTitulo.Text.Trim())
            Comando.Parameters.AddWithValue("@Dir", FormInicial.txDirector.Text.Trim())
            Comando.Parameters.AddWithValue("@IdGen", FormInicial.txGen.Text.Trim())
            Comando.Parameters.AddWithValue("@Anio", anio)
            Comando.Parameters.AddWithValue("@Cal", calificacion)
            Comando.Parameters.AddWithValue("@Desc", FormInicial.txDescp.Text.Trim())

            ' Ejecutar la consulta
            Dim filasAfectadas As Integer = Comando.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MessageBox.Show("Película agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarCampos()
            Else
                MessageBox.Show("No se pudo agregar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al agregar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar conexión
            If conexionNueva.State = ConnectionState.Open Then
                conexionNueva.Close()
            End If
        End Try
    End Sub

    Private Sub validarCampos()
        If String.IsNullOrWhiteSpace(FormInicial.txTitulo.Text) OrElse
                   String.IsNullOrWhiteSpace(FormInicial.txDirector.Text) OrElse
                   String.IsNullOrWhiteSpace(FormInicial.txGen.Text) OrElse
                   String.IsNullOrWhiteSpace(FormInicial.txAnio.Text) OrElse
                   String.IsNullOrWhiteSpace(FormInicial.txCalific.Text) OrElse
                   String.IsNullOrWhiteSpace(FormInicial.txDescp.Text) Then

            MessageBox.Show("Todos los campos deben estar completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub limpiarCampos()
        FormInicial.txTitulo.Clear()
        FormInicial.txDirector.Clear()
        FormInicial.txGen.Clear()
        FormInicial.txAnio.Clear()
        FormInicial.txCalific.Clear()
        FormInicial.txDescp.Clear()
    End Sub

    Public Sub visualizarRegistroDataAdapter(indice As Integer)
        FormInicial.LabelMostrId.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(0)
        FormInicial.txTitulo.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(1)
        FormInicial.txDirector.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(2)
        FormInicial.txGen.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(3)
        FormInicial.txAnio.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(4)
        FormInicial.txCalific.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(5)
        FormInicial.txDescp.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(6)
    End Sub


End Module
