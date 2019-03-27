using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    static public class ABMPaciente
    {
        static public bool agregarPaciente(Entidades.Paciente pa)
        {
            Entidades.Paciente pacienteEncontrado = BD.PacienteDB.getInstance().getPacientesbyDNI(pa.Dni);
            if (pacienteEncontrado == null)
            {
                return BD.PacienteDB.getInstance().agregarPaciente(pa);
            }
            return false;
        }

        static public List<Entidades.Paciente> getAllPacientes()
        {
            return BD.PacienteDB.getInstance().getAllPacientes();
        }

        static public bool deshabilitarPaciente(Entidades.Paciente pa)
        {
            return BD.PacienteDB.getInstance().deshabilitarPaciente(pa);
        }

        public static List<Entidades.PacienteOS> getAllOS(Paciente pa)
        {
            return BD.PacienteDB.getInstance().getAllOS(pa);
        }

        static public bool habilitarPaciente(Entidades.Paciente pa)
        {
            return BD.PacienteDB.getInstance().habilitarPaciente(pa);
        }

      
        static public List<Entidades.Paciente> getAllPacientesbyDNI(string Dni)
        {
            return BD.PacienteDB.getInstance().getAllPacientesbyDNI(Dni);
        }

        static public List<Entidades.Paciente> getAllPacientesbyApellido(string Apellido)
        {
            return BD.PacienteDB.getInstance().getAllPacientesbyApellido(Apellido);
        }


        public static bool agregarOsaPaciente(PacienteOS paos)
        {
            bool existe = BD.ObraSocialDB.getInstance().buscarAfiliadoOS(paos);
            if (existe==false)
            {
                Entidades.Paciente pa = new Entidades.Paciente();
                pa.Id = paos.IdPaciente;
                List<Entidades.PacienteOS> oss = BD.PacienteDB.getInstance().getAllOS(pa);
                foreach (Entidades.PacienteOS os in oss)
                {
                    if (os.Id == paos.IdOS)
                    {
                        return false;
                    }
                }
                return BD.PacienteDB.getInstance().agregarOsaPaciente(paos);
            }
            return false;
        }

        static public bool modificarPaciente(Entidades.Paciente pa)
        {
            Entidades.Paciente pacienteEncontrado = BD.PacienteDB.getInstance().getPacientesbyDNI(pa.Dni);
            if (pacienteEncontrado == null || pacienteEncontrado.Id ==pa.Id)
            {
                return BD.PacienteDB.getInstance().modificarPaciente(pa);
            }
            return false;
        }
    }
}
