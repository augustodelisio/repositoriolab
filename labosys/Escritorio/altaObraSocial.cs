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
        bool tipo = false;//POR DEFECTO ES NBU
        public altaObraSocial()
        {
            InitializeComponent();
        }

        private void rbt_nbu_CheckedChanged(object sender, EventArgs e)//RADIOBUTTON NBU
        {
            tipo = false;
        }

        private void rbt_inos_CheckedChanged(object sender, EventArgs e)//RADIOBUTTON INOS
        {
            tipo = true;
        }

        private void btn_agregarobrasocial_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string porcentaje = this.txt_porcentaje.Text;
            string arancel = this.txt_arancel.Text;
            Entidades.Obra_Social obraSocial = new Entidades.Obra_Social(nombre, porcentaje, tipo, arancel);          
            Negocio.ABMObraSocial.agregarOS(obraSocial);
            this.Close();
        }

    }

}
