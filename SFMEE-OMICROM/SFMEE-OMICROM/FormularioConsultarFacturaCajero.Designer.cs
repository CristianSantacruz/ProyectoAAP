namespace SFMEE_OMICROM
{
    partial class FormularioConsultarFacturaCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioConsultarFacturaCajero));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSGFMOMICROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelNuevaFactura = new System.Windows.Forms.Panel();
            this.tablaFactura = new System.Windows.Forms.DataGridView();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblTipoPagoMostrar = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblCajero = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.lblIVAValor = new System.Windows.Forms.Label();
            this.lblDescuentoValor = new System.Windows.Forms.Label();
            this.lblSubTotalValor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablaDetalle = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grupoCliente = new System.Windows.Forms.GroupBox();
            this.lblCelularMostrar = new System.Windows.Forms.Label();
            this.lblTelefonoFijoMostrar = new System.Windows.Forms.Label();
            this.lblDireccionMostrar = new System.Windows.Forms.Label();
            this.lblCIMostrar = new System.Windows.Forms.Label();
            this.lblNombreMostrar = new System.Windows.Forms.Label();
            this.lblClienteMostrar = new System.Windows.Forms.Label();
            this.lblCI = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefonoFijo = new System.Windows.Forms.Label();
            this.lblTelefonoMovil = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelNuevaFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFactura)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetalle)).BeginInit();
            this.grupoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.consultarToolStripMenuItem.Text = "Nuevo";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salirToolStripMenuItem.Text = "Cerrar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
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
            // panelNuevaFactura
            // 
            this.panelNuevaFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelNuevaFactura.BackgroundImage")));
            this.panelNuevaFactura.Controls.Add(this.tablaFactura);
            this.panelNuevaFactura.Controls.Add(this.lblHora);
            this.panelNuevaFactura.Controls.Add(this.lblTipoPagoMostrar);
            this.panelNuevaFactura.Controls.Add(this.txtNumeroFactura);
            this.panelNuevaFactura.Controls.Add(this.lblCajero);
            this.panelNuevaFactura.Controls.Add(this.lblFecha);
            this.panelNuevaFactura.Controls.Add(this.btnBuscar);
            this.panelNuevaFactura.Controls.Add(this.btnImprimir);
            this.panelNuevaFactura.Controls.Add(this.lblTipoPago);
            this.panelNuevaFactura.Controls.Add(this.panel2);
            this.panelNuevaFactura.Controls.Add(this.panel1);
            this.panelNuevaFactura.Controls.Add(this.btnRegresar);
            this.panelNuevaFactura.Controls.Add(this.btnCancelar);
            this.panelNuevaFactura.Controls.Add(this.grupoCliente);
            this.panelNuevaFactura.Location = new System.Drawing.Point(0, 27);
            this.panelNuevaFactura.Name = "panelNuevaFactura";
            this.panelNuevaFactura.Size = new System.Drawing.Size(1234, 636);
            this.panelNuevaFactura.TabIndex = 9;
            // 
            // tablaFactura
            // 
            this.tablaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFactura.Location = new System.Drawing.Point(50, 593);
            this.tablaFactura.Name = "tablaFactura";
            this.tablaFactura.Size = new System.Drawing.Size(110, 29);
            this.tablaFactura.TabIndex = 1;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHora.Location = new System.Drawing.Point(1082, 21);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 20);
            this.lblHora.TabIndex = 27;
            this.lblHora.Text = "HORA";
            // 
            // lblTipoPagoMostrar
            // 
            this.lblTipoPagoMostrar.AutoSize = true;
            this.lblTipoPagoMostrar.BackColor = System.Drawing.SystemColors.Window;
            this.lblTipoPagoMostrar.Location = new System.Drawing.Point(164, 488);
            this.lblTipoPagoMostrar.Name = "lblTipoPagoMostrar";
            this.lblTipoPagoMostrar.Size = new System.Drawing.Size(83, 13);
            this.lblTipoPagoMostrar.TabIndex = 43;
            this.lblTipoPagoMostrar.Text = "TIPO DE PAGO";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumeroFactura.Location = new System.Drawing.Point(210, 81);
            this.txtNumeroFactura.MaxLength = 6;
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(137, 20);
            this.txtNumeroFactura.TabIndex = 42;
            this.txtNumeroFactura.TextChanged += new System.EventHandler(this.txtNumeroFactura_TextChanged);
            this.txtNumeroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroFactura_KeyPress);
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.BackColor = System.Drawing.SystemColors.Window;
            this.lblCajero.Location = new System.Drawing.Point(415, 122);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(49, 13);
            this.lblCajero.TabIndex = 41;
            this.lblCajero.Text = "CAJERO";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.Window;
            this.lblFecha.Location = new System.Drawing.Point(101, 122);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 40;
            this.lblFecha.Text = "FECHA";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(353, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Location = new System.Drawing.Point(363, 587);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(40, 40);
            this.btnImprimir.TabIndex = 38;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.BackColor = System.Drawing.Color.White;
            this.lblTipoPago.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTipoPago.Location = new System.Drawing.Point(42, 484);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(118, 18);
            this.lblTipoPago.TabIndex = 34;
            this.lblTipoPago.Text = "TIPO DE PAGO:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblTotalValor);
            this.panel2.Controls.Add(this.lblIVAValor);
            this.panel2.Controls.Add(this.lblDescuentoValor);
            this.panel2.Controls.Add(this.lblSubTotalValor);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblIVA);
            this.panel2.Controls.Add(this.lblDescuento);
            this.panel2.Controls.Add(this.lblSubTotal);
            this.panel2.Location = new System.Drawing.Point(928, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 100);
            this.panel2.TabIndex = 14;
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalValor.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotalValor.Location = new System.Drawing.Point(155, 74);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(51, 18);
            this.lblTotalValor.TabIndex = 33;
            this.lblTotalValor.Text = "00,00";
            // 
            // lblIVAValor
            // 
            this.lblIVAValor.AutoSize = true;
            this.lblIVAValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIVAValor.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVAValor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIVAValor.Location = new System.Drawing.Point(155, 53);
            this.lblIVAValor.Name = "lblIVAValor";
            this.lblIVAValor.Size = new System.Drawing.Size(51, 18);
            this.lblIVAValor.TabIndex = 32;
            this.lblIVAValor.Text = "00,00";
            // 
            // lblDescuentoValor
            // 
            this.lblDescuentoValor.AutoSize = true;
            this.lblDescuentoValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescuentoValor.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoValor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDescuentoValor.Location = new System.Drawing.Point(155, 32);
            this.lblDescuentoValor.Name = "lblDescuentoValor";
            this.lblDescuentoValor.Size = new System.Drawing.Size(51, 18);
            this.lblDescuentoValor.TabIndex = 31;
            this.lblDescuentoValor.Text = "00,00";
            // 
            // lblSubTotalValor
            // 
            this.lblSubTotalValor.AutoSize = true;
            this.lblSubTotalValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTotalValor.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalValor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSubTotalValor.Location = new System.Drawing.Point(155, 10);
            this.lblSubTotalValor.Name = "lblSubTotalValor";
            this.lblSubTotalValor.Size = new System.Drawing.Size(51, 18);
            this.lblSubTotalValor.TabIndex = 30;
            this.lblSubTotalValor.Text = "00,00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotal.Location = new System.Drawing.Point(68, 74);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 18);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIVA.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIVA.Location = new System.Drawing.Point(91, 53);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(36, 18);
            this.lblIVA.TabIndex = 28;
            this.lblIVA.Text = "IVA:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescuento.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDescuento.Location = new System.Drawing.Point(28, 32);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(99, 18);
            this.lblDescuento.TabIndex = 27;
            this.lblDescuento.Text = "DESCUENTO:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTotal.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSubTotal.Location = new System.Drawing.Point(34, 10);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(93, 18);
            this.lblSubTotal.TabIndex = 26;
            this.lblSubTotal.Text = "SUB-TOTAL:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tablaDetalle);
            this.panel1.Location = new System.Drawing.Point(42, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 177);
            this.panel1.TabIndex = 13;
            // 
            // tablaDetalle
            // 
            this.tablaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDetalle.Location = new System.Drawing.Point(3, 3);
            this.tablaDetalle.Name = "tablaDetalle";
            this.tablaDetalle.Size = new System.Drawing.Size(1143, 170);
            this.tablaDetalle.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(729, 587);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(40, 40);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(560, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grupoCliente
            // 
            this.grupoCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grupoCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grupoCliente.BackgroundImage")));
            this.grupoCliente.Controls.Add(this.lblCelularMostrar);
            this.grupoCliente.Controls.Add(this.lblTelefonoFijoMostrar);
            this.grupoCliente.Controls.Add(this.lblDireccionMostrar);
            this.grupoCliente.Controls.Add(this.lblCIMostrar);
            this.grupoCliente.Controls.Add(this.lblNombreMostrar);
            this.grupoCliente.Controls.Add(this.lblClienteMostrar);
            this.grupoCliente.Controls.Add(this.lblCI);
            this.grupoCliente.Controls.Add(this.lblDireccion);
            this.grupoCliente.Controls.Add(this.lblTelefonoFijo);
            this.grupoCliente.Controls.Add(this.lblTelefonoMovil);
            this.grupoCliente.Controls.Add(this.lblNombreCliente);
            this.grupoCliente.Controls.Add(this.lblCodigoCliente);
            this.grupoCliente.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.grupoCliente.Location = new System.Drawing.Point(42, 149);
            this.grupoCliente.Name = "grupoCliente";
            this.grupoCliente.Size = new System.Drawing.Size(546, 130);
            this.grupoCliente.TabIndex = 1;
            this.grupoCliente.TabStop = false;
            this.grupoCliente.Text = "CLIENTE";
            // 
            // lblCelularMostrar
            // 
            this.lblCelularMostrar.AutoSize = true;
            this.lblCelularMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCelularMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCelularMostrar.Location = new System.Drawing.Point(119, 110);
            this.lblCelularMostrar.Name = "lblCelularMostrar";
            this.lblCelularMostrar.Size = new System.Drawing.Size(95, 13);
            this.lblCelularMostrar.TabIndex = 24;
            this.lblCelularMostrar.Text = "TELÉFONO MÓVIL";
            // 
            // lblTelefonoFijoMostrar
            // 
            this.lblTelefonoFijoMostrar.AutoSize = true;
            this.lblTelefonoFijoMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefonoFijoMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoFijoMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTelefonoFijoMostrar.Location = new System.Drawing.Point(119, 93);
            this.lblTelefonoFijoMostrar.Name = "lblTelefonoFijoMostrar";
            this.lblTelefonoFijoMostrar.Size = new System.Drawing.Size(83, 13);
            this.lblTelefonoFijoMostrar.TabIndex = 23;
            this.lblTelefonoFijoMostrar.Text = "TELÉFONO FIJO";
            // 
            // lblDireccionMostrar
            // 
            this.lblDireccionMostrar.AutoSize = true;
            this.lblDireccionMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDireccionMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDireccionMostrar.Location = new System.Drawing.Point(119, 77);
            this.lblDireccionMostrar.Name = "lblDireccionMostrar";
            this.lblDireccionMostrar.Size = new System.Drawing.Size(61, 13);
            this.lblDireccionMostrar.TabIndex = 22;
            this.lblDireccionMostrar.Text = "DIRECCIÓN";
            // 
            // lblCIMostrar
            // 
            this.lblCIMostrar.AutoSize = true;
            this.lblCIMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCIMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCIMostrar.Location = new System.Drawing.Point(119, 60);
            this.lblCIMostrar.Name = "lblCIMostrar";
            this.lblCIMostrar.Size = new System.Drawing.Size(44, 13);
            this.lblCIMostrar.TabIndex = 21;
            this.lblCIMostrar.Text = "C.I./RUC";
            // 
            // lblNombreMostrar
            // 
            this.lblNombreMostrar.AutoSize = true;
            this.lblNombreMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombreMostrar.Location = new System.Drawing.Point(119, 43);
            this.lblNombreMostrar.Name = "lblNombreMostrar";
            this.lblNombreMostrar.Size = new System.Drawing.Size(51, 13);
            this.lblNombreMostrar.TabIndex = 20;
            this.lblNombreMostrar.Text = "NOMBRE";
            // 
            // lblClienteMostrar
            // 
            this.lblClienteMostrar.AutoSize = true;
            this.lblClienteMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClienteMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClienteMostrar.Location = new System.Drawing.Point(119, 22);
            this.lblClienteMostrar.Name = "lblClienteMostrar";
            this.lblClienteMostrar.Size = new System.Drawing.Size(48, 13);
            this.lblClienteMostrar.TabIndex = 19;
            this.lblClienteMostrar.Text = "CLIENTE";
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCI.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCI.Location = new System.Drawing.Point(67, 60);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(46, 13);
            this.lblCI.TabIndex = 18;
            this.lblCI.Text = "C.I./RUC:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDireccion.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDireccion.Location = new System.Drawing.Point(50, 77);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 13);
            this.lblDireccion.TabIndex = 17;
            this.lblDireccion.Text = "DIRECCIÓN:";
            // 
            // lblTelefonoFijo
            // 
            this.lblTelefonoFijo.AutoSize = true;
            this.lblTelefonoFijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefonoFijo.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoFijo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTelefonoFijo.Location = new System.Drawing.Point(28, 93);
            this.lblTelefonoFijo.Name = "lblTelefonoFijo";
            this.lblTelefonoFijo.Size = new System.Drawing.Size(85, 13);
            this.lblTelefonoFijo.TabIndex = 16;
            this.lblTelefonoFijo.Text = "TELÉFONO FIJO:";
            // 
            // lblTelefonoMovil
            // 
            this.lblTelefonoMovil.AutoSize = true;
            this.lblTelefonoMovil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefonoMovil.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoMovil.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTelefonoMovil.Location = new System.Drawing.Point(16, 110);
            this.lblTelefonoMovil.Name = "lblTelefonoMovil";
            this.lblTelefonoMovil.Size = new System.Drawing.Size(97, 13);
            this.lblTelefonoMovil.TabIndex = 15;
            this.lblTelefonoMovil.Text = "TELÉFONO MÓVIL:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreCliente.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombreCliente.Location = new System.Drawing.Point(60, 43);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(53, 13);
            this.lblNombreCliente.TabIndex = 14;
            this.lblNombreCliente.Text = "NOMBRE:";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCodigoCliente.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCodigoCliente.Location = new System.Drawing.Point(63, 22);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(50, 13);
            this.lblCodigoCliente.TabIndex = 9;
            this.lblCodigoCliente.Text = "CLIENTE:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormularioConsultarFacturaCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 661);
            this.Controls.Add(this.panelNuevaFactura);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioConsultarFacturaCajero";
            this.Text = "SFMEE-OMICROM";
            this.Load += new System.EventHandler(this.FormularioConsultarFacturaCajero_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelNuevaFactura.ResumeLayout(false);
            this.panelNuevaFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFactura)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetalle)).EndInit();
            this.grupoCliente.ResumeLayout(false);
            this.grupoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeSGFMOMICROMToolStripMenuItem;
        private System.Windows.Forms.Panel panelNuevaFactura;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Label lblIVAValor;
        private System.Windows.Forms.Label lblDescuentoValor;
        private System.Windows.Forms.Label lblSubTotalValor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaDetalle;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grupoCliente;
        private System.Windows.Forms.Label lblCelularMostrar;
        private System.Windows.Forms.Label lblTelefonoFijoMostrar;
        private System.Windows.Forms.Label lblDireccionMostrar;
        private System.Windows.Forms.Label lblCIMostrar;
        private System.Windows.Forms.Label lblNombreMostrar;
        private System.Windows.Forms.Label lblClienteMostrar;
        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefonoFijo;
        private System.Windows.Forms.Label lblTelefonoMovil;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTipoPagoMostrar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView tablaFactura;
    }
}