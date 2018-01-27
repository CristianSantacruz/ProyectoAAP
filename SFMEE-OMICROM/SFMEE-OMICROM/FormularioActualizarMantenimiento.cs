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
    public partial class FormularioActualizarMantenimiento : Form
    {
        public FormularioActualizarMantenimiento()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearCampos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InterfazPrincipalTecnico tecnico = new InterfazPrincipalTecnico();
            tecnico.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipalTecnico tecnico = new InterfazPrincipalTecnico();
            tecnico.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            bloquearCampos();
        }

        public void bloquearCampos()
        {
            comboEstado.Visible = false;
            txtObservacion.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            btnGuardar.Visible = false;
        }

        public void desbloquearCampos()
        {
            comboEstado.Visible = true;
            txtObservacion.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            btnGuardar.Visible = true;
        }

        public void LimpiarCampos()
        {
            txtCodigoMantenimiento.Clear();
            lblClienteMostrar.ResetText();
            lblCIMostrar.ResetText();
            lblNombreMostrar.ResetText();
            lblDireccionMostrar.ResetText();
            lblTelefonoFijoMostrar.ResetText();
            lblCelularMostrar.ResetText();

            lblFechaMantenimientoMostrar.ResetText();
            lblHoraMantenimientoMostrar.ResetText();
            txtObservacion.Clear();
            txtPrecio.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultaMantenimientoTecnico consulta = new FormularioConsultaMantenimientoTecnico();
            consulta.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
