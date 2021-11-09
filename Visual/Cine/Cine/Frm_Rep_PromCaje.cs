using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineBackend.Acceso_a_Datos;

namespace Cine
{
    public partial class Frm_Rep_PromCaje : Form
    {
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
        }

        private void Frm_Rep_PromCaje_Load(object sender, EventArgs e)
        {
           nud_Año_Prom_caje.Value = DateTime.Now.Year;
        }
    }
}
