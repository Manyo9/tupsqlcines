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
    public partial class Frm_Rep_GanMens : Form
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
        
        public Frm_Rep_GanMens()
        {
            InitializeComponent();
            dao = new ReporteDao();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (nudGan_mens.Value.Equals(0) || Convert.ToInt32(nudGan_mens.Value) > DateTime.Now.Year)
            {
                MessageBox.Show("Ingresar un año válido");
                return;
            }
            CargarGrid();
        }

        private void CargarGrid()
        {
            DataTable tabla = new DataTable();
            tabla = dao.GetGananciasMensuales(Convert.ToInt32(nudGan_mens.Value));
            dgvGananciaMen.DataSource = tabla;
            dgvGananciaMen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Frm_Rep_GanMens_Load(object sender, EventArgs e)
        {
            nudGan_mens.Value = DateTime.Now.Year;  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void nudGan_mens_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblAño_Click(object sender, EventArgs e)
        {

        }
    }
}
