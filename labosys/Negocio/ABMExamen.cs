using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ABMExamen
    {
        public static Entidades.Examen agregarExamen(Entidades.Examen ex)
        {
            return BD.ExamenDB.getInstance().agregarExamen(ex);
        }

    }
}
