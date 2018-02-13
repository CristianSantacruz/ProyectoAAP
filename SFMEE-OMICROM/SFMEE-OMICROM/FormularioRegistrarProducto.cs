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
    public partial class FormularioRegistrarProducto : Form
    {
        public FormularioRegistrarProducto()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearCampos();
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Registrar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registrar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioActualizarProducto actualizar = new FormularioActualizarProducto();
            actualizar.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEliminarProducto eliminar = new FormularioEliminarProducto();
            eliminar.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            txtNombreProducto.Clear();
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtCategoria.Clear();
            txtCantidad.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
        }

        public void bloquearCampos()
        {
            txtNombreProducto.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            txtCategoria.ReadOnly = true;
            txtCantidad.ReadOnly = true;
            txtPrecioCompra.ReadOnly = true;
            txtPrecioVenta.ReadOnly = true;
            btnGuardar.Visible = false;
            pickerFechaRegistroCompra.Visible = false;
            pickerFechaRegistroVenta.Visible = false;
        }

        public void desbloquearCampos()
        {
            txtNombreProducto.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            txtCategoria.ReadOnly = false;
            txtCantidad.ReadOnly = false;
            txtPrecioCompra.ReadOnly = false;
            txtPrecioVenta.ReadOnly = false;
            btnGuardar.Visible = true;
            pickerFechaRegistroCompra.Visible = true;
            pickerFechaRegistroVenta.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tablaProducto = NegocioProducto.consultarProductoTabla(this.txtCodigo.Text);
            if (tablaProducto.Rows.Count == 0)
            {
                desbloquearCampos();
            }
            else
            {
                MessageBox.Show("Producto ya registrado", "Registrar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultarProducto consulta = new FormularioConsultarProducto();
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
                if (this.txtCodigo.Text == string.Empty || this.txtNombreProducto.Text == string.Empty || this.txtDescripcion.Text == string.Empty || this.txtCategoria.Text == string.Empty || this.txtCantidad.Text == string.Empty || 
                    this.txtPrecioCompra.Text == string.Empty || this.txtPrecioVenta.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioProducto.insertarProducto(this.txtCodigo.Text.ToUpper(), this.txtNombreProducto.Text.ToUpper(), this.txtDescripcion.Text.ToUpper(), this.txtCategoria.Text.ToUpper(), Int32.Parse(this.txtCantidad.Text), 
                                                                 float.Parse(this.txtPrecioCompra.Text), float.Parse(this.txtPrecioVenta.Text), this.pickerFechaRegistroCompra.Text, this.pickerFechaRegistroVenta.Text);
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
                if (this.txtCodigo.Text == string.Empty || this.txtNombreProducto.Text == string.Empty || this.txtDescripcion.Text == string.Empty || this.txtCategoria.Text == string.Empty || this.txtCantidad.Text == string.Empty ||
                    this.txtPrecioCompra.Text == string.Empty || this.txtPrecioVenta.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioProducto.insertarProducto(this.txtCodigo.Text.ToUpper(), this.txtNombreProducto.Text.ToUpper(), this.txtDescripcion.Text.ToUpper(), this.txtCategoria.Text.ToUpper(), Int32.Parse(this.txtCantidad.Text),
                                                                 float.Parse(this.txtPrecioCompra.Text), float.Parse(this.txtPrecioVenta.Text), this.pickerFechaRegistroCompra.Text, this.pickerFechaRegistroVenta.Text);
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

        private void soloLetras(KeyPressEventArgs evento)
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

        private void codigo(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsLetter(evento.KeyChar) || char.IsNumber(evento.KeyChar) || char.IsControl(evento.KeyChar))
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

        private void descripcion(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsLetter(evento.KeyChar) || evento.KeyChar == '-' || evento.KeyChar == '.' || evento.KeyChar == ','|| char.IsNumber(evento.KeyChar) || char.IsControl(evento.KeyChar) || char.IsSeparator(evento.KeyChar))
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

        public void cantidad(KeyPressEventArgs evento)
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

        public void decimales(KeyPressEventArgs evento)
        {
            try
            {
                if (char.IsNumber(evento.KeyChar) || evento.KeyChar== ',')
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.codigo(e);
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloLetras(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.descripcion(e);
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloLetras(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.cantidad(e);
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.decimales(e);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.decimales(e);
        }
    }
}
