Imports dominio
Imports dominio.modelo
Public Class ProductoNegocio
    Public Function listar() As List(Of Producto)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of Producto)
        Try
            datos.setearConsulta("SELECT * FROM productos")
            datos.ejecutarLectura()
            While (datos.lector.Read())
                Dim aux As New Producto
                aux.id = CType(datos.lector("ID"), Integer)
                aux.nombre = CType(datos.lector("Nombre"), String)
                aux.precio = CType(datos.lector("Precio"), Decimal)
                aux.categoria = CType(datos.lector("Categoria"), String)
                lista.Add(aux)
            End While

            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try

    End Function
    Public Function listar(id As Integer) As Producto
        Dim datos As New AccesoDatos
        Dim aux As New Producto
        Try
            datos.setearConsulta("SELECT * FROM productos where ID = @id")
            datos.setearParametro("@id", id)
            datos.ejecutarLectura()
            While (datos.lector.Read())
                aux.id = CType(datos.lector("ID"), Integer)
                aux.nombre = CType(datos.lector("Nombre"), String)
                aux.precio = CType(datos.lector("Precio"), Decimal)
                aux.categoria = CType(datos.lector("Categoria"), String)
            End While

            Return aux
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try

    End Function
    Public Sub agregar(producto As Producto)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("INSERT INTO productos (Nombre, Precio, Categoria) values (@nombre, @precio, @categoria)")
            datos.setearParametro("@nombre", producto.nombre)
            datos.setearParametro("@precio", producto.precio)
            datos.setearParametro("@categoria", producto.categoria)
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub
    Public Sub modificar(producto As Producto)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("update productos set Nombre = @nombre, Precio = @precio, Categoria = @categoria where ID = @id")
            datos.setearParametro("@id", producto.id)
            datos.setearParametro("@nombre", producto.nombre)
            datos.setearParametro("@precio", producto.precio)
            datos.setearParametro("@categoria", producto.categoria)
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub
    Public Sub reporte()
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("select 
                                    P.id,
                                    P.Nombre,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 1 ) as ene,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 2 ) as feb,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 3 ) as mar,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 4 ) as abr,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 5 ) as may,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 6 ) as jun,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 7 ) as jul,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 8 ) as ago,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 9 ) as sep,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 10 ) as oct,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 11 ) as nov,
                                    (select SUM(cantidad) from ventasitems VI inner join ventas on ventas.ID = vi.IDVenta where VI.ID = P.ID AND Month(ventas.Fecha) = 12 ) as dic
                                    from productos P")
            datos.ejecutarLectura()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class
