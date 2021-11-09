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
    public partial class Frm_Butacas : Form
    {
        private IReporteDao dao;
        public Frm_Butacas()
        {
            InitializeComponent();
            dao = new ReporteDao();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (nudNro_funcion.Value.Equals(0))
            {
                MessageBox.Show("Ingresar el número de identificación de la función");
                return;
            }
            CargarGrid();
        }

        private void CargarGrid() {
            DataTable tabla = new DataTable();
            tabla = dao.GetButacasDisponibles(Convert.ToInt32(nudNro_funcion.Value));
            
            tabla.Columns["cod_butaca"].ColumnName = "Código Butaca";
            tabla.Columns.Remove("id_butaca");
            dgvButacas.DataSource = tabla;
            //foreach (DataRow fila in tabla.Rows)
            //{
            //    dgvButacas.Rows.Add(new object[] {String.Empty, fila["cod_butaca"].ToString()});
            //}
        }
    }
}
