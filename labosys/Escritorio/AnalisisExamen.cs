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
    public partial class AnalisisExamen : Form
    {
        
        BindingSource bs;
        bool cerrar;
        private Entidades.Examen examen;
        List<Entidades.Analisis> analisis= new List<Entidades.Analisis>();
        public AnalisisExamen(Entidades.Examen ex)
        {
            InitializeComponent();
            try
            {
                cerrar = false;
                examen = ex;
                bs = new BindingSource(analisis, "");
                dgv_analisis.DataSource = bs;
                this.cmb_analisis.DataSource = Negocio.ABMAnalisis.getAllAnalisis();
                this.cmb_analisis.DisplayMember = "codigo";
                this.cmb_analisis.ValueMember = "id";
                this.ControlBox = false;
                this.btn_eliminarAnalisis.Enabled = false;
                this.btn_eliminarAnalisis.Visible = false;
                this.btn_guardarCambios.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_agregarAnalisis_Click(object sender, EventArgs e)
        {
            if (analisis.Count >= 0)
            {
                this.btn_eliminarAnalisis.Visible = true;
                this.btn_eliminarAnalisis.Enabled = true;
                this.btn_guardarCambios.Enabled = true;
            }
            if (cmb_analisis.SelectedItem != null)
            {
                Entidades.Analisis ana = (Entidades.Analisis)cmb_analisis.SelectedItem;
                analisis.Add(ana);
                actualizarBinding();
                
            }
            this.ControlBox = true;
        }

        private void cmb_analisis_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_analisis.SelectedItem != null)
                {
                    Entidades.Analisis ana = (Entidades.Analisis)cmb_analisis.SelectedItem;
                    string nombreAnalisis = ana.Nombre;
                    lbl_nombreAnalisis.Text = nombreAnalisis;
                }
            }
            catch
            {
                lbl_nombreAnalisis.Text = "";
            }
        }

        private void btn_guardarCambios_Click(object sender, EventArgs e)
        {
            try
            {

                Entidades.Obra_Social os = Negocio.ABMObraSocial.buscarOsPorId(examen.IdOS);
                float costoTotal=0;
                foreach (Entidades.Analisis ana in analisis)
                {
                    float cantNbu = float.Parse(ana.CantNBU);
                    float nbu = float.Parse(os.Nbu);
                    float costo = nbu * cantNbu;
                    costoTotal =costoTotal + costo;                 
                }
                float costoCubierto = float.Parse(os.Porcentaje)/100 * costoTotal;
                float costoAPagar = costoTotal - costoCubierto;
                 DialogResult resultado =MessageBox.Show(" Monto total: $" + costoTotal +                   
                    "\n Porcentaje cubierto: " + os.Porcentaje + "%"+
                     "\n\n Monto a abonar es: $" + costoAPagar +
                    "\n\n ¿Desea confirmar la operación?", "Confirmar Operación", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    Entidades.Examen exa = new Entidades.Examen();
                    exa = Negocio.ABMExamen.agregarExamen(examen);
                    foreach (Entidades.Analisis ana in analisis)
                    {
                        float cantNbu = float.Parse(ana.CantNBU);
                        float nbu = float.Parse(os.Nbu);
                        float costo = nbu * cantNbu;
                        Negocio.ABMExamen.agregarAnalisisAlExamen(exa, ana, costo);
                    }
                    float actobioquimico = float.Parse(os.Nbu) * float.Parse(os.ActoBioquimico);
                    float costoExamen = costoTotal + actobioquimico;
                    bool exito = Negocio.ABMExamen.agregarCosto(costoExamen, exa);
                    if (exito)
                    {
                        MessageBox.Show("Examen guardado con éxito", "Exito", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        cerrar = true;
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido guardar el exámen", "Fracaso", MessageBoxButtons.OK,MessageBoxIcon.Stop);

                    }
                    this.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_eliminarAnalisis_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataGridViewRow row = this.dgv_analisis.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                Entidades.Analisis ana = new Entidades.Analisis();
                ana.Id = (int)celdas["id"].Value;
                analisis.RemoveAll(x => x.Id == ana.Id);
                actualizarBinding();
                if (analisis.Count == 0)
                {
                    this.btn_eliminarAnalisis.Visible = false;
                    this.btn_eliminarAnalisis.Enabled = false;
                    this.btn_guardarCambios.Enabled = false;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ningun análisis", "Cuidado", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void actualizarBinding()
        {
            try
            {
                bs.ResetBindings(false);
                bs = new BindingSource(analisis, "");
                dgv_analisis.DataSource = bs;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_analisis_Enter(object sender, EventArgs e)
        {
            if (analisis.Count >= 0)
            {
                this.btn_eliminarAnalisis.Visible = true;
                this.btn_eliminarAnalisis.Enabled = true;
            }
            if (cmb_analisis.SelectedItem != null)
            {
                Entidades.Analisis ana = (Entidades.Analisis)cmb_analisis.SelectedItem;
                if (!analisis.Contains(ana))
                {
                    analisis.Add(ana);
                    actualizarBinding();
                }
                else
                {
                    MessageBox.Show("El análisis ya se encuentra cargado", "Cuidado!", MessageBoxButtons.OK);
                }

            }
            this.ControlBox = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new altaAnalisis().ShowDialog();
            this.cmb_analisis.DataSource = Negocio.ABMAnalisis.getAllAnalisis();
            this.cmb_analisis.DisplayMember = "codigo";
            this.cmb_analisis.ValueMember = "id";
        }

        private void cmb_analisis_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.cmb_analisis, true, false, true, true);
            }
        }

        private void btn_agregarAnalisis_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.btn_agregarAnalisis, false, false, true, true);
            }
        }

        private void AnalisisExamen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrar)
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
