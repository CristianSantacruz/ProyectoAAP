using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosMantenimiento
    {
        private int _idMantenimiento;
        private int _idCliente;
        private string _fechaMantenimiento;
        private string _horaMantenimiento;
        private string _estadoMantenimiento;
        private string _observacionMantenimiento;
        private float _precioMantenimiento;

        public DatosMantenimiento()
        {

        }

        public DatosMantenimiento(int idMantenimiento, int idCliente, string fechaMantenimiento, string horaMantenimiento, 
                                  string estadoMantenimiento, string observacionMantenimiento, float precioMantenimiento)
        {
            this._idMantenimiento = idMantenimiento;
            this._idCliente = idCliente;
            this._fechaMantenimiento = fechaMantenimiento;
            this._horaMantenimiento = horaMantenimiento;
            this._estadoMantenimiento = estadoMantenimiento;
            this._observacionMantenimiento = observacionMantenimiento;
            this._precioMantenimiento = precioMantenimiento;
        }

        public int IdMantenimiento { get => _idMantenimiento; set => _idMantenimiento = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public string FechaMantenimiento { get => _fechaMantenimiento; set => _fechaMantenimiento = value; }
        public string HoraMantenimiento { get => _horaMantenimiento; set => _horaMantenimiento = value; }
        public string EstadoMantenimiento { get => _estadoMantenimiento; set => _estadoMantenimiento = value; }
        public string ObservacionMantenimiento { get => _observacionMantenimiento; set => _observacionMantenimiento = value; }
        public float PrecioMantenimiento { get => _precioMantenimiento; set => _precioMantenimiento = value; }

        public string insertarMantenimiento(DatosMantenimiento Mantenimiento)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertarDatosMantenimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                //Crear parámetro @IDCLIENTE
                SqlParameter parametroIdCliente = new SqlParameter();
                parametroIdCliente.ParameterName = "@IDCLIENTE";
                parametroIdCliente.SqlDbType = SqlDbType.Int;
                parametroIdCliente.Value = Mantenimiento._idCliente;
                SqlCmd.Parameters.Add(parametroIdCliente);

                //Crear parámetro @FECHAMANTENIMIENTO
                SqlParameter parametroFechaMantenimiento = new SqlParameter();
                parametroFechaMantenimiento.ParameterName = "@FECHAMANTENIMIENTO";
                parametroFechaMantenimiento.SqlDbType = SqlDbType.VarChar;
                parametroFechaMantenimiento.Size = 10;
                parametroFechaMantenimiento.Value = Mantenimiento._fechaMantenimiento;
                SqlCmd.Parameters.Add(parametroFechaMantenimiento);

                //Crear parámetro @HORAMANTENIMIENTO
                SqlParameter parametroHoraMantenimiento = new SqlParameter();
                parametroHoraMantenimiento.ParameterName = "@HORAMANTENIMIENTO";
                parametroHoraMantenimiento.SqlDbType = SqlDbType.VarChar;
                parametroHoraMantenimiento.Size = 8;
                parametroHoraMantenimiento.Value = Mantenimiento._horaMantenimiento;
                SqlCmd.Parameters.Add(parametroHoraMantenimiento);

                //Crear parámetro @ESTADOMANTENIMIENTO
                SqlParameter parametroEstadoMantenimiento = new SqlParameter();
                parametroEstadoMantenimiento.ParameterName = "@ESTADOMANTENIMIENTO";
                parametroEstadoMantenimiento.SqlDbType = SqlDbType.VarChar;
                parametroEstadoMantenimiento.Size = 15;
                parametroEstadoMantenimiento.Value = Mantenimiento._estadoMantenimiento;
                SqlCmd.Parameters.Add(parametroEstadoMantenimiento);

                //Crear parámetro @OBSERVACIONMANTENIMIENTO
                SqlParameter parametroObservacionMantenimiento = new SqlParameter();
                parametroObservacionMantenimiento.ParameterName = "@OBSERVACIONMANTENIMIENTO";
                parametroObservacionMantenimiento.SqlDbType = SqlDbType.VarChar;
                parametroObservacionMantenimiento.Size = 200;
                parametroObservacionMantenimiento.Value = Mantenimiento._observacionMantenimiento;
                SqlCmd.Parameters.Add(parametroObservacionMantenimiento);

                //Crear parámetro @PRECIOMANTENIMIENTO
                SqlParameter parametroPrecioMantenimiento = new SqlParameter();
                parametroPrecioMantenimiento.ParameterName = "@PRECIOMANTENIMIENTO";
                parametroPrecioMantenimiento.SqlDbType = SqlDbType.Float;
                parametroPrecioMantenimiento.Size = 5;
                parametroPrecioMantenimiento.Value = Mantenimiento._precioMantenimiento;
                SqlCmd.Parameters.Add(parametroPrecioMantenimiento);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "Registro ingresado exitosamente" : "No se ingresó el registro";
            }

            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }

            return respuesta;
        }

        public DataTable mostrarMantenimientos()
        {
            DataTable tablaResultado = new DataTable("MANTENIMIENTO");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarMantenimientos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(tablaResultado);
            }

            catch (Exception ex)
            {
                tablaResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }

            return tablaResultado;
        }

        public DataTable consultarMantenimientoTabla(DatosMantenimiento Mantenimiento)
        {
            DataTable tablaResultado = new DataTable("MANTENIMIENTO");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscarMantenimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @IDMANTENIMIENTO
                SqlParameter parametroIdMantenimiento = new SqlParameter();
                parametroIdMantenimiento.ParameterName = "@IDMANTENIMIENTO";
                parametroIdMantenimiento.SqlDbType = SqlDbType.Int;
                parametroIdMantenimiento.Value = Mantenimiento._idMantenimiento;
                SqlCmd.Parameters.Add(parametroIdMantenimiento);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(tablaResultado);
            }

            catch (Exception ex)
            {
                tablaResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }

            return tablaResultado;
        }

        public string buscarMantenimiento(DatosMantenimiento Mantenimiento)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscarMantenimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @IDMANTENIMIENTO
                SqlParameter parametroIdMantenimiento = new SqlParameter();
                parametroIdMantenimiento.ParameterName = "@IDMANTENIMIENTO";
                parametroIdMantenimiento.SqlDbType = SqlDbType.Int;
                parametroIdMantenimiento.Value = Mantenimiento._idMantenimiento;
                SqlCmd.Parameters.Add(parametroIdMantenimiento);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "" : "No se encontró el registro";
            }

            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }

            return respuesta;
        }

        public string actualizarMantenimiento(DatosMantenimiento Mantenimiento)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "actualizarDatosMantenimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @IDMANTENIMIENTO
                SqlParameter parametroIdMantenimiento = new SqlParameter();
                parametroIdMantenimiento.ParameterName = "@IDMANTENIMIENTO";
                parametroIdMantenimiento.SqlDbType = SqlDbType.Int;
                parametroIdMantenimiento.Value = Mantenimiento._idMantenimiento;
                SqlCmd.Parameters.Add(parametroIdMantenimiento);

                //Crear parámetro @ESTADOMANTENIMIENTO
                SqlParameter parametroEstadoMantenimiento = new SqlParameter();
                parametroEstadoMantenimiento.ParameterName = "@ESTADOMANTENIMIENTO";
                parametroEstadoMantenimiento.SqlDbType = SqlDbType.VarChar;
                parametroEstadoMantenimiento.Size = 15;
                parametroEstadoMantenimiento.Value = Mantenimiento._estadoMantenimiento;
                SqlCmd.Parameters.Add(parametroEstadoMantenimiento);

                //Crear parámetro @OBSERVACIONMANTENIMIENTO
                SqlParameter parametroObservacionMantenimiento = new SqlParameter();
                parametroObservacionMantenimiento.ParameterName = "@OBSERVACIONMANTENIMIENTO";
                parametroObservacionMantenimiento.SqlDbType = SqlDbType.VarChar;
                parametroObservacionMantenimiento.Size = 200;
                parametroObservacionMantenimiento.Value = Mantenimiento._observacionMantenimiento;
                SqlCmd.Parameters.Add(parametroObservacionMantenimiento);

                //Crear parámetro @PRECIOMANTENIMIENTO
                SqlParameter parametroPrecioMantenimiento = new SqlParameter();
                parametroPrecioMantenimiento.ParameterName = "@PRECIOMANTENIMIENTO";
                parametroPrecioMantenimiento.SqlDbType = SqlDbType.Float;
                parametroPrecioMantenimiento.Size = 5;
                parametroPrecioMantenimiento.Value = Mantenimiento._precioMantenimiento;
                SqlCmd.Parameters.Add(parametroPrecioMantenimiento);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "Registro actualizado exitosamente" : "No se actualizó el registro";
            }

            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }

            return respuesta;
        }

        public DataTable contarRegistros()
        {
            DataTable tablaResultado = new DataTable("MANTENIMIENTO");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "contarRegistros";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(tablaResultado);
            }

            catch (Exception ex)
            {
                tablaResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }

            return tablaResultado;
        }

    }
}
