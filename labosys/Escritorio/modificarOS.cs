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
    public partial class modificarOS : Form
    {
        int id;
        public modificarOS(Entidades.Obra_Social os)
        {
            InitializeComponent();
            this.txt_nombre.Text = os.Nombre;
            this.txt_porcentaje.Text = os.Porcentaje;
            this.txt_nbu.Text = os.Nbu;
            this.txt_actoBioquimico.Text = os.ActoBioquimico;
            
            id = os.Id;
        }

        private void btn_ModificarOS_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Obra_Social obraSocial = new Entidades.Obra_Social(txt_nombre.Text, txt_porcentaje.Text, txt_nbu.Text, txt_actoBioquimico.Text);
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
}
