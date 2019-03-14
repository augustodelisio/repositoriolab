using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    static public class ABMObraSocial
    {
        static public bool agregarOS(Entidades.Obra_Social os)
        {
           return BD.ObraSocialDB.getInstance().agregarOS(os);
        }

        static public List<Entidades.Obra_Social> getAllObrasSociales()
        {
            return BD.ObraSocialDB.getInstance().getAllObrasSociales();
        }

        static public bool deshabilitarOS(Entidades.Obra_Social os)
        {
            return BD.ObraSocialDB.getInstance().deshabilitarOS(os);
        }

        static public bool habilitarOS(Entidades.Obra_Social os)
        {
            return BD.ObraSocialDB.getInstance().habilitarOS(os);
        }

        static public bool modificarOS(Entidades.Obra_Social os)
        {
            return BD.ObraSocialDB.getInstance().modificarOS(os);
        }

        public static Obra_Social buscarOsPorId(int idOS)
        {
            return BD.ObraSocialDB.getInstance().buscarOsPorId(idOS);
        }
    }
}
