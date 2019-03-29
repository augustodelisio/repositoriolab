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
        bool cambio = false;
        Entidades.Paciente paciente;
        public AgregarOSPAciente(Entidades.Paciente pa)
        {
            InitializeComponent();
            this.groupBox1.Text = "Obras Sociales de " + pa.Apellido + ", " + pa.Nombre;
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
                    errorProvider.SetError(txt_afiliado, "El campo no puede estar vacío");
                }
                else
                {
                    paos.NroAfiliado = this.txt_afiliado.Text;
                    bool exito = Negocio.ABMPaciente.agregarOsaPaciente(paos);
                    if (exito)
                    {
                        MessageBox.Show("Obra social agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cambio = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido agregar la obra social al paciente\n, es probable que la misma ya se encuentre cargada o \nel número de afiliado ya se encuentre en uso", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_afiliado_TextChanged(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void AgregarOSPAciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambio)
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
