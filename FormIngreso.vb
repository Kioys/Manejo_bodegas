Imports System.Security.Cryptography

Public Class FormIngreso

    Dim frmMenuPrincipal As FormMenuPrincipal
    Dim proveedores As New Dictionary(Of Integer, String)
    Dim conexion As Conexion

    Public Sub New(menuForm As FormMenuPrincipal)

        InitializeComponent()

        Me.frmMenuPrincipal = menuForm

        conexion = New Conexion("127.0.0.1", "root", "", "dbbodega")

        proveedores = conexion.getProveedores()

        For Each kvp As KeyValuePair(Of Integer, String) In proveedores

            comboProveedor.Items.Add(kvp.Value)

        Next

        comboProveedor.SelectedIndex = 0

    End Sub

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

                Catch ex As Exception

                    MsgBox("No puede haber texto en los campos numericos (Codigo Producto, stock, precio unidad)")

                End Try

            End If


        Catch ex As Exception

            MsgBox("AH OCURRIDO UN ERROR " & ex.ToString())

        End Try

    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click

        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        txtStock.Clear()

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        frmMenuPrincipal.Show()
        Me.Hide()

    End Sub

End Class