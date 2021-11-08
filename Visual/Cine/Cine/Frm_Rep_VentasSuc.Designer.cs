
namespace Cine
{
    partial class Frm_Rep_VentasSuc
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
            this.txtFechaUno = new System.Windows.Forms.TextBox();
            this.txtFechaDos = new System.Windows.Forms.TextBox();
            this.dgvVentasSuc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasSuc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaUno
            // 
            this.lblFechaUno.AutoSize = true;
            this.lblFechaUno.Location = new System.Drawing.Point(58, 61);
            this.lblFechaUno.Name = "lblFechaUno";
            this.lblFechaUno.Size = new System.Drawing.Size(63, 15);
            this.lblFechaUno.TabIndex = 0;
            this.lblFechaUno.Text = "Fecha Uno";
            // 
            // lblFechaDos
            // 
            this.lblFechaDos.AutoSize = true;
            this.lblFechaDos.Location = new System.Drawing.Point(58, 99);
            this.lblFechaDos.Name = "lblFechaDos";
            this.lblFechaDos.Size = new System.Drawing.Size(61, 15);
            this.lblFechaDos.TabIndex = 1;
            this.lblFechaDos.Text = "Fecha Dos";
            // 
            // txtFechaUno
            // 
            this.txtFechaUno.Location = new System.Drawing.Point(136, 61);
            this.txtFechaUno.Name = "txtFechaUno";
            this.txtFechaUno.Size = new System.Drawing.Size(100, 23);
            this.txtFechaUno.TabIndex = 2;
            // 
            // txtFechaDos
            // 
            this.txtFechaDos.Location = new System.Drawing.Point(136, 99);
            this.txtFechaDos.Name = "txtFechaDos";
            this.txtFechaDos.Size = new System.Drawing.Size(100, 23);
            this.txtFechaDos.TabIndex = 3;
            // 
            // dgvVentasSuc
            // 
            this.dgvVentasSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasSuc.Location = new System.Drawing.Point(42, 199);
            this.dgvVentasSuc.Name = "dgvVentasSuc";
            this.dgvVentasSuc.RowTemplate.Height = 25;
            this.dgvVentasSuc.Size = new System.Drawing.Size(467, 150);
            this.dgvVentasSuc.TabIndex = 4;
            // 
            // Frm_Rep_VentasSuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 416);
            this.Controls.Add(this.dgvVentasSuc);
            this.Controls.Add(this.txtFechaDos);
            this.Controls.Add(this.txtFechaUno);
            this.Controls.Add(this.lblFechaDos);
            this.Controls.Add(this.lblFechaUno);
            this.Name = "Frm_Rep_VentasSuc";
            this.Text = "Frm_Rep_VentasSuc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasSuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaUno;
        private System.Windows.Forms.Label lblFechaDos;
        private System.Windows.Forms.TextBox txtFechaUno;
        private System.Windows.Forms.TextBox txtFechaDos;
        private System.Windows.Forms.DataGridView dgvVentasSuc;
    }
}