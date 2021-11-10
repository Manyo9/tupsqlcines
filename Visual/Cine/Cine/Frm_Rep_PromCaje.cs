using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineBackend.Acceso_a_Datos;

namespace Cine
{
    public partial class Frm_Rep_PromCaje : Form
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
        public Frm_Rep_PromCaje()
        {
            InitializeComponent();
            dao = new ReporteDao();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (nud_Año_Prom_caje.Value.Equals(0) || Convert.ToInt32(nud_Año_Prom_caje.Value) > DateTime.Now.Year)
            {
                MessageBox.Show("Ingresar un año válido");
                return;
            }
            CargarGrid();
        }
        private void CargarGrid()
        {
            DataTable tabla = new DataTable();
            tabla = dao.GetPromVentasPorCajero(Convert.ToInt32(nud_Año_Prom_caje.Value));
            dgvPromCaje.DataSource = tabla;
            dgvPromCaje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromCaje.Columns["Importe promedio de venta"].DefaultCellStyle.Format = "c2";
            dgvPromCaje.Columns["Importe promedio de venta"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es_AR");
        }

        private void Frm_Rep_PromCaje_Load(object sender, EventArgs e)
        {
           nud_Año_Prom_caje.Value = DateTime.Now.Year;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
