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
    public partial class modificarAnalisis : Form
    {
        int id;
        public modificarAnalisis(Entidades.Analisis analisis)
        {
            InitializeComponent();
            this.txt_codigo.Text = analisis.Codigo.Trim();
            this.txt_nombre.Text = analisis.Nombre.Trim();
            this.txt_nbu.Text = analisis.CantNBU.Trim();
            id = analisis.Id;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            try
            {
                if (!Validador.validarString(txt_codigo.Text))
                {
                    errorProvider1.SetError(txt_codigo, "El campo no puede ser vacio");
                    valido = false;
                }
                else
                {
                    errorProvider1.SetError(txt_codigo, "");
                }
                if (!Validador.validarString(txt_nombre.Text))
                {
                    errorProvider1.SetError(txt_nombre, "El campo no puede ser vacio");
                    valido = false;
                }
                else
                {
                    errorProvider1.SetError(txt_nombre, "");
                }
                if (!Validador.validarDecimal(txt_nbu.Text))
                {
                    errorProvider1.SetError(txt_nbu, "El campo debe contener solo digitos y/o ,");
                    valido = false;
                }
                else
                {
                    errorProvider1.SetError(txt_nbu, "");
                }
                if (valido)
                {
                    Entidades.Analisis analisis = new Entidades.Analisis();
                    analisis.Codigo = this.txt_codigo.Text.Trim();
                    analisis.Nombre = this.txt_nombre.Text.Trim();
                    analisis.CantNBU = (this.txt_nbu.Text).Trim();
                    analisis.Id = id;

                    bool exito = Negocio.ABMAnalisis.modificarAnalisis(analisis);
                    if (exito)
                    {
                        MessageBox.Show("El analisis se modifico exitosamente", "Exito!", MessageBoxButtons.OK);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El analisis no se pudo modificar", "Fracaso", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception k)
            {
                MessageBox.Show("Ha ocurrido un error", "Fracaso", MessageBoxButtons.OK);
            }
        }
    }
}
