using CineBackend.Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Frm_Ticket : Form
    {

        private IReporteDao dao;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        ///
        /// para mover el form con el mouse
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }


        public Frm_Ticket()
        {
            InitializeComponent();
            dao = new ReporteDao();
        }

     
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Ticket_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimirTicket_Click(object sender, EventArgs e)
        {
            DataTable tablaTicket = dao.ImprimirTicket(Convert.ToInt32(txtNroTicket.Text), Convert.ToInt32(txtID.Text));
            lblNroTransaccion.Text = "Nro Transaccion: " + tablaTicket.Rows[0]["Nro de transacción"];
            lblNombreSuc.Text = "Nombre Sucursal: " + tablaTicket.Rows[0]["Sucursal"];
            lblFormaPago.Text = "Forma de Pago: " + tablaTicket.Rows[0]["Forma de pago"];
            lblCantidadEntradas.Text = "Cantidad de entradas: " + tablaTicket.Rows[0]["Cantidad de entradas"];
            lblTotalPagar.Text = "Total a Pagar: " + tablaTicket.Rows[0]["Total a pagar"];

            DGVEntradas.DataSource = dao.GetEntradasPorTicket(Convert.ToInt32(txtNroTicket.Text), Convert.ToInt32(txtID.Text));
            DataGridViewButtonColumn colAccion = new DataGridViewButtonColumn();
            colAccion.UseColumnTextForButtonValue = true;
            colAccion.Text = "Imprimir";
            colAccion.Name = "Accion";
            DGVEntradas.Columns.Add(colAccion);
            DGVEntradas.Columns["id_sucursal"].Visible = false;
        }
    }
}
