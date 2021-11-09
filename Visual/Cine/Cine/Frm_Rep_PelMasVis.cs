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
        private IReporteDao dao;
        public Frm_Rep_PelMasVis()
        {
            InitializeComponent();
            dao = new ReporteDao();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (txtCantMin.Text.Trim().Equals("") || Convert.ToInt32(txtCantMin.Text) < 0)
            {
                MessageBox.Show("Ingrese un número mínimo de ventas válido. Puede ser cero.");
                return;
            }
            CargarGrid();
        }
        private void CargarGrid()
        {
            DataTable tabla;
            tabla = dao.GetPeliMasVistas(dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(txtCantMin.Text));
            DGVPelMasVistas.DataSource = tabla;
        }
    }
}
