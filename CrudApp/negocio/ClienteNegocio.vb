Imports dominio.modelo

Public Class ClienteNegocio
    Public Function listar() As List(Of Cliente)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of Cliente)
        Try
            datos.setearConsulta("SELECT * FROM Clientes")
            datos.ejecutarLectura()
            While (datos.lector.Read())
                Dim aux As New Cliente
                aux.id = If(IsDBNull(datos.lector("ID")), 0, CType(datos.lector("ID"), Integer))
                aux.cliente = If(IsDBNull(datos.lector("Cliente")), String.Empty, CType(datos.lector("Cliente"), String))
                aux.telefono = If(IsDBNull(datos.lector("Telefono")), String.Empty, CType(datos.lector("Telefono"), String))
                aux.correo = If(IsDBNull(datos.lector("Correo")), String.Empty, CType(datos.lector("Correo"), String))
                lista.Add(aux)
            End While
            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

    Public Function listar(id As Integer) As Cliente
        Dim datos As New AccesoDatos
        Dim aux As New Cliente
        Try
            datos.setearConsulta("SELECT * FROM Clientes where ID = @id")
            datos.setearParametro("@id", id)
            datos.ejecutarLectura()
            While (datos.lector.Read())
                aux.id = If(IsDBNull(datos.lector("ID")), 0, CType(datos.lector("ID"), Integer))
                aux.cliente = If(IsDBNull(datos.lector("Cliente")), String.Empty, CType(datos.lector("Cliente"), String))
                aux.telefono = If(IsDBNull(datos.lector("Telefono")), String.Empty, CType(datos.lector("Telefono"), String))
                aux.correo = If(IsDBNull(datos.lector("Correo")), String.Empty, CType(datos.lector("Correo"), String))
            End While
            Return aux
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function
    Public Function listarFiltro(filtro As String, tipoFiltro As String) As List(Of Cliente)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of Cliente)
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

            datos.setearConsulta("SELECT * FROM Clientes where Cliente like " + cadenaDeFiltro)
            datos.ejecutarLectura()
            While (datos.lector.Read())
                Dim aux As New Cliente
                aux.id = If(IsDBNull(datos.lector("ID")), 0, CType(datos.lector("ID"), Integer))
                aux.cliente = If(IsDBNull(datos.lector("Cliente")), String.Empty, CType(datos.lector("Cliente"), String))
                aux.telefono = If(IsDBNull(datos.lector("Telefono")), String.Empty, CType(datos.lector("Telefono"), String))
                aux.correo = If(IsDBNull(datos.lector("Correo")), String.Empty, CType(datos.lector("Correo"), String))
                lista.Add(aux)
            End While
            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function
    Public Sub agregar(cliente As Cliente)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("INSERT INTO clientes ( Cliente, Telefono, Correo) VALUES ( @cliente, @telefono, @correo)")
            datos.setearParametro("@cliente", cliente.cliente)
            datos.setearParametro("@telefono", cliente.telefono)
            datos.setearParametro("@correo", cliente.correo)
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub

    Public Sub modificar(cliente As Cliente)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("UPDATE clientes set Cliente = @cliente, Telefono = @telefono, Correo = @correo where ID = @id")
            datos.setearParametro("@id", cliente.id)
            datos.setearParametro("@cliente", cliente.cliente)
            datos.setearParametro("@telefono", cliente.telefono)
            datos.setearParametro("@correo", cliente.correo)
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub
    Public Sub bajaFisica(cliente As Cliente)
        Dim datos1 As New AccesoDatos
        Dim datos2 As New AccesoDatos
        Dim resultado As Integer
        Try
            datos1.setearConsulta("select COUNT(*) from ventas where IDCliente = @id")
            datos1.setearParametro("@id", cliente.id)
            resultado = datos1.ejecutarScalar()
            datos1.cerrarConexion()
            If resultado > 0 Then
                Throw New Exception("Cliente comprometido en Ventas")
                Exit Sub
            End If
            datos2.setearConsulta("delete from clientes where ID = @id")
            datos2.setearParametro("@id", cliente.id)
            datos2.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos1.cerrarConexion()
            datos2.cerrarConexion()
        End Try
    End Sub

End Class
