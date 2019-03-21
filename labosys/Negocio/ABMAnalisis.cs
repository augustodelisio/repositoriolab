using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ABMAnalisis
    {

        static public List<Entidades.Analisis> getAllAnalisis()
        {
            return BD.AnalisisDB.getInstance().getAllAnalisis();
        }
        static public bool agregarAnalisis(Entidades.Analisis ana)
        {
            Entidades.Analisis analisis = BD.AnalisisDB.getInstance().getAnalisisByCodigo(ana.Codigo);
            if (analisis == null)
            {
                return BD.AnalisisDB.getInstance().agregarAnalisis(ana);
            }
            return false;
        }
        static public bool modificarAnalisis(Entidades.Analisis ana)
        { Entidades.Analisis analisis = BD.AnalisisDB.getInstance().getAnalisisByCodigo(ana.Codigo);
            if (analisis == null || ana.Id== analisis.Id)
            {
                return BD.AnalisisDB.getInstance().modificarAnalisis(ana);
            }
            return false;
        }



    }

}
