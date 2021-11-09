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

        
    }
}
