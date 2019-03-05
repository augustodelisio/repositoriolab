using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class OSColeccion
    {
       
        //defino la propiedad coleccion pacientes
        private List<Entidades.Obra_Social> obrasSociales;

        //crear la colleccion
        public OSColeccion()
        {
            obrasSociales = new List<Entidades.Obra_Social>();
        }

        //hacer singleton la clase
        private static OSColeccion instancia = null;

        public static OSColeccion getInstance()
        {
            if (OSColeccion.instancia == null)
            {
                OSColeccion.instancia = new OSColeccion();
            }
            return OSColeccion.instancia;
        }

        //Agrega paciente a la coleccion
        public void agregarOS(Entidades.Obra_Social os)
        {
            obrasSociales.Add(os);
        }

        //devuelve todos los pacientes
        public List<Entidades.Obra_Social> getAllObrasSociales()
        {
            return obrasSociales;
        }
    }
}
