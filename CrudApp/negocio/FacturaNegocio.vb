Imports dominio
Imports dominio.modelo

Public Class FacturaNegocio
    Public Function listar(id As Integer) As Factura
        Try
            Dim factura As New Factura
            Dim negocioVenta As New VentaNegocio
            Dim negocioVentaItem As New VentaItemNegocio
            factura.cabecera = negocioVenta.listar(id)
            factura.detalle = negocioVentaItem.listarItemsDeVenta(id)
            Return factura
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub agregar(factura As Factura)
        Try
            Dim negocio As New VentaNegocio
            Dim negocioVentaItem As New VentaItemNegocio
            Dim listadeVentas As New List(Of Venta)

            negocio.agregar(factura.cabecera)
            listadeVentas = negocio.listar()
            Dim ultimoId As Integer = listadeVentas.Last.id
            negocio.actualizarTotal(ultimoId)
            For Each ventaItem In factura.detalle
                ventaItem.idVenta = ultimoId
                negocioVentaItem.agregar(ventaItem)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
