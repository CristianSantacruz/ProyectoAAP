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
    public partial class FormularioActualizarProducto : Form
    {
        public FormularioActualizarProducto()
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRegistrarProducto nuevo = new FormularioRegistrarProducto();
            nuevo.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarProducto eliminar = new FormularioEliminarProducto();
            eliminar.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            bloquearCampos();
        }

        public void limpiarCampos()
        {
            txtCodigo.Clear();
            txtNombreProducto.Clear();
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtCategoria.Clear();
            txtCantidad.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
        }

        public void bloquearCampos()
        {
            txtNombreProducto.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            txtCategoria.ReadOnly = true;
            txtCantidad.ReadOnly = true;
            txtPrecioCompra.ReadOnly = true;
            txtPrecioVenta.ReadOnly = true;
            btnGuardar.Visible = false;
            pickerFechaRegistroCompra.Visible = false;
            pickerFechaRegistroVenta.Visible = false;
        }

        public void desbloquearCampos()
        {
            txtCantidad.ReadOnly = false;
            txtPrecioCompra.ReadOnly = false;
            txtPrecioVenta.ReadOnly = false;
            btnGuardar.Visible = true;
            pickerFechaRegistroCompra.Visible = true;
            pickerFechaRegistroVenta.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarProducto consulta = new FormularioConsultarProducto();
            consulta.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
