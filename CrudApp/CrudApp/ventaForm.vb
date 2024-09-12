Imports dominio.modelo
Imports negocio

Public Class ventaForm
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
End Class