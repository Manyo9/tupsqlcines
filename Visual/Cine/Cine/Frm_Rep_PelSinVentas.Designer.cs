﻿
namespace Cine
{
    partial class Frm_Rep_PelSinVentas
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
            this.lblFechaUno = new System.Windows.Forms.Label();
            this.lblFechaDos = new System.Windows.Forms.Label();
            this.dgvPelSinVentas = new System.Windows.Forms.DataGridView();
            this.DTPFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelSinVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaUno
            // 
            this.lblFechaUno.AutoSize = true;
            this.lblFechaUno.Location = new System.Drawing.Point(30, 54);
            this.lblFechaUno.Name = "lblFechaUno";
            this.lblFechaUno.Size = new System.Drawing.Size(62, 15);
            this.lblFechaUno.TabIndex = 0;
            this.lblFechaUno.Text = "Fecha uno";
            // 
            // lblFechaDos
            // 
            this.lblFechaDos.AutoSize = true;
            this.lblFechaDos.Location = new System.Drawing.Point(30, 96);
            this.lblFechaDos.Name = "lblFechaDos";
            this.lblFechaDos.Size = new System.Drawing.Size(60, 15);
            this.lblFechaDos.TabIndex = 2;
            this.lblFechaDos.Text = "Fecha dos";
            // 
            // dgvPelSinVentas
            // 
            this.dgvPelSinVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelSinVentas.Location = new System.Drawing.Point(41, 183);
            this.dgvPelSinVentas.Name = "dgvPelSinVentas";
            this.dgvPelSinVentas.RowTemplate.Height = 25;
            this.dgvPelSinVentas.Size = new System.Drawing.Size(485, 150);
            this.dgvPelSinVentas.TabIndex = 4;
            // 
            // DTPFecha1
            // 
            this.DTPFecha1.Location = new System.Drawing.Point(127, 54);
            this.DTPFecha1.Name = "DTPFecha1";
            this.DTPFecha1.Size = new System.Drawing.Size(200, 23);
            this.DTPFecha1.TabIndex = 5;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Location = new System.Drawing.Point(127, 96);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha2.TabIndex = 6;
            // 
            // Frm_Rep_PelSinVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 413);
            this.Controls.Add(this.dtpFecha2);
            this.Controls.Add(this.DTPFecha1);
            this.Controls.Add(this.dgvPelSinVentas);
            this.Controls.Add(this.lblFechaDos);
            this.Controls.Add(this.lblFechaUno);
            this.Name = "Frm_Rep_PelSinVentas";
            this.Text = "Frm_Rep_PelSinVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelSinVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaUno;
        private System.Windows.Forms.Label lblFechaDos;
        private System.Windows.Forms.DataGridView dgvPelSinVentas;
        private System.Windows.Forms.DateTimePicker DTPFecha1;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
    }
}