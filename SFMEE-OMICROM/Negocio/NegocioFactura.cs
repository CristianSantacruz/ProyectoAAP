using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class NegocioFactura
    {
        public static DataTable contarRegistros()
        {
            return new DatosFactura().contarRegistros();
        }

        public static string insertarFactura(int idCliente, string fechaFactura, string vendedor, string tipoPago,
                          float subtotal, float descuento, float iva, float total, string estadoFactura, DataTable tablaDetalle)
        {
            DatosFactura factura = new DatosFactura();
            factura.IdCliente = idCliente;
            factura.FechaFactura = fechaFactura;
            factura.Vendedor = vendedor;
            factura.TipoPago = tipoPago;
            factura.SubTotal = subtotal;
            factura.Descuento = descuento;
            factura.Iva = iva;
            factura.Total = total;
            factura.EstadoFactura = estadoFactura;
            List<DatosDetalleFactura> detalles = new List<DatosDetalleFactura>();
            foreach (DataRow row in tablaDetalle.Rows)
            {
                DatosDetalleFactura detalle = new DatosDetalleFactura();
                detalle.IdFactura = Convert.ToInt32(row["IDFACTURA"].ToString());
                detalle.IdProducto = Convert.ToInt32(row["IDPRODUCTO"].ToString());
                detalle.IdMantenimiento = Convert.ToInt32(row["IDMANTENIMIENTO"].ToString());
                detalle.Codigo = (row["CODIGO"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["CANTIDAD"].ToString());
                detalle.Detalle = (row["DETALLE"].ToString());
                detalle.ValorUnitario = float.Parse(row["VALORUNITARIO"].ToString());
                detalle.DescuentoDetalle = float.Parse(row["DESCUENTODETALLE"].ToString());
                detalle.ValorTotal = float.Parse(row["VALORTOTAL"].ToString());
                detalles.Add(detalle);
            }
            return factura.insertarDatosFactura(factura, detalles);
        }

        public static string anularFactura(int idfactura)
        {
            DatosFactura factura = new DatosFactura();
            factura.IdFactura = idfactura;
            
            return factura.eliminarFactura(factura);
        }

        public static DataTable mostrarFacturas()
        {
            return new DatosFactura().mostrarFacturas();
        }

        public static DataTable mostrarDetalle(int idFactura)
        {
            return new DatosFactura().mostrarDetalle(idFactura);
        }
    }
    
}
