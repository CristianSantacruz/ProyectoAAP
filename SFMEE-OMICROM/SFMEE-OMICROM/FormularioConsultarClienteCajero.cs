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
    public partial class FormularioConsultarClienteCajero : Form
    {
        public FormularioConsultarClienteCajero()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
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
        }

        public void limpiarCampos()
        {
            txtCI.Clear();
            lblNombre.ResetText();
            lblDireccion.ResetText();
            lblTelefono.ResetText();
            lblCelular.ResetText();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
