using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    class NegocioProducto
    {
        public static string insertarProducto(string codigoProducto, string nombreProducto, string descripcionProducto, string categoriaProducto, int cantidadProducto,
                                                float precioCompraProducto, float precioVentaProducto, string fechaRegistroPrecioCompra, string fechaRegistroPrecioVenta)
        {
            DatosProducto producto = new DatosProducto();
            producto.CodigoProducto=codigoProducto;
            producto.NombreProducto= nombreProducto;
            producto.DescripcionProducto = descripcionProducto; ;
            producto.CategoriaProducto=categoriaProducto;
            producto.CantidadProducto=cantidadProducto;
            producto.PrecioCompraProducto = precioCompraProducto;
            producto.PrecioVentaProducto = precioVentaProducto;
            producto.FechaRegistroPrecioCompra = fechaRegistroPrecioCompra;
            producto.FechaRegistroPrecioVenta = fechaRegistroPrecioVenta;

            return producto.insertarProducto(producto);
        }

        public static DataTable mostrarProductos()
        {
            return new DatosProducto().mostrarProductos();
        }

        public static DataTable consultarProductoTabla(string codigoProducto)
        {
            DatosProducto producto = new DatosProducto();
            producto.CodigoProducto = codigoProducto;

            return producto.consultarProductoTabla(producto);
        }

        public static string buscarProducto(string codigoProducto)
        {
            DatosProducto producto = new DatosProducto();
            producto.CodigoProducto = codigoProducto;

            return producto.buscarProducto(producto);
        }

        public static string actualizarCliente(string codigoProducto, int cantidadProducto, float precioCompraProducto, float precioVentaProducto,
                                                string fechaRegistroPrecioCompra, string fechaRegistroPrecioVenta)
        {
            DatosProducto producto = new DatosProducto();
            producto.CodigoProducto = codigoProducto;
            producto.CantidadProducto = cantidadProducto;
            producto.PrecioCompraProducto = precioCompraProducto;
            producto.PrecioVentaProducto = precioVentaProducto;
            producto.FechaRegistroPrecioCompra = fechaRegistroPrecioCompra;
            producto.FechaRegistroPrecioVenta = fechaRegistroPrecioVenta;

            return producto.actualizarProducto(producto);
        }

        public static string eliminarProducto(string codigoProducto)
        {
            DatosProducto producto = new DatosProducto();
            producto.CodigoProducto = codigoProducto;

            return producto.actualizarProducto(producto);
        }

    }
}
