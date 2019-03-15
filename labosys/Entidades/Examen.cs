using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Examen
    {
        DateTime fecha;
        int idExamen, idPaciente, idOS;
        string costo,actoBioquimico,nbu;

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public int IdExamen
        {
            get { return this.idExamen; }
            set { this.idExamen = value; }
        }

        public int IdPaciente
        {
            get { return this.idPaciente; }
            set { this.idPaciente = value; }
        }

        public int IdOS
        {
            get { return this.idOS; }
            set { this.idOS = value; }
        }

        public string Costo
        {
            get { return this.costo; }
            set { this.costo = value; }
        }
        public string ActoBioquimico
        {
            get { return this.actoBioquimico; }
            set { this.actoBioquimico = value; }
        }
        public string Nbu
        {
            get { return this.nbu; }
            set { this.nbu = value; }
        }
    }
}
