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
    public partial class NuevoExamen : Form
    {
        public NuevoExamen()
        {
            InitializeComponent();
            DateTime FECHA = DateTime.Today;
            this.mtb_fecha.Text =FECHA.ToString();
            this.cmb_pacientes.DataSource = Negocio.ABMPaciente.getAllPacientes();
            this.cmb_pacientes.DisplayMember = "dni";
            this.cmb_pacientes.ValueMember = "id";
            this.cmb_pacientes.SelectedIndex = -1;
            this.lbl_muestraNom.Text = "";
        }

        private void cmb_pacientes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_pacientes.SelectedItem != null)
            {
                this.lbl_muestraNom.Visible = true;
                Entidades.Paciente pa = (Entidades.Paciente)this.cmb_pacientes.SelectedItem;
                this.lbl_muestraNom.Text = pa.Apellido + ", " + pa.Nombre;
            }
        }

        private void cmb_pacientes_TextChanged(object sender, EventArgs e)
        {
            if (cmb_pacientes.SelectedItem != null)
            {
                string dni = this.cmb_pacientes.Text;
                this.cmb_pacientes.DataSource = Negocio.ABMPaciente.getAllPacientesbyDNI(dni);
            }
        }
    }
}
