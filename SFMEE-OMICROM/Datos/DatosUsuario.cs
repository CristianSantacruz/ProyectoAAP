using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosUsuario
    {
        private int _idUsuario;
        private string _nombreUsuario;
        private string _loginUsuario;
        private string _passwordUsuario;
        private string _cargoUsuario;

        public DatosUsuario()
        {

        }

        public DatosUsuario(int idUsuario, string nombreUsuario, string loginUsuario, string passwordUsuario, string cargoUsuario)
        {
            this._idUsuario = idUsuario;
            this._nombreUsuario = nombreUsuario;
            this._loginUsuario = loginUsuario;
            this._passwordUsuario = passwordUsuario;
            this._cargoUsuario = cargoUsuario;
        }

        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string LoginUsuario { get => _loginUsuario; set => _loginUsuario = value; }
        public string PasswordUsuario { get => _passwordUsuario; set => _passwordUsuario = value; }
        public string CargoUsuario { get => _cargoUsuario; set => _cargoUsuario = value; }

        public string insertarUsuario(DatosUsuario Usuario)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertarDatosUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                //Crear parámetro @NOMBREUSUARIO
                SqlParameter parametroNombreUsuario = new SqlParameter();
                parametroNombreUsuario.ParameterName = "@NOMBREUSUARIO";
                parametroNombreUsuario.SqlDbType = SqlDbType.VarChar;
                parametroNombreUsuario.Size = 50;
                parametroNombreUsuario.Value = Usuario._nombreUsuario;
                SqlCmd.Parameters.Add(parametroNombreUsuario);

                //Crear parámetro @LOGINUSUARIO
                SqlParameter parametroLoginUsuario = new SqlParameter();
                parametroLoginUsuario.ParameterName = "@LOGINUSUARIO";
                parametroLoginUsuario.SqlDbType = SqlDbType.VarChar;
                parametroLoginUsuario.Size = 20;
                parametroLoginUsuario.Value = Usuario._loginUsuario;
                SqlCmd.Parameters.Add(parametroLoginUsuario);

                //Crear parámetro @PASSWORDUSUARIO
                SqlParameter parametroPasswordUsuario = new SqlParameter();
                parametroPasswordUsuario.ParameterName = "@PASSWORDUSUARIO";
                parametroPasswordUsuario.SqlDbType = SqlDbType.VarChar;
                parametroPasswordUsuario.Size = 10;
                parametroPasswordUsuario.Value = Usuario._passwordUsuario;
                SqlCmd.Parameters.Add(parametroPasswordUsuario);

                //Crear parámetro @CARGOUSUARIO
                SqlParameter parametroCargoUsuario = new SqlParameter();
                parametroCargoUsuario.ParameterName = "@CARGOUSUARIO";
                parametroCargoUsuario.SqlDbType = SqlDbType.VarChar;
                parametroCargoUsuario.Size = 15;
                parametroCargoUsuario.Value = Usuario._cargoUsuario;
                SqlCmd.Parameters.Add(parametroCargoUsuario);

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

        public DataTable mostrarUsuarios()
        {
            DataTable tablaResultado = new DataTable("USUARIO");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarUsuarios";
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

        public DataTable consultarUsuarioTabla(DatosUsuario Usuario)
        {
            DataTable tablaResultado = new DataTable("USUARIO");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscarUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @NOMBREUSUARIO
                SqlParameter parametroNombreUsuario = new SqlParameter();
                parametroNombreUsuario.ParameterName = "@NOMBREUSUARIO";
                parametroNombreUsuario.SqlDbType = SqlDbType.VarChar;
                parametroNombreUsuario.Size = 50;
                parametroNombreUsuario.Value = Usuario._nombreUsuario;
                SqlCmd.Parameters.Add(parametroNombreUsuario);

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

        public string buscarUsuario(DatosUsuario Usuario)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscarUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @NOMBREUSUARIO
                SqlParameter parametroNombreUsuario = new SqlParameter();
                parametroNombreUsuario.ParameterName = "@NOMBREUSUARIO";
                parametroNombreUsuario.SqlDbType = SqlDbType.VarChar;
                parametroNombreUsuario.Size = 50;
                parametroNombreUsuario.Value = Usuario._nombreUsuario;
                SqlCmd.Parameters.Add(parametroNombreUsuario);

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

        public string actualizarUsuario(DatosUsuario Usuario)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "actualizarDatosUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @NOMBREUSUARIO
                SqlParameter parametroNombreUsuario = new SqlParameter();
                parametroNombreUsuario.ParameterName = "@NOMBREUSUARIO";
                parametroNombreUsuario.SqlDbType = SqlDbType.VarChar;
                parametroNombreUsuario.Size = 50;
                parametroNombreUsuario.Value = Usuario._nombreUsuario;
                SqlCmd.Parameters.Add(parametroNombreUsuario);

                //Crear parámetro @PASSWORDUSUARIO
                SqlParameter parametroPasswordUsuario = new SqlParameter();
                parametroPasswordUsuario.ParameterName = "@PASSWORDUSUARIO";
                parametroPasswordUsuario.SqlDbType = SqlDbType.VarChar;
                parametroPasswordUsuario.Size = 10;
                parametroPasswordUsuario.Value = Usuario._passwordUsuario;
                SqlCmd.Parameters.Add(parametroPasswordUsuario);

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

        public string eliminarUsuario(DatosUsuario Usuario)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminarUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @NOMBREUSUARIO
                SqlParameter parametroNombreUsuario = new SqlParameter();
                parametroNombreUsuario.ParameterName = "@NOMBREUSUARIO";
                parametroNombreUsuario.SqlDbType = SqlDbType.VarChar;
                parametroNombreUsuario.Size = 50;
                parametroNombreUsuario.Value = Usuario._nombreUsuario;
                SqlCmd.Parameters.Add(parametroNombreUsuario);

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
