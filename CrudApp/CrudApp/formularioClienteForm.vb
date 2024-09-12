Imports dominio.modelo
Imports negocio

Public Class formularioClienteForm
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim negocio As New ClienteNegocio
            Dim aux As New Cliente
            aux.cliente = txtNombre.Text
            aux.telefono = txtTelefono.Text
            aux.correo = txtCorreo.Text
            negocio.agregar(aux)
            MessageBox.Show("Cliente " + aux.cliente + " agregado con exito")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
        End Try
    End Sub

    Private Sub formularioClienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class