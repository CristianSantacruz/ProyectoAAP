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
    public partial class FormularioActualizarCliente : Form
    {
        public FormularioActualizarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearCampos();
        }

        private void FormularioActualizarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InterfazPrincipalGerente actualizar = new InterfazPrincipalGerente();
            actualizar.Show();
            this.Hide();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRegistrarCliente nuevo = new FormularioRegistrarCliente();
            nuevo.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipalGerente actualizar = new InterfazPrincipalGerente();
            actualizar.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarCliente eliminar = new FormularioEliminarCliente();
            eliminar.Show();
            this.Hide();
        }

        public void bloquearCampos()
        {
            txtNombreCliente.ReadOnly = true;
            txtDireccionCliente.ReadOnly = true;
            txtTelefonoCliente.ReadOnly = true;
            txtCelular.ReadOnly = true;
            btnGuardar.Visible = false;
        }

        public void desbloquearCampos()
        {
            txtCI.ReadOnly = true;
            txtDireccionCliente.ReadOnly = false;
            txtTelefonoCliente.ReadOnly = false;
            txtCelular.ReadOnly = false;
            btnGuardar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarCliente consulta = new FormularioConsultarCliente();
            consulta.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
