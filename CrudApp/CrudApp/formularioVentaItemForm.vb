Imports dominio.modelo
Imports negocio

Public Class formularioVentaItemForm
    Private nuevaLista As List(Of VentaItem)
    Private lista As List(Of VentaItem)
    Private id As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(value1 As List(Of VentaItem), value2 As Integer)
        InitializeComponent()
        lista = value1
        id = value2
    End Sub

    Private Sub formularioVentaItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim negocioProducto As New ProductoNegocio
            cmbProducto.DataSource = negocioProducto.listar()
            cmbProducto.DisplayMember = "nombre"
            cmbProducto.ValueMember = "id"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function retornarLista() As List(Of VentaItem)
        Return nuevaLista
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim aux As New VentaItem
            aux = lista.FirstOrDefault(Function(i) i.id = id)
            If aux IsNot Nothing Then
                aux.producto = CType(cmbProducto.SelectedItem, Producto)
                aux.cantidad = txtCantidad.Value
                aux.precioUnitario = aux.producto.precio
                aux.precioTotal = aux.precioUnitario * aux.cantidad
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class