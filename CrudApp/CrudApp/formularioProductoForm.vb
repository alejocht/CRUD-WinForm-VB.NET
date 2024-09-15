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
            If producto Is Nothing Then
                producto = New Producto
            End If

            Dim negocio As New ProductoNegocio
            producto.nombre = txtNombre.Text
            producto.precio = txtPrecio.Text
            producto.categoria = txtCategoria.Text

            If producto.precio <= 0 Then
                Throw New Exception("El precio no puede ser menor o igual a $0")
            End If

            If producto.id = 0 Then
                negocio.agregar(producto)
                MessageBox.Show("Producto " + producto.nombre + " agregado con exito")
            Else
                negocio.modificar(producto)
                MessageBox.Show("Producto " + producto.nombre + " modificado con exito")
            End If

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
            MessageBox.Show("Hubo un error: " + ex.Message)
        End Try
    End Sub

End Class