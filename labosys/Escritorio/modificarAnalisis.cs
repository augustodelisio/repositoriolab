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
    public partial class modificarAnalisis : Form
    {
        int id;
        public modificarAnalisis(Entidades.Analisis analisis)
        {
            InitializeComponent();
            this.txt_codigo.Text = analisis.Codigo;
            this.txt_nombre.Text = analisis.Nombre;
            this.txt_ug.Text = analisis.CantUG;
            this.txt_uh.Text = analisis.CantUH;
            this.txt_nbu.Text = analisis.CantNBU;
            id = analisis.Id;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Analisis analisis = new Entidades.Analisis();
                analisis.Codigo = this.txt_codigo.Text;
                analisis.Nombre = this.txt_nombre.Text;
                analisis.CantUG = (this.txt_ug.Text);
                analisis.CantUH = (this.txt_uh.Text);
                analisis.CantNBU = (this.txt_nbu.Text);
                analisis.Id = id;

                bool exito = Negocio.ABMAnalisis.modificarAnalisis(analisis);
                if (exito)
                {
                    MessageBox.Show("El analisis se modifico exitosamente", "Exito!", MessageBoxButtons.OK);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("El analisis no se pudo modificar", "Fracaso", MessageBoxButtons.OK);
                }

            }
            catch (Exception k)
            {
                MessageBox.Show("Ha ocurrido un error", "Fracaso", MessageBoxButtons.OK);
            }
        }
    }
}
