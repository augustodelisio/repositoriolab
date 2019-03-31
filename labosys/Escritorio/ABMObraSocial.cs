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
            this.dgv_obrasSociales.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void Btn_altaobrasocial_Click(object sender, EventArgs e)
        {
            new altaObraSocial().ShowDialog();
            this.txt_nombre.Text = "";
            try
            {
                this.dgv_obrasSociales.DataSource = Negocio.ABMObraSocial.getAllObrasSociales();
                bs.ResetBindings(false);
                actualizaColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex + ". Contacte con el proveedor del software", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                MessageBox.Show("No ha seleccionado ninguna Obra Social", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.txt_nombre.Text = "";
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
                    
                    //COLORES
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                    row.DefaultCellStyle.SelectionForeColor = Color.White;

                    DialogResult result = MessageBox.Show("¿Dar de baja a " + nombre + "?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //bool exito = false;
                    if (result == DialogResult.Yes)
                    {
                        bool exito = Negocio.ABMObraSocial.deshabilitarOS(os);
                        if (exito)
                        {
                            MessageBox.Show("Obra Social dada de baja con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido dar de baja Obra Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    this.dgv_obrasSociales.DataSource = Negocio.ABMObraSocial.getAllObrasSociales();
                    bs.ResetBindings(false);
                    actualizaColor();
                }
                else
                {
                    MessageBox.Show("La Obra Social ya se encuentra deshabilitada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ninguna Obra Social", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.txt_nombre.Text = "";

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
                    
                    //COLORES
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                    row.DefaultCellStyle.SelectionForeColor = Color.White;

                    DialogResult result = MessageBox.Show("¿Dar de alta a " + nombre + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //bool exito = false;
                    if (result == DialogResult.Yes)
                    {
                        bool exito = Negocio.ABMObraSocial.habilitarOS(os);
                        if (exito)
                        {
                            MessageBox.Show("Obra Social " + nombre + " se dió de alta con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido dar de alta la Obra Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    this.dgv_obrasSociales.DataSource = Negocio.ABMObraSocial.getAllObrasSociales();
                    bs.ResetBindings(false);
                    actualizaColor();
                }
                else
                {
                    MessageBox.Show("La Obra Social ya se encuentra habilitada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ninguna Obra Social", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.txt_nombre.Text = "";

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
                MessageBox.Show("Error: " + e + ". Contacte con el proveedor del software", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_obrasSociales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            actualizaColor();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            this.dgv_obrasSociales.DataSource = Negocio.ABMObraSocial.getAllObrasSocialesbyNombre(this.txt_nombre.Text);
        }
    }
}
