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
    public partial class FormularioActualizarProducto : Form
    {
        public FormularioActualizarProducto()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
            bloquearCampos();
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Actualizar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Actualizar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FormularioRegistrarProducto nuevo = new FormularioRegistrarProducto();
            nuevo.Show();
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
            bloquearCampos();
        }

        public void limpiarCampos()
        {
            txtCodigo.Clear();
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
            txtCantidad.ReadOnly = false;
            txtPrecioCompra.ReadOnly = false;
            txtPrecioVenta.ReadOnly = false;
            btnGuardar.Visible = true;
            pickerFechaRegistroCompra.Visible = true;
            pickerFechaRegistroVenta.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioProducto.consultarProductoTabla(this.txtCodigo.Text);
            if (this.tablaProducto.Rows.Count != 0)
            {
                this.txtCodigo.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["CODIGOPRODUCTO"].Value);
                this.txtNombreProducto.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["NOMBREPRODUCTO"].Value);
                this.txtDescripcion.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["DESCRIPCIONPRODUCTO"].Value);
                this.txtCategoria.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["CATEGORIAPRODUCTO"].Value);
                this.txtCantidad.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["CANTIDADPRODUCTO"].Value);
                this.txtPrecioCompra.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["PRECIOCOMPRAPRODUCTO"].Value);
                this.txtPrecioVenta.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["PRECIOVENTAPRODUCTO"].Value);
                this.pickerFechaRegistroCompra.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["FECHAREGISTROPRECIOCOMPRA"].Value);
                this.pickerFechaRegistroVenta.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["FECHAREGISTROPRECIOVENTA"].Value);
                this.desbloquearCampos();
            }

            else
            {
                this.limpiarCampos();
                this.mostrarProductos();
                MessageBox.Show("Producto no registrado", "Actualizar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void FormularioActualizarProducto_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtCantidad.Text == string.Empty || this.txtPrecioCompra.Text == string.Empty || this.txtPrecioVenta.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioProducto.actualizarProducto(this.txtCodigo.Text.ToUpper(), Int32.Parse(this.txtCantidad.Text), float.Parse(this.txtPrecioCompra.Text),
                                                                    float.Parse(this.txtPrecioVenta.Text), this.pickerFechaRegistroCompra.Text, this.pickerFechaRegistroVenta.Text);
                    this.MensajeOK("Registro actualizado exitosamente");
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
                if (this.txtCantidad.Text == string.Empty || this.txtPrecioCompra.Text == string.Empty || this.txtPrecioVenta.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    respuesta = NegocioProducto.actualizarProducto(this.txtCodigo.Text.ToUpper(), Int32.Parse(this.txtCantidad.Text), float.Parse(this.txtPrecioCompra.Text),
                                                                    float.Parse(this.txtPrecioVenta.Text), this.pickerFechaRegistroCompra.Text, this.pickerFechaRegistroVenta.Text);
                    this.MensajeOK("Registro actualizado exitosamente");
                    this.limpiarCampos();
                    this.bloquearCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text == string.Empty)
            {
                this.btnBuscar.Visible = false;
            }
            else
            {
                this.btnBuscar.Visible = true;
            }
            this.consultarProductoTabla();
        }

        private void consultarProductoTabla()
        {
            this.tablaProducto.DataSource = NegocioProducto.consultarProductoTabla(this.txtCodigo.Text);
        }

        private void mostrarProductos()
        {
            this.tablaProducto.DataSource = NegocioProducto.mostrarProductos();
            this.tablaProducto.Columns[0].Visible = false;
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
                if (char.IsNumber(evento.KeyChar) || evento.KeyChar == ',')
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.codigo(e);
        }
    }
}
