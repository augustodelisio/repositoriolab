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
            Entidades.Obra_Social obra = BD.ObraSocialDB.getInstance().buscarOsPorNombre(os.Nombre);
            if (obra == null)
            {
                return BD.ObraSocialDB.getInstance().agregarOS(os);
            }
            return false;
        }

        static public List<Entidades.Obra_Social> getAllObrasSociales()
        {
            return BD.ObraSocialDB.getInstance().getAllObrasSociales();
        }

        static public List<Entidades.Obra_Social> getAllObrasSocialesbyNombre(string nombre)
        {
            return BD.ObraSocialDB.getInstance().getAllObrasSocialesbyNombre(nombre);
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
            Entidades.Obra_Social obra = BD.ObraSocialDB.getInstance().buscarOsPorNombre(os.Nombre);
            if (obra == null || obra.Id==os.Id)
            {
                return BD.ObraSocialDB.getInstance().modificarOS(os);
            }
            return false;
        }

        public static Obra_Social buscarOsPorId(int idOS)
        {
            return BD.ObraSocialDB.getInstance().buscarOsPorId(idOS);
        }
    }
}
