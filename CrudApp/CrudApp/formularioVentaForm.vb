Imports dominio
Imports dominio.modelo
Imports negocio

Public Class formularioVentaForm
    Private factura As Factura
    Private listaDeItems As New List(Of VentaItem)

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(value As Factura)
        InitializeComponent()
        factura = value
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCliente.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub formularioVentaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarCmb()
            If factura IsNot Nothing Then
                cmbCliente.SelectedIndex = (factura.cabecera.cliente.id) - 1
                fechaPicker.Value = factura.cabecera.fecha
                lblImporteTotal.Text = "$" + factura.cabecera.total.ToString
                listaDeItems = factura.detalle
            End If
            cargarDgv()

        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If factura Is Nothing Then
                factura = New Factura
            End If

            Dim negocio As New FacturaNegocio
            factura.cabecera.cliente = CType(cmbCliente.SelectedItem, Cliente)
            factura.cabecera.fecha = CType(fechaPicker.Value, Date)

            If listaDeItems Is Nothing Then
                Throw New Exception("El cuerpo de la factura no tuvo items")
            End If

            factura.cabecera.total = listaDeItems.Sum(Function(p) p.precioTotal)
            factura.detalle = listaDeItems

            If factura.cabecera.id = 0 Then
                negocio.agregar(factura)
                MessageBox.Show("Factura guardada correctamente")
                Me.Close()
            Else
                negocio.modificar(factura)
                MessageBox.Show("Factura guardada correctamente")
                Me.Close()
            End If

            dgvItems.DataSource = Nothing
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

            cargarDgv()
            lblImporteTotal.Text = listaDeItems.Sum(Function(p) p.precioTotal).ToString("$#,##0.00")
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub dgvItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick

    End Sub

    Private Sub cargarCmb()
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
            Throw ex
        End Try
    End Sub
    Private Sub cargarDgv()
        Try
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
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnModificarItem_Click(sender As Object, e As EventArgs) Handles btnModificarItem.Click
        Try
            Dim id As Integer
            Dim ventaItem As New VentaItem
            If dgvItems.CurrentRow Is Nothing Then
                Throw New Exception("Debe seleccionar una fila para modificar")
            End If
            ventaItem = CType(dgvItems.CurrentRow.DataBoundItem, VentaItem)
            id = ventaItem.id
            Dim form As New formularioVentaItemForm(listaDeItems, id)
            form.ShowDialog()
            listaDeItems = form.retornarLista()
            cargarDgv()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub
End Class