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
    public partial class ReporteCompleto : Form
    {
        public ReporteCompleto()
        {
            InitializeComponent();
        }

        private void ReporteCompleto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetCompleto.AnalisisExamen' table. You can move, or remove it, as needed.
            //this.AnalisisExamenTableAdapter.Fill(this.DataSetCompleto.AnalisisExamen);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            List<Entidades.reporte> reportes = Negocio.ABMReporte.getAllReports();
            this.reporteBindingSource.DataSource = reportes;
            this.reportViewer1.RefreshReport();
        }
    }
}
