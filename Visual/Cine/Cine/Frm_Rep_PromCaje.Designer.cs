
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
            this.DTPAño = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromCaje)).BeginInit();
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
            // DTPAño
            // 
            this.DTPAño.Location = new System.Drawing.Point(93, 42);
            this.DTPAño.Name = "DTPAño";
            this.DTPAño.Size = new System.Drawing.Size(200, 23);
            this.DTPAño.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(34, 106);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(179, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // Frm_Rep_PromCaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 391);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.DTPAño);
            this.Controls.Add(this.dgvPromCaje);
            this.Controls.Add(this.lblAño);
            this.Name = "Frm_Rep_PromCaje";
            this.Text = "Frm_Rep_PromCaje";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromCaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.DataGridView dgvPromCaje;
        private System.Windows.Forms.DateTimePicker DTPAño;
        private System.Windows.Forms.Button btnGenerar;
    }
}