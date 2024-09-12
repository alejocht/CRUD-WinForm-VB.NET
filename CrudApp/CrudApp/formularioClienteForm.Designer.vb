<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formularioClienteForm
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
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(69, 190)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAgregar.Location = New System.Drawing.Point(182, 190)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Guardar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(138, 126)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtCorreo.TabIndex = 13
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(66, 134)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 12
        Me.lblCorreo.Text = "Correo"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(138, 91)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 11
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(66, 99)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 10
        Me.lblTelefono.Text = "Telefono"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(138, 54)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 9
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(66, 62)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre"
        '
        'formularioClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 266)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(339, 305)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(339, 305)
        Me.Name = "formularioClienteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "altaClienteForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
End Class
