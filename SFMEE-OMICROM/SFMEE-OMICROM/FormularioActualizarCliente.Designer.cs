namespace SFMEE_OMICROM
{
    partial class FormularioActualizarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioActualizarCliente));
            this.panelActualizarCliente = new System.Windows.Forms.Panel();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSGFMOMICROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaCliente = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelActualizarCliente.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActualizarCliente
            // 
            this.panelActualizarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelActualizarCliente.BackgroundImage")));
            this.panelActualizarCliente.Controls.Add(this.txtCelular);
            this.panelActualizarCliente.Controls.Add(this.lblHora);
            this.panelActualizarCliente.Controls.Add(this.btnBuscar);
            this.panelActualizarCliente.Controls.Add(this.txtTelefonoCliente);
            this.panelActualizarCliente.Controls.Add(this.txtDireccionCliente);
            this.panelActualizarCliente.Controls.Add(this.txtNombreCliente);
            this.panelActualizarCliente.Controls.Add(this.txtCI);
            this.panelActualizarCliente.Controls.Add(this.btnRegresar);
            this.panelActualizarCliente.Controls.Add(this.btnCancelar);
            this.panelActualizarCliente.Controls.Add(this.btnGuardar);
            this.panelActualizarCliente.Location = new System.Drawing.Point(0, 27);
            this.panelActualizarCliente.Name = "panelActualizarCliente";
            this.panelActualizarCliente.Size = new System.Drawing.Size(585, 335);
            this.panelActualizarCliente.TabIndex = 4;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(203, 254);
            this.txtCelular.MaxLength = 10;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(295, 20);
            this.txtCelular.TabIndex = 14;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHora.Location = new System.Drawing.Point(459, 15);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 20);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "HORA";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(504, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(203, 208);
            this.txtTelefonoCliente.MaxLength = 9;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(295, 20);
            this.txtTelefonoCliente.TabIndex = 13;
            this.txtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCliente_KeyPress);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(203, 160);
            this.txtDireccionCliente.MaxLength = 200;
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(295, 20);
            this.txtDireccionCliente.TabIndex = 12;
            this.txtDireccionCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccionCliente_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(203, 115);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(295, 20);
            this.txtNombreCliente.TabIndex = 11;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(203, 68);
            this.txtCI.MaxLength = 13;
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(295, 20);
            this.txtCI.TabIndex = 10;
            this.txtCI.TextChanged += new System.EventHandler(this.txtCI_TextChanged);
            this.txtCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCI_KeyPress);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(407, 289);
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
            this.btnCancelar.Location = new System.Drawing.Point(286, 289);
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
            this.btnGuardar.Location = new System.Drawing.Point(152, 289);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.guardarToolStripMenuItem,
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
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
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
            this.eliminarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
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
            // tablaCliente
            // 
            this.tablaCliente.AllowUserToAddRows = false;
            this.tablaCliente.AllowUserToDeleteRows = false;
            this.tablaCliente.AllowUserToOrderColumns = true;
            this.tablaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCliente.Location = new System.Drawing.Point(0, 362);
            this.tablaCliente.MultiSelect = false;
            this.tablaCliente.Name = "tablaCliente";
            this.tablaCliente.ReadOnly = true;
            this.tablaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCliente.Size = new System.Drawing.Size(584, 299);
            this.tablaCliente.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormularioActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.tablaCliente);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelActualizarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioActualizarCliente";
            this.Text = "SFMEE-OMICROM";
            this.Load += new System.EventHandler(this.FormularioActualizarCliente_Load);
            this.panelActualizarCliente.ResumeLayout(false);
            this.panelActualizarCliente.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelActualizarCliente;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeSGFMOMICROMToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.DataGridView tablaCliente;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}