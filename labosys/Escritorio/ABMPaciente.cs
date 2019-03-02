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
    public partial class ABMPaciente : Form
    {
        BindingSource bs;
        public ABMPaciente()
        {
            InitializeComponent();
            //cargar los pacientes al gridview
            bs = new BindingSource(Negocio.ABMPaciente.getAllPacientes(), "");
            this.dgv_pacientes.DataSource = bs;
        }

        private void btn_altapaciente_Click(object sender, EventArgs e)
        {
            new altaPaciente().ShowDialog();
            bs.ResetBindings(false);
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
    }
}
