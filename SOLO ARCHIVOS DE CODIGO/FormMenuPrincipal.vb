Imports System.Runtime.CompilerServices

Public Class FormMenuPrincipal

    'DECLARACION DE VARIABLES
    Dim frmIngreso, frmMenuAdministrador, frmVenta

    Private Sub FormMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'INSTANCIAMOS TODOS LOS FORMULARIOS PARA LUEGO PODER ACCEDER A ELLOS SEGUN CORRESPONDA
        frmIngreso = New FormIngreso(Me)
        frmVenta = New FormVenta(Me)
        frmMenuAdministrador = New FormMenuAdministrador(Me)

    End Sub

    'CADA BOTON ENTRA A UN FORMULARIO ESPECIFICO, MOSTRANDO ESTE, PARA LUEGO ESCONDER EL MENU PRINCIPAL
    Private Sub btnMenuIngreso_Click(sender As Object, e As EventArgs) Handles btnMenuIngreso.Click

        frmIngreso.Show()
        Me.Hide()

    End Sub

    Private Sub btnMenuVenta_Click(sender As Object, e As EventArgs) Handles btnMenuVenta.Click

        frmVenta.Show()
        Me.Hide()

    End Sub

    Private Sub btnMenuAdministrador_Click(sender As Object, e As EventArgs) Handles btnMenuAdministrador.Click

        frmMenuAdministrador.Show()
        Me.Hide()

    End Sub

    'CIERRA EL PROGRAMA
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        End

    End Sub

End Class
