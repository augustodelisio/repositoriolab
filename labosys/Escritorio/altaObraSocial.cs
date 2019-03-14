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
            string nombre = this.txt_nombre.Text;
            string porcentaje = this.txt_porcentaje.Text;
            string nbu = this.txt_nbu.Text;
            string actoBioquimico = this.txt_actoBioquimico.Text;
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
                MessageBox.Show("Error: "+ex, "Error", MessageBoxButtons.OK);

            }
        }
    }
}
