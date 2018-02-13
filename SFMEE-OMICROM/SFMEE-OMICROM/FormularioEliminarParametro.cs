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
    public partial class FormularioEliminarParametro : Form
    {
        public FormularioEliminarParametro()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            btnEliminar.Visible = false;
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Eliminar Parámetro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Eliminar Parámetro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRegistrarParametro nuevo = new FormularioRegistrarParametro();
            nuevo.Show();
            this.Hide();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioActualizarParametro actualizar = new FormularioActualizarParametro();
            actualizar.Show();
            this.Hide();
        }

        private void limpiarCampos()
        {
            this.txtNomnbreParametro.Clear();
            this.lblValorParametro.ResetText();
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

        private void FormularioEliminarParametro_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarParametros();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            btnEliminar.Visible = false;
        }

        private void mostrarParametros()
        {
            this.tablaParametro.DataSource = NegocioParametro.mostrarParametros();
            this.tablaParametro.Columns[0].Visible = false;
        }

        private void consultarParametroTabla()
        {
            this.tablaParametro.DataSource = NegocioParametro.consultarParametroTabla(this.txtNomnbreParametro.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioParametro.consultarParametroTabla(this.txtNomnbreParametro.Text);
            if (this.tablaParametro.Rows.Count != 0)
            {
                this.txtNomnbreParametro.Text = Convert.ToString(this.tablaParametro.CurrentRow.Cells["NOMBREPARAMETRO"].Value);
                this.lblValorParametro.Text = Convert.ToString(this.tablaParametro.CurrentRow.Cells["VALOR"].Value);
                btnEliminar.Visible = true;
            }

            else
            {
                this.limpiarCampos();
                this.mostrarParametros();
                MessageBox.Show("Parámetro no registrado", "Eliminar Parámetro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                DialogResult opcion;
                opcion = MessageBox.Show("¿Seguro que desea eliminar el Parámetro?", "Eliminar Parámetro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    respuesta = NegocioParametro.eliminarParametro(this.txtNomnbreParametro.Text);
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
            this.limpiarCampos();
            btnEliminar.Visible = false;
            this.mostrarParametros();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void txtNomnbreParametro_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNomnbreParametro.Text == string.Empty)
            {
                this.btnBuscar.Visible = false;
            }
            else
            {
                this.btnBuscar.Visible = true;
            }
            this.consultarParametroTabla();
        }

        private void txtNomnbreParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloLetras(e);
        }
    }
}
