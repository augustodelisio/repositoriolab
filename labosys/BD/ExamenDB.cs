using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Entidades;

namespace BD
{
    public class ExamenDB
    {
        private static ExamenDB instancia = null;

        public static ExamenDB getInstance()
        {
            if (ExamenDB.instancia == null)
            {
                ExamenDB.instancia = new ExamenDB();
            }
            return ExamenDB.instancia;
        }

        public void agregarAnalisisAlExamen(Examen examen, Analisis ana, float costo)
        {
            try
            {
                string scosto = costo.ToString();
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.AnalisisExamen(costo,idAnalisis,idExamen) " +
                    "values('" + scosto + "','" + ana.Id + "','" + examen.IdExamen + "')", Conexion.getInstance().Conection);
                cmd.ExecuteNonQuery();
                Conexion.getInstance().Disconnect();
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
            }
        }

        public bool agregarCosto(float costoExamen, Examen examen)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("update dbo.Examenes set costo='" + costoExamen + "'where  id='" + examen.IdExamen + "'", Conexion.getInstance().Conection);
                cmd.ExecuteNonQuery();
                Conexion.getInstance().Disconnect();
                return true;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return false;
            }
        }

        public Entidades.Examen agregarExamen(Entidades.Examen ex)
        {
            try
            {
                string fecha = ex.Fecha.ToString("yyyyMMdd");
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Examenes(fecha,idPaciente,idOS,costo,actoBioquimico) " +
                    "values('" + fecha + "','" + ex.IdPaciente + "','" + ex.IdOS + "','"+"0"+"','"+ex.ActoBioquimico+"')", Conexion.getInstance().Conection);
                cmd.ExecuteNonQuery();
                Conexion.getInstance().Disconnect();
                return buscarIdExamen(ex);
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }

        public Entidades.Examen buscarIdExamen(Entidades.Examen ex)
        {
            
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd1 = new SqlCommand("select MAX(id) from dbo.Examenes;", Conexion.getInstance().Conection);
                ex.IdExamen = (int)cmd1.ExecuteScalar();
                Conexion.getInstance().Disconnect();
                return ex;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return ex;
            }
        }

    }
}
