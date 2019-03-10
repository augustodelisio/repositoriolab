namespace Escritorio
{
    partial class ReporteCompleto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataSetCompleto = new Escritorio.DataSetCompleto();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AnalisisExamenTableAdapter = new Escritorio.DataSetCompletoTableAdapters.AnalisisExamenTableAdapter();
            this.reporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCompleto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSetCompleto
            // 
            this.DataSetCompleto.DataSetName = "DataSetCompleto";
            this.DataSetCompleto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.reporteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Escritorio.Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // AnalisisExamenTableAdapter
            // 
            this.AnalisisExamenTableAdapter.ClearBeforeFill = true;
            // 
            // reporteBindingSource
            // 
            this.reporteBindingSource.DataSource = typeof(Entidades.reporte);
            // 
            // ReporteCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCompleto";
            this.Text = "ReporteCompleto";
            this.Load += new System.EventHandler(this.ReporteCompleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCompleto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetCompleto DataSetCompleto;
        private DataSetCompletoTableAdapters.AnalisisExamenTableAdapter AnalisisExamenTableAdapter;
        private System.Windows.Forms.BindingSource reporteBindingSource;
    }
}