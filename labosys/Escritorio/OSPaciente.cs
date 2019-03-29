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
    public partial class OSPaciente : Form
    {
        BindingSource bs;
        Entidades.Paciente paciente;
        public OSPaciente(Entidades.Paciente pa)
        {
            InitializeComponent();
            try
            {
                this.gb_paciente.Text = pa.Apellido + ", " + pa.Nombre;
                bs = new BindingSource(Negocio.ABMPaciente.getAllOS(pa), "");
                paciente = pa;
                this.dgv_ospacientes.DataSource = bs;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_agregarOSPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                new AgregarOSPAciente(paciente).ShowDialog();
                this.dgv_ospacientes.DataSource = Negocio.ABMPaciente.getAllOS(paciente);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: " + e, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void OSPaciente_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        
       

        private void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgv_ospacientes.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                string nombre = (string)celdas["NombreOS"].Value;
                Entidades.Obra_Social os = new Entidades.Obra_Social();
                os.Nombre = nombre;
                os.Id = (int)celdas["IdOS"].Value;
                new modificarOSPaciente(paciente,os).ShowDialog();
                this.dgv_ospacientes.DataSource = Negocio.ABMPaciente.getAllOS(paciente);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ninguna Obra Social", "Cuidado", MessageBoxButtons.OK);
            }
        }

        private void OSPaciente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
