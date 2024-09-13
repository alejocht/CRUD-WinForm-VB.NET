Imports dominio

Public Class mostrarFacturaForm
    Private factura As Factura
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(value As Factura)
        InitializeComponent()
        factura = value
    End Sub
    Private Sub mostrarFacturaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvItems.DataSource = factura.detalle
        lblNombreCliente.Text = factura.cabecera.cliente.cliente
        lblFechaFact.Text = factura.cabecera.fecha.ToString("yyyy-MM-dd")
        lblImporteTotal.Text = "$" + factura.cabecera.total.ToString
        Label4.Text = factura.cabecera.cliente.telefono
        Label2.Text = factura.cabecera.cliente.correo
        lblID.Text = factura.cabecera.id

        dgvItems.Columns("id").Visible = False
        dgvItems.Columns("idventa").Visible = False
        dgvItems.Columns("producto").HeaderText = "Producto"
        dgvItems.Columns("precioUnitario").HeaderText = "Precio"
        dgvItems.Columns("cantidad").HeaderText = "Cantidad"
        dgvItems.Columns("precioTotal").HeaderText = "SubTotal"
        dgvItems.Columns("precioUnitario").DefaultCellStyle.Format = "$#,##0.00"
        dgvItems.Columns("precioTotal").DefaultCellStyle.Format = "$#,##0.00"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class