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
    public partial class FormularioActualizarUsuario : Form
    {
        public FormularioActualizarUsuario()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearCampos();
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Actualizar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Actualizar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarUsuario consulta = new FormularioConsultarUsuario();
            consulta.Show();
            this.Hide();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioregistrarUsuario nuevo = new FormularioregistrarUsuario();
            nuevo.Show();
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarUsuario eliminar = new FormularioEliminarUsuario();
            eliminar.Show();
            this.Hide();
        }

        public void bloquearCampos()
        {
            txtNombreUsuario.ReadOnly = false;
            txtLogin.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtCargo.ReadOnly = true;
            btnGuardar.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioUsuario.consultarUsuarioTabla(this.txtNombreUsuario.Text);
            if (this.tablaUsuario.Rows.Count != 0)
            {
                this.txtNombreUsuario.Text = Convert.ToString(this.tablaUsuario.CurrentRow.Cells["NOMBREUSUARIO"].Value);
                this.txtLogin.Text = Convert.ToString(this.tablaUsuario.CurrentRow.Cells["LOGINUSUARIO"].Value);
                this.txtPassword.Text = Convert.ToString(this.tablaUsuario.CurrentRow.Cells["PASSWORDUSUARIO"].Value);
                this.txtCargo.Text = Convert.ToString(this.tablaUsuario.CurrentRow.Cells["CARGOUSUARIO"].Value);

                txtNombreUsuario.ReadOnly = true;
                txtPassword.ReadOnly = false;
                btnGuardar.Visible = true;
            }

            else
            {
                this.limpiarCampos();
                this.mostrarUsuarios();
                MessageBox.Show("Usuario no registrado", "Actualizar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void limpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtLogin.Clear();
            txtPassword.Clear();
            txtCargo.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            bloquearCampos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InterfazPrincipalGerente gerente = new InterfazPrincipalGerente();
            gerente.Show();
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
                if (this.txtNombreUsuario.Text == string.Empty || this.txtLogin.Text == string.Empty || this.txtPassword.Text == string.Empty || this.txtCargo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioUsuario.actualizarUsuario(this.txtNombreUsuario.Text.ToUpper(), this.txtPassword.Text.Trim());
                    this.MensajeOK("Registro actualizado exitosamente");
                    this.limpiarCampos();
                    this.bloquearCampos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void mostrarUsuarios()
        {
            this.tablaUsuario.DataSource = NegocioUsuario.mostrarUsuario();
            this.tablaUsuario.Columns[0].Visible = false;
        }

        private void consultarUsuarioTabla()
        {
            this.tablaUsuario.DataSource = NegocioUsuario.consultarUsuarioTabla(this.txtNombreUsuario.Text);
        }

        private void FormularioActualizarUsuario_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarUsuarios();
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNombreUsuario.Text == string.Empty)
            {
                this.btnBuscar.Visible = false;
            }
            else
            {
                this.btnBuscar.Visible = true;
            }
            this.consultarUsuarioTabla();
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

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloLetras(e);
        }
    }
}
