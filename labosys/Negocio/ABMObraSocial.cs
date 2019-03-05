using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    static public class ABMObraSocial
    {
        static public void agregarOS(Entidades.Obra_Social os)
        {
            BD.OSColeccion.getInstance().agregarOS(os);
        }

        static public List<Entidades.Obra_Social> getAllObrasSociales()
        {
            return BD.OSColeccion.getInstance().getAllObrasSociales();
        }
    }
}
