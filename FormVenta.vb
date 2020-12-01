Imports MySql.Data.MySqlClient
Public Class FormVenta

    Dim selectedProductoId, stock, nuevoStock As Integer
    Dim frmMenuPrincipal As FormMenuPrincipal
    Dim conexion As Conexion
    Dim productos As New Dictionary(Of Integer, String)
    Dim reader As MySqlDataReader
    Dim datos As DataSet

    Public Sub New(menuForm As FormMenuPrincipal)

        InitializeComponent()

        Me.frmMenuPrincipal = menuForm

        conexion = New Conexion("127.0.0.1", "root", "", "dbbodega")

    End Sub


    Private Sub FormVenta_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown



    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click

        nuevoStock = stock - numericCantidad.Value

        conexion.enviarComando(String.Format("UPDATE productos set stock = {0} where idProductos = {1}; INSERT INTO factura(fecha) values(now()); INSERT INTO detallefactura(factura_idfactura, cantidadProducto, productos_idProductos) values((select idfactura from factura order by idfactura desc LIMIT 1), {2}, {3})", nuevoStock, selectedProductoId, numericCantidad.Value, selectedProductoId))

    End Sub

    Private Sub FormVenta_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        If conexion.getConexion().State.Equals(ConnectionState.Closed) Then

            conexion.getConexion().Open()

        End If

        reader = conexion.enviarConsulta("SELECT idProductos, nombreProducto FROM productos").ExecuteReader()

        If reader.HasRows Then

            productos.Clear()
            comboProductos.Items.Clear()

            Do While reader.Read()

                productos.Add(reader.GetInt32(0), reader.GetString(1))

            Loop

        End If

        reader.Close()

        For Each kvp As KeyValuePair(Of Integer, String) In productos

            comboProductos.Items.Add(kvp.Value)

        Next

        comboProductos.SelectedIndex = 0
    End Sub

    Private Sub btnVolver_Click_1(sender As Object, e As EventArgs) Handles btnVolver.Click
        frmMenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub comboProductos_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboProductos.SelectedValueChanged



        For Each kvp As KeyValuePair(Of Integer, String) In productos

            If kvp.Value.Equals(comboProductos.SelectedItem) Then

                selectedProductoId = kvp.Key

            End If

        Next

        datos = conexion.enviarConsultaDataSet("Select idProductos as 'ID producto', nombreProducto as 'Nombre producto', stock as 'Stock disponible', precio as 'Precio unidad', p.nombre As 'Nombre proveedor' from productos join proveedor as p on Proveedor_idProveedor = p.idProveedor where idProductos = " & selectedProductoId)

        dataGrid.DataSource = datos.Tables(0)

        stock = dataGrid.Rows(0).Cells(2).Value

        numericCantidad.Maximum = stock

        If stock = 0 Then

            MsgBox("No hay más stock de este producto, lo sentimos")

            btnVender.Enabled = False

        Else

            btnVender.Enabled = Enabled

        End If



    End Sub
End Class