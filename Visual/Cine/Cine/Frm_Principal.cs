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
    }
}
