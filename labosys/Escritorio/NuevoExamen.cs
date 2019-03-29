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
    public partial class NuevoExamen : Form
    {
        public NuevoExamen()
        {
            InitializeComponent();
            try
            {
                DateTime FECHA = DateTime.Today.Date;
                this.txt_fecha.Text = FECHA.ToString("dd/MM/yyyy");
                List<Entidades.Paciente> pacientes = Negocio.ABMPaciente.getAllPacientes();
                this.cmb_pacientes.DataSource = pacientes;
                this.cmb_pacientes.DisplayMember = "dni";
                this.cmb_pacientes.ValueMember = "id";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: El formato de fecha no es válido", "Error", MessageBoxButtons.OK);
            }
        }
        private Entidades.Paciente paciente;


        private void cmb_pacientes_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_pacientes.SelectedItem != null)
                {
                    Entidades.Paciente pa = (Entidades.Paciente)this.cmb_pacientes.SelectedItem;
                    this.paciente = pa;
                    string nombre = pa.Apellido + ", " + pa.Nombre;
                    this.lbl_nombre.Text = nombre;
                    if (Negocio.ABMPaciente.getAllOS(pa).Count > 0)
                    {
                        this.cmb_os.Enabled = true;
                        this.btn_agregarAnalisis.Enabled = true;
                        this.cmb_os.DataSource = Negocio.ABMPaciente.getAllOS(pa);
                        this.cmb_os.DisplayMember = "nombreOS";
                        this.cmb_os.ValueMember = "idOS";
                    }
                    else
                    {
                        this.cmb_os.Enabled = false;
                        this.btn_agregarAnalisis.Enabled = false;
                        this.cmb_os.DataSource = null;
                    }
                }
                else { this.lbl_nombre.Text = ""; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el paciente", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_agregarAnalisis_Click(object sender, EventArgs e)
        {
            bool valido = true;
            try
            {
                if (!txt_fecha.MaskCompleted)
                {
                    valido = false;
                }
                if (valido)
                {
                    Entidades.Examen ex = new Entidades.Examen();
                    ex.Fecha = DateTime.Parse(this.txt_fecha.Text);
                    ex.IdPaciente = (int)cmb_pacientes.SelectedValue;
                    ex.IdOS = (int)cmb_os.SelectedValue;
                    Entidades.Obra_Social os = Negocio.ABMObraSocial.buscarOsPorId(ex.IdOS);
                    float actobioquimico = float.Parse(os.Nbu) * float.Parse(os.ActoBioquimico);
                    ex.ActoBioquimico = actobioquimico.ToString();
                    //Entidades.Examen exa = new Entidades.Examen();
                    ex.Nbu = os.Nbu;
                    //exa = Negocio.ABMExamen.agregarExamen(ex);
                    if (ex != null)
                    {
                        //if (ex.IdExamen != 0)
                        {
                            new AnalisisExamen(ex).ShowDialog();
                        }
                       // else
                        {
                        //    MessageBox.Show("error", "Error", MessageBoxButtons.OK);
                        }
                    }
                }else
                {
                    MessageBox.Show("La fecha ingresada no es válida", "Cuidado!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \nEs probable que el formato de fecha no sea correcto", "Cuidado!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_nuevoPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                new altaPaciente().ShowDialog();
                List<Entidades.Paciente> pacientes = Negocio.ABMPaciente.getAllPacientes();
                this.cmb_pacientes.DataSource = pacientes;
                this.cmb_pacientes.DisplayMember = "dni";
                this.cmb_pacientes.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_nuevaOS_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_pacientes.SelectedItem != null)
                {
                    Entidades.Paciente pa = (Entidades.Paciente)cmb_pacientes.SelectedItem;
                    if (pa != null)
                    {
                        new AgregarOSPAciente(pa).ShowDialog();
                        if (Negocio.ABMPaciente.getAllOS(pa).Count > 0)
                        {
                            this.cmb_os.DataSource = Negocio.ABMPaciente.getAllOS(pa);
                            this.cmb_os.DisplayMember = "nombreOS";
                            this.cmb_os.ValueMember = "idOS";
                            this.cmb_os.Enabled = true;
                            this.btn_agregarAnalisis.Enabled = true;
                        }
                        else
                        {
                            this.cmb_os.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmb_pacientes_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("asd", "asds", MessageBoxButtons.OK);
        }

        private void cmb_pacientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.cmb_pacientes,true,false,true,true);
            }
        }

        private void cmb_os_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.cmb_os, true, false, true, true);
            }
        }
    }
}
