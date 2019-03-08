using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class AnalisisExamen : Form
    {
        BindingSource bs;
        private Entidades.Examen examen;
        List<Entidades.Analisis> analisis = new List<Entidades.Analisis>();
        public AnalisisExamen(Entidades.Examen ex)
        {
            InitializeComponent();
            examen = ex;
            bs = new BindingSource(analisis, "");
            this.dgv_analisis.DataSource = bs;

        }
    }
}
