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
       
        //hacer singleton la clase
        private static ObraSocialDB instancia = null;

        public static ObraSocialDB getInstance()
        {
            if (ObraSocialDB.instancia == null)
            {
                ObraSocialDB.instancia = new ObraSocialDB();
            }
            return ObraSocialDB.instancia;
        }

        //Agrega OS a la coleccion
        public bool agregarOS(Entidades.Obra_Social os)
        {
            try
            {
                string nombre = os.Nombre;
                string porcentaje = os.Porcentaje;
                string arancel = os.Arancel;
                bool tipo = os.Tipo;
                bool habilitado = true;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.ObrasSociales(nombre,porcentaje,tipo,arancel, habilitado) " +
                    "values('" + nombre + "','" + porcentaje + "','" + tipo + "','" + arancel + "','" + habilitado + "')", Conexion.getInstance().Conection);
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

        //devuelve las OS--------------------------------------------------------------------------
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
                    bool tipo = reader.GetBoolean(2);
                    string arancel = reader.GetString(3);
                    int id = reader.GetInt32(4);
                    Entidades.Obra_Social os = new Entidades.Obra_Social(nombre, porcentaje, tipo, arancel);
                    os.Habilitado = reader.GetBoolean(5);
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

        //Deshabilitar OS--------------------------------------------------------------------------
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

        //HABILITAR OS--------------------------------------------------------------------------
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

        //MODIFICAR OS--------------------------------------------------------------------------
        public bool modificarOS(Entidades.Obra_Social os)
        {
            try
            {
                string nombre = os.Nombre;
                string porcentaje = os.Porcentaje;
                bool tipo = os.Tipo;
                string arancel = os.Arancel;
                int id = os.Id;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("update dbo.ObrasSociales set nombre='" + nombre + "',porcentaje='"
                    + porcentaje + "',tipo='"
                    + tipo + "',arancel='" + arancel
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
