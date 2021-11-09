
namespace Cine
{
    partial class Frm_Rep_GanMens
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
            this.lblAño = new System.Windows.Forms.Label();
            this.dgvGananciaMen = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.txtAnio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGananciaMen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(55, 49);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(70, 15);
            this.lblAño.TabIndex = 1;
            this.lblAño.Text = "Ingrese Año";
            // 
            // dgvGananciaMen
            // 
            this.dgvGananciaMen.AllowUserToAddRows = false;
            this.dgvGananciaMen.AllowUserToDeleteRows = false;
            this.dgvGananciaMen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGananciaMen.Location = new System.Drawing.Point(55, 225);
            this.dgvGananciaMen.Name = "dgvGananciaMen";
            this.dgvGananciaMen.ReadOnly = true;
            this.dgvGananciaMen.RowTemplate.Height = 25;
            this.dgvGananciaMen.Size = new System.Drawing.Size(244, 150);
            this.dgvGananciaMen.TabIndex = 2;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(55, 151);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(156, 23);
            this.BtnConsultar.TabIndex = 4;
            this.BtnConsultar.Text = "Generar Reporte";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(55, 83);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(156, 23);
            this.txtAnio.TabIndex = 5;
            // 
            // Frm_Rep_GanMens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.dgvGananciaMen);
            this.Controls.Add(this.lblAño);
            this.Name = "Frm_Rep_GanMens";
            this.Text = "Frm_Rep_GanMens";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGananciaMen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.DataGridView dgvGananciaMen;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TextBox txtAnio;
    }
}