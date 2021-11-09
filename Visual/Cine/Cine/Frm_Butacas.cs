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
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtFuncion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingresar el número de identificación de la función");
                return;
            }
            CargarGrid();
        }

        private void CargarGrid() { 
            
        }
    }
}
