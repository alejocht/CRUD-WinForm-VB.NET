Imports dominio
Imports dominio.modelo
Imports negocio

Public Class formularioVentaForm
    Private listaDeItems As New List(Of VentaItem)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCliente.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub formularioVentaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim negocioCliente As New ClienteNegocio
            cmbCliente.DataSource = negocioCliente.listar()
            cmbCliente.DisplayMember = "cliente"
            cmbCliente.ValueMember = "id"

            Dim negocioProducto As New ProductoNegocio
            cmbProducto.DataSource = negocioProducto.listar()
            cmbProducto.DisplayMember = "nombre"
            cmbProducto.ValueMember = "id"

        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim factura As New Factura
            Dim negocio As New FacturaNegocio
            factura.cabecera.cliente = CType(cmbCliente.SelectedItem, Cliente)
            factura.cabecera.fecha = CType(fechaPicker.Value, Date)

            If listaDeItems Is Nothing Or listaDeItems.count < 1 Then
                Throw New Exception("Hubo un error: el cuerpo de la factura no tuvo items")
            End If

            factura.cabecera.total = listaDeItems.Sum(Function(p) p.precioTotal)
            factura.detalle = listaDeItems

            negocio.agregar(factura)

            MessageBox.Show("Factura guardada correctamente")
            listaDeItems = Nothing
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnAgregarItem_Click(sender As Object, e As EventArgs) Handles btnAgregarItem.Click
        Try
            Dim producto As New Producto
            Dim ventaItem As New VentaItem
            producto = CType(cmbProducto.SelectedItem, Producto)
            ventaItem.producto = producto
            ventaItem.precioUnitario = producto.precio
            ventaItem.cantidad = txtCantidad.Value
            ventaItem.precioTotal = ventaItem.precioUnitario * ventaItem.cantidad
            listaDeItems.Add(ventaItem)
            dgvItems.DataSource = Nothing
            dgvItems.DataSource = listaDeItems

            dgvItems.Columns("id").Visible = False
            dgvItems.Columns("idventa").Visible = False
            dgvItems.Columns("producto").HeaderText = "Producto"
            dgvItems.Columns("precioUnitario").HeaderText = "Precio"
            dgvItems.Columns("cantidad").HeaderText = "Cantidad"
            dgvItems.Columns("precioTotal").HeaderText = "SubTotal"
            dgvItems.Columns("precioUnitario").DefaultCellStyle.Format = "$#,##0.00"
            dgvItems.Columns("precioTotal").DefaultCellStyle.Format = "$#,##0.00"

            lblImporteTotal.Text = listaDeItems.Sum(Function(p) p.precioTotal).ToString("$#,##0.00")
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub dgvItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick

    End Sub
End Class