Imports System.Data.SQLite
Module ConexionesSQLite
    Public CadenaConexion As String = "Data Source=C:\Users\Diurno\Desktop\videoclub.db; Version=3"
    Public ConexionNueva As New SQLiteConnection(CadenaConexion)

    Public AdaptadorDatosPelis As SQLiteDataAdapter
    Public DatosConjuntosPelis As DataSet
    Public fila As DataRow

    Public CadenaConsultar As String = "SELECT * FROM Peliculas"
    Public CadenaInsertarReg As String = "insert into Peliculas values (@idP, @Tl, @Dir, @IdGen, @Anio, @Cal, @Desc)"

    Public Sub ConectarBD()
        Try
            ConexionNueva.Open()

            AdaptadorDatosPelis = New SQLiteDataAdapter(CadenaConsultar, ConexionNueva)

            DatosConjuntosPelis = New DataSet()
            AdaptadorDatosPelis.Fill(DatosConjuntosPelis)

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

    Public Sub visualizarRegistroDataAdapter(indice As Integer)
        FormInicial.LabelMostrId.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(0)
        FormInicial.txTitulo.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(1)
        FormInicial.txDirector.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(2)
        FormInicial.txGen.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(3)
        FormInicial.txAnio.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(4)
        FormInicial.txCalific.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(5)
        FormInicial.txDescp.Text = DatosConjuntosPelis.Tables(0).Rows(indice).Item(6)
    End Sub

    Public Sub AgregarConDataAdpater()
        Try
            ' Verificar conexión
            If ConexionNueva.State = ConnectionState.Closed Then
                ConexionNueva.Open()
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
            Dim comandoID As New SQLiteCommand("SELECT MAX(num_registro) FROM peliculas", ConexionNueva)
            Dim resultado As Object = comandoID.ExecuteScalar()

            If resultado IsNot DBNull.Value AndAlso resultado IsNot Nothing Then
                ultimoID = Convert.ToInt32(resultado)
            End If

            ' Nuevo ID calculado
            Dim nuevoID As Integer = ultimoID + 1

            ' Crear comando SQL
            Dim Comando As New SQLiteCommand(CadenaInsertarReg, ConexionNueva)
            AdaptadorDatosPelis.InsertCommand = Comando

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
            If ConexionNueva.State = ConnectionState.Open Then
                ConexionNueva.Close()
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

End Module
