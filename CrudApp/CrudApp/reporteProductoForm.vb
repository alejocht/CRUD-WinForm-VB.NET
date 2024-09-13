Imports negocio

Public Class reporteProductoForm
    Private Sub reporteProductoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim negocio As New ProductoNegocio
        DataGridView1.DataSource = negocio.reporte()

    End Sub
End Class