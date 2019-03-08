﻿using System;
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
        }

        private void btn_altaAnalisis_Click(object sender, EventArgs e)
        {
            new altaAnalisis().ShowDialog();
            this.dgv_analisis.DataSource = Negocio.ABMAnalisis.getAllAnalisis();
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
                MessageBox.Show("No ha seleccionado ningun analisis", "Cuidado", MessageBoxButtons.OK);
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
