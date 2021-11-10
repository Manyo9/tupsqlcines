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
    public partial class Frm_Rep_PelSinVentas : Form
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



        private IReporteDao dao;
        public Frm_Rep_PelSinVentas()
        {
            InitializeComponent();
            dao = new ReporteDao();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpFecha1.Value > dtpFecha2.Value)
            {
                MessageBox.Show("La fecha de inicio debe ser anterior a la de fin.");
                return;
            }
            CargarGrid();
        }
        private void CargarGrid()
        {
            DataTable tabla = new DataTable();
            tabla = dao.GetPeliSinVentas(dtpFecha1.Value, dtpFecha2.Value);
            dgvPelSinVentas.DataSource = tabla;
        }

        private void Frm_Rep_PelSinVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

      

       

    }
}
