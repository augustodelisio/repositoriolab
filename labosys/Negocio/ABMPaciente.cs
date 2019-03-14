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
           return BD.PacienteDB.getInstance().agregarPaciente(pa);
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


        public static bool agregarOsaPaciente(PacienteOS paos)
        {
            return BD.PacienteDB.getInstance().agregarOsaPaciente(paos);
        }

        static public bool modificarPaciente(Entidades.Paciente pa)
        {
            return BD.PacienteDB.getInstance().modificarPaciente(pa);
        }
    }
}
