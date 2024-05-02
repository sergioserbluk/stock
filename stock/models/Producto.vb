Public Class Producto
    Private codigo As String ' Codigo de barras
    Private nombre As String ' Nombre del producto
    Private descripcion As String ' Descripcion del producto
    Private precioCosto As Double ' Precio de costo
    Private precioVenta As Double ' Precio de venta
    Private stock As Integer ' Stock actual
    Private stockMinimo As Integer ' Stock minimo
    Private utilidad As Integer ' Utilidad
    Private categoria As String ' Categoria
    Private proveedor As String ' Proveedor
    ' Getters And setters
    Public Function getCodigo() As String
        Return codigo
    End Function
    Public Sub setCodigo(codigo As String)
        Me.codigo = codigo
    End Sub
    Public Function getNombre() As String
        Return nombre
    End Function
    Public Sub setNombre(nombre As String)
        Me.nombre = nombre
    End Sub
    Public Function getDescripcion() As String
        Return descripcion
    End Function
    Public Sub setDescripcion(descripcion As String)
        Me.descripcion = descripcion
    End Sub
    Public Function getPrecioCosto() As Double
        Return precioCosto
    End Function
    Public Sub setPrecioCosto(precioCosto As Double)
        Me.precioCosto = precioCosto
    End Sub
    Public Function getPrecioVenta() As Double
        Return precioVenta
    End Function
    Public Sub setPrecioVenta(precioVenta As Double)
        Me.precioVenta = precioVenta
    End Sub
    Public Function getStock() As Integer
        Return stock
    End Function
    Public Sub setStock(stock As Integer)
        Me.stock = stock
    End Sub
    Public Function getStockMinimo() As Integer
        Return stockMinimo
    End Function
    Public Sub setStockMinimo(stockMinimo As Integer)
        Me.stockMinimo = stockMinimo
    End Sub
    Public Function getUtilidad() As Integer
        Return utilidad
    End Function
    Public Sub setUtilidad(utilidad As Integer)
        Me.utilidad = utilidad
    End Sub
    Public Function getCategoria() As String
        Return categoria
    End Function
    Public Sub setCategoria(categoria As String)
        Me.categoria = categoria
    End Sub
    Public Function getProveedor() As String
        Return proveedor
    End Function
    Public Sub setProveedor(proveedor As String)
        Me.proveedor = proveedor
    End Sub
    Public Sub New(codigo As String, nombre As String, descripcion As String, precioCosto As Double, precioVenta As Double, stock As Integer, stockMinimo As Integer, utilidad As Integer, categoria As String, proveedor As String)
        Me.codigo = codigo
        Me.nombre = nombre
        Me.descripcion = descripcion
        Me.precioCosto = precioCosto
        'Me.precioVenta = precioVenta
        Me.stock = stock
        Me.stockMinimo = stockMinimo
        Me.utilidad = utilidad
        Me.categoria = categoria
        Me.proveedor = proveedor
        Me.precioVenta = precioCosto + (precioCosto * utilidad / 100)
    End Sub
    ' Constructor vacio
    Public Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "Producto{" + "codigo=" + codigo + ", nombre=" + nombre + ", descripcion=" + descripcion + ", precioCosto=" + precioCosto + ", precioVenta=" + precioVenta + ", stock=" + stock + ", stockMinimo=" + stockMinimo + ", utilidad=" + utilidad + ", categoria=" + categoria + ", proveedor=" + proveedor + "}"
    End Function
    ' metodo para calcular precioVenta
    Public Sub calcularPrecioVenta()
        precioVenta = precioCosto + (precioCosto * utilidad / 100)
    End Sub









End Class
