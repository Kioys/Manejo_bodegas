Imports System.Runtime.CompilerServices

Public Class FormMenuPrincipal

    Dim frmIngreso, frmMenuAdministrador, frmVenta

    Private Sub FormMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmIngreso = New FormIngreso(Me)
        frmVenta = New FormVenta(Me)
        frmMenuAdministrador = New FormMenuAdministrador(Me)

    End Sub

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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

End Class
