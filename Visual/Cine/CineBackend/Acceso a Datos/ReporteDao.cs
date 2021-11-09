using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackend.Acceso_a_Datos
{
    class ReporteDao : IReporteDao
    {
        private DaoHelper helper;

        public ReporteDao()
        {
            helper = new DaoHelper();
        }
        public DataTable GetGananciasMensuales(int anio)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@año", anio));
            DataTable resultado = helper.ConsultarConParametro("pa_reporte_ganancias_mensuales", lst);
            return resultado;

        }
        public DataTable GetPeliMasVistas(DateTime fechaDesde, DateTime fechaHasta, int cant_min)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha1", fechaDesde));//convertir si es necesario
            lst.Add(new Parametro("@fecha2", fechaHasta));
            lst.Add(new Parametro("@cant_min", cant_min));
            DataTable resultado = helper.ConsultarConParametro("pa_pelicula_mas_vista", lst);
            return resultado;
        }
        public DataTable GetPeliSinVentas(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha1", fechaDesde));//convertir si es necesario
            lst.Add(new Parametro("@fecha2", fechaHasta));
            DataTable resultado = helper.ConsultarConParametro("pa_peliculas_sin_ventas", lst);
            return resultado;
        }
        public DataTable GetPromVentasPorCajero(int anio)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@año", anio));
            DataTable resultado = helper.ConsultarConParametro("pa_ventas_promedio_por_cajero", lst);
            return resultado;
        }
        public DataTable GetVentasPorSucursal(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha_1", fechaDesde));//convertir si es necesario
            lst.Add(new Parametro("@fecha_2", fechaHasta));
            DataTable resultado = helper.ConsultarConParametro("pa_reporte_entradas_sucursal", lst);
            return resultado;
        }
        public DataTable GetEntradasPorTicket(int nroTicket, int idSucursal)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@nro_ticket", nroTicket));
            lst.Add(new Parametro("@id_sucursal", idSucursal));
            DataTable resultado = helper.ConsultarConParametro("pa_entradas_por_ticket", lst);
            return resultado;
        }
        public DataTable ImprimirTicket(int nroTicket, int idSucursal)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@nro_ticket", nroTicket));
            lst.Add(new Parametro("@id_sucursal", idSucursal));
            DataTable resultado = helper.ConsultarConParametro("pa_imprimir_ticket", lst);
            return resultado;
        }

        public DataTable GetButacasDisponibles(int nroFuncion)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@funcion", nroFuncion));
            DataTable resultado = helper.ConsultarConParametro("pa_butacas_disp_funcion", lst);
            return resultado;
        }
    }
}
