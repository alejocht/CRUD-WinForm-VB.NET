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
    Public Function reporte() As DataTable
        Dim datos As New AccesoDatos
        Dim tabla As New DataTable
        Try
            datos.setearConsulta("select 
                                    P.ID,
                                    P.nombre,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 1),0) as enero,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 2),0) as febrero,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 3),0) as marzo,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 4),0) as abril,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 5),0) as mayo,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 6),0) as junio,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 7),0) as julio,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 8),0) as agosto,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 9),0) as septiembre,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 10),0) as octubre,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 11),0) as noviembre,
                                    coalesce((select SUM(Cantidad) from ventasitems inner join ventas on ventas.ID = ventasitems.IDVenta where IDProducto = P.ID and MONTH(ventas.Fecha) = 12),0) as diciembre
                                    from productos P")
            datos.ejecutarLectura()
            tabla.Load(datos.lector)
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try

    End Function

    Public Function listarFiltro(filtro As String, tipoFiltro As String) As List(Of Producto)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of Producto)
        Dim cadenaDeFiltro As String = String.Empty
        Try
            Select Case tipoFiltro
                Case "comienza por"
                    cadenaDeFiltro = "'" + filtro + "%'"
                Case "contiene"
                    cadenaDeFiltro = "'%" + filtro + "%'"
                Case "termina con"
                    cadenaDeFiltro = "'%" + filtro + "'"
            End Select

            datos.setearConsulta("SELECT * FROM Productos where nombre like " + cadenaDeFiltro)
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

    Public Sub bajaFisica(value As Producto)
        Dim datos1 As New AccesoDatos
        Dim datos2 As New AccesoDatos
        Dim resultado As Integer
        Try
            datos1.setearConsulta("select count(*) from ventasitems where IDProducto = @id")
            datos1.setearParametro("@id", value.id)
            resultado = CType(datos1.ejecutarScalar(), Integer)
            If resultado > 0 Then
                Throw New Exception("Producto comprometido en una venta")
                Exit Sub
            End If
            datos2.setearConsulta("delete from productos where ID = @id")
            datos2.setearParametro("@id", value.id)
            datos2.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos1.cerrarConexion()
            datos2.cerrarConexion()
        End Try
    End Sub
End Class
