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
    public partial class modificarPaciente : Form
    {
        int id;
        public modificarPaciente(Entidades.Paciente pa)
        {
            InitializeComponent();
            this.txt_apellido.Text = pa.Apellido;
            this.txt_dni.Text = pa.Dni;
            this.txt_nombre.Text = pa.Nombre;
            id = pa.Id;
        }

        private void btn_modificarpaciente_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Paciente paciente = new Entidades.Paciente(txt_apellido.Text, txt_nombre.Text, txt_dni.Text);
                paciente.Id = id;
                bool exito = Negocio.ABMPaciente.modificarPaciente(paciente);
                if (exito)
                {
                    MessageBox.Show("Paciente modificado con exito", "Exito", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El paciente no se ha podido modificar", "Fracaso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "Fracaso", MessageBoxButtons.OK);

            }
        }
    }
}
