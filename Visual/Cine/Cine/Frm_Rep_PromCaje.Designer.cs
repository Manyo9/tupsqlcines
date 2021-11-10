
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rep_PromCaje));
            this.lblAño = new System.Windows.Forms.Label();
            this.dgvPromCaje = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.nud_Año_Prom_caje = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromCaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Año_Prom_caje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAño.ForeColor = System.Drawing.Color.White;
            this.lblAño.Location = new System.Drawing.Point(34, 48);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(41, 26);
            this.lblAño.TabIndex = 0;
            this.lblAño.Text = "Año";
            // 
            // dgvPromCaje
            // 
            this.dgvPromCaje.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvPromCaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromCaje.Location = new System.Drawing.Point(34, 154);
            this.dgvPromCaje.Name = "dgvPromCaje";
            this.dgvPromCaje.RowTemplate.Height = 25;
            this.dgvPromCaje.Size = new System.Drawing.Size(481, 150);
            this.dgvPromCaje.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.HotPink;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.btnGenerar.Location = new System.Drawing.Point(34, 106);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(481, 32);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(169, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 103);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Rep_PromCaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(547, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nud_Año_Prom_caje);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvPromCaje);
            this.Controls.Add(this.lblAño);
            this.Name = "Frm_Rep_PromCaje";
            this.Text = "Frm_Rep_PromCaje";
            this.Load += new System.EventHandler(this.Frm_Rep_PromCaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromCaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Año_Prom_caje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.DataGridView dgvPromCaje;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.NumericUpDown nud_Año_Prom_caje;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}