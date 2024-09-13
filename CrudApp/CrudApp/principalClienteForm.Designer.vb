<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principalClienteForm
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
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLupa = New System.Windows.Forms.Button()
        Me.lblBusqueda = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClientes.Location = New System.Drawing.Point(52, 44)
        Me.dgvClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(727, 479)
        Me.dgvClientes.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(833, 122)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(217, 28)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar Cliente"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(833, 170)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(217, 28)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar Cliente"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLupa
        '
        Me.btnLupa.Location = New System.Drawing.Point(984, 62)
        Me.btnLupa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLupa.Name = "btnLupa"
        Me.btnLupa.Size = New System.Drawing.Size(72, 28)
        Me.btnLupa.TabIndex = 11
        Me.btnLupa.Text = "Buscar"
        Me.btnLupa.UseVisualStyleBackColor = True
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.Location = New System.Drawing.Point(833, 44)
        Me.lblBusqueda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(69, 16)
        Me.lblBusqueda.TabIndex = 12
        Me.lblBusqueda.Text = "Busqueda"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(833, 64)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(153, 22)
        Me.txtBusqueda.TabIndex = 10
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(833, 218)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(217, 28)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar Cliente"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'principalClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLupa)
        Me.Controls.Add(Me.lblBusqueda)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "principalClienteForm"
        Me.Text = "clienteForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLupa As Button
    Friend WithEvents lblBusqueda As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnEliminar As Button
End Class
