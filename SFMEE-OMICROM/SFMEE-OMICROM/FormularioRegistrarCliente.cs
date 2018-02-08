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
    public partial class FormularioRegistrarCliente : Form
    {
        public FormularioRegistrarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearCampos();
            
        }

        private void MensajeOK (string mensaje)
        {
            MessageBox.Show(mensaje,"Registrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormularioRegistrarCliente_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InterfazPrincipalGerente gerente = new InterfazPrincipalGerente();
            gerente.Show();
            this.Hide();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarCliente eliminar = new FormularioEliminarCliente();
            eliminar.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            bloquearCampos();
        }

        public void bloquearCampos()
        {
            txtNombreCliente.ReadOnly = true;
            txtDireccionCliente.ReadOnly = true;
            txtTelefonoCliente.ReadOnly = true;
            txtCelular.ReadOnly = true;
            btnGuardar.Visible = false;
            guardarToolStripMenuItem.Visible = false;
        }

        public void limpiarCampos()
        {
            txtCI.Clear();
            txtNombreCliente.Clear();
            txtDireccionCliente.Clear();
            txtTelefonoCliente.Clear();
            txtCelular.Clear();
        }

        public void desbloquearCampos()
        {
            txtNombreCliente.ReadOnly = false;
            txtDireccionCliente.ReadOnly = false;
            txtTelefonoCliente.ReadOnly = false;
            txtCelular.ReadOnly = false;
            btnGuardar.Visible = true;
            guardarToolStripMenuItem.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(NegocioCliente.VerificarNumeroCedula(this.txtCI.Text).Equals(true) || NegocioCliente.verificarNumeroRucNatural(this.txtCI.Text).Equals(true) || NegocioCliente.VerificarNumeroRucPublico(this.txtCI.Text).Equals(true) || NegocioCliente.VerificarNumeroRucJuridico(this.txtCI.Text).Equals(true))
            {
                DataTable tablaCliente = NegocioCliente.consultarClienteTabla(this.txtCI.Text);
                if (tablaCliente.Rows.Count == 0)
                {
                    desbloquearCampos();
                }
                else
                {
                    MessageBox.Show("Cliente ya registrado", "Registrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Número de cédula o RUC inconsistente", "Verificar Cedula/RUC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarCliente consulta = new FormularioConsultarCliente();
            consulta.Show();
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
                if(this.txtCI.Text==string.Empty || this.txtNombreCliente.Text==string.Empty || this.txtDireccionCliente.Text==string.Empty || this.txtTelefonoCliente.Text == string.Empty || this.txtCelular.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    if(NegocioCliente.verificarNumeroFijo(this.txtTelefonoCliente.Text).Equals(true))
                    {
                        if (NegocioCliente.verificarNumeroCelular(this.txtCelular.Text).Equals(true))
                        {
                            respuesta = NegocioCliente.insertarCliente(this.txtCI.Text.Trim(), this.txtNombreCliente.Text.ToUpper(), this.txtDireccionCliente.Text.ToUpper(), this.txtTelefonoCliente.Text.Trim(), this.txtCelular.Text.Trim());
                            this.MensajeOK("Registro ingresado exitosamente");
                            this.limpiarCampos();
                            this.bloquearCampos();
                        }

                        else
                        {
                            MessageBox.Show("Número de Teléfono Móvil inconsistente","Registro de Cliente", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            MessageBox.Show("Vuelva a ingresar el número de Teléfono Móvil", "Registro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtCelular.Clear();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Número de Teléfono Fijo inconsistente", "Registro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Vuelva a ingresar el número de Teléfono Fijo", "Registro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtTelefonoCliente.Clear();
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtCI.Text == string.Empty || this.txtNombreCliente.Text == string.Empty || this.txtDireccionCliente.Text == string.Empty || this.txtTelefonoCliente.Text == string.Empty || this.txtCelular.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    if (NegocioCliente.verificarNumeroFijo(this.txtTelefonoCliente.Text).Equals(true))
                    {
                        if (NegocioCliente.verificarNumeroCelular(this.txtCelular.Text).Equals(true))
                        {
                            respuesta = NegocioCliente.insertarCliente(this.txtCI.Text.Trim(), this.txtNombreCliente.Text.ToUpper(), this.txtDireccionCliente.Text.ToUpper(), this.txtTelefonoCliente.Text.Trim(), this.txtCelular.Text.Trim());
                            this.MensajeOK("Registro ingresado exitosamente");
                            this.limpiarCampos();
                            this.bloquearCampos();
                        }

                        else
                        {
                            MessageBox.Show("Número de Teléfono Móvil inconsistente", "Registro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtCelular.Clear();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Número de Teléfono Fijo inconsistente", "Registro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        public void soloLetras(KeyPressEventArgs evento)
        {
            try
            {
                if(char.IsLetter(evento.KeyChar))
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
            catch(Exception ex)
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

        public void signosPuntuacion(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsPunctuation(evento.KeyChar))
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

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloLetras(e);
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
        }
    }
}
