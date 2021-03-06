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
    public partial class altaPaciente : Form
    {
        public altaPaciente()
        {
            InitializeComponent();
        }

      

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposValidos = true;
                if (!Validador.validarString(txt_nombre.Text))
                {
                    errorProvider1.SetError(txt_nombre, "El campo no puede estar vacío");
                    camposValidos = false;
                }
                else
                {
                    errorProvider1.SetError(txt_nombre, "");
                }
                if (!Validador.validarString(txt_apellido.Text))
                {
                    errorProvider1.SetError(txt_apellido, "El campo debe contener solo dígitos y/o ,");
                    camposValidos = false;
                }
                else
                {
                    errorProvider1.SetError(txt_apellido, "");
                }
                if (!Validador.validarDNI(txt_dni.Text))
                {
                    errorProvider1.SetError(txt_dni, "El campo debe tener 8 dígitos");
                    camposValidos = false;
                }
                else
                {
                    errorProvider1.SetError(txt_dni, "");
                }
                if (camposValidos)
                {
                    string apellido = this.txt_apellido.Text.Trim();
                    string nombre = this.txt_nombre.Text.Trim();
                    string dni = this.txt_dni.Text.Trim();
                    Entidades.Paciente paciente = new Entidades.Paciente(apellido, nombre, dni);
                    bool exito = Negocio.ABMPaciente.agregarPaciente(paciente);
                    if (exito)
                    {
                        MessageBox.Show("El paciente se agrego exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("El paciente no se pudo dar de alta.\nEs probable que ya exista otro paciente con el DNI ingresado.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, contacte con su proveedor del software", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void altaPaciente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
