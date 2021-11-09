namespace Cine
{
    partial class Frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butacasVendidasPorFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasSinVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasMásVistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasMensualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promVentasPorCajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarIntegrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMAximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMAximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionesToolStripMenuItem,
            this.ticketsToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(20);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(132, 326);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butacasVendidasPorFuncionToolStripMenuItem});
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // butacasVendidasPorFuncionToolStripMenuItem
            // 
            this.butacasVendidasPorFuncionToolStripMenuItem.Name = "butacasVendidasPorFuncionToolStripMenuItem";
            this.butacasVendidasPorFuncionToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.butacasVendidasPorFuncionToolStripMenuItem.Text = "Butacas vendidas por funcion";
            this.butacasVendidasPorFuncionToolStripMenuItem.Click += new System.EventHandler(this.butacasVendidasPorFuncionToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirTicketToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // imprimirTicketToolStripMenuItem
            // 
            this.imprimirTicketToolStripMenuItem.Name = "imprimirTicketToolStripMenuItem";
            this.imprimirTicketToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.imprimirTicketToolStripMenuItem.Text = "Imprimir Ticket";
            this.imprimirTicketToolStripMenuItem.Click += new System.EventHandler(this.imprimirTicketToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasSinVentasToolStripMenuItem,
            this.peliculasMásVistasToolStripMenuItem,
            this.gananciasMensualesToolStripMenuItem,
            this.ventasPorSucursalToolStripMenuItem,
            this.promVentasPorCajeroToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // peliculasSinVentasToolStripMenuItem
            // 
            this.peliculasSinVentasToolStripMenuItem.Name = "peliculasSinVentasToolStripMenuItem";
            this.peliculasSinVentasToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.peliculasSinVentasToolStripMenuItem.Text = "Peliculas sin ventas";
            this.peliculasSinVentasToolStripMenuItem.Click += new System.EventHandler(this.peliculasSinVentasToolStripMenuItem_Click);
            // 
            // peliculasMásVistasToolStripMenuItem
            // 
            this.peliculasMásVistasToolStripMenuItem.Name = "peliculasMásVistasToolStripMenuItem";
            this.peliculasMásVistasToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.peliculasMásVistasToolStripMenuItem.Text = "Peliculas más vistas";
            this.peliculasMásVistasToolStripMenuItem.Click += new System.EventHandler(this.peliculasMásVistasToolStripMenuItem_Click);
            // 
            // gananciasMensualesToolStripMenuItem
            // 
            this.gananciasMensualesToolStripMenuItem.Name = "gananciasMensualesToolStripMenuItem";
            this.gananciasMensualesToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.gananciasMensualesToolStripMenuItem.Text = "Ganancias mensuales";
            this.gananciasMensualesToolStripMenuItem.Click += new System.EventHandler(this.gananciasMensualesToolStripMenuItem_Click);
            // 
            // ventasPorSucursalToolStripMenuItem
            // 
            this.ventasPorSucursalToolStripMenuItem.Name = "ventasPorSucursalToolStripMenuItem";
            this.ventasPorSucursalToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.ventasPorSucursalToolStripMenuItem.Text = "Ventas por sucursal";
            this.ventasPorSucursalToolStripMenuItem.Click += new System.EventHandler(this.ventasPorSucursalToolStripMenuItem_Click);
            // 
            // promVentasPorCajeroToolStripMenuItem
            // 
            this.promVentasPorCajeroToolStripMenuItem.Name = "promVentasPorCajeroToolStripMenuItem";
            this.promVentasPorCajeroToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.promVentasPorCajeroToolStripMenuItem.Text = "Prom. ventas por cajero";
            this.promVentasPorCajeroToolStripMenuItem.Click += new System.EventHandler(this.promVentasPorCajeroToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarIntegrantesToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // mostrarIntegrantesToolStripMenuItem
            // 
            this.mostrarIntegrantesToolStripMenuItem.Name = "mostrarIntegrantesToolStripMenuItem";
            this.mostrarIntegrantesToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.mostrarIntegrantesToolStripMenuItem.Text = "Mostrar integrantes";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(530, 326);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(662, 351);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(59)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMAximizar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnRestaurar);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 37);
            this.panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(499, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 27);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMAximizar
            // 
            this.btnMAximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMAximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMAximizar.Image")));
            this.btnMAximizar.Location = new System.Drawing.Point(466, 4);
            this.btnMAximizar.Name = "btnMAximizar";
            this.btnMAximizar.Size = new System.Drawing.Size(29, 27);
            this.btnMAximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMAximizar.TabIndex = 3;
            this.btnMAximizar.TabStop = false;
            this.btnMAximizar.Click += new System.EventHandler(this.btnMAximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(431, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(466, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(27, 29);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 0;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 351);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMAximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasSinVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasMásVistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasMensualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promVentasPorCajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butacasVendidasPorFuncionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarIntegrantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMAximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
    }
}

