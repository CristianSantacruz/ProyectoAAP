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
    public partial class FormularioEliminarProducto : Form
    {
        public FormularioEliminarProducto()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            btnEliminar.Visible = false;
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRegistrarProducto nuevo = new FormularioRegistrarProducto();
            nuevo.Show();
            this.Hide();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioActualizarProducto actualizar = new FormularioActualizarProducto();
            actualizar.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            btnEliminar.Visible = false;
        }

        public void limpiarCampos()
        {
            txtCodigo.Clear();
            lblNombreProducto.ResetText();
            lblDescripcion.ResetText();
            lblCategoria.ResetText();
            lblCantidad.ResetText();
            lblPrecioCompra.ResetText();
            lblFechaRegistroPrecioVenta.ResetText();
            lblFechaRegistroPrecioVenta.ResetText();
            lblFechaRegistroPrecioCompra.ResetText();
            lblFechaRegistroPrecioVenta.ResetText();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRegistrarProducto nuevo = new FormularioRegistrarProducto();
            nuevo.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnEliminar.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
