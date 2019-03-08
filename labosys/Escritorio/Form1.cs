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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ABMPaciente().ShowDialog();
        }

        private void btn_abmobrasocial_Click(object sender, EventArgs e)
        {
            new ABMObraSocial().ShowDialog();
        }

        private void gestionDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABMPaciente().ShowDialog();
        }

        private void listadoDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABMObraSocial().ShowDialog();
        }

        private void gestionAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABMAnalisis().ShowDialog();
        }

        private void nuevoExámenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NuevoExamen().ShowDialog();
        }
    }
}
