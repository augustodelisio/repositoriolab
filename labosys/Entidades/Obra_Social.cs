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
        private bool tipo;
        private string arancel;

        public Obra_Social(string nombre, string porcentaje, bool tipo, string arancel)
        {
            this.Nombre = nombre;
            this.Porcentaje = porcentaje;
            this.Tipo = tipo; //0=NBU ----- 1=INOS
            this.Arancel = arancel;
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

        public bool Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public string Arancel
        {
            get { return this.arancel; }
            set { this.arancel = value; }
        }

    }
}
