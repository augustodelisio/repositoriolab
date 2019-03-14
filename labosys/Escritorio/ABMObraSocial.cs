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
            try
            {
                this.dgv_obrasSociales.DataSource = Negocio.ABMObraSocial.getAllObrasSociales();
                bs.ResetBindings(false);
                actualizaColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificarOS_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgv_obrasSociales.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                string nombre = (string)celdas["nombre"].Value;
                string porcentaje = (string)celdas["porcentaje"].Value;
                string nbu = (string)celdas["nbu"].Value;
                string actoBioquimico = (string)celdas["actoBioquimico"].Value;
                Entidades.Obra_Social os = new Entidades.Obra_Social(nombre, porcentaje, nbu, actoBioquimico);
                os.Id = (int)celdas["id"].Value;
                new modificarOS(os).ShowDialog();
                this.dgv_obrasSociales.DataSource = Negocio.ABMObraSocial.getAllObrasSociales();
                bs.ResetBindings(false);
                actualizaColor();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ninguna Obra Social", "Cuidado", MessageBoxButtons.OK);
            }

        }

        private void btn_deshabilitarOS_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgv_obrasSociales.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                if ((bool)celdas["habilitado"].Value)
                {
                    string nombre = (string)celdas["nombre"].Value;
                    string porcentaje = (string)celdas["porcentaje"].Value;
                    string nbu = (string)celdas["nbu"].Value;
                    string actoBioquimico = (string)celdas["actoBioquimico"].Value;
                    Entidades.Obra_Social os = new Entidades.Obra_Social(nombre, porcentaje, nbu, actoBioquimico);
                    os.Id = (int)celdas["id"].Value;
                    row.DefaultCellStyle.BackColor = Color.Red;
                    DialogResult result = MessageBox.Show("esta seguro que desea dar de baja a '" + nombre + "'?", "Cuidado", MessageBoxButtons.YesNo);
                    //bool exito = false;
                    if (result == DialogResult.Yes)
                    {
                        bool exito = Negocio.ABMObraSocial.deshabilitarOS(os);
                        if (exito)
                        {
                            MessageBox.Show("Obra Social dada de baja con exito", "Exito", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido dar de baja Obra Social", "Fracaso", MessageBoxButtons.OK);
                        }
                    }

                    this.dgv_obrasSociales.DataSource = Negocio.ABMObraSocial.getAllObrasSociales();
                    bs.ResetBindings(false);
                    actualizaColor();
                }
                else
                {
                    MessageBox.Show("La Obra Social ya se encuentra deshabilitada", "Ciudado!", MessageBoxButtons.OK);
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ninguna Obra Social", "Cuidado", MessageBoxButtons.OK);
            }

        }

        private void btn_habilitarOS_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgv_obrasSociales.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                if (!(bool)celdas["habilitado"].Value)
                {
                    string nombre = (string)celdas["nombre"].Value;
                    string porcentaje = (string)celdas["porcentaje"].Value;
                    string nbu = (string)celdas["nbu"].Value;
                    string actoBioquimico = (string)celdas["actoBioquimico"].Value;
                    Entidades.Obra_Social os = new Entidades.Obra_Social(nombre, porcentaje, nbu, actoBioquimico);
                    os.Id = (int)celdas["id"].Value;
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                    DialogResult result = MessageBox.Show("esta seguro que desea dar de alta a '" + nombre + "'?", "Cuidado", MessageBoxButtons.YesNo);
                    //bool exito = false;
                    if (result == DialogResult.Yes)
                    {
                        bool exito = Negocio.ABMObraSocial.habilitarOS(os);
                        if (exito)
                        {
                            MessageBox.Show("Paciente dado de alta con exito", "Exito", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido dar de alta al paciente", "Fracaso", MessageBoxButtons.OK);
                        }
                    }
                    this.dgv_obrasSociales.DataSource = Negocio.ABMObraSocial.getAllObrasSociales();
                    bs.ResetBindings(false);
                    actualizaColor();
                }
                else
                {
                    MessageBox.Show("La Obra Social ya se encuentra habilitada", "Ciudado!", MessageBoxButtons.OK);
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ninguna Obra Social", "Cuidado", MessageBoxButtons.OK);
            }

        }

        private void dgv_obrasSociales_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgv_obrasSociales.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                bool habilitado = (bool)celdas["habilitado"].Value;
                if (habilitado)
                {
                    this.btn_habilitarOS.Visible = false;
                    this.btn_habilitarOS.Enabled = false;
                    this.btn_deshabilitarOS.Enabled = true;
                    this.btn_deshabilitarOS.Visible = true;
                }
                else
                {
                    this.btn_deshabilitarOS.Visible = false;
                    this.btn_deshabilitarOS.Enabled = false;
                    this.btn_habilitarOS.Enabled = true;
                    this.btn_habilitarOS.Visible = true;
                }
            }
            catch (NullReferenceException ne)
            {
            }

        }

        public void actualizaColor()
        {
            try
            {
                for (int i = 0; i < this.dgv_obrasSociales.RowCount; i++)
                {
                    int hab = Convert.ToInt16(this.dgv_obrasSociales.Rows[i].Cells[3].Value);
                    if (hab != 1)
                    {
                        this.dgv_obrasSociales.Rows[i].DefaultCellStyle.ForeColor = Color.DarkGray;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e, "Error", MessageBoxButtons.OK);
            }
        }

        private void dgv_obrasSociales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            actualizaColor();
        }
    }
}
