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
    public partial class FormularioAnularFactura : Form
    {
        public FormularioAnularFactura()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            btnAnular.Visible = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InterfazPrincipalGerente gerente = new InterfazPrincipalGerente();
            gerente.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipalGerente gerente = new InterfazPrincipalGerente();
            gerente.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarFacturaGerente consulta = new FormularioConsultarFacturaGerente();
            consulta.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            btnAnular.Visible = false;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnAnular.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
