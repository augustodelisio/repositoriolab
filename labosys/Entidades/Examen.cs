using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Examen
    {
        private List<Analisis> analisis;
        private Obra_Social os;
        private string fecha;
        private Paciente paciente;

        public string Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

    }
}
