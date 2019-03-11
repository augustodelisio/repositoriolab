using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Escritorio
{
    public partial class Informe : Form
    {
        public Informe()
        {
            InitializeComponent();
            reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);

        }
        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            int id = int.Parse(e.Parameters[0].Values[0]);
            List<Entidades.subreport> subre = Negocio.ABMReporte.getAllSubReports(id);
            e.DataSources.Add(new ReportDataSource("DataSet1", subre));
        }

        private void Informe_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reporteBindingSource.DataSource = Negocio.ABMReporte.getAllReports();
            this.reportViewer1.Refresh();
        }
    }
}
