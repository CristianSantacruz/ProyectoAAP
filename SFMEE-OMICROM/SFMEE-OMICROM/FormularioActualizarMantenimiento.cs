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
    public partial class FormularioActualizarMantenimiento : Form
    {
        public FormularioActualizarMantenimiento()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearCampos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InterfazPrincipalTecnico tecnico = new InterfazPrincipalTecnico();
            tecnico.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipalTecnico tecnico = new InterfazPrincipalTecnico();
            tecnico.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            bloquearCampos();
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Actualizar Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Actualizar Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void bloquearCampos()
        {
            comboEstado.Visible = false;
            txtObservacion.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            btnGuardar.Visible = false;
        }

        public void desbloquearCampos()
        {
            comboEstado.Visible = true;
            txtObservacion.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            btnGuardar.Visible = true;
        }

        public void LimpiarCampos()
        {
            txtCodigoMantenimiento.Clear();
            lblClienteMostrar.ResetText();
            lblCIMostrar.ResetText();
            lblNombreMostrar.ResetText();
            lblDireccionMostrar.ResetText();
            lblTelefonoFijoMostrar.ResetText();
            lblCelularMostrar.ResetText();

            lblFechaMantenimientoMostrar.ResetText();
            lblHoraMantenimientoMostrar.ResetText();
            txtObservacion.Clear();
            txtPrecio.Clear();
        }

        private void mostrarMantenimientos()
        {
            this.tablaMantenimiento.DataSource = NegocioMantenimiento.mostrarMantenimientos();
        }

        private void consultarMantenimientoTabla()
        {
            if (this.txtCodigoMantenimiento.Text == string.Empty)
            {
                this.tablaMantenimiento.DataSource = NegocioMantenimiento.consultarMantenimientoTabla(0);
            }
            else
            {
                this.tablaMantenimiento.DataSource = NegocioMantenimiento.consultarMantenimientoTabla(int.Parse(this.txtCodigoMantenimiento.Text));
            }

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
                if (char.IsNumber(evento.KeyChar) || char.IsControl(evento.KeyChar) || evento.KeyChar==',')
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
            NegocioMantenimiento.consultarMantenimientoTabla(int.Parse(this.txtCodigoMantenimiento.Text));
            if (this.tablaMantenimiento.Rows.Count != 0)
            {
                this.lblClienteMostrar.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["IDCLIENTE"].Value);
                this.lblCIMostrar.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["CICLIENTE"].Value);
                this.lblNombreMostrar.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["NOMBRECLIENTE"].Value);
                this.lblDireccionMostrar.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["DIRECCIONCLIENTE"].Value);
                this.lblTelefonoFijoMostrar.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["TELEFONOFIJOCLIENTE"].Value);
                this.lblCelularMostrar.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["TELEFONOMOVILCLIENTE"].Value);
                this.lblFechaMantenimientoMostrar.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["FECHAMANTENIMIENTO"].Value);
                this.lblHoraMantenimientoMostrar.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["HORAMANTENIMIENTO"].Value);
                this.comboEstado.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["ESTADOMANTENIMIENTO"].Value);
                this.txtObservacion.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["OBSERVACIONMANTENIMIENTO"].Value);
                this.txtPrecio.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["PRECIOMANTENIMIENTO"].Value);
                desbloquearCampos();
            }

            else
            {
                this.LimpiarCampos();
                this.mostrarMantenimientos();
                MessageBox.Show("Mantenimiento no registrado", "Consultar Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultaMantenimientoTecnico consulta = new FormularioConsultaMantenimientoTecnico();
            consulta.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void txtCodigoMantenimiento_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCodigoMantenimiento.Text == string.Empty)
            {
                this.btnBuscar.Visible = false;
            }
            else
            {
                this.btnBuscar.Visible = true;
            }
            this.consultarMantenimientoTabla();
        }

        private void txtCodigoMantenimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e);
        }

        private void FormularioActualizarMantenimiento_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarMantenimientos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtCodigoMantenimiento.Text == string.Empty || this.comboEstado.Text == string.Empty || this.txtObservacion.Text == string.Empty || this.txtPrecio.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioMantenimiento.actualizarMantenimiento(Int32.Parse(this.txtCodigoMantenimiento.Text.Trim()), this.comboEstado.Text, 
                                                                             this.txtObservacion.Text.ToUpper(), float.Parse(this.txtPrecio.Text));
                    this.MensajeOK("Registro actualizado exitosamente");
                    this.LimpiarCampos();
                    this.bloquearCampos();
                    this.mostrarMantenimientos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.decimales(e);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtCodigoMantenimiento.Text == string.Empty || this.comboEstado.Text == string.Empty || this.txtObservacion.Text == string.Empty || this.txtPrecio.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioMantenimiento.actualizarMantenimiento(Int32.Parse(this.txtCodigoMantenimiento.Text.Trim()), this.comboEstado.Text,
                                                                             this.txtObservacion.Text.ToUpper(), float.Parse(this.txtPrecio.Text));
                    this.MensajeOK("Registro actualizado exitosamente");
                    this.bloquearCampos();
                    this.mostrarMantenimientos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
