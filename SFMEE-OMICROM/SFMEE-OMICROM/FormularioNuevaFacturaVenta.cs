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
    public partial class FormularioNueva_FacturaVenta : Form
    {
        public FormularioNueva_FacturaVenta()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearBotones();
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
        }

        public void limpiarCampos()
        {
            txtCi.Clear();
            lblNombreMostrar.ResetText();
            lblDireccionMostrar.ResetText();
            lblTelefonoFijoMostrar.ResetText();
            lblCelularMostrar.ResetText();

            lblSubTotalValor.ResetText();
            lblDescuentoValor.ResetText();
            lblIVAValor.ResetText();
            lblSubTotalValor.ResetText();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            radioEfectivo.Visible = true;
            radioTarjeta.Visible = true;
            radioCheque.Visible = true;
            btnIngresarProducto.Visible = true;
            btnIngresarMantenimiento.Visible = true;
        }

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            btnBorrarProducto.Visible = true;
            btnGuardar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = true;
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
        }

        private void btnIngresarMantenimiento_Click(object sender, EventArgs e)
        {
            btnBorrarProducto.Visible = true;
            btnGuardar.Visible = true;
        }
    }
}
