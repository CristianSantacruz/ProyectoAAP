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

namespace SFMEE_OMICROM
{
    public partial class FormularioInsertarProductoFactura : Form
    {
        public FormularioInsertarProductoFactura()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
        }

        private void mostrarProductos()
        {
            this.tablaProducto.DataSource = NegocioProducto.mostrarProductos();
            this.tablaProducto.Columns[0].Visible = false;
        }

        private void consultarProductoTabla()
        {
            this.tablaProducto.DataSource = NegocioProducto.consultarProductoTabla(this.txtCodigo.Text);
        }

        private void codigo(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsLetter(evento.KeyChar) || char.IsNumber(evento.KeyChar) || char.IsControl(evento.KeyChar))
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

        private void cantidad(KeyPressEventArgs evento)
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

        public void limpiarCampos()
        {
            txtCodigo.Clear();
            lblNombreProducto.ResetText();
            lblDescripcion.ResetText();
            lblCategoria.ResetText();
            lblCantidad.ResetText();
            lblPrecioCompra.ResetText();
            lblPrecioVenta.ResetText();
            lblFechaRegistroPrecioCompra.ResetText();
            lblFechaRegistroPrecioVenta.ResetText();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioProducto.consultarProductoTabla(this.txtCodigo.Text);
            if (this.tablaProducto.Rows.Count != 0)
            {
                this.txtCodigo.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["CODIGOPRODUCTO"].Value);
                this.lblNombreProducto.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["NOMBREPRODUCTO"].Value);
                this.lblDescripcion.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["DESCRIPCIONPRODUCTO"].Value);
                this.lblCategoria.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["CATEGORIAPRODUCTO"].Value);
                this.lblCantidad.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["CANTIDADPRODUCTO"].Value);
                this.lblPrecioCompra.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["PRECIOCOMPRAPRODUCTO"].Value);
                this.lblPrecioVenta.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["PRECIOVENTAPRODUCTO"].Value);
                this.lblFechaRegistroPrecioCompra.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["FECHAREGISTROPRECIOCOMPRA"].Value);
                this.lblFechaRegistroPrecioVenta.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["FECHAREGISTROPRECIOVENTA"].Value);
            }

            else
            {
                this.limpiarCampos();
                this.mostrarProductos();
                MessageBox.Show("Producto no registrado", "Consultar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FormularioInsertarProductoFactura_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarProductos();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(this.txtCodigo.Text == string.Empty)
            {
                this.btnBuscar.Visible = false;
            }
            else
            {
                this.btnBuscar.Visible = true;
            }
            this.consultarProductoTabla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.codigo(e);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text==String.Empty || this.txtDescuento.Text == String.Empty || this.txtCantidadVender.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar algunos campos", "Ingresar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Convert.ToInt32(this.lblCantidad.Text) < Convert.ToInt32(this.txtCantidadVender.Text))
                {
                    MessageBox.Show("Producto Insuficiente", "Ingresar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FormularioNueva_FacturaVenta factura = new FormularioNueva_FacturaVenta();
                    NegocioProducto.consultarProductoTabla(this.txtCodigo.Text);
                    if (this.tablaProducto.Rows.Count != 0)
                    {
                        DataRow row = FormularioNueva_FacturaVenta.tablaDetalle.NewRow();
                        row["IDFACTURA"] = Int32.Parse((factura.lblNumeroFacturaVenta.Text));
                        row["IDPRODUCTO"] = Int32.Parse(Convert.ToString(this.tablaProducto.CurrentRow.Cells["IDPRODUCTO"].Value));
                        row["IDMANTENIMIENTO"] = 1;
                        row["CÓDIGO"] = this.txtCodigo.Text;
                        row["CANTIDAD"] = Convert.ToInt32(this.txtCantidadVender.Text);
                        row["DETALLE"] = this.lblDescripcion.Text;
                        row["VALOR UNITARIO"] = Convert.ToSingle(this.lblPrecioVenta.Text);
                        row["DESCUENTO"] = Convert.ToSingle(this.lblPrecioVenta.Text) * Convert.ToInt32(this.txtCantidadVender.Text) * (float.Parse(this.txtDescuento.Text) / 100);
                        row["VALOR TOTAL"] = (Convert.ToSingle(row["VALOR UNITARIO"].ToString()) * (Convert.ToSingle(row["CANTIDAD"].ToString())) - (Convert.ToSingle(row["DESCUENTO"].ToString())));


                        FormularioNueva_FacturaVenta.tablaDetalle.Rows.Add(row);

                        this.Hide();
                    }
                }
            }
        }

        private void txtCantidadVender_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.cantidad(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.cantidad(e);
        }
    }
}
