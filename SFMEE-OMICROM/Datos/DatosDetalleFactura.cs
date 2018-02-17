using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosDetalleFactura
    {
        private int _idDetalleFactura;
        private int _idFactura;
        private int _idMantenimiento;
        private int _idProducto;
        private string _codigo;
        private int _cantidad;
        private string _detalle;
        private float _valorUnitario;
        private float _descuentoDetalle;
        private float _valorTotal;
        

        public DatosDetalleFactura()
        {

        }

        public DatosDetalleFactura(int idDetalleFactura, int idFactura, int idMantenimiento, int idProducto, string codigo, int cantidad, 
                                   string detalle, float valorUnitario, float descuentoDetalle,float valorTotal)
        {
            this.IdDetalleFactura = idDetalleFactura;
            this.IdFactura = idFactura;
            this.IdMantenimiento = idMantenimiento;
            this.IdProducto = idProducto;
            this.Codigo = codigo;
            this.Cantidad = cantidad;
            this.Detalle = detalle;
            this.ValorUnitario = valorUnitario;
            this.DescuentoDetalle = descuentoDetalle;
            this.ValorTotal= valorTotal;
        }

        public int IdDetalleFactura { get => _idDetalleFactura; set => _idDetalleFactura = value; }
        public int IdFactura { get => _idFactura; set => _idFactura = value; }
        public int IdMantenimiento { get => _idMantenimiento; set => _idMantenimiento = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public string Detalle { get => _detalle; set => _detalle = value; }
        public float ValorUnitario { get => _valorUnitario; set => _valorUnitario = value; }
        public float DescuentoDetalle { get => _descuentoDetalle; set => _descuentoDetalle = value; }
        public float ValorTotal { get => _valorTotal; set => _valorTotal = value; }

        public string insertarDetalleFactura(DatosDetalleFactura DetalleFactura, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertarDatosDetalleFactura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Crear parámetro @IDFACTURA
                SqlParameter parametroIdDetalleVenta = new SqlParameter();
                parametroIdDetalleVenta.ParameterName = "@IDDETALLEFACTURA";
                parametroIdDetalleVenta.SqlDbType = SqlDbType.Int;
                parametroIdDetalleVenta.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(parametroIdDetalleVenta);
                
                //Crear parámetro @IDFACTURA
                SqlParameter parametroIdfactura = new SqlParameter();
                parametroIdfactura.ParameterName = "@IDFACTURA";
                parametroIdfactura.SqlDbType = SqlDbType.Int;
                parametroIdfactura.Value = DetalleFactura.IdFactura;
                SqlCmd.Parameters.Add(parametroIdfactura);

                //Crear parámetro @IDMANTENIMIENTO
                SqlParameter parametroIdMantenimiento = new SqlParameter();
                parametroIdMantenimiento.ParameterName = "@IDMANTENIMIENTO";
                parametroIdMantenimiento.SqlDbType = SqlDbType.Int;
                parametroIdMantenimiento.Value = DetalleFactura.IdMantenimiento;
                SqlCmd.Parameters.Add(parametroIdMantenimiento);

                //Crear parámetro @IDPRODUCTO
                SqlParameter parametroIdProducto = new SqlParameter();
                parametroIdProducto.ParameterName = "@IDPRODUCTO";
                parametroIdProducto.SqlDbType = SqlDbType.Int;
                parametroIdProducto.Value = DetalleFactura.IdProducto;
                SqlCmd.Parameters.Add(parametroIdProducto);

                //Crear parámetro @CODIGO
                SqlParameter parametroCodigo = new SqlParameter();
                parametroCodigo.ParameterName = "@CODIGO";
                parametroCodigo.SqlDbType = SqlDbType.VarChar;
                parametroCodigo.Size = 5;
                parametroCodigo.Value = DetalleFactura.Codigo;
                SqlCmd.Parameters.Add(parametroCodigo);

                //Crear parámetro @CANTIDAD
                SqlParameter parametroCantidad = new SqlParameter();
                parametroCantidad.ParameterName = "@CANTIDAD";
                parametroCantidad.SqlDbType = SqlDbType.Int;
                parametroCantidad.Value = DetalleFactura.Cantidad;
                SqlCmd.Parameters.Add(parametroCantidad);

                //Crear parámetro @DETALLE
                SqlParameter parametroDetalle = new SqlParameter();
                parametroDetalle.ParameterName = "@DETALLE";
                parametroDetalle.SqlDbType = SqlDbType.VarChar;
                parametroDetalle.Size = 50;
                parametroDetalle.Value = DetalleFactura.Detalle;
                SqlCmd.Parameters.Add(parametroDetalle);

                //Crear parámetro @VALORUNITARIO
                SqlParameter parametroValorUnitario = new SqlParameter();
                parametroValorUnitario.ParameterName = "@VALORUNITARIO";
                parametroValorUnitario.SqlDbType = SqlDbType.Float;
                parametroValorUnitario.Size = 10;
                parametroValorUnitario.Value = DetalleFactura.ValorUnitario;
                SqlCmd.Parameters.Add(parametroValorUnitario);

                //Crear parámetro @DESCUENTODETALLE
                SqlParameter parametroDescuentoDetalle = new SqlParameter();
                parametroDescuentoDetalle.ParameterName = "@DESCUENTODETALLE";
                parametroDescuentoDetalle.SqlDbType = SqlDbType.Float;
                parametroDescuentoDetalle.Size = 10;
                parametroDescuentoDetalle.Value = DetalleFactura.DescuentoDetalle;
                SqlCmd.Parameters.Add(parametroDescuentoDetalle);

                //Crear parámetro @VALORTOTAL
                SqlParameter parametroValorTotal = new SqlParameter();
                parametroValorTotal.ParameterName = "@VALORTOTAL";
                parametroValorTotal.SqlDbType = SqlDbType.Float;
                parametroValorTotal.Size = 10;
                parametroValorTotal.Value = DetalleFactura.ValorTotal;
                SqlCmd.Parameters.Add(parametroValorTotal);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingresó el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }
    }
}
