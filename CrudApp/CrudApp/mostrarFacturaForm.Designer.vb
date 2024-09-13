<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mostrarFacturaForm
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
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.lblImporteTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblFechaFact = New System.Windows.Forms.Label()
        Me.lblParaId = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvItems
        '
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItems.Location = New System.Drawing.Point(23, 185)
        Me.dgvItems.MultiSelect = False
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(617, 342)
        Me.dgvItems.TabIndex = 5
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.AutoSize = True
        Me.lblImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteTotal.Location = New System.Drawing.Point(109, 130)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(0, 18)
        Me.lblImporteTotal.TabIndex = 14
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(39, 130)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Total"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(338, 59)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 12
        Me.lblFecha.Text = "Fecha"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(39, 63)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 11
        Me.lblCliente.Text = "Cliente"
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(109, 59)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(0, 18)
        Me.lblNombreCliente.TabIndex = 15
        '
        'lblFechaFact
        '
        Me.lblFechaFact.AutoSize = True
        Me.lblFechaFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFact.Location = New System.Drawing.Point(403, 59)
        Me.lblFechaFact.Name = "lblFechaFact"
        Me.lblFechaFact.Size = New System.Drawing.Size(0, 18)
        Me.lblFechaFact.TabIndex = 16
        '
        'lblParaId
        '
        Me.lblParaId.AutoSize = True
        Me.lblParaId.Location = New System.Drawing.Point(341, 130)
        Me.lblParaId.Name = "lblParaId"
        Me.lblParaId.Size = New System.Drawing.Size(18, 13)
        Me.lblParaId.TabIndex = 17
        Me.lblParaId.Text = "ID"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(403, 130)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 18)
        Me.lblID.TabIndex = 18
        '
        'mostrarFacturaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 588)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblParaId)
        Me.Controls.Add(Me.lblFechaFact)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.lblImporteTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.dgvItems)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(679, 627)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(679, 627)
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
End Class
