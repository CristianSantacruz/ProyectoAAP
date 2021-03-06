﻿using System;
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
    public partial class FormularioConsultarProducto : Form
    {
        public FormularioConsultarProducto()
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRegistrarProducto nuevo = new FormularioRegistrarProducto();
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

        private void mostrarProductos()
        {
            this.tablaProducto.DataSource = NegocioProducto.mostrarProductos();
            this.tablaProducto.Columns[0].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            txtCodigo.Clear();
            lblNombreProducto.ResetText();
            lblDescripcion.ResetText();
            lblCategoria.ResetText();
            lblCantidad.ResetText();
            lblPrecioCompra.ResetText();
            lblPrecioVenta.ResetText();
            lblFechaRegistroPrecioCompra.ResetText();
            lblFechaRegistroPrecioVenta.ResetText();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioProducto.consultarProductoTabla(this.txtCodigo.Text);
            if (this.tablaProducto.Rows.Count != 0)
            {
                this.txtCodigo.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["CODIGOPRODUCTO"].Value);
                this.lblNombreProducto.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["NOMBREPRODUCTO"].Value);
                this.lblDescripcion.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["DESCRIPCIONPRODUCTO"].Value);
                this.lblCategoria.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["CATEGORIAPRODUCTO"].Value);
                this.lblCantidad.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["CANTIDADPRODUCTO"].Value);
                this.lblPrecioCompra.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["PRECIOCOMPRAPRODUCTO"].Value);
                this.lblPrecioVenta.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["PRECIOVENTAPRODUCTO"].Value);
                this.lblFechaRegistroPrecioCompra.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["FECHAREGISTROPRECIOCOMPRA"].Value);
                this.lblFechaRegistroPrecioVenta.Text = Convert.ToString(this.tablaProducto.CurrentRow.Cells["FECHAREGISTROPRECIOVENTA"].Value);
            }

            else
            {
                this.limpiarCampos();
                this.mostrarProductos();
                MessageBox.Show("Producto no registrado", "Consultar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void FormularioConsultarProducto_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarProductos();
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.codigo(e);
        }
    }
}
