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

        public bool agregarAnalisis(Entidades.Analisis an)
        {
            try
            {
                string codigo = an.Codigo.Trim();
                string nombre = an.Nombre.Trim();
                string nbu = an.CantNBU.Trim();
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
                    ana.Codigo = reader.GetString(1).Trim();
                    ana.Nombre = reader.GetString(2).Trim(); 
                    ana.CantNBU =reader.GetString(3).Trim();
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

        public List<Entidades.Analisis> getAllAnalisisbyCodigo(string codi)
        {
            try
            {
                string codigo = codi + "%";
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from Analisis where codigo like '"+codigo+"'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Entidades.Analisis> analisis = new List<Entidades.Analisis>();
                while (reader.Read())
                {
                    Entidades.Analisis ana = new Entidades.Analisis();
                    ana.Codigo = reader.GetString(1).Trim();
                    ana.Nombre = reader.GetString(2).Trim();
                    ana.CantNBU = reader.GetString(3).Trim();
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

        public Entidades.Analisis getAnalisisByCodigo(string codigo)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from Analisis where codigo ='"+codigo+"'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Entidades.Analisis ana = new Entidades.Analisis();
                    ana.Codigo = reader.GetString(1).Trim();
                    ana.Nombre = reader.GetString(2).Trim();
                    ana.CantNBU = reader.GetString(3).Trim();
                    ana.Id = reader.GetInt32(0);
                    return ana;
                }
                Conexion.getInstance().Disconnect();
                return null;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }
    }
}
