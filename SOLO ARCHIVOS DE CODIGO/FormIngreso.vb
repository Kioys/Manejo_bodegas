Imports MySql.Data.MySqlClient

Public Class FormIngreso

    'DECLARACION DE OBJETOS
    Dim frmMenuPrincipal As FormMenuPrincipal
    Dim proveedores As New Dictionary(Of Integer, String)
    Dim reader As MySqlDataReader
    Dim conexion As Conexion

    Public Sub New(menuForm As FormMenuPrincipal)
        'INICIALIZAR LOS COMPONENTES CUANDO EL CONSTRUCTOR ES LLAMADO
        InitializeComponent()
        'obtener el form del menu principal por parametro
        Me.frmMenuPrincipal = menuForm
        'instanciar una conexion con parametros correctos
        conexion = New Conexion("127.0.0.1", "root", "", "dbbodega")
        'si la conexion está cerrada que la abra, al hacer la consulta guarde los resultados en un diccionario
        'luego que lea el diccionario añadiendo cada proveedor al ComboBox
        If conexion.getConexion().State.Equals(ConnectionState.Closed) Then

            conexion.getConexion().Open()

        End If

        reader = conexion.enviarConsulta("SELECT * FROM proveedor").ExecuteReader()

        If reader.HasRows Then

            Do While reader.Read()

                proveedores.Add(reader.GetInt32(0), reader.GetString(1))

            Loop

        End If

        reader.Close()

        For Each kvp As KeyValuePair(Of Integer, String) In proveedores

            comboProveedor.Items.Add(kvp.Value)

        Next

        comboProveedor.SelectedIndex = 0

    End Sub

    'al presionar el boton se leeran los campo de textos verificando que no estén vacios
    'si no están vacios los leera y comprobará si no hay letras donde deberian haber numeros
    'si cumple con todos estos requisitos se ejecuta el comando insert con los datos correctos
    Private Sub btnIngresarProducto_Click(sender As Object, e As EventArgs) Handles btnIngresarProducto.Click

        Try

            Dim idProducto, stock, precio, idProveedor As Integer
            Dim nombreProducto As String

            If txtCodigo.Text.Equals("") Or txtNombre.Text.Equals("") Or txtStock.Text.Equals("") Or txtPrecio.Text.Equals("") Then

                MsgBox("Debes rellenar todos los campos correctamente")

            Else

                Try

                    idProducto = Convert.ToInt32(txtCodigo.Text)
                    stock = Convert.ToInt32(txtStock.Text)
                    precio = Convert.ToInt32(txtPrecio.Text)
                    nombreProducto = txtNombre.Text

                    For Each kvp As KeyValuePair(Of Integer, String) In proveedores

                        If kvp.Value.Equals(comboProveedor.SelectedIndex) Then

                            idProveedor = kvp.Key

                        End If

                    Next

                    Dim comando = String.Format("INSERT INTO productos(idProductos, nombreProducto, Stock, Precio, Proveedor_idProveedor) VALUES({0}, '{1}', {2}, {3}, {4})", idProducto, nombreProducto, stock, precio, idProveedor)

                    conexion.enviarComando(comando)

                    txtCodigo.Clear()
                    txtNombre.Clear()
                    txtPrecio.Clear()
                    txtStock.Clear()

                Catch ex As Exception

                    MsgBox("No puede haber texto en los campos numericos (Codigo Producto, stock, precio unidad)")

                End Try

            End If


        Catch ex As Exception

            MsgBox("AH OCURRIDO UN ERROR " & ex.ToString())

        End Try

    End Sub

    'limpia todos los campos
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click

        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        txtStock.Clear()

    End Sub

    'esconde el form actual y muestra el menu principal
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        frmMenuPrincipal.Show()
        Me.Hide()

    End Sub

End Class