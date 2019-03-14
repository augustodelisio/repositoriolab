using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Entidades;

namespace BD
{
    public class ObraSocialDB
    {
        private static ObraSocialDB instancia = null;

        public static ObraSocialDB getInstance()
        {
            if (ObraSocialDB.instancia == null)
            {
                ObraSocialDB.instancia = new ObraSocialDB();
            }
            return ObraSocialDB.instancia;
        }

        public bool agregarOS(Entidades.Obra_Social os)
        {
            try
            {
                string nombre = os.Nombre;
                string porcentaje = os.Porcentaje;
                string nbu = os.Nbu;
                bool habilitado = true;
                string actoBioquimico = os.ActoBioquimico;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.ObrasSociales(nombre,porcentaje,nbu, habilitado, actoBioquimico) " +
                    "values('" + nombre + "','" + porcentaje + "','" + nbu + "','" + habilitado + "','" + actoBioquimico + "')", Conexion.getInstance().Conection);
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

        public Obra_Social buscarOsPorId(int idOS)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from ObrasSociales where id='" + idOS + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string nombre = reader.GetString(0);
                    string porcentaje = reader.GetString(1);
                    string nbu = reader.GetString(2);
                    int id = reader.GetInt32(3);
                    string actoBioquimico = reader.GetString(5);
                    Entidades.Obra_Social os = new Entidades.Obra_Social(nombre, porcentaje, nbu, actoBioquimico);
                    os.Habilitado = reader.GetBoolean(4);
                    os.Id = id;

                    Conexion.getInstance().Disconnect();
                    return os;
                }
                else { return null; }
            }
            catch (Exception e)
            {

                Conexion.getInstance().Disconnect();
                return null;
            }
        }

        public List<Entidades.Obra_Social> getAllObrasSociales()
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from ObrasSociales", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Entidades.Obra_Social> obrasSociales = new List<Entidades.Obra_Social>();
                while (reader.Read())
                {
                    string nombre = reader.GetString(0);
                    string porcentaje = reader.GetString(1);
                    string nbu = reader.GetString(2);
                    int id = reader.GetInt32(3);
                    string actoBioquimico = reader.GetString(5);
                    Entidades.Obra_Social os = new Entidades.Obra_Social(nombre, porcentaje, nbu, actoBioquimico);
                    os.Habilitado = reader.GetBoolean(4);
                    os.Id = id;
                    obrasSociales.Add(os);
                }
                Conexion.getInstance().Disconnect();
                return obrasSociales;
            }
            catch (Exception e)
            {

                Conexion.getInstance().Disconnect();
                return null;
            }
        }

        internal Obra_Social buscarOSporId(int idOS)
        {
            try
            {
                int id = idOS;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from ObrasSociales where id='" + id + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string nombre = reader.GetString(0);
                    Entidades.Obra_Social os = new Entidades.Obra_Social();
                    os.Nombre = nombre;
                    os.Id = id;
                    Conexion.getInstance().Disconnect();
                    return os;
                }
                return null;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }

        public bool deshabilitarOS(Entidades.Obra_Social os)
        {
            try
            {
                Conexion.getInstance().Connect();
                bool habilitado = false;
                SqlCommand cmd = new SqlCommand("update dbo.ObrasSociales set habilitado='" + habilitado + "'where  id='" + os.Id + "'", Conexion.getInstance().Conection);
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

        public bool habilitarOS(Entidades.Obra_Social os)
        {
            try
            {
                Conexion.getInstance().Connect();
                bool habilitado = true;
                SqlCommand cmd = new SqlCommand("update dbo.ObrasSociales set habilitado='" + habilitado + "'where  id='" + os.Id + "'", Conexion.getInstance().Conection);
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

        public bool modificarOS(Entidades.Obra_Social os)
        {
            try
            {
                string nombre = os.Nombre;
                string porcentaje = os.Porcentaje;
                string nbu = os.Nbu;
                string actoBioquimico = os.ActoBioquimico;
                int id = os.Id;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("update dbo.ObrasSociales set nombre='" + nombre + "',porcentaje='"
                    + porcentaje + "',nbu='"
                    + nbu + "',actoBioquimico='" + actoBioquimico
                    + "'where  id='" + id + "'", Conexion.getInstance().Conection);
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
    }
}
