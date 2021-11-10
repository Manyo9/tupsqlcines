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

        private void Frm_Butacas_Load(object sender, EventArgs e)
        {

        }
    }
}
