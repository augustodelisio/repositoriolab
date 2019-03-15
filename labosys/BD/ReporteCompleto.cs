using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BD
{
    public class ReporteCompleto
    {
        private static ReporteCompleto instancia = null;

        public static ReporteCompleto getInstance()
        {
            if (ReporteCompleto.instancia == null)
            {
                ReporteCompleto.instancia = new ReporteCompleto();
            }
            return ReporteCompleto.instancia;
        }

        public List<Entidades.reporte> getAllReports()
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select ex.id ,ex.fecha, ex.costo , os.nombre , pa.nombre, pa.apellido,po.afiliado,ex.actoBioquimico from dbo.Examenes ex inner join dbo.ObrasSociales os on ex.idOS = os.id inner join dbo.Pacientes pa on ex.idPaciente = pa.id inner join dbo.PacienteOS po on (po.idOS = ex.idOS and po.IdPaciente = pa.id) order by ex.fecha", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Entidades.reporte> reportes = new List<Entidades.reporte>();
                while (reader.Read())
                {
                    Entidades.reporte rep = new Entidades.reporte();
                    //rep.CostoAnalisis = reader.GetString(0);
                    //rep.CodigoAnalisis = reader.GetString(1);
                    rep.Id = reader.GetInt32(0);
                    DateTime Fecha = reader.GetDateTime(1);
                    rep.Fecha = Fecha.ToShortDateString();
                    rep.CostoTotal = reader.GetString(2);
                    rep.NombreOS = reader.GetString(3);
                    rep.Nombre = reader.GetString(4);
                    rep.Apellido = reader.GetString(5);
                    rep.Afiliado = reader.GetString(6);
                    rep.ActoBioquimico = reader.GetString(7);
                    reportes.Add(rep);
                }
                Conexion.getInstance().Disconnect();
                return reportes;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }

        public List<Entidades.subreport> getAllSubReports(int id)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select codigo, costo, idExamen from dbo.Analisis an inner join dbo.AnalisisExamen ae on an.id= ae.idAnalisis where ae.idExamen ='" + id + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Entidades.subreport> reportes = new List<Entidades.subreport>();
                while (reader.Read())
                {
                    Entidades.subreport rep = new Entidades.subreport();
                    rep.CodigoAnalisis = reader.GetString(0);
                    rep.CostoAnalisis = reader.GetString(1);
                    rep.IdExamen = reader.GetInt32(2);
                    reportes.Add(rep);
                }
                Conexion.getInstance().Disconnect();
                return reportes;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }

        }

        public List<Entidades.reporte> getAllReportsPorFecha(string desde, string hasta)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select ex.id ,ex.fecha, ex.costo , os.nombre , pa.nombre, pa.apellido,po.afiliado,ex.actoBioquimico from dbo.Examenes ex inner join dbo.ObrasSociales os on ex.idOS = os.id inner join dbo.Pacientes pa on ex.idPaciente = pa.id inner join dbo.PacienteOS po on (po.idOS = ex.idOS and po.IdPaciente = pa.id) where(ex.fecha >= '"+desde+"' and ex.fecha <= '"+hasta+ "') order by ex.fecha", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Entidades.reporte> reportes = new List<Entidades.reporte>();
                while (reader.Read())
                {
                    Entidades.reporte rep = new Entidades.reporte();
                    //rep.CostoAnalisis = reader.GetString(0);
                    //rep.CodigoAnalisis = reader.GetString(1);
                    rep.Id = reader.GetInt32(0);
                    DateTime Fecha = reader.GetDateTime(1);
                    rep.Fecha = Fecha.ToShortDateString();
                    rep.CostoTotal = reader.GetString(2);
                    rep.NombreOS = reader.GetString(3);
                    rep.Nombre = reader.GetString(4);
                    rep.Apellido = reader.GetString(5);
                    rep.Afiliado = reader.GetString(6);
                    rep.ActoBioquimico = reader.GetString(7);
                    reportes.Add(rep);
                }
                Conexion.getInstance().Disconnect();
                return reportes;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }
        public List<Entidades.reporte> getAllReportsPorPaciente(string desde, string hasta,Entidades.Paciente pa)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select ex.id ,ex.fecha, ex.costo , os.nombre , pa.nombre, pa.apellido,po.afiliado,ex.actoBioquimico from dbo.Examenes ex inner join dbo.ObrasSociales os on ex.idOS = os.id inner join dbo.Pacientes pa on ex.idPaciente = pa.id inner join dbo.PacienteOS po on (po.idOS = ex.idOS and po.IdPaciente = pa.id) where(ex.fecha >= '" + desde + "' and ex.fecha <= '" + hasta + "' and pa.id='"+pa.Id+ "') order by ex.fecha", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Entidades.reporte> reportes = new List<Entidades.reporte>();
                while (reader.Read())
                {
                    Entidades.reporte rep = new Entidades.reporte();
                    //rep.CostoAnalisis = reader.GetString(0);
                    //rep.CodigoAnalisis = reader.GetString(1);
                    rep.Id = reader.GetInt32(0);
                    DateTime Fecha = reader.GetDateTime(1);
                    rep.Fecha = Fecha.ToShortDateString();
                    rep.CostoTotal = reader.GetString(2);
                    rep.NombreOS = reader.GetString(3);
                    rep.Nombre = reader.GetString(4);
                    rep.Apellido = reader.GetString(5);
                    rep.Afiliado = reader.GetString(6);
                    rep.ActoBioquimico = reader.GetString(7);
                    reportes.Add(rep);
                }
                Conexion.getInstance().Disconnect();
                return reportes;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }

        public List<Entidades.reporte> getAllReportsPorOS(string desde, string hasta, Entidades.Obra_Social os)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select ex.id ,ex.fecha, ex.costo , os.nombre , pa.nombre, pa.apellido,po.afiliado,ex.actoBioquimico from dbo.Examenes ex inner join dbo.ObrasSociales os on ex.idOS = os.id inner join dbo.Pacientes pa on ex.idPaciente = pa.id inner join dbo.PacienteOS po on (po.idOS = ex.idOS and po.IdPaciente = pa.id) where(ex.fecha >= '" + desde + "' and ex.fecha <= '" + hasta + "' and os.id='" + os.Id + "') order by ex.fecha", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Entidades.reporte> reportes = new List<Entidades.reporte>();
                while (reader.Read())
                {
                    Entidades.reporte rep = new Entidades.reporte();
                    //rep.CostoAnalisis = reader.GetString(0);
                    //rep.CodigoAnalisis = reader.GetString(1);
                    rep.Id = reader.GetInt32(0);
                    DateTime Fecha = reader.GetDateTime(1);
                    rep.Fecha = Fecha.ToShortDateString();
                    rep.CostoTotal = reader.GetString(2);
                    rep.NombreOS = reader.GetString(3);
                    rep.Nombre = reader.GetString(4);
                    rep.Apellido = reader.GetString(5);
                    rep.Afiliado = reader.GetString(6);
                    rep.ActoBioquimico = reader.GetString(7);
                    reportes.Add(rep);
                }
                Conexion.getInstance().Disconnect();
                return reportes;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }
    }

}
