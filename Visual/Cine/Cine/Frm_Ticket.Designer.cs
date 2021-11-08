
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnImprimirTicket = new System.Windows.Forms.Button();
            this.lblNroTransaccion = new System.Windows.Forms.Label();
            this.lblNombreSuc = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblCantidadEntradas = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.DGVEntradas = new System.Windows.Forms.DataGridView();
            this.nroTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaFuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodButaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEntradas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEntradas)).BeginInit();
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
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 85);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 3;
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
            // DGVEntradas
            // 
            this.DGVEntradas.AllowUserToAddRows = false;
            this.DGVEntradas.AllowUserToDeleteRows = false;
            this.DGVEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroTransaccion,
            this.sucursal,
            this.Sala,
            this.Pelicula,
            this.diaFuncion,
            this.CodButaca,
            this.duracionPelicula,
            this.subtotal,
            this.subtotalDescuento,
            this.accion});
            this.DGVEntradas.Location = new System.Drawing.Point(37, 354);
            this.DGVEntradas.Name = "DGVEntradas";
            this.DGVEntradas.ReadOnly = true;
            this.DGVEntradas.RowTemplate.Height = 25;
            this.DGVEntradas.Size = new System.Drawing.Size(1043, 150);
            this.DGVEntradas.TabIndex = 10;
            // 
            // nroTransaccion
            // 
            this.nroTransaccion.HeaderText = "Transaccion";
            this.nroTransaccion.Name = "nroTransaccion";
            this.nroTransaccion.ReadOnly = true;
            // 
            // sucursal
            // 
            this.sucursal.HeaderText = "Sucursal";
            this.sucursal.Name = "sucursal";
            this.sucursal.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // Pelicula
            // 
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.ReadOnly = true;
            // 
            // diaFuncion
            // 
            this.diaFuncion.HeaderText = "Dia de la Funcion";
            this.diaFuncion.Name = "diaFuncion";
            this.diaFuncion.ReadOnly = true;
            // 
            // CodButaca
            // 
            this.CodButaca.HeaderText = "Butaca";
            this.CodButaca.Name = "CodButaca";
            this.CodButaca.ReadOnly = true;
            // 
            // duracionPelicula
            // 
            this.duracionPelicula.HeaderText = "Duracion pelicula";
            this.duracionPelicula.Name = "duracionPelicula";
            this.duracionPelicula.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // subtotalDescuento
            // 
            this.subtotalDescuento.HeaderText = "Subtotal Descuento";
            this.subtotalDescuento.Name = "subtotalDescuento";
            this.subtotalDescuento.ReadOnly = true;
            // 
            // accion
            // 
            this.accion.HeaderText = "accion";
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(1164, 555);
            this.Controls.Add(this.lblEntradas);
            this.Controls.Add(this.DGVEntradas);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblCantidadEntradas);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.lblNombreSuc);
            this.Controls.Add(this.lblNroTransaccion);
            this.Controls.Add(this.btnImprimirTicket);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.IdSucursal);
            this.Controls.Add(this.txtNroTicket);
            this.Controls.Add(this.lblNroTicket);
            this.Name = "Frm_Ticket";
            this.Text = "Frm_Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.DGVEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroTicket;
        private System.Windows.Forms.TextBox txtNroTicket;
        private System.Windows.Forms.Label IdSucursal;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnImprimirTicket;
        private System.Windows.Forms.Label lblNroTransaccion;
        private System.Windows.Forms.Label lblNombreSuc;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblCantidadEntradas;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.DataGridView DGVEntradas;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaFuncion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodButaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn accion;
    }
}