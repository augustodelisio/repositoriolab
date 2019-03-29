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
 
        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportesEleccion().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.No)
            { 
                e.Cancel = true;
            }
        }
    }
}
