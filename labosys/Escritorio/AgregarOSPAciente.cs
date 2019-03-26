using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Escritorio
{
    public partial class AgregarOSPAciente : Form
    {
        Entidades.Paciente paciente;
        public AgregarOSPAciente(Entidades.Paciente pa)
        {
            InitializeComponent();
            this.groupBox1.Text = "Obras Sociales disponibles para " + pa.Apellido + " " + pa.Nombre;
            this.cmb_OS.DataSource = Negocio.ABMObraSocial.getAllObrasSociales();
            this.cmb_OS.DisplayMember = "nombre";
            this.cmb_OS.ValueMember = "id";
            paciente = pa;
        }

        private void btn_agregarOSaPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.PacienteOS paos = new Entidades.PacienteOS();
                paos.IdOS = (int)this.cmb_OS.SelectedValue;
                paos.IdPaciente = paciente.Id;
                if (!Validador.validarString(this.txt_afiliado.Text))
                {
                    errorProvider.SetError(txt_afiliado, "El campo no puede estar vacio");
                }
                else
                {
                    paos.NroAfiliado = this.txt_afiliado.Text;
                    bool exito = Negocio.ABMPaciente.agregarOsaPaciente(paos);
                    if (exito)
                    {
                        MessageBox.Show("obra social agregada al paciente correctamente", "Exito", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido agregar la obra social al paciente, es probable que la misma ya se encuentre cargada o el numero de afiliado ya se encuentre en uso", "Fracaso", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "Fracaso", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
