
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
            this.txtFechaUno = new System.Windows.Forms.TextBox();
            this.lblFechaDos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvPelSinVentas = new System.Windows.Forms.DataGridView();
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
            // txtFechaUno
            // 
            this.txtFechaUno.Location = new System.Drawing.Point(107, 51);
            this.txtFechaUno.Name = "txtFechaUno";
            this.txtFechaUno.Size = new System.Drawing.Size(100, 23);
            this.txtFechaUno.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
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
            // Frm_Rep_PelSinVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 413);
            this.Controls.Add(this.dgvPelSinVentas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFechaDos);
            this.Controls.Add(this.txtFechaUno);
            this.Controls.Add(this.lblFechaUno);
            this.Name = "Frm_Rep_PelSinVentas";
            this.Text = "Frm_Rep_PelSinVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelSinVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaUno;
        private System.Windows.Forms.TextBox txtFechaUno;
        private System.Windows.Forms.Label lblFechaDos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvPelSinVentas;
    }
}