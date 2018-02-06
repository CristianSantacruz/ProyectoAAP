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

        public static bool VerificarNumeroCedula(string ciCliente)
        {
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            
            int entero;
            int total = 0;

            if(int.TryParse(ciCliente, out entero) && ciCliente.Length==10)
            {
                int numeroProvincia = Convert.ToInt32(string.Concat(ciCliente[0], ciCliente[1], string.Empty));
                int tercerDigito = Convert.ToInt32(string.Concat(ciCliente[2], string.Empty));
                if(numeroProvincia > 0 && numeroProvincia <= 24 && tercerDigito < 6)
                {
                    int digitoVerificadorRecibido = Convert.ToInt32(ciCliente[9] + string.Empty);
                    for (int i = 0; i < coeficientes.Length; i++)
                    {
                        int valor = Convert.ToInt32(coeficientes[i] + string.Empty) * Convert.ToInt32(ciCliente[i] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    int digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ? 10 - (total % 10) : (total % 10) : total;
                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }
                return false;
            }
            return false;
        }

        public static bool verificarNumeroRucNatural(string rucCliente)
        {
            long entero;
            if(long.TryParse(rucCliente, out entero) && rucCliente.Length==13)
            {
                int numeroProvincia = Convert.ToInt32(string.Concat(rucCliente[0], rucCliente[1], string.Empty));
                int tercerDigito = Convert.ToInt32(string.Concat(rucCliente[2], string.Empty));
                if (numeroProvincia > 0 && numeroProvincia <= 24 && tercerDigito < 6)
                {
                    return rucCliente.Substring(10, 3) == "001" && VerificarNumeroCedula(rucCliente.Substring(0, 10));
                }
                return false;
            }
            return false;
        }

        public static bool VerificarNumeroRucJuridico(string rucCliente)
        {
            int[] coeficientes = { 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            long entero;
            int total = 0;

            if (long.TryParse(rucCliente, out entero) && rucCliente.Length == 13)
            {
                int numeroProvincia = Convert.ToInt32(string.Concat(rucCliente[0], rucCliente[1], string.Empty));
                int tercerDigito = Convert.ToInt32(string.Concat(rucCliente[2], string.Empty));
                if (numeroProvincia > 0 && numeroProvincia <= 24 && tercerDigito == 9 && rucCliente.Substring(10, 3) == "001")
                {
                    int digitoVerificadorRecibido = Convert.ToInt32(rucCliente[9] + string.Empty);
                    for (int i = 0; i < coeficientes.Length; i++)
                    {
                        total = total + Convert.ToInt32(coeficientes[i] + string.Empty) * Convert.ToInt32(rucCliente[i] + string.Empty);
                    }
                    int digitoVerificadorObtenido = (total % 11) == 0 ? 0 : 11 - (total % 11);
                    return digitoVerificadorRecibido == digitoVerificadorObtenido;
                }
                return false;
            }
            return false;
        }

        public static bool VerificarNumeroRucPublico(string rucCliente)
        {
            int[] coeficientes = { 3, 2, 7, 6, 5, 4, 3, 2 };
            long entero;
            int total = 0;

            if (long.TryParse(rucCliente, out entero) && rucCliente.Length == 13)
            {
                int numeroProvincia = Convert.ToInt32(string.Concat(rucCliente[0], rucCliente[1], string.Empty));
                int tercerDigito = Convert.ToInt32(string.Concat(rucCliente[2], string.Empty));
                if (numeroProvincia > 0 && numeroProvincia <= 24 && tercerDigito == 6 && rucCliente.Substring(9, 4) == "0001")
                {
                    int digitoVerificadorRecibido = Convert.ToInt32(rucCliente[8] + string.Empty);
                    for (int i = 0; i < coeficientes.Length; i++)
                    {
                        total = total + Convert.ToInt32(coeficientes[i] + string.Empty) * Convert.ToInt32(rucCliente[i] + string.Empty);
                    }
                    int digitoVerificadorObtenido = 11 - (total % 11);
                    return digitoVerificadorRecibido == digitoVerificadorObtenido;
                }
                return false;
            }
            return false;
        }

        public static bool verificarNumeroFijo(string fijoCliente)
        {
            int primerDigito = Convert.ToInt32(string.Concat(fijoCliente[0]));
            int digitoProvincia = Convert.ToInt32(string.Concat(fijoCliente[1]));
            if(primerDigito == 0 && digitoProvincia > 1 && digitoProvincia <8)
            {
                return true;
            }
            return false;
        }

        public static bool verificarNumeroCelular(string celularCliente)
        {
            int primerDigito = Convert.ToInt32(string.Concat(celularCliente[0]));
            int digitoCelular = Convert.ToInt32(string.Concat(celularCliente[1]));
            if (primerDigito == 0 && digitoCelular == 9)
            {
                return true;
            }
            return false;
        }
    }
}
