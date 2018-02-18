using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Data.SqlClient;

namespace SFMEE_OMICROM
{

    public partial  class FormularioNueva_FacturaVenta : Form
    {
        private SqlConnection conexion = new SqlConnection();

        public void abrirConexion()
        {
            conexion.ConnectionString = "Data Source =LPT-CRISTIAN; Initial Catalog=SFMEE_OMICROM; Integrated Security=true";
            conexion.Open();
        }

        public static DataTable tablaDetalle;

        private string tipoPago;

        public FormularioNueva_FacturaVenta()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearBotones();
            this.contarRegistros();
        }

        public void insertarDetalles()
        {
            this.abrirConexion();

            foreach (DataRow row in tablaDetalle.Rows)
            {
                SqlCommand SqlCmd = new SqlCommand("insertarDatosDetalleFactura", conexion);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(new SqlParameter("@IDFACTURA", Convert.ToInt32(row["IDFACTURA"].ToString())));
                SqlCmd.Parameters.Add(new SqlParameter("@IDMANTENIMIENTO", Convert.ToInt32(row["IDMANTENIMIENTO"].ToString())));
                SqlCmd.Parameters.Add(new SqlParameter("@IDPRODUCTO", Convert.ToInt32(row["IDPRODUCTO"].ToString())));
                SqlCmd.Parameters.Add(new SqlParameter("@CODIGO", (row["CÓDIGO"].ToString())));
                SqlCmd.Parameters.Add(new SqlParameter("@CANTIDAD", Convert.ToInt32(row["CANTIDAD"].ToString())));
                SqlCmd.Parameters.Add(new SqlParameter("@DETALLE", (row["DETALLE"].ToString())));
                SqlCmd.Parameters.Add(new SqlParameter("@VALORUNITARIO", Convert.ToSingle(row["VALOR UNITARIO"].ToString())));
                SqlCmd.Parameters.Add(new SqlParameter("@DESCUENTODETALLE", Convert.ToSingle(row["DESCUENTO"].ToString())));
                SqlCmd.Parameters.Add(new SqlParameter("@VALORTOTAL", Convert.ToSingle(row["VALOR TOTAL"].ToString())));
                SqlCmd.ExecuteNonQuery();
            }
            conexion.Close();
        }

        public void disminuirStock()
        {
            this.abrirConexion();
            
            foreach (DataRow row in tablaDetalle.Rows)
            {
                SqlCommand SqlCmd = new SqlCommand("disminuirStock", conexion);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(new SqlParameter("@CODIGO", row["CÓDIGO"].ToString()));
                SqlCmd.Parameters.Add(new SqlParameter("@CANTIDAD", Convert.ToInt32(row["CANTIDAD"].ToString())));
                SqlCmd.ExecuteNonQuery();
            }
            conexion.Close();
        }

        private void crearTabla()
        {
            tablaDetalle = new DataTable("Detalle");
            tablaDetalle.Columns.Add("IDFACTURA", System.Type.GetType("System.Int32"));
            tablaDetalle.Columns.Add("IDMANTENIMIENTO", System.Type.GetType("System.Int32"));
            tablaDetalle.Columns.Add("IDPRODUCTO", System.Type.GetType("System.Int32"));

            tablaDetalle.Columns.Add("CÓDIGO", System.Type.GetType("System.String"));
            tablaDetalle.Columns.Add("CANTIDAD", System.Type.GetType("System.Int32"));
            tablaDetalle.Columns.Add("DETALLE", System.Type.GetType("System.String"));
            tablaDetalle.Columns.Add("VALOR UNITARIO", System.Type.GetType("System.Single"));
            tablaDetalle.Columns.Add("DESCUENTO", System.Type.GetType("System.Single"));
            tablaDetalle.Columns.Add("VALOR TOTAL", System.Type.GetType("System.Single"));


            this.tablaFactura.DataSource = tablaDetalle;
        }

        private void subtotal()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in this.tablaFactura.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells["VALOR TOTAL"].Value);
            }
            subtotal = Math.Round(subtotal, 2);
            this.lblSubTotalValor.Text = Convert.ToString(subtotal);
        }

        private void descuento()
        {
            decimal descuento = 0;
            foreach (DataGridViewRow row in this.tablaFactura.Rows)
            {
                descuento += Convert.ToDecimal(row.Cells["DESCUENTO"].Value);
            }
            descuento = Math.Round(descuento, 2);
            this.lblDescuentoValor.Text = Convert.ToString(descuento);
        }

        private void capturarIVA()
        {
            decimal iva = 0;
            NegocioParametro.buscarParametro(this.lblIVA.Text);
            if (this.tablaIva.Rows.Count != 0)
            {
                iva = (Convert.ToDecimal(this.lblSubTotalValor.Text)) * ((Convert.ToDecimal(tablaIva.CurrentRow.Cells["VALOR"].Value)) / 100);
                iva = Math.Round(iva, 2);
                this.lblIVAValor.Text = Convert.ToString(iva);
            }
        }

        private void mostrarIVA()
        {
            this.tablaIva.DataSource = NegocioParametro.consultarParametroTabla("IVA");
        }

        private void mostrarCajeros()
        {
            this.comboCajero.ValueMember = "IDUSUARIO";
            this.comboCajero.DisplayMember = "NOMBREUSUARIO";
            this.comboCajero.DataSource = NegocioUsuario.cargarCajeros();
        }

        private void total()
        {
            decimal total = 0;
            total += (Convert.ToDecimal(this.lblSubTotalValor.Text) + Convert.ToDecimal(this.lblIVAValor.Text));
            total = Math.Round(total, 2);
            this.lblTotalValor.Text = Convert.ToString(total);
        }

        private string TipoPago()
        {
            if (radioEfectivo.Checked == true)
            {
                return this.tipoPago = "EFECTIVO";
            }

            else if (radioCheque.Checked == true)
            {
                return this.tipoPago = "CHEQUE";
            }

            else if (radioTarjeta.Checked == true)
            {
                return this.tipoPago = "TARJETA";
            }

            else
            {
                return this.tipoPago = "";
            }
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Registrar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registrar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InterfazPrincipalCajero cajero = new InterfazPrincipalCajero();
            cajero.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipalCajero cajero = new InterfazPrincipalCajero();
            cajero.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            bloquearBotones();
        }
        
        public void bloquearBotones()
        {
            btnIngresarProducto.Visible = false;
            btnIngresarMantenimiento.Visible = false;
            btnBorrarProducto.Visible = false;
            btnGuardar.Visible = false;
            btnImprimir.Visible = false;
            radioEfectivo.Visible = false;
            radioTarjeta.Visible = false;
            radioCheque.Visible = false;
            comboEstadoFactura.Visible = false;
            txtCi.ReadOnly = true;
            comboCajero.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void limpiarCampos()
        {
            txtCi.Clear();
            lblClienteMostrar.ResetText();
            lblNombreMostrar.ResetText();
            lblDireccionMostrar.ResetText();
            lblTelefonoFijoMostrar.ResetText();
            lblCelularMostrar.ResetText();

            lblSubTotalValor.Text = "0";
            lblDescuentoValor.Text = "0";
            lblIVAValor.Text = "0";
            comboEstadoFactura.ResetText();
            comboCajero.ResetText();

            this.crearTabla();
        }

        public void soloNumeros(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsNumber(evento.KeyChar) || char.IsControl(evento.KeyChar))
                {
                    evento.Handled = false;
                }

                else
                {
                    evento.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contarRegistros()
        {
            this.tabla_aux.DataSource = NegocioFactura.numeroFactura();

            if (this.tabla_aux.Rows.Count != 0)
            {
                int var = Convert.ToInt32(this.tabla_aux.Rows[0].Cells[0].Value) + 1;
                this.lblNumeroFacturaVenta.Text = Convert.ToString(var);
            }

            else
            {
                this.limpiarCampos();
            }
        }

        private void mostrarClientes()
        {
            this.tablaCliente.DataSource = NegocioCliente.mostrarClientes();
            //this.tablaCliente.Columns[0].Visible = false;
        }

        private void consultarClienteTabla()
        {
            this.tablaCliente.DataSource = NegocioCliente.consultarClienteTabla(this.txtCi.Text);
        }
        
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            NegocioCliente.consultarClienteTabla(this.txtCi.Text);
            if (this.tablaCliente.Rows.Count != 0)
            {
                this.txtCi.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["CICLIENTE"].Value);
                this.lblClienteMostrar.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["IDCLIENTE"].Value);
                this.lblNombreMostrar.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["NOMBRECLIENTE"].Value);
                this.lblDireccionMostrar.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["DIRECCIONCLIENTE"].Value);
                this.lblTelefonoFijoMostrar.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["TELEFONOFIJOCLIENTE"].Value);
                this.lblCelularMostrar.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["TELEFONOMOVILCLIENTE"].Value);
                
                radioEfectivo.Visible = true;
                radioTarjeta.Visible = true;
                radioCheque.Visible = true;
                comboEstadoFactura.Visible = true;
                comboEstadoFactura.DropDownStyle = ComboBoxStyle.DropDownList;
                btnIngresarProducto.Visible = true;
                btnIngresarMantenimiento.Visible = true;
            }

            else
            {
                this.limpiarCampos();
                this.bloquearBotones();
                MessageBox.Show("Cliente no registrado", "Registrar Factura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            FormularioInsertarProductoFactura producto = new FormularioInsertarProductoFactura();
            producto.Show();
            btnBorrarProducto.Visible = true;
            btnGuardar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                try
            {
                string respuesta = "";
                if (this.lblClienteMostrar.Text != string.Empty && this.pickerFechaNuevaFactura.Text != string.Empty && this.comboCajero.Text != string.Empty &&
                    this.lblSubTotalValor.Text != string.Empty && this.lblDescuento.Text != string.Empty && this.lblIVAValor.Text != string.Empty &&
                    this.lblTotalValor.Text != string.Empty && this.comboEstadoFactura.Text != string.Empty &&
                    (radioCheque.Checked == true || radioEfectivo.Checked == true) || radioTarjeta.Checked == true)
                {
                    respuesta = NegocioFactura.insertarFactura(Convert.ToInt32(this.lblClienteMostrar.Text), this.pickerFechaNuevaFactura.Text, this.comboCajero.Text,
                        this.TipoPago().ToString(), float.Parse(this.lblSubTotalValor.Text), float.Parse(this.lblDescuentoValor.Text),
                        float.Parse(this.lblIVAValor.Text), float.Parse(this.lblTotalValor.Text), this.comboEstadoFactura.Text);
                    this.insertarDetalles();
                    this.disminuirStock();

                    this.MensajeOK("Registro ingresado exitosamente");
                    btnImprimir.Visible = true;
                }
                else
                {
                    MensajeError("Falta ingresar algunos datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarFacturaCajero consulta = new FormularioConsultarFacturaCajero();
            consulta.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            this.subtotal();
            this.descuento();
            this.capturarIVA();
            this.total();
        }

        private void btnIngresarMantenimiento_Click(object sender, EventArgs e)
        {
            FormularioInsertarMantenimientoFactura mantenimiento = new FormularioInsertarMantenimientoFactura();
            mantenimiento.Show();
            btnBorrarProducto.Visible = true;
            btnGuardar.Visible = true;
        }

        private void txtCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e);
        }

        private void txtCi_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCi.Text == string.Empty)
            {
                this.btnBuscarCliente.Visible = false;
            }
            else
            {
                this.btnBuscarCliente.Visible = true;
            }
            this.consultarClienteTabla();
        }

        private void FormularioNueva_FacturaVenta_Load(object sender, EventArgs e)
        {
            this.txtCi.ReadOnly = true;
            this.btnBuscarCliente.Visible = false;
            this.mostrarCajeros();
            this.mostrarClientes();
            this.mostrarIVA();
            this.tablaCliente.Visible = false;
            this.tabla_aux.Visible = false;
            this.tablaIva.Visible = false;
            this.crearTabla();
            this.tablaFactura.Columns[0].Visible = false;
            this.tablaFactura.Columns[1].Visible = false;
            this.tablaFactura.Columns[2].Visible = false;
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFila = this.tablaFactura.CurrentCell.RowIndex;
                DataRow row = tablaDetalle.Rows[indiceFila];
                tablaDetalle.Rows.Remove(row);
            }
            catch
            {
                MessageBox.Show("No ha seleccionado una fila", "Eliminar Fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
        }

        private void comboCajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboCajero.Text != string.Empty)
            {
                this.txtCi.ReadOnly = false;
            }
        }
    }
}
