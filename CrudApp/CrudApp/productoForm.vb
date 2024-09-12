Imports dominio.modelo
Imports negocio

Public Class productoForm
    Private listado As New List(Of Producto)
    Private Sub productoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim negocio As New ProductoNegocio
            listado = negocio.listar()
            dgvProductos.DataSource = listado
            dgvProductos.Columns("precio").DefaultCellStyle.Format = "$#,##0.00"
            dgvProductos.Columns("id").HeaderText = "ID"
            dgvProductos.Columns("nombre").HeaderText = "Producto"
            dgvProductos.Columns("precio").HeaderText = "Precio"
            dgvProductos.Columns("categoria").HeaderText = "Categoria"
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub dgvProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProductos.SelectionChanged
        Try
            Dim producto As New Producto
            producto = CType(dgvProductos.CurrentRow.DataBoundItem, Producto)
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub
End Class