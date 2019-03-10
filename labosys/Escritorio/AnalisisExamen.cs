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
        private Entidades.Examen examen;
        List<Entidades.Analisis> analisis= new List<Entidades.Analisis>();
        public AnalisisExamen(Entidades.Examen ex)
        {
            InitializeComponent();
            examen = ex;
            bs = new BindingSource(analisis,"");
            dgv_analisis.DataSource = bs;
            this.cmb_analisis.DataSource = Negocio.ABMAnalisis.getAllAnalisis();
            this.cmb_analisis.DisplayMember = "codigo";
            this.cmb_analisis.ValueMember = "id";
            this.ControlBox = false;
            this.btn_eliminarAnalisis.Enabled = false;
            this.btn_eliminarAnalisis.Visible = false;
        }

        private void btn_agregarAnalisis_Click(object sender, EventArgs e)
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
                    MessageBox.Show("El analisis ya se encuentra cargado", "Cuidado!", MessageBoxButtons.OK);
                }
                
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
                 DialogResult resultado =MessageBox.Show("El monto total es: " + costoTotal +
                    "\n El monto cubierto por la OS es:" + costoCubierto +
                    "\n El monto que el paciente debe abonar es: " + costoAPagar +
                    "\n\n Desea confirmar la operacion?", "Confirmar Operacion", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    foreach (Entidades.Analisis ana in analisis)
                    {
                        float cantNbu = float.Parse(ana.CantNBU);
                        float nbu = float.Parse(os.Nbu);
                        float costo = nbu * cantNbu;
                        Negocio.ABMExamen.agregarAnalisisAlExamen(examen, ana, costo);
                    }
                    float actobioquimico = float.Parse(os.Nbu) * float.Parse(os.ActoBioquimico);
                    float costoExamen = costoTotal + actobioquimico;
                    bool exito = Negocio.ABMExamen.agregarCosto(costoExamen, examen);
                    if (exito)
                    {
                        MessageBox.Show("Examen guardado con exito", "Exito", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido guardar el examen", "Fracaso", MessageBoxButtons.OK);

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
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ningun analisis", "Cuidado", MessageBoxButtons.OK);
            }
        }

        private void actualizarBinding()
        {
            bs.ResetBindings(false);
            bs = new BindingSource(analisis, "");
            dgv_analisis.DataSource = bs;
        }
    }
}
