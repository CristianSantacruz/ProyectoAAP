using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class NegocioParametro
    {
        public static string insertarParametro(string nombreParametro, int valorParametro)
        {
            DatosParametro parametro = new DatosParametro();
            parametro.NombreParametro = nombreParametro;
            parametro.ValorParametro = valorParametro;

            return parametro.insertarParametro(parametro);
        }

        public static DataTable mostrarParametros()
        {
            return new DatosParametro().mostrarParametros();
        }

        public static DataTable consultarParametroTabla(string nombreParametro)
        {
            DatosParametro parametro = new DatosParametro();
            parametro.NombreParametro = nombreParametro;

            return parametro.consultarParametroTabla(parametro);
        }

        public static string buscarParametro(string nombreParametro)
        {
            DatosParametro parametro = new DatosParametro();
            parametro.NombreParametro = nombreParametro;

            return parametro.buscarparametro(parametro);
        }

        public static string actualizarParametro(string nombreParametro, int valorParametro)
        {
            DatosParametro parametro = new DatosParametro();
            parametro.NombreParametro = nombreParametro;
            parametro.ValorParametro = valorParametro;

            return parametro.actualizarParametro(parametro);
        }

        public static string eliminarParametro(string nombreParametro)
        {
            DatosParametro parametro = new DatosParametro();
            parametro.NombreParametro = nombreParametro;

            return parametro.eliminarParametro(parametro);
        }
    }
}
