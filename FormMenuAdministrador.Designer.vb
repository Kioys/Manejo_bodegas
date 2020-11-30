<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuAdministrador
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.comboProductos = New System.Windows.Forms.ComboBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(588, 559)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(651, 505)
        Me.DataGridView1.TabIndex = 2
        '
        'btnVentas
        '
        Me.btnVentas.Location = New System.Drawing.Point(13, 13)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(172, 23)
        Me.btnVentas.TabIndex = 3
        Me.btnVentas.Text = "Mostrar Ventas Realizadas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'comboProductos
        '
        Me.comboProductos.FormattingEnabled = True
        Me.comboProductos.Location = New System.Drawing.Point(460, 15)
        Me.comboProductos.Name = "comboProductos"
        Me.comboProductos.Size = New System.Drawing.Size(121, 21)
        Me.comboProductos.TabIndex = 6
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(339, 18)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(115, 13)
        Me.lblSelect.TabIndex = 7
        Me.lblSelect.Text = "Seleccionar Producto: "
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(587, 15)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FormMenuAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 594)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.comboProductos)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "FormMenuAdministrador"
        Me.Text = "FormMenuAdministrador"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnVentas As Button
    Friend WithEvents comboProductos As ComboBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents btnEliminar As Button
End Class
