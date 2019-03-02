using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   static public class ABMPaciente
    {
        static public void agregarPaciente(Entidades.Paciente pa)
        {
             BD.PacienteColecicon.getInstance().agregarPaciente(pa);
        }

        static public List<Entidades.Paciente> getAllPacientes()
        {
            return BD.PacienteColecicon.getInstance().getAllPacientes();
        }
    }
}
