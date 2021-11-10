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


    public partial class Frm_Rep_PelMasVis : Form
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
        public Frm_Rep_PelMasVis()
        {
            InitializeComponent();
            dao = new ReporteDao();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (nudCant_min_entradas.Value < 0)
            {
                MessageBox.Show("Ingrese un número mínimo de ventas válido. Puede ser cero.");
                return;
            }
            CargarGrid();
        }
        private void CargarGrid()
        {
            DataTable tabla;
            tabla = dao.GetPeliMasVistas(dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(nudCant_min_entradas.Value - 1));
            DGVPelMasVistas.DataSource = tabla;
            DGVPelMasVistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
