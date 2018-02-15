namespace SFMEE_OMICROM
{
    partial class FormularioInsertarProductoFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioInsertarProductoFactura));
            this.panelConsultarProducto = new System.Windows.Forms.Panel();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblFechaRegistroPrecioVenta = new System.Windows.Forms.Label();
            this.lblFechaRegistroPrecioCompra = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tablaProducto = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadVender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelConsultarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultarProducto
            // 
            this.panelConsultarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelConsultarProducto.BackgroundImage")));
            this.panelConsultarProducto.Controls.Add(this.label3);
            this.panelConsultarProducto.Controls.Add(this.txtDescuento);
            this.panelConsultarProducto.Controls.Add(this.label2);
            this.panelConsultarProducto.Controls.Add(this.txtCantidadVender);
            this.panelConsultarProducto.Controls.Add(this.label1);
            this.panelConsultarProducto.Controls.Add(this.btnInsertar);
            this.panelConsultarProducto.Controls.Add(this.lblFechaRegistroPrecioVenta);
            this.panelConsultarProducto.Controls.Add(this.lblFechaRegistroPrecioCompra);
            this.panelConsultarProducto.Controls.Add(this.lblPrecioVenta);
            this.panelConsultarProducto.Controls.Add(this.btnBuscar);
            this.panelConsultarProducto.Controls.Add(this.btnRegresar);
            this.panelConsultarProducto.Controls.Add(this.btnCancelar);
            this.panelConsultarProducto.Controls.Add(this.lblPrecioCompra);
            this.panelConsultarProducto.Controls.Add(this.lblCantidad);
            this.panelConsultarProducto.Controls.Add(this.lblDescripcion);
            this.panelConsultarProducto.Controls.Add(this.lblCategoria);
            this.panelConsultarProducto.Controls.Add(this.lblNombreProducto);
            this.panelConsultarProducto.Controls.Add(this.lblHora);
            this.panelConsultarProducto.Controls.Add(this.txtCodigo);
            this.panelConsultarProducto.Location = new System.Drawing.Point(0, 0);
            this.panelConsultarProducto.Name = "panelConsultarProducto";
            this.panelConsultarProducto.Size = new System.Drawing.Size(585, 435);
            this.panelConsultarProducto.TabIndex = 6;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertar.BackgroundImage")));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInsertar.Location = new System.Drawing.Point(111, 390);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(40, 42);
            this.btnInsertar.TabIndex = 35;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblFechaRegistroPrecioVenta
            // 
            this.lblFechaRegistroPrecioVenta.AutoSize = true;
            this.lblFechaRegistroPrecioVenta.BackColor = System.Drawing.SystemColors.Window;
            this.lblFechaRegistroPrecioVenta.Location = new System.Drawing.Point(405, 358);
            this.lblFechaRegistroPrecioVenta.Name = "lblFechaRegistroPrecioVenta";
            this.lblFechaRegistroPrecioVenta.Size = new System.Drawing.Size(42, 13);
            this.lblFechaRegistroPrecioVenta.TabIndex = 34;
            this.lblFechaRegistroPrecioVenta.Text = "FECHA";
            // 
            // lblFechaRegistroPrecioCompra
            // 
            this.lblFechaRegistroPrecioCompra.AutoSize = true;
            this.lblFechaRegistroPrecioCompra.BackColor = System.Drawing.SystemColors.Window;
            this.lblFechaRegistroPrecioCompra.Location = new System.Drawing.Point(405, 315);
            this.lblFechaRegistroPrecioCompra.Name = "lblFechaRegistroPrecioCompra";
            this.lblFechaRegistroPrecioCompra.Size = new System.Drawing.Size(42, 13);
            this.lblFechaRegistroPrecioCompra.TabIndex = 33;
            this.lblFechaRegistroPrecioCompra.Text = "FECHA";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrecioVenta.Location = new System.Drawing.Point(169, 358);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(47, 13);
            this.lblPrecioVenta.TabIndex = 32;
            this.lblPrecioVenta.Text = "PRECIO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(481, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(411, 390);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(40, 40);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(252, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrecioCompra.Location = new System.Drawing.Point(169, 315);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(47, 13);
            this.lblPrecioCompra.TabIndex = 18;
            this.lblPrecioCompra.Text = "PRECIO";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.lblCantidad.Location = new System.Drawing.Point(169, 271);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 13);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.Text = "CANTIDAD";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.lblDescripcion.Location = new System.Drawing.Point(169, 182);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 13);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.lblCategoria.Location = new System.Drawing.Point(169, 229);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 13);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "CATEGORÍA";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombreProducto.Location = new System.Drawing.Point(169, 138);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(54, 13);
            this.lblNombreProducto.TabIndex = 14;
            this.lblNombreProducto.Text = "NOMBRE";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHora.Location = new System.Drawing.Point(487, 21);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 20);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "HORA";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(172, 86);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(289, 20);
            this.txtCodigo.TabIndex = 12;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // tablaProducto
            // 
            this.tablaProducto.AllowUserToAddRows = false;
            this.tablaProducto.AllowUserToDeleteRows = false;
            this.tablaProducto.AllowUserToOrderColumns = true;
            this.tablaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProducto.Location = new System.Drawing.Point(0, 436);
            this.tablaProducto.MultiSelect = false;
            this.tablaProducto.Name = "tablaProducto";
            this.tablaProducto.ReadOnly = true;
            this.tablaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProducto.Size = new System.Drawing.Size(584, 198);
            this.tablaProducto.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "CANTIDAD A VENDER:";
            // 
            // txtCantidadVender
            // 
            this.txtCantidadVender.Location = new System.Drawing.Point(408, 266);
            this.txtCantidadVender.MaxLength = 3;
            this.txtCantidadVender.Name = "txtCantidadVender";
            this.txtCantidadVender.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadVender.TabIndex = 37;
            this.txtCantidadVender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadVender_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "DESCUENTO:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(408, 226);
            this.txtDescuento.MaxLength = 3;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(53, 20);
            this.txtDescuento.TabIndex = 39;
            this.txtDescuento.Text = "0";
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "%";
            // 
            // FormularioInsertarProductoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 636);
            this.Controls.Add(this.tablaProducto);
            this.Controls.Add(this.panelConsultarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioInsertarProductoFactura";
            this.Text = "FormularioInsertarProductoFactura";
            this.Load += new System.EventHandler(this.FormularioInsertarProductoFactura_Load);
            this.panelConsultarProducto.ResumeLayout(false);
            this.panelConsultarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelConsultarProducto;
        private System.Windows.Forms.Label lblFechaRegistroPrecioVenta;
        private System.Windows.Forms.Label lblFechaRegistroPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView tablaProducto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtCantidadVender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}