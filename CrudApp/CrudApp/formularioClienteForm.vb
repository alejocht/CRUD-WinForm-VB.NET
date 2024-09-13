Imports dominio.modelo
Imports negocio

Public Class formularioClienteForm
    Private cliente As Cliente = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(cliente As Cliente)
        InitializeComponent()
        Me.cliente = cliente
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If cliente Is Nothing Then
                cliente = New Cliente
            End If

            Dim negocio As New ClienteNegocio
            cliente.cliente = txtNombre.Text
            cliente.telefono = txtTelefono.Text
            cliente.correo = txtCorreo.Text

            If cliente.id = 0 Then
                negocio.agregar(cliente)
                MessageBox.Show("Cliente " + cliente.cliente + " agregado con exito")
            Else
                negocio.modificar(cliente)
                MessageBox.Show("Cliente " + cliente.cliente + " modificado con exito")
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
        End Try
    End Sub

    Private Sub formularioClienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If cliente IsNot Nothing Then
                txtNombre.Text = cliente.cliente
                txtCorreo.Text = cliente.correo
                txtTelefono.Text = cliente.telefono
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class