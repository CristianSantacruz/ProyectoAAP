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
    public partial class FormularioEliminarCliente : Form
    {
        public FormularioEliminarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            btnEliminar.Visible = false;
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InterfazPrincipalGerente gerente = new InterfazPrincipalGerente();
            gerente.Show();
            this.Hide();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRegistrarCliente nuevo = new FormularioRegistrarCliente();
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

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioActualizarCliente actualizar = new FormularioActualizarCliente();
            actualizar.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            btnEliminar.Visible = false;
        }

        public void limpiarCampos()
        {
            txtCI.Clear();
            lblNombre.ResetText();
            lblDireccion.ResetText();
            lblTelefono.ResetText();
            lblCelular.ResetText();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnEliminar.Visible = true;
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
                btnEliminar.Visible = false;
                MessageBox.Show("Cliente no registrado", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarCliente consulta = new FormularioConsultarCliente();
            consulta.Show();
            this.Hide();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                opcion = MessageBox.Show("¿Seguro que desea eliminar al cliente?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(opcion == DialogResult.OK)
                {
                    respuesta = NegocioCliente.eliminarCliente(this.txtCI.Text);
                    if(respuesta.Equals("OK"))
                    {
                        this.MensajeOK("Registro eliminado exitosamente");
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            this.limpiarCampos();
            btnEliminar.Visible = false;
            this.mostrarClientes();
        }

        private void FormularioEliminarCliente_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarClientes();
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
