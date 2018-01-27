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
    public partial class InterfazPrincipalGerente : Form
    {
        public InterfazPrincipalGerente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void InterfazPrincipalGerente_Load(object sender, EventArgs e)
        {

        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarCliente consulta = new FormularioConsultarCliente();
            consulta.Show();
            this.Hide();
        }

        private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRegistrarCliente nuevo = new FormularioRegistrarCliente();
            nuevo.Show();
            this.Hide();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioActualizarCliente actualizar = new FormularioActualizarCliente();
            actualizar.Show();
            this.Hide();

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarCliente eliminar = new FormularioEliminarCliente();
            eliminar.Show();
            this.Hide();

        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRegistrarProducto nuevo = new FormularioRegistrarProducto();
            nuevo.Show();
            this.Hide();
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarProducto consulta = new FormularioConsultarProducto();
            consulta.Show();
            this.Hide();
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioActualizarProducto actualizar = new FormularioActualizarProducto();
            actualizar.Show();
            this.Hide();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarProducto eliminar = new FormularioEliminarProducto();
            eliminar.Show();
            this.Hide();
        }

        private void nuevoMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRegistrarMantenimiento nuevo = new FormularioRegistrarMantenimiento();
            nuevo.Show();
            this.Hide();
        }

        private void consultarMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarMantenimiento consulta = new FormularioConsultarMantenimiento();
            consulta.Show();
            this.Hide();
        }

        private void btnSalirGerente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fACTURACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarFacturaGerente consulta = new FormularioConsultarFacturaGerente();
            consulta.Show();
            this.Hide();
        }

        private void anularFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioAnularFactura anular = new FormularioAnularFactura();
            anular.Show();
            this.Hide();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioregistrarUsuario nuevo = new FormularioregistrarUsuario();
            nuevo.Show();
            this.Hide();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarUsuario consulta = new FormularioConsultarUsuario();
            consulta.Show();
            this.Hide();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormularioActualizarUsuario actualizar = new FormularioActualizarUsuario();
            actualizar.Show();
            this.Hide();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarUsuario eliminar = new FormularioEliminarUsuario();
            eliminar.Show();
            this.Hide();
        }
    }
}
