﻿using CineBackend.Acceso_a_Datos;
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
        }

        private void Frm_Rep_GanMens_Load(object sender, EventArgs e)
        {
            nudGan_mens.Value = DateTime.Now.Year;  
        }
    }
}
