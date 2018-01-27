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
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;

            InterfazPrincipal principal = new InterfazPrincipal();
            principal.Show();
        }

        private void FormularioLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "cristian" && txtPassword.Text == "123456" && checkGerente.Checked==true)
            {
                InterfazPrincipalGerente gerente = new InterfazPrincipalGerente();
                gerente.Show();
                this.Hide();
            }

            else if (txtUsuario.Text == "erika" && txtPassword.Text == "123456" && checkCajero.Checked == true)
            {
                InterfazPrincipalCajero cajero = new InterfazPrincipalCajero();
                cajero.Show();
                this.Hide();
            }

            else if (txtUsuario.Text == "david" && txtPassword.Text == "123456")
            {
                InterfazPrincipalTecnico tecnico = new InterfazPrincipalTecnico();
                tecnico.Show();
                this.Hide();
            }

            else {
                MessageBox.Show("Credenciales incorrectas","LOGIN",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
