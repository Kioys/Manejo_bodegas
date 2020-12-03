Imports MySql.Data.MySqlClient
Public Class FormVenta

    'DECLARACION DE VARIABLES Y OBJETOS
    Dim selectedProductoId, stock, nuevoStock As Integer
    Dim frmMenuPrincipal As FormMenuPrincipal
    Dim conexion As Conexion
    Dim productos As New Dictionary(Of Integer, String)
    Dim reader As MySqlDataReader
    Dim datos As DataSet

    Public Sub New(menuForm As FormMenuPrincipal)
        'inicializacion de componentes del form
        InitializeComponent()

        'obtener el form del menu principal
        Me.frmMenuPrincipal = menuForm

        'configurar los parametros de conexion
        conexion = New Conexion("127.0.0.1", "root", "", "dbbodega")

    End Sub

    'al dar click a vender se guarda el valor del nuevo stock y se ejecuta un comando para hacer un update de stock al producto
    'agregando una nueva factura y una nueva detallefactura con la id de la factura nueva
    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click

        nuevoStock = stock - numericCantidad.Value

        conexion.enviarComando(String.Format("UPDATE productos set stock = {0} where idProductos = {1}; INSERT INTO factura(fecha) values(now()); INSERT INTO detallefactura(factura_idfactura, cantidadProducto, productos_idProductos) values((select idfactura from factura order by idfactura desc LIMIT 1), {2}, {3})", nuevoStock, selectedProductoId, numericCantidad.Value, selectedProductoId))

    End Sub

    'cuando el estado de visibilidad de la ventana cambie se realice la obtencion de datos
    Private Sub FormVenta_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        'si la conexion está cerrada entonces que la abra
        If conexion.getConexion().State.Equals(ConnectionState.Closed) Then

            conexion.getConexion().Open()

        End If

        'obtener los resultados de la consulta
        reader = conexion.enviarConsulta("SELECT idProductos, nombreProducto FROM productos").ExecuteReader()

        'leer los resultados, limpiar el diccionario y los items del combo box, luego agregar los datos obtenidos al diccionario
        If reader.HasRows Then

            productos.Clear()
            comboProductos.Items.Clear()

            Do While reader.Read()

                productos.Add(reader.GetInt32(0), reader.GetString(1))

            Loop

        End If

        reader.Close()

        'agregar los datos value del diccionario a la lista "comboProductos"
        For Each kvp As KeyValuePair(Of Integer, String) In productos

            comboProductos.Items.Add(kvp.Value)

        Next

        'seleccionar el primer item
        comboProductos.SelectedIndex = 0
    End Sub

    Private Sub btnVolver_Click_1(sender As Object, e As EventArgs) Handles btnVolver.Click
        'al precionar el boton volver que esconda este form y abra el menu principal
        frmMenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub comboProductos_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboProductos.SelectedValueChanged

        'cuando se seleccione un item distinto se ejecuta el siguiente codigo
        'este codigo lee el diccionario producto para obtener el id del producto que corresponde al item seleccionado
        'luego hacemos la consulta correcta y la mostramos en el DataGridView 

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