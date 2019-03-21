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
    public partial class altaObraSocial : Form
    {
        public altaObraSocial()
        {
            InitializeComponent();
        }

        private void btn_agregarobrasocial_Click(object sender, EventArgs e)
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
            if (!Validador.validarPorcentaje(txt_porcentaje.Text))
            {
                errorProvider1.SetError(txt_porcentaje, "El campo debe tener un valor entre 0 y 100");
                camposValidos = false;
            }
            else
            {
                errorProvider1.SetError(txt_porcentaje, "");
            }
            if (!Validador.validarDecimal(txt_nbu.Text))
            {
                errorProvider1.SetError(txt_nbu, "Debe contener solo digitos y/o ,");
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
                string nombre = this.txt_nombre.Text.Trim();
                string porcentaje = this.txt_porcentaje.Text.Trim();
                string nbu = this.txt_nbu.Text.Trim();
                string actoBioquimico = this.txt_actoBioquimico.Text.Trim();
                try
                {
                    Entidades.Obra_Social obraSocial = new Entidades.Obra_Social(nombre, porcentaje, nbu, actoBioquimico);
                    bool exito = Negocio.ABMObraSocial.agregarOS(obraSocial);
                    if (exito)
                    {
                        MessageBox.Show("Obra Social agregada con exito", "Exito", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido agregar la obra social", "Fracaso", MessageBoxButtons.OK);

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);

                }
            }
        }

        private void txt_nbu_KeyUp(object sender, KeyEventArgs e)
        {
            string tex = this.txt_nbu.Text;
            this.txt_nbu.Text = tex.Replace(".", ",");
            int largo = txt_nbu.Text.Length;
            this.txt_nbu.Select();
            this.txt_nbu.Select(largo, 0);
        }

        private void txt_actoBioquimico_KeyUp(object sender, KeyEventArgs e)
        {
            string tex = this.txt_actoBioquimico.Text;
            this.txt_actoBioquimico.Text = tex.Replace(".", ",");
            int largo = txt_actoBioquimico.Text.Length;
            this.txt_actoBioquimico.Select();
            this.txt_actoBioquimico.Select(largo, 0);
        }

        private void txt_porcentaje_KeyUp(object sender, KeyEventArgs e)
        {
            string tex = this.txt_porcentaje.Text;
            this.txt_porcentaje.Text = tex.Replace(".", ",");
            int largo = txt_porcentaje.Text.Length;
            this.txt_porcentaje.Select();
            this.txt_porcentaje.Select(largo, 0);
        }

        private void txt_porcentaje_Leave(object sender, EventArgs e)
        {
            string tex = this.txt_porcentaje.Text;
            this.txt_porcentaje.Text = tex.Replace(".", ",");
        }
    }
}
