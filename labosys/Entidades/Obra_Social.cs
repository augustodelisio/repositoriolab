using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Obra_Social
    {
        private string nombre, porcentaje, nbu, actoBioquimico;
        private bool habilitado;
        private int id;
        public Obra_Social() { }

        public Obra_Social(string nombre, string porcentaje, string nbu, string actoBioquimico)
        {
            this.Nombre = nombre;
            this.Porcentaje = porcentaje;
            this.Nbu = nbu;
            this.ActoBioquimico = actoBioquimico;
        }

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

        public string Nbu
        {
            get { return this.nbu; }
            set { this.nbu = value; }
        }

        public bool Habilitado
        {
            get { return this.habilitado; }
            set { this.habilitado = value; }
        }

        public string ActoBioquimico
        {
            get { return this.actoBioquimico; }
            set { this.actoBioquimico = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
