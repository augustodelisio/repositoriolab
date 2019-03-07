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
        private string cantUG, cantUH, cantNBU;
        private int id;

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

        public string CantUG
        {
            get { return this.cantUG; }
            set { this.cantUG = value; }
        }

        public string CantUH
        {
            get { return this.cantUH; }
            set { this.cantUH = value; }
        }

        public string CantNBU
        {
            get { return this.cantNBU; }
            set { this.cantNBU = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
