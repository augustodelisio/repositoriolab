using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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

        public Entidades.Examen agregarExamen(Entidades.Examen ex)
        {
            try
            {

                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Examenes(fecha,idPaciente,idOS) " +
                    "values('" + ex.Fecha + "','" + ex.IdPaciente + "','" + ex.IdOS + "');select SCOPE_IDENTITY() AS [id]", Conexion.getInstance().Conection);
                cmd.ExecuteNonQuery();
                ex.IdExamen = (int)cmd.ExecuteScalar();
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
