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
                string apellido = this.txt_apellido.Text;
                string nombre = this.txt_nombre.Text;
                string dni = this.txt_dni.Text;
                Entidades.Paciente paciente = new Entidades.Paciente(apellido, nombre, dni);
                bool exito = Negocio.ABMPaciente.agregarPaciente(paciente);
                if (exito)
                {
                    MessageBox.Show("El paciente se agrego exitosamente", "Exito!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El paciente no se pudo dar de alta", "Fracaso", MessageBoxButtons.OK);
                }
                this.Close();
            }
            catch( Exception )
            {
                MessageBox.Show("Ha ocurrido un error", "Fracaso", MessageBoxButtons.OK);
            }
        }

        
    }
}
