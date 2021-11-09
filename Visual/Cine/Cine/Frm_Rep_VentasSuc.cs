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
    public partial class Frm_Rep_VentasSuc : Form
    {
        private IReporteDao dao;
        public Frm_Rep_VentasSuc()
        {
            InitializeComponent();
            dao = new ReporteDao();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
            {
                MessageBox.Show("La fecha de inicio debe ser anterior a la de fin.");
                return;
            }
            CargarGrid();
        }
        private void CargarGrid()
        {
            DataTable tabla = new DataTable();
            tabla = dao.GetVentasPorSucursal(dtpFechaInicio.Value, dtpFechaFin.Value);
            tabla.Columns.Remove("id_sucursal");
            dgvVentasSuc.DataSource = tabla;
        }
    }
}
