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
    public partial class FormularioActualizarCliente : Form
    {
        public FormularioActualizarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearCampos();
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormularioActualizarCliente_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarClientes();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InterfazPrincipalGerente actualizar = new InterfazPrincipalGerente();
            actualizar.Show();
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
            InterfazPrincipalGerente actualizar = new InterfazPrincipalGerente();
            actualizar.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarCliente eliminar = new FormularioEliminarCliente();
            eliminar.Show();
            this.Hide();
        }

        public void limpiarCampos()
        {
            txtCI.Clear();
            txtNombreCliente.Clear();
            txtDireccionCliente.Clear();
            txtTelefonoCliente.Clear();
            txtCelular.Clear();
        }

        public void bloquearCampos()
        {
            txtCI.ReadOnly = false;
            txtNombreCliente.ReadOnly = true;
            txtDireccionCliente.ReadOnly = true;
            txtTelefonoCliente.ReadOnly = true;
            txtCelular.ReadOnly = true;
            btnGuardar.Visible = false;
            guardarToolStripMenuItem.Visible = false;
        }

        public void desbloquearCampos()
        {
            txtCI.ReadOnly = true;
            txtDireccionCliente.ReadOnly = false;
            txtTelefonoCliente.ReadOnly = false;
            txtCelular.ReadOnly = false;
            btnGuardar.Visible = true;
            guardarToolStripMenuItem.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioCliente.consultarClienteTabla(this.txtCI.Text);
            if (this.tablaCliente.Rows.Count != 0)
            {
                desbloquearCampos();
                this.txtCI.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["CICLIENTE"].Value);
                this.txtNombreCliente.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["NOMBRECLIENTE"].Value);
                this.txtDireccionCliente.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["DIRECCIONCLIENTE"].Value);
                this.txtTelefonoCliente.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["TELEFONOFIJOCLIENTE"].Value);
                this.txtCelular.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["TELEFONOMOVILCLIENTE"].Value);
            }

            else
            {
                this.limpiarCampos();
                this.mostrarClientes();
                this.bloquearCampos();
                MessageBox.Show("Cliente no registrado", "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarCliente consulta = new FormularioConsultarCliente();
            consulta.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarCampos();
            this.bloquearCampos();
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
                if (this.txtDireccionCliente.Text == string.Empty || this.txtTelefonoCliente.Text == string.Empty || this.txtCelular.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    if (NegocioCliente.verificarNumeroFijo(this.txtTelefonoCliente.Text).Equals(true))
                    {
                        if (NegocioCliente.verificarNumeroCelular(this.txtCelular.Text).Equals(true))
                        {
                            respuesta = NegocioCliente.actualizarCliente(this.txtCI.Text.Trim(), this.txtDireccionCliente.Text.ToUpper(), this.txtTelefonoCliente.Text.Trim(), this.txtCelular.Text.Trim());
                            this.MensajeOK("Registro actualizado exitosamente");
                            this.limpiarCampos();
                            this.bloquearCampos();
                            this.mostrarClientes();
                        }

                        else
                        {
                            MessageBox.Show("Número de Teléfono Móvil inconsistente", "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtCelular.Clear();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Número de Teléfono Fijo inconsistente", "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtTelefonoCliente.Clear();
                    }

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
                if (this.txtDireccionCliente.Text == string.Empty || this.txtTelefonoCliente.Text == string.Empty || this.txtCelular.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    if (NegocioCliente.verificarNumeroFijo(this.txtTelefonoCliente.Text).Equals(true))
                    {
                        if (NegocioCliente.verificarNumeroCelular(this.txtCelular.Text).Equals(true))
                        {
                            respuesta = NegocioCliente.actualizarCliente(this.txtCI.Text.Trim(), this.txtDireccionCliente.Text.ToUpper(), this.txtTelefonoCliente.Text.Trim(), this.txtCelular.Text.Trim());
                            this.MensajeOK("Registro actualizado exitosamente");
                            this.limpiarCampos();
                            this.bloquearCampos();
                            this.mostrarClientes();
                        }

                        else
                        {
                            MessageBox.Show("Número de Teléfono Móvil inconsistente", "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtCelular.Clear();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Número de Teléfono Fijo inconsistente", "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtTelefonoCliente.Clear();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            this.limpiarCampos();
            this.bloquearCampos();
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

        public void soloLetras(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsLetter(evento.KeyChar))
                {
                    evento.Handled = false;
                }

                else if (char.IsControl(evento.KeyChar))
                {
                    evento.Handled = false;
                }

                else if (char.IsSeparator(evento.KeyChar))
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

        public void direccion(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsLetter(evento.KeyChar) || evento.KeyChar == '-' || evento.KeyChar == '.' || evento.KeyChar == ',' || char.IsControl(evento.KeyChar) || char.IsSeparator(evento.KeyChar) || char.IsNumber(evento.KeyChar))
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
            soloNumeros(e);
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e);
        }

        private void txtDireccionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.direccion(e);
        }
    }
}
