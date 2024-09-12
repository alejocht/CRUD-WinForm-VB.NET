Imports dominio.modelo
Imports negocio

Public Class principalVentaForm
    Private listado As List(Of Venta)
    Private Sub ventaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim negocio As New VentaNegocio
            listado = negocio.listar()
            dgvVentas.DataSource = listado
            dgvVentas.Columns("total").DefaultCellStyle.Format = "$#,##0.00"
            dgvVentas.Columns("id").HeaderText = "ID"
            dgvVentas.Columns("cliente").HeaderText = "Cliente"
            dgvVentas.Columns("fecha").HeaderText = "Fecha"
            dgvVentas.Columns("total").HeaderText = "Total"
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            For Each form In Application.OpenForms
                If TypeOf form Is formularioVentaForm Then
                    Exit Sub
                End If
            Next

            Dim form2 As New formularioVentaForm
            form2.ShowDialog()
            Dim negocio As New VentaNegocio
            listado = Nothing
            listado = negocio.listar()
            dgvVentas.DataSource = listado
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub dgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick

    End Sub
End Class