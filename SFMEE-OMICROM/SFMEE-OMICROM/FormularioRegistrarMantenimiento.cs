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
    public partial class FormularioRegistrarMantenimiento : Form
    {
        public FormularioRegistrarMantenimiento()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearCampos();
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Registrar Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registrar Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bloquearCampos();
        }

        public void limpiarCampos()
        {
            txtCI.Clear();
            txtCodigoMantenimiento.Clear();
            lblClienteMostrar.ResetText();
            lblCIMostrar.ResetText();
            lblNombreMostrar.ResetText();
            lblDireccionMostrar.ResetText();
            lblTelefonoFijoMostrar.ResetText();
            lblCelularMostrar.ResetText();
            txtObservacion.Clear();
            txtPrecio.Clear();
        }

        public void bloquearCampos()
        {
            txtCodigoMantenimiento.ReadOnly = true;
            pickerFechaMantenimiento.Visible = false;
            comboEstado.Visible = false;
            txtObservacion.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            btnGuardar.Visible = false;
        }

        public void desbloquearCampos()
        {
            pickerFechaMantenimiento.Visible = true;
            comboEstado.Visible = true;
            txtObservacion.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            btnGuardar.Visible = true;
        }

        private void mostrarClientes()
        {
            this.tablaCliente.DataSource = NegocioCliente.mostrarClientes();
            //this.tablaCliente.Columns[0].Visible = false;
        }

        private void consultarClienteTabla()
        {
            this.tablaCliente.DataSource = NegocioCliente.consultarClienteTabla(this.txtCI.Text);
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarMantenimiento consulta = new FormularioConsultarMantenimiento();
            consulta.Show();
            this.Hide();
        }

        public void soloNumeros(KeyPressEventArgs evento)
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

        public void decimales(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsNumber(evento.KeyChar) || char.IsControl(evento.KeyChar) || evento.KeyChar == ',')
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioCliente.consultarClienteTabla(this.txtCI.Text);
            if (this.tablaCliente.Rows.Count != 0)
            {
                this.txtCI.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["CICLIENTE"].Value);
                this.lblClienteMostrar.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["IDCLIENTE"].Value);
                this.lblCIMostrar.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["CICLIENTE"].Value);
                this.lblNombreMostrar.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["NOMBRECLIENTE"].Value);
                this.lblDireccionMostrar.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["DIRECCIONCLIENTE"].Value);
                this.lblTelefonoFijoMostrar.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["TELEFONOFIJOCLIENTE"].Value);
                this.lblCelularMostrar.Text = Convert.ToString(this.tablaCliente.CurrentRow.Cells["TELEFONOMOVILCLIENTE"].Value);

                this.contarRegistros();
                this.desbloquearCampos();
            }

            else
            {
                this.limpiarCampos();
                MessageBox.Show("Cliente no registrado", "Registrar Manteniminento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblHoraSistemaMostrar.Text = DateTime.Now.ToString("HH:mm:ss");
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.mostrarClientes();
        }

        private void FormularioRegistrarMantenimiento_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarClientes();
            this.tablaCliente.Visible = false;
            this.tabla_aux.Visible = false;
        }

        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.comboEstado.Text == string.Empty || this.txtObservacion.Text == string.Empty || this.txtPrecio.Text == string.Empty || 
                    this.lblClienteMostrar.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioMantenimiento.insertarMantenimiento(Int32.Parse(this.lblClienteMostrar.Text), this.pickerFechaMantenimiento.Text, this.lblHoraSistemaMostrar.Text, 
                                                                            this.comboEstado.Text, this.txtObservacion.Text.ToUpper(), float.Parse(this.txtPrecio.Text));
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
                if (this.comboEstado.Text == string.Empty || this.txtObservacion.Text == string.Empty || this.txtPrecio.Text == string.Empty ||
                    this.lblClienteMostrar.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioMantenimiento.insertarMantenimiento(Int32.Parse(this.lblClienteMostrar.Text), this.pickerFechaMantenimiento.Text, this.lblHoraSistemaMostrar.Text,
                                                                            this.comboEstado.Text, this.txtObservacion.Text.ToUpper(), float.Parse(this.txtPrecio.Text));
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

        private void contarRegistros()
        {
            this.tabla_aux.DataSource = NegocioMantenimiento.contarRegistros();

            if (this.tabla_aux.Rows.Count != 0)
            {
                int var = Convert.ToInt32(this.tabla_aux.Rows[0].Cells[0].Value) + 1;
                this.txtCodigoMantenimiento.Text = Convert.ToString(var);

                desbloquearCampos();
            }

            else
            {
                this.limpiarCampos();
                MessageBox.Show("Mantenimiento no registrado", "Registrar Manteniminento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.decimales(e);
        }
    }
}
