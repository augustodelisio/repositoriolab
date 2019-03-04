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
    }
}
