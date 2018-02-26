using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

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

        private void login()
        {
            string cargo;
            if (checkGerente.Checked == true)
            {
                cargo = "GERENTE";
                this.tabla_aux.DataSource = NegocioUsuario.loginUsuario(this.txtUsuario.Text, this.txtPassword.Text, cargo);
                int var = Convert.ToInt32(this.tabla_aux.Rows[0].Cells[0].Value);
                if (var != 0)
                {
                    InterfazPrincipalGerente gerente = new InterfazPrincipalGerente();
                    gerente.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkCajero.Checked == true)
            {
                cargo = "CAJERO";
                this.tabla_aux.DataSource = NegocioUsuario.loginUsuario(this.txtUsuario.Text, this.txtPassword.Text, cargo);
                int var = Convert.ToInt32(this.tabla_aux.Rows[0].Cells[0].Value);
                if (var != 0)
                {
                    InterfazPrincipalCajero cajero = new InterfazPrincipalCajero();
                    cajero.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkTecnico.Checked == true)
            {
                cargo = "TECNICO";
                this.tabla_aux.DataSource = NegocioUsuario.loginUsuario(this.txtUsuario.Text, this.txtPassword.Text, cargo);
                int var = Convert.ToInt32(this.tabla_aux.Rows[0].Cells[0].Value);
                if (var != 0)
                {
                    InterfazPrincipalTecnico tecnico = new InterfazPrincipalTecnico();
                    tecnico.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormularioLogin_Load(object sender, EventArgs e)
        {
            this.tabla_aux.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.login();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnSalir_MouseHover(Object sender, EventArgs e)
        {

            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
