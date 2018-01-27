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
    public partial class InterfazPrincipalCajero : Form
    {
        public InterfazPrincipalCajero()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarClienteCajero consulta = new FormularioConsultarClienteCajero();
            consulta.Show();
            this.Hide();
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarProductoCajero consulta = new FormularioConsultarProductoCajero();
            consulta.Show();
            this.Hide();
        }

        private void consultarMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarMantenimientoCajero consulta = new FormularioConsultarMantenimientoCajero();
            consulta.Show();
            this.Hide();
        }

        private void btnSalirCajero_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioNueva_FacturaVenta nuevo = new FormularioNueva_FacturaVenta();
            nuevo.Show();
            this.Hide();
        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarFacturaCajero consulta = new FormularioConsultarFacturaCajero();
            consulta.Show();
            this.Hide();
        }
    }
}
