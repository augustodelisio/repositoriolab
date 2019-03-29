﻿using System;
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
    public partial class modificarOSPaciente : Form
    {
        Entidades.Paciente paciente;
        Entidades.Obra_Social obra;
        bool cambio = false;
        public modificarOSPaciente(Entidades.Paciente pa,Entidades.Obra_Social os)
        {
            InitializeComponent();
            this.groupBox1.Text = "Obras Sociales de " + pa.Apellido + ", " + pa.Nombre;
            this.txt_OS.Text = os.Nombre;
            this.txt_OS.Enabled = false;
            paciente = pa;
            obra = os;
        }

        private void btn_agregarOSaPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validador.validarString(this.txt_afiliado.Text))
                {
                    errorProvider1.SetError(txt_afiliado, "El campo no puede estar vacío");
                }
                else
                {
                    Entidades.PacienteOS paos = new Entidades.PacienteOS();
                    paos.IdOS = obra.Id;
                    paos.IdPaciente = paciente.Id;
                    paos.NroAfiliado = this.txt_afiliado.Text;
                    bool exito = Negocio.ABMPaciente.modificarOsaPaciente(paos);
                    if (exito)
                    {
                        MessageBox.Show("Obra social modificada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cambio = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido modificar la obra social al paciente\n, es probable que la misma ya se encuentre cargada o \nel número de afiliado ya se encuentre en uso", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarOSPaciente_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txt_afiliado_TextChanged(object sender, EventArgs e)
        {
            cambio = true;
        }
    }
}
