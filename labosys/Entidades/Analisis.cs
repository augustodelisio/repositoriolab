using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Analisis
    {
        private string nombre;
        private string codigo;
        private float ug, uh;


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public float Ug
        {
            get { return this.ug; }
            set { this.ug = value; }
        }

        public float Uh
        {
            get { return this.uh; }
            set { this.uh = value; }
        }
    }
}
