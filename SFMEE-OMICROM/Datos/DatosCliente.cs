using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosCliente
    {
        private int _idCliente;
        private string _ciCliente;
        private string _nombreCliente;
        private string _direccionCliente;
        private string _telefonoFijoCliente;
        private string _telefonoMovilCliente;

        public DatosCliente()
        {

        }

        public DatosCliente (int idCliente, string ciCliente, string nombreCliente, string direccionCliente, string telefonoFijoCliente, string telefonoMovilCliente)
        {
            this.IdCliente = idCliente;
            this.CiCliente = ciCliente;
            this.NombreCliente = nombreCliente;
            this.DireccionCliente = direccionCliente;
            this.TelefonoFijoCliente = telefonoFijoCliente;
            this.TelefonoMovilCliente = telefonoMovilCliente;
        }

        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public string CiCliente { get => _ciCliente; set => _ciCliente = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string DireccionCliente { get => _direccionCliente; set => _direccionCliente = value; }
        public string TelefonoFijoCliente { get => _telefonoFijoCliente; set => _telefonoFijoCliente = value; }
        public string TelefonoMovilCliente { get => _telefonoMovilCliente; set => _telefonoMovilCliente = value; }

        public string insertarCliente(DatosCliente Cliente)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertarDatosCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                ////Crear parámetro @IDCLIENTE
                //SqlParameter parametroIdCliente = new SqlParameter();
                //parametroIdCliente.ParameterName = "@IDCLIENTE";
                //parametroIdCliente.SqlDbType = SqlDbType.Int;
                //parametroIdCliente.Direction = ParameterDirection.Output;
                //SqlCmd.Parameters.Add(parametroIdCliente);

                //Crear parámetro @CICLIENTE
                SqlParameter parametroCiCliente = new SqlParameter();
                parametroCiCliente.ParameterName = "@CICLIENTE";
                parametroCiCliente.SqlDbType = SqlDbType.VarChar;
                parametroCiCliente.Size = 13;
                parametroCiCliente.Value = Cliente.CiCliente;
                SqlCmd.Parameters.Add(parametroCiCliente);

                //Crear parámetro @NOMBRECLIENTE
                SqlParameter parametroNombreCliente = new SqlParameter();
                parametroNombreCliente.ParameterName = "@NOMBRECLIENTE";
                parametroNombreCliente.SqlDbType = SqlDbType.VarChar;
                parametroNombreCliente.Size = 50;
                parametroNombreCliente.Value = Cliente.NombreCliente;
                SqlCmd.Parameters.Add(parametroNombreCliente);

                //Crear parámetro @DIRECCIONCLIENTE
                SqlParameter parametroDireccionCliente = new SqlParameter();
                parametroDireccionCliente.ParameterName = "@DIRECCIONCLIENTE";
                parametroDireccionCliente.SqlDbType = SqlDbType.VarChar;
                parametroDireccionCliente.Size = 200;
                parametroDireccionCliente.Value = Cliente.DireccionCliente;
                SqlCmd.Parameters.Add(parametroDireccionCliente);

                //Crear parámetro @TELEFONIFIJOCLIENTE
                SqlParameter parametroTelefonoFijoCliente = new SqlParameter();
                parametroTelefonoFijoCliente.ParameterName = "@TELEFONOFIJOCLIENTE";
                parametroTelefonoFijoCliente.SqlDbType = SqlDbType.VarChar;
                parametroTelefonoFijoCliente.Size = 9;
                parametroTelefonoFijoCliente.Value = Cliente.TelefonoFijoCliente;
                SqlCmd.Parameters.Add(parametroTelefonoFijoCliente);

                //Crear parámetro @TELEFONOMOVILCLIENTE
                SqlParameter parametroTelefonoMovilCliente = new SqlParameter();
                parametroTelefonoMovilCliente.ParameterName = "@TELEFONOMOVILCLIENTE";
                parametroTelefonoMovilCliente.SqlDbType = SqlDbType.VarChar;
                parametroTelefonoMovilCliente.Size = 10;
                parametroTelefonoMovilCliente.Value = Cliente.TelefonoMovilCliente;
                SqlCmd.Parameters.Add(parametroTelefonoMovilCliente);

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

        public DataTable mostrarClientes()
        {
            DataTable tablaResultado = new DataTable("CLIENTE");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarClientes";
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

        public DataTable consultarClienteTabla(DatosCliente Cliente)
        {
            DataTable tablaResultado = new DataTable("CLIENTE");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscarClientesCedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @CICLIENTE
                SqlParameter parametroCiCliente = new SqlParameter();
                parametroCiCliente.ParameterName = "@CICLIENTE";
                parametroCiCliente.SqlDbType = SqlDbType.VarChar;
                parametroCiCliente.Size = 13;
                parametroCiCliente.Value = Cliente.CiCliente;
                SqlCmd.Parameters.Add(parametroCiCliente);

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

        public string buscarCliente(DatosCliente Cliente)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscarClienteCedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @CICLIENTE
                SqlParameter parametroCiCliente = new SqlParameter();
                parametroCiCliente.ParameterName = "@CICLIENTE";
                parametroCiCliente.SqlDbType = SqlDbType.VarChar;
                parametroCiCliente.Size = 13;
                parametroCiCliente.Value = Cliente.CiCliente;
                SqlCmd.Parameters.Add(parametroCiCliente);

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

        public string actualizarCliente(DatosCliente Cliente)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "actualizarDatosCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @CICLIENTE
                SqlParameter parametroCiCliente = new SqlParameter();
                parametroCiCliente.ParameterName = "@CICLIENTE";
                parametroCiCliente.SqlDbType = SqlDbType.VarChar;
                parametroCiCliente.Size = 13;
                parametroCiCliente.Value = Cliente.CiCliente;
                SqlCmd.Parameters.Add(parametroCiCliente);

                //Crear parámetro @DIRECCIONCLIENTE
                SqlParameter parametroDireccionCliente = new SqlParameter();
                parametroDireccionCliente.ParameterName = "@DIRECCIONCLIENTE";
                parametroDireccionCliente.SqlDbType = SqlDbType.VarChar;
                parametroDireccionCliente.Size = 200;
                parametroDireccionCliente.Value = Cliente.DireccionCliente;
                SqlCmd.Parameters.Add(parametroDireccionCliente);

                //Crear parámetro @TELEFONIFIJOCLIENTE
                SqlParameter parametroTelefonoFijoCliente = new SqlParameter();
                parametroTelefonoFijoCliente.ParameterName = "@TELEFONOFIJOCLIENTE";
                parametroTelefonoFijoCliente.SqlDbType = SqlDbType.VarChar;
                parametroTelefonoFijoCliente.Size = 9;
                parametroTelefonoFijoCliente.Value = Cliente.TelefonoFijoCliente;
                SqlCmd.Parameters.Add(parametroTelefonoFijoCliente);

                //Crear parámetro @TELEFONOMOVILCLIENTE
                SqlParameter parametroTelefonoMovilCliente = new SqlParameter();
                parametroTelefonoMovilCliente.ParameterName = "@TELEFONOMOVILCLIENTE";
                parametroTelefonoMovilCliente.SqlDbType = SqlDbType.VarChar;
                parametroTelefonoMovilCliente.Size = 10;
                parametroTelefonoMovilCliente.Value = Cliente.TelefonoMovilCliente;
                SqlCmd.Parameters.Add(parametroTelefonoMovilCliente);

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

        public string eliminarCliente(DatosCliente Cliente)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminarDatosCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @CICLIENTE
                SqlParameter parametroCiCliente = new SqlParameter();
                parametroCiCliente.ParameterName = "@CICLIENTE";
                parametroCiCliente.SqlDbType = SqlDbType.VarChar;
                parametroCiCliente.Size = 13;
                parametroCiCliente.Value = Cliente.CiCliente;
                SqlCmd.Parameters.Add(parametroCiCliente);

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
