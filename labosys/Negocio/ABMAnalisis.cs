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
            return BD.AnalisisDB.getInstance().agregarAnalisis(ana);
        }
        static public bool modificarAnalisis(Entidades.Analisis ana)
        {
            return BD.AnalisisDB.getInstance().modificarAnalisis(ana);
        }



    }

}
