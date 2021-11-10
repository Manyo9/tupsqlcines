using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackend.Acceso_a_Datos
{
    public interface IReporteDao
    {
        public DataTable ImprimirTicket(int nroTicket, int idSucursal);
        public DataTable GetPeliSinVentas(DateTime fechaDesde, DateTime fechaHasta);
        public DataTable GetPeliMasVistas(DateTime fechaDesde, DateTime fechaHasta, int cant_min);
        public DataTable GetGananciasMensuales(int anio);
        public DataTable GetVentasPorSucursal(DateTime fechaDesde, DateTime fechaHasta);
        public DataTable GetPromVentasPorCajero(int anio);
        public DataTable GetEntradasPorTicket(int nroTicket, int idSucursal);
        public DataTable GetButacasDisponibles(int nroFuncion);
        public DataTable GetEntrada(int idDetalle);


    }
}
