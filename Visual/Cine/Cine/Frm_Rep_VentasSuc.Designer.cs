
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rep_VentasSuc));
            this.lblFechaUno = new System.Windows.Forms.Label();
            this.lblFechaDos = new System.Windows.Forms.Label();
            this.dgvVentasSuc = new System.Windows.Forms.DataGridView();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasSuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaUno
            // 
            this.lblFechaUno.AutoSize = true;
            this.lblFechaUno.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaUno.ForeColor = System.Drawing.Color.White;
            this.lblFechaUno.Location = new System.Drawing.Point(23, 35);
            this.lblFechaUno.Name = "lblFechaUno";
            this.lblFechaUno.Size = new System.Drawing.Size(97, 26);
            this.lblFechaUno.TabIndex = 0;
            this.lblFechaUno.Text = "Fecha inicio";
            // 
            // lblFechaDos
            // 
            this.lblFechaDos.AutoSize = true;
            this.lblFechaDos.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaDos.ForeColor = System.Drawing.Color.White;
            this.lblFechaDos.Location = new System.Drawing.Point(23, 73);
            this.lblFechaDos.Name = "lblFechaDos";
            this.lblFechaDos.Size = new System.Drawing.Size(77, 26);
            this.lblFechaDos.TabIndex = 1;
            this.lblFechaDos.Text = "Fecha fin";
            // 
            // dgvVentasSuc
            // 
            this.dgvVentasSuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvVentasSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasSuc.Location = new System.Drawing.Point(24, 180);
            this.dgvVentasSuc.Name = "dgvVentasSuc";
            this.dgvVentasSuc.RowTemplate.Height = 25;
            this.dgvVentasSuc.Size = new System.Drawing.Size(510, 170);
            this.dgvVentasSuc.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaInicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.dtpFechaInicio.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaInicio.Location = new System.Drawing.Point(121, 35);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaInicio.TabIndex = 5;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(121, 73);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaFin.TabIndex = 6;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.HotPink;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.btnGenerar.Location = new System.Drawing.Point(24, 134);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(510, 29);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(176, 356);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 103);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Rep_VentasSuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(556, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dgvVentasSuc);
            this.Controls.Add(this.lblFechaDos);
            this.Controls.Add(this.lblFechaUno);
            this.Name = "Frm_Rep_VentasSuc";
            this.Text = "Frm_Rep_VentasSuc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasSuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaUno;
        private System.Windows.Forms.Label lblFechaDos;
        private System.Windows.Forms.DataGridView dgvVentasSuc;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}