namespace SFMEE_OMICROM
{
    partial class FormularioEliminarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEliminarProducto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSGFMOMICROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEliminarProducto = new System.Windows.Forms.Panel();
            this.lblFechaRegistroPrecioVenta = new System.Windows.Forms.Label();
            this.lblFechaRegistroPrecioCompra = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tablaProducto = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelEliminarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.salirToolStripMenuItem.Text = "Cerrar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteTécnicoToolStripMenuItem,
            this.acercaDeSGFMOMICROMToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // soporteTécnicoToolStripMenuItem
            // 
            this.soporteTécnicoToolStripMenuItem.Name = "soporteTécnicoToolStripMenuItem";
            this.soporteTécnicoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.soporteTécnicoToolStripMenuItem.Text = "Soporte Técnico";
            // 
            // acercaDeSGFMOMICROMToolStripMenuItem
            // 
            this.acercaDeSGFMOMICROMToolStripMenuItem.Name = "acercaDeSGFMOMICROMToolStripMenuItem";
            this.acercaDeSGFMOMICROMToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.acercaDeSGFMOMICROMToolStripMenuItem.Text = "Acerca de SGFM-OMICROM";
            // 
            // panelEliminarProducto
            // 
            this.panelEliminarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEliminarProducto.BackgroundImage")));
            this.panelEliminarProducto.Controls.Add(this.lblFechaRegistroPrecioVenta);
            this.panelEliminarProducto.Controls.Add(this.lblFechaRegistroPrecioCompra);
            this.panelEliminarProducto.Controls.Add(this.lblPrecioVenta);
            this.panelEliminarProducto.Controls.Add(this.btnRegresar);
            this.panelEliminarProducto.Controls.Add(this.btnCancelar);
            this.panelEliminarProducto.Controls.Add(this.btnEliminar);
            this.panelEliminarProducto.Controls.Add(this.lblHora);
            this.panelEliminarProducto.Controls.Add(this.btnBuscar);
            this.panelEliminarProducto.Controls.Add(this.lblPrecioCompra);
            this.panelEliminarProducto.Controls.Add(this.lblCantidad);
            this.panelEliminarProducto.Controls.Add(this.lblDescripcion);
            this.panelEliminarProducto.Controls.Add(this.lblCategoria);
            this.panelEliminarProducto.Controls.Add(this.lblNombreProducto);
            this.panelEliminarProducto.Controls.Add(this.txtCodigo);
            this.panelEliminarProducto.Location = new System.Drawing.Point(0, 27);
            this.panelEliminarProducto.Name = "panelEliminarProducto";
            this.panelEliminarProducto.Size = new System.Drawing.Size(585, 435);
            this.panelEliminarProducto.TabIndex = 6;
            // 
            // lblFechaRegistroPrecioVenta
            // 
            this.lblFechaRegistroPrecioVenta.AutoSize = true;
            this.lblFechaRegistroPrecioVenta.BackColor = System.Drawing.SystemColors.Window;
            this.lblFechaRegistroPrecioVenta.Location = new System.Drawing.Point(406, 357);
            this.lblFechaRegistroPrecioVenta.Name = "lblFechaRegistroPrecioVenta";
            this.lblFechaRegistroPrecioVenta.Size = new System.Drawing.Size(42, 13);
            this.lblFechaRegistroPrecioVenta.TabIndex = 31;
            this.lblFechaRegistroPrecioVenta.Text = "FECHA";
            // 
            // lblFechaRegistroPrecioCompra
            // 
            this.lblFechaRegistroPrecioCompra.AutoSize = true;
            this.lblFechaRegistroPrecioCompra.BackColor = System.Drawing.SystemColors.Window;
            this.lblFechaRegistroPrecioCompra.Location = new System.Drawing.Point(406, 314);
            this.lblFechaRegistroPrecioCompra.Name = "lblFechaRegistroPrecioCompra";
            this.lblFechaRegistroPrecioCompra.Size = new System.Drawing.Size(42, 13);
            this.lblFechaRegistroPrecioCompra.TabIndex = 30;
            this.lblFechaRegistroPrecioCompra.Text = "FECHA";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrecioVenta.Location = new System.Drawing.Point(170, 357);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(47, 13);
            this.lblPrecioVenta.TabIndex = 29;
            this.lblPrecioVenta.Text = "PRECIO";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(409, 391);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(40, 40);
            this.btnRegresar.TabIndex = 28;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(286, 391);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Location = new System.Drawing.Point(157, 391);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHora.Location = new System.Drawing.Point(459, 17);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 20);
            this.lblHora.TabIndex = 25;
            this.lblHora.Text = "HORA";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(478, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrecioCompra.Location = new System.Drawing.Point(170, 314);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(47, 13);
            this.lblPrecioCompra.TabIndex = 23;
            this.lblPrecioCompra.Text = "PRECIO";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.lblCantidad.Location = new System.Drawing.Point(170, 271);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 13);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "CANTIDAD";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.lblDescripcion.Location = new System.Drawing.Point(170, 182);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 13);
            this.lblDescripcion.TabIndex = 21;
            this.lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.lblCategoria.Location = new System.Drawing.Point(170, 227);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 13);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "CATEGORÍA";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombreProducto.Location = new System.Drawing.Point(170, 137);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(54, 13);
            this.lblNombreProducto.TabIndex = 19;
            this.lblNombreProducto.Text = "NOMBRE";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(173, 86);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(288, 20);
            this.txtCodigo.TabIndex = 13;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // tablaProducto
            // 
            this.tablaProducto.AllowUserToAddRows = false;
            this.tablaProducto.AllowUserToDeleteRows = false;
            this.tablaProducto.AllowUserToOrderColumns = true;
            this.tablaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProducto.Location = new System.Drawing.Point(0, 457);
            this.tablaProducto.MultiSelect = false;
            this.tablaProducto.Name = "tablaProducto";
            this.tablaProducto.ReadOnly = true;
            this.tablaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProducto.Size = new System.Drawing.Size(584, 204);
            this.tablaProducto.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormularioEliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.tablaProducto);
            this.Controls.Add(this.panelEliminarProducto);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioEliminarProducto";
            this.Text = "SFMEE-OMICROM";
            this.Load += new System.EventHandler(this.FormularioEliminarProducto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelEliminarProducto.ResumeLayout(false);
            this.panelEliminarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeSGFMOMICROMToolStripMenuItem;
        private System.Windows.Forms.Panel panelEliminarProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFechaRegistroPrecioVenta;
        private System.Windows.Forms.Label lblFechaRegistroPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.DataGridView tablaProducto;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}