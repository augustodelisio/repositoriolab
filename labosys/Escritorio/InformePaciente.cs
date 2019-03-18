﻿using System;
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
    public partial class InformePaciente : Form
    {
        string desde, hasta;
        Entidades.Paciente paciente;
        public InformePaciente(string desdedt, string hastadt, Entidades.Paciente pa)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.DisplayName =  pa.Apellido +" "+ DateTime.Now.Date.ToString("dd-MM-yyyy");
            try
            {
                reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
                this.desde = desdedt;
                this.hasta = hastadt;
                paciente = pa;
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


        private void InformePaciente_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                this.reporteBindingSource.DataSource = Negocio.ABMReporte.getAllReportsPorPaciente(desde, hasta,paciente);
                this.reportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
        }
    }
}