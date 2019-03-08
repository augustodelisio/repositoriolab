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
            this.mtb_fecha.Text = FECHA.ToString();
            List<Entidades.Paciente> pacientes = Negocio.ABMPaciente.getAllPacientes();
            this.cmb_pacientes.DataSource = pacientes;
            this.cmb_pacientes.DisplayMember = "dni";
            this.cmb_pacientes.ValueMember = "id";

        }

        private void cmb_pacientes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_pacientes.SelectedItem != null)
            {
                Entidades.Paciente pa = (Entidades.Paciente)this.cmb_pacientes.SelectedItem;
                string nombre = pa.Apellido + ", " + pa.Nombre;
                this.lbl_nombre.Text = nombre;
                if (Negocio.ABMPaciente.getAllOS(pa).Count > 0)
                {
                    this.cmb_os.DataSource = Negocio.ABMPaciente.getAllOS(pa);
                    this.cmb_os.DisplayMember = "nombreOS";
                    this.cmb_os.ValueMember = "idOS";
                }
                else
                {
                    this.cmb_os.DataSource = null;
                }

            }
            else { this.lbl_nombre.Text = ""; }
        }

        private void btn_agregarAnalisis_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Examen ex = new Entidades.Examen();
                ex.Fecha = DateTime.Parse(this.mtb_fecha.Text);
                ex.IdPaciente = (int)cmb_pacientes.SelectedValue;
                ex.IdOS = (int)cmb_os.SelectedValue;
                Entidades.Examen exa = new Entidades.Examen();
                exa.IdExamen = -1;
                //ver como recuperar el id de examen despues de crearlo o buscar el maximo (otra alternativa)
                exa = Negocio.ABMExamen.agregarExamen(ex);
                if (exa.IdExamen != -1)
                {
                    new AnalisisExamen(exa).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Cuidado!", MessageBoxButtons.OK);
            }
        }
    }
}
