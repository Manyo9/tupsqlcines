using CineBackend.Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintDialog printDialog = new PrintDialog();
        public Frm_Entrada(int id_detalle)
        {
            InitializeComponent();
            dao = new ReporteDao();
            detalle = id_detalle;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
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

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDialog.Document = printDocument1;
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument1.Print();

            }

        }
        Bitmap memoryImage;
        Size s;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            s = this.Size;
            s.Width -= 15;
            s.Height -= 110;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X + 15, this.Location.Y + 40, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            int altura = Convert.ToInt32(s.Height / 1.41);
            int ancho = Convert.ToInt32(s.Width / 1.41);
            e.Graphics.DrawImage(memoryImage, 0, 0,ancho,altura);
            //e.Graphics.DrawString(label1.Text, label1.Font, Brushes.Black, new RectangleF(0,10,250,150));
        }

    }
}
