<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboProductos = New System.Windows.Forms.ComboBox()
        Me.numericCantidad = New System.Windows.Forms.NumericUpDown()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numericCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.comboProductos)
        Me.GroupBox1.Controls.Add(Me.numericCantidad)
        Me.GroupBox1.Controls.Add(Me.btnVender)
        Me.GroupBox1.Controls.Add(Me.dataGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 319)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vender producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(313, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cantidad de productos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Seleccionar Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Vender un producto"
        '
        'comboProductos
        '
        Me.comboProductos.FormattingEnabled = True
        Me.comboProductos.Location = New System.Drawing.Point(176, 80)
        Me.comboProductos.Name = "comboProductos"
        Me.comboProductos.Size = New System.Drawing.Size(121, 21)
        Me.comboProductos.TabIndex = 4
        '
        'numericCantidad
        '
        Me.numericCantidad.Location = New System.Drawing.Point(316, 80)
        Me.numericCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericCantidad.Name = "numericCantidad"
        Me.numericCantidad.Size = New System.Drawing.Size(121, 20)
        Me.numericCantidad.TabIndex = 3
        Me.numericCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnVender
        '
        Me.btnVender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVender.Location = New System.Drawing.Point(235, 115)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(140, 31)
        Me.btnVender.TabIndex = 1
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'dataGrid
        '
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(6, 152)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.Size = New System.Drawing.Size(585, 161)
        Me.dataGrid.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(487, 338)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(126, 35)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'FormVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 385)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.Name = "FormVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu de venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numericCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comboProductos As ComboBox
    Friend WithEvents numericCantidad As NumericUpDown
    Friend WithEvents btnVender As Button
End Class
