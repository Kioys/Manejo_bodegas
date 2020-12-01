Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FormMenuAdministrador

    Dim frmMenuPrincipal As FormMenuPrincipal
    Dim productos As New Dictionary(Of Integer, String)
    Dim reader As MySqlDataReader
    Dim conexion As Conexion
    Dim filteredProductos As New Dictionary(Of Integer, String)

    Public Sub New(menuForm As FormMenuPrincipal)

        InitializeComponent()

        Me.frmMenuPrincipal = menuForm

        conexion = New Conexion("127.0.0.1", "root", "", "dbbodega")

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        frmMenuPrincipal.Show()
        Me.Hide()

    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter()
        Dim ds As New DataSet

        con = New MySqlConnection("server=localhost;uid=root;pwd=;database=dbbodega")
        con.Open()


        ada = New MySqlDataAdapter("SELECT iddetalleFactura as 'ID detalle factura', factura_idfactura as 'ID factura', p.nombreProducto as 'Nombre producto', p.Precio as 'Precio unitario', cantidadProducto as 'Cantidad vendida', f.fecha from detallefactura join productos as p on productos_idproductos = p.idProductos join factura as f on Factura_idFactura = f.idFactura", con)
        ada.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub comboProductos_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboProductos.SelectedValueChanged
        If (comboProductos.SelectedItem = String.Empty) Then
            Return
        End If
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter()
        Dim ds As New DataSet

        Dim query = "Select * from productos where nombreProducto ='" & comboProductos.SelectedItem.ToString & "'"

        con = New MySqlConnection("server=localhost;uid=root;pwd=;database=dbbodega")
        con.Open()

        ada = New MySqlDataAdapter(query, con)
        ada.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (comboProductos.SelectedItem = String.Empty) Then
            Return
        End If
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter()
        Dim ds As New DataSet
        Dim query = "Delete from productos where nombreProducto ='" & comboProductos.SelectedItem.ToString & "'"
        Dim resultado = MsgBox("¿Seguro que desea eliminar " & comboProductos.SelectedItem.ToString & " ?", vbYesNo + vbExclamation, "Mensaje especial")
        If (resultado = 6) Then
            con = New MySqlConnection("server=localhost;uid=root;pwd=;database=dbbodega")
            con.Open()

            ada = New MySqlDataAdapter(query, con)
            ada.Fill(ds)
            MsgBox("Dato eliminado.")
            comboProductos.Items.Remove(comboProductos.SelectedItem)
            comboProductos.SelectedIndex = 0
        Else
            MsgBox("No se realizaron cambios.")
        End If
    End Sub

    Private Sub FormMenuAdministrador_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        If conexion.getConexion().State.Equals(ConnectionState.Closed) Then

            conexion.getConexion().Open()

        End If

        reader = conexion.enviarConsulta("SELECT * FROM productos").ExecuteReader()

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
End Class