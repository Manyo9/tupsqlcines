
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
            this.txtBaño = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBaño
            // 
            this.txtBaño.Location = new System.Drawing.Point(144, 46);
            this.txtBaño.Name = "txtBaño";
            this.txtBaño.Size = new System.Drawing.Size(113, 23);
            this.txtBaño.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mes,
            this.Ganancia});
            this.dataGridView1.Location = new System.Drawing.Point(55, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Mes
            // 
            this.Mes.HeaderText = "mes";
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            // 
            // Ganancia
            // 
            this.Ganancia.HeaderText = "Ganancia";
            this.Ganancia.Name = "Ganancia";
            this.Ganancia.ReadOnly = true;
            // 
            // Frm_Rep_GanMens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtBaño);
            this.Name = "Frm_Rep_GanMens";
            this.Text = "Frm_Rep_GanMens";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ganancia;
    }
}