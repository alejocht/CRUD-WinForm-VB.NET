<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mostrarFacturaForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.lblImporteTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblFechaFact = New System.Windows.Forms.Label()
        Me.lblParaId = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblParaCorreo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvItems
        '
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItems.Location = New System.Drawing.Point(31, 228)
        Me.dgvItems.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvItems.MultiSelect = False
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(823, 421)
        Me.dgvItems.TabIndex = 5
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.AutoSize = True
        Me.lblImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteTotal.Location = New System.Drawing.Point(145, 173)
        Me.lblImporteTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(0, 18)
        Me.lblImporteTotal.TabIndex = 14
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(52, 173)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(38, 16)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Total"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(451, 73)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(45, 16)
        Me.lblFecha.TabIndex = 12
        Me.lblFecha.Text = "Fecha"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(52, 78)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(48, 16)
        Me.lblCliente.TabIndex = 11
        Me.lblCliente.Text = "Cliente"
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(145, 73)
        Me.lblNombreCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(0, 18)
        Me.lblNombreCliente.TabIndex = 15
        '
        'lblFechaFact
        '
        Me.lblFechaFact.AutoSize = True
        Me.lblFechaFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFact.Location = New System.Drawing.Point(537, 73)
        Me.lblFechaFact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaFact.Name = "lblFechaFact"
        Me.lblFechaFact.Size = New System.Drawing.Size(0, 18)
        Me.lblFechaFact.TabIndex = 16
        '
        'lblParaId
        '
        Me.lblParaId.AutoSize = True
        Me.lblParaId.Location = New System.Drawing.Point(455, 173)
        Me.lblParaId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParaId.Name = "lblParaId"
        Me.lblParaId.Size = New System.Drawing.Size(20, 16)
        Me.lblParaId.TabIndex = 17
        Me.lblParaId.Text = "ID"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(537, 173)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 18)
        Me.lblID.TabIndex = 18
        '
        'lblParaCorreo
        '
        Me.lblParaCorreo.AutoSize = True
        Me.lblParaCorreo.Location = New System.Drawing.Point(52, 110)
        Me.lblParaCorreo.Name = "lblParaCorreo"
        Me.lblParaCorreo.Size = New System.Drawing.Size(48, 16)
        Me.lblParaCorreo.TabIndex = 19
        Me.lblParaCorreo.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 14)
        Me.Label2.TabIndex = 20
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(52, 141)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefono.TabIndex = 21
        Me.lblTelefono.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 14)
        Me.Label4.TabIndex = 22
        '
        'mostrarFacturaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 905)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblParaCorreo)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblParaId)
        Me.Controls.Add(Me.lblFechaFact)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.lblImporteTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.dgvItems)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 763)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 763)
        Me.Name = "mostrarFacturaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents lblImporteTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblFechaFact As Label
    Friend WithEvents lblParaId As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblParaCorreo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents Label4 As Label
End Class
