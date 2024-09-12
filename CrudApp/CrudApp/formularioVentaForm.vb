Imports dominio
Imports dominio.modelo
Imports negocio

Public Class formularioVentaForm
    Private listaDeItems As List(Of VentaItem)
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

            factura.cabecera.total = listaDeItems.Sum(Function(p) p.precioUnitario)
            factura.detalle = listaDeItems

            negocio.agregar(factura)
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnAgregarItem_Click(sender As Object, e As EventArgs) Handles btnAgregarItem.Click

    End Sub
End Class