﻿Imports System.Security.Cryptography

Public Class FormIngreso

    Dim frmMenuPrincipal As FormMenuPrincipal

    Public Sub New(menuForm As FormMenuPrincipal)

        InitializeComponent()

        Me.frmMenuPrincipal = menuForm

    End Sub




    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        frmMenuPrincipal.Show()
        Me.Hide()

    End Sub

End Class