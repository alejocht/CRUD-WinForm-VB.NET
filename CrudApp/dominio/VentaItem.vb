Namespace modelo
    Public Class VentaItem
        Private _id As Integer
        Private _idVenta As Integer
        Private _producto As Producto
        Private _precioUnitario As Decimal
        Private _cantidad As Decimal
        Private _precioTotal As Decimal

        Public Sub New()

        End Sub

        Public Sub New(ByVal id As Integer, ByVal idVenta As Integer, idProducto As Integer, precioUnitario As Decimal, cantidad As Decimal, precioTotal As Decimal)
            _id = id
            _idVenta = idVenta
            _producto.id = idProducto
            _precioUnitario = precioUnitario
            _cantidad = cantidad
            _precioTotal = precioTotal
        End Sub

        Public Property id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property idVenta As Integer
            Get
                Return _idVenta
            End Get
            Set(value As Integer)
                _idVenta = value
            End Set
        End Property

        Public Property producto As Producto
            Get
                Return _producto
            End Get
            Set(value As Producto)
                _producto = value
            End Set
        End Property

        Public Property precioUnitario As Decimal
            Get
                Return _precioUnitario
            End Get
            Set(value As Decimal)
                _precioUnitario = value
            End Set
        End Property

        Public Property cantidad As Decimal
            Get
                Return _cantidad
            End Get
            Set(value As Decimal)
                _cantidad = value
            End Set
        End Property

        Public Property precioTotal As Decimal
            Get
                Return _precioTotal
            End Get
            Set(value As Decimal)
                _precioTotal = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return "[ ID: " + id.ToString + " IDVenta: " + idVenta.ToString + " Producto: " + producto.ToString + " Precio unitario: $" + precioUnitario.ToString + " Importe total: " + precioTotal.ToString + " ]"
        End Function
    End Class
End Namespace