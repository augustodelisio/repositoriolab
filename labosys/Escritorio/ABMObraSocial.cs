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
    public partial class ABMObraSocial : Form
    {
        BindingSource bs;
        public ABMObraSocial()
        {
            InitializeComponent();
            bs = new BindingSource(Negocio.ABMObraSocial.getAllObrasSociales(), "");
            this.dgv_obrasSociales.DataSource = bs;
        }

        private void Btn_altaobrasocial_Click(object sender, EventArgs e)
        {
            new altaObraSocial().ShowDialog();
            bs.ResetBindings(false);
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
