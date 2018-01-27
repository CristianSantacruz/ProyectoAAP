using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void FormularioConsultarFacturaCajero_Load(object sender, EventArgs e)
        {

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

        public void limpiarCampos()
        {
            txtNumeroFactura.Clear();
            lblNombreMostrar.ResetText();
            lblCIMostrar.ResetText();
            lblDireccionMostrar.ResetText();
            lblTelefonoFijoMostrar.ResetText();
            lblCelularMostrar.ResetText();

            lblSubTotalValor.ResetText();
            lblDescuentoValor.ResetText();
            lblIVAValor.ResetText();
            lblSubTotalValor.ResetText();
            lblTipoPagoMostrar.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
