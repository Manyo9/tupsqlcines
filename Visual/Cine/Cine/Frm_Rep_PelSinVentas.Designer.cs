
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
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
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
            // dtpFecha1
            // 
            this.dtpFecha1.Location = new System.Drawing.Point(127, 54);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha1.TabIndex = 5;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Location = new System.Drawing.Point(127, 96);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha2.TabIndex = 6;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(41, 142);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(180, 23);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Frm_Rep_PelSinVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 413);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpFecha2);
            this.Controls.Add(this.dtpFecha1);
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
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Button btnGenerar;
    }
}