Imports dominio.modelo
Imports negocio

Public Class formularioProductoForm
    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim negocio As New ProductoNegocio
            Dim aux As New Producto
            aux.nombre = txtNombre.Text
            aux.precio = txtPrecio.Text
            aux.categoria = txtCategoria.Text
            negocio.agregar(aux)
            MessageBox.Show("Producto " + aux.nombre + " agregado con exito")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
        End Try

    End Sub
End Class