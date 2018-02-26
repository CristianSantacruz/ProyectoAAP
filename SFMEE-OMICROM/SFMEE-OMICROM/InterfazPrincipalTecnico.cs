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
    public partial class InterfazPrincipalTecnico : Form
    {
        public InterfazPrincipalTecnico()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarClienteTecnico consulta = new FormularioConsultarClienteTecnico();
            consulta.Show();
            this.Hide();
        }

        private void actualizarMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultaMantenimientoTecnico consulta = new FormularioConsultaMantenimientoTecnico();
            consulta.Show();
            this.Hide();
        }

        private void actualizarMantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormularioActualizarMantenimiento actualizar = new FormularioActualizarMantenimiento();
            actualizar.Show();
            this.Hide();
        }

        private void btnSalirTecnico_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeSGFMOMICROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioAcercaDeTecnico tecnico = new FormularioAcercaDeTecnico();
            tecnico.Show();
            this.Hide();
        }
    }
}
