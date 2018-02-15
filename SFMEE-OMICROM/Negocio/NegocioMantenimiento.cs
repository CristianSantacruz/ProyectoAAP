using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class NegocioMantenimiento
    {
        public static string insertarMantenimiento(int idCliente, string fechaMantenimiento, string horaMantenimiento,
                                  string estadoMantenimiento, string observacionMantenimiento, float precioMantenimiento)
        {
            DatosMantenimiento mantenimiento = new DatosMantenimiento();
            mantenimiento.IdCliente = idCliente;
            mantenimiento.FechaMantenimiento = fechaMantenimiento;
            mantenimiento.HoraMantenimiento = horaMantenimiento;
            mantenimiento.EstadoMantenimiento = estadoMantenimiento;
            mantenimiento.ObservacionMantenimiento = observacionMantenimiento;
            mantenimiento.PrecioMantenimiento = precioMantenimiento;

            return mantenimiento.insertarMantenimiento(mantenimiento);
        }

        public static DataTable mostrarMantenimientos()
        {
            return new DatosMantenimiento().mostrarMantenimientos();
        }

        public static DataTable consultarMantenimientoTabla(int idMantenimiento)
        {
            DatosMantenimiento mantenimiento = new DatosMantenimiento();
            mantenimiento.IdMantenimiento = idMantenimiento;

            return mantenimiento.consultarMantenimientoTabla(mantenimiento);
        }

        public static string buscarMantenimiento(int idMantenimiento)
        {
            DatosMantenimiento mantenimiento = new DatosMantenimiento();
            mantenimiento.IdMantenimiento = idMantenimiento;

            return mantenimiento.buscarMantenimiento(mantenimiento);
        }

        public static string actualizarMantenimiento(int idMantenimiento, string estadoMantenimiento, string observacionMantenimiento, float precioMantenimiento)
        {
            DatosMantenimiento mantenimiento = new DatosMantenimiento();
            mantenimiento.IdMantenimiento=idMantenimiento;
            mantenimiento.EstadoMantenimiento = estadoMantenimiento;
            mantenimiento.ObservacionMantenimiento = observacionMantenimiento;
            mantenimiento.PrecioMantenimiento = precioMantenimiento;

            return mantenimiento.actualizarMantenimiento(mantenimiento);
        }

        public static DataTable contarRegistros()
        {
            return new DatosMantenimiento().contarRegistros();
        }

    }
}
