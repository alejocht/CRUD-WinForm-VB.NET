Imports dominio.modelo
Imports negocio

Public Class principalClienteForm
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            For Each form In Application.OpenForms
                If TypeOf form Is formularioClienteForm Then
                    Exit Sub
                End If
            Next

            Dim form2 As New formularioClienteForm
            form2.ShowDialog()
            Dim negocio As New ClienteNegocio
            listado = negocio.listar()
            dgvClientes.DataSource = listado
            dgvClientes.Refresh()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub
End Class