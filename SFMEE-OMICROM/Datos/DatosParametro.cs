using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosParametro
    {
        private int _idParametro;
        private string _nombreParametro;
        private int _valorParametro;

        public DatosParametro()
        {

        }

        public DatosParametro(int idParametro, string nombreParametro, int valorParametro)
        {
            this._idParametro = idParametro;
            this._nombreParametro = nombreParametro;
            this._valorParametro = valorParametro;
        }

        public int IdParametro { get => _idParametro; set => _idParametro = value; }
        public string NombreParametro { get => _nombreParametro; set => _nombreParametro = value; }
        public int ValorParametro { get => _valorParametro; set => _valorParametro = value; }

        public string insertarParametro(DatosParametro Parametro)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertarDatosParametro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @NOMBREPARAMETRO
                SqlParameter parametroNombreParametro = new SqlParameter();
                parametroNombreParametro.ParameterName = "@NOMBREPARAMETRO";
                parametroNombreParametro.SqlDbType = SqlDbType.VarChar;
                parametroNombreParametro.Size = 15;
                parametroNombreParametro.Value = Parametro._nombreParametro;
                SqlCmd.Parameters.Add(parametroNombreParametro);

                //Crear parámetro @VALORPARAMETRO
                SqlParameter parametroValorParametro = new SqlParameter();
                parametroValorParametro.ParameterName = "@VALOR";
                parametroValorParametro.SqlDbType = SqlDbType.Int;
                parametroValorParametro.Value = Parametro._valorParametro;
                SqlCmd.Parameters.Add(parametroValorParametro);

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

        public DataTable mostrarParametros()
        {
            DataTable tablaResultado = new DataTable("PARAMETRO");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarParametros";
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

        public DataTable consultarParametroTabla(DatosParametro Parametro)
        {
            DataTable tablaResultado = new DataTable("PARAMETRO");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscarParametro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @NOMBREPARAMETRO
                SqlParameter parametroNombreParametro = new SqlParameter();
                parametroNombreParametro.ParameterName = "@NOMBREPARAMETRO";
                parametroNombreParametro.SqlDbType = SqlDbType.VarChar;
                parametroNombreParametro.Size = 15;
                parametroNombreParametro.Value = Parametro._nombreParametro;
                SqlCmd.Parameters.Add(parametroNombreParametro);

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

        public string buscarparametro(DatosParametro Parametro)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscarParametro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @NOMBREPARAMETRO
                SqlParameter parametroNombreParametro = new SqlParameter();
                parametroNombreParametro.ParameterName = "@NOMBREPARAMETRO";
                parametroNombreParametro.SqlDbType = SqlDbType.VarChar;
                parametroNombreParametro.Size = 15;
                parametroNombreParametro.Value = Parametro._nombreParametro;
                SqlCmd.Parameters.Add(parametroNombreParametro);

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

        public string actualizarParametro(DatosParametro Parametro)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "actualizarDatosParametro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @NOMBREPARAMETRO
                SqlParameter parametroNombreParametro = new SqlParameter();
                parametroNombreParametro.ParameterName = "@NOMBREPARAMETRO";
                parametroNombreParametro.SqlDbType = SqlDbType.VarChar;
                parametroNombreParametro.Size = 15;
                parametroNombreParametro.Value = Parametro._nombreParametro;
                SqlCmd.Parameters.Add(parametroNombreParametro);

                //Crear parámetro @VALORPARAMETRO
                SqlParameter parametroValorParametro = new SqlParameter();
                parametroValorParametro.ParameterName = "@VALOR";
                parametroValorParametro.SqlDbType = SqlDbType.Int;
                parametroValorParametro.Value = Parametro._valorParametro;
                SqlCmd.Parameters.Add(parametroValorParametro);

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

        public string eliminarParametro(DatosParametro Parametro)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminarParametro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @NOMBREPARAMETRO
                SqlParameter parametroNombreParametro = new SqlParameter();
                parametroNombreParametro.ParameterName = "@NOMBREPARAMETRO";
                parametroNombreParametro.SqlDbType = SqlDbType.VarChar;
                parametroNombreParametro.Size = 15;
                parametroNombreParametro.Value = Parametro._nombreParametro;
                SqlCmd.Parameters.Add(parametroNombreParametro);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "Registro eliminado exitosamente" : "No se eliminó el registro";
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
    }
}
