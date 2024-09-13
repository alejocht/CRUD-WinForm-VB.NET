Imports dominio.modelo
Imports negocio

Public Class principalProductoForm
    Private listado As New List(Of Producto)
    Private Sub productoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargar()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            For Each form In Application.OpenForms
                If TypeOf form Is formularioProductoForm Then
                    Exit Sub
                End If
            Next

            Dim form2 As New formularioProductoForm
            form2.ShowDialog()
            cargar()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            For Each form In Application.OpenForms
                If TypeOf form Is formularioProductoForm Then
                    Exit Sub
                End If
            Next

            Dim producto As New Producto
            producto = CType(dgvProductos.CurrentRow.DataBoundItem, Producto)

            Dim form2 As New formularioProductoForm(producto)
            form2.ShowDialog()
            cargar()
        Catch ex As Exception
            MessageBox.Show("Hubo un error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub cargar()
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
            Throw ex
            Exit Sub
        End Try
    End Sub

    Private Sub btnLupa_Click(sender As Object, e As EventArgs) Handles btnLupa.Click
        Try
            Dim filtro As String
            filtro = txtBusqueda.Text
            Dim negocio As New ProductoNegocio

            listado = negocio.listarFiltro(filtro, "contiene")
            If listado Is Nothing Then
                Throw New Exception("No hubo resultados para la busqueda")
            End If
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

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        For Each form In Application.OpenForms
            If TypeOf form Is reporteProductoForm Then
                Exit Sub
            End If
        Next

        Dim form2 As New reporteProductoForm()
        form2.ShowDialog()
    End Sub
End Class