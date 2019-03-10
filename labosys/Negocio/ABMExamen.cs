using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class ABMExamen
    {
        public static Entidades.Examen agregarExamen(Entidades.Examen ex)
        {
            return BD.ExamenDB.getInstance().agregarExamen(ex);
        }

        public static void agregarAnalisisAlExamen(Examen examen, Analisis ana, float costo)
        {
            BD.ExamenDB.getInstance().agregarAnalisisAlExamen(examen, ana, costo);
        }

        public static bool agregarCosto(float costoExamen, Examen examen)
        {
             return BD.ExamenDB.getInstance().agregarCosto(costoExamen, examen);
        }
    }
}
