using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Obra_Social
    {
        private string nombre;
        private string porcentaje;
        private float nbu;


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Porcentaje
        {
            get { return this.porcentaje; }
            set { this.porcentaje = value; }
        }

        public float Nbu
        {
            get { return this.nbu; }
            set { this.nbu = value; }
        }

    }
}
