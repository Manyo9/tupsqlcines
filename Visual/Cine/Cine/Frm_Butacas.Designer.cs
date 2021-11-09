
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
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.dgvButacas = new System.Windows.Forms.DataGridView();
            this.idButaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvButacas)).BeginInit();
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
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(192, 59);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 23);
            this.txtFuncion.TabIndex = 1;
            // 
            // dgvButacas
            // 
            this.dgvButacas.AllowUserToAddRows = false;
            this.dgvButacas.AllowUserToDeleteRows = false;
            this.dgvButacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvButacas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idButaca});
            this.dgvButacas.Location = new System.Drawing.Point(67, 165);
            this.dgvButacas.Name = "dgvButacas";
            this.dgvButacas.ReadOnly = true;
            this.dgvButacas.RowTemplate.Height = 25;
            this.dgvButacas.Size = new System.Drawing.Size(240, 150);
            this.dgvButacas.TabIndex = 2;
            // 
            // idButaca
            // 
            this.idButaca.HeaderText = "Column1";
            this.idButaca.Name = "idButaca";
            this.idButaca.ReadOnly = true;
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
            // Frm_Butacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvButacas);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.lblFuncion);
            this.Name = "Frm_Butacas";
            this.Text = "Frm_Butacas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvButacas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.DataGridView dgvButacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idButaca;
        private System.Windows.Forms.Button btnConsultar;
    }
}