Imports dominio.modelo
Imports negocio

Public Class clienteForm
    Private listado As List(Of Cliente)
    Private Sub clienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim negocio As New ClienteNegocio
            listado = negocio.listar()
            dgvClientes.DataSource = listado
            dgvClientes.Columns("id").HeaderText = "ID"
            dgvClientes.Columns("cliente").HeaderText = "Nombre"
            dgvClientes.Columns("telefono").HeaderText = "Telefono"
            dgvClientes.Columns("correo").HeaderText = "Correo"
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub
End Class