<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formularioVentaItemForm
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(69, 165)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAgregar.Location = New System.Drawing.Point(182, 165)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Guardar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(66, 94)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 9
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(66, 57)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 6
        Me.lblProducto.Text = "Producto"
        '
        'cmbProducto
        '
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(136, 54)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(121, 21)
        Me.cmbProducto.TabIndex = 13
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(136, 92)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(121, 20)
        Me.txtCantidad.TabIndex = 14
        Me.txtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'formularioVentaItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 266)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblProducto)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(339, 305)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(339, 305)
        Me.Name = "formularioVentaItemForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formularioVentaItemForm"
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents txtCantidad As NumericUpDown
End Class
