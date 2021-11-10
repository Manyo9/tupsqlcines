
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.DGVPelMasVistas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidadMinima = new System.Windows.Forms.Label();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.nudCant_min_entradas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPelMasVistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant_min_entradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 110);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(157, 192);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(320, 31);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "final";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(82, 121);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(54, 28);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "inicio";
            // 
            // DGVPelMasVistas
            // 
            this.DGVPelMasVistas.AllowUserToAddRows = false;
            this.DGVPelMasVistas.AllowUserToDeleteRows = false;
            this.DGVPelMasVistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPelMasVistas.Location = new System.Drawing.Point(82, 453);
            this.DGVPelMasVistas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DGVPelMasVistas.Name = "DGVPelMasVistas";
            this.DGVPelMasVistas.ReadOnly = true;
            this.DGVPelMasVistas.RowTemplate.Height = 25;
            this.DGVPelMasVistas.Size = new System.Drawing.Size(657, 146);
            this.DGVPelMasVistas.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese Fecha";
            // 
            // lblCantidadMinima
            // 
            this.lblCantidadMinima.AutoSize = true;
            this.lblCantidadMinima.Location = new System.Drawing.Point(82, 282);
            this.lblCantidadMinima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadMinima.Name = "lblCantidadMinima";
            this.lblCantidadMinima.Size = new System.Drawing.Size(333, 28);
            this.lblCantidadMinima.TabIndex = 8;
            this.lblCantidadMinima.Text = "Cantidad minima de entradas vendidas";
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Location = new System.Drawing.Point(82, 371);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(256, 43);
            this.BtnGenerar.TabIndex = 9;
            this.BtnGenerar.Text = "Generar Reporte";
            this.BtnGenerar.UseVisualStyleBackColor = true;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // nudCant_min_entradas
            // 
            this.nudCant_min_entradas.Location = new System.Drawing.Point(510, 279);
            this.nudCant_min_entradas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nudCant_min_entradas.Name = "nudCant_min_entradas";
            this.nudCant_min_entradas.Size = new System.Drawing.Size(154, 31);
            this.nudCant_min_entradas.TabIndex = 10;
            // 
            // Frm_Rep_PelMasVis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(795, 654);
            this.Controls.Add(this.nudCant_min_entradas);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.lblCantidadMinima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVPelMasVistas);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frm_Rep_PelMasVis";
            this.Text = "Frm_Rep_PelMasVis";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPelMasVistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant_min_entradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DataGridView DGVPelMasVistas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidadMinima;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.NumericUpDown nudCant_min_entradas;
    }
}