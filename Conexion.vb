﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Conexion

    Dim connString As String

    Dim conexion As MySqlConnection

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

    Public Function enviarConsultaDataSet(consulta As String) As DataSet

        Try

            Using conexion
                If conexion.State.Equals(ConnectionState.Closed) Then

                    conexion.Open()

                End If
                Dim adaptador = New MySqlDataAdapter(consulta, conexion)

                Dim datos = New DataSet

                adaptador.Fill(datos, "datos")

                Return datos

            End Using
        Catch ex As MySqlException

            MsgBox("Hubo un error al hacer la consulta")

        End Try

        Return New DataSet()

    End Function

    Public Function getProveedores() As Dictionary(Of Integer, String)

        Try

            Using conexion

                If conexion.State.Equals(ConnectionState.Closed) Then

                    conexion.Open()

                End If

                Dim proveedores As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)

                Dim comando As MySqlCommand = New MySqlCommand("SELECT * FROM proveedor", conexion)

                Dim reader As MySqlDataReader = comando.ExecuteReader()

                If reader.HasRows Then

                    Do While reader.Read()

                        proveedores.Add(reader.GetInt32(0), reader.GetString(1))

                    Loop

                End If

                reader.Close()

                Return proveedores

            End Using

        Catch ex As MySqlException

            MsgBox("Error de lectura " & ex.ToString())

        End Try

        Return New Dictionary(Of Integer, String)

    End Function

    Public Sub cerrarConexion()

        Try

            If conexion.State.Equals(ConnectionState.Open) Then

                conexion.Close()

            End If



        Catch ex As MySqlException

            MsgBox("Error al cerrar la conexion")

        End Try

    End Sub


End Class
