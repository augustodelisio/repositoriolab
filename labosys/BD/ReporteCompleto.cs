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
                SqlCommand cmd = new SqlCommand("select ae.costo, an.codigo, ex.id  ,ex.fecha, ex.costo , os.nombre , pa.nombre, pa.apellido,po.afiliado from dbo.AnalisisExamen ae inner join Examenes ex on ae.idExamen = ex.id inner join dbo.ObrasSociales os on ex.idOS = os.id inner join dbo.Analisis an on an.id = ae.idAnalisis inner join dbo.Pacientes pa on ex.idPaciente = pa.id inner join dbo.PacienteOS po on (po.idOS = ex.idOS and po.IdPaciente = pa.id); ", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Entidades.reporte> reportes = new List<Entidades.reporte>();
                while (reader.Read())
                {
                    Entidades.reporte rep = new Entidades.reporte();
                    rep.CostoAnalisis = reader.GetString(0);
                    rep.CodigoAnalisis = reader.GetString(1);
                    rep.Id = reader.GetInt32(2);
                    rep.Fecha = reader.GetDateTime(3);
                    rep.CostoTotal = reader.GetString(4);
                    rep.NombreOS = reader.GetString(5);
                    rep.Nombre = reader.GetString(6);
                    rep.Apellido = reader.GetString(7);
                    rep.Afiliado = reader.GetString(8);
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
