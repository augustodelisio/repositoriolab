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

        private void btn_agregarpaciente_Click(object sender, EventArgs e)
        {
            string apellido = this.txt_apellido.Text;
            string nombre = this.txt_nombre.Text;
            string dni = this.txt_dni.Text;
            Entidades.Paciente paciente = new Entidades.Paciente(apellido,nombre,dni);          
            Negocio.ABMPaciente.agregarPaciente(paciente);
            this.Close();
        }
    }
}
