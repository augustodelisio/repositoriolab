using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ABMReporte
    {
        public static List<Entidades.reporte> getAllReports()
        {
            return BD.ReporteCompleto.getInstance().getAllReports();
        }
        public static List<Entidades.subreport> getAllSubReports(int id)
        {
            return BD.ReporteCompleto.getInstance().getAllSubReports(id);
        }
        public static List<Entidades.reporte> getAllReportsPorFecha(string desde,string hasta)
        {
            return BD.ReporteCompleto.getInstance().getAllReportsPorFecha(desde,hasta);
        }
        public static List<Entidades.reporte> getAllReportsPorPaciente(string desde, string hasta, Entidades.Paciente pa)
        {
            return BD.ReporteCompleto.getInstance().getAllReportsPorPaciente(desde, hasta,pa);
        }
    }
}
