
namespace Cine
{
    partial class Frm_Rep_PelMasVis
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.DGVPelMasVistas = new System.Windows.Forms.DataGridView();
            this.NombrePelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantButacasVendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantMin = new System.Windows.Forms.TextBox();
            this.lblCantidadMinima = new System.Windows.Forms.Label();
            this.BtnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPelMasVistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(122, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 23);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "final";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(64, 65);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(36, 15);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "inicio";
            // 
            // DGVPelMasVistas
            // 
            this.DGVPelMasVistas.AllowUserToAddRows = false;
            this.DGVPelMasVistas.AllowUserToDeleteRows = false;
            this.DGVPelMasVistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPelMasVistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePelicula,
            this.CantButacasVendidas});
            this.DGVPelMasVistas.Location = new System.Drawing.Point(64, 237);
            this.DGVPelMasVistas.Name = "DGVPelMasVistas";
            this.DGVPelMasVistas.ReadOnly = true;
            this.DGVPelMasVistas.RowTemplate.Height = 25;
            this.DGVPelMasVistas.Size = new System.Drawing.Size(511, 150);
            this.DGVPelMasVistas.TabIndex = 5;
            // 
            // NombrePelicula
            // 
            this.NombrePelicula.HeaderText = "Pelicula";
            this.NombrePelicula.Name = "NombrePelicula";
            this.NombrePelicula.ReadOnly = true;
            // 
            // CantButacasVendidas
            // 
            this.CantButacasVendidas.HeaderText = "Cantidad de Butacas Vendidas";
            this.CantButacasVendidas.Name = "CantButacasVendidas";
            this.CantButacasVendidas.ReadOnly = true;
            this.CantButacasVendidas.Width = 250;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese Fecha";
            // 
            // txtCantMin
            // 
            this.txtCantMin.Location = new System.Drawing.Point(272, 147);
            this.txtCantMin.Name = "txtCantMin";
            this.txtCantMin.Size = new System.Drawing.Size(100, 23);
            this.txtCantMin.TabIndex = 7;
            // 
            // lblCantidadMinima
            // 
            this.lblCantidadMinima.AutoSize = true;
            this.lblCantidadMinima.Location = new System.Drawing.Point(64, 151);
            this.lblCantidadMinima.Name = "lblCantidadMinima";
            this.lblCantidadMinima.Size = new System.Drawing.Size(163, 15);
            this.lblCantidadMinima.TabIndex = 8;
            this.lblCantidadMinima.Text = "Cantidad minima de entradas";
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Location = new System.Drawing.Point(64, 199);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(199, 23);
            this.BtnGenerar.TabIndex = 9;
            this.BtnGenerar.Text = "Generar Reporte";
            this.BtnGenerar.UseVisualStyleBackColor = true;
            // 
            // Frm_Rep_PelMasVis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.lblCantidadMinima);
            this.Controls.Add(this.txtCantMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVPelMasVistas);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Frm_Rep_PelMasVis";
            this.Text = "Frm_Rep_PelMasVis";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPelMasVistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DataGridView DGVPelMasVistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantButacasVendidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantMin;
        private System.Windows.Forms.Label lblCantidadMinima;
        private System.Windows.Forms.Button BtnGenerar;
    }
}