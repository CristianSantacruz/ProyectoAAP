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
    public partial class FormularioregistrarUsuario : Form
    {
        public FormularioregistrarUsuario()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearCampos();
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Registrar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registrar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtNombreUsuario.ReadOnly = false;
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
            DataTable tablaUsuario = NegocioUsuario.consultarUsuarioTabla(this.txtNombreUsuario.Text);
            if (tablaUsuario.Rows.Count == 0)
            {
                desbloquearCampos();
            }
            else
            {
                MessageBox.Show("Usuario ya registrado", "Registrar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtNombreUsuario.Text == string.Empty || this.txtLogin.Text == string.Empty || this.txtPassword.Text == string.Empty || this.comboCargo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioUsuario.insertarUsuario(this.txtNombreUsuario.Text.ToUpper(), this.txtLogin.Text.ToLower().Trim(), this.txtPassword.Text.Trim(), this.comboCargo.Text);
                    this.MensajeOK("Registro ingresado exitosamente");
                    this.limpiarCampos();
                    this.bloquearCampos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtNombreUsuario.Text == string.Empty || this.txtLogin.Text == string.Empty || this.txtPassword.Text == string.Empty || this.comboCargo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioUsuario.insertarUsuario(this.txtNombreUsuario.Text.ToUpper(), this.txtLogin.Text.ToLower().Trim(), this.txtPassword.Text.Trim(), this.comboCargo.Text);
                    this.MensajeOK("Registro ingresado exitosamente");
                    this.limpiarCampos();
                    this.bloquearCampos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void soloLetras(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsLetter(evento.KeyChar) || char.IsControl(evento.KeyChar) || char.IsSeparator(evento.KeyChar))
                {
                    evento.Handled = false;
                }

                else
                {
                    evento.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void login(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsLetter(evento.KeyChar) || char.IsNumber(evento.KeyChar) || evento.KeyChar == '.')
                {
                    evento.Handled = false;
                }

                else
                {
                    evento.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloLetras(e);
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.login(e);
        }
        
    }
}
