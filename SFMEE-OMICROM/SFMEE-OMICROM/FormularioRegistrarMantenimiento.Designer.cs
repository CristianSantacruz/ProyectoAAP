namespace SFMEE_OMICROM
{
    partial class FormularioRegistrarMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRegistrarMantenimiento));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSGFMOMICROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRegistrarMantenimiento = new System.Windows.Forms.Panel();
            this.grupoMantenimiento = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblHoraSistemaMostrar = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.pickerFechaMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.lblHoraSistema = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCelularMostrar = new System.Windows.Forms.Label();
            this.lblTelefonoFijoMostrar = new System.Windows.Forms.Label();
            this.lblDireccionMostrar = new System.Windows.Forms.Label();
            this.lblCIMostrar = new System.Windows.Forms.Label();
            this.lblNombreMostrar = new System.Windows.Forms.Label();
            this.lblClienteMostrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTelefonoMovil = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.txtCodigoMantenimiento = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelRegistrarMantenimiento.SuspendLayout();
            this.grupoMantenimiento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
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
            // panelRegistrarMantenimiento
            // 
            this.panelRegistrarMantenimiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRegistrarMantenimiento.BackgroundImage")));
            this.panelRegistrarMantenimiento.Controls.Add(this.grupoMantenimiento);
            this.panelRegistrarMantenimiento.Controls.Add(this.groupBox1);
            this.panelRegistrarMantenimiento.Controls.Add(this.txtCodigoMantenimiento);
            this.panelRegistrarMantenimiento.Controls.Add(this.lblHora);
            this.panelRegistrarMantenimiento.Controls.Add(this.txtCI);
            this.panelRegistrarMantenimiento.Controls.Add(this.btnBuscar);
            this.panelRegistrarMantenimiento.Controls.Add(this.btnRegresar);
            this.panelRegistrarMantenimiento.Controls.Add(this.btnCancelar);
            this.panelRegistrarMantenimiento.Controls.Add(this.btnGuardar);
            this.panelRegistrarMantenimiento.Location = new System.Drawing.Point(0, 27);
            this.panelRegistrarMantenimiento.Name = "panelRegistrarMantenimiento";
            this.panelRegistrarMantenimiento.Size = new System.Drawing.Size(785, 535);
            this.panelRegistrarMantenimiento.TabIndex = 5;
            // 
            // grupoMantenimiento
            // 
            this.grupoMantenimiento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grupoMantenimiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grupoMantenimiento.BackgroundImage")));
            this.grupoMantenimiento.Controls.Add(this.txtPrecio);
            this.grupoMantenimiento.Controls.Add(this.lblHoraSistemaMostrar);
            this.grupoMantenimiento.Controls.Add(this.txtObservacion);
            this.grupoMantenimiento.Controls.Add(this.pickerFechaMantenimiento);
            this.grupoMantenimiento.Controls.Add(this.comboEstado);
            this.grupoMantenimiento.Controls.Add(this.lblHoraSistema);
            this.grupoMantenimiento.Controls.Add(this.lblObservacion);
            this.grupoMantenimiento.Controls.Add(this.lblPrecio);
            this.grupoMantenimiento.Controls.Add(this.lblEstado);
            this.grupoMantenimiento.Controls.Add(this.lblFecha);
            this.grupoMantenimiento.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoMantenimiento.ForeColor = System.Drawing.SystemColors.Window;
            this.grupoMantenimiento.Location = new System.Drawing.Point(12, 296);
            this.grupoMantenimiento.Name = "grupoMantenimiento";
            this.grupoMantenimiento.Size = new System.Drawing.Size(760, 177);
            this.grupoMantenimiento.TabIndex = 25;
            this.grupoMantenimiento.TabStop = false;
            this.grupoMantenimiento.Text = "MANTENIMIENTO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(208, 140);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(67, 24);
            this.txtPrecio.TabIndex = 16;
            // 
            // lblHoraSistemaMostrar
            // 
            this.lblHoraSistemaMostrar.AutoSize = true;
            this.lblHoraSistemaMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHoraSistemaMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSistemaMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHoraSistemaMostrar.Location = new System.Drawing.Point(529, 28);
            this.lblHoraSistemaMostrar.Name = "lblHoraSistemaMostrar";
            this.lblHoraSistemaMostrar.Size = new System.Drawing.Size(117, 15);
            this.lblHoraSistemaMostrar.TabIndex = 21;
            this.lblHoraSistemaMostrar.Text = "HORA DEL SISTEMA";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(208, 98);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(429, 30);
            this.txtObservacion.TabIndex = 3;
            // 
            // pickerFechaMantenimiento
            // 
            this.pickerFechaMantenimiento.Location = new System.Drawing.Point(210, 20);
            this.pickerFechaMantenimiento.Name = "pickerFechaMantenimiento";
            this.pickerFechaMantenimiento.Size = new System.Drawing.Size(200, 24);
            this.pickerFechaMantenimiento.TabIndex = 4;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(210, 57);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(200, 26);
            this.comboEstado.TabIndex = 2;
            // 
            // lblHoraSistema
            // 
            this.lblHoraSistema.AutoSize = true;
            this.lblHoraSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHoraSistema.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSistema.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHoraSistema.Location = new System.Drawing.Point(461, 25);
            this.lblHoraSistema.Name = "lblHoraSistema";
            this.lblHoraSistema.Size = new System.Drawing.Size(54, 18);
            this.lblHoraSistema.TabIndex = 18;
            this.lblHoraSistema.Text = "HORA:";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblObservacion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblObservacion.Location = new System.Drawing.Point(93, 101);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(112, 18);
            this.lblObservacion.TabIndex = 17;
            this.lblObservacion.Text = "OBSERVACIÓN:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrecio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrecio.Location = new System.Drawing.Point(139, 143);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 18);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "PRECIO:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstado.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEstado.Location = new System.Drawing.Point(139, 58);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 18);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "ESTADO:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFecha.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFecha.Location = new System.Drawing.Point(144, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 18);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "FECHA:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.lblCelularMostrar);
            this.groupBox1.Controls.Add(this.lblTelefonoFijoMostrar);
            this.groupBox1.Controls.Add(this.lblDireccionMostrar);
            this.groupBox1.Controls.Add(this.lblCIMostrar);
            this.groupBox1.Controls.Add(this.lblNombreMostrar);
            this.groupBox1.Controls.Add(this.lblClienteMostrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTelefonoMovil);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.lblCodigoCliente);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 162);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            // 
            // lblCelularMostrar
            // 
            this.lblCelularMostrar.AutoSize = true;
            this.lblCelularMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCelularMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCelularMostrar.Location = new System.Drawing.Point(529, 122);
            this.lblCelularMostrar.Name = "lblCelularMostrar";
            this.lblCelularMostrar.Size = new System.Drawing.Size(108, 15);
            this.lblCelularMostrar.TabIndex = 24;
            this.lblCelularMostrar.Text = "TELÉFONO MÓVIL";
            // 
            // lblTelefonoFijoMostrar
            // 
            this.lblTelefonoFijoMostrar.AutoSize = true;
            this.lblTelefonoFijoMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefonoFijoMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoFijoMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTelefonoFijoMostrar.Location = new System.Drawing.Point(245, 122);
            this.lblTelefonoFijoMostrar.Name = "lblTelefonoFijoMostrar";
            this.lblTelefonoFijoMostrar.Size = new System.Drawing.Size(93, 15);
            this.lblTelefonoFijoMostrar.TabIndex = 23;
            this.lblTelefonoFijoMostrar.Text = "TELÉFONO FIJO";
            // 
            // lblDireccionMostrar
            // 
            this.lblDireccionMostrar.AutoSize = true;
            this.lblDireccionMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDireccionMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDireccionMostrar.Location = new System.Drawing.Point(245, 93);
            this.lblDireccionMostrar.Name = "lblDireccionMostrar";
            this.lblDireccionMostrar.Size = new System.Drawing.Size(69, 15);
            this.lblDireccionMostrar.TabIndex = 22;
            this.lblDireccionMostrar.Text = "DIRECCIÓN";
            // 
            // lblCIMostrar
            // 
            this.lblCIMostrar.AutoSize = true;
            this.lblCIMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCIMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCIMostrar.Location = new System.Drawing.Point(529, 28);
            this.lblCIMostrar.Name = "lblCIMostrar";
            this.lblCIMostrar.Size = new System.Drawing.Size(51, 15);
            this.lblCIMostrar.TabIndex = 21;
            this.lblCIMostrar.Text = "C.I./RUC";
            // 
            // lblNombreMostrar
            // 
            this.lblNombreMostrar.AutoSize = true;
            this.lblNombreMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombreMostrar.Location = new System.Drawing.Point(245, 61);
            this.lblNombreMostrar.Name = "lblNombreMostrar";
            this.lblNombreMostrar.Size = new System.Drawing.Size(58, 15);
            this.lblNombreMostrar.TabIndex = 20;
            this.lblNombreMostrar.Text = "NOMBRE";
            // 
            // lblClienteMostrar
            // 
            this.lblClienteMostrar.AutoSize = true;
            this.lblClienteMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClienteMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteMostrar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClienteMostrar.Location = new System.Drawing.Point(245, 28);
            this.lblClienteMostrar.Name = "lblClienteMostrar";
            this.lblClienteMostrar.Size = new System.Drawing.Size(54, 15);
            this.lblClienteMostrar.TabIndex = 19;
            this.lblClienteMostrar.Text = "CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(456, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "C.I./RUC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(123, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "DIRECCIÓN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(96, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "TELÉFONO FIJO:";
            // 
            // lblTelefonoMovil
            // 
            this.lblTelefonoMovil.AutoSize = true;
            this.lblTelefonoMovil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefonoMovil.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoMovil.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTelefonoMovil.Location = new System.Drawing.Point(390, 119);
            this.lblTelefonoMovil.Name = "lblTelefonoMovil";
            this.lblTelefonoMovil.Size = new System.Drawing.Size(133, 18);
            this.lblTelefonoMovil.TabIndex = 15;
            this.lblTelefonoMovil.Text = "TELÉFONO MÓVIL:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreCliente.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombreCliente.Location = new System.Drawing.Point(139, 58);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(73, 18);
            this.lblNombreCliente.TabIndex = 14;
            this.lblNombreCliente.Text = "NOMBRE:";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCodigoCliente.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCodigoCliente.Location = new System.Drawing.Point(144, 25);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(68, 18);
            this.lblCodigoCliente.TabIndex = 9;
            this.lblCodigoCliente.Text = "CLIENTE:";
            // 
            // txtCodigoMantenimiento
            // 
            this.txtCodigoMantenimiento.Location = new System.Drawing.Point(648, 76);
            this.txtCodigoMantenimiento.Name = "txtCodigoMantenimiento";
            this.txtCodigoMantenimiento.Size = new System.Drawing.Size(93, 20);
            this.txtCodigoMantenimiento.TabIndex = 15;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHora.Location = new System.Drawing.Point(652, 16);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 20);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "HORA";
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(115, 76);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(192, 20);
            this.txtCI.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(337, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(472, 489);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(40, 40);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(346, 489);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Location = new System.Drawing.Point(217, 489);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormularioRegistrarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelRegistrarMantenimiento);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioRegistrarMantenimiento";
            this.Text = "SFMEE-OMICROM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelRegistrarMantenimiento.ResumeLayout(false);
            this.panelRegistrarMantenimiento.PerformLayout();
            this.grupoMantenimiento.ResumeLayout(false);
            this.grupoMantenimiento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeSGFMOMICROMToolStripMenuItem;
        private System.Windows.Forms.Panel panelRegistrarMantenimiento;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtCodigoMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker pickerFechaMantenimiento;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox grupoMantenimiento;
        private System.Windows.Forms.Label lblHoraSistemaMostrar;
        private System.Windows.Forms.Label lblHoraSistema;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCelularMostrar;
        private System.Windows.Forms.Label lblTelefonoFijoMostrar;
        private System.Windows.Forms.Label lblDireccionMostrar;
        private System.Windows.Forms.Label lblCIMostrar;
        private System.Windows.Forms.Label lblNombreMostrar;
        private System.Windows.Forms.Label lblClienteMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTelefonoMovil;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Timer timer1;
    }
}