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
    public partial class Frm_Principal : Form
    {


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
        public Frm_Principal()
        {
            InitializeComponent();
        }

       

        private void butacasVendidasPorFuncionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Butacas nuevo = new Frm_Butacas();
            nuevo.ShowDialog();
        }

        private void imprimirTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Ticket nuevo = new Frm_Ticket();
            nuevo.ShowDialog();
        }

        private void peliculasSinVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Rep_PelSinVentas nuevo = new Frm_Rep_PelSinVentas();
            nuevo.ShowDialog();
        }

        private void peliculasMásVistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Rep_PelMasVis nuevo = new Frm_Rep_PelMasVis();
            nuevo.ShowDialog();

        }

        private void gananciasMensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Rep_GanMens nuevo = new Frm_Rep_GanMens();
            nuevo.ShowDialog();
        }

        private void ventasPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Rep_VentasSuc nuevo = new Frm_Rep_VentasSuc();
            nuevo.ShowDialog();
        }

        private void promVentasPorCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Rep_PromCaje nuevo = new Frm_Rep_PromCaje();
            nuevo.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMAximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMAximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMAximizar.Visible = true;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
