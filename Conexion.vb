Imports MySql.Data.MySqlClient

Public Class Conexion

    Dim connString As String

    Dim conexion As MySqlConnection

    'RECIBIMOS LOS PARAMETROS POR CONSTRUCTOR Y CREAMOS LA CONEXION
    Public Sub New(servidor As String, usuario As String, password As String, database As String)

        Try
            connString = String.Format("server={0}; user id={1}; password={2}; database={3};", servidor, usuario, password, database)

            conexion = New MySqlConnection(connString)

            conexion.ConnectionString = connString

            conexion.Open()
        Catch ex As MySqlException

            MsgBox("Error al conectar a la base de datos")

        End Try

    End Sub

    'SE ENVIA UN COMANDO A LA BASE DE DATOS
    Public Sub enviarComando(comandoString As String)

        Try

            Using conexion

                If conexion.State.Equals(ConnectionState.Closed) Then

                    conexion.Open()

                End If

                Dim comando = New MySqlCommand(comandoString, conexion)

                comando.ExecuteNonQuery()

                MsgBox("Se ha ingresado los datos correctamente")

            End Using



        Catch ex As Exception

            MsgBox("Error al enviar el comando " & ex.ToString())

        End Try

    End Sub

    'HACE UNA CONSULTA A LA BASE DE DATOS DEVOLVIENDO EL RESULTADO EN UN DATASET
    Public Function enviarConsultaDataSet(consulta As String, tabla As String) As DataSet

        Try

            Using conexion
                If conexion.State.Equals(ConnectionState.Closed) Then

                    conexion.Open()

                End If
                Dim adaptador = New MySqlDataAdapter(consulta, conexion)

                Dim datos = New DataSet

                adaptador.Fill(datos, tabla)

                Return datos

            End Using
        Catch ex As MySqlException

            MsgBox("Hubo un error al hacer la consulta")

        End Try

        Return New DataSet()

    End Function

    'ENVIA UNA CONSULTA A LA BASE DE DATOS DEVOLVIENDO MYSQLCOMMAND
    Public Function enviarConsulta(sql As String) As MySqlCommand

        Dim comando As MySqlCommand = New MySqlCommand(sql, conexion)

        Return comando

    End Function

    'SIRVE PARA CERRAR LA CONEXION CREADA
    Public Sub cerrarConexion()

        Try

            If conexion.State.Equals(ConnectionState.Open) Then

                conexion.Close()

            End If



        Catch ex As MySqlException

            MsgBox("Error al cerrar la conexion")

        End Try

    End Sub

    'OBTIENE LA CONEXION DE LA INSTANCIA ACTUAL DEL OBJETO
    Public Function getConexion() As MySqlConnection

        Return conexion

    End Function



End Class
