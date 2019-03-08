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
    public partial class OSPaciente : Form
    {
        BindingSource bs;
        Entidades.Paciente paciente;
        public OSPaciente(Entidades.Paciente pa)
        {
            InitializeComponent();
            this.gb_paciente.Text = pa.Apellido + ", " + pa.Nombre;
            bs = new BindingSource(Negocio.ABMPaciente.getAllOS(pa), "");
            paciente = pa;
            this.dgv_ospacientes.DataSource = bs;
        }

        private void btn_agregarOSPaciente_Click(object sender, EventArgs e)
        {
            new AgregarOSPAciente(paciente).ShowDialog();
            this.dgv_ospacientes.DataSource = Negocio.ABMPaciente.getAllOS(paciente);
        }
    }
}