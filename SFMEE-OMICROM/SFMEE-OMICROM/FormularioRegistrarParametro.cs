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
    public partial class FormularioRegistrarParametro : Form
    {
        public FormularioRegistrarParametro()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            this.limpiarCampos();
            this.bloquearCampos();
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Registrar Parámetro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registrar Parámetro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FormularioConsultarParametro consulta = new FormularioConsultarParametro();
            consulta.Show();
            this.Hide();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioActualizarParametro actualizar = new FormularioActualizarParametro();
            actualizar.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarParametro eliminar = new FormularioEliminarParametro();
            eliminar.Show();
            this.Hide();
        }

        private void limpiarCampos()
        {
            this.txtNombreParametro.Clear();
            this.txtValorParametro.Clear();
            this.txtNombreParametro.Clear();
        }

        private void bloquearCampos()
        {
            txtValorParametro.ReadOnly = true;
            btnGuardar.Visible = false;
        }

        private void desbloquearCampos()
        {
            txtValorParametro.ReadOnly = false;
            btnGuardar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtNombreParametro.Text == string.Empty || this.txtValorParametro.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioParametro.insertarParametro(this.txtNombreParametro.Text.ToUpper(), Int32.Parse(this.txtValorParametro.Text.Trim()));
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarCampos();
            this.bloquearCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tablaParametro = NegocioParametro.consultarParametroTabla(this.txtNombreParametro.Text);
            if (tablaParametro.Rows.Count == 0)
            {
                desbloquearCampos();
            }
            else
            {
                MessageBox.Show("Parámetro ya registrado", "Registrar Parámetro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void soloNumeros(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsNumber(evento.KeyChar) || char.IsControl(evento.KeyChar))
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

        private void txtNombreParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloLetras(e);
        }

        private void txtValorParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtNombreParametro.Text == string.Empty || this.txtValorParametro.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioParametro.insertarParametro(this.txtNombreParametro.Text.ToUpper(), Int32.Parse(this.txtValorParametro.Text.Trim()));
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
    }
}
