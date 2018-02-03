using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class NegocioCliente
    {
        public static string insertarCliente(string ciCliente, string nombreCliente, string direccionCliente, string telefonoFijoCliente, string telefonoMovilCliente)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.CiCliente = ciCliente;
            cliente.NombreCliente = nombreCliente;
            cliente.DireccionCliente = direccionCliente;
            cliente.TelefonoFijoCliente = telefonoFijoCliente;
            cliente.TelefonoMovilCliente = telefonoMovilCliente;

            return cliente.insertarCliente(cliente);
        }

        public static DataTable mostrarClientes()
        {
            return new DatosCliente().mostrarClientes() ;
        }

        public static DataTable consultarClienteTabla(string ciCliente)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.CiCliente = ciCliente;

            return cliente.consultarClienteTabla(cliente);
        }

        public static string buscarCliente(string ciCliente)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.CiCliente = ciCliente;

            return cliente.buscarCliente(cliente);
        }

        public static string actualizarCliente(string ciCliente, string direccionCliente, string telefonoFijoCliente, string telefonoMovilCliente)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.CiCliente = ciCliente;
            cliente.DireccionCliente = direccionCliente;
            cliente.TelefonoFijoCliente = telefonoFijoCliente;
            cliente.TelefonoMovilCliente = telefonoMovilCliente;

            return cliente.actualizarCliente(cliente);
        }

        public static string eliminarCliente(string ciCliente)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.CiCliente = ciCliente;

            return cliente.eliminarCliente(cliente);
        }
    }
}
