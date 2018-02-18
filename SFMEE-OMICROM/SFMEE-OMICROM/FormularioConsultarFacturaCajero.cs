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
    public partial class FormularioConsultarFacturaCajero : Form
    {
        public FormularioConsultarFacturaCajero()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            btnImprimir.Visible = false;
        }

        private void mostrarFactura()
        {
            this.tablaFactura.DataSource = NegocioFactura.mostrarFacturas();
        }

        public void consultarFactura()
        {
            NegocioFactura.consultarFacturaTabla(int.Parse(this.txtNumeroFactura.Text));
            if (this.tablaFactura.Rows.Count != 0)
            {
                this.lblClienteMostrar.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["CICLIENTE"].Value);
                this.lblClienteMostrar.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["IDCLIENTE"].Value);
                this.lblNombreMostrar.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["NOMBRECLIENTE"].Value);
                this.lblDireccionMostrar.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["DIRECCIONCLIENTE"].Value);
                this.lblTelefonoFijoMostrar.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["TELEFONOFIJOCLIENTE"].Value);
                this.lblCelularMostrar.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["TELEFONOMOVILCLIENTE"].Value);

                this.lblFecha.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["FECHAFACTURA"].Value);
                this.lblCajero.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["VENDEDOR"].Value);
                this.lblSubTotalValor.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["SUBTOTAL"].Value);
                this.lblDescuentoValor.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["DESCUENTO"].Value);
                this.lblIVAValor.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["IVA"].Value);
                this.lblTotalValor.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["TOTAL"].Value);
                this.lblTipoPagoMostrar.Text = Convert.ToString(this.tablaFactura.CurrentRow.Cells["ESTADOFACTURA"].Value);
            }

            else
            {
                this.limpiarCampos();
                this.mostrarFactura();
                MessageBox.Show("No existe la factura", "Consultar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void consultarFacturaTabla()
        {
            if (this.txtNumeroFactura.Text == string.Empty)
            {
                this.tablaFactura.DataSource = NegocioFactura.consultarFacturaTabla(0);
            }
            else
            {
                this.tablaFactura.DataSource = NegocioFactura.consultarFacturaTabla(int.Parse(this.txtNumeroFactura.Text));
            }

        }

        private void consultarDetalleTabla()
        {
            if (this.txtNumeroFactura.Text == string.Empty)
            {
                this.tablaDetalle.DataSource = NegocioFactura.mostrarDetalle(0);
            }
            else
            {
                this.tablaDetalle.DataSource = NegocioFactura.mostrarDetalle(int.Parse(this.txtNumeroFactura.Text));
            }

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

        public void limpiarCampos()
        {
            txtNumeroFactura.Clear();
            lblClienteMostrar.ResetText();
            lblNombreMostrar.ResetText();
            lblCIMostrar.ResetText();
            lblDireccionMostrar.ResetText();
            lblTelefonoFijoMostrar.ResetText();
            lblCelularMostrar.ResetText();

            lblFecha.ResetText();
            lblCajero.ResetText();
            lblSubTotalValor.ResetText();
            lblDescuentoValor.ResetText();
            lblIVAValor.ResetText();
            lblSubTotalValor.ResetText();
            lblTotalValor.ResetText();
            lblTipoPagoMostrar.ResetText();

            DataTable dt = (DataTable)tablaDetalle.DataSource;
            dt.Clear();
        }

        private void FormularioConsultarFacturaCajero_Load(object sender, EventArgs e)
        {
            this.tablaFactura.Visible = false;
            this.btnBuscar.Visible = false;
            this.mostrarFactura();
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

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioNueva_FacturaVenta nuevo = new FormularioNueva_FacturaVenta();
            nuevo.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            btnImprimir.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.consultarFactura();
            this.consultarDetalleTabla();
            btnImprimir.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void txtNumeroFactura_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNumeroFactura.Text == string.Empty)
            {
                this.btnBuscar.Visible = false;
            }
            else
            {
                this.btnBuscar.Visible = true;
            }
        }

        private void txtNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e);
        }
    }
}
