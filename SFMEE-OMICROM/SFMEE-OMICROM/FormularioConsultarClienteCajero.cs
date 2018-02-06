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
    public partial class FormularioConsultarClienteCajero : Form
    {
        public FormularioConsultarClienteCajero()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InterfazPrincipalCajero cajero = new InterfazPrincipalCajero();
            cajero.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipalCajero cajero = new InterfazPrincipalCajero();
            cajero.Show();
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
            txtCI.Clear();
            lblNombre.ResetText();
            lblDireccion.ResetText();
            lblTelefono.ResetText();
            lblCelular.ResetText();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void mostrarClientes()
        {
            this.tablaCliente.DataSource = NegocioCliente.mostrarClientes();
            this.tablaCliente.Columns[0].Visible = false;
        }

        private void consultarClienteTabla()
        {
            this.tablaCliente.DataSource = NegocioCliente.consultarClienteTabla(this.txtCI.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioCliente.consultarClienteTabla(this.txtCI.Text);
            if (this.tablaCliente.Rows.Count != 0)
            {
                this.txtCI.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["CICLIENTE"].Value);
                this.lblNombre.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["NOMBRECLIENTE"].Value);
                this.lblDireccion.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["DIRECCIONCLIENTE"].Value);
                this.lblTelefono.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["TELEFONOFIJOCLIENTE"].Value);
                this.lblCelular.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["TELEFONOMOVILCLIENTE"].Value);
            }

            else
            {
                this.limpiarCampos();
                this.mostrarClientes();
                MessageBox.Show("Cliente no registrado", "Consultar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCI_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCI.Text == string.Empty)
            {
                this.btnBuscar.Visible = false;
            }
            else
            {
                this.btnBuscar.Visible = true;
            }
            this.consultarClienteTabla();
        }

        private void FormularioConsultarClienteCajero_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarClientes();
        }

        public void soloNumeros(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsNumber(evento.KeyChar))
                {
                    evento.Handled = false;
                }

                else if (char.IsControl(evento.KeyChar))
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

        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e);
        }
    }
}
