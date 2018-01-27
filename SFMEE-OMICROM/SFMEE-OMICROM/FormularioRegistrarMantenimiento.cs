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
    public partial class FormularioRegistrarMantenimiento : Form
    {
        public FormularioRegistrarMantenimiento()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearCampos();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            bloquearCampos();
        }

        public void limpiarCampos()
        {
            txtCI.Clear();
            txtCodigoMantenimiento.Clear();
            lblClienteMostrar.ResetText();
            lblCIMostrar.ResetText();
            lblNombreMostrar.ResetText();
            lblDireccionMostrar.ResetText();
            lblTelefonoFijoMostrar.ResetText();
            lblCelularMostrar.ResetText();
            txtObservacion.Clear();
            txtPrecio.Clear();
        }

        public void bloquearCampos()
        {
            txtCodigoMantenimiento.ReadOnly = true;
            pickerFechaMantenimiento.Visible = false;
            comboEstado.Visible = false;
            txtObservacion.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            btnGuardar.Visible = false;
        }

        public void desbloquearCampos()
        {
            pickerFechaMantenimiento.Visible = true;
            comboEstado.Visible = true;
            txtObservacion.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            btnGuardar.Visible = true;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarMantenimiento consulta = new FormularioConsultarMantenimiento();
            consulta.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblHoraSistemaMostrar.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
