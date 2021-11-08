
namespace Cine
{
    partial class Frm_Ticket
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
            this.lblNroTicket = new System.Windows.Forms.Label();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.IdSucursal = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnImprimirTicket = new System.Windows.Forms.Button();
            this.lblNroTransaccion = new System.Windows.Forms.Label();
            this.lblNombreSuc = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblCantidadEntradas = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEntradas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroTicket
            // 
            this.lblNroTicket.AutoSize = true;
            this.lblNroTicket.Location = new System.Drawing.Point(37, 40);
            this.lblNroTicket.Name = "lblNroTicket";
            this.lblNroTicket.Size = new System.Drawing.Size(58, 15);
            this.lblNroTicket.TabIndex = 0;
            this.lblNroTicket.Text = "NroTicket";
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.Location = new System.Drawing.Point(115, 37);
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.Size = new System.Drawing.Size(100, 23);
            this.txtNroTicket.TabIndex = 1;
            // 
            // IdSucursal
            // 
            this.IdSucursal.AutoSize = true;
            this.IdSucursal.Location = new System.Drawing.Point(37, 85);
            this.IdSucursal.Name = "IdSucursal";
            this.IdSucursal.Size = new System.Drawing.Size(64, 15);
            this.IdSucursal.TabIndex = 2;
            this.IdSucursal.Text = "Id Sucursal";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(115, 85);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 23);
            this.txt.TabIndex = 3;
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.Location = new System.Drawing.Point(272, 53);
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            this.btnImprimirTicket.Size = new System.Drawing.Size(116, 23);
            this.btnImprimirTicket.TabIndex = 4;
            this.btnImprimirTicket.Text = "Imprimir Ticket";
            this.btnImprimirTicket.UseVisualStyleBackColor = true;
            // 
            // lblNroTransaccion
            // 
            this.lblNroTransaccion.AutoSize = true;
            this.lblNroTransaccion.Location = new System.Drawing.Point(50, 155);
            this.lblNroTransaccion.Name = "lblNroTransaccion";
            this.lblNroTransaccion.Size = new System.Drawing.Size(92, 15);
            this.lblNroTransaccion.TabIndex = 5;
            this.lblNroTransaccion.Text = "Nro Transaccion";
            // 
            // lblNombreSuc
            // 
            this.lblNombreSuc.AutoSize = true;
            this.lblNombreSuc.Location = new System.Drawing.Point(50, 190);
            this.lblNombreSuc.Name = "lblNombreSuc";
            this.lblNombreSuc.Size = new System.Drawing.Size(98, 15);
            this.lblNombreSuc.TabIndex = 6;
            this.lblNombreSuc.Text = "Nombre Sucursal";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(50, 226);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(87, 15);
            this.lblFormaPago.TabIndex = 7;
            this.lblFormaPago.Text = "Forma de Pago";
            // 
            // lblCantidadEntradas
            // 
            this.lblCantidadEntradas.AutoSize = true;
            this.lblCantidadEntradas.Location = new System.Drawing.Point(50, 291);
            this.lblCantidadEntradas.Name = "lblCantidadEntradas";
            this.lblCantidadEntradas.Size = new System.Drawing.Size(119, 15);
            this.lblCantidadEntradas.TabIndex = 8;
            this.lblCantidadEntradas.Text = "Cantidad de entradas";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(362, 507);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(74, 15);
            this.lblTotalPagar.TabIndex = 9;
            this.lblTotalPagar.Text = "Total a Pagar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(492, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Location = new System.Drawing.Point(50, 315);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(65, 15);
            this.lblEntradas.TabIndex = 11;
            this.lblEntradas.Text = "ENTRADAS";
            // 
            // Frm_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 555);
            this.Controls.Add(this.lblEntradas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblCantidadEntradas);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.lblNombreSuc);
            this.Controls.Add(this.lblNroTransaccion);
            this.Controls.Add(this.btnImprimirTicket);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.IdSucursal);
            this.Controls.Add(this.txtNroTicket);
            this.Controls.Add(this.lblNroTicket);
            this.Name = "Frm_Ticket";
            this.Text = "Frm_Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroTicket;
        private System.Windows.Forms.TextBox txtNroTicket;
        private System.Windows.Forms.Label IdSucursal;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnImprimirTicket;
        private System.Windows.Forms.Label lblNroTransaccion;
        private System.Windows.Forms.Label lblNombreSuc;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblCantidadEntradas;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEntradas;
    }
}