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
    public partial class InformeOS : Form
    {
        string desde, hasta;
        Entidades.Obra_Social obraSocial;
        public InformeOS(string desdedt, string hastadt, Entidades.Obra_Social os)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.DisplayName =  os.Nombre + " " + DateTime.Now.Date.ToString("dd-MM-yyyy");

            try
            {
                reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
                this.desde = desdedt;
                this.hasta = hastadt;
                obraSocial = os;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e, "Error", MessageBoxButtons.OK);
            }
        }

        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            int id = int.Parse(e.Parameters[0].Values[0]);
            List<Entidades.subreport> subre = Negocio.ABMReporte.getAllSubReports(id);
            e.DataSources.Add(new ReportDataSource("DataSet1", subre));
        }

        private void InformeOS_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                float costo = 0;
                List<Entidades.reporte> reportes= Negocio.ABMReporte.getAllReportsPorOS(desde, hasta, obraSocial);
                this.reporteBindingSource.DataSource = reportes;
                foreach (Entidades.reporte re in reportes)
                {
                    costo += float.Parse(re.CostoTotal);
                }
                ReportParameter total = new ReportParameter("Total", costo.ToString());
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { total });
                this.reportViewer1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
