<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMenuIngreso = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMenuAdministrador = New System.Windows.Forms.Button()
        Me.btnMenuVenta = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMenuIngreso
        '
        Me.btnMenuIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuIngreso.Location = New System.Drawing.Point(6, 19)
        Me.btnMenuIngreso.Name = "btnMenuIngreso"
        Me.btnMenuIngreso.Size = New System.Drawing.Size(371, 57)
        Me.btnMenuIngreso.TabIndex = 0
        Me.btnMenuIngreso.Text = "Ingreso de productos a bodega"
        Me.btnMenuIngreso.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnMenuAdministrador)
        Me.GroupBox1.Controls.Add(Me.btnMenuVenta)
        Me.GroupBox1.Controls.Add(Me.btnMenuIngreso)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 275)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu principal"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(6, 208)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(371, 57)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnMenuAdministrador
        '
        Me.btnMenuAdministrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuAdministrador.Location = New System.Drawing.Point(6, 145)
        Me.btnMenuAdministrador.Name = "btnMenuAdministrador"
        Me.btnMenuAdministrador.Size = New System.Drawing.Size(371, 57)
        Me.btnMenuAdministrador.TabIndex = 2
        Me.btnMenuAdministrador.Text = "Menu de administrador"
        Me.btnMenuAdministrador.UseVisualStyleBackColor = True
        '
        'btnMenuVenta
        '
        Me.btnMenuVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuVenta.Location = New System.Drawing.Point(6, 82)
        Me.btnMenuVenta.Name = "btnMenuVenta"
        Me.btnMenuVenta.Size = New System.Drawing.Size(371, 57)
        Me.btnMenuVenta.TabIndex = 1
        Me.btnMenuVenta.Text = "Venta de productos"
        Me.btnMenuVenta.UseVisualStyleBackColor = True
        '
        'FormMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 294)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormMenuPrincipal"
        Me.Text = "Menu principal"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMenuIngreso As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnMenuAdministrador As Button
    Friend WithEvents btnMenuVenta As Button
End Class
