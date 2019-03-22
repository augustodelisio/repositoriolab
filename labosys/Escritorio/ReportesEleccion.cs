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
            try
            {
                List<Entidades.Paciente> pacientes = Negocio.ABMPaciente.getAllPacientes();
                this.cmb_Paciente.DataSource = pacientes;
                this.cmb_Paciente.DisplayMember = "dni";
                this.cmb_Paciente.ValueMember = "id";
                this.cmb_os.DataSource = Negocio.ABMObraSocial.getAllObrasSociales();
                this.cmb_os.DisplayMember = "nombre";
                this.cmb_os.ValueMember = "id";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la carga de datos", "Error", MessageBoxButtons.OK);
            }
        }

        private void ReportesEleccion_Load(object sender, EventArgs e)
        {
            this.txt_finTodos.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txt_finPaciente.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txt_finOS.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_informeCompleto_Click(object sender, EventArgs e)
        {
            if (!txt_inicioTodos.MaskCompleted)
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

        private void btn_informePaciente_Click(object sender, EventArgs e)
        {
            Entidades.Paciente pa = (Entidades.Paciente)cmb_Paciente.SelectedItem;
            if (!txt_inicioPaciente.MaskCompleted)
            {
                string desde = "20000101";
                DateTime hastaDT = DateTime.Parse(this.txt_finTodos.Text);
                string hasta = hastaDT.ToString("yyyyMMdd");
                new InformePaciente(desde, hasta, pa).ShowDialog();
            }
            else
            {
                DateTime desdeDt = DateTime.Parse(this.txt_inicioTodos.Text);
                string desde = desdeDt.ToString("yyyyMMdd");
                DateTime hastaDT = DateTime.Parse(this.txt_finTodos.Text);
                string hasta = hastaDT.ToString("yyyyMMdd");
                new InformePaciente(desde, hasta, pa).ShowDialog();
            }
        }

        private void cmb_Paciente_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Paciente.SelectedItem != null)
                {
                    Entidades.Paciente pa = (Entidades.Paciente)this.cmb_Paciente.SelectedItem;
                    string nombre = pa.Apellido + ", " + pa.Nombre;
                    this.lbl_nombrePaciente.Text = nombre;
                }
                else { this.lbl_nombrePaciente.Text = ""; }
            }
            catch
            {
                MessageBox.Show("Error en la carga de datos", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_informeOs_Click(object sender, EventArgs e)
        {
            Entidades.Obra_Social os = (Entidades.Obra_Social)cmb_os.SelectedItem;
            if (!txt_inicioOS.MaskCompleted)
            {
                string desde = "20000101";
                DateTime hastaDT = DateTime.Parse(this.txt_finTodos.Text);
                string hasta = hastaDT.ToString("yyyyMMdd");
                new InformeOS(desde, hasta, os).ShowDialog();
            }
            else
            {
                DateTime desdeDt = DateTime.Parse(this.txt_inicioTodos.Text);
                string desde = desdeDt.ToString("yyyyMMdd");
                DateTime hastaDT = DateTime.Parse(this.txt_finTodos.Text);
                string hasta = hastaDT.ToString("yyyyMMdd");
                new InformeOS(desde, hasta, os).ShowDialog();
            }
        }
    }
}
