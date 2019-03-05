using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace BD
{
    public class PacienteDB
    {
      

        //hacer singleton la clase
        private static PacienteDB instancia = null;

        public static PacienteDB getInstance()
        {
            if (PacienteDB.instancia == null)
            {
                PacienteDB.instancia = new PacienteDB();
            }
            return PacienteDB.instancia;
        }

        //Agrega paciente a la coleccion
        public bool agregarPaciente(Entidades.Paciente pa)
        {
            try
            {
                string nombre = pa.Nombre;
                string apellido = pa.Apellido;
                string dni = pa.Dni;
                bool habilitado = true;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Pacientes(apellido,nombre,dni,habilitado) " +
                    "values('" + apellido + "','" + nombre + "','" + dni + "','" + habilitado + "')", Conexion.getInstance().Conection);
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
        public List<Entidades.Paciente> getAllPacientes()
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from Pacientes", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Entidades.Paciente> pacientes = new List<Entidades.Paciente>();
                while (reader.Read())
                {
                    string apellido = reader.GetString(0);
                    string nombre = reader.GetString(1);
                    string dni = reader.GetString(2);
                    int id = reader.GetInt32(4);
                    Entidades.Paciente pa = new Entidades.Paciente(apellido,nombre,dni);
                    pa.Habilitado = reader.GetBoolean(3);
                    pa.Id = id;
                    pacientes.Add(pa);
                }
                Conexion.getInstance().Disconnect();
                return pacientes;
            }
            catch (Exception e)
            {
               
                Conexion.getInstance().Disconnect();
                return null;
            }


        }

        public bool deshabilitarPaciente(Entidades.Paciente pa)
        {
            try
            {
                Conexion.getInstance().Connect();
                bool habilitado = false;
                SqlCommand cmd = new SqlCommand("update dbo.Pacientes set habilitado='" + habilitado + "'where  id='" + pa.Id + "'", Conexion.getInstance().Conection);
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

        public bool habilitarPaciente(Entidades.Paciente pa)
        {
            try
            {
                Conexion.getInstance().Connect();
                bool habilitado = true;
                SqlCommand cmd = new SqlCommand("update dbo.Pacientes set habilitado='" + habilitado + "'where  id='" + pa.Id + "'", Conexion.getInstance().Conection);
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

        public bool modificarPaciente(Entidades.Paciente paciente)
        {
            try
            {
                string nombre = paciente.Nombre;
                string dni = paciente.Dni;
                string apellido = paciente.Apellido;
                int id = paciente.Id;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("update dbo.Pacientes set nombre='" + nombre + "',apellido='"
                    + apellido + "',dni='"
                    + dni + "'where  id='" + id + "'", Conexion.getInstance().Conection);
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

        public Entidades.Paciente buscarPacientePorDni(string dni)
        {
            //foreach (Entidades.Paciente pa in pacientes)
            //{
            //    if (pa.Dni == dni)
            //    {
            //        return pa;
            //    }
           // }
            return null;
        }
    }
}
