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
    public partial class FormularioEliminarUsuario : Form
    {
        public FormularioEliminarUsuario()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            btnEliminar.Visible = false;
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioActualizarUsuario eliminar = new FormularioActualizarUsuario();
            eliminar.Show();
            this.Hide();
        }

        private void mostrarUsuarios()
        {
            this.tablaUsuario.DataSource = NegocioUsuario.mostrarUsuario();
            this.tablaUsuario.Columns[0].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioUsuario.consultarUsuarioTabla(this.txtNombreUsuario.Text);
            if (this.tablaUsuario.Rows.Count != 0)
            {
                this.txtNombreUsuario.Text = Convert.ToString(this.tablaUsuario.CurrentRow.Cells["NOMBREUSUARIO"].Value);
                btnEliminar.Visible = true;
            }

            else
            {
                this.txtNombreUsuario.Clear(); ;
                this.mostrarUsuarios();
                MessageBox.Show("Usuario no registrado", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormularioEliminarUsuario usuario = new FormularioEliminarUsuario();
            usuario.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                DialogResult opcion;
                opcion = MessageBox.Show("¿Seguro que desea eliminar el usuario?", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    respuesta = NegocioUsuario.eliminarUsuario(this.txtNombreUsuario.Text);
                    this.txtNombreUsuario.Clear();
                    if (respuesta.Equals("OK"))
                    {
                        this.MensajeOK("Registro eliminado exitosamente");
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            btnEliminar.Visible = false;
            this.mostrarUsuarios();
        }

        private void FormularioEliminarUsuario_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarUsuarios();
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

        private void consultarUsuarioTabla()
        {
            this.tablaUsuario.DataSource = NegocioUsuario.consultarUsuarioTabla(this.txtNombreUsuario.Text);
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
    }
}
