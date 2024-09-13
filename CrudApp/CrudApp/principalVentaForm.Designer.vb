<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principalVentaForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnMostrarFactura = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVentas
        '
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvVentas.Location = New System.Drawing.Point(29, 37)
        Me.dgvVentas.MultiSelect = False
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(545, 389)
        Me.dgvVentas.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(609, 37)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(134, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Venta"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(609, 75)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(134, 23)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar Venta"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnMostrarFactura
        '
        Me.btnMostrarFactura.Location = New System.Drawing.Point(609, 115)
        Me.btnMostrarFactura.Name = "btnMostrarFactura"
        Me.btnMostrarFactura.Size = New System.Drawing.Size(134, 23)
        Me.btnMostrarFactura.TabIndex = 4
        Me.btnMostrarFactura.Text = "Mostrar detalle de Venta"
        Me.btnMostrarFactura.UseVisualStyleBackColor = True
        '
        'principalVentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMostrarFactura)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "principalVentaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ventaForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnMostrarFactura As Button
End Class
