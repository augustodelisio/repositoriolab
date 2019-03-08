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
    public class AnalisisDB
    {
        //hacer singleton la clase
        private static AnalisisDB instancia = null;

        public static AnalisisDB getInstance()
        {
            if (AnalisisDB.instancia == null)
            {
                AnalisisDB.instancia = new AnalisisDB();
            }
            return AnalisisDB.instancia;
        }

        public bool modificarAnalisis(Analisis ana)
        {
            try
            {             
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("update dbo.Analisis set codigo='" + ana.Codigo + "',nombre='"
                    + ana.Nombre + "',cantNBU='"
                    + ana.CantNBU + "'where  id='" + ana.Id+ "'", Conexion.getInstance().Conection);
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

        //Agrega paciente a la coleccion
        public bool agregarAnalisis(Entidades.Analisis an)
        {
            try
            {
                string codigo = an.Codigo;
                string nombre = an.Nombre;
                string nbu = an.CantNBU;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Analisis(codigo,nombre,cantNBU) " +
                    "values('" + codigo + "','" + nombre + "','"+ nbu + "')", Conexion.getInstance().Conection);
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

        //devuelve todos los pacientes
        public List<Entidades.Analisis> getAllAnalisis()
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from Analisis", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Entidades.Analisis> analisis = new List<Entidades.Analisis>();
                while (reader.Read())
                {
                    Entidades.Analisis ana = new Entidades.Analisis();
                    ana.Codigo = reader.GetString(1);
                    ana.Nombre = reader.GetString(2);
                    ana.CantNBU =reader.GetString(3);
                    ana.Id = reader.GetInt32(0);
                    analisis.Add(ana);
                }
                Conexion.getInstance().Disconnect();
                return analisis;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }
    }
}
