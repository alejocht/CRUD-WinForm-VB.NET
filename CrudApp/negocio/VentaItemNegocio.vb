Imports dominio
Imports dominio.modelo

Public Class VentaItemNegocio
    Public Function listar() As List(Of VentaItem)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of VentaItem)
        Try
            datos.setearConsulta("SELECT * FROM ventasitems")
            datos.ejecutarLectura()
            While (datos.lector.Read())
                Dim aux As New VentaItem
                Dim negocioProducto As New ProductoNegocio

                aux.id = If(IsDBNull(datos.lector("ID")), 0, CType(datos.lector("ID"), Integer))
                aux.idVenta = If(IsDBNull(datos.lector("IDVenta")), 0, CType(datos.lector("IDVenta"), Integer))
                aux.producto.id = If(IsDBNull(datos.lector("IDProducto")), 0, CType(datos.lector("IDProducto"), Integer))

                aux.producto = negocioProducto.listar(aux.producto.id)
                If aux.producto Is Nothing Then
                    aux.producto.id = -1
                    Throw New Exception
                End If

                aux.precioUnitario = If(IsDBNull(datos.lector("PrecioUnitario")), 0, CType(datos.lector("PrecioUnitario"), Integer))
                aux.cantidad = If(IsDBNull(datos.lector("Cantidad")), 0, CType(datos.lector("Cantidad"), Integer))
                aux.precioTotal = If(IsDBNull(datos.lector("PrecioTotal")), 0, CType(datos.lector("PrecioTotal"), Decimal))

                lista.Add(aux)
            End While
            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

    Public Function listarItemsDeVenta(nroventa As Integer) As List(Of VentaItem)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of VentaItem)
        Try
            datos.setearConsulta("SELECT * FROM ventasitems where IDVenta = @idventa")
            datos.setearParametro("@idventa", nroventa)
            datos.ejecutarLectura()
            While (datos.lector.Read())
                Dim aux As New VentaItem
                Dim negocioProducto As New ProductoNegocio

                aux.id = If(IsDBNull(datos.lector("ID")), 0, CType(datos.lector("ID"), Integer))
                aux.idVenta = If(IsDBNull(datos.lector("IDVenta")), 0, CType(datos.lector("IDVenta"), Integer))
                aux.producto.id = If(IsDBNull(datos.lector("IDProducto")), 0, CType(datos.lector("IDProducto"), Integer))

                aux.producto = negocioProducto.listar(aux.producto.id)
                If aux.producto Is Nothing Then
                    aux.producto.id = -1
                    Throw New Exception
                End If

                aux.precioUnitario = If(IsDBNull(datos.lector("PrecioUnitario")), 0, CType(datos.lector("PrecioUnitario"), Integer))
                aux.cantidad = If(IsDBNull(datos.lector("Cantidad")), 0, CType(datos.lector("Cantidad"), Integer))
                aux.precioTotal = If(IsDBNull(datos.lector("PrecioTotal")), 0, CType(datos.lector("PrecioTotal"), Decimal))
                lista.Add(aux)
            End While
            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

    Public Function listar(id As Integer) As VentaItem
        Dim datos As New AccesoDatos
        Dim aux As New VentaItem
        Dim negocioProducto As New ProductoNegocio
        Try
            datos.setearConsulta("SELECT * FROM ventasitems where ID = @id")
            datos.setearParametro("@id", id)
            datos.ejecutarLectura()
            While (datos.lector.Read())
                aux.id = CType(datos.lector("ID"), Integer)
                aux.idVenta = CType(datos.lector("IDVenta"), Integer)
                aux.producto.id = CType(datos.lector("IDProducto"), Integer)

                aux.producto = negocioProducto.listar(aux.producto.id)
                If aux.producto Is Nothing Then
                    aux.producto.id = -1
                    Throw New Exception
                End If

                aux.precioUnitario = CType(datos.lector("PrecioUnitario"), Decimal)
                aux.cantidad = CType(datos.lector("Cantidad"), Integer)
                aux.precioTotal = CType(datos.lector("PrecioTotal"), Decimal)
            End While
            Return aux
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

    Public Sub agregar(ventaItem As VentaItem)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("INSERT INTO ventasitems ( IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) values ( @idventa, @idproducto, @precioUnitario, @cantidad, @precioTotal)")
            datos.setearParametro("@idventa", ventaItem.idVenta)
            datos.setearParametro("@idproducto", ventaItem.producto.id)
            datos.setearParametro("@precioUnitario", ventaItem.precioUnitario)
            datos.setearParametro("@cantidad", ventaItem.cantidad)
            datos.setearParametro("@precioTotal", ventaItem.precioTotal)
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub

    Public Sub modificar(ventaItem As VentaItem)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("UPDATE ventasitems SET IDVenta = @idventa,IDProducto = @idproducto,PrecioUnitario = @precioUnitario,Cantidad = @cantidad,PrecioTotal = @precioTotal WHERE ID = @id")
            datos.setearParametro("@id", ventaItem.id)
            datos.setearParametro("@idventa", ventaItem.idVenta)
            datos.setearParametro("@idproducto", ventaItem.producto.id)
            datos.setearParametro("@precioUnitario", ventaItem.precioUnitario)
            datos.setearParametro("@cantidad", ventaItem.cantidad)
            datos.setearParametro("@precioTotal", ventaItem.precioTotal)
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub
End Class
