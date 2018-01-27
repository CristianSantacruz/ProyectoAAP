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
    public partial class FormularioregistrarUsuario : Form
    {
        public FormularioregistrarUsuario()
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
        }

        public void limpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtLogin.Clear();
            txtPassword.Clear();
        }

        public void bloquearCampos()
        {
            txtNombreUsuario.ReadOnly = true;
            txtLogin.ReadOnly=true;
            txtPassword.ReadOnly = true;
            comboCargo.Visible = false;
            btnGuardar.Visible = false;
        }

        public void desbloquearCampos()
        {
            txtNombreUsuario.ReadOnly = false;
            txtLogin.ReadOnly = false;
            txtPassword.ReadOnly = false;
            comboCargo.Visible = true;
            btnGuardar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
            bloquearCampos();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarUsuario consulta = new FormularioConsultarUsuario();
            consulta.Show();
            this.Hide();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioActualizarUsuario actualizar = new FormularioActualizarUsuario();
            actualizar.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarUsuario eliminar = new FormularioEliminarUsuario();
            eliminar.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
