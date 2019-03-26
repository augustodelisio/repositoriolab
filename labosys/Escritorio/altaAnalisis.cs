using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Escritorio
{
    public partial class altaAnalisis : Form
    {
        public altaAnalisis()
        {
            InitializeComponent();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            try
            {
                if (!Validador.validarCodAnalisis(txt_codigo.Text))
                {
                    errorProvider.SetError(txt_codigo, "El campo debe contener entre 4 y 6 dígitos");
                    valido = false;
                }
                else
                {
                    errorProvider.SetError(txt_codigo, "");
                }
                if (!Validador.validarString(txt_nombre.Text))
                {
                    errorProvider.SetError(txt_nombre, "El campo no puede ser vacio");
                    valido = false;
                }
                else
                {
                    errorProvider.SetError(txt_nombre, "");
                }
                if (!Validador.validarDecimal(txt_nbu.Text))
                {
                    errorProvider.SetError(txt_nbu, "El campo debe contener solo digitos y/o ,");
                    valido = false;
                }
                else
                {
                    errorProvider.SetError(txt_nbu, "");
                }
                if (valido)
                {
                    
                    Entidades.Analisis analisis = new Entidades.Analisis();
                    analisis.Codigo = this.txt_codigo.Text.Trim();
                    analisis.Nombre = this.txt_nombre.Text.Trim();
                    analisis.CantNBU = (this.txt_nbu.Text).Trim();

                    bool exito = Negocio.ABMAnalisis.agregarAnalisis(analisis);
                    if (exito)
                    {
                        MessageBox.Show("El analisis se agrego exitosamente", "Exito!", MessageBoxButtons.OK);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El analisis no se pudo dar de alta, es probable que ya exista otro analisis con el mismo codigo", "Fracaso", MessageBoxButtons.OK);
                    }

                }
            }
            catch (Exception k)
            {
                MessageBox.Show("Ha ocurrido un error", "Fracaso", MessageBoxButtons.OK);
            }
        
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if ((this.txt_codigo.Text.Length >= 4) && (this.txt_codigo.Text.Length <= 6))
            {
                if (this.txt_codigo.Text.Length != 4)
                {
                    this.lbl_avisoCod.Text = "Se recomienda que el campo\ncontenga 4 numeros";
                    this.lbl_avisoCod.Visible = true;
                }
                else this.lbl_avisoCod.Text = "";
            }
            else this.lbl_avisoCod.Text = "";
        }

        private void txt_nbu_KeyUp(object sender, KeyEventArgs e) //CAMBIAR "." POR ","
        {
            string tex = this.txt_nbu.Text;
            this.txt_nbu.Text = tex.Replace(".", ",");
            int largo = txt_nbu.Text.Length;
            this.txt_nbu.Select();
            this.txt_nbu.Select(largo,0);
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
