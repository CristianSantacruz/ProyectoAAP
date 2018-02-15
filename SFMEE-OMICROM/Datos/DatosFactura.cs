﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosFactura
    {
        private int _idFactura;
        private int _idCliente;
        private string _fechaFactura;
        private string _vendedor;
        private string _tipoPago;
        private float _subTotal;
        private float _descuento;
        private float _iva;
        private float _total;
        private string _estadoFactura;

        public DatosFactura()
        {

        }

        public DatosFactura(int idFactura, int idCliente, string fechaFactura, string vendedor, string tipoPago, 
                            float subtotal, float descuento, float iva, float total, string estadoFactura)
        {
            this._idFactura = idFactura;
            this._idCliente = idCliente;
            this._fechaFactura = fechaFactura;
            this._vendedor = vendedor;
            this._tipoPago = tipoPago;
            this._subTotal = subtotal;
            this._descuento = descuento;
            this._iva = iva;
            this._total = total;
            this._estadoFactura = estadoFactura;
        }

        public int IdFactura { get => _idFactura; set => _idFactura = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public string FechaFactura { get => _fechaFactura; set => _fechaFactura = value; }
        public string Vendedor { get => _vendedor; set => _vendedor = value; }
        public string TipoPago { get => _tipoPago; set => _tipoPago = value; }
        public float SubTotal { get => _subTotal; set => _subTotal = value; }
        public float Descuento { get => _descuento; set => _descuento = value; }
        public float Iva { get => _iva; set => _iva = value; }
        public float Total { get => _total; set => _total = value; }
        public string EstadoFactura { get => _estadoFactura; set => _estadoFactura = value; }

        public DataTable contarRegistros()
        {
            DataTable tablaResultado = new DataTable("FACTURA");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "contarRegistrosFactura";
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

        public string disminuirStock(int idDetalleFactura, int cantidad)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "disminuirStock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @IDDETALLEFACTURA
                SqlParameter parametroIdDetalleFactura = new SqlParameter();
                parametroIdDetalleFactura.ParameterName = "@IDDETALLEFACTURA";
                parametroIdDetalleFactura.SqlDbType = SqlDbType.Int;
                parametroIdDetalleFactura.Value = idDetalleFactura;
                SqlCmd.Parameters.Add(parametroIdDetalleFactura);

                //Crear parámetro @CANTIDAD
                SqlParameter parametroCantidad = new SqlParameter();
                parametroCantidad.ParameterName = "@CANTIDAD";
                parametroCantidad.SqlDbType = SqlDbType.Int;
                parametroCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(parametroCantidad);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "Registro actualizado exitosamente" : "No se actualizó el Stock";
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

        public string insertarDatosFactura(DatosFactura Factura, List<DatosDetalleFactura>Detalle)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertarDatosFactura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @IDFACTURA
                SqlParameter parametroIdFactura = new SqlParameter();
                parametroIdFactura.ParameterName = "@IDFACTURA";
                parametroIdFactura.SqlDbType = SqlDbType.Int;
                parametroIdFactura.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(parametroIdFactura);

                //Crear parámetro @IDCLIENTE
                SqlParameter parametroIdCliente = new SqlParameter();
                parametroIdCliente.ParameterName = "@IDCLIENTE";
                parametroIdCliente.SqlDbType = SqlDbType.Int;
                parametroIdCliente.Value = Factura._idCliente;
                SqlCmd.Parameters.Add(parametroIdCliente);
                
                //Crear parámetro @FECHAFACTURA
                SqlParameter parametroFechaFactura = new SqlParameter();
                parametroFechaFactura.ParameterName = "@FECHAFACTURA";
                parametroFechaFactura.SqlDbType = SqlDbType.VarChar;
                parametroFechaFactura.Size = 10;
                parametroFechaFactura.Value = Factura._fechaFactura;
                SqlCmd.Parameters.Add(parametroFechaFactura);

                //Crear parámetro @VENDEDOR
                SqlParameter parametroVendedor = new SqlParameter();
                parametroVendedor.ParameterName = "@FVENDEDOR";
                parametroVendedor.SqlDbType = SqlDbType.VarChar;
                parametroVendedor.Size = 50;
                parametroVendedor.Value = Factura._vendedor;
                SqlCmd.Parameters.Add(parametroVendedor);

                //Crear parámetro @TIPOPAGO
                SqlParameter parametroTipoPAgo = new SqlParameter();
                parametroTipoPAgo.ParameterName = "@TIPOPAGO";
                parametroTipoPAgo.SqlDbType = SqlDbType.VarChar;
                parametroTipoPAgo.Size = 10;
                parametroTipoPAgo.Value = Factura._tipoPago;
                SqlCmd.Parameters.Add(parametroTipoPAgo);

                //Crear parámetro @SUBTOTAL
                SqlParameter parametroSubTotal = new SqlParameter();
                parametroSubTotal.ParameterName = "@SUBTOTAL";
                parametroSubTotal.SqlDbType = SqlDbType.Float;
                parametroSubTotal.Size = 10;
                parametroSubTotal.Value = Factura._subTotal;
                SqlCmd.Parameters.Add(parametroSubTotal);

                //Crear parámetro @DESCUENTO
                SqlParameter parametroDescuento = new SqlParameter();
                parametroDescuento.ParameterName = "@DESCUENTO";
                parametroDescuento.SqlDbType = SqlDbType.Float;
                parametroDescuento.Size = 10;
                parametroDescuento.Value = Factura._descuento;
                SqlCmd.Parameters.Add(parametroDescuento);

                //Crear parámetro @IVA
                SqlParameter parametroIva = new SqlParameter();
                parametroIva.ParameterName = "@IVA";
                parametroIva.SqlDbType = SqlDbType.Float;
                parametroIva.Size = 10;
                parametroIva.Value = Factura._iva;
                SqlCmd.Parameters.Add(parametroIva);

                //Crear parámetro @TOTAL
                SqlParameter parametroTotal = new SqlParameter();
                parametroTotal.ParameterName = "@TOTAL";
                parametroTotal.SqlDbType = SqlDbType.Float;
                parametroTotal.Size = 10;
                parametroTotal.Value = Factura._total;
                SqlCmd.Parameters.Add(parametroTotal);

                //Crear parámetro @ESTADOFACTURA
                SqlParameter parametroEstadofactura = new SqlParameter();
                parametroEstadofactura.ParameterName = "@ESTADOFACTURA";
                parametroEstadofactura.SqlDbType = SqlDbType.VarChar;
                parametroEstadofactura.Size = 15;
                parametroEstadofactura.Value = Factura._estadoFactura;
                SqlCmd.Parameters.Add(parametroEstadofactura);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "Registro ingresado exitosamente" : "No se ingresó el registro";

                if (respuesta.Equals("Registro ingresado exitosamente"))
                {
                    this.IdFactura = Convert.ToInt32(SqlCmd.Parameters["@IDFACTURA"].Value);
                    foreach (DatosDetalleFactura det in Detalle)
                    {
                        det.IdFactura = this.IdFactura;
                        respuesta = det.insertarDetalleFactura(det, ref SqlCon, ref SqlTra);
                        if (!respuesta.Equals("Registro ingresado exitosamente"))
                        {
                            break;
                        }
                        else
                        {
                            respuesta = disminuirStock(det.IdDetalleFactura, det.Cantidad);
                            if (!respuesta.Equals("Registro ingresado exitosamente"))
                            {
                                break;
                            }
                        }
                    }
                }
                if (respuesta.Equals("Registro ingresado exitosamente"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }
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

        public string eliminarFactura(DatosFactura Factura)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "anularFactura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @IDFACTURA
                SqlParameter parametroIdFactura = new SqlParameter();
                parametroIdFactura.ParameterName = "@IDFACTURA";
                parametroIdFactura.SqlDbType = SqlDbType.Int;
                parametroIdFactura.Value = Factura.IdFactura;
                SqlCmd.Parameters.Add(parametroIdFactura);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";
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

        public DataTable mostrarFacturas()
        {
            DataTable tablaResultado = new DataTable("FACTURA");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarFacturas";
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

        public string buscarFactura(DatosFactura Factura)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscarFactura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @IDFACTURA
                SqlParameter parametroIdFactura = new SqlParameter();
                parametroIdFactura.ParameterName = "@IDFACTURA";
                parametroIdFactura.SqlDbType = SqlDbType.Int;
                parametroIdFactura.Value = Factura.IdFactura;
                SqlCmd.Parameters.Add(parametroIdFactura);

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

        public DataTable mostrarDetalle(int idFactura)
        {
            DataTable tablaResultado = new DataTable("DETALLE_VENTA");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarDetalleFactura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @IDFACTURA
                SqlParameter parametroIdFactura = new SqlParameter();
                parametroIdFactura.ParameterName = "@IDFACTURA";
                parametroIdFactura.SqlDbType = SqlDbType.Int;
                parametroIdFactura.Value = idFactura;
                SqlCmd.Parameters.Add(parametroIdFactura);

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