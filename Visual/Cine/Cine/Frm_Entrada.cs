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
    public partial class Frm_Entrada : Form
    {
        private IReporteDao dao;
        private int detalle;
        public Frm_Entrada(int id_detalle)
        {
            InitializeComponent();
            dao = new ReporteDao();
            detalle = id_detalle;
        }

        private void Frm_Entrada_Load(object sender, EventArgs e)
        {
            DataTable tablaDetalles = new DataTable();
            tablaDetalles = dao.GetEntrada(detalle);
            lblTransaccion.Text = "Nro de Transaccion: " + tablaDetalles.Rows[0]["Nro de transacción"].ToString();
            lblSucursal.Text = "Nombre Sucursal: " + tablaDetalles.Rows[0]["Nombre sucursal"].ToString(); 
            lblSala1.Text = "Nombre sala: " + tablaDetalles.Rows[0]["Nombre sala"].ToString();
            lblSala2.Text = "Nombre sala: " + tablaDetalles.Rows[0]["Nombre sala"].ToString();
            lblPelicula1.Text = "Pelicula: " + tablaDetalles.Rows[0]["Nombre Pelicula"].ToString();
            lblPelicula2.Text = "Pelicula: " + tablaDetalles.Rows[0]["Nombre Pelicula"].ToString();
            lblDuracion1.Text = "Duracion: " + tablaDetalles.Rows[0]["Duracion de la película"].ToString();
            lblDuracion2.Text = "Duracion: " + tablaDetalles.Rows[0]["Duracion de la película"].ToString();
            lblDia1.Text = "Día: " + Convert.ToDateTime(tablaDetalles.Rows[0]["Dia de la función"]).ToString("dd/MM/yyyy");
            lblDia2.Text = "Día: " + Convert.ToDateTime(tablaDetalles.Rows[0]["Dia de la función"]).ToString("dd/MM/yyyy");
            lblHora1.Text = "Hora de inicio: " + tablaDetalles.Rows[0]["Hora de inicio"].ToString();
            lblHora2.Text = "Hora de inicio: " + tablaDetalles.Rows[0]["Hora de inicio"].ToString();
            lblButaca.Text = "Butaca: " + tablaDetalles.Rows[0]["Código butaca"].ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
