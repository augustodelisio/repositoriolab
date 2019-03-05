using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static public bool habilitarPaciente(Entidades.Paciente pa)
        {
            return BD.PacienteDB.getInstance().habilitarPaciente(pa);
        }

        static public Entidades.Paciente buscarPacientePorDni(string dni)
        {
            return BD.PacienteDB.getInstance().buscarPacientePorDni(dni);
        }

        static public bool modificarPaciente(Entidades.Paciente pa)
        {
            return BD.PacienteDB.getInstance().modificarPaciente(pa);
        }
    }
}
