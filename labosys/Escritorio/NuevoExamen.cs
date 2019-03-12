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
            DateTime FECHA = DateTime.Today.Date;
            this.txt_fecha.Text = FECHA.ToString("dd/MM/yyyy");
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
                ex.Fecha = DateTime.Parse(this.txt_fecha.Text);
                ex.IdPaciente = (int)cmb_pacientes.SelectedValue;
                ex.IdOS = (int)cmb_os.SelectedValue;
                Entidades.Obra_Social os = Negocio.ABMObraSocial.buscarOsPorId(ex.IdOS);
                float actobioquimico = float.Parse(os.Nbu) * float.Parse(os.ActoBioquimico);
                ex.ActoBioquimico = actobioquimico.ToString();
                Entidades.Examen exa = new Entidades.Examen();
                exa = Negocio.ABMExamen.agregarExamen(ex);
                if (exa != null)
                {
                    if (exa.IdExamen != 0)
                    {  
                        this.Close();
                        new AnalisisExamen(exa).ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("error", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema"+ex.ToString(), "Cuidado!", MessageBoxButtons.OK);
            }
        }

        private void btn_nuevoPaciente_Click(object sender, EventArgs e)
        {
            new altaPaciente().ShowDialog();
            List<Entidades.Paciente> pacientes = Negocio.ABMPaciente.getAllPacientes();
            this.cmb_pacientes.DataSource = pacientes;
            this.cmb_pacientes.DisplayMember = "dni";
            this.cmb_pacientes.ValueMember = "id";
        }

        private void btn_nuevaOS_Click(object sender, EventArgs e)
        {
            Entidades.Paciente pa = (Entidades.Paciente)cmb_pacientes.SelectedItem;
            if (pa != null)
            {
                new AgregarOSPAciente(pa).ShowDialog();
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
        }
    }
}
