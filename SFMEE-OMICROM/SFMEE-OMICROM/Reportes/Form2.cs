using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFMEE_OMICROM

{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int IDFACTURA { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.preporte_factura' Puede moverla o quitarla según sea necesario.
            this.preporte_facturaTableAdapter.Fill(this.DataSet2.preporte_factura,IDFACTURA);
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spreporte_venta' Puede moverla o quitarla según sea necesario.
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
