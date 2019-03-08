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

        public bool agregarOsaPaciente(PacienteOS paos)
        {
            try
            {

                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.PacienteOS(idOS,IdPaciente,afiliado) " +
                    "values('" + paos.IdOS + "','" + paos.IdPaciente + "','" + paos.NroAfiliado + "')", Conexion.getInstance().Conection);
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
    

        public List<PacienteOS> getAllOS(Paciente pa)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from dbo.PacienteOS where IdPaciente='"+pa.Id+"'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<PacienteOS> pacos = new List<PacienteOS>();
                while (reader.Read())
                {
                    Entidades.PacienteOS pos = new PacienteOS();
                    pos.Id = reader.GetInt32(0);
                    pos.NroAfiliado = reader.GetString(3);
                    pos.IdOS = reader.GetInt32(1);
                    pos.IdPaciente = reader.GetInt32(2);
                    Entidades.Obra_Social os = new Entidades.Obra_Social();
                    os = ObraSocialDB.getInstance().buscarOSporId(pos.IdOS);
                    pos.NombreOS = os.Nombre;
                    //agrega a pos el nombre de la os
                    pacos.Add(pos); 

                }
                Conexion.getInstance().Disconnect();
                return pacos ;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
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

        public List<Entidades.Paciente> getAllPacientesbyDNI(string Dni)
        {
            try
            {
                Conexion.getInstance().Connect();
                string DNI = "%" + Dni + "%";
                SqlCommand cmd = new SqlCommand("select * from Pacientes where CONVERT(VARCHAR,dni) like '"+DNI+"'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Entidades.Paciente> pacientes = new List<Entidades.Paciente>();
                while (reader.Read())
                {
                    string apellido = reader.GetString(0);
                    string nombre = reader.GetString(1);
                    string dni = reader.GetString(2);
                    int id = reader.GetInt32(4);
                    Entidades.Paciente pa = new Entidades.Paciente(apellido, nombre, dni);
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
