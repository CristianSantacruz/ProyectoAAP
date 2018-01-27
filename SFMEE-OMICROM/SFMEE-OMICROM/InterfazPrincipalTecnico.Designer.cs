namespace SFMEE_OMICROM
{
    partial class InterfazPrincipalTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazPrincipalTecnico));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANTENIMIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarMantenimientoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSGFMOMICROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipalTecnico = new System.Windows.Forms.Panel();
            this.btnSalirTecnico = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelPrincipalTecnico.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.mANTENIMIENTOSToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarClienteToolStripMenuItem});
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar Cliente";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // mANTENIMIENTOSToolStripMenuItem
            // 
            this.mANTENIMIENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarMantenimientoToolStripMenuItem,
            this.actualizarMantenimientoToolStripMenuItem1});
            this.mANTENIMIENTOSToolStripMenuItem.Name = "mANTENIMIENTOSToolStripMenuItem";
            this.mANTENIMIENTOSToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.mANTENIMIENTOSToolStripMenuItem.Text = "MANTENIMIENTOS";
            // 
            // actualizarMantenimientoToolStripMenuItem
            // 
            this.actualizarMantenimientoToolStripMenuItem.Name = "actualizarMantenimientoToolStripMenuItem";
            this.actualizarMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.actualizarMantenimientoToolStripMenuItem.Text = "Consultar Mantenimiento";
            this.actualizarMantenimientoToolStripMenuItem.Click += new System.EventHandler(this.actualizarMantenimientoToolStripMenuItem_Click);
            // 
            // actualizarMantenimientoToolStripMenuItem1
            // 
            this.actualizarMantenimientoToolStripMenuItem1.Name = "actualizarMantenimientoToolStripMenuItem1";
            this.actualizarMantenimientoToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.actualizarMantenimientoToolStripMenuItem1.Text = "Actualizar Mantenimiento";
            this.actualizarMantenimientoToolStripMenuItem1.Click += new System.EventHandler(this.actualizarMantenimientoToolStripMenuItem1_Click);
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteTécnicoToolStripMenuItem,
            this.acercaDeSGFMOMICROMToolStripMenuItem});
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // soporteTécnicoToolStripMenuItem
            // 
            this.soporteTécnicoToolStripMenuItem.Name = "soporteTécnicoToolStripMenuItem";
            this.soporteTécnicoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.soporteTécnicoToolStripMenuItem.Text = "Soporte Técnico";
            // 
            // acercaDeSGFMOMICROMToolStripMenuItem
            // 
            this.acercaDeSGFMOMICROMToolStripMenuItem.Name = "acercaDeSGFMOMICROMToolStripMenuItem";
            this.acercaDeSGFMOMICROMToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.acercaDeSGFMOMICROMToolStripMenuItem.Text = "Acerca de SGFM OMICROM";
            // 
            // panelPrincipalTecnico
            // 
            this.panelPrincipalTecnico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPrincipalTecnico.BackgroundImage")));
            this.panelPrincipalTecnico.Controls.Add(this.btnSalirTecnico);
            this.panelPrincipalTecnico.Location = new System.Drawing.Point(0, 27);
            this.panelPrincipalTecnico.Name = "panelPrincipalTecnico";
            this.panelPrincipalTecnico.Size = new System.Drawing.Size(984, 434);
            this.panelPrincipalTecnico.TabIndex = 1;
            // 
            // btnSalirTecnico
            // 
            this.btnSalirTecnico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalirTecnico.BackgroundImage")));
            this.btnSalirTecnico.FlatAppearance.BorderSize = 0;
            this.btnSalirTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirTecnico.Location = new System.Drawing.Point(723, 309);
            this.btnSalirTecnico.Name = "btnSalirTecnico";
            this.btnSalirTecnico.Size = new System.Drawing.Size(75, 74);
            this.btnSalirTecnico.TabIndex = 0;
            this.btnSalirTecnico.UseVisualStyleBackColor = true;
            this.btnSalirTecnico.Click += new System.EventHandler(this.btnSalirTecnico_Click);
            // 
            // InterfazPrincipalTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panelPrincipalTecnico);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InterfazPrincipalTecnico";
            this.Text = "SFMEE - OMICROM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPrincipalTecnico.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarMantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarMantenimientoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeSGFMOMICROMToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipalTecnico;
        private System.Windows.Forms.Button btnSalirTecnico;
    }
}