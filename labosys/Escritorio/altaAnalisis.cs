﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Escritorio
{
    public partial class altaAnalisis : Form
    {
        public altaAnalisis()
        {
            InitializeComponent();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Analisis analisis = new Entidades.Analisis();
                analisis.Codigo = this.txt_codigo.Text;
                analisis.Nombre = this.txt_nombre.Text;
                analisis.CantUG =(this.txt_ug.Text);
                analisis.CantUH = (this.txt_uh.Text);
                analisis.CantNBU =(this.txt_nbu.Text);

                bool exito = Negocio.ABMAnalisis.agregarAnalisis(analisis);
                if (exito)
                {
                    MessageBox.Show("El analisis se agrego exitosamente", "Exito!", MessageBoxButtons.OK);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("El analisis no se pudo dar de alta", "Fracaso", MessageBoxButtons.OK);
                }
               
            }
            catch (Exception k)
            {
                MessageBox.Show("Ha ocurrido un error", "Fracaso", MessageBoxButtons.OK);
            }
        }
    }
    
}