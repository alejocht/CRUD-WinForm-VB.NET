Imports dominio.modelo
Imports negocio

Public Class formularioProductoForm
    Private producto As Producto
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(producto As Producto)
        InitializeComponent()
        Me.producto = producto
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim negocio As New ProductoNegocio
            Dim aux As New Producto
            aux.nombre = txtNombre.Text
            aux.precio = txtPrecio.Text
            aux.categoria = txtCategoria.Text
            negocio.agregar(aux)
            MessageBox.Show("Producto " + aux.nombre + " agregado con exito")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
        End Try

    End Sub

    Private Sub formularioProductoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If producto IsNot Nothing Then
                txtNombre.Text = producto.nombre
                txtPrecio.Text = producto.precio
                txtCategoria.Text = producto.categoria
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub modificar()

    End Sub
End Class