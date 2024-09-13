Imports dominio
Imports dominio.modelo
Imports negocio

Public Class principalVentaForm
    Private listado As List(Of Venta)

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub ventaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargar()
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

            cargar()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub dgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick

    End Sub

    Private Sub cargar()
        Try
            Dim negocio As New VentaNegocio
            listado = negocio.listar()
            dgvVentas.DataSource = listado

            dgvVentas.Columns("total").DefaultCellStyle.Format = "$#,##0.00"
            dgvVentas.Columns("id").HeaderText = "ID"
            dgvVentas.Columns("cliente").HeaderText = "Cliente"
            dgvVentas.Columns("fecha").HeaderText = "Fecha"
            dgvVentas.Columns("total").HeaderText = "Total"
            dgvVentas.Columns("fecha").DefaultCellStyle.Format = "yyyy-MM-dd"
        Catch ex As Exception
            Throw ex
            Exit Sub
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            For Each form In Application.OpenForms
                If TypeOf form Is formularioVentaForm Then
                    Exit Sub
                End If
            Next
            Dim facturaMod As New Factura
            Dim negocioItemventa As New VentaItemNegocio
            facturaMod.cabecera = CType(dgvVentas.CurrentRow.DataBoundItem, Venta)
            facturaMod.detalle = negocioItemventa.listarItemsDeVenta(facturaMod.cabecera.id)
            Dim form2 As New formularioVentaForm(facturaMod)
            form2.ShowDialog()

            cargar()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnMostrarFactura_Click(sender As Object, e As EventArgs) Handles btnMostrarFactura.Click
        Try
            For Each form In Application.OpenForms
                If TypeOf form Is mostrarFacturaForm Then
                    Exit Sub
                End If
            Next
            Dim facturaMod As New Factura
            Dim negocioItemventa As New VentaItemNegocio
            facturaMod.cabecera = CType(dgvVentas.CurrentRow.DataBoundItem, Venta)
            facturaMod.detalle = negocioItemventa.listarItemsDeVenta(facturaMod.cabecera.id)
            Dim form2 As New mostrarFacturaForm(facturaMod)
            form2.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub
End Class