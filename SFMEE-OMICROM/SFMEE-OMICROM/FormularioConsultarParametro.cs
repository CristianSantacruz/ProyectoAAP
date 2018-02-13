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
    public partial class FormularioConsultarParametro : Form
    {
        public FormularioConsultarParametro()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarParametro eliminar = new FormularioEliminarParametro();
            eliminar.Show();
            this.Hide();
        }

        private void limpiarCampos()
        {
            txtNombreParametro.Clear();
            lblValorParametro.ResetText();
        }

        private void mostrarParametros()
        {
            this.tablaParametro.DataSource = NegocioParametro.mostrarParametros();
            this.tablaParametro.Columns[0].Visible = false;
        }

        private void consultarParametroTabla()
        {
            this.tablaParametro.DataSource = NegocioParametro.consultarParametroTabla(this.txtNombreParametro.Text);
        }

        private void soloLetras(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsLetter(evento.KeyChar) || char.IsSeparator(evento.KeyChar) || char.IsControl(evento.KeyChar))
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioParametro.consultarParametroTabla(this.txtNombreParametro.Text);
            if (this.tablaParametro.Rows.Count != 0)
            {
                this.txtNombreParametro.Text = Convert.ToString(this.tablaParametro.CurrentRow.Cells["NOMBREPARAMETRO"].Value);
                this.lblValorParametro.Text = Convert.ToString(this.tablaParametro.CurrentRow.Cells["VALOR"].Value);
            }

            else
            {
                this.limpiarCampos();
                this.mostrarParametros();
                MessageBox.Show("Parámetro no registrado", "Consultar Parámetro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void txtNombreParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloLetras(e);
        }

        private void txtNombreParametro_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNombreParametro.Text == string.Empty)
            {
                this.btnBuscar.Visible = false;
            }
            else
            {
                this.btnBuscar.Visible = true;
            }
            this.consultarParametroTabla();
        }

        private void FormularioConsultarParametro_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarParametros();
        }
    }
}
