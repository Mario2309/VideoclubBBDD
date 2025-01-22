Imports Microsoft.Data.Sqlite

Module AdaptadorDatosSQLite

    Public AdaptadorDatosPelis As SqliteConnection
    Public DatosConjuntosPelis As DataSet
    Public fila As DataRow


    Public CadenaConsultar As String = "select * from peliculas"




End Module
