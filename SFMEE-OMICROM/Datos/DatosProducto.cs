using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosProducto
    {
        private int _idProducto;
        private string _codigoProducto;
        private string _nombreProducto;
        private string _descripcionProducto;
        private string _categoriaProducto;
        private int _cantidadProducto;
        private float _precioCompraProducto;
        private float _precioVentaProducto;
        private string _fechaRegistroPrecioCompra;
        private string _fechaRegistroPrecioVenta;

        public DatosProducto()
        {
            
        }

        public DatosProducto(int idProducto, string codigoProducto, string nombreProducto, string descripcionProducto, string categoriaProducto, int cantidadProducto,
                            float precioCompraProducto, float precioVentaProducto, string fechaRegistroPrecioCompra, string fechaRegistroPrecioVenta)
        {
            this._idProducto = idProducto;
            this._codigoProducto = codigoProducto;
            this._nombreProducto = nombreProducto;
            this._descripcionProducto = descripcionProducto;
            this._categoriaProducto = categoriaProducto;
            this._cantidadProducto = cantidadProducto;
            this._precioCompraProducto = precioCompraProducto;
            this._precioVentaProducto = precioVentaProducto;
            this._fechaRegistroPrecioCompra = fechaRegistroPrecioCompra;
            this._fechaRegistroPrecioVenta = fechaRegistroPrecioVenta;
        }
        
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string CodigoProducto { get => _codigoProducto; set => _codigoProducto = value; }
        public string DescripcionProducto { get => _descripcionProducto; set => _descripcionProducto = value; }
        public string CategoriaProducto { get => _categoriaProducto; set => _categoriaProducto = value; }
        public int CantidadProducto { get => _cantidadProducto; set => _cantidadProducto = value; }
        public float PrecioCompraProducto { get => _precioCompraProducto; set => _precioCompraProducto = value; }
        public float PrecioVentaProducto { get => _precioVentaProducto; set => _precioVentaProducto = value; }
        public string FechaRegistroPrecioCompra { get => _fechaRegistroPrecioCompra; set => _fechaRegistroPrecioCompra = value; }
        public string FechaRegistroPrecioVenta { get => _fechaRegistroPrecioVenta; set => _fechaRegistroPrecioVenta = value; }
        public string NombreProducto { get => _nombreProducto; set => _nombreProducto = value; }

        public string insertarProducto(DatosProducto Producto)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertarDatosProducto";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                //Crear parámetro @CODIGOPRODUCTO
                SqlParameter parametroCodigoProducto = new SqlParameter();
                parametroCodigoProducto.ParameterName = "@CODIGOPRODUCTO";
                parametroCodigoProducto.SqlDbType = SqlDbType.VarChar;
                parametroCodigoProducto.Size = 5;
                parametroCodigoProducto.Value = Producto._codigoProducto;
                SqlCmd.Parameters.Add(parametroCodigoProducto);

                //Crear parámetro @NOMBREPRODUCTO
                SqlParameter parametroNombreProducto = new SqlParameter();
                parametroNombreProducto.ParameterName = "@NOMBREPRODUCTO";
                parametroNombreProducto.SqlDbType = SqlDbType.VarChar;
                parametroNombreProducto.Size = 25;
                parametroNombreProducto.Value = Producto._nombreProducto;
                SqlCmd.Parameters.Add(parametroNombreProducto);

                //Crear parámetro @DESCRIPCIONPRODUCTO
                SqlParameter parametroDescripcionProducto = new SqlParameter();
                parametroDescripcionProducto.ParameterName = "@DESCRIPCIONPRODUCTO";
                parametroDescripcionProducto.SqlDbType = SqlDbType.VarChar;
                parametroDescripcionProducto.Size = 50;
                parametroDescripcionProducto.Value = Producto._descripcionProducto;
                SqlCmd.Parameters.Add(parametroDescripcionProducto);

                //Crear parámetro @CATEGORIAPRODUCTO
                SqlParameter parametroCategoriaProducto = new SqlParameter();
                parametroCategoriaProducto.ParameterName = "@CATEGORIAPRODUCTO";
                parametroCategoriaProducto.SqlDbType = SqlDbType.VarChar;
                parametroCategoriaProducto.Size = 25;
                parametroCategoriaProducto.Value = Producto._categoriaProducto;
                SqlCmd.Parameters.Add(parametroCategoriaProducto);

                //Crear parámetro @CANTIDADPRODUCTO
                SqlParameter parametroCantidadProducto = new SqlParameter();
                parametroCantidadProducto.ParameterName = "@CANTIDADPRODUCTO";
                parametroCantidadProducto.SqlDbType = SqlDbType.Int;
                parametroCantidadProducto.Value = Producto._cantidadProducto;
                SqlCmd.Parameters.Add(parametroCantidadProducto);

                //Crear parámetro @PRECIOCOMPRAPRODUCTO
                SqlParameter parametroPrecioCompraProducto = new SqlParameter();
                parametroPrecioCompraProducto.ParameterName = "@PRECIOCOMPRAPRODUCTO";
                parametroPrecioCompraProducto.SqlDbType = SqlDbType.Float;
                parametroPrecioCompraProducto.Size = 5;
                parametroPrecioCompraProducto.Value = Producto._precioCompraProducto;
                SqlCmd.Parameters.Add(parametroPrecioCompraProducto);

                //Crear parámetro @PRECIOVENTAPRODUCTO
                SqlParameter parametroPrecioVentaProducto = new SqlParameter();
                parametroPrecioVentaProducto.ParameterName = "@PRECIOVENTAPRODUCTO";
                parametroPrecioVentaProducto.SqlDbType = SqlDbType.Float;
                parametroPrecioVentaProducto.Size = 5;
                parametroPrecioVentaProducto.Value = Producto._precioVentaProducto;
                SqlCmd.Parameters.Add(parametroPrecioVentaProducto);

                //Crear parámetro @FECHAREGISTROPRECIOCOMPRA
                SqlParameter parametroFechaRegistroPrecioCompra = new SqlParameter();
                parametroFechaRegistroPrecioCompra.ParameterName = "@FECHAREGISTROPRECIOCOMPRA";
                parametroFechaRegistroPrecioCompra.SqlDbType = SqlDbType.VarChar;
                parametroFechaRegistroPrecioCompra.Size = 10;
                parametroFechaRegistroPrecioCompra.Value = Producto._fechaRegistroPrecioCompra;
                SqlCmd.Parameters.Add(parametroFechaRegistroPrecioCompra);

                //Crear parámetro @FECHAREGISTROPRECIOVENTA
                SqlParameter parametroFechaRegistroPrecioVenta = new SqlParameter();
                parametroFechaRegistroPrecioVenta.ParameterName = "@FECHAREGISTROPRECIOVENTA";
                parametroFechaRegistroPrecioVenta.SqlDbType = SqlDbType.VarChar;
                parametroFechaRegistroPrecioVenta.Size = 10;
                parametroFechaRegistroPrecioVenta.Value = Producto._fechaRegistroPrecioVenta;
                SqlCmd.Parameters.Add(parametroFechaRegistroPrecioVenta);

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

        public DataTable mostrarProductos()
        {
            DataTable tablaResultado = new DataTable("PRODUCTO");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarProductos";
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

        public DataTable consultarProductoTabla(DatosProducto Producto)
        {
            DataTable tablaResultado = new DataTable("PRODUCTO");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscarProductoCodigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @CODIGOPRODUCTO
                SqlParameter parametroCodigoProducto = new SqlParameter();
                parametroCodigoProducto.ParameterName = "@CODIGOPRODUCTO";
                parametroCodigoProducto.SqlDbType = SqlDbType.VarChar;
                parametroCodigoProducto.Size = 5;
                parametroCodigoProducto.Value = Producto._codigoProducto;
                SqlCmd.Parameters.Add(parametroCodigoProducto);

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

        public string buscarProducto(DatosProducto Producto)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscarProductoCodigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @CODIGOPRODUCTO
                SqlParameter parametroCodigoProducto = new SqlParameter();
                parametroCodigoProducto.ParameterName = "@CODIGOPRODUCTO";
                parametroCodigoProducto.SqlDbType = SqlDbType.VarChar;
                parametroCodigoProducto.Size = 5;
                parametroCodigoProducto.Value = Producto._codigoProducto;
                SqlCmd.Parameters.Add(parametroCodigoProducto);

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

        public string actualizarProducto(DatosProducto Producto)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "actualizarDatosProducto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @CODIGOPRODUCTO
                SqlParameter parametroCodigoProducto = new SqlParameter();
                parametroCodigoProducto.ParameterName = "@CODIGOPRODUCTO";
                parametroCodigoProducto.SqlDbType = SqlDbType.VarChar;
                parametroCodigoProducto.Size = 5;
                parametroCodigoProducto.Value = Producto._codigoProducto;
                SqlCmd.Parameters.Add(parametroCodigoProducto);

                //Crear parámetro @CANTIDADPRODUCTO
                SqlParameter parametroCantidadProducto = new SqlParameter();
                parametroCantidadProducto.ParameterName = "@CANTIDADPRODUCTO";
                parametroCantidadProducto.SqlDbType = SqlDbType.Int;
                parametroCantidadProducto.Value = Producto._cantidadProducto;
                SqlCmd.Parameters.Add(parametroCantidadProducto);

                //Crear parámetro @PRECIOCOMPRAPRODUCTO
                SqlParameter parametroPrecioCompraProducto = new SqlParameter();
                parametroPrecioCompraProducto.ParameterName = "@PRECIOCOMPRAPRODUCTO";
                parametroPrecioCompraProducto.SqlDbType = SqlDbType.Float;
                parametroPrecioCompraProducto.Size = 5;
                parametroPrecioCompraProducto.Value = Producto._precioCompraProducto;
                SqlCmd.Parameters.Add(parametroPrecioCompraProducto);

                //Crear parámetro @PRECIOVENTAPRODUCTO
                SqlParameter parametroPrecioVentaProducto = new SqlParameter();
                parametroPrecioVentaProducto.ParameterName = "@PRECIOVENTAPRODUCTO";
                parametroPrecioVentaProducto.SqlDbType = SqlDbType.Float;
                parametroPrecioVentaProducto.Size = 5;
                parametroPrecioVentaProducto.Value = Producto._precioVentaProducto;
                SqlCmd.Parameters.Add(parametroPrecioVentaProducto);

                //Crear parámetro @FECHAREGISTROPRECIOCOMPRA
                SqlParameter parametroFechaRegistroPrecioCompra = new SqlParameter();
                parametroFechaRegistroPrecioCompra.ParameterName = "@FECHAREGISTROPRECIOCOMPRA";
                parametroFechaRegistroPrecioCompra.SqlDbType = SqlDbType.VarChar;
                parametroFechaRegistroPrecioCompra.Size = 10;
                parametroFechaRegistroPrecioCompra.Value = Producto._fechaRegistroPrecioCompra;
                SqlCmd.Parameters.Add(parametroFechaRegistroPrecioCompra);

                //Crear parámetro @FECHAREGISTROPRECIOVENTA
                SqlParameter parametroFechaRegistroPrecioVenta = new SqlParameter();
                parametroFechaRegistroPrecioVenta.ParameterName = "@FECHAREGISTROPRECIOVENTA";
                parametroFechaRegistroPrecioVenta.SqlDbType = SqlDbType.VarChar;
                parametroFechaRegistroPrecioVenta.Size = 10;
                parametroFechaRegistroPrecioVenta.Value = Producto._fechaRegistroPrecioVenta;
                SqlCmd.Parameters.Add(parametroFechaRegistroPrecioVenta);

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

        public string eliminarCliente(DatosProducto Producto)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminarProducto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @CODIGOPRODUCTO
                SqlParameter parametroCodigoProducto = new SqlParameter();
                parametroCodigoProducto.ParameterName = "@CODIGOPRODUCTO";
                parametroCodigoProducto.SqlDbType = SqlDbType.VarChar;
                parametroCodigoProducto.Size = 5;
                parametroCodigoProducto.Value = Producto._codigoProducto;
                SqlCmd.Parameters.Add(parametroCodigoProducto);

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
