Imports Microsoft.Data.Sqlite

Module ConexionesSQLite

    Public ConexionNueva As SqliteConnection
    Public CadenaConexion As String = "Data Source=C:\Users\Diurno\Desktop\videoclub.db; Version=3"

    Public Sub ConectarBD()
        ConexionNueva = New SqliteConnection(CadenaConexion)
        Try
            ConexionNueva.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub DesconectarBD()
        If ConexionNueva.State = ConnectionState.Open Then
            ConexionNueva.Close()
        Else
            MsgBox("No se puede cerrar")
        End If
    End Sub

End Module
