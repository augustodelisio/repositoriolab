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
    public partial class modificarPaciente : Form
    {
        int id;
        bool cerrar;
        public modificarPaciente(Entidades.Paciente pa)
        {
            InitializeComponent();
            try
            {
                this.txt_apellido.Text = pa.Apellido.Trim();
                this.txt_dni.Text = pa.Dni.Trim();
                this.txt_nombre.Text = pa.Nombre.Trim();
                id = pa.Id;
                cerrar = false;
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modificarpaciente_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposValidos = true;
                if (!Validador.validarString(txt_nombre.Text))
                {
                    errorProvider1.SetError(txt_nombre, "El campo no puede estar vacio");
                    camposValidos = false;
                }
                else
                {
                    errorProvider1.SetError(txt_nombre, "");
                }
                if (!Validador.validarString(txt_apellido.Text))
                {
                    errorProvider1.SetError(txt_apellido, "El campo debe contener solo digitos y/o ,");
                    camposValidos = false;
                }
                else
                {
                    errorProvider1.SetError(txt_apellido, "");
                }
                if (!Validador.validarDNI(txt_dni.Text))
                {
                    errorProvider1.SetError(txt_dni, "El campo debe tener 8 digitos");
                    camposValidos = false;
                }
                else
                {
                    errorProvider1.SetError(txt_dni, "");
                }
                if (camposValidos)
                {
                    Entidades.Paciente paciente = new Entidades.Paciente(txt_apellido.Text.Trim(), txt_nombre.Text.Trim(), txt_dni.Text.Trim());
                    paciente.Id = id;
                    bool exito = Negocio.ABMPaciente.modificarPaciente(paciente);
                    if (exito)
                    {
                        MessageBox.Show("Paciente modificado con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cerrar = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El paciente no se ha podido modificar\nEs probable que el dni ingresado coincida con alguno existente.", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error "+ex, "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrar)
            {
                DialogResult resultado = MessageBox.Show("¿Descartar cambios?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void modificarPaciente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
