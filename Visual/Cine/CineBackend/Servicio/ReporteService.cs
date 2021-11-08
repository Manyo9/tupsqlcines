using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackend.Servicio
{
    class ReporteService : IReporteService
    { 
        public DataTable GetGananciasMensuales(int anio)
        {
            throw new NotImplementedException();
        }

        public DataTable GetPeliMasVistas(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NotImplementedException();
        }

        public DataTable GetPeliSinVentas(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NotImplementedException();
        }

        public DataTable GetPromVentasPorCajero(int anio)
        {
            throw new NotImplementedException();
        }

        public DataTable GetVentasPorSucursal(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NotImplementedException();
        }

        public DataTable ImprimirTicket(int nroTicket, int idSucursal)
        {
            throw new NotImplementedException();
        }
    }
}
