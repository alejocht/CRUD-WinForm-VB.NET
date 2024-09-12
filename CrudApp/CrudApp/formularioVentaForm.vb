Imports dominio
Imports negocio

Public Class formularioVentaForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCliente.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub formularioVentaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim factura As New Factura
            Dim negocioCliente As New ClienteNegocio
            cmbCliente.DataSource = negocioCliente.listar()
            cmbCliente.DisplayMember = "cliente"
            cmbCliente.ValueMember = "id"

        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub
End Class