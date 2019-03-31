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
    public partial class ABMAnalisis : Form
    {
        BindingSource bs;

        public ABMAnalisis()
        {
            InitializeComponent();
            bs = new BindingSource(Negocio.ABMAnalisis.getAllAnalisis(), "");
            this.dgv_analisis.DataSource = bs;
            this.dgv_analisis.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void btn_altaAnalisis_Click(object sender, EventArgs e)
        {
            new altaAnalisis().ShowDialog();
            try
            {
                this.dgv_analisis.DataSource = Negocio.ABMAnalisis.getAllAnalisis();
            }
            catch
            {
                MessageBox.Show("Error: " + e, "Error", MessageBoxButtons.OK);
            }
            this.textBox1.Text = "";
        }

        private void btn_modificarAnalisis_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgv_analisis.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                Entidades.Analisis analisis = new Entidades.Analisis();
                analisis.Codigo = (string)celdas["codigo"].Value;
                analisis.Nombre = (string)celdas["nombre"].Value;
                analisis.CantNBU = (string)celdas["cantNBU"].Value;
                analisis.Id = (int)celdas["id"].Value;
                new modificarAnalisis(analisis).ShowDialog();
                this.dgv_analisis.DataSource = Negocio.ABMAnalisis.getAllAnalisis();
                bs.ResetBindings(false);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ningun analisis", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.textBox1.Text = "";
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dgv_analisis.DataSource = Negocio.ABMAnalisis.getAllAnalisisbyCodigo(this.textBox1.Text);
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
