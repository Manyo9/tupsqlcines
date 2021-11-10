
namespace Cine
{
    partial class Frm_Butacas
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
            this.lblFuncion = new System.Windows.Forms.Label();
            this.dgvButacas = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.nudNro_funcion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvButacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNro_funcion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(67, 62);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(73, 15);
            this.lblFuncion.TabIndex = 0;
            this.lblFuncion.Text = "Nro Funcion";
            // 
            // dgvButacas
            // 
            this.dgvButacas.AllowUserToAddRows = false;
            this.dgvButacas.AllowUserToDeleteRows = false;
            this.dgvButacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvButacas.Location = new System.Drawing.Point(67, 165);
            this.dgvButacas.Name = "dgvButacas";
            this.dgvButacas.ReadOnly = true;
            this.dgvButacas.RowTemplate.Height = 25;
            this.dgvButacas.Size = new System.Drawing.Size(240, 150);
            this.dgvButacas.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(321, 58);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // nudNro_funcion
            // 
            this.nudNro_funcion.Location = new System.Drawing.Point(163, 57);
            this.nudNro_funcion.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNro_funcion.Name = "nudNro_funcion";
            this.nudNro_funcion.Size = new System.Drawing.Size(120, 23);
            this.nudNro_funcion.TabIndex = 4;
            // 
            // Frm_Butacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.nudNro_funcion);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvButacas);
            this.Controls.Add(this.lblFuncion);
            this.Name = "Frm_Butacas";
            this.Text = "Frm_Butacas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvButacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNro_funcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.DataGridView dgvButacas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.NumericUpDown nudNro_funcion;
    }
}