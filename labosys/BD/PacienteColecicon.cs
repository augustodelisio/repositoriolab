using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class PacienteColecicon
    {
       

        //defino la propiedad coleccion pacientes
        private List<Entidades.Paciente> pacientes;

        //crear la colleccion
        public PacienteColecicon()
        {
            pacientes = new List<Entidades.Paciente>();
        }

        //hacer singleton la clase
        private static PacienteColecicon instancia = null;

        public static PacienteColecicon getInstance()
        {
            if (PacienteColecicon.instancia == null)
            {
                PacienteColecicon.instancia = new PacienteColecicon();
            }
            return PacienteColecicon.instancia;
        }

        //Agrega paciente a la coleccion
        public void agregarPaciente(Entidades.Paciente pa)
        {
            pacientes.Add(pa);
        }

        //devuelve todos los pacientes
        public List<Entidades.Paciente> getAllPacientes()
        {
            return pacientes;
        }
    }
}
