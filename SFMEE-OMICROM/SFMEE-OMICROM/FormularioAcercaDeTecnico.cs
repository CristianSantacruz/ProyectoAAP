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
    public partial class FormularioAcercaDeTecnico : Form
    {
        public FormularioAcercaDeTecnico()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InterfazPrincipalTecnico tecnico = new InterfazPrincipalTecnico();
            tecnico.Show();
            this.Hide();
        }
    }
}
