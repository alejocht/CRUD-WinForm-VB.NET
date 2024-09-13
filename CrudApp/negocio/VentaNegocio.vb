﻿Imports dominio
Imports dominio.modelo

Public Class VentaNegocio
    Public Function listar() As List(Of Venta)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of Venta)
        Try
            datos.setearConsulta("SELECT * FROM Ventas")
            datos.ejecutarLectura()
            While (datos.lector.Read())
                Dim aux As New Venta
                Dim negocioCliente As New ClienteNegocio
                aux.id = CType(datos.lector("ID"), Integer)
                aux.cliente = negocioCliente.listar(CType(datos.lector("IDCliente"), Integer))

                If aux.cliente Is Nothing Then
                    Throw New Exception
                End If

                aux.fecha = CType(datos.lector("Fecha"), Date)
                aux.total = If(IsDBNull(datos.lector("total")), 0, CType(datos.lector("Total"), Decimal))

                actualizarTotal(aux.id)
                lista.Add(aux)
            End While
            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

    Public Function listar(id As Integer) As Venta
        Dim datos As New AccesoDatos
        Dim aux As New Venta
        Try
            datos.setearConsulta("SELECT * FROM Ventas where ID = @id")
            datos.setearParametro("@id", id)
            datos.ejecutarLectura()
            Dim negocioCliente As New ClienteNegocio
            While (datos.lector.Read())
                aux.id = CType(datos.lector("ID"), Integer)
                aux.cliente = negocioCliente.listar(CType(datos.lector("IDCliente"), Integer))

                If aux.cliente Is Nothing Then
                    Throw New Exception
                End If

                aux.fecha = CType(datos.lector("Fecha"), Date)
                aux.total = If(IsDBNull(datos.lector("Total")), 0, CType(datos.lector("Total"), Decimal))
            End While
            Return aux
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

    Public Sub agregar(venta As Venta)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("INSERT INTO ventas ( IDCliente, Fecha) values ( @idcliente, @fecha)")
            datos.setearParametro("@idcliente", venta.cliente.id)
            datos.setearParametro("@fecha", venta.fecha)
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub

    Public Sub modificar(venta As Venta)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("UPDATE ventas SET IDCliente = @idcliente, Fecha = @fecha where ID = @id")
            datos.setearParametro("@id", venta.id)
            datos.setearParametro("@idcliente", venta.cliente.id)
            datos.setearParametro("@fecha", venta.fecha)
            actualizarTotal(venta.id)
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub

    Public Sub actualizarTotal(id As Integer)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("UPDATE ventas SET Total = Totales.TotalVentas FROM ventas JOIN (SELECT IDVenta, SUM(PrecioTotal) AS TotalVentas FROM ventasitems GROUP BY IDVenta) AS Totales ON ventas.ID = Totales.IDVenta WHERE ventas.ID = @id")
            datos.setearParametro("@id", id)
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub

    Public Function listarFiltro(filtro As String, tipoFiltro As String) As List(Of Venta)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of Venta)
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

            datos.setearConsulta("SELECT * FROM Ventas inner join clientes on clientes.ID = ventas.IDCliente where cliente like " + cadenaDeFiltro)
            datos.ejecutarLectura()
            While (datos.lector.Read())
                Dim aux As New Venta
                Dim negocioCliente As New ClienteNegocio
                aux.id = CType(datos.lector("ID"), Integer)
                aux.cliente = negocioCliente.listar(CType(datos.lector("IDCliente"), Integer))

                If aux.cliente Is Nothing Then
                    Throw New Exception
                End If

                aux.fecha = CType(datos.lector("Fecha"), Date)
                aux.total = If(IsDBNull(datos.lector("total")), 0, CType(datos.lector("Total"), Decimal))

                actualizarTotal(aux.id)
                lista.Add(aux)
            End While
            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function
End Class
