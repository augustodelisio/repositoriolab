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

            bs = new BindingSource(Negocio.ABMPaciente.getAllPacientes(), "");
            this.dgv_pacientes.DataSource = bs;
        }

        private void btn_altapaciente_Click(object sender, EventArgs e)
        {
            new altaPaciente().ShowDialog();
            this.txt_filtroDni.Text = "";
            this.txt_filtroNombre.Text = "";
            try
            {
                this.dgv_pacientes.DataSource = Negocio.ABMPaciente.getAllPacientes();
                bs.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_modificarpaciente_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgv_pacientes.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                string dni = (string)celdas["dni"].Value;
                string nombre = (string)celdas["nombre"].Value;
                string apellido = (string)celdas["apellido"].Value;
                Entidades.Paciente pa = new Entidades.Paciente(apellido, nombre, dni);
                pa.Id = (int)celdas["id"].Value;
                new modificarPaciente(pa).ShowDialog();
                this.dgv_pacientes.DataSource = Negocio.ABMPaciente.getAllPacientes();
                bs.ResetBindings(false);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No se ha seleccionado ningún paciente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.txt_filtroDni.Text = "";
            this.txt_filtroNombre.Text = "";

        }

        private void btn_bajapaciente_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    DataGridViewRow row = this.dgv_pacientes.CurrentRow;
                    DataGridViewCellCollection celdas = row.Cells;
                    if ((bool)celdas["habilitado"].Value)
                    {
                        string dni = (string)celdas["dni"].Value;
                        string nombre = (string)celdas["nombre"].Value;
                        string apellido = (string)celdas["apellido"].Value;
                        Entidades.Paciente pa = new Entidades.Paciente(apellido, nombre, dni);
                        pa.Id = (int)celdas["id"].Value;

                        //COLORES
                        row.DefaultCellStyle.BackColor = Color.DarkRed;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        row.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                        row.DefaultCellStyle.SelectionForeColor = Color.White;

                        DialogResult result = MessageBox.Show("¿Dar de baja a " + apellido + ", " + nombre + "?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        //bool exito = false;
                        if (result == DialogResult.Yes)
                        {
                            bool exito = Negocio.ABMPaciente.deshabilitarPaciente(pa);
                            if (exito)
                            {
                                MessageBox.Show("Paciente dado de baja con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido dar de baja al paciente", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        this.dgv_pacientes.DataSource = Negocio.ABMPaciente.getAllPacientes();
                        bs.ResetBindings(false);
                        actualizaColor();
                    }
                    else
                    {
                        MessageBox.Show("El paciente ya se encuentra deshabilitado", "Ciudado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("No ha seleccionado ningún paciente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.txt_filtroDni.Text = "";
                this.txt_filtroNombre.Text = "";

            }
        }

        private void dgv_pacientes_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgv_pacientes.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                bool habilitado = (bool)celdas["habilitado"].Value;
                if (habilitado)
                {
                    this.btn_habilitar.Visible = false;
                    this.btn_habilitar.Enabled = false;
                    this.btn_bajapaciente.Enabled = true;
                    this.btn_bajapaciente.Visible = true;
                }
                else
                {
                    this.btn_bajapaciente.Visible = false;
                    this.btn_bajapaciente.Enabled = false;
                    this.btn_habilitar.Enabled = true;
                    this.btn_habilitar.Visible = true;
                }
            }
            catch (NullReferenceException ex)
            {
                
            }

        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    DataGridViewRow row = this.dgv_pacientes.CurrentRow;
                    DataGridViewCellCollection celdas = row.Cells;
                    if (!(bool)celdas["habilitado"].Value)
                    {
                        string dni = (string)celdas["dni"].Value;
                        string nombre = (string)celdas["nombre"].Value;
                        string apellido = (string)celdas["apellido"].Value;
                        Entidades.Paciente pa = new Entidades.Paciente(apellido, nombre, dni);
                        pa.Id = (int)celdas["id"].Value;
                        
                        //COLORES
                        row.DefaultCellStyle.BackColor = Color.DarkRed;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        row.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                        row.DefaultCellStyle.SelectionForeColor = Color.White;

                        DialogResult result = MessageBox.Show("¿Dar de alta a " + apellido + ", " + nombre + "?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        //bool exito = false;
                        if (result == DialogResult.Yes)
                        {
                            bool exito = Negocio.ABMPaciente.habilitarPaciente(pa);
                            if (exito)
                            {
                                MessageBox.Show("Paciente dado de alta con Éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido dar de alta al paciente", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        this.dgv_pacientes.DataSource = Negocio.ABMPaciente.getAllPacientes();
                        bs.ResetBindings(false);
                        actualizaColor();
                    }
                    else
                    {
                        MessageBox.Show("El paciente ya se encuentra habilitado", "Ciudado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("No se ha seleccionado ningún paciente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.txt_filtroDni.Text = "";
                this.txt_filtroNombre.Text = "";

            }
        }
            
        private void btn_obrasSocialesPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgv_pacientes.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                string dni = (string)celdas["dni"].Value;
                string nombre = (string)celdas["nombre"].Value;
                string apellido = (string)celdas["apellido"].Value;
                Entidades.Paciente pa = new Entidades.Paciente(apellido, nombre, dni);
                pa.Id = (int)celdas["id"].Value;
                new OSPaciente(pa).ShowDialog();

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No se ha seleccionado ningún paciente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.txt_filtroDni.Text = "";
            this.txt_filtroNombre.Text = "";
        }

        private void txt_filtroDni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgv_pacientes.DataSource = Negocio.ABMPaciente.getAllPacientesbyDNI(this.txt_filtroDni.Text);
            }
            catch
            {
                this.dgv_pacientes.DataSource = null;
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_filtroNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgv_pacientes.DataSource = Negocio.ABMPaciente.getAllPacientesbyApellido(this.txt_filtroNombre.Text);
            }
            catch
            {
                this.dgv_pacientes.DataSource = null;
            }
        }

        private void txt_filtroNombre_Enter(object sender, EventArgs e)
        {
            this.txt_filtroDni.Text = "";
        }

        private void txt_filtroDni_Enter(object sender, EventArgs e)
        {
            this.txt_filtroNombre.Text = "";
        }

        public void actualizaColor()
        {
            try
            {
                for (int i = 0; i < this.dgv_pacientes.RowCount; i++)
                {
                    int hab = Convert.ToInt16(this.dgv_pacientes.Rows[i].Cells[3].Value);
                    if (hab != 1)
                    {
                        this.dgv_pacientes.Rows[i].DefaultCellStyle.ForeColor = Color.DarkGray;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e, "Error", MessageBoxButtons.OK);
            }
        }

        private void dgv_pacientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            actualizaColor();
        }
    }
}
