using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        private string nombre;
        private string apellido;
        private string dni;
        List<string> afiliados;
        private bool habilitado;
        int id;

        public Paciente(string apellido, string nombre, string dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value;  }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        
        public bool Habilitado
        {
            get {return this.habilitado; }
            set {this.habilitado=value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
