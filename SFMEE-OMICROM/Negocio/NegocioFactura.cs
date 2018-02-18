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

        public static DataTable numeroFactura()
        {
            return new DatosFactura().numeroFactura();
        }

        public static string insertarFactura(int idCliente, string fechaFactura, string vendedor, string tipoPago, float subtotal, float descuento, float iva,
                                             float total, string estadoFactura)
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
            
            return factura.insertarDatosFactura(factura);
        }

        public static DataTable consultarFacturaTabla(int idFactura)
        {
            DatosFactura factura = new DatosFactura();
            factura.IdFactura = idFactura;

            return factura.buscarFacturaTabla(factura);
        }

        public static string buscarFactura(int numeroFactura)
        {
            DatosFactura factura = new DatosFactura();
            factura.IdFactura = numeroFactura;

            return factura.buscarFactura(factura);
        }

        public static string anularFactura(int numeroFactura)
        {
            DatosFactura factura = new DatosFactura();
            factura.IdFactura = numeroFactura;

            return factura.anularFactura(factura);
        }

        public static DataTable mostrarFacturas()
        {
            return new DatosFactura().mostrarFacturas();
        }

        public static DataTable mostrarDetalle(int idFactura)
        {
            DatosFactura factura = new DatosFactura();
            factura.IdFactura = idFactura;
            return factura.mostrarDetalle(factura);
        }
    }
    
}
