
namespace Cine
{
    partial class Frm_Rep_PromCaje
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
            this.dgvPromCaje = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.nud_Año_Prom_caje = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromCaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Año_Prom_caje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(34, 48);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 15);
            this.lblAño.TabIndex = 0;
            this.lblAño.Text = "Año";
            // 
            // dgvPromCaje
            // 
            this.dgvPromCaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromCaje.Location = new System.Drawing.Point(34, 154);
            this.dgvPromCaje.Name = "dgvPromCaje";
            this.dgvPromCaje.RowTemplate.Height = 25;
            this.dgvPromCaje.Size = new System.Drawing.Size(481, 150);
            this.dgvPromCaje.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(34, 106);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(179, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // nud_Año_Prom_caje
            // 
            this.nud_Año_Prom_caje.Location = new System.Drawing.Point(87, 48);
            this.nud_Año_Prom_caje.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nud_Año_Prom_caje.Name = "nud_Año_Prom_caje";
            this.nud_Año_Prom_caje.Size = new System.Drawing.Size(120, 23);
            this.nud_Año_Prom_caje.TabIndex = 5;
            // 
            // Frm_Rep_PromCaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 391);
            this.Controls.Add(this.nud_Año_Prom_caje);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvPromCaje);
            this.Controls.Add(this.lblAño);
            this.Name = "Frm_Rep_PromCaje";
            this.Text = "Frm_Rep_PromCaje";
            this.Load += new System.EventHandler(this.Frm_Rep_PromCaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromCaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Año_Prom_caje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.DataGridView dgvPromCaje;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.NumericUpDown nud_Año_Prom_caje;
    }
}