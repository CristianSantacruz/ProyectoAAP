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
    public partial class FormularioInsertarMantenimientoFactura : Form
    {
        public FormularioInsertarMantenimientoFactura()
        {
            InitializeComponent();
            this.CenterToScreen();
            timer1.Enabled = true;
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

        public void limpiarCampos()
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
            lblEstadoMantenimientoMostrar.ResetText();
            lblObservacionMantenimientoMostrar.ResetText();
            lblPrecioMantenimientoMostrar.ResetText();
        }

        private void FormularioInsertarMantenimientoFactura_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Visible = false;
            this.mostrarMantenimientos();
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
                this.lblEstadoMantenimientoMostrar.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["ESTADOMANTENIMIENTO"].Value);
                this.lblObservacionMantenimientoMostrar.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["OBSERVACIONMANTENIMIENTO"].Value);
                this.lblPrecioMantenimientoMostrar.Text = Convert.ToString(this.tablaMantenimiento.CurrentRow.Cells["PRECIOMANTENIMIENTO"].Value);

            }

            else
            {
                this.limpiarCampos();
                this.mostrarMantenimientos();
                MessageBox.Show("Mantenimiento no registrado", "Consultar Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarCampos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigoMantenimiento.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar algunos campos", "Ingresar Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormularioNueva_FacturaVenta factura = new FormularioNueva_FacturaVenta();
                DataRow row = FormularioNueva_FacturaVenta.tablaDetalle.NewRow();
                row["IDFACTURA"] = Convert.ToInt32(factura.lblNumeroFacturaVenta.Text);
                row["IDPRODUCTO"]=1;
                row["IDMANTENIMIENTO"] = Convert.ToInt32(this.txtCodigoMantenimiento.Text);
                row["CÓDIGO"] = this.txtCodigoMantenimiento.Text;
                row["CANTIDAD"] = 1;
                row["DETALLE"] = this.lblObservacionMantenimientoMostrar.Text;
                row["VALOR UNITARIO"] = float.Parse(this.lblPrecioMantenimientoMostrar.Text);
                row["DESCUENTO"] = 0;
                row["VALOR TOTAL"] = float.Parse(this.lblPrecioMantenimientoMostrar.Text) * float.Parse(row["CANTIDAD"].ToString());
                FormularioNueva_FacturaVenta.tablaDetalle.Rows.Add(row);

                this.Hide();
            }
        }
    }
}
