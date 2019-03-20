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
    public partial class modificarOS : Form
    {
        int id;
        public modificarOS(Entidades.Obra_Social os)
        {
            InitializeComponent();
            this.txt_nombre.Text = os.Nombre.Trim();
            this.txt_porcentaje.Text = os.Porcentaje.Trim();
            this.txt_nbu.Text = os.Nbu.Trim();
            this.txt_actoBioquimico.Text = os.ActoBioquimico.Trim();
            id = os.Id;
        }

        private void btn_ModificarOS_Click(object sender, EventArgs e)
        { bool camposValidos = true;
            if (!Validador.validarString(txt_nombre.Text))
            {
                errorProvider1.SetError(txt_nombre, "El campo no puede estar vacio");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(txt_nombre, "");
            }
            if (!Validador.validarDecimal(txt_porcentaje.Text))
            {
                errorProvider1.SetError(txt_porcentaje, "El campo debe contener solo digitos y/o ,");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(txt_porcentaje, "");
            }
            if (!Validador.validarDecimal(txt_nbu.Text))
            {
                errorProvider1.SetError(txt_nbu, "El campo debe contener solo digitos y/o ,");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(txt_nbu, "");
            }
            if (!Validador.validarDecimal(txt_actoBioquimico.Text))
            {
                errorProvider1.SetError(txt_actoBioquimico, "El campo debe contener solo digitos y/o ,");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(txt_actoBioquimico, "");
            }
            if (camposValidos)
            {
                try
                {
                    Entidades.Obra_Social obraSocial = new Entidades.Obra_Social(txt_nombre.Text.Trim(), txt_porcentaje.Text.Trim(), txt_nbu.Text.Trim(), txt_actoBioquimico.Text.Trim());
                    obraSocial.Id = id;
                    bool exito = Negocio.ABMObraSocial.modificarOS(obraSocial);
                    if (exito)
                    {
                        MessageBox.Show("Obra Social modificada con exito", "Exito", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La Obra Social no se ha podido modificar", "Fracaso", MessageBoxButtons.OK);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error", "Fracaso", MessageBoxButtons.OK);

                }
            }
        }

        private void txt_actoBioquimico_KeyUp(object sender, KeyEventArgs e)
        {
            {
                string tex = this.txt_actoBioquimico.Text;
                this.txt_actoBioquimico.Text = tex.Replace(".", ",");
                int largo = txt_actoBioquimico.Text.Length;
                this.txt_actoBioquimico.Select();
                this.txt_actoBioquimico.Select(largo, 0);
            }
        }

        private void txt_nbu_KeyUp(object sender, KeyEventArgs e)
        {
            {
                string tex = this.txt_nbu.Text;
                this.txt_nbu.Text = tex.Replace(".", ",");
                int largo = txt_nbu.Text.Length;
                this.txt_nbu.Select();
                this.txt_nbu.Select(largo, 0);
            }
        }
    }
}
