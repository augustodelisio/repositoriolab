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
    public partial class ReportesEleccion : Form
    {
        public ReportesEleccion()
        {
            InitializeComponent();
        }

        private void ReportesEleccion_Load(object sender, EventArgs e)
        {
            this.txt_finTodos.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_informeCompleto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txt_inicioTodos.Text))
            {

                    string desde = "20000101";
                    DateTime hastaDT = DateTime.Parse(this.txt_finTodos.Text);
                    string hasta = hastaDT.ToString("yyyyMMdd");
                    new Informe(desde, hasta).ShowDialog();
  
            }
            else
            {
                DateTime desdeDt = DateTime.Parse(this.txt_inicioTodos.Text);
                string desde = desdeDt.ToString("yyyyMMdd");
                DateTime hastaDT = DateTime.Parse(this.txt_finTodos.Text);
                string hasta = hastaDT.ToString("yyyyMMdd");
                new Informe(desde, hasta).ShowDialog();
            }
        }
    }
}
